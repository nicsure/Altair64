using NAudio.Wave.SampleProviders;
using System;
using System.Buffers.Text;
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

    public partial class Presets : Form
    {
        private bool change = false;

        public Presets()
        {
            InitializeComponent();
        }

        private void Presets_Shown(object sender, EventArgs e)
        {
            PresetGrid.Rows.Add("TEST NAME", "TEST DESCRIPTION");
            Preset.Load();
            for (int i = 0; i < Preset.Size; i++)
            {
                Preset p = Preset.Get(i);
                int r = PresetGrid.Rows.Add(p.Name, p.Description);
                PresetGrid.Rows[r].Tag = p;
            }
        }

        private void PresetGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PresetGrid.Rows[e.RowIndex];
            Preset p = row.Tag as Preset;
            if (p == null)
            {
                
            }
            string desc = row.Cells[1].Value as string;
            string name = row.Cells[0].Value as string;
            if (desc != p.Description || name != p.Name)
            {
                p.Description = desc;
                p.Name = name;
                //change = true;
            }
        }

        private void Presets_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change)
                Preset.Save();
        }

        private void Controls_Enter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = SystemColors.GradientActiveCaption;
        }

        private void Controls_Leave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = BackColor;
        }
    }

    public class Preset
    {
        private const string presetFile = "presets.conf";
        private static List<Preset> Presets { get; } = new List<Preset>();
        public static int Size => Presets.Count;
        public static Preset Get(int i) => Presets[i]; 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool[] Switches { get; } = new bool[8];
        public byte[] State { get; set; }
        public string[] Disks { get; } = new string[16];
        public bool[] Terminal { get; } = new bool[8];

        public static void Save()
        {
            using StreamWriter writer = new(presetFile);
            foreach (var p in Presets)
            {
                string f = p.Name.Replace(';', ':') + ";" + p.Description.Replace(';', ':') + ";";
                foreach (bool swich in p.Switches)
                    f += swich + ";";
                foreach (string disk in p.Disks)
                    f += disk + ";";
                foreach (bool term in p.Terminal)
                    f += term + ";";
                f += Encode(p.State);
                writer.WriteLine(f);
            }
        }

        public static void Load()
        {
            Presets.Clear();
            if (File.Exists(presetFile))
            {
                foreach (string line in File.ReadLines(presetFile))
                {
                    int c = 0;
                    Preset p = new();
                    string[] e = line.Split(';');
                    p.Name = e[c++];
                    p.Description = e[c++];
                    for (int i = 0; i < p.Switches.Length; i++)
                        p.Switches[i] = bool.Parse(e[c++]);
                    for (int i = 0; i < p.Disks.Length; i++)
                        p.Disks[i] = e[c++];
                    for (int i = 0; i < p.Terminal.Length; i++)
                        p.Terminal[i] = bool.Parse(e[c++]);
                    p.State = Decode(e[c]);
                    Presets.Add(p);
                }
            }            
        }

        public static string Encode(byte[] b)
        {
            int m = 3 - (b.Length % 3);
            if (m < 3)
            {
                byte[] c = new byte[b.Length + m];
                Array.Copy(b, 0, c, 0, b.Length);
                b = c;
            }
            string r = string.Empty;
            for (int i = 0; i < b.Length; i += 3)
            {
                int c1 = (b[i] & 0xfc) >> 2;
                int c2 = ((b[i] & 0x03) << 4) | ((b[i + 1] & 0xf0) >> 4);
                int c3 = ((b[i + 1] & 0x0F) << 2) | ((b[i + 2] & 0xc0) >> 6);
                int c4 = b[i + 2] & 0x3f;
                c1 += 33;
                c2 += 33;
                c3 += 33;
                c4 += 33;
                r += (char)c1 + (char)c2 + (char)c3 + (char)c4;
            }
            return r;
        }

        public static byte[] Decode(string s)
        {
            while (s.Length % 4 != 0) s += "!";
            byte[] b = new byte[(s.Length / 4) * 3];
            int bc = 0;
            for (int i = 0; i < s.Length; i += 4)
            {
                int c1 = s[i] - 33;
                int c2 = s[i + 1] - 33;
                int c3 = s[i + 2] - 33;
                int c4 = s[i + 3] - 33;
                b[bc++] = (byte)((c1 << 2) | ((c2 & 0x30) >> 4));
                b[bc++] = (byte)(((c2 & 0x0f) << 4) | ((c3 & 0x3c) >> 2));
                b[bc++] = (byte)(((c3 & 0x03) << 6) | c4);
            }
            return b;
        }
    }
}
