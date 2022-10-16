namespace Altair64.Project
{
    partial class Presets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PresetGrid = new System.Windows.Forms.DataGridView();
            this.PresetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadPreset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RunPreset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNew = new System.Windows.Forms.Label();
            this.AddNewRam = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_ButtonColors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PresetGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresetGrid
            // 
            this.PresetGrid.AllowUserToAddRows = false;
            this.PresetGrid.AllowUserToDeleteRows = false;
            this.PresetGrid.AllowUserToResizeColumns = false;
            this.PresetGrid.AllowUserToResizeRows = false;
            this.PresetGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PresetGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PresetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PresetGrid.ColumnHeadersVisible = false;
            this.PresetGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PresetName,
            this.Description,
            this.LoadPreset,
            this.RunPreset});
            this.tableLayoutPanel1.SetColumnSpan(this.PresetGrid, 3);
            this.PresetGrid.GridColor = System.Drawing.SystemColors.Control;
            this.PresetGrid.Location = new System.Drawing.Point(3, 3);
            this.PresetGrid.MultiSelect = false;
            this.PresetGrid.Name = "PresetGrid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PresetGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PresetGrid.RowHeadersVisible = false;
            this.PresetGrid.RowHeadersWidth = 62;
            this.PresetGrid.RowTemplate.Height = 33;
            this.PresetGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PresetGrid.Size = new System.Drawing.Size(1224, 792);
            this.PresetGrid.TabIndex = 0;
            this.PresetGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PresetGrid_CellContentClick);
            this.PresetGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PresetGrid_CellEndEdit);
            // 
            // PresetName
            // 
            this.PresetName.HeaderText = "Preset Name";
            this.PresetName.MinimumWidth = 8;
            this.PresetName.Name = "PresetName";
            this.PresetName.Width = 300;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Preset Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            // 
            // LoadPreset
            // 
            this.LoadPreset.FillWeight = 70F;
            this.LoadPreset.HeaderText = "Load";
            this.LoadPreset.MinimumWidth = 8;
            this.LoadPreset.Name = "LoadPreset";
            this.LoadPreset.Text = "Load";
            this.LoadPreset.Width = 90;
            // 
            // RunPreset
            // 
            this.RunPreset.FillWeight = 70F;
            this.RunPreset.HeaderText = "Run";
            this.RunPreset.MinimumWidth = 8;
            this.RunPreset.Name = "RunPreset";
            this.RunPreset.Width = 90;
            // 
            // AddNew
            // 
            this.AddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNew.AutoSize = true;
            this.AddNew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNew.Location = new System.Drawing.Point(165, 822);
            this.AddNew.Margin = new System.Windows.Forms.Padding(0);
            this.AddNew.Name = "AddNew";
            this.AddNew.Padding = new System.Windows.Forms.Padding(5);
            this.AddNew.Size = new System.Drawing.Size(78, 41);
            this.AddNew.TabIndex = 0;
            this.AddNew.Text = "New";
            this.AddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNew.Click += new System.EventHandler(this.Controls_Clicked);
            this.AddNew.MouseEnter += new System.EventHandler(this.Controls_Enter);
            this.AddNew.MouseLeave += new System.EventHandler(this.Controls_Leave);
            // 
            // AddNewRam
            // 
            this.AddNewRam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewRam.AutoSize = true;
            this.AddNewRam.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddNewRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewRam.Location = new System.Drawing.Point(502, 822);
            this.AddNewRam.Margin = new System.Windows.Forms.Padding(0);
            this.AddNewRam.Name = "AddNewRam";
            this.AddNewRam.Padding = new System.Windows.Forms.Padding(5);
            this.AddNewRam.Size = new System.Drawing.Size(223, 41);
            this.AddNewRam.TabIndex = 0;
            this.AddNewRam.Text = "New (Save RAM)";
            this.AddNewRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNewRam.Click += new System.EventHandler(this.Controls_Clicked);
            this.AddNewRam.MouseEnter += new System.EventHandler(this.Controls_Enter);
            this.AddNewRam.MouseLeave += new System.EventHandler(this.Controls_Leave);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.AutoSize = true;
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(973, 822);
            this.Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(5);
            this.Delete.Size = new System.Drawing.Size(102, 41);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.Click += new System.EventHandler(this.Controls_Clicked);
            this.Delete.MouseEnter += new System.EventHandler(this.Controls_Enter);
            this.Delete.MouseLeave += new System.EventHandler(this.Controls_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.PresetGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddNewRam, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddNew, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1230, 887);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LAB_ButtonColors
            // 
            this.LAB_ButtonColors.AutoSize = true;
            this.LAB_ButtonColors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LAB_ButtonColors.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LAB_ButtonColors.Location = new System.Drawing.Point(1231, 583);
            this.LAB_ButtonColors.Name = "LAB_ButtonColors";
            this.LAB_ButtonColors.Size = new System.Drawing.Size(59, 25);
            this.LAB_ButtonColors.TabIndex = 3;
            this.LAB_ButtonColors.Text = "label1";
            this.LAB_ButtonColors.Visible = false;
            // 
            // Presets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1230, 887);
            this.Controls.Add(this.LAB_ButtonColors);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Presets";
            this.Text = "Presets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Presets_FormClosing);
            this.Shown += new System.EventHandler(this.Presets_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PresetGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PresetGrid;
        private Label AddNew;
        private Label Delete;
        private Label AddNewRam;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn PresetName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn LoadPreset;
        private DataGridViewButtonColumn RunPreset;
        private Label LAB_ButtonColors;
    }
}