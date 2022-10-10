using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;

namespace Nicsure.Altair8800.Hardware
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public enum SerialCardType
    {
        SIO, SIO2
    }

    public class SerialController : IInputDevice, IOutputDevice, IResettable
    {
        public String DeviceName { get; }
        public int ControlPort { get; }
        public int DataPort { get; }
        public Action<SerialController> CallBack { get; set; }
        public bool Available { get => toUserBuffer.Avail(); }
        public bool ClearToSend { get => toCpuBuffer.HasRoom(); }

        private readonly ByteBuffer toCpuBuffer = new (true);
        private readonly ByteBuffer toUserBuffer = new (false);
        private readonly bool sio2;
        private bool rxInterruptEnabled = false;
        private bool rxInterruptRequest = false;

        public SerialController(SerialCardType type, int controlPort, int dataPort)
        {
            ControlPort = controlPort;
            DataPort = dataPort;
            switch (type)
            {
                case SerialCardType.SIO:
                    sio2 = false;
                    DeviceName = "88-SIO";
                    break;
                case SerialCardType.SIO2:
                    sio2 = true;
                    DeviceName = "88-2SIO";
                    break;
            }
        }

        private int[] Ports() => new int[] { ControlPort, DataPort };
        public int[] GetInputPorts() => Ports();
        public int[] GetOutputPorts() => Ports();

        public SerialController(SerialCardType type, int controlPort, int dataPort, Action<SerialController> callBack) : this(type, controlPort, dataPort)
        {
            CallBack = callBack;
        }

        public override string ToString() => DeviceName;

        public virtual int RequestRead(int port)
        {
            if (port == ControlPort)
            {
                if (sio2)
                    return
                        (rxInterruptRequest ? 0x80 : 0) +
                        (toUserBuffer.HasRoom() ? 2 : 0) +
                        (toCpuBuffer.Avail() ? 1 : 0);
                else
                    return (toUserBuffer.HasRoom() ? 0 : 128) + (toCpuBuffer.Avail() ? 34 : 3);
            }
            else if (port == DataPort)
            {
                rxInterruptRequest = false;
                return toCpuBuffer.Avail() ? toCpuBuffer.Get() : 0;
            }
            return 0;
        }

        public virtual void RequestWrite(int port, int val)
        {
            if (port == ControlPort)
            {
                if ((val & 3) == 3) { val = 0; }
                rxInterruptEnabled = (val & 0x80) != 0;
            }
            else if (port == DataPort)
            {
                toUserBuffer.Add(val);
                CallBack?.Invoke(this);
            }
        }

        public virtual int Get() => toUserBuffer.Get();

        public virtual byte[] GetAll() => toUserBuffer.GetAll();

        public virtual void Send(int byt)
        {
            toCpuBuffer.Add(byt);
            if (rxInterruptEnabled && !rxInterruptRequest)
            {
                rxInterruptRequest = true;
                Mon.Msg(1, 7);
            }
        }

        public void Reset()
        {
            toUserBuffer.Reset();
            toCpuBuffer.Reset();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }

    public class ByteBuffer
    {
        private readonly byte[] buffer = new byte[4096];
        private long readPos = 0, writePos = 0;
        private readonly bool blockWhenFull = false;

        public ByteBuffer(bool fullBlock) => blockWhenFull = fullBlock;

        public void Add(int byt)
        {
            int timeOut = 0;
            while (true)
            {
                lock (buffer)
                {
                    if (HasRoom())
                    {
                        buffer[writePos++ & 0xfff] = (byte)byt;
                        return;
                    }
                }
                if (!blockWhenFull) break;
                if (timeOut++ == 50)
                {
                    Mon.Wrn("Serial device is locked. Attempting to reset, serial data will be lost.");
                    Reset();
                }
                if (timeOut > 200)
                {
                    Mon.Err("Unable to unlock serial device.");
                    Mon.Msg(0, 0);
                    break;
                }
                Thread.Sleep(10);
            }
        }

        public int Get()
        {
            lock (buffer)
            {
                return Avail() ? buffer[readPos++ & 0xfff] : 0;
            }
        }

        public byte[] GetAll()
        {
            lock (buffer)
            {
                int len = (int)(writePos - readPos);
                byte[] b = new byte[len];
                for (int i = 0; i < len; i++)
                    b[i] = (byte)buffer[(readPos + i) & 0xffff];
                Reset();
                return b;
            }
        }

        public void Reset()
        {
            lock (buffer)
            {
                readPos = 0;
                writePos = 0;
            }
        }

        public bool Avail()
        {
            lock (buffer)
            {
                if (writePos > readPos)
                    return true;
                Reset();
                return false;
            }
        }

        public bool HasRoom()
        {
            lock (buffer)
            {
                return writePos - readPos < 0xffe;
            }
        }

    }

}