using System.Drawing.Drawing2D;

namespace Nicsure.CustomControls
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public class VariableLED : PictureBox, IPWM
    {
        private static readonly Dictionary<int, Color[]> cTables = new();

        private int brightness = 0, onCount;
        private Color ledColor = Color.Red, housingColor = Color.DarkSlateGray, maskColor = Color.Green;
        private Color[] cTable = GetColorTable(Color.Red);
        private bool invert = false;

        public int Brightness { get => brightness; set => SetBrightness(value); }
        public bool Invert
        {
            get => invert;
            set => invert = value;
        }
        public Color LedColor
        {
            get => ledColor;
            set
            {
                ledColor = value;
                cTable = GetColorTable(ledColor);
                DrawLED();
            }
        }
        public Color HousingColor
        {
            get => housingColor;
            set
            {
                housingColor = value;
                DrawLED();
            }
        }
        public Color MaskColor
        {
            get => maskColor;
            set
            {
                maskColor = value;
                DrawLED();
            }
        }

        public VariableLED() : base()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = new Bitmap(100, 100);
            Image = null;
            onCount = 0;
            DrawLED();
        }

        private static Color[] GetColorTable(Color col)
        {
            int r = col.R;
            int g = col.G;
            int b = col.B;
            int key = (r << 16) | (g << 8) | b;
            if (!cTables.TryGetValue(key, out Color[] cTable))
            {
                cTable = new Color[257];
                for (int i = 0; i < 257; i++)
                {
                    double ii = Math.Sqrt(i / 256.0);
                    int rr = (int)(ii * r);
                    int gg = (int)(ii * g);
                    int bb = (int)(ii * b);
                    cTable[i] = Color.FromArgb(rr, gg, bb);
                }
                cTables[key] = cTable;
            }
            return cTable;
        }

        private void SetBrightness(int val)
        {            
            if (invert) val = 255 - val;
            brightness = val;
            BackColor = cTable[brightness];
        }

        private void DrawLED()
        {
            using (Graphics g = Graphics.FromImage(BackgroundImage))
            using (Brush hBrush = new SolidBrush(HousingColor))
            {
                g.Clear(MaskColor);
                g.FillEllipse(hBrush, 0, 0, 100, 100);
                g.CompositingMode = CompositingMode.SourceCopy;
                g.FillEllipse(Brushes.Transparent, 10, 10, 80, 80);
            }
            Refresh();
        }

        public void UpdatePWM()
        {
            onCount++;
        }

        public void UpdatePWM(int count)
        {
            onCount += count;
        }

        public void Display(int totalCount)
        {
            SetBrightness(onCount * 256 / totalCount);
            onCount = 0;
        }
    }
}
