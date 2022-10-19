using Nicsure.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altair64.Project
{
    public partial class PuttyOptions : Form
    {
        private const char sep = '\u002C';

        private const string defaultsFile = "default.putty";
        public static bool InUse { get; set; } = false;
        public static IntPtr Window { get; set; } = IntPtr.Zero;
        public static Process Proc { get; set; } = null;
        public static string Path { get; private set; } = @"C:\Program Files\PuTTY\putty.exe";
        public static string Session { get; private set; } = "Altair8800";
        public static int TitleHeight { get; private set; } = 50;
        public static int TelnetPort { get; private set; } = 7870;

        static PuttyOptions()
        {
            ApplyDefaults();
        }

        public PuttyOptions()
        {
            InitializeComponent();
        }

        private static void ApplyDefaults()
        {
            string[] p = Mon.ReadAllLines(defaultsFile);
            if (p != null && p.Length > 0)
                FromString(p[0]);
        }

        private void SetCurrent()
        {
            TBOX_Path.Text = Path;
            TBOX_Session.Text = Session;
            NUD_TitleBarHeight.Value = TitleHeight;
            NUD_TelnetPort.Value = TelnetPort;
        }

        private void ApplyCurrent()
        {
            Path = TBOX_Path.Text;
            Session = TBOX_Session.Text;
            TitleHeight = (int)NUD_TitleBarHeight.Value;
            TelnetPort = (int)NUD_TelnetPort.Value;
        }

        private void SaveDefaults()
        {
            Mon.WriteAllText(defaultsFile, ToString());
        }

        private void PuttyOptions_Shown(object sender, EventArgs e)
        {
            SetCurrent();
        }

        private void BUT_PathBrowse_Click(object sender, EventArgs e)
        {
            Path = UI.OpenFile("Locate PuTTY.exe", "EXE") ?? Path;
        }

        public override string ToString()
        {
            return Path + sep + Session + sep + TitleHeight + sep + TelnetPort;
        }

        public static void FromString(string s)
        {
            string[] p = s.Split(sep);
            for (int i = 0; i < p.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Path = p[0];
                        break;
                    case 1:
                        Session = p[1];
                        break;
                    case 2:
                        if (int.TryParse(p[2], out int th)) TitleHeight = th;
                        break;
                    case 3:
                        if (int.TryParse(p[3], out int tp)) TelnetPort = tp;
                        break;
                    default:
                        return;
                }
            }
        }

        private void BUT_Default_Click(object sender, EventArgs e)
        {
            ApplyCurrent();
            SaveDefaults();
            Close();
        }

        private void BUT_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            ApplyCurrent();
            Close();
        }
    }
}
