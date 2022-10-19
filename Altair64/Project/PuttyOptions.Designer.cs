namespace Altair64.Project
{
    partial class PuttyOptions
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBOX_Path = new System.Windows.Forms.TextBox();
            this.BUT_PathBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBOX_Session = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_TitleBarHeight = new System.Windows.Forms.NumericUpDown();
            this.BUT_Cancel = new System.Windows.Forms.Button();
            this.BUT_Default = new System.Windows.Forms.Button();
            this.BUT_OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_TelnetPort = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TitleBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TelnetPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBOX_Path, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_PathBrowse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBOX_Session, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NUD_TitleBarHeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Cancel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Default, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_OK, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NUD_TelnetPort, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 253);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PuTTY.EXE Path";
            // 
            // TBOX_Path
            // 
            this.TBOX_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOX_Path.Location = new System.Drawing.Point(263, 10);
            this.TBOX_Path.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TBOX_Path.Name = "TBOX_Path";
            this.TBOX_Path.ReadOnly = true;
            this.TBOX_Path.Size = new System.Drawing.Size(439, 31);
            this.TBOX_Path.TabIndex = 1;
            this.TBOX_Path.Text = "C:\\Program Files\\PuTTY\\putty.exe";
            // 
            // BUT_PathBrowse
            // 
            this.BUT_PathBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BUT_PathBrowse.Location = new System.Drawing.Point(757, 13);
            this.BUT_PathBrowse.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.BUT_PathBrowse.Name = "BUT_PathBrowse";
            this.BUT_PathBrowse.Size = new System.Drawing.Size(112, 34);
            this.BUT_PathBrowse.TabIndex = 2;
            this.BUT_PathBrowse.Text = "Browse";
            this.BUT_PathBrowse.UseVisualStyleBackColor = true;
            this.BUT_PathBrowse.Click += new System.EventHandler(this.BUT_PathBrowse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "PuTTY.Session";
            // 
            // TBOX_Session
            // 
            this.TBOX_Session.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBOX_Session.BackColor = System.Drawing.SystemColors.Control;
            this.TBOX_Session.Location = new System.Drawing.Point(263, 51);
            this.TBOX_Session.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.TBOX_Session.Name = "TBOX_Session";
            this.TBOX_Session.Size = new System.Drawing.Size(241, 31);
            this.TBOX_Session.TabIndex = 1;
            this.TBOX_Session.Text = "Altair8800";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "PuTTY TitleBar Height";
            // 
            // NUD_TitleBarHeight
            // 
            this.NUD_TitleBarHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NUD_TitleBarHeight.BackColor = System.Drawing.SystemColors.Control;
            this.NUD_TitleBarHeight.Location = new System.Drawing.Point(263, 92);
            this.NUD_TitleBarHeight.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NUD_TitleBarHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_TitleBarHeight.Name = "NUD_TitleBarHeight";
            this.NUD_TitleBarHeight.Size = new System.Drawing.Size(98, 31);
            this.NUD_TitleBarHeight.TabIndex = 3;
            this.NUD_TitleBarHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_TitleBarHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BUT_Cancel
            // 
            this.BUT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BUT_Cancel.Location = new System.Drawing.Point(10, 209);
            this.BUT_Cancel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.BUT_Cancel.Name = "BUT_Cancel";
            this.BUT_Cancel.Size = new System.Drawing.Size(112, 34);
            this.BUT_Cancel.TabIndex = 2;
            this.BUT_Cancel.Text = "Cancel";
            this.BUT_Cancel.UseVisualStyleBackColor = true;
            this.BUT_Cancel.Click += new System.EventHandler(this.BUT_Cancel_Click);
            // 
            // BUT_Default
            // 
            this.BUT_Default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BUT_Default.Location = new System.Drawing.Point(263, 209);
            this.BUT_Default.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.BUT_Default.Name = "BUT_Default";
            this.BUT_Default.Size = new System.Drawing.Size(167, 34);
            this.BUT_Default.TabIndex = 2;
            this.BUT_Default.Text = "Save Defaults";
            this.BUT_Default.UseVisualStyleBackColor = true;
            this.BUT_Default.Click += new System.EventHandler(this.BUT_Default_Click);
            // 
            // BUT_OK
            // 
            this.BUT_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_OK.Location = new System.Drawing.Point(757, 209);
            this.BUT_OK.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.BUT_OK.Name = "BUT_OK";
            this.BUT_OK.Size = new System.Drawing.Size(112, 34);
            this.BUT_OK.TabIndex = 2;
            this.BUT_OK.Text = "OK";
            this.BUT_OK.UseVisualStyleBackColor = true;
            this.BUT_OK.Click += new System.EventHandler(this.BUT_OK_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telnet Port";
            // 
            // NUD_TelnetPort
            // 
            this.NUD_TelnetPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NUD_TelnetPort.BackColor = System.Drawing.SystemColors.Control;
            this.NUD_TelnetPort.Location = new System.Drawing.Point(263, 133);
            this.NUD_TelnetPort.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NUD_TelnetPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_TelnetPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_TelnetPort.Name = "NUD_TelnetPort";
            this.NUD_TelnetPort.Size = new System.Drawing.Size(98, 31);
            this.NUD_TelnetPort.TabIndex = 3;
            this.NUD_TelnetPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_TelnetPort.Value = new decimal(new int[] {
            7870,
            0,
            0,
            0});
            // 
            // PuttyOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(879, 253);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PuttyOptions";
            this.Text = "Putty Options";
            this.Shown += new System.EventHandler(this.PuttyOptions_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TitleBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TelnetPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox TBOX_Path;
        private Button BUT_PathBrowse;
        private Label label2;
        private TextBox TBOX_Session;
        private Label label3;
        private NumericUpDown NUD_TitleBarHeight;
        private Button BUT_Cancel;
        private Button BUT_Default;
        private Button BUT_OK;
        private Label label4;
        private NumericUpDown NUD_TelnetPort;
    }
}