namespace Altair64.Project
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public partial class CassetteOptions : Form
    {
        public bool Active => CB_Enable.Checked;
        public int Mark => (int)NUD_Mark.Value;
        public int Space => (int)NUD_Space.Value;
        public int Hysteresis => TBAR_Hysteresis.Value;
        public int Baud => Convert.ToInt32(COMBO_Baud.SelectedItem);

        public CassetteOptions(bool enable, int mark, int space, int baud, int hysteresis)
        {
            InitializeComponent();
            CB_Enable.Checked = enable;
            NUD_Mark.Value = mark;
            NUD_Space.Value = space;
            COMBO_Baud.SelectedItem = baud.ToString();
            TBAR_Hysteresis.Value = hysteresis;
            TBAR_Hysteresis_Scroll(null, null);
        }

        private void BUT_OK_Click(object sender, EventArgs e)
        {
            if (Mark <= Space)
                MessageBox.Show("The Mark Freqency must be larger than the Space Frequency", "Error");
            else
                DialogResult = DialogResult.OK;
        }

        private void BUT_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TBAR_Hysteresis_Scroll(object sender, EventArgs e)
        {
            LAB_Hysteresis.Text = TBAR_Hysteresis.Value + "%";
        }
    }
}
