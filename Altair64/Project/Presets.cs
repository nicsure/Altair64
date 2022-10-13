using NAudio.Wave.SampleProviders;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altair64.Project
{

    public partial class Presets : Form
    {
        private bool change = false;
        private readonly Action<Preset, bool> Set;
        private readonly Func<bool, Preset> Get;

        public Presets(Action<Preset, bool> set, Func<bool, Preset> get)
        {
            Set = set;
            Get = get;
            InitializeComponent();
        }

        private int AddRow(Preset p)
        {
            int r = PresetGrid.Rows.Add(p.Name, p.Description, "Load", "Run");
            PresetGrid.Rows[r].Tag = p;
            return r;
        }

        private void Presets_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < Preset.Size; i++)
            {
                AddRow(Preset.Get(i));
            }            
        }

        private void PresetGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PresetGrid.Rows[e.RowIndex];
            if (row.Tag is Preset p)
            {
                string desc = row.Cells[1].Value as string;
                string name = row.Cells[0].Value as string;
                if (desc != p.Description || name != p.Name)
                {
                    p.Description = desc;
                    p.Name = name;
                }
                change = true;
            }
        }

        private void AddNewEntry(bool ram)
        {
            Preset p = Get(ram);            
            p.Name = "changeme";
            p.Description = "";
            if (ram)
            {
                p.StateFile = Preset.RandomFile();
                File.WriteAllBytes(p.StateFile, p.State);
                p.State = null;
            }
            PresetGrid.EndEdit();
            int r = AddRow(p);
            Preset.Presets.Add(p);
            PresetGrid.Rows[r].Cells[0].Selected = true;
            PresetGrid.BeginEdit(true);
            change = true;
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
            ((Control)sender).BackColor = SystemColors.InactiveBorder;
        }

        private void Controls_Clicked(object sender, EventArgs e)
        {
            if (sender == Delete)
            {
                DataGridViewRow row = PresetGrid.SelectedRows.Count > 0 ? PresetGrid.SelectedRows[0] : null;
                if (row != null && row.Tag is Preset p)
                {
                    if (p.StateFile != null)
                        File.Delete(p.StateFile);
                    Preset.Presets.Remove(p);
                    PresetGrid.Rows.Remove(row);
                    change = true;
                }
            }
            else
            {
                AddNewEntry(sender == AddNewRam);
            }
        }

        private void PresetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Preset p = Preset.Get(e.RowIndex);
            bool run = e.ColumnIndex == 3;
            if (e.ColumnIndex == 2 || run)
            {
                if (p.StateFile != null)
                    p.State = File.ReadAllBytes(p.StateFile);
                Set(p, run);
                p.State = null;
            }
            if (run) Close();
        }

    }

    public class Preset
    {
        private const string presetDir = "preset";
        private const string presetFile = "presets.conf";
        private static readonly RandomNumberGenerator rnd = RandomNumberGenerator.Create();

        private static readonly char sep = Path.DirectorySeparatorChar;
        public static List<Preset> Presets { get; } = new List<Preset>();
        public static int Size => Presets.Count;
        public static Preset Get(int i) => Presets[i]; 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool[] Switches { get; } = new bool[8];
        public byte[] State { get; set; } = null;
        public string StateFile { get; set; } = null;
        public string[] Disks { get; } = new string[16];
        public bool[] Terminal { get; } = new bool[8];
        public int Speed { get; set; } = 500;
        public bool Status { get; set; } = true;
        public bool Momentary { get; set; }

        static Preset()
        {
            Directory.CreateDirectory(presetDir);
            Load();
        }

        public static void Save()
        {
            using StreamWriter writer = new(presetDir + sep + presetFile);
            foreach (var p in Presets)
            {
                string f = p.Name.Replace(';', ':') + ";" + p.Description.Replace(';', ':') + ";";
                foreach (bool swich in p.Switches)
                    f += swich + ";";
                foreach (string disk in p.Disks)
                    f += disk + ";";
                foreach (bool term in p.Terminal)
                    f += term + ";";
                f += p.Speed + ";";
                f += p.Status + ";";
                f += p.Momentary + ";";
                if (p.StateFile != null)
                    f += p.StateFile;
                writer.WriteLine(f);
            }
        }

        public static void Load()
        {
            Presets.Clear();
            if (File.Exists(presetDir + sep + presetFile))
            {
                foreach (string line in File.ReadLines(presetDir + sep + presetFile))
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
                    p.Speed = int.Parse(e[c++]);
                    p.Status = bool.Parse(e[c++]);
                    p.Momentary = bool.Parse(e[c++]);
                    p.StateFile = e[c].Length > 0 ? e[c] : null;
                    Presets.Add(p);
                }
            }
        }

        public static string RandomFile()
        {
            while (true)
            {
                byte[] b = new byte[8];
                rnd.GetBytes(b);
                String file = presetDir + sep + BitConverter.ToString(b).Replace("-", String.Empty) + ".bin";
                if (!File.Exists(file))
                    return file;
            }
        }
    }
}
