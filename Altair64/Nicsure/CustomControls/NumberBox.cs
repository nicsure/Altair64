using Nicsure.General;

namespace Nicsure.CustomControls
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public class NumberBox : TextBox
    {
        public int Value { get => val; set => NewValue(value, false); }
        private int val = 0;
        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 65535;
        public int Base { get => nbase; set { nbase = value; NewValue(val, false); } }
        private int nbase = 16;
        public int Digits { get => digits; set { digits = value; NewValue(val, false); } }
        private int digits = 4;
        public bool SelectAllOnChange { get; set; } = true;
        public event EventHandler ValueChanged;

        public NumberBox() : base()
        {
            Leave += NumberBox_Leave;
            KeyPress += NumberBox_KeyPress;
        }

        private void NumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int k = e.KeyChar.ToString().ToUpper()[0];
            e.KeyChar = (char)k;
            switch (k)
            {
                case 13:
                    e.Handled = true;
                    NumberBox_Leave(sender, e);
                    break;
                case 8:
                    break;
                default:
                    int v = k <= '9' ? k - 48 : k - 55;
                    if ((base.Text.Length >= Digits && SelectionLength == 0) || v < 0 || v >= Base)
                        e.Handled = true;
                    break;
            }
        }

        private bool Validate(String s, out int result)
        {
            result = 0;
            int pow = s.Length - 1;
            foreach (char c in s)
            {
                int v = c <= '9' ? c - 48 : c - 55;
                if (v < 0 || v >= Base)
                    return false;
                result += v * Mon.Pow(Base, pow--);
            }
            return true;
        }

        private void NumberBox_Leave(object sender, EventArgs e)
        {
            if (Validate(base.Text.ToUpper().Trim(), out int newVal))
                NewValue(newVal, true);
            else
                Value = val;
        }

        private void NewValue(int value, bool raiseEvent)
        {
            value = value < Minimum ? Minimum : value > Maximum ? Maximum : value;
            if (val == value) raiseEvent = false;
            val = value;
            String t = String.Empty;
            while (value > 0)
            {
                int mod = value % Base;
                value /= Base;
                mod += mod <= 9 ? 48 : 55;
                t = Mon.Ascii(mod) + t;
            }
            while (t.Length < Digits)
                t = "0" + t;
            base.Text = t;
            if (SelectAllOnChange)
                SelectAll();
            else
            {
                SelectionStart = TextLength;
                SelectionLength = 0;
            }
            if (raiseEvent)
                ValueChanged?.Invoke(this, new EventArgs());
        }

    }
}
