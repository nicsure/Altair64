using Nicsure.Altair8800.Emulator;
using Nicsure.CustomControls;
using Nicsure.General;
using Nicsure.Intel8080;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altair64.Project
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public partial class Monitor : Form
    {
        // Code by nicsure (C)2022
        // https://www.youtube.com/nicsure

        private readonly NumberBox[] addrBox = new NumberBox[15];
        private readonly NumberBox[][] dataBox = new NumberBox[15][];
        private byte[] state;
        private int lastAddr = 0;
        int bc, de, hl, sp, pc, ret;

        public void SetState(byte[] b) => state = b;

        private void BUT_PC_Click(object sender, EventArgs e)
        {
            SetAddress(pc);
        }

        private void BUT_BC_Click(object sender, EventArgs e)
        {
            SetAddress(bc);
        }

        private void BUT_DE_Click(object sender, EventArgs e)
        {
            SetAddress(de);
        }

        private void BUT_HL_Click(object sender, EventArgs e)
        {
            SetAddress(hl);
        }

        private void BUT_SP_Click(object sender, EventArgs e)
        {
            SetAddress(sp);
        }

        private void BUT_RET_Click(object sender, EventArgs e)
        {
            SetAddress(ret);
        }

        public Monitor()
        {
            InitializeComponent();
        }

        public void Init()
        {
            for (int i = 0; i < 15; i++)
            {
                dataBox[i] = new NumberBox[16];
                NumberBox ab = new()
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Margin = new(0),
                    TextAlign = HorizontalAlignment.Center,
                    Value = 0xffff,
                    Font = Bold.Font
                };
                ab.TextAlign = HorizontalAlignment.Center;
                if (i == 7)
                {
                    ab.Leave += Ab_Leave;
                }
                else
                {
                    ab.ReadOnly = true;
                    ab.BorderStyle = BorderStyle.None;
                }
                addrBox[i] = ab;
                MemView.Controls.Add(ab, 0, i+1);
            }
            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    NumberBox nb = new()
                    {
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        Margin = new(0),
                        Font = Courier.Font,
                        Digits = 2,
                        Value = 0xff,
                        Maximum = 0xff,
                        TextAlign = HorizontalAlignment.Center
                    };
                    nb.Leave += Nb_Leave;
                    dataBox[y][x] = nb;
                    MemView.Controls.Add(nb, x + 1, y + 1);
                }
            }
            TBOX_DSM.BorderStyle = BorderStyle.None;
        }

        private void Ab_Leave(object sender, EventArgs e)
        {
            SetAddress(((NumberBox)sender).Value);
        }

        private void Nb_Leave(object sender, EventArgs e)
        {
            NumberBox nb = (NumberBox)sender;
            int addr = (int)nb.Tag;
            int data = nb.Value;
            state[addr + 0x100] = (byte)data;
            SetAddress();
        }

        public void SetAddress(int addr = -1)
        {
            if (addr == -1)
                addr = lastAddr;
            else
                lastAddr = addr;
            int ab = -1, bb = 0;
            bc = state[0] | (state[1] << 8);
            de = state[2] | (state[3] << 8);
            hl = state[4] | (state[5] << 8);
            sp = state[8] | (state[9] << 8);
            pc = state[10] | (state[11] << 8);
            ret = state[sp + 0x100] | ((state[((sp + 1)&0xffff) + 0x100]) << 8);
            int addr0 = addr & 0xfff0;
            for (int a = addr0 - 112; a < addr0 + 128; a++)
            {
                int aa = a & 0xffff;
                if ((aa & 0xf) == 0)
                {
                    addrBox[++ab].Value = aa;
                    bb = 0;
                }
                NumberBox db = dataBox[ab][bb++];
                db.Tag = aa;
                db.Value = state[aa + 0x100];
                if (ret == aa)
                    db.BackColor = BUT_RET.BackColor;
                else if (bc == aa)
                    db.BackColor = BUT_BC.BackColor;
                else if (de == aa)
                    db.BackColor = BUT_DE.BackColor;
                else if (hl == aa)
                    db.BackColor = BUT_HL.BackColor;
                else if (sp == aa)
                    db.BackColor = BUT_SP.BackColor;
                else if (pc == aa)
                    db.BackColor = BUT_PC.BackColor;
                else
                    db.BackColor = addrBox[0].BackColor;
            }
            TBOX_DSM.Text = "$"+addr.X4() + "    " + Disassembler.Get(addr, state);
        }

    }
}
