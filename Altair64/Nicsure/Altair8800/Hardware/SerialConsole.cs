using Nicsure.Altair8800.Hardware.Interfaces;
using Nicsure.General;
using Nicsure.Intel8080;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Nicsure.Altair8800.Hardware
{
    class SerialConsole : TextBox, IInputDevice, IOutputDevice, IResettable, ISendToAble, ICapturable, IShutDownAble
    {
        // Code by nicsure (C)2022
        // https://www.youtube.com/nicsure

        private SerialController serialDevice;
        private System.Windows.Forms.Timer displayTimer;
        private String termBuf = String.Empty;

        private TcpListener listener;
        private TcpClient client;
        private NetworkStream telnet = null;
        private MemoryStream capture = null;
        private int captured;
        private bool shutDown = false, telnetEnabled = true;

        public int TelnetPort { get; set; } = 7870;
        public int ControlPort { get; } = 16;
        public int DataPort { get; } = 17;
        public String DeviceName { get; }
        public int Captured { get { lock (this) { return captured; } } }
        public bool Irq { get; set; } = false;
        public bool Bel { get; set; } = true;
        public bool Flash { get; set; } = true;
        public bool Echo { get; set; } = false;
        public bool LF { get; set; } = false;
        public bool Telnet
        {
            get => telnetEnabled;
            set
            {
                if (telnetEnabled && !value)
                {
                    telnetEnabled = false;
                    Mon.KillListener(listener);
                    try { client?.Close(); } catch (Exception) { }
                }
                else if (!telnetEnabled && value)
                {
                    telnetEnabled = true;
                    Mon.Run(Listen);
                }
            }
        }
        public bool Cls { get; set; } = true;
        public bool BasicBackspace { get; set; } = false;

        public override String ToString() => DeviceName;

        public SerialConsole() : base()
        {
            DeviceName = "Terminal";
            ReadOnly = true;
            Enabled = true;
            Multiline = true;
        }

        public void Init()
        { 
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode)
                return;
            
            KeyPress += SerialConsole_KeyPress;
            displayTimer = new System.Windows.Forms.Timer();
            displayTimer.Tick += DisplayTimer_Tick;
            displayTimer.Interval = 60;
            serialDevice = new SerialController(SerialCardType.SIO2, ControlPort, DataPort, CallBack);
            ContextMenuStrip clipMenu = new ();
            clipMenu.Items.Add(new ToolStripMenuItem("Copy", null, null, "0"));
            clipMenu.Items.Add(new ToolStripMenuItem("Paste", null, null, "1"));
            clipMenu.Items.Add(new ToolStripSeparator());
            clipMenu.Items.Add(new ToolStripMenuItem("Font", null, null, "2"));            
            clipMenu.ItemClicked += ClipMenu_ItemClicked;
            ContextMenuStrip = clipMenu;
            if (Telnet) Mon.Run(Listen);
        }

        

        private void ClipMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (Convert.ToInt32(e.ClickedItem.Name))
            {
                case 0:
                    if (SelectedText.Length > 0)
                        Clipboard.SetText(SelectedText);
                    break;
                case 1:
                    String s = Clipboard.GetText();
                    byte[] b = Encoding.ASCII.GetBytes(s ?? String.Empty);
                    Mon.Run(() =>
                    {
                        foreach (char c in b.Select(v => (char)v))
                        {
                            Send(c);
                        }
                    });
                    break;
                case 2:
                    using (FontDialog fd = new ())
                    {
                        ContextMenuStrip.Visible = false;
                        fd.FixedPitchOnly = true;
                        fd.Font = Font;
                        fd.Color = ForeColor;
                        fd.ShowColor = true;
                        fd.FontMustExist = true;
                        switch (fd.ShowDialog())
                        {
                            case DialogResult.OK:
                                Font = fd.Font;
                                ForeColor = fd.Color;
                                break;
                        }
                    }
                    break;
            }
        }

        private int[] Ports() => new int[] { ControlPort, DataPort };
        public int[] GetInputPorts() => Ports();
        public int[] GetOutputPorts() => Ports();

        private void Listen()
        {
            try
            {
                listener = new TcpListener(IPAddress.Loopback, TelnetPort);
                listener.Start();
            }
            catch
            {
                Mon.Err("Unable to start Telnet server on port " + TelnetPort);
                return;
            }
            while (!shutDown & Telnet)
            {
                telnet = null;
                try
                {
                    using (client = listener.AcceptTcpClient())
                    {
                        using (telnet = client.GetStream())
                        {
                            byte[] b = Encoding.ASCII.GetBytes(Text);
                            telnet.Write(b, 0, b.Length);
                            while (!shutDown & Telnet)
                            {
                                int c = telnet.ReadByte();
                                if (c == -1) break;
                                CharFromUser((char)c);
                            }
                        }
                    }
                }
                catch { }
            }
            Mon.KillListener(listener);
        }

        private void Append(String s)
        {
            Mon.Invoke(() => AppendText(s));
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            lock(this)
            {
                if (termBuf.Length > 0)
                {
                    Append(termBuf);
                    termBuf = String.Empty;
                }
                displayTimer.Stop();
            }
        }

        private void CharFromUser(char c)
        {
            if (c == 3 && Irq) Mon.Msg(1, 0);
            if (c == 8 && BasicBackspace)
            {
                Backspace();
                try
                {
                    telnet?.WriteByte(32);
                    telnet?.WriteByte(8);
                }
                catch { }
                c = '_';
            }
            if (c == 13 && LF) c = '\n';
            serialDevice.Send(c);
            if (Echo)
            {
                ShowChar(c);
                if (c == 13)
                    ShowChar('\n');
            }
        }

        private void SerialConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            CharFromUser(e.KeyChar);
        }

        private void Backspace()
        {
            try
            {
                telnet?.WriteByte(8);
            }
            catch { }
            if (InvokeRequired) return;
            if (termBuf.Length == 0)
            {
                if (Text.Length > 0)
                {
                    Text = Mon.TruncStringBy(Text, 1);
                    SelectionStart = Text.Length;
                    ScrollToCaret();
                }
            }
            else
                termBuf = Mon.TruncStringBy(termBuf, 1);
        }

        private void FlashScreen()
        {
            Mon.Run(() =>
            {
                Mon.Invoke(InvertScreen);
                Thread.Sleep(200);
                Mon.Invoke(InvertScreen);
            });
        }

        public void ClearScreen()
        {
            Text = "";
            lastChar = 0;
            try { telnet?.WriteByte(12); } catch { }
        }

        private void InvertScreen()
        {
            (ForeColor, BackColor) = (BackColor, ForeColor);
        }

        private void ShowChar(char c)
        {
            try { telnet?.WriteByte((byte)c); } catch { }
            lock (this)
            {
                if (termBuf.Length == 0)
                    displayTimer.Start();
                termBuf += Mon.Ascii(c);
            }
        }

        private void CallBack(SerialController _)
        {
            int c = serialDevice.Get();
            lock (this)
            {
                if (capture != null)
                {
                    capture?.WriteByte((byte)c);
                    captured++;
                }
            }
            Mon.Invoke(() =>
            {
                switch (c)
                {
                    case 12:
                        if (Cls)
                            ClearScreen();
                        break;
                    case 7:
                        if (Bel)
                            SystemSounds.Beep.Play();
                        if (Flash)
                            FlashScreen();
                        break;
                    case 8:
                        Backspace();
                        break;
                    case int when c == '_' && BasicBackspace:
                        break;
                    default:
                        if (c == 10 && lastChar != 13)
                            ShowChar('\r');
                        ShowChar(Mon.Ascii(c));
                        lastChar = c;
                        break;
                }
            });
        }

        int lastChar = 0;

        public int RequestRead(int port)
        {
            return serialDevice.RequestRead(port);
        }

        public void RequestWrite(int port, int val)
        {
            serialDevice.RequestWrite(port, val);
        }

        public void Reset()
        {
            serialDevice.Reset();
        }

        public void Send(int byt)
        {
            serialDevice.Send(byt);
        }

        public int Get()
        {
            return serialDevice.Get();
        }

        public void StartCapture()
        {
            capture = new MemoryStream();
            captured = 0;
        }

        public byte[] StopCapture()
        {
            lock (this)
            {
                if (capture != null)
                {
                    byte[] b = capture.ToArray();
                    MemoryStream temp = capture;
                    capture = null;
                    temp.Dispose();
                    return b;
                }
                return Array.Empty<byte>();
            }
        }

        public void ShutDown()
        {
            shutDown = true;
            telnet?.Close();
            Mon.KillListener(listener);
        }
    }
}