namespace Altair64.Project
{
    partial class CassetteOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CassetteOptions));
            this.BUT_OK = new System.Windows.Forms.Button();
            this.BUT_Cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CB_Enable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Mark = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_Space = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.COMBO_Baud = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBAR_Hysteresis = new System.Windows.Forms.TrackBar();
            this.LAB_Hysteresis = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Space)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_Hysteresis)).BeginInit();
            this.SuspendLayout();
            // 
            // BUT_OK
            // 
            this.BUT_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_OK.Location = new System.Drawing.Point(372, 354);
            this.BUT_OK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BUT_OK.Name = "BUT_OK";
            this.BUT_OK.Size = new System.Drawing.Size(150, 53);
            this.BUT_OK.TabIndex = 0;
            this.BUT_OK.Text = "OK";
            this.BUT_OK.UseVisualStyleBackColor = true;
            this.BUT_OK.Click += new System.EventHandler(this.BUT_OK_Click);
            // 
            // BUT_Cancel
            // 
            this.BUT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Cancel.Location = new System.Drawing.Point(210, 354);
            this.BUT_Cancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BUT_Cancel.Name = "BUT_Cancel";
            this.BUT_Cancel.Size = new System.Drawing.Size(150, 53);
            this.BUT_Cancel.TabIndex = 1;
            this.BUT_Cancel.Text = "Cancel";
            this.BUT_Cancel.UseVisualStyleBackColor = true;
            this.BUT_Cancel.Click += new System.EventHandler(this.BUT_Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CB_Enable);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.NUD_Mark);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.NUD_Space);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.COMBO_Baud);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.TBAR_Hysteresis);
            this.flowLayoutPanel1.Controls.Add(this.LAB_Hysteresis);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 28);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 275);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // CB_Enable
            // 
            this.CB_Enable.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.CB_Enable, true);
            this.CB_Enable.Location = new System.Drawing.Point(6, 7);
            this.CB_Enable.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CB_Enable.Name = "CB_Enable";
            this.CB_Enable.Size = new System.Drawing.Size(332, 34);
            this.CB_Enable.TabIndex = 0;
            this.CB_Enable.Text = "Enable Cassette Audio Function";
            this.CB_Enable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mark";
            // 
            // NUD_Mark
            // 
            this.NUD_Mark.Location = new System.Drawing.Point(62, 48);
            this.NUD_Mark.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.NUD_Mark.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Mark.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.NUD_Mark.Name = "NUD_Mark";
            this.NUD_Mark.Size = new System.Drawing.Size(106, 35);
            this.NUD_Mark.TabIndex = 1;
            this.NUD_Mark.Value = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 7, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Space";
            // 
            // NUD_Space
            // 
            this.NUD_Space.Location = new System.Drawing.Point(324, 48);
            this.NUD_Space.Margin = new System.Windows.Forms.Padding(0);
            this.NUD_Space.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Space.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.NUD_Space.Name = "NUD_Space";
            this.NUD_Space.Size = new System.Drawing.Size(106, 35);
            this.NUD_Space.TabIndex = 1;
            this.NUD_Space.Value = new decimal(new int[] {
            1850,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.label4, true);
            this.label4.Location = new System.Drawing.Point(430, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Baud";
            // 
            // COMBO_Baud
            // 
            this.COMBO_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Baud.FormattingEnabled = true;
            this.COMBO_Baud.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "600",
            "1200"});
            this.COMBO_Baud.Location = new System.Drawing.Point(60, 90);
            this.COMBO_Baud.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.COMBO_Baud.Name = "COMBO_Baud";
            this.COMBO_Baud.Size = new System.Drawing.Size(102, 38);
            this.COMBO_Baud.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.label6, true);
            this.label6.Location = new System.Drawing.Point(162, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "bps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.label7.Size = new System.Drawing.Size(106, 53);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hysteresis";
            // 
            // TBAR_Hysteresis
            // 
            this.TBAR_Hysteresis.Location = new System.Drawing.Point(106, 163);
            this.TBAR_Hysteresis.Margin = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.TBAR_Hysteresis.Maximum = 75;
            this.TBAR_Hysteresis.Minimum = 10;
            this.TBAR_Hysteresis.Name = "TBAR_Hysteresis";
            this.TBAR_Hysteresis.Size = new System.Drawing.Size(250, 80);
            this.TBAR_Hysteresis.TabIndex = 4;
            this.TBAR_Hysteresis.TickFrequency = 5;
            this.TBAR_Hysteresis.Value = 30;
            this.TBAR_Hysteresis.Scroll += new System.EventHandler(this.TBAR_Hysteresis_Scroll);
            // 
            // LAB_Hysteresis
            // 
            this.LAB_Hysteresis.AutoSize = true;
            this.LAB_Hysteresis.Location = new System.Drawing.Point(356, 151);
            this.LAB_Hysteresis.Margin = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.LAB_Hysteresis.Name = "LAB_Hysteresis";
            this.LAB_Hysteresis.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.LAB_Hysteresis.Size = new System.Drawing.Size(65, 53);
            this.LAB_Hysteresis.TabIndex = 5;
            this.LAB_Hysteresis.Text = "+0.30";
            // 
            // CassetteOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(546, 434);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.BUT_Cancel);
            this.Controls.Add(this.BUT_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CassetteOptions";
            this.Text = "Cassette Audio Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Space)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBAR_Hysteresis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BUT_OK;
        private System.Windows.Forms.Button BUT_Cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CB_Enable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Mark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_Space;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox COMBO_Baud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TBAR_Hysteresis;
        private System.Windows.Forms.Label LAB_Hysteresis;
    }
}