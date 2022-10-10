namespace Altair64.Project
{
    partial class Monitor
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
            this.TBOX_DSM = new System.Windows.Forms.TextBox();
            this.BUT_PC = new System.Windows.Forms.Button();
            this.BUT_SP = new System.Windows.Forms.Button();
            this.BUT_HL = new System.Windows.Forms.Button();
            this.BUT_DE = new System.Windows.Forms.Button();
            this.BUT_BC = new System.Windows.Forms.Button();
            this.BUT_RET = new System.Windows.Forms.Button();
            this.Courier = new System.Windows.Forms.Label();
            this.Bold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBOX_DSM
            // 
            this.TBOX_DSM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBOX_DSM.Location = new System.Drawing.Point(10, 545);
            this.TBOX_DSM.Name = "TBOX_DSM";
            this.TBOX_DSM.ReadOnly = true;
            this.TBOX_DSM.Size = new System.Drawing.Size(695, 35);
            this.TBOX_DSM.TabIndex = 0;
            // 
            // BUT_PC
            // 
            this.BUT_PC.BackColor = System.Drawing.Color.PaleGreen;
            this.BUT_PC.ForeColor = System.Drawing.Color.Black;
            this.BUT_PC.Location = new System.Drawing.Point(711, 537);
            this.BUT_PC.Name = "BUT_PC";
            this.BUT_PC.Size = new System.Drawing.Size(56, 43);
            this.BUT_PC.TabIndex = 1;
            this.BUT_PC.Text = "PC";
            this.BUT_PC.UseVisualStyleBackColor = false;
            this.BUT_PC.Click += new System.EventHandler(this.BUT_PC_Click);
            // 
            // BUT_SP
            // 
            this.BUT_SP.BackColor = System.Drawing.Color.LightSalmon;
            this.BUT_SP.ForeColor = System.Drawing.Color.Black;
            this.BUT_SP.Location = new System.Drawing.Point(711, 488);
            this.BUT_SP.Name = "BUT_SP";
            this.BUT_SP.Size = new System.Drawing.Size(56, 43);
            this.BUT_SP.TabIndex = 1;
            this.BUT_SP.Text = "SP";
            this.BUT_SP.UseVisualStyleBackColor = false;
            this.BUT_SP.Click += new System.EventHandler(this.BUT_SP_Click);
            // 
            // BUT_HL
            // 
            this.BUT_HL.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BUT_HL.ForeColor = System.Drawing.Color.Black;
            this.BUT_HL.Location = new System.Drawing.Point(711, 439);
            this.BUT_HL.Name = "BUT_HL";
            this.BUT_HL.Size = new System.Drawing.Size(56, 43);
            this.BUT_HL.TabIndex = 1;
            this.BUT_HL.Text = "HL";
            this.BUT_HL.UseVisualStyleBackColor = false;
            this.BUT_HL.Click += new System.EventHandler(this.BUT_HL_Click);
            // 
            // BUT_DE
            // 
            this.BUT_DE.BackColor = System.Drawing.Color.Violet;
            this.BUT_DE.ForeColor = System.Drawing.Color.Black;
            this.BUT_DE.Location = new System.Drawing.Point(711, 390);
            this.BUT_DE.Name = "BUT_DE";
            this.BUT_DE.Size = new System.Drawing.Size(56, 43);
            this.BUT_DE.TabIndex = 1;
            this.BUT_DE.Text = "DE";
            this.BUT_DE.UseVisualStyleBackColor = false;
            this.BUT_DE.Click += new System.EventHandler(this.BUT_DE_Click);
            // 
            // BUT_BC
            // 
            this.BUT_BC.BackColor = System.Drawing.Color.Gold;
            this.BUT_BC.ForeColor = System.Drawing.Color.Black;
            this.BUT_BC.Location = new System.Drawing.Point(711, 341);
            this.BUT_BC.Name = "BUT_BC";
            this.BUT_BC.Size = new System.Drawing.Size(56, 43);
            this.BUT_BC.TabIndex = 1;
            this.BUT_BC.Text = "BC";
            this.BUT_BC.UseVisualStyleBackColor = false;
            this.BUT_BC.Click += new System.EventHandler(this.BUT_BC_Click);
            // 
            // BUT_RET
            // 
            this.BUT_RET.BackColor = System.Drawing.Color.Silver;
            this.BUT_RET.ForeColor = System.Drawing.Color.Black;
            this.BUT_RET.Location = new System.Drawing.Point(711, 292);
            this.BUT_RET.Name = "BUT_RET";
            this.BUT_RET.Size = new System.Drawing.Size(56, 43);
            this.BUT_RET.TabIndex = 1;
            this.BUT_RET.Text = "RET";
            this.BUT_RET.UseVisualStyleBackColor = false;
            this.BUT_RET.Click += new System.EventHandler(this.BUT_RET_Click);
            // 
            // Courier
            // 
            this.Courier.AutoSize = true;
            this.Courier.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Courier.Location = new System.Drawing.Point(1242, 946);
            this.Courier.Name = "Courier";
            this.Courier.Size = new System.Drawing.Size(101, 23);
            this.Courier.TabIndex = 2;
            this.Courier.Text = "Courier";
            this.Courier.Visible = false;
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bold.Location = new System.Drawing.Point(1272, 896);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(58, 30);
            this.Bold.TabIndex = 3;
            this.Bold.Text = "Bold";
            this.Bold.Visible = false;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 1037);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.Courier);
            this.Controls.Add(this.BUT_RET);
            this.Controls.Add(this.BUT_BC);
            this.Controls.Add(this.BUT_DE);
            this.Controls.Add(this.BUT_HL);
            this.Controls.Add(this.BUT_SP);
            this.Controls.Add(this.BUT_PC);
            this.Controls.Add(this.TBOX_DSM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Monitor";
            this.Text = "Disassembler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBOX_DSM;
        private Button BUT_PC;
        private Button BUT_SP;
        private Button BUT_HL;
        private Button BUT_DE;
        private Button BUT_BC;
        private Button BUT_RET;
        private Label Courier;
        private Label Bold;
    }
}