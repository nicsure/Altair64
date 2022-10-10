namespace Nicsure.CustomControls
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    class HButton : Button
    {
        private readonly bool[] highlight = { false, false };
        private Color? tempColor = null;
        private readonly Color[] highlightColors = { Color.LightGoldenrodYellow, Color.LightSalmon };

        public Color HighlightColor1 { get => highlightColors[0]; set => highlightColors[0] = value; }
        public Color HighlightColor2 { get => highlightColors[1]; set => highlightColors[1] = value; }
        public bool Highlighted1 { get => highlight[0]; set => Highlight(0, value); }
        public bool Highlighted2 { get => highlight[1]; set => Highlight(1, value); }

        public void Highlight(int which, bool value)
        {
            which &= 1;
            if (value)
            {
                tempColor ??= BackColor;
                BackColor = highlightColors[which];
            }
            else
            {
                if (tempColor != null)
                    BackColor = (Color)tempColor;
            }
            highlight[which] = value;
            highlight[~which & 1] = false;
        }

    }
}
