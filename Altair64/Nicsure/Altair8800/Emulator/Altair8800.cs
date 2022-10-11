using Altair64.Project;
using Nicsure.Altair8800.Hardware;
using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;
using Nicsure.Intel8080;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Code by nicsure (C)2022
// https://www.youtube.com/nicsure

namespace Nicsure.Altair8800.Emulator
{
    public static class Altair8800
    {
        delegate void PortOutCallbackDelegate(byte port, byte data);
        delegate byte PortInCallbackDelegate(byte port);
        delegate void StatusCallbackDelegate(IntPtr statusPtr, IntPtr statePtr, bool running);

        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Init(
            PortInCallbackDelegate portInCbPtr,
            PortOutCallbackDelegate portOutCbPtr,
            StatusCallbackDelegate statusCbPtr,
            ushort speed
        );
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Start();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void ShutDown();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Speed(ushort speed);
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Run();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Stop();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Step();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Reset();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void HardReset();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern IntPtr State();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Interrupt(byte vector);
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern byte Examine(ushort addr);
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void Deposit(ushort addr, byte data);
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern void SetDoStatus(bool doStatus);
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern bool IsRunning();
        [DllImport("Intel8080.dll", CharSet = CharSet.Ansi)] private static extern int TestDLL();

        public static ComboBox InputChoice { get; set; } = null;
        public static ComboBox OutputChoice { get; set; } = null;
        public static IStatusReadout StatusReadout { get; set; } = null;
        public static bool Running => IsRunning();
        public static long NanosPerTS { get; private set; } = 500;

        private static byte switches = 0;
        private static readonly Dictionary<int, IInputDevice> inputDevices = new();
        private static readonly Dictionary<int, IOutputDevice> outputDevices = new();
        private static readonly List<IResettable> resettableDevices = new();
        private static readonly List<ISendToAble> sendToDevices = new();
        private static readonly List<ICapturable> captureDevices = new();
        private static readonly List<IShutDownAble> shutDownDevices = new();
        private static Thread initThread = null;
        private static readonly byte[] status = new byte[140];
        private static readonly byte[] state = new byte[0x10100];
        public static byte[] MachineState => state;

        // We need to keep perm references to the callback delegates which are passed to the DLL.
        // Just passing the methods directly creates temporary delegate objects that eventually
        // get clobbered by the garbage collector because it doesn't know the DLL still needs them.
        private static readonly PortOutCallbackDelegate PortOutCallback = PortOut;
        private static readonly PortInCallbackDelegate PortInCallback = PortIn;
        private static readonly StatusCallbackDelegate StatusCallback = StatusIn;

        private static int ParseHex(String s) => int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);

        public static int WriteRam(byte[] data, int toAddr)
        {
            GetState(true);
            int len = data.Length;
            Array.Copy(data, 0, state, toAddr + 0x100, len);
            SetState(true);
            return len;
        }

        public static byte[] ReadRam(int fromAddr, int len)
        {
            byte[] r = new byte[len];
            GetState(true);
            Array.Copy(state, fromAddr + 0x100, r, 0, len);
            return r;
        }

        public static void DoStatus(bool b) => SetDoStatus(b);

        public static int ReadByte(int addr) => Examine((ushort)addr);

        public static void WriteByte(int addr, int data) => Deposit((ushort)addr, (byte)data);

        public static void InterruptReq(int vector) => Interrupt((byte)vector);

        public static void StepCycle() => Step();

        public static void RunMode() => Run();

        public static void StepMode()
        {
            GC.Collect();
            Stop();
        }

        public static void SetSpeed(long speed)
        {
            NanosPerTS = speed;
            Speed((ushort)speed);
        }

        public static int LoadHex(String hex)
        {
            GetState(true);
            int addr = -1;
            String[] lines = hex
                .Replace(" ", "")
                .Replace("\t", "")
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace(':', ' ')
                .Trim()
                .ToUpper()
                .Split(' ');
            try
            {
                foreach (String line in lines)
                {
                    if (line.Length >= 8 && Regex.IsMatch(line, @"\A\b[0-9A-F]+\b\Z"))
                    {
                        int len = ParseHex(line[..2]);
                        if (len > 0 && line.Length == len * 2 + 10)
                        {
                            int loc = ParseHex(line.Substring(2, 4));
                            if (addr == -1) addr = loc;
                            for (int i = 0; i < len; i++)
                            {
                                byte byt = (byte)ParseHex(line.Substring(i * 2 + 8, 2));
                                state[loc++ + 0x100] = byt;
                            }
                        }
                    }
                }
            }
            catch (Exception) { addr = -1; }
            if (addr == -1)
                Mon.Err("Cannot parse hex file.");
            else
                SetState(true);
            return addr;
        }

        public static void SetSwitch(int swNum_, bool val)
        {
            byte swNum = (byte)(swNum_ % 8);
            byte bit = (byte)(1 << swNum);
            switches |= bit;
            if (!val)
                switches ^= bit;
        }

        public static bool GetSwitch(int swNum_)
        {
            byte swNum = (byte)(swNum_ % 8);
            byte bit = (byte)(1 << swNum);
            return (int)(switches & bit) != 0;
        }

        public static void RegisterDevice(object device)
        {
            if (device is IInputDevice inputDevice)
            {
                if (device is ISendToAble sendToDevice && !sendToDevices.Contains(sendToDevice))
                {
                    sendToDevices.Add(sendToDevice);
                    InputChoice?.Items.Add(new ComboUIChoice(inputDevice.DeviceName, sendToDevice));
                }
                foreach (int port in inputDevice.GetInputPorts())
                    inputDevices[port] = inputDevice;
            }
            if (device is IOutputDevice outputDevice)
            {
                if (device is ICapturable captureDevice && !captureDevices.Contains(captureDevice))
                {
                    captureDevices.Add(captureDevice);
                    OutputChoice?.Items.Add(new ComboUIChoice(outputDevice.DeviceName, captureDevice));
                }
                foreach (int port in outputDevice.GetOutputPorts())
                    outputDevices[port] = outputDevice;
            }
            if (device is IResettable resettable && !resettableDevices.Contains(resettable))
                resettableDevices.Add(resettable);
            if (device is IShutDownAble shutDownable && !shutDownDevices.Contains(shutDownable))
                shutDownDevices.Add(shutDownable);
        }

        public static void Initialize()
        {
            if (initThread != null)
            {
                Mon.Log("CPU Emulator is already initialized.");
            }
            else
            {
                StatusReadout.MonitorWindow.SetState(state);
                initThread = Thread.CurrentThread;
                Init(PortInCallback, PortOutCallback, StatusCallback, 500);
                Task task = Task.Run(() => {
                    Start();
                    foreach (IShutDownAble shutDownable in shutDownDevices)
                        shutDownable.ShutDown();
                });
                initThread = null;
            }
        }

        public static void CloseDown()
        {
            if (initThread == null)
            {
                Mon.Log("CPU Emulator is not Initialized.");
            }
            else
            {
                if (initThread != Thread.CurrentThread)
                {
                    Mon.Log("CPU Emulator must be shutdown from the same thread that initialized it.");
                }
                else
                {
                    ShutDown();
                }
            }
        }

        public static void PerformReset(bool hard)
        {
            if (hard) HardReset(); else Reset();
            foreach (IResettable resettable in resettableDevices)
                resettable.Reset();
        }

        public static byte PortIn(byte port)
        {
            switch (port)
            {
                default:
                    if (inputDevices.ContainsKey(port))
                        return (byte)inputDevices[port].RequestRead(port);
                    else
                        Mon.Log("Unhandled IN Port:" + port.X2(), 10);
                    break;
                case 0xFF: // front switches
                    return switches;
            }
            return 0;
        }

        public static void PortOut(byte port, byte val)
        {
            switch (port)
            {
                default:
                    if (outputDevices.ContainsKey(port))
                        outputDevices[port].RequestWrite(port, val);
                    else
                        Mon.Log("Unhandled OUT Port:" + port.X2() + " Val:" + val.X2(), 10);
                    break;
            }
        }

        public static void SetReg(int reg, int val, bool b16)
        {
            state[reg] = (byte)(val & 0xff);
            if(b16) state[reg + 1] = (byte)((val & 0xff00) >> 8);
        }

        public static IntPtr GetState(bool full = false)
        {
            IntPtr statePtr = State();
            Marshal.Copy(statePtr, state, 0, full ? 0x10100 : 24);
            return statePtr;
        }

        public static void SetState(bool full = false)
        {
            IntPtr statePtr = State();
            Marshal.Copy(state, 0, statePtr, full ? 0x10100 : 24);
        }


        private static int SINT(int i) =>
            status[i] | (status[i + 1] << 8) | (status[i + 2] << 16) | (status[i + 3] << 24);

        private static int SWORD(int i) =>
            state[i] | (state[i + 1] << 8);

        public static void StatusIn(IntPtr statusPtr, IntPtr statePtr, bool running)
        {
            Marshal.Copy(statusPtr, status, 0, 140);
            Marshal.Copy(statePtr, state, 0, running ? 24 : 0x10100);
            IStatusReadout readout = StatusReadout;
            if (readout == null) return;
            int total = SINT(136);
            for (int i = 0; i < 16; i++)
            {
                int i4 = i << 2;
                readout.AddressLEDs[i].UpdatePWM(SINT(i4));
                if (i < 10)
                {
                    readout.StatusLEDs[i].UpdatePWM(SINT(i4 + 96));
                    if (i < 8)
                    {
                        readout.DataLEDs[i].UpdatePWM(SINT(i4 + 64));
                    }
                }
            }
            Mon.Invoke(() => {
                for (int i = 0; i < 16; i++)
                {
                    int i4 = i << 2;
                    readout.AddressLEDs[i].Display(total);
                    if (i < 10)
                    {
                        readout.StatusLEDs[i].Display(total);
                        if (i < 8)
                        {
                            readout.DataLEDs[i].Display(total);
                        }
                    }
                }
                readout.BC.Value = SWORD(0);
                readout.DE.Value = SWORD(2);
                readout.HL.Value = SWORD(4);
                readout.SP.Value = SWORD(8);
                readout.PC.Value = SWORD(10);
                readout.IV.Value = state[12];
                readout.A.Value = state[7];
                int F = state[6];
                readout.CF.Checked = (F & 1) != 0;
                readout.PF.Checked = (F & 4) != 0;
                readout.HF.Checked = (F & 16) != 0;
                readout.ZF.Checked = (F & 64) != 0;
                readout.SF.Checked = (F & 128) != 0;
                readout.HLT.Checked = state[20] != 0;
                readout.EI.Checked = state[16] != 0;
                readout.IRQ.Checked = state[13] != 0;
                if (!running)
                    readout.MonitorWindow.SetAddress(SWORD(10));
            });
        }
    }
}
