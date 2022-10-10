namespace Nicsure.CustomControls
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public class FrontSwitch : Panel
    {
        public bool AllowRightClick 
        {
            get => allowRight;
            set => allowRight = value;
        }
        public bool Checked
        {
            get => check;
            set
            {
                check = value;
                DrawSwitch();
            }
        }
        public Color SwitchBackColor
        {
            get => switchBackColor;
            set
            {
                switchBackColor = value;
                DrawSwitch();
            }
        }
        public Color KnobColor
        {
            get => knobColor;
            set
            {
                knobColor = value;
                DrawSwitch();
            }
        }
        public new Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                DrawSwitch();
            }
        }
        public bool Momentary
        {
            get => momentary;
            set
            {
                momentary = value;
                InitEvents();
            }
        }
        private readonly CheckBox focus = new();
        private bool momentary = false, check = false, allowRight = false;
        private Color knobColor, switchBackColor;
        public event EventHandler CheckedChanged, Clicked;

        public FrontSwitch() : base()
        {
            DrawSwitch();
            InitEvents();
            focus.Size = Size.Empty;
            Controls.Add(focus);
        }

        private void FrontSwitch_MouseEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || (AllowRightClick && e.Button == MouseButtons.Right))
            {
                Checked = !Checked;
                if (Checked)
                {
                    focus.Focus();
                    (_ = Clicked)?.Invoke(this, e);
                }
                (_ = CheckedChanged)?.Invoke(this, e);
            }
        }

        private void FrontSwitch_Click(object sender, EventArgs e)
        {            
            focus.Focus();
            Checked = !Checked;
            (_ = CheckedChanged)?.Invoke(this, e);
        }

        private void InitEvents()
        {
            Click -= FrontSwitch_Click;
            MouseDown -= FrontSwitch_MouseEvent;
            MouseUp -= FrontSwitch_MouseEvent;
            if (momentary)
            {
                MouseDown += FrontSwitch_MouseEvent;
                MouseUp += FrontSwitch_MouseEvent;
            }
            else
                Click += FrontSwitch_Click;
        }

        private void DrawSwitch()
        {
            if (BackgroundImage == null) BackgroundImage = new Bitmap(100, 150);
            BackgroundImageLayout = ImageLayout.Zoom;
            using (Graphics g = Graphics.FromImage(BackgroundImage))
            {
                using Brush fb = new SolidBrush(KnobColor), bb = new SolidBrush(SwitchBackColor), sb = new SolidBrush(ForeColor);
                Rectangle rect = new (10, 10, 80, 130);
                Rectangle knob = new (20, check ? 20 : 70, 60, 60);
                Rectangle knob3d = new (20, check ? 35 : 55, 60, 60);
                g.Clear(ForeColor);
                g.FillRectangle(bb, rect);
                g.FillEllipse(sb, knob3d);
                g.FillEllipse(fb, knob);
            }
            Refresh();
        }

    }
}
