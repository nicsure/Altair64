using NAudio.MediaFoundation;
using Nicsure.Altair8800;
using Nicsure.Altair8800.Emulator;
using Nicsure.Altair8800.Hardware;
using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.CustomControls;
using Nicsure.General;
using Nicsure.Intel8080;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using static System.Windows.Forms.AxHost;

namespace Altair64.Project
{
    public partial class UI : Form, IStatusReadout, IInvokable
    {
        // Code by nicsure (C)2022
        // https://www.youtube.com/nicsure

        private static UI ui;
        private DiskController diskController;
        private Modem modem;
        private ComboUIChoice activeCapture = null;
        private TapeController tapeController;
        private SIOController sioController;
        private int lastCaptured;
        private IPWM[] addressLEDs;
        private IPWM[] dataLEDs;
        private IPWM[] statusLEDs;
        private FrontSwitch[] frontSwitches;
        private bool canInvoke = true;
        private readonly static string[] nullFile = { null };
        private Monitor monitor;
        public IPWM[] AddressLEDs => addressLEDs;

        public IPWM[] DataLEDs => dataLEDs;

        public IPWM[] StatusLEDs => statusLEDs;

        public Monitor MonitorWindow => monitor;

        public byte[] EmuState { get; set; }

        public NumericUpDown BC => NUD_BC;
        public NumericUpDown DE => NUD_DE;
        public NumericUpDown HL => NUD_HL;
        public NumericUpDown SP => NUD_SP;
        public NumericUpDown PC => NUD_PC;
        public NumericUpDown IV => NUD_IV;
        public NumericUpDown A => NUD_A;
        public CheckBox CF => CB_CF;
        public CheckBox PF => CB_PF;
        public CheckBox HF => CB_HF;
        public CheckBox ZF => CB_ZF;
        public CheckBox SF => CB_SF;
        public CheckBox HLT => CB_HLT;
        public CheckBox EI => CB_EI;
        public CheckBox IRQ => CB_IRQ;

        public Control Invoker => this;

        public bool CanInvoke => canInvoke;

        public bool IsRunning => SW_RunStop.Checked;

        private enum DiskControl { BUTTON, EJECT, LABEL }

        public UI()
        {
            InitializeComponent();            
        }

        private Preset GetPreset(bool state)
        {
            Preset p = new()
            {
                Speed = (int)NUD_Speed.Value,
                Status = CB_DoStatus.Checked,
            };
            for (int i = 0; i < 16; i++)
            {
                if (i < 8)
                    p.Switches[i] = Altair8800.GetSwitch(i);
                p.Disks[i] = ui.diskController.DiskFiles[i];
            }
            p.Terminal[0] = Terminal.Irq;
            p.Terminal[1] = Terminal.Bel;
            p.Terminal[2] = Terminal.Flash;
            p.Terminal[3] = Terminal.Telnet;
            p.Terminal[4] = Terminal.Cls;
            p.Terminal[5] = Terminal.BasicBackspace;
            p.Terminal[6] = Terminal.Echo;
            p.Terminal[7] = Terminal.LF;
            if (state)
            {
                p.State = new byte[0x10100];
                Altair8800.GetState(true);
                Array.Copy(Altair8800.MachineState, 0, p.State, 0, 0x10100);
            }
            return p;
        }

        private void SetPreset(Preset p, bool run)
        {
            Altair8800.PerformReset(true);
            NUD_Speed.Value = p.Speed;
            Altair8800.SetSpeed(p.Speed);
            CB_DoStatus.Checked = p.Status;
            Altair8800.DoStatus(p.Status);
            for (int i = 0; i < 16; i++)
                diskController.InsertDiskImage(i, null, false);
            for (int i = 0; i < 16; i++)
            {
                if (i < 8)
                {
                    Altair8800.SetSwitch(i, p.Switches[i]);
                    frontSwitches[i].Checked = p.Switches[i];
                }
                bool ram = false;
                string disk = p.Disks[i];
                if (disk != null && !disk.Equals("null") && disk.Length > 0)
                {
                    if (disk.StartsWith("RAM:"))
                    {
                        ram = true;
                        disk = disk[4..];
                    }
                    if (disk.Equals("null"))
                        disk = null;
                    diskController.InsertDiskImage(i, disk, ram);
                }
                if (i < 4)
                    ui.UpdateDiskName(i);
            }
            Terminal.Irq = p.Terminal[0];
            Terminal.Bel = p.Terminal[1];
            Terminal.Flash = p.Terminal[2];
            Terminal.Telnet = p.Terminal[3];
            Terminal.Cls = p.Terminal[4];
            Terminal.BasicBackspace = p.Terminal[5];
            Terminal.Echo = p.Terminal[6];
            Terminal.LF = p.Terminal[7];
            if(p.State != null)
            {
                Array.Copy(p.State, 0, Altair8800.MachineState, 0, p.State.Length);
                Altair8800.SetState(true);
            }
            if(run)
            {
                SW_RunStop.Checked = true;
                Altair8800.RunMode();
            }
        }

        private void Init()
        {
            Mon.Invoker = this;
            addressLEDs = new IPWM[] { LEDa0, LEDa1, LEDa2, LEDa3 , LEDa4, LEDa5, LEDa6, LEDa7, LEDa8, LEDa9, LEDa10, LEDa11, LEDa12, LEDa13, LEDa14, LEDa15 };
            dataLEDs = new IPWM[] { LEDd0, LEDd1, LEDd2, LEDd3, LEDd4, LEDd5, LEDd6, LEDd7 };
            statusLEDs = new IPWM[10];
            statusLEDs[(int)StatusLED.HLT] = LED_HLT;
            statusLEDs[(int)StatusLED.WO] = LED_WO;
            statusLEDs[(int)StatusLED.OUT] = LED_OUT;
            statusLEDs[(int)StatusLED.WAIT] = LED_WAIT;
            statusLEDs[(int)StatusLED.IN] = LED_IN;
            statusLEDs[(int)StatusLED.STK] = LED_STK;
            statusLEDs[(int)StatusLED.IE] = LED_IE;
            statusLEDs[(int)StatusLED.M1] = LED_M1;
            statusLEDs[(int)StatusLED.INT] = LED_INT;
            statusLEDs[(int)StatusLED.RM] = LED_RM;
            frontSwitches = new FrontSwitch[] { SW_A0, SW_A1, SW_A2, SW_A3, SW_A4, SW_A5, SW_A6, SW_A7 };
            Altair8800.StatusReadout = this;
            Mon.LogReceiever = MonitorLog;
            Mon.MsgReceiever = MonitorMessage;
            ui = this;
            Altair8800.InputChoice = COMBO_SendToDevices;
            Altair8800.OutputChoice = COMBO_CaptureDevices;
            Altair8800.SetSwitch(8, true);
            Altair8800.SetSwitch(12, true);
            sioController = new SIOController();
            modem = new Modem();
            diskController = new DiskController(8);
            tapeController = new TapeController();
            diskController.DriveLEDs = new Control[] { LED_Drive0, LED_Drive1, LED_Drive2, LED_Drive3 };
            Altair8800.RegisterDevice(modem);
            Altair8800.RegisterDevice(diskController);
            Altair8800.RegisterDevice(tapeController);
            Altair8800.RegisterDevice(Terminal);
            Altair8800.RegisterDevice(sioController);
            InitFrontSwitches();
            Mon.WatchDog(false);
            ReportSpeed();
            Altair8800.Initialize();
        }

        private void InitFrontSwitches()
        {
            for (int i = 0; i < 8; i++)
            {
                frontSwitches[i].Checked = Altair8800.GetSwitch(i);
            }
        }

        private void CaptureState()
        {
            ComboUIChoice ac = activeCapture;
            if (ac != null)
            {
                int captured = ac.Capturable.Captured;
                if (captured > lastCaptured)
                {
                    lastCaptured = captured;
                    Mon.Log("Bytes captured from " + ac.ToString() + ": " + lastCaptured);
                }
            }
        }

        private static void Append(TextBox tb, String s) => Mon.Invoke(() => tb.AppendText(s));

        private static void MonitorLog(String s) { Append(ui.TBOX_Monitor, s + "\r\n"); }

        private void MonitorMessage(int i1, int i2)
        {
            switch (i1)
            {
                case 0: // errors
                    switch (i2)
                    {
                        case 0: // fatal error
                            Altair8800.PerformReset(true);
                            Mon.Err("FATAL: Performing Hard Reset");
                            break;
                    }
                    break;
                case 1: // interrupt
                    Altair8800.InterruptReq(0xc7 | (i2 << 3));
                    break;
            }
        }

        private void BUT_Step_Click(object sender, EventArgs e)
        {
            if (!Altair8800.Running)
            {
                Altair8800.StepCycle();
            }
        }

        private void BUT_Run_Click(object sender, EventArgs e)
        {
            if (SW_RunStop.Checked)
            {
                if (!Altair8800.Running)
                {
                    //stateTimer.Start();
                    Mon.Log("SYSTEM STARTED");
                    Altair8800.RunMode();
                }
            }
            else
                StopRuntime();
        }

        private static void WriteBytesToInterface(ISendToAble userInterface, byte[] data)
        {
            Mon.Run(() =>
            {
                foreach (byte b in data)
                {
                    userInterface.Send(b);
                }
                Mon.Log(data.Length + " bytes sent");
            });
        }

        private static void ButtonHighlight(HButton button, bool highlight, int which = 0)
            => button.Highlight(which, highlight);

        private void BUT_Load_Click(object sender, EventArgs e)
        {
            if (COMBO_SendToDevices.SelectedIndex != -1)
            {
                if (COMBO_SendToDevices.SelectedItem.ToString() == "Cassette" && tapeController.Audio && !tapeController.Modulating)
                {
                    if (tapeController.Listening)
                    {
                        tapeController.StopListening();
                        ButtonHighlight(BUT_Load, false);
                    }
                    else
                    {
                        tapeController.StartListening();
                        ButtonHighlight(BUT_Load, true);
                    }
                    return;
                }
                ComboUIChoice uis = (ComboUIChoice)COMBO_SendToDevices.SelectedItem;
                String file = OpenFile("Select file to send to interface", "TAP", "BAS", "TXT", "BIN");
                if (file != null)
                    WriteBytesToInterface(uis.UserInterface, Mon.ReadAllBytes(file));
            }
        }

        private static void ToggleButtonTag(Button button)
        {
            String tmp = button.Text;
            button.Text = button.Tag.ToString();
            button.Tag = tmp;
        }

        private void BUT_Capture_Click(object sender, EventArgs e)
        {
            if (activeCapture != null)
            {
                ButtonHighlight(BUT_Capture, false);
                Mon.Log("Stopped capture of data from " + activeCapture.ToString());
                ToggleButtonTag(BUT_Capture);
                CaptureState();
                byte[] captured = activeCapture.Capturable.StopCapture();
                if (captured == null || captured.Length == 0)
                    Mon.Log("No Data Captured From " + activeCapture.ToString());
                else
                {
                    String file = SaveFile("Select file to save captured data to", "TAP", "TXT", "BIN", "BAS");
                    if (file != null)
                        Mon.WriteAllBytes(file, captured);
                }
                activeCapture = null;
            }
            else
            if (COMBO_CaptureDevices.SelectedIndex != -1)
            {
                ButtonHighlight(BUT_Capture, true);
                lastCaptured = 0;
                activeCapture = (ComboUIChoice)COMBO_CaptureDevices.SelectedItem;
                ToggleButtonTag(BUT_Capture);
                Mon.Log("Starting capture of data from " + activeCapture.ToString());
                activeCapture.Capturable.StartCapture();
            }
        }

        private void CB_Debug_CheckedChanged(object sender, EventArgs e)
        {
            Mon.LogLevel = CB_Debug.Checked ? 10 : 1;
            Mon.Log("Debug Level: " + Mon.LogLevel);
        }

        private void BUT_BinLoad_Click(object sender, EventArgs e)
        {
            String file = OpenFile("Select binary file to write to RAM", "BIN");
            int addr = (int)NUD_BinLoadAddr.Value;
            if (file != null)
            {
                byte[] b = Mon.ReadAllBytes(file);
                if (addr + b.Length > 65536)
                    Mon.Err("Binary File '" + OFD_Load.SafeFileName + "' is too big (" + b.Length + " bytes) to be loaded at addresss " + addr);
                else
                {
                    Altair8800.WriteRam(Mon.ReadAllBytes(file), addr);
                    Mon.Log("Binary File '" + OFD_Load.SafeFileName + "' loaded to:" + addr.X4() + " Length:" + b.Length);
                }
            }
        }

        private void StopRuntime()
        {
            Altair8800.StepMode();
            SW_RunStop.Checked = false;
            Mon.Log("SYSTEM STOPPED");
        }

        private void BUT_Reset_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
                Altair8800.PerformReset(false);
            else
            {
                Altair8800.PerformReset(true);
                SW_RunStop.Checked = false;
            }
        }

        private void BUT_LoadHex_Click(object sender, EventArgs e)
        {
            String[] files = OpenFiles("Select HEX file(s) to load into RAM", "HEX");
            if (files[0] != null)
            {
                int lowaddr = 0x10000, addr;
                foreach (String file in files)
                {
                    addr = Altair8800.LoadHex(Mon.ReadAllText(file));
                    if (addr != -1)
                    {
                        if (addr < lowaddr) lowaddr = addr;
                        Mon.Log("Hex File '" + FileOnly(file) + "' loaded to " + addr.X4());
                    }
                }
                if (lowaddr < 0x10000) NB_FPAddress.Value = lowaddr;                
            }
        }

        private static string FileOnly(string path) => path[(path.LastIndexOf(Path.DirectorySeparatorChar) + 1)..];

        private void BUT_Disk_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button button = (Button)sender;
                int drive = Convert.ToInt32(button.Tag);
                button.ContextMenuStrip.Items[0].Text = "Disk in Drive " + drive;
                button.ContextMenuStrip.Items[1].Text = diskController.DiskNames[drive] ?? "[NONE]";
            }
        }

        private Control GetDiskControl(int diskNo, DiskControl c)
        {
            return c switch
            {
                DiskControl.EJECT => diskNo switch
                {
                    1 => BUT_Eject1,
                    2 => BUT_Eject2,
                    3 => BUT_Eject3,
                    _ => BUT_Eject0,
                },
                DiskControl.LABEL => diskNo switch
                {
                    1 => TTB_DiskName1,
                    2 => TTB_DiskName2,
                    3 => TTB_DiskName3,
                    _ => TTB_DiskName0,
                },
                _ => diskNo switch
                {
                    1 => BUT_Disk1,
                    2 => BUT_Disk2,
                    3 => BUT_Disk3,
                    _ => BUT_Disk0,
                },
            };
        }

        private void CMS_DiskOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clicked = e.ClickedItem;
            Button button = (Button)((ContextMenuStrip)sender).SourceControl;
            CMS_DiskOptions.Hide();
            int drive = Convert.ToInt32(button.Tag);
            if (clicked == TSMI_MountImage) Disk_Button_Clicked(button, e);
            else
            if (clicked == TSMI_Eject)
                Disk_Button_Clicked(GetDiskControl(drive, DiskControl.EJECT), e);
            else
            if (clicked == TSMI_MountRAM) Disk_Button_Clicked(button, null);
            else
            if (clicked == TSMI_ConvertRAM)
            {
                String file = SaveFile("Select the file you wish the RAM Mirrored disk coverted to", "DSK");
                if (file != null)
                {
                    if (!diskController.ConvertToPhysicalDisk(drive, file))
                        Mon.Err("The drive either did not contain a RAM Mirrored disk or there was an issue writing the disk data to the file you selected.");
                    else
                    {
                        Mon.Log("RAM Mirrored Disk conversion complete.");
                        UpdateDiskName(drive);
                    }
                }
            }
            else
            if (clicked == TSMI_MountBlank)
            {
                diskController.InsertDiskImage(drive, "*BLANK", true);
                UpdateDiskName(drive);
            }
        }

        public void UpdateDiskName(int dnum)
        {
            String name = diskController.DiskNames[dnum] ?? "(Empty)";
            ((Button)GetDiskControl(dnum, DiskControl.LABEL)).Text = name;
            ButtonHighlight(
                (HButton)GetDiskControl(dnum, DiskControl.BUTTON),
                diskController.IsPopulated(dnum),
                diskController.IsRamMirror(dnum) ? 1 : 0
            );
        }

        private void Disk_Button_Clicked(object sender, EventArgs e)
        {
            int diskNo = Convert.ToInt32(((Button)sender).Tag);
            if (diskNo <= 3)
            {
                String file = OpenFile("Select disk image to insert in drive " + diskNo, "DSK");
                if (file != null)
                {
                    if (diskController.InsertDiskImage(diskNo, file, e == null))
                    {
                        Mon.Log("Disk image '" + OFD_Load.SafeFileName + "' inserted into drive " + diskNo);
                        UpdateDiskName(diskNo);
                        return;
                    }
                    else
                        Mon.Err("Unable to open disk file: " + file);
                }
            }
            else
            {
                diskNo %= 10;
                diskController.InsertDiskImage(diskNo, null);
                Mon.Log("Disk in drive " + diskNo + " ejected");
                UpdateDiskName(diskNo);
            }
        }

        private void UI_Shown(object sender, EventArgs e)
        {
            FormBorderStyle fbs = this.FormBorderStyle;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = MainPanel.Width;
            this.Height = MainPanel.Height;
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.FormBorderStyle = fbs;
            monitor = new()
            {
                TopLevel = false,
                Visible = false,
                Size = TBOX_Monitor.Size,
                Location = TBOX_Monitor.Location,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right
            };
            monitor.Init();
            MainPanel.Controls.Add(monitor);
            BUT_Commit.Visible = false;
            this.Init();
            Terminal.Init();
            tapeController.FuncIndicator = LED_Cassette;
            tapeController.DataIndicator = LED_CassetteData;

        }

        private String[] OpenFiles(String title, params String[] ext) => OpenOrSaveFile(title, false, ext, true);
        private String OpenFile(String title, params String[] ext) => OpenOrSaveFile(title, false, ext)[0];
        private String SaveFile(String title, params String[] ext) => OpenOrSaveFile(title, true, ext)[0];

        private String[] OpenOrSaveFile(String title, bool save, String[] ext, bool multi = false)
        {
            OFD_Load.Multiselect = multi && !save;
            FileDialog dialog = save ? (FileDialog)SFD_Save : (FileDialog)OFD_Load;
            dialog.Title = title;
            String filt = String.Empty;
            foreach (String e in ext)
                filt += e + " Files(*." + e + ")|*." + e + "|";
            filt += "All Files(*.*) | *.*";
            dialog.Filter = filt;
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (!OFD_Load.Multiselect)
                {
                    if (save || File.Exists(OFD_Load.FileName))
                        return new string[] { dialog.FileName };
                }
                else
                {
                    foreach(string f in OFD_Load.FileNames)
                    {
                        if (!File.Exists(f))
                            return nullFile;
                    }
                    return OFD_Load.FileNames;
                }
            }
            return nullFile;
        }

        private void UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            canInvoke = false;
            Mon.WatchDog(true);
            Altair8800.CloseDown();
            e.Cancel = true;
            Invoke(CloseDown);
        }

        private void CloseDown()
        {
            FormClosing -= UI_FormClosing;
            Close();
        }

        private void FrontSwitch_Changed(object sender, EventArgs e)
        {
            FrontSwitch sw = (FrontSwitch)sender;
            int swNum = Convert.ToInt32(sw.Tag);
            Altair8800.SetSwitch(swNum, sw.Checked);
        }

        private void Terminal_Option_Clicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int i = Convert.ToInt32(label.Tag);
            bool b = false;
            switch (i)
            {
                case 0:
                    b = (Terminal.Irq = !Terminal.Irq);
                    break;
                case 1:
                    b = (Terminal.Bel = !Terminal.Bel);
                    break;
                case 2:
                    b = (Terminal.Flash = !Terminal.Flash);
                    break;
                case 3:
                    b = (Terminal.Telnet = !Terminal.Telnet);
                    break;
                case 4:
                    b = (Terminal.Cls = !Terminal.Cls);
                    break;
                case 5:
                    b = (Terminal.BasicBackspace = !Terminal.BasicBackspace);
                    break;
                case 6:
                    b = (Terminal.Echo = !Terminal.Echo);
                    break;
                case 8:
                    b = (Terminal.LF = !Terminal.LF);
                    break;
                case 7:
                    Terminal.ClearScreen();
                    return;
            }
            label.ForeColor = !b ? LAB_Ref.ForeColor : LAB_Ref.BackColor;
            label.BackColor = !b ? LAB_Ref.BackColor : LAB_Ref.ForeColor;
        }

        private void Examine_Clicked(object sender, EventArgs e)
        {
            if (!Altair8800.Running)
            {
                if (sender == SW_ExamineNext)
                    NB_FPAddress.Value = (NB_FPAddress.Value + 1) & 0xffff;
                int byt = Altair8800.ReadByte(NB_FPAddress.Value);
                NB_FPData.Value = byt;
            }
        }

        private void Deposit_Clicked(object sender, EventArgs e)
        {
            if (!Altair8800.Running)
            {
                if (sender == SW_DepositNext)
                    NB_FPAddress.Value = (NB_FPAddress.Value + 1) & 0xffff;
                Altair8800.WriteByte(NB_FPAddress.Value, NB_FPData.Value);
                NB_FPData.Focus();
                NB_FPData.SelectAll();
            }
        }

        private void CB_Octal_CheckedChanged(object sender, EventArgs e)
        {
            NB_FPAddress.Base = CB_Octal.Checked ? 8 : 16;
            NB_FPAddress.Digits = CB_Octal.Checked ? 6 : 4;
            NB_FPData.Base = NB_FPAddress.Base;
            NB_FPData.Digits = CB_Octal.Checked ? 3 : 2;
        }

        private void BUT_BinSave_Click(object sender, EventArgs e)
        {
            int addr = (int)NUD_BinSaveAddr.Value;
            int len = (int)NUD_BinSaveLength.Value;
            if (len > 0)
            {
                String file = SaveFile("Select the file you wish to save the binary data dump to", "BIN");
                if (file != null)
                {
                    byte[] b = Altair8800.ReadRam(addr, len);
                    Mon.WriteAllBytes(file, b);
                }
            }
        }

        private void CB_SenseSwMomentary_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                Altair8800.SetSwitch(i, false);
                frontSwitches[i].Checked = false;
                frontSwitches[i].Momentary = CB_SenseSwMomentary.Checked;
            }
        }

        private void CassetteOptions()
        {
            using CassetteOptions cOptions = new(
                tapeController.Audio,
                tapeController.Mark,
                tapeController.Space,
                tapeController.Baud,
                tapeController.Hysteresis
            );
            if (cOptions.ShowDialog() == DialogResult.OK)
            {
                tapeController.Baud = cOptions.Baud;
                tapeController.Mark = cOptions.Mark;
                tapeController.Space = cOptions.Space;
                tapeController.Hysteresis = cOptions.Hysteresis;
                SetCassetteStatus(cOptions.Active);
            }
        }

        private void SetCassetteStatus(bool active)
        {
            if (!active && tapeController.Modulating || tapeController.Listening) return;
            tapeController.Audio = active;
            ButtonHighlight(BUT_CassAudio, active);
        }

        private void CassetteAudio_Clicked(object sender, EventArgs e)
        {
            SetCassetteStatus(!tapeController.Audio);
        }

        private void RegEdit_Leave(object sender, EventArgs e)
        {
            if (IsRunning) return;
            Altair8800.GetState();
            Altair8800.SetReg(7, (int)NUD_A.Value, false);
            Altair8800.SetReg(0, (int)NUD_BC.Value, true);
            Altair8800.SetReg(2, (int)NUD_DE.Value, true);
            Altair8800.SetReg(4, (int)NUD_HL.Value, true);
            Altair8800.SetReg(8, (int)NUD_SP.Value, true);
            Altair8800.SetReg(10, (int)NUD_PC.Value, true);
            Altair8800.SetReg(12, (int)NUD_IV.Value, false);
            Altair8800.SetState();
            monitor.SetAddress();
        }

        private void StatusFlag_Clicked(object sender, EventArgs e)
        {
            if (IsRunning) return;
            int f = 2;
            f |= CB_CF.Checked ? 1 : 0;
            f |= CB_PF.Checked ? 4 : 0;
            f |= CB_HF.Checked ? 16 : 0;
            f |= CB_ZF.Checked ? 64 : 0;
            f |= CB_SF.Checked ? 128 : 0;
            Altair8800.GetState();
            Altair8800.SetReg(6, f, false);
            Altair8800.SetReg(20, CB_HLT.Checked ? 1 : 0, false);
            Altair8800.SetReg(16, CB_EI.Checked ? 1 : 0, false);
            Altair8800.SetState();
            monitor.SetAddress();
        }

        private void TSMI_CassetteAudioOptions_Click(object sender, EventArgs e)
        {
            CassetteOptions();
        }

        private static void ReportSpeed()
        {
            double mhz = 1000.0 / Altair8800.NanosPerTS;
            Mon.Log("System Speed: " + mhz.ToString("N2") + " MHz  (" + Altair8800.NanosPerTS + " nanoseconds per CPU cycle)");
        }

        private void NUD_Speed_ValueChanged(object sender, EventArgs e)
        {
            if (IsRunning) Mon.Wrn("Changing speed while running is not recommended.");
            Altair8800.SetSpeed((long)NUD_Speed.Value);
            ReportSpeed();
        }

        private void CB_DoStatus_Click(object sender, EventArgs e)
        {
            Altair8800.DoStatus(CB_DoStatus.Checked);
        }

        private void CBOX_Monitor_Click(object sender, EventArgs e)
        {
            TBOX_Monitor.Visible = !CBOX_Monitor.Checked;
            monitor.Visible = CBOX_Monitor.Checked;
            BUT_Commit.Visible = CBOX_Monitor.Checked;
        }

        private void BUT_Commit_Click(object sender, EventArgs e)
        {
            if(!IsRunning)
                Altair8800.SetState(true);
        }

        private void LL_Youtube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(LL_Youtube.Text) { UseShellExecute = true });
        }

        private void BUT_Presets_Click(object sender, EventArgs e)
        {
            if(!Altair8800.Running)
            {
                Presets presetUI = new(SetPreset, GetPreset);
                presetUI.ShowDialog();
            }
            else
                Mon.Wrn("Must be in stopped state to access Presets.");
        }
    }

}