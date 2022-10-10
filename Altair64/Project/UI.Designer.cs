using Nicsure.Altair8800.Hardware;
using Nicsure.CustomControls;

namespace Altair64.Project
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.OFD_Load = new System.Windows.Forms.OpenFileDialog();
            this.CB_Debug = new System.Windows.Forms.CheckBox();
            this.NUD_BinLoadAddr = new System.Windows.Forms.NumericUpDown();
            this.BUT_BinLoad = new System.Windows.Forms.Button();
            this.NUD_PC = new System.Windows.Forms.NumericUpDown();
            this.COMBO_SendToDevices = new System.Windows.Forms.ComboBox();
            this.BUT_LoadHex = new System.Windows.Forms.Button();
            this.CMS_DiskOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Label1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DiskName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Eject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MountImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MountRAM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ConvertRAM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MountBlank = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.LAB_Irq = new System.Windows.Forms.Label();
            this.LAB_Bel = new System.Windows.Forms.Label();
            this.LAB_Flash = new System.Windows.Forms.Label();
            this.LAB_Telnet = new System.Windows.Forms.Label();
            this.LAB_Cls = new System.Windows.Forms.Label();
            this.LAB_BasicBackspace = new System.Windows.Forms.Label();
            this.LAB_Echo = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.LAB_Clear = new System.Windows.Forms.Label();
            this.LAB_Ref = new System.Windows.Forms.Label();
            this.Terminal = new Nicsure.Altair8800.Hardware.SerialConsole();
            this.TBOX_Monitor = new System.Windows.Forms.TextBox();
            this.BUT_Eject0 = new System.Windows.Forms.Button();
            this.BUT_Eject1 = new System.Windows.Forms.Button();
            this.BUT_Eject2 = new System.Windows.Forms.Button();
            this.BUT_Eject3 = new System.Windows.Forms.Button();
            this.COMBO_CaptureDevices = new System.Windows.Forms.ComboBox();
            this.NUD_BC = new System.Windows.Forms.NumericUpDown();
            this.NUD_DE = new System.Windows.Forms.NumericUpDown();
            this.NUD_IV = new System.Windows.Forms.NumericUpDown();
            this.NUD_HL = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_SP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_A = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_CF = new System.Windows.Forms.CheckBox();
            this.CB_PF = new System.Windows.Forms.CheckBox();
            this.CB_HF = new System.Windows.Forms.CheckBox();
            this.CB_ZF = new System.Windows.Forms.CheckBox();
            this.CB_SF = new System.Windows.Forms.CheckBox();
            this.CB_HLT = new System.Windows.Forms.CheckBox();
            this.CB_EI = new System.Windows.Forms.CheckBox();
            this.CB_IRQ = new System.Windows.Forms.CheckBox();
            this.CB_DoStatus = new System.Windows.Forms.CheckBox();
            this.CBOX_Monitor = new System.Windows.Forms.CheckBox();
            this.NUD_Speed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.LAB_Hint = new System.Windows.Forms.Label();
            this.SFD_Save = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.LEDd7 = new Nicsure.CustomControls.VariableLED();
            this.LEDd6 = new Nicsure.CustomControls.VariableLED();
            this.LEDd5 = new Nicsure.CustomControls.VariableLED();
            this.LEDd4 = new Nicsure.CustomControls.VariableLED();
            this.LEDd3 = new Nicsure.CustomControls.VariableLED();
            this.LEDd2 = new Nicsure.CustomControls.VariableLED();
            this.LEDd1 = new Nicsure.CustomControls.VariableLED();
            this.LEDd0 = new Nicsure.CustomControls.VariableLED();
            this.label25 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LEDa15 = new Nicsure.CustomControls.VariableLED();
            this.LEDa14 = new Nicsure.CustomControls.VariableLED();
            this.LEDa13 = new Nicsure.CustomControls.VariableLED();
            this.LEDa12 = new Nicsure.CustomControls.VariableLED();
            this.LEDa11 = new Nicsure.CustomControls.VariableLED();
            this.LEDa10 = new Nicsure.CustomControls.VariableLED();
            this.LEDa9 = new Nicsure.CustomControls.VariableLED();
            this.LEDa8 = new Nicsure.CustomControls.VariableLED();
            this.LEDa7 = new Nicsure.CustomControls.VariableLED();
            this.LEDa6 = new Nicsure.CustomControls.VariableLED();
            this.LEDa5 = new Nicsure.CustomControls.VariableLED();
            this.LEDa4 = new Nicsure.CustomControls.VariableLED();
            this.LEDa3 = new Nicsure.CustomControls.VariableLED();
            this.LEDa2 = new Nicsure.CustomControls.VariableLED();
            this.LEDa1 = new Nicsure.CustomControls.VariableLED();
            this.LEDa0 = new Nicsure.CustomControls.VariableLED();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.SW_RunStop = new Nicsure.CustomControls.FrontSwitch();
            this.SW_Reset = new Nicsure.CustomControls.FrontSwitch();
            this.SW_Step = new Nicsure.CustomControls.FrontSwitch();
            this.SW_Examine = new Nicsure.CustomControls.FrontSwitch();
            this.SW_ExamineNext = new Nicsure.CustomControls.FrontSwitch();
            this.SW_Deposit = new Nicsure.CustomControls.FrontSwitch();
            this.SW_DepositNext = new Nicsure.CustomControls.FrontSwitch();
            this.label34 = new System.Windows.Forms.Label();
            this.CB_Octal = new System.Windows.Forms.CheckBox();
            this.NB_FPAddress = new Nicsure.CustomControls.NumberBox();
            this.NB_FPData = new Nicsure.CustomControls.NumberBox();
            this.BUT_BinSave = new System.Windows.Forms.Button();
            this.NUD_BinSaveAddr = new System.Windows.Forms.NumericUpDown();
            this.NUD_BinSaveLength = new System.Windows.Forms.NumericUpDown();
            this.TTB_DiskName0 = new System.Windows.Forms.Button();
            this.TTB_DiskName1 = new System.Windows.Forms.Button();
            this.TTB_DiskName2 = new System.Windows.Forms.Button();
            this.TTB_DiskName3 = new System.Windows.Forms.Button();
            this.CB_SenseSwMomentary = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.LED_IE = new Nicsure.CustomControls.VariableLED();
            this.LED_RM = new Nicsure.CustomControls.VariableLED();
            this.LED_IN = new Nicsure.CustomControls.VariableLED();
            this.LED_M1 = new Nicsure.CustomControls.VariableLED();
            this.LED_OUT = new Nicsure.CustomControls.VariableLED();
            this.LED_HLT = new Nicsure.CustomControls.VariableLED();
            this.LED_STK = new Nicsure.CustomControls.VariableLED();
            this.LED_WO = new Nicsure.CustomControls.VariableLED();
            this.LED_INT = new Nicsure.CustomControls.VariableLED();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.LED_WAIT = new Nicsure.CustomControls.VariableLED();
            this.label44 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BUT_Presets = new System.Windows.Forms.Button();
            this.CMS_CassetteOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_CassetteAudioOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.LED_Drive3 = new Nicsure.CustomControls.VariableLED();
            this.LED_Drive2 = new Nicsure.CustomControls.VariableLED();
            this.LED_Drive1 = new Nicsure.CustomControls.VariableLED();
            this.LED_Drive0 = new Nicsure.CustomControls.VariableLED();
            this.LED_CassetteData = new Nicsure.CustomControls.VariableLED();
            this.BUT_CassAudio = new Nicsure.CustomControls.HButton();
            this.LED_Cassette = new Nicsure.CustomControls.VariableLED();
            this.SW_A7 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A6 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A5 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A4 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A3 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A2 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A1 = new Nicsure.CustomControls.FrontSwitch();
            this.SW_A0 = new Nicsure.CustomControls.FrontSwitch();
            this.BUT_Capture = new Nicsure.CustomControls.HButton();
            this.BUT_Disk3 = new Nicsure.CustomControls.HButton();
            this.BUT_Disk2 = new Nicsure.CustomControls.HButton();
            this.BUT_Disk1 = new Nicsure.CustomControls.HButton();
            this.BUT_Disk0 = new Nicsure.CustomControls.HButton();
            this.BUT_Load = new Nicsure.CustomControls.HButton();
            this.BUT_Commit = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.LL_Youtube = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinLoadAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PC)).BeginInit();
            this.CMS_DiskOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_IV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HL)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd0)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa0)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinSaveAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinSaveLength)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LED_IE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_RM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_IN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_OUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_HLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_STK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_WO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_INT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_WAIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_CassetteOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_CassetteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Cassette)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Debug
            // 
            this.CB_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Debug.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.CB_Debug, true);
            this.CB_Debug.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_Debug.Location = new System.Drawing.Point(161, 141);
            this.CB_Debug.Margin = new System.Windows.Forms.Padding(23, 12, 5, 6);
            this.CB_Debug.Name = "CB_Debug";
            this.CB_Debug.Size = new System.Drawing.Size(84, 21);
            this.CB_Debug.TabIndex = 11;
            this.CB_Debug.Text = "Debug";
            this.CB_Debug.UseVisualStyleBackColor = true;
            this.CB_Debug.CheckedChanged += new System.EventHandler(this.CB_Debug_CheckedChanged);
            // 
            // NUD_BinLoadAddr
            // 
            this.NUD_BinLoadAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_BinLoadAddr.BackColor = System.Drawing.Color.Black;
            this.NUD_BinLoadAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_BinLoadAddr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_BinLoadAddr.ForeColor = System.Drawing.Color.Silver;
            this.NUD_BinLoadAddr.Hexadecimal = true;
            this.NUD_BinLoadAddr.Location = new System.Drawing.Point(1668, 402);
            this.NUD_BinLoadAddr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_BinLoadAddr.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_BinLoadAddr.Name = "NUD_BinLoadAddr";
            this.NUD_BinLoadAddr.Size = new System.Drawing.Size(90, 31);
            this.NUD_BinLoadAddr.TabIndex = 12;
            this.NUD_BinLoadAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BUT_BinLoad
            // 
            this.BUT_BinLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_BinLoad.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_BinLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_BinLoad.ForeColor = System.Drawing.Color.Black;
            this.BUT_BinLoad.Location = new System.Drawing.Point(1430, 394);
            this.BUT_BinLoad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_BinLoad.Name = "BUT_BinLoad";
            this.BUT_BinLoad.Size = new System.Drawing.Size(233, 44);
            this.BUT_BinLoad.TabIndex = 13;
            this.BUT_BinLoad.Text = "BIN LOAD TO RAM";
            this.BUT_BinLoad.UseVisualStyleBackColor = false;
            this.BUT_BinLoad.Click += new System.EventHandler(this.BUT_BinLoad_Click);
            // 
            // NUD_PC
            // 
            this.NUD_PC.BackColor = System.Drawing.Color.Black;
            this.NUD_PC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_PC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_PC.ForeColor = System.Drawing.Color.Silver;
            this.NUD_PC.Hexadecimal = true;
            this.NUD_PC.Location = new System.Drawing.Point(5, 6);
            this.NUD_PC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_PC.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_PC.Name = "NUD_PC";
            this.NUD_PC.Size = new System.Drawing.Size(100, 31);
            this.NUD_PC.TabIndex = 14;
            this.NUD_PC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_PC.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // COMBO_SendToDevices
            // 
            this.COMBO_SendToDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.COMBO_SendToDevices.BackColor = System.Drawing.Color.Black;
            this.COMBO_SendToDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_SendToDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_SendToDevices.ForeColor = System.Drawing.Color.Silver;
            this.COMBO_SendToDevices.FormattingEnabled = true;
            this.COMBO_SendToDevices.Location = new System.Drawing.Point(1668, 289);
            this.COMBO_SendToDevices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.COMBO_SendToDevices.Name = "COMBO_SendToDevices";
            this.COMBO_SendToDevices.Size = new System.Drawing.Size(169, 33);
            this.COMBO_SendToDevices.TabIndex = 17;
            // 
            // BUT_LoadHex
            // 
            this.BUT_LoadHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_LoadHex.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_LoadHex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_LoadHex.ForeColor = System.Drawing.Color.Black;
            this.BUT_LoadHex.Location = new System.Drawing.Point(1430, 227);
            this.BUT_LoadHex.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_LoadHex.Name = "BUT_LoadHex";
            this.BUT_LoadHex.Size = new System.Drawing.Size(233, 44);
            this.BUT_LoadHex.TabIndex = 18;
            this.BUT_LoadHex.Text = "LOAD HEX FILE";
            this.BUT_LoadHex.UseVisualStyleBackColor = false;
            this.BUT_LoadHex.Click += new System.EventHandler(this.BUT_LoadHex_Click);
            // 
            // CMS_DiskOptions
            // 
            this.CMS_DiskOptions.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.CMS_DiskOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Label1,
            this.TSMI_DiskName,
            this.toolStripSeparator1,
            this.TSMI_Eject,
            this.TSMI_MountImage,
            this.TSMI_MountRAM,
            this.TSMI_ConvertRAM,
            this.TSMI_MountBlank});
            this.CMS_DiskOptions.Name = "CMS_DiskOptions";
            this.CMS_DiskOptions.Size = new System.Drawing.Size(361, 234);
            this.CMS_DiskOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_DiskOptions_ItemClicked);
            // 
            // TSMI_Label1
            // 
            this.TSMI_Label1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Label1.Enabled = false;
            this.TSMI_Label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TSMI_Label1.Name = "TSMI_Label1";
            this.TSMI_Label1.Size = new System.Drawing.Size(360, 32);
            this.TSMI_Label1.Text = " ";
            // 
            // TSMI_DiskName
            // 
            this.TSMI_DiskName.Enabled = false;
            this.TSMI_DiskName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TSMI_DiskName.Name = "TSMI_DiskName";
            this.TSMI_DiskName.Size = new System.Drawing.Size(360, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(357, 6);
            // 
            // TSMI_Eject
            // 
            this.TSMI_Eject.Name = "TSMI_Eject";
            this.TSMI_Eject.Size = new System.Drawing.Size(360, 32);
            this.TSMI_Eject.Text = "Eject Disk";
            // 
            // TSMI_MountImage
            // 
            this.TSMI_MountImage.Name = "TSMI_MountImage";
            this.TSMI_MountImage.Size = new System.Drawing.Size(360, 32);
            this.TSMI_MountImage.Text = "Insert Disk Image";
            // 
            // TSMI_MountRAM
            // 
            this.TSMI_MountRAM.Name = "TSMI_MountRAM";
            this.TSMI_MountRAM.Size = new System.Drawing.Size(360, 32);
            this.TSMI_MountRAM.Text = "Insert Disk Image as RAM Mirror";
            // 
            // TSMI_ConvertRAM
            // 
            this.TSMI_ConvertRAM.Name = "TSMI_ConvertRAM";
            this.TSMI_ConvertRAM.Size = new System.Drawing.Size(360, 32);
            this.TSMI_ConvertRAM.Text = "Convert RAM Mirror to Disk Image";
            // 
            // TSMI_MountBlank
            // 
            this.TSMI_MountBlank.Name = "TSMI_MountBlank";
            this.TSMI_MountBlank.Size = new System.Drawing.Size(360, 32);
            this.TSMI_MountBlank.Text = "Insert New Blank Disk";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel5);
            this.panel1.Controls.Add(this.Terminal);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 1049);
            this.panel1.TabIndex = 24;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel5.Controls.Add(this.LAB_Irq);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Bel);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Flash);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Telnet);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Cls);
            this.flowLayoutPanel5.Controls.Add(this.LAB_BasicBackspace);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Echo);
            this.flowLayoutPanel5.Controls.Add(this.label45);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Clear);
            this.flowLayoutPanel5.Controls.Add(this.LAB_Ref);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(13, 996);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1397, 37);
            this.flowLayoutPanel5.TabIndex = 24;
            // 
            // LAB_Irq
            // 
            this.LAB_Irq.AutoSize = true;
            this.LAB_Irq.BackColor = System.Drawing.Color.Black;
            this.LAB_Irq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Irq.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Irq.ForeColor = System.Drawing.Color.DarkOrange;
            this.LAB_Irq.Location = new System.Drawing.Point(5, 6);
            this.LAB_Irq.Margin = new System.Windows.Forms.Padding(5, 6, 5, 0);
            this.LAB_Irq.Name = "LAB_Irq";
            this.LAB_Irq.Size = new System.Drawing.Size(85, 24);
            this.LAB_Irq.TabIndex = 0;
            this.LAB_Irq.Tag = "0";
            this.LAB_Irq.Text = "CTL-C";
            this.LAB_Irq.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Bel
            // 
            this.LAB_Bel.AutoSize = true;
            this.LAB_Bel.BackColor = System.Drawing.Color.DarkOrange;
            this.LAB_Bel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Bel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Bel.ForeColor = System.Drawing.Color.Black;
            this.LAB_Bel.Location = new System.Drawing.Point(128, 6);
            this.LAB_Bel.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Bel.Name = "LAB_Bel";
            this.LAB_Bel.Size = new System.Drawing.Size(85, 24);
            this.LAB_Bel.TabIndex = 1;
            this.LAB_Bel.Tag = "1";
            this.LAB_Bel.Text = " BEL ";
            this.LAB_Bel.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Flash
            // 
            this.LAB_Flash.AutoSize = true;
            this.LAB_Flash.BackColor = System.Drawing.Color.DarkOrange;
            this.LAB_Flash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Flash.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Flash.ForeColor = System.Drawing.Color.Black;
            this.LAB_Flash.Location = new System.Drawing.Point(251, 6);
            this.LAB_Flash.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Flash.Name = "LAB_Flash";
            this.LAB_Flash.Size = new System.Drawing.Size(115, 24);
            this.LAB_Flash.TabIndex = 2;
            this.LAB_Flash.Tag = "2";
            this.LAB_Flash.Text = " FLASH ";
            this.LAB_Flash.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Telnet
            // 
            this.LAB_Telnet.AutoSize = true;
            this.LAB_Telnet.BackColor = System.Drawing.Color.DarkOrange;
            this.LAB_Telnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Telnet.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Telnet.ForeColor = System.Drawing.Color.Black;
            this.LAB_Telnet.Location = new System.Drawing.Point(404, 6);
            this.LAB_Telnet.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Telnet.Name = "LAB_Telnet";
            this.LAB_Telnet.Size = new System.Drawing.Size(130, 24);
            this.LAB_Telnet.TabIndex = 3;
            this.LAB_Telnet.Tag = "3";
            this.LAB_Telnet.Text = " TELNET ";
            this.LAB_Telnet.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Cls
            // 
            this.LAB_Cls.AutoSize = true;
            this.LAB_Cls.BackColor = System.Drawing.Color.DarkOrange;
            this.LAB_Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Cls.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Cls.ForeColor = System.Drawing.Color.Black;
            this.LAB_Cls.Location = new System.Drawing.Point(572, 6);
            this.LAB_Cls.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Cls.Name = "LAB_Cls";
            this.LAB_Cls.Size = new System.Drawing.Size(85, 24);
            this.LAB_Cls.TabIndex = 4;
            this.LAB_Cls.Tag = "4";
            this.LAB_Cls.Text = " CLS ";
            this.LAB_Cls.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_BasicBackspace
            // 
            this.LAB_BasicBackspace.AutoSize = true;
            this.LAB_BasicBackspace.BackColor = System.Drawing.Color.Black;
            this.LAB_BasicBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_BasicBackspace.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_BasicBackspace.ForeColor = System.Drawing.Color.DarkOrange;
            this.LAB_BasicBackspace.Location = new System.Drawing.Point(695, 6);
            this.LAB_BasicBackspace.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_BasicBackspace.Name = "LAB_BasicBackspace";
            this.LAB_BasicBackspace.Size = new System.Drawing.Size(70, 24);
            this.LAB_BasicBackspace.TabIndex = 5;
            this.LAB_BasicBackspace.Tag = "5";
            this.LAB_BasicBackspace.Text = "BS=_";
            this.LAB_BasicBackspace.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Echo
            // 
            this.LAB_Echo.AutoSize = true;
            this.LAB_Echo.BackColor = System.Drawing.Color.Black;
            this.LAB_Echo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Echo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Echo.ForeColor = System.Drawing.Color.DarkOrange;
            this.LAB_Echo.Location = new System.Drawing.Point(803, 6);
            this.LAB_Echo.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Echo.Name = "LAB_Echo";
            this.LAB_Echo.Size = new System.Drawing.Size(100, 24);
            this.LAB_Echo.TabIndex = 7;
            this.LAB_Echo.Tag = "6";
            this.LAB_Echo.Text = " ECHO ";
            this.LAB_Echo.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Black;
            this.label45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label45.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label45.ForeColor = System.Drawing.Color.DarkOrange;
            this.label45.Location = new System.Drawing.Point(941, 6);
            this.label45.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 24);
            this.label45.TabIndex = 9;
            this.label45.Tag = "8";
            this.label45.Text = "LF";
            this.label45.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Clear
            // 
            this.LAB_Clear.AutoSize = true;
            this.LAB_Clear.BackColor = System.Drawing.Color.Black;
            this.LAB_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Clear.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.LAB_Clear.Location = new System.Drawing.Point(1019, 6);
            this.LAB_Clear.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Clear.Name = "LAB_Clear";
            this.LAB_Clear.Size = new System.Drawing.Size(85, 24);
            this.LAB_Clear.TabIndex = 8;
            this.LAB_Clear.Tag = "7";
            this.LAB_Clear.Text = "CLEAR";
            this.LAB_Clear.Click += new System.EventHandler(this.Terminal_Option_Clicked);
            // 
            // LAB_Ref
            // 
            this.LAB_Ref.AutoSize = true;
            this.LAB_Ref.BackColor = System.Drawing.Color.Black;
            this.LAB_Ref.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Ref.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LAB_Ref.ForeColor = System.Drawing.Color.DarkOrange;
            this.LAB_Ref.Location = new System.Drawing.Point(1142, 6);
            this.LAB_Ref.Margin = new System.Windows.Forms.Padding(33, 6, 5, 0);
            this.LAB_Ref.Name = "LAB_Ref";
            this.LAB_Ref.Size = new System.Drawing.Size(0, 24);
            this.LAB_Ref.TabIndex = 6;
            this.LAB_Ref.Tag = "5";
            // 
            // Terminal
            // 
            this.Terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminal.BackColor = System.Drawing.Color.Black;
            this.Terminal.BasicBackspace = false;
            this.Terminal.Bel = true;
            this.Terminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Terminal.Cls = true;
            this.Terminal.Echo = false;
            this.Terminal.Flash = true;
            this.Terminal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Terminal.ForeColor = System.Drawing.Color.LawnGreen;
            this.Terminal.Irq = false;
            this.Terminal.LF = false;
            this.Terminal.Location = new System.Drawing.Point(13, 15);
            this.Terminal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Terminal.MaxLength = 3000;
            this.Terminal.Multiline = true;
            this.Terminal.Name = "Terminal";
            this.Terminal.ReadOnly = true;
            this.Terminal.Size = new System.Drawing.Size(1381, 969);
            this.Terminal.TabIndex = 23;
            this.Terminal.Telnet = true;
            // 
            // TBOX_Monitor
            // 
            this.TBOX_Monitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOX_Monitor.BackColor = System.Drawing.Color.Black;
            this.TBOX_Monitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBOX_Monitor.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBOX_Monitor.ForeColor = System.Drawing.Color.White;
            this.TBOX_Monitor.Location = new System.Drawing.Point(1430, 506);
            this.TBOX_Monitor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TBOX_Monitor.Multiline = true;
            this.TBOX_Monitor.Name = "TBOX_Monitor";
            this.TBOX_Monitor.Size = new System.Drawing.Size(715, 551);
            this.TBOX_Monitor.TabIndex = 25;
            // 
            // BUT_Eject0
            // 
            this.BUT_Eject0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Eject0.BackColor = System.Drawing.Color.Gray;
            this.BUT_Eject0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Eject0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Eject0.ForeColor = System.Drawing.Color.Black;
            this.BUT_Eject0.Location = new System.Drawing.Point(1533, 8);
            this.BUT_Eject0.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Eject0.Name = "BUT_Eject0";
            this.BUT_Eject0.Size = new System.Drawing.Size(48, 44);
            this.BUT_Eject0.TabIndex = 26;
            this.BUT_Eject0.Tag = "10";
            this.BUT_Eject0.Text = "^";
            this.BUT_Eject0.UseVisualStyleBackColor = false;
            this.BUT_Eject0.Click += new System.EventHandler(this.Disk_Button_Clicked);
            // 
            // BUT_Eject1
            // 
            this.BUT_Eject1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Eject1.BackColor = System.Drawing.Color.Gray;
            this.BUT_Eject1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Eject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Eject1.ForeColor = System.Drawing.Color.Black;
            this.BUT_Eject1.Location = new System.Drawing.Point(1533, 54);
            this.BUT_Eject1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Eject1.Name = "BUT_Eject1";
            this.BUT_Eject1.Size = new System.Drawing.Size(48, 44);
            this.BUT_Eject1.TabIndex = 27;
            this.BUT_Eject1.Tag = "11";
            this.BUT_Eject1.Text = "^";
            this.BUT_Eject1.UseVisualStyleBackColor = false;
            this.BUT_Eject1.Click += new System.EventHandler(this.Disk_Button_Clicked);
            // 
            // BUT_Eject2
            // 
            this.BUT_Eject2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Eject2.BackColor = System.Drawing.Color.Gray;
            this.BUT_Eject2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Eject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Eject2.ForeColor = System.Drawing.Color.Black;
            this.BUT_Eject2.Location = new System.Drawing.Point(1533, 100);
            this.BUT_Eject2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Eject2.Name = "BUT_Eject2";
            this.BUT_Eject2.Size = new System.Drawing.Size(48, 44);
            this.BUT_Eject2.TabIndex = 28;
            this.BUT_Eject2.Tag = "12";
            this.BUT_Eject2.Text = "^";
            this.BUT_Eject2.UseVisualStyleBackColor = false;
            this.BUT_Eject2.Click += new System.EventHandler(this.Disk_Button_Clicked);
            // 
            // BUT_Eject3
            // 
            this.BUT_Eject3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Eject3.BackColor = System.Drawing.Color.Gray;
            this.BUT_Eject3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Eject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Eject3.ForeColor = System.Drawing.Color.Black;
            this.BUT_Eject3.Location = new System.Drawing.Point(1533, 146);
            this.BUT_Eject3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Eject3.Name = "BUT_Eject3";
            this.BUT_Eject3.Size = new System.Drawing.Size(48, 44);
            this.BUT_Eject3.TabIndex = 29;
            this.BUT_Eject3.Tag = "13";
            this.BUT_Eject3.Text = "^";
            this.BUT_Eject3.UseVisualStyleBackColor = false;
            this.BUT_Eject3.Click += new System.EventHandler(this.Disk_Button_Clicked);
            // 
            // COMBO_CaptureDevices
            // 
            this.COMBO_CaptureDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.COMBO_CaptureDevices.BackColor = System.Drawing.Color.Black;
            this.COMBO_CaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CaptureDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CaptureDevices.ForeColor = System.Drawing.Color.Silver;
            this.COMBO_CaptureDevices.FormattingEnabled = true;
            this.COMBO_CaptureDevices.Location = new System.Drawing.Point(1668, 344);
            this.COMBO_CaptureDevices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.COMBO_CaptureDevices.Name = "COMBO_CaptureDevices";
            this.COMBO_CaptureDevices.Size = new System.Drawing.Size(169, 33);
            this.COMBO_CaptureDevices.TabIndex = 31;
            // 
            // NUD_BC
            // 
            this.NUD_BC.BackColor = System.Drawing.Color.Black;
            this.NUD_BC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_BC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_BC.ForeColor = System.Drawing.Color.Silver;
            this.NUD_BC.Hexadecimal = true;
            this.NUD_BC.Location = new System.Drawing.Point(153, 6);
            this.NUD_BC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_BC.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_BC.Name = "NUD_BC";
            this.NUD_BC.Size = new System.Drawing.Size(100, 31);
            this.NUD_BC.TabIndex = 32;
            this.NUD_BC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_BC.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // NUD_DE
            // 
            this.NUD_DE.BackColor = System.Drawing.Color.Black;
            this.NUD_DE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_DE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_DE.ForeColor = System.Drawing.Color.Silver;
            this.NUD_DE.Hexadecimal = true;
            this.NUD_DE.Location = new System.Drawing.Point(153, 49);
            this.NUD_DE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_DE.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_DE.Name = "NUD_DE";
            this.NUD_DE.Size = new System.Drawing.Size(100, 31);
            this.NUD_DE.TabIndex = 33;
            this.NUD_DE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_DE.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // NUD_IV
            // 
            this.NUD_IV.BackColor = System.Drawing.Color.Black;
            this.NUD_IV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_IV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_IV.ForeColor = System.Drawing.Color.Silver;
            this.NUD_IV.Hexadecimal = true;
            this.NUD_IV.Location = new System.Drawing.Point(5, 92);
            this.NUD_IV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_IV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_IV.Name = "NUD_IV";
            this.NUD_IV.Size = new System.Drawing.Size(100, 31);
            this.NUD_IV.TabIndex = 34;
            this.NUD_IV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_IV.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // NUD_HL
            // 
            this.NUD_HL.BackColor = System.Drawing.Color.Black;
            this.NUD_HL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_HL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_HL.ForeColor = System.Drawing.Color.Silver;
            this.NUD_HL.Hexadecimal = true;
            this.NUD_HL.Location = new System.Drawing.Point(153, 92);
            this.NUD_HL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_HL.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_HL.Name = "NUD_HL";
            this.NUD_HL.Size = new System.Drawing.Size(100, 31);
            this.NUD_HL.TabIndex = 35;
            this.NUD_HL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_HL.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.NUD_PC);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.NUD_BC);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.NUD_SP);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.NUD_DE);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.NUD_IV);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.NUD_HL);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.NUD_A);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.CB_Debug);
            this.flowLayoutPanel1.Controls.Add(this.CB_CF);
            this.flowLayoutPanel1.Controls.Add(this.CB_PF);
            this.flowLayoutPanel1.Controls.Add(this.CB_HF);
            this.flowLayoutPanel1.Controls.Add(this.CB_ZF);
            this.flowLayoutPanel1.Controls.Add(this.CB_SF);
            this.flowLayoutPanel1.Controls.Add(this.CB_HLT);
            this.flowLayoutPanel1.Controls.Add(this.CB_EI);
            this.flowLayoutPanel1.Controls.Add(this.CB_IRQ);
            this.flowLayoutPanel1.Controls.Add(this.CB_DoStatus);
            this.flowLayoutPanel1.Controls.Add(this.CBOX_Monitor);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1850, 227);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 281);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label2.Size = new System.Drawing.Size(28, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "PC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(263, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "BC";
            // 
            // NUD_SP
            // 
            this.NUD_SP.BackColor = System.Drawing.Color.Black;
            this.NUD_SP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_SP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_SP.ForeColor = System.Drawing.Color.Silver;
            this.NUD_SP.Hexadecimal = true;
            this.NUD_SP.Location = new System.Drawing.Point(5, 49);
            this.NUD_SP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_SP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_SP.Name = "NUD_SP";
            this.NUD_SP.Size = new System.Drawing.Size(100, 31);
            this.NUD_SP.TabIndex = 32;
            this.NUD_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_SP.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(115, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label8.Size = new System.Drawing.Size(28, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(263, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label4.Size = new System.Drawing.Size(28, 30);
            this.label4.TabIndex = 36;
            this.label4.Text = "DE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(115, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label5.Size = new System.Drawing.Size(28, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "IV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(263, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label6.Size = new System.Drawing.Size(28, 30);
            this.label6.TabIndex = 37;
            this.label6.Text = "HL";
            // 
            // NUD_A
            // 
            this.NUD_A.BackColor = System.Drawing.Color.Black;
            this.NUD_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_A.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_A.ForeColor = System.Drawing.Color.Silver;
            this.NUD_A.Hexadecimal = true;
            this.NUD_A.Location = new System.Drawing.Point(5, 135);
            this.NUD_A.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_A.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUD_A.Name = "NUD_A";
            this.NUD_A.Size = new System.Drawing.Size(100, 31);
            this.NUD_A.TabIndex = 14;
            this.NUD_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_A.Leave += new System.EventHandler(this.RegEdit_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(115, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.label7.Size = new System.Drawing.Size(18, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "A";
            // 
            // CB_CF
            // 
            this.CB_CF.AutoSize = true;
            this.CB_CF.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_CF.Location = new System.Drawing.Point(5, 178);
            this.CB_CF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_CF.Name = "CB_CF";
            this.CB_CF.Size = new System.Drawing.Size(54, 21);
            this.CB_CF.TabIndex = 38;
            this.CB_CF.Text = "CF";
            this.CB_CF.UseVisualStyleBackColor = true;
            this.CB_CF.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_PF
            // 
            this.CB_PF.AutoSize = true;
            this.CB_PF.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_PF.Location = new System.Drawing.Point(69, 178);
            this.CB_PF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_PF.Name = "CB_PF";
            this.CB_PF.Size = new System.Drawing.Size(64, 21);
            this.CB_PF.TabIndex = 38;
            this.CB_PF.Text = "PF ";
            this.CB_PF.UseVisualStyleBackColor = true;
            this.CB_PF.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_HF
            // 
            this.CB_HF.AutoSize = true;
            this.CB_HF.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_HF.Location = new System.Drawing.Point(143, 178);
            this.CB_HF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_HF.Name = "CB_HF";
            this.CB_HF.Size = new System.Drawing.Size(54, 21);
            this.CB_HF.TabIndex = 38;
            this.CB_HF.Text = "HF";
            this.CB_HF.UseVisualStyleBackColor = true;
            this.CB_HF.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_ZF
            // 
            this.CB_ZF.AutoSize = true;
            this.CB_ZF.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_ZF.Location = new System.Drawing.Point(207, 178);
            this.CB_ZF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_ZF.Name = "CB_ZF";
            this.CB_ZF.Size = new System.Drawing.Size(54, 21);
            this.CB_ZF.TabIndex = 38;
            this.CB_ZF.Text = "ZF";
            this.CB_ZF.UseVisualStyleBackColor = true;
            this.CB_ZF.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_SF
            // 
            this.CB_SF.AutoSize = true;
            this.CB_SF.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_SF.Location = new System.Drawing.Point(271, 178);
            this.CB_SF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_SF.Name = "CB_SF";
            this.CB_SF.Size = new System.Drawing.Size(54, 21);
            this.CB_SF.TabIndex = 38;
            this.CB_SF.Text = "SF";
            this.CB_SF.UseVisualStyleBackColor = true;
            this.CB_SF.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_HLT
            // 
            this.CB_HLT.AutoSize = true;
            this.CB_HLT.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_HLT.Location = new System.Drawing.Point(5, 211);
            this.CB_HLT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_HLT.Name = "CB_HLT";
            this.CB_HLT.Size = new System.Drawing.Size(64, 21);
            this.CB_HLT.TabIndex = 38;
            this.CB_HLT.Text = "HLT";
            this.CB_HLT.UseVisualStyleBackColor = true;
            this.CB_HLT.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_EI
            // 
            this.CB_EI.AutoSize = true;
            this.CB_EI.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_EI.Location = new System.Drawing.Point(79, 211);
            this.CB_EI.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_EI.Name = "CB_EI";
            this.CB_EI.Size = new System.Drawing.Size(54, 21);
            this.CB_EI.TabIndex = 38;
            this.CB_EI.Text = "EI";
            this.CB_EI.UseVisualStyleBackColor = true;
            this.CB_EI.Click += new System.EventHandler(this.StatusFlag_Clicked);
            // 
            // CB_IRQ
            // 
            this.CB_IRQ.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.CB_IRQ, true);
            this.CB_IRQ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_IRQ.Location = new System.Drawing.Point(143, 211);
            this.CB_IRQ.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CB_IRQ.Name = "CB_IRQ";
            this.CB_IRQ.Size = new System.Drawing.Size(64, 21);
            this.CB_IRQ.TabIndex = 38;
            this.CB_IRQ.Text = "IRQ";
            this.CB_IRQ.UseVisualStyleBackColor = true;
            // 
            // CB_DoStatus
            // 
            this.CB_DoStatus.AutoSize = true;
            this.CB_DoStatus.Checked = true;
            this.CB_DoStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_DoStatus.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_DoStatus.Location = new System.Drawing.Point(21, 253);
            this.CB_DoStatus.Margin = new System.Windows.Forms.Padding(21, 15, 5, 6);
            this.CB_DoStatus.Name = "CB_DoStatus";
            this.CB_DoStatus.Size = new System.Drawing.Size(94, 21);
            this.CB_DoStatus.TabIndex = 39;
            this.CB_DoStatus.Text = "Status";
            this.CB_DoStatus.UseVisualStyleBackColor = true;
            this.CB_DoStatus.Click += new System.EventHandler(this.CB_DoStatus_Click);
            // 
            // CBOX_Monitor
            // 
            this.CBOX_Monitor.AutoSize = true;
            this.CBOX_Monitor.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBOX_Monitor.Location = new System.Drawing.Point(141, 253);
            this.CBOX_Monitor.Margin = new System.Windows.Forms.Padding(21, 15, 5, 6);
            this.CBOX_Monitor.Name = "CBOX_Monitor";
            this.CBOX_Monitor.Size = new System.Drawing.Size(104, 21);
            this.CBOX_Monitor.TabIndex = 39;
            this.CBOX_Monitor.Text = "Monitor";
            this.CBOX_Monitor.UseVisualStyleBackColor = true;
            this.CBOX_Monitor.Click += new System.EventHandler(this.CBOX_Monitor_Click);
            // 
            // NUD_Speed
            // 
            this.NUD_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Speed.BackColor = System.Drawing.Color.Black;
            this.NUD_Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_Speed.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_Speed.ForeColor = System.Drawing.Color.Silver;
            this.NUD_Speed.Location = new System.Drawing.Point(2053, 13);
            this.NUD_Speed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_Speed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Speed.Name = "NUD_Speed";
            this.NUD_Speed.Size = new System.Drawing.Size(93, 24);
            this.NUD_Speed.TabIndex = 37;
            this.NUD_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Speed.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUD_Speed.ValueChanged += new System.EventHandler(this.NUD_Speed_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(1987, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Speed";
            // 
            // LAB_Hint
            // 
            this.LAB_Hint.AutoSize = true;
            this.LAB_Hint.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LAB_Hint.Location = new System.Drawing.Point(-17, 1242);
            this.LAB_Hint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LAB_Hint.Name = "LAB_Hint";
            this.LAB_Hint.Size = new System.Drawing.Size(0, 24);
            this.LAB_Hint.TabIndex = 39;
            // 
            // SFD_Save
            // 
            this.SFD_Save.Title = "Choose where to save your captured data";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.LEDd7);
            this.flowLayoutPanel3.Controls.Add(this.LEDd6);
            this.flowLayoutPanel3.Controls.Add(this.LEDd5);
            this.flowLayoutPanel3.Controls.Add(this.LEDd4);
            this.flowLayoutPanel3.Controls.Add(this.LEDd3);
            this.flowLayoutPanel3.Controls.Add(this.LEDd2);
            this.flowLayoutPanel3.Controls.Add(this.LEDd1);
            this.flowLayoutPanel3.Controls.Add(this.LEDd0);
            this.flowLayoutPanel3.Controls.Add(this.label25);
            this.flowLayoutPanel3.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1586, 1084);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(645, 73);
            this.flowLayoutPanel3.TabIndex = 58;
            // 
            // LEDd7
            // 
            this.LEDd7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd7.BackgroundImage")));
            this.LEDd7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd7.Brightness = 8;
            this.LEDd7.HousingColor = System.Drawing.Color.Gray;
            this.LEDd7.Invert = false;
            this.LEDd7.LedColor = System.Drawing.Color.Red;
            this.LEDd7.Location = new System.Drawing.Point(2, 0);
            this.LEDd7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd7.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd7.Name = "LEDd7";
            this.LEDd7.Size = new System.Drawing.Size(50, 50);
            this.LEDd7.TabIndex = 62;
            this.LEDd7.TabStop = false;
            // 
            // LEDd6
            // 
            this.LEDd6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd6.BackgroundImage")));
            this.LEDd6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd6.Brightness = 13;
            this.LEDd6.HousingColor = System.Drawing.Color.Gray;
            this.LEDd6.InitialImage = null;
            this.LEDd6.Invert = false;
            this.LEDd6.LedColor = System.Drawing.Color.Red;
            this.LEDd6.Location = new System.Drawing.Point(56, 0);
            this.LEDd6.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDd6.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd6.Name = "LEDd6";
            this.LEDd6.Size = new System.Drawing.Size(50, 50);
            this.LEDd6.TabIndex = 63;
            this.LEDd6.TabStop = false;
            // 
            // LEDd5
            // 
            this.LEDd5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd5.BackgroundImage")));
            this.LEDd5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd5.Brightness = 37;
            this.LEDd5.HousingColor = System.Drawing.Color.Gray;
            this.LEDd5.Invert = false;
            this.LEDd5.LedColor = System.Drawing.Color.Red;
            this.LEDd5.Location = new System.Drawing.Point(125, 0);
            this.LEDd5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd5.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd5.Name = "LEDd5";
            this.LEDd5.Size = new System.Drawing.Size(50, 50);
            this.LEDd5.TabIndex = 64;
            this.LEDd5.TabStop = false;
            // 
            // LEDd4
            // 
            this.LEDd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd4.BackgroundImage")));
            this.LEDd4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd4.Brightness = 9;
            this.LEDd4.HousingColor = System.Drawing.Color.Gray;
            this.LEDd4.Invert = false;
            this.LEDd4.LedColor = System.Drawing.Color.Red;
            this.LEDd4.Location = new System.Drawing.Point(179, 0);
            this.LEDd4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd4.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd4.Name = "LEDd4";
            this.LEDd4.Size = new System.Drawing.Size(50, 50);
            this.LEDd4.TabIndex = 65;
            this.LEDd4.TabStop = false;
            // 
            // LEDd3
            // 
            this.LEDd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd3.BackgroundImage")));
            this.LEDd3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd3.Brightness = 38;
            this.LEDd3.HousingColor = System.Drawing.Color.Gray;
            this.LEDd3.Invert = false;
            this.LEDd3.LedColor = System.Drawing.Color.Red;
            this.LEDd3.Location = new System.Drawing.Point(233, 0);
            this.LEDd3.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDd3.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd3.Name = "LEDd3";
            this.LEDd3.Size = new System.Drawing.Size(50, 50);
            this.LEDd3.TabIndex = 66;
            this.LEDd3.TabStop = false;
            // 
            // LEDd2
            // 
            this.LEDd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd2.BackgroundImage")));
            this.LEDd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd2.Brightness = 13;
            this.LEDd2.HousingColor = System.Drawing.Color.Gray;
            this.LEDd2.Invert = false;
            this.LEDd2.LedColor = System.Drawing.Color.Red;
            this.LEDd2.Location = new System.Drawing.Point(302, 0);
            this.LEDd2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd2.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd2.Name = "LEDd2";
            this.LEDd2.Size = new System.Drawing.Size(50, 50);
            this.LEDd2.TabIndex = 67;
            this.LEDd2.TabStop = false;
            // 
            // LEDd1
            // 
            this.LEDd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd1.BackgroundImage")));
            this.LEDd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd1.Brightness = 15;
            this.LEDd1.HousingColor = System.Drawing.Color.Gray;
            this.LEDd1.Invert = false;
            this.LEDd1.LedColor = System.Drawing.Color.Red;
            this.LEDd1.Location = new System.Drawing.Point(356, 0);
            this.LEDd1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd1.Name = "LEDd1";
            this.LEDd1.Size = new System.Drawing.Size(50, 50);
            this.LEDd1.TabIndex = 68;
            this.LEDd1.TabStop = false;
            // 
            // LEDd0
            // 
            this.LEDd0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDd0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDd0.BackgroundImage")));
            this.LEDd0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDd0.Brightness = 15;
            this.LEDd0.HousingColor = System.Drawing.Color.Gray;
            this.LEDd0.Invert = false;
            this.LEDd0.LedColor = System.Drawing.Color.Red;
            this.LEDd0.Location = new System.Drawing.Point(410, 0);
            this.LEDd0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDd0.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDd0.Name = "LEDd0";
            this.LEDd0.Size = new System.Drawing.Size(50, 50);
            this.LEDd0.TabIndex = 69;
            this.LEDd0.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(467, 0);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(7, 12, 0, 0);
            this.label25.Size = new System.Drawing.Size(59, 46);
            this.label25.TabIndex = 70;
            this.label25.Text = "Data\r\nBus";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.LEDa15);
            this.flowLayoutPanel2.Controls.Add(this.LEDa14);
            this.flowLayoutPanel2.Controls.Add(this.LEDa13);
            this.flowLayoutPanel2.Controls.Add(this.LEDa12);
            this.flowLayoutPanel2.Controls.Add(this.LEDa11);
            this.flowLayoutPanel2.Controls.Add(this.LEDa10);
            this.flowLayoutPanel2.Controls.Add(this.LEDa9);
            this.flowLayoutPanel2.Controls.Add(this.LEDa8);
            this.flowLayoutPanel2.Controls.Add(this.LEDa7);
            this.flowLayoutPanel2.Controls.Add(this.LEDa6);
            this.flowLayoutPanel2.Controls.Add(this.LEDa5);
            this.flowLayoutPanel2.Controls.Add(this.LEDa4);
            this.flowLayoutPanel2.Controls.Add(this.LEDa3);
            this.flowLayoutPanel2.Controls.Add(this.LEDa2);
            this.flowLayoutPanel2.Controls.Add(this.LEDa1);
            this.flowLayoutPanel2.Controls.Add(this.LEDa0);
            this.flowLayoutPanel2.Controls.Add(this.label26);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label16);
            this.flowLayoutPanel2.Controls.Add(this.label17);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Controls.Add(this.label19);
            this.flowLayoutPanel2.Controls.Add(this.label20);
            this.flowLayoutPanel2.Controls.Add(this.label21);
            this.flowLayoutPanel2.Controls.Add(this.label22);
            this.flowLayoutPanel2.Controls.Add(this.label23);
            this.flowLayoutPanel2.Controls.Add(this.label24);
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1115, 1163);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1117, 121);
            this.flowLayoutPanel2.TabIndex = 58;
            // 
            // LEDa15
            // 
            this.LEDa15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa15.BackgroundImage")));
            this.LEDa15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa15.Brightness = 6;
            this.LEDa15.HousingColor = System.Drawing.Color.Gray;
            this.LEDa15.Invert = false;
            this.LEDa15.LedColor = System.Drawing.Color.Red;
            this.LEDa15.Location = new System.Drawing.Point(2, 0);
            this.LEDa15.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDa15.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa15.Name = "LEDa15";
            this.LEDa15.Size = new System.Drawing.Size(50, 50);
            this.LEDa15.TabIndex = 61;
            this.LEDa15.TabStop = false;
            // 
            // LEDa14
            // 
            this.LEDa14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa14.BackgroundImage")));
            this.LEDa14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa14.Brightness = 0;
            this.LEDa14.ErrorImage = null;
            this.LEDa14.HousingColor = System.Drawing.Color.Gray;
            this.LEDa14.InitialImage = null;
            this.LEDa14.Invert = false;
            this.LEDa14.LedColor = System.Drawing.Color.Red;
            this.LEDa14.Location = new System.Drawing.Point(71, 0);
            this.LEDa14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa14.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa14.Name = "LEDa14";
            this.LEDa14.Size = new System.Drawing.Size(50, 50);
            this.LEDa14.TabIndex = 62;
            this.LEDa14.TabStop = false;
            // 
            // LEDa13
            // 
            this.LEDa13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa13.BackgroundImage")));
            this.LEDa13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa13.Brightness = 21;
            this.LEDa13.ErrorImage = null;
            this.LEDa13.HousingColor = System.Drawing.Color.Gray;
            this.LEDa13.InitialImage = null;
            this.LEDa13.Invert = false;
            this.LEDa13.LedColor = System.Drawing.Color.Red;
            this.LEDa13.Location = new System.Drawing.Point(125, 0);
            this.LEDa13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa13.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa13.Name = "LEDa13";
            this.LEDa13.Size = new System.Drawing.Size(50, 50);
            this.LEDa13.TabIndex = 63;
            this.LEDa13.TabStop = false;
            // 
            // LEDa12
            // 
            this.LEDa12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa12.BackgroundImage")));
            this.LEDa12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa12.Brightness = 8;
            this.LEDa12.ErrorImage = null;
            this.LEDa12.HousingColor = System.Drawing.Color.Gray;
            this.LEDa12.InitialImage = null;
            this.LEDa12.Invert = false;
            this.LEDa12.LedColor = System.Drawing.Color.Red;
            this.LEDa12.Location = new System.Drawing.Point(179, 0);
            this.LEDa12.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDa12.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa12.Name = "LEDa12";
            this.LEDa12.Size = new System.Drawing.Size(50, 50);
            this.LEDa12.TabIndex = 64;
            this.LEDa12.TabStop = false;
            // 
            // LEDa11
            // 
            this.LEDa11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa11.BackgroundImage")));
            this.LEDa11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa11.Brightness = 15;
            this.LEDa11.ErrorImage = null;
            this.LEDa11.HousingColor = System.Drawing.Color.Gray;
            this.LEDa11.InitialImage = null;
            this.LEDa11.Invert = false;
            this.LEDa11.LedColor = System.Drawing.Color.Red;
            this.LEDa11.Location = new System.Drawing.Point(248, 0);
            this.LEDa11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa11.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa11.Name = "LEDa11";
            this.LEDa11.Size = new System.Drawing.Size(50, 50);
            this.LEDa11.TabIndex = 65;
            this.LEDa11.TabStop = false;
            // 
            // LEDa10
            // 
            this.LEDa10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa10.BackgroundImage")));
            this.LEDa10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa10.Brightness = 0;
            this.LEDa10.ErrorImage = null;
            this.LEDa10.HousingColor = System.Drawing.Color.Gray;
            this.LEDa10.InitialImage = null;
            this.LEDa10.Invert = false;
            this.LEDa10.LedColor = System.Drawing.Color.Red;
            this.LEDa10.Location = new System.Drawing.Point(302, 0);
            this.LEDa10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa10.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa10.Name = "LEDa10";
            this.LEDa10.Size = new System.Drawing.Size(50, 50);
            this.LEDa10.TabIndex = 66;
            this.LEDa10.TabStop = false;
            // 
            // LEDa9
            // 
            this.LEDa9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa9.BackgroundImage")));
            this.LEDa9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa9.Brightness = 1;
            this.LEDa9.ErrorImage = null;
            this.LEDa9.HousingColor = System.Drawing.Color.Gray;
            this.LEDa9.InitialImage = null;
            this.LEDa9.Invert = false;
            this.LEDa9.LedColor = System.Drawing.Color.Red;
            this.LEDa9.Location = new System.Drawing.Point(356, 0);
            this.LEDa9.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDa9.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa9.Name = "LEDa9";
            this.LEDa9.Size = new System.Drawing.Size(50, 50);
            this.LEDa9.TabIndex = 67;
            this.LEDa9.TabStop = false;
            // 
            // LEDa8
            // 
            this.LEDa8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa8.BackgroundImage")));
            this.LEDa8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa8.Brightness = 10;
            this.LEDa8.ErrorImage = null;
            this.LEDa8.HousingColor = System.Drawing.Color.Gray;
            this.LEDa8.InitialImage = null;
            this.LEDa8.Invert = false;
            this.LEDa8.LedColor = System.Drawing.Color.Red;
            this.LEDa8.Location = new System.Drawing.Point(425, 0);
            this.LEDa8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa8.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa8.Name = "LEDa8";
            this.LEDa8.Size = new System.Drawing.Size(50, 50);
            this.LEDa8.TabIndex = 68;
            this.LEDa8.TabStop = false;
            // 
            // LEDa7
            // 
            this.LEDa7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa7.BackgroundImage")));
            this.LEDa7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa7.Brightness = 0;
            this.LEDa7.ErrorImage = null;
            this.LEDa7.HousingColor = System.Drawing.Color.Gray;
            this.LEDa7.InitialImage = null;
            this.LEDa7.Invert = false;
            this.LEDa7.LedColor = System.Drawing.Color.Red;
            this.LEDa7.Location = new System.Drawing.Point(479, 0);
            this.LEDa7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa7.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa7.Name = "LEDa7";
            this.LEDa7.Size = new System.Drawing.Size(50, 50);
            this.LEDa7.TabIndex = 69;
            this.LEDa7.TabStop = false;
            // 
            // LEDa6
            // 
            this.LEDa6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa6.BackgroundImage")));
            this.LEDa6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa6.Brightness = 10;
            this.LEDa6.ErrorImage = null;
            this.LEDa6.HousingColor = System.Drawing.Color.Gray;
            this.LEDa6.InitialImage = null;
            this.LEDa6.Invert = false;
            this.LEDa6.LedColor = System.Drawing.Color.Red;
            this.LEDa6.Location = new System.Drawing.Point(533, 0);
            this.LEDa6.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDa6.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa6.Name = "LEDa6";
            this.LEDa6.Size = new System.Drawing.Size(50, 50);
            this.LEDa6.TabIndex = 70;
            this.LEDa6.TabStop = false;
            // 
            // LEDa5
            // 
            this.LEDa5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa5.BackgroundImage")));
            this.LEDa5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa5.Brightness = 0;
            this.LEDa5.ErrorImage = null;
            this.LEDa5.HousingColor = System.Drawing.Color.Gray;
            this.LEDa5.InitialImage = null;
            this.LEDa5.Invert = false;
            this.LEDa5.LedColor = System.Drawing.Color.Red;
            this.LEDa5.Location = new System.Drawing.Point(602, 0);
            this.LEDa5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa5.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa5.Name = "LEDa5";
            this.LEDa5.Size = new System.Drawing.Size(50, 50);
            this.LEDa5.TabIndex = 71;
            this.LEDa5.TabStop = false;
            // 
            // LEDa4
            // 
            this.LEDa4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa4.BackgroundImage")));
            this.LEDa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa4.Brightness = 0;
            this.LEDa4.ErrorImage = null;
            this.LEDa4.HousingColor = System.Drawing.Color.Gray;
            this.LEDa4.InitialImage = null;
            this.LEDa4.Invert = false;
            this.LEDa4.LedColor = System.Drawing.Color.Red;
            this.LEDa4.Location = new System.Drawing.Point(656, 0);
            this.LEDa4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa4.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa4.Name = "LEDa4";
            this.LEDa4.Size = new System.Drawing.Size(50, 50);
            this.LEDa4.TabIndex = 72;
            this.LEDa4.TabStop = false;
            // 
            // LEDa3
            // 
            this.LEDa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa3.BackgroundImage")));
            this.LEDa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa3.Brightness = 7;
            this.LEDa3.ErrorImage = null;
            this.LEDa3.HousingColor = System.Drawing.Color.Gray;
            this.LEDa3.InitialImage = null;
            this.LEDa3.Invert = false;
            this.LEDa3.LedColor = System.Drawing.Color.Red;
            this.LEDa3.Location = new System.Drawing.Point(710, 0);
            this.LEDa3.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.LEDa3.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa3.Name = "LEDa3";
            this.LEDa3.Size = new System.Drawing.Size(50, 50);
            this.LEDa3.TabIndex = 73;
            this.LEDa3.TabStop = false;
            // 
            // LEDa2
            // 
            this.LEDa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa2.BackgroundImage")));
            this.LEDa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa2.Brightness = 12;
            this.LEDa2.ErrorImage = null;
            this.LEDa2.HousingColor = System.Drawing.Color.Gray;
            this.LEDa2.InitialImage = null;
            this.LEDa2.Invert = false;
            this.LEDa2.LedColor = System.Drawing.Color.Red;
            this.LEDa2.Location = new System.Drawing.Point(779, 0);
            this.LEDa2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa2.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa2.Name = "LEDa2";
            this.LEDa2.Size = new System.Drawing.Size(50, 50);
            this.LEDa2.TabIndex = 74;
            this.LEDa2.TabStop = false;
            // 
            // LEDa1
            // 
            this.LEDa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa1.BackgroundImage")));
            this.LEDa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa1.Brightness = 9;
            this.LEDa1.ErrorImage = null;
            this.LEDa1.HousingColor = System.Drawing.Color.Gray;
            this.LEDa1.InitialImage = null;
            this.LEDa1.Invert = false;
            this.LEDa1.LedColor = System.Drawing.Color.Red;
            this.LEDa1.Location = new System.Drawing.Point(833, 0);
            this.LEDa1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa1.Name = "LEDa1";
            this.LEDa1.Size = new System.Drawing.Size(50, 50);
            this.LEDa1.TabIndex = 75;
            this.LEDa1.TabStop = false;
            // 
            // LEDa0
            // 
            this.LEDa0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LEDa0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LEDa0.BackgroundImage")));
            this.LEDa0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LEDa0.Brightness = 18;
            this.LEDa0.ErrorImage = null;
            this.LEDa0.HousingColor = System.Drawing.Color.Gray;
            this.LEDa0.InitialImage = null;
            this.LEDa0.Invert = false;
            this.LEDa0.LedColor = System.Drawing.Color.Red;
            this.LEDa0.Location = new System.Drawing.Point(887, 0);
            this.LEDa0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LEDa0.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LEDa0.Name = "LEDa0";
            this.LEDa0.Size = new System.Drawing.Size(50, 50);
            this.LEDa0.TabIndex = 76;
            this.LEDa0.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label26, true);
            this.label26.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(946, 12);
            this.label26.Margin = new System.Windows.Forms.Padding(7, 12, 0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 34);
            this.label26.TabIndex = 93;
            this.label26.Text = "Address\r\nBus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 8, 0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(81, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(38, 8, 0, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "14";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(136, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(25, 8, 0, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 79;
            this.label11.Text = "13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(191, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(25, 8, 0, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(259, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(38, 8, 0, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(314, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(25, 8, 0, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(372, 58);
            this.label15.Margin = new System.Windows.Forms.Padding(28, 8, 0, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 17);
            this.label15.TabIndex = 83;
            this.label15.Text = "9";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(441, 58);
            this.label16.Margin = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 17);
            this.label16.TabIndex = 84;
            this.label16.Text = "8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(495, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 17);
            this.label17.TabIndex = 85;
            this.label17.Text = "7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(549, 58);
            this.label18.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 17);
            this.label18.TabIndex = 86;
            this.label18.Text = "6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(618, 58);
            this.label19.Margin = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 17);
            this.label19.TabIndex = 87;
            this.label19.Text = "5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(672, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 17);
            this.label20.TabIndex = 88;
            this.label20.Text = "4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(726, 58);
            this.label21.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 17);
            this.label21.TabIndex = 89;
            this.label21.Text = "3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(795, 58);
            this.label22.Margin = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 17);
            this.label22.TabIndex = 90;
            this.label22.Text = "2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(849, 58);
            this.label23.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 17);
            this.label23.TabIndex = 91;
            this.label23.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(903, 58);
            this.label24.Margin = new System.Windows.Forms.Padding(35, 8, 0, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 17);
            this.label24.TabIndex = 92;
            this.label24.Text = "0";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel4.Controls.Add(this.label27);
            this.flowLayoutPanel4.Controls.Add(this.label28);
            this.flowLayoutPanel4.Controls.Add(this.label29);
            this.flowLayoutPanel4.Controls.Add(this.label30);
            this.flowLayoutPanel4.Controls.Add(this.label31);
            this.flowLayoutPanel4.Controls.Add(this.label32);
            this.flowLayoutPanel4.Controls.Add(this.label33);
            this.flowLayoutPanel4.Controls.Add(this.SW_RunStop);
            this.flowLayoutPanel4.Controls.Add(this.SW_Reset);
            this.flowLayoutPanel4.Controls.Add(this.SW_Step);
            this.flowLayoutPanel4.Controls.Add(this.SW_Examine);
            this.flowLayoutPanel4.Controls.Add(this.SW_ExamineNext);
            this.flowLayoutPanel4.Controls.Add(this.SW_Deposit);
            this.flowLayoutPanel4.Controls.Add(this.SW_DepositNext);
            this.flowLayoutPanel4.Controls.Add(this.label34);
            this.flowLayoutPanel4.Controls.Add(this.CB_Octal);
            this.flowLayoutPanel4.Controls.Add(this.NB_FPAddress);
            this.flowLayoutPanel4.Controls.Add(this.NB_FPData);
            this.flowLayoutPanel4.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(7, 1068);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(660, 192);
            this.flowLayoutPanel4.TabIndex = 62;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(8, 0);
            this.label27.Margin = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 50);
            this.label27.TabIndex = 68;
            this.label27.Text = "\r\nRun";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(99, 0);
            this.label28.Margin = new System.Windows.Forms.Padding(43, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 50);
            this.label28.TabIndex = 69;
            this.label28.Text = "\r\nReset";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(199, 0);
            this.label29.Margin = new System.Windows.Forms.Padding(41, 0, 5, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 50);
            this.label29.TabIndex = 70;
            this.label29.Text = "\r\nStep";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(281, 0);
            this.label30.Margin = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 50);
            this.label30.TabIndex = 71;
            this.label30.Text = "\r\nExamine";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(376, 0);
            this.label31.Margin = new System.Windows.Forms.Padding(13, 0, 5, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 50);
            this.label31.TabIndex = 72;
            this.label31.Text = "Examine\r\nNext";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(473, 0);
            this.label32.Margin = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 50);
            this.label32.TabIndex = 73;
            this.label32.Text = "\r\nDeposit";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.flowLayoutPanel4.SetFlowBreak(this.label33, true);
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(568, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 50);
            this.label33.TabIndex = 74;
            this.label33.Text = "Deposit\r\nNext";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SW_RunStop
            // 
            this.SW_RunStop.AllowRightClick = false;
            this.SW_RunStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_RunStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_RunStop.BackgroundImage")));
            this.SW_RunStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_RunStop.Checked = false;
            this.SW_RunStop.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_RunStop.KnobColor = System.Drawing.Color.Tan;
            this.SW_RunStop.Location = new System.Drawing.Point(8, 56);
            this.SW_RunStop.Margin = new System.Windows.Forms.Padding(8, 6, 33, 6);
            this.SW_RunStop.Momentary = false;
            this.SW_RunStop.Name = "SW_RunStop";
            this.SW_RunStop.Size = new System.Drawing.Size(38, 77);
            this.SW_RunStop.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_RunStop.TabIndex = 62;
            this.SW_RunStop.Tag = "7";
            this.SW_RunStop.CheckedChanged += new System.EventHandler(this.BUT_Run_Click);
            // 
            // SW_Reset
            // 
            this.SW_Reset.AllowRightClick = true;
            this.SW_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_Reset.BackgroundImage")));
            this.SW_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_Reset.Checked = false;
            this.SW_Reset.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_Reset.KnobColor = System.Drawing.Color.Tan;
            this.SW_Reset.Location = new System.Drawing.Point(104, 56);
            this.SW_Reset.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_Reset.Momentary = true;
            this.SW_Reset.Name = "SW_Reset";
            this.SW_Reset.Size = new System.Drawing.Size(38, 77);
            this.SW_Reset.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_Reset.TabIndex = 63;
            this.SW_Reset.Tag = "7";
            this.SW_Reset.Clicked += new System.EventHandler(this.BUT_Reset_Click);
            // 
            // SW_Step
            // 
            this.SW_Step.AllowRightClick = false;
            this.SW_Step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_Step.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_Step.BackgroundImage")));
            this.SW_Step.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_Step.Checked = false;
            this.SW_Step.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_Step.KnobColor = System.Drawing.Color.Tan;
            this.SW_Step.Location = new System.Drawing.Point(200, 56);
            this.SW_Step.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_Step.Momentary = true;
            this.SW_Step.Name = "SW_Step";
            this.SW_Step.Size = new System.Drawing.Size(38, 77);
            this.SW_Step.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_Step.TabIndex = 64;
            this.SW_Step.Tag = "7";
            this.SW_Step.Clicked += new System.EventHandler(this.BUT_Step_Click);
            // 
            // SW_Examine
            // 
            this.SW_Examine.AllowRightClick = false;
            this.SW_Examine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_Examine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_Examine.BackgroundImage")));
            this.SW_Examine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_Examine.Checked = false;
            this.SW_Examine.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_Examine.KnobColor = System.Drawing.Color.Tan;
            this.SW_Examine.Location = new System.Drawing.Point(296, 56);
            this.SW_Examine.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_Examine.Momentary = true;
            this.SW_Examine.Name = "SW_Examine";
            this.SW_Examine.Size = new System.Drawing.Size(38, 77);
            this.SW_Examine.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_Examine.TabIndex = 65;
            this.SW_Examine.Tag = "7";
            this.SW_Examine.Clicked += new System.EventHandler(this.Examine_Clicked);
            // 
            // SW_ExamineNext
            // 
            this.SW_ExamineNext.AllowRightClick = false;
            this.SW_ExamineNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_ExamineNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_ExamineNext.BackgroundImage")));
            this.SW_ExamineNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_ExamineNext.Checked = false;
            this.SW_ExamineNext.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_ExamineNext.KnobColor = System.Drawing.Color.Tan;
            this.SW_ExamineNext.Location = new System.Drawing.Point(392, 56);
            this.SW_ExamineNext.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_ExamineNext.Momentary = true;
            this.SW_ExamineNext.Name = "SW_ExamineNext";
            this.SW_ExamineNext.Size = new System.Drawing.Size(38, 77);
            this.SW_ExamineNext.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_ExamineNext.TabIndex = 66;
            this.SW_ExamineNext.Tag = "7";
            this.SW_ExamineNext.Clicked += new System.EventHandler(this.Examine_Clicked);
            // 
            // SW_Deposit
            // 
            this.SW_Deposit.AllowRightClick = false;
            this.SW_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_Deposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_Deposit.BackgroundImage")));
            this.SW_Deposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_Deposit.Checked = false;
            this.SW_Deposit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_Deposit.KnobColor = System.Drawing.Color.Tan;
            this.SW_Deposit.Location = new System.Drawing.Point(488, 56);
            this.SW_Deposit.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_Deposit.Momentary = true;
            this.SW_Deposit.Name = "SW_Deposit";
            this.SW_Deposit.Size = new System.Drawing.Size(38, 77);
            this.SW_Deposit.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_Deposit.TabIndex = 67;
            this.SW_Deposit.Tag = "7";
            this.SW_Deposit.Clicked += new System.EventHandler(this.Deposit_Clicked);
            // 
            // SW_DepositNext
            // 
            this.SW_DepositNext.AllowRightClick = false;
            this.SW_DepositNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_DepositNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_DepositNext.BackgroundImage")));
            this.SW_DepositNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_DepositNext.Checked = false;
            this.flowLayoutPanel4.SetFlowBreak(this.SW_DepositNext, true);
            this.SW_DepositNext.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_DepositNext.KnobColor = System.Drawing.Color.Tan;
            this.SW_DepositNext.Location = new System.Drawing.Point(584, 56);
            this.SW_DepositNext.Margin = new System.Windows.Forms.Padding(25, 6, 33, 6);
            this.SW_DepositNext.Momentary = true;
            this.SW_DepositNext.Name = "SW_DepositNext";
            this.SW_DepositNext.Size = new System.Drawing.Size(38, 77);
            this.SW_DepositNext.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_DepositNext.TabIndex = 75;
            this.SW_DepositNext.Tag = "7";
            this.SW_DepositNext.Clicked += new System.EventHandler(this.Deposit_Clicked);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(7, 139);
            this.label34.Margin = new System.Windows.Forms.Padding(7, 0, 5, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 25);
            this.label34.TabIndex = 76;
            this.label34.Text = "Stop";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Octal
            // 
            this.CB_Octal.AutoSize = true;
            this.CB_Octal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_Octal.Checked = true;
            this.CB_Octal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Octal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_Octal.Location = new System.Drawing.Point(186, 154);
            this.CB_Octal.Margin = new System.Windows.Forms.Padding(125, 15, 5, 6);
            this.CB_Octal.Name = "CB_Octal";
            this.CB_Octal.Size = new System.Drawing.Size(84, 21);
            this.CB_Octal.TabIndex = 64;
            this.CB_Octal.Text = "Octal";
            this.CB_Octal.UseVisualStyleBackColor = true;
            this.CB_Octal.CheckedChanged += new System.EventHandler(this.CB_Octal_CheckedChanged);
            // 
            // NB_FPAddress
            // 
            this.NB_FPAddress.BackColor = System.Drawing.Color.Black;
            this.NB_FPAddress.Base = 8;
            this.NB_FPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NB_FPAddress.Digits = 6;
            this.NB_FPAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NB_FPAddress.ForeColor = System.Drawing.Color.Silver;
            this.NB_FPAddress.Location = new System.Drawing.Point(280, 149);
            this.NB_FPAddress.Margin = new System.Windows.Forms.Padding(5, 10, 5, 6);
            this.NB_FPAddress.Maximum = 65535;
            this.NB_FPAddress.Minimum = 0;
            this.NB_FPAddress.Name = "NB_FPAddress";
            this.NB_FPAddress.SelectAllOnChange = false;
            this.NB_FPAddress.Size = new System.Drawing.Size(142, 31);
            this.NB_FPAddress.TabIndex = 63;
            this.NB_FPAddress.Text = "000000";
            this.NB_FPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NB_FPAddress.Value = 0;
            // 
            // NB_FPData
            // 
            this.NB_FPData.BackColor = System.Drawing.Color.Black;
            this.NB_FPData.Base = 8;
            this.NB_FPData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NB_FPData.Digits = 3;
            this.NB_FPData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NB_FPData.ForeColor = System.Drawing.Color.Silver;
            this.NB_FPData.Location = new System.Drawing.Point(474, 149);
            this.NB_FPData.Margin = new System.Windows.Forms.Padding(47, 10, 5, 6);
            this.NB_FPData.Maximum = 255;
            this.NB_FPData.Minimum = 0;
            this.NB_FPData.Name = "NB_FPData";
            this.NB_FPData.SelectAllOnChange = true;
            this.NB_FPData.Size = new System.Drawing.Size(142, 31);
            this.NB_FPData.TabIndex = 77;
            this.NB_FPData.Text = "000";
            this.NB_FPData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NB_FPData.Value = 0;
            // 
            // BUT_BinSave
            // 
            this.BUT_BinSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_BinSave.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_BinSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_BinSave.ForeColor = System.Drawing.Color.Black;
            this.BUT_BinSave.Location = new System.Drawing.Point(1430, 450);
            this.BUT_BinSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_BinSave.Name = "BUT_BinSave";
            this.BUT_BinSave.Size = new System.Drawing.Size(233, 44);
            this.BUT_BinSave.TabIndex = 63;
            this.BUT_BinSave.Text = "BIN SAVE FROM RAM";
            this.BUT_BinSave.UseVisualStyleBackColor = false;
            this.BUT_BinSave.Click += new System.EventHandler(this.BUT_BinSave_Click);
            // 
            // NUD_BinSaveAddr
            // 
            this.NUD_BinSaveAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_BinSaveAddr.BackColor = System.Drawing.Color.Black;
            this.NUD_BinSaveAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_BinSaveAddr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_BinSaveAddr.ForeColor = System.Drawing.Color.Silver;
            this.NUD_BinSaveAddr.Hexadecimal = true;
            this.NUD_BinSaveAddr.Location = new System.Drawing.Point(1668, 458);
            this.NUD_BinSaveAddr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_BinSaveAddr.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_BinSaveAddr.Name = "NUD_BinSaveAddr";
            this.NUD_BinSaveAddr.Size = new System.Drawing.Size(90, 31);
            this.NUD_BinSaveAddr.TabIndex = 64;
            this.NUD_BinSaveAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_BinSaveLength
            // 
            this.NUD_BinSaveLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_BinSaveLength.BackColor = System.Drawing.Color.Black;
            this.NUD_BinSaveLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_BinSaveLength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NUD_BinSaveLength.ForeColor = System.Drawing.Color.Silver;
            this.NUD_BinSaveLength.Hexadecimal = true;
            this.NUD_BinSaveLength.Location = new System.Drawing.Point(1758, 458);
            this.NUD_BinSaveLength.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NUD_BinSaveLength.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NUD_BinSaveLength.Name = "NUD_BinSaveLength";
            this.NUD_BinSaveLength.Size = new System.Drawing.Size(90, 31);
            this.NUD_BinSaveLength.TabIndex = 65;
            this.NUD_BinSaveLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_BinSaveLength.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // TTB_DiskName0
            // 
            this.TTB_DiskName0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTB_DiskName0.AutoSize = true;
            this.TTB_DiskName0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TTB_DiskName0.FlatAppearance.BorderSize = 0;
            this.TTB_DiskName0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTB_DiskName0.ForeColor = System.Drawing.Color.Silver;
            this.TTB_DiskName0.Location = new System.Drawing.Point(1623, 10);
            this.TTB_DiskName0.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TTB_DiskName0.Name = "TTB_DiskName0";
            this.TTB_DiskName0.Size = new System.Drawing.Size(352, 44);
            this.TTB_DiskName0.TabIndex = 66;
            this.TTB_DiskName0.Text = "(Empty)";
            this.TTB_DiskName0.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TTB_DiskName0.UseVisualStyleBackColor = false;
            // 
            // TTB_DiskName1
            // 
            this.TTB_DiskName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTB_DiskName1.AutoSize = true;
            this.TTB_DiskName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TTB_DiskName1.FlatAppearance.BorderSize = 0;
            this.TTB_DiskName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTB_DiskName1.ForeColor = System.Drawing.Color.Silver;
            this.TTB_DiskName1.Location = new System.Drawing.Point(1623, 56);
            this.TTB_DiskName1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TTB_DiskName1.Name = "TTB_DiskName1";
            this.TTB_DiskName1.Size = new System.Drawing.Size(352, 44);
            this.TTB_DiskName1.TabIndex = 67;
            this.TTB_DiskName1.Text = "(Empty)";
            this.TTB_DiskName1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TTB_DiskName1.UseVisualStyleBackColor = false;
            // 
            // TTB_DiskName2
            // 
            this.TTB_DiskName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTB_DiskName2.AutoSize = true;
            this.TTB_DiskName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TTB_DiskName2.FlatAppearance.BorderSize = 0;
            this.TTB_DiskName2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTB_DiskName2.ForeColor = System.Drawing.Color.Silver;
            this.TTB_DiskName2.Location = new System.Drawing.Point(1623, 102);
            this.TTB_DiskName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TTB_DiskName2.Name = "TTB_DiskName2";
            this.TTB_DiskName2.Size = new System.Drawing.Size(352, 44);
            this.TTB_DiskName2.TabIndex = 68;
            this.TTB_DiskName2.Text = "(Empty)";
            this.TTB_DiskName2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TTB_DiskName2.UseVisualStyleBackColor = false;
            // 
            // TTB_DiskName3
            // 
            this.TTB_DiskName3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TTB_DiskName3.AutoSize = true;
            this.TTB_DiskName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TTB_DiskName3.FlatAppearance.BorderSize = 0;
            this.TTB_DiskName3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TTB_DiskName3.ForeColor = System.Drawing.Color.Silver;
            this.TTB_DiskName3.Location = new System.Drawing.Point(1623, 148);
            this.TTB_DiskName3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TTB_DiskName3.Name = "TTB_DiskName3";
            this.TTB_DiskName3.Size = new System.Drawing.Size(352, 44);
            this.TTB_DiskName3.TabIndex = 69;
            this.TTB_DiskName3.Text = "(Empty)";
            this.TTB_DiskName3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TTB_DiskName3.UseVisualStyleBackColor = false;
            // 
            // CB_SenseSwMomentary
            // 
            this.CB_SenseSwMomentary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_SenseSwMomentary.AutoSize = true;
            this.CB_SenseSwMomentary.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel6.SetFlowBreak(this.CB_SenseSwMomentary, true);
            this.CB_SenseSwMomentary.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_SenseSwMomentary.ForeColor = System.Drawing.Color.Silver;
            this.CB_SenseSwMomentary.Location = new System.Drawing.Point(218, 82);
            this.CB_SenseSwMomentary.Margin = new System.Windows.Forms.Padding(167, 6, 5, 6);
            this.CB_SenseSwMomentary.Name = "CB_SenseSwMomentary";
            this.CB_SenseSwMomentary.Size = new System.Drawing.Size(194, 38);
            this.CB_SenseSwMomentary.TabIndex = 70;
            this.CB_SenseSwMomentary.Text = "Sense Switch\r\nMomentary Action";
            this.CB_SenseSwMomentary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_SenseSwMomentary.UseVisualStyleBackColor = true;
            this.CB_SenseSwMomentary.CheckedChanged += new System.EventHandler(this.CB_SenseSwMomentary_CheckedChanged);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.Controls.Add(this.LED_IE);
            this.flowLayoutPanel6.Controls.Add(this.LED_RM);
            this.flowLayoutPanel6.Controls.Add(this.LED_IN);
            this.flowLayoutPanel6.Controls.Add(this.LED_M1);
            this.flowLayoutPanel6.Controls.Add(this.LED_OUT);
            this.flowLayoutPanel6.Controls.Add(this.LED_HLT);
            this.flowLayoutPanel6.Controls.Add(this.LED_STK);
            this.flowLayoutPanel6.Controls.Add(this.LED_WO);
            this.flowLayoutPanel6.Controls.Add(this.LED_INT);
            this.flowLayoutPanel6.Controls.Add(this.label35);
            this.flowLayoutPanel6.Controls.Add(this.label36);
            this.flowLayoutPanel6.Controls.Add(this.label37);
            this.flowLayoutPanel6.Controls.Add(this.label38);
            this.flowLayoutPanel6.Controls.Add(this.label39);
            this.flowLayoutPanel6.Controls.Add(this.label40);
            this.flowLayoutPanel6.Controls.Add(this.label41);
            this.flowLayoutPanel6.Controls.Add(this.label42);
            this.flowLayoutPanel6.Controls.Add(this.label43);
            this.flowLayoutPanel6.Controls.Add(this.LED_WAIT);
            this.flowLayoutPanel6.Controls.Add(this.CB_SenseSwMomentary);
            this.flowLayoutPanel6.Controls.Add(this.label44);
            this.flowLayoutPanel6.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel6.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(675, 1071);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(430, 192);
            this.flowLayoutPanel6.TabIndex = 71;
            // 
            // LED_IE
            // 
            this.LED_IE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_IE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_IE.BackgroundImage")));
            this.LED_IE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_IE.Brightness = 3;
            this.LED_IE.ErrorImage = null;
            this.LED_IE.HousingColor = System.Drawing.Color.Gray;
            this.LED_IE.InitialImage = null;
            this.LED_IE.Invert = false;
            this.LED_IE.LedColor = System.Drawing.Color.Red;
            this.LED_IE.Location = new System.Drawing.Point(7, 0);
            this.LED_IE.Margin = new System.Windows.Forms.Padding(7, 0, 2, 0);
            this.LED_IE.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_IE.Name = "LED_IE";
            this.LED_IE.Size = new System.Drawing.Size(42, 42);
            this.LED_IE.TabIndex = 64;
            this.LED_IE.TabStop = false;
            // 
            // LED_RM
            // 
            this.LED_RM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_RM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_RM.BackgroundImage")));
            this.LED_RM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_RM.Brightness = 26;
            this.LED_RM.ErrorImage = null;
            this.LED_RM.HousingColor = System.Drawing.Color.Gray;
            this.LED_RM.InitialImage = null;
            this.LED_RM.Invert = false;
            this.LED_RM.LedColor = System.Drawing.Color.Red;
            this.LED_RM.Location = new System.Drawing.Point(53, 0);
            this.LED_RM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_RM.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_RM.Name = "LED_RM";
            this.LED_RM.Size = new System.Drawing.Size(42, 42);
            this.LED_RM.TabIndex = 65;
            this.LED_RM.TabStop = false;
            // 
            // LED_IN
            // 
            this.LED_IN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_IN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_IN.BackgroundImage")));
            this.LED_IN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_IN.Brightness = 7;
            this.LED_IN.ErrorImage = null;
            this.LED_IN.HousingColor = System.Drawing.Color.Gray;
            this.LED_IN.InitialImage = null;
            this.LED_IN.Invert = false;
            this.LED_IN.LedColor = System.Drawing.Color.Red;
            this.LED_IN.Location = new System.Drawing.Point(99, 0);
            this.LED_IN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_IN.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_IN.Name = "LED_IN";
            this.LED_IN.Size = new System.Drawing.Size(42, 42);
            this.LED_IN.TabIndex = 66;
            this.LED_IN.TabStop = false;
            // 
            // LED_M1
            // 
            this.LED_M1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_M1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_M1.BackgroundImage")));
            this.LED_M1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_M1.Brightness = 11;
            this.LED_M1.ErrorImage = null;
            this.LED_M1.HousingColor = System.Drawing.Color.Gray;
            this.LED_M1.InitialImage = null;
            this.LED_M1.Invert = false;
            this.LED_M1.LedColor = System.Drawing.Color.Red;
            this.LED_M1.Location = new System.Drawing.Point(145, 0);
            this.LED_M1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_M1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_M1.Name = "LED_M1";
            this.LED_M1.Size = new System.Drawing.Size(42, 42);
            this.LED_M1.TabIndex = 67;
            this.LED_M1.TabStop = false;
            // 
            // LED_OUT
            // 
            this.LED_OUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_OUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_OUT.BackgroundImage")));
            this.LED_OUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_OUT.Brightness = 4;
            this.LED_OUT.ErrorImage = null;
            this.LED_OUT.HousingColor = System.Drawing.Color.Gray;
            this.LED_OUT.InitialImage = null;
            this.LED_OUT.Invert = false;
            this.LED_OUT.LedColor = System.Drawing.Color.Red;
            this.LED_OUT.Location = new System.Drawing.Point(191, 0);
            this.LED_OUT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_OUT.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_OUT.Name = "LED_OUT";
            this.LED_OUT.Size = new System.Drawing.Size(42, 42);
            this.LED_OUT.TabIndex = 68;
            this.LED_OUT.TabStop = false;
            // 
            // LED_HLT
            // 
            this.LED_HLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_HLT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_HLT.BackgroundImage")));
            this.LED_HLT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_HLT.Brightness = 2;
            this.LED_HLT.ErrorImage = null;
            this.LED_HLT.HousingColor = System.Drawing.Color.Gray;
            this.LED_HLT.InitialImage = null;
            this.LED_HLT.Invert = false;
            this.LED_HLT.LedColor = System.Drawing.Color.Red;
            this.LED_HLT.Location = new System.Drawing.Point(237, 0);
            this.LED_HLT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_HLT.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_HLT.Name = "LED_HLT";
            this.LED_HLT.Size = new System.Drawing.Size(42, 42);
            this.LED_HLT.TabIndex = 69;
            this.LED_HLT.TabStop = false;
            // 
            // LED_STK
            // 
            this.LED_STK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_STK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_STK.BackgroundImage")));
            this.LED_STK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_STK.Brightness = 3;
            this.LED_STK.ErrorImage = null;
            this.LED_STK.HousingColor = System.Drawing.Color.Gray;
            this.LED_STK.InitialImage = null;
            this.LED_STK.Invert = false;
            this.LED_STK.LedColor = System.Drawing.Color.Red;
            this.LED_STK.Location = new System.Drawing.Point(283, 0);
            this.LED_STK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_STK.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_STK.Name = "LED_STK";
            this.LED_STK.Size = new System.Drawing.Size(42, 42);
            this.LED_STK.TabIndex = 70;
            this.LED_STK.TabStop = false;
            // 
            // LED_WO
            // 
            this.LED_WO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_WO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_WO.BackgroundImage")));
            this.LED_WO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_WO.Brightness = 13;
            this.LED_WO.ErrorImage = null;
            this.LED_WO.HousingColor = System.Drawing.Color.Gray;
            this.LED_WO.InitialImage = null;
            this.LED_WO.Invert = false;
            this.LED_WO.LedColor = System.Drawing.Color.Red;
            this.LED_WO.Location = new System.Drawing.Point(329, 0);
            this.LED_WO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_WO.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_WO.Name = "LED_WO";
            this.LED_WO.Size = new System.Drawing.Size(42, 42);
            this.LED_WO.TabIndex = 71;
            this.LED_WO.TabStop = false;
            // 
            // LED_INT
            // 
            this.LED_INT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_INT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_INT.BackgroundImage")));
            this.LED_INT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_INT.Brightness = 23;
            this.LED_INT.ErrorImage = null;
            this.flowLayoutPanel6.SetFlowBreak(this.LED_INT, true);
            this.LED_INT.HousingColor = System.Drawing.Color.Gray;
            this.LED_INT.InitialImage = null;
            this.LED_INT.Invert = false;
            this.LED_INT.LedColor = System.Drawing.Color.Red;
            this.LED_INT.Location = new System.Drawing.Point(375, 0);
            this.LED_INT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_INT.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_INT.Name = "LED_INT";
            this.LED_INT.Size = new System.Drawing.Size(42, 42);
            this.LED_INT.TabIndex = 72;
            this.LED_INT.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label35.Location = new System.Drawing.Point(15, 46);
            this.label35.Margin = new System.Windows.Forms.Padding(15, 4, 0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 17);
            this.label35.TabIndex = 72;
            this.label35.Text = "IE";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(61, 46);
            this.label36.Margin = new System.Windows.Forms.Padding(18, 4, 0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(28, 17);
            this.label36.TabIndex = 74;
            this.label36.Text = "RM";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(107, 46);
            this.label37.Margin = new System.Windows.Forms.Padding(18, 4, 0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 17);
            this.label37.TabIndex = 75;
            this.label37.Text = "IN";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(153, 46);
            this.label38.Margin = new System.Windows.Forms.Padding(18, 4, 0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 17);
            this.label38.TabIndex = 76;
            this.label38.Text = "M1";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(194, 46);
            this.label39.Margin = new System.Windows.Forms.Padding(13, 4, 0, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 17);
            this.label39.TabIndex = 77;
            this.label39.Text = "OUT";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label40.Location = new System.Drawing.Point(240, 46);
            this.label40.Margin = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(38, 17);
            this.label40.TabIndex = 78;
            this.label40.Text = "HLT";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label41.Location = new System.Drawing.Point(285, 46);
            this.label41.Margin = new System.Windows.Forms.Padding(7, 4, 0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(38, 17);
            this.label41.TabIndex = 79;
            this.label41.Text = "STK";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label42.Location = new System.Drawing.Point(335, 46);
            this.label42.Margin = new System.Windows.Forms.Padding(12, 4, 0, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(28, 17);
            this.label42.TabIndex = 80;
            this.label42.Text = "WO";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.flowLayoutPanel6.SetFlowBreak(this.label43, true);
            this.label43.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label43.Location = new System.Drawing.Point(375, 46);
            this.label43.Margin = new System.Windows.Forms.Padding(12, 4, 0, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(38, 17);
            this.label43.TabIndex = 81;
            this.label43.Text = "INT";
            // 
            // LED_WAIT
            // 
            this.LED_WAIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_WAIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_WAIT.BackgroundImage")));
            this.LED_WAIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_WAIT.Brightness = 3;
            this.LED_WAIT.ErrorImage = null;
            this.LED_WAIT.HousingColor = System.Drawing.Color.Gray;
            this.LED_WAIT.InitialImage = null;
            this.LED_WAIT.Invert = false;
            this.LED_WAIT.LedColor = System.Drawing.Color.Red;
            this.LED_WAIT.Location = new System.Drawing.Point(7, 84);
            this.LED_WAIT.Margin = new System.Windows.Forms.Padding(7, 21, 2, 0);
            this.LED_WAIT.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_WAIT.Name = "LED_WAIT";
            this.LED_WAIT.Size = new System.Drawing.Size(42, 42);
            this.LED_WAIT.TabIndex = 82;
            this.LED_WAIT.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label44.Location = new System.Drawing.Point(6, 130);
            this.label44.Margin = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(48, 17);
            this.label44.TabIndex = 83;
            this.label44.Text = "WAIT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Altair64.Properties.Resources.front;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(62, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 17, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 43);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // BUT_Presets
            // 
            this.BUT_Presets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Presets.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_Presets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Presets.ForeColor = System.Drawing.Color.Black;
            this.BUT_Presets.Location = new System.Drawing.Point(1666, 227);
            this.BUT_Presets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Presets.Name = "BUT_Presets";
            this.BUT_Presets.Size = new System.Drawing.Size(177, 44);
            this.BUT_Presets.TabIndex = 75;
            this.BUT_Presets.Text = "PRESETS";
            this.BUT_Presets.UseVisualStyleBackColor = false;
            // 
            // CMS_CassetteOptions
            // 
            this.CMS_CassetteOptions.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.CMS_CassetteOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CassetteAudioOptions});
            this.CMS_CassetteOptions.Name = "CMS_CassetteOptions";
            this.CMS_CassetteOptions.Size = new System.Drawing.Size(273, 36);
            // 
            // TSMI_CassetteAudioOptions
            // 
            this.TSMI_CassetteAudioOptions.Name = "TSMI_CassetteAudioOptions";
            this.TSMI_CassetteAudioOptions.Size = new System.Drawing.Size(272, 32);
            this.TSMI_CassetteAudioOptions.Text = "Cassette Audio Options";
            this.TSMI_CassetteAudioOptions.Click += new System.EventHandler(this.TSMI_CassetteAudioOptions_Click);
            // 
            // LED_Drive3
            // 
            this.LED_Drive3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_Drive3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_Drive3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_Drive3.BackgroundImage")));
            this.LED_Drive3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_Drive3.Brightness = 2;
            this.LED_Drive3.ErrorImage = null;
            this.LED_Drive3.HousingColor = System.Drawing.Color.Gray;
            this.LED_Drive3.InitialImage = null;
            this.LED_Drive3.Invert = false;
            this.LED_Drive3.LedColor = System.Drawing.Color.Red;
            this.LED_Drive3.Location = new System.Drawing.Point(1585, 148);
            this.LED_Drive3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_Drive3.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Drive3.Name = "LED_Drive3";
            this.LED_Drive3.Size = new System.Drawing.Size(40, 40);
            this.LED_Drive3.TabIndex = 74;
            this.LED_Drive3.TabStop = false;
            // 
            // LED_Drive2
            // 
            this.LED_Drive2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_Drive2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_Drive2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_Drive2.BackgroundImage")));
            this.LED_Drive2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_Drive2.Brightness = 0;
            this.LED_Drive2.ErrorImage = null;
            this.LED_Drive2.HousingColor = System.Drawing.Color.Gray;
            this.LED_Drive2.InitialImage = null;
            this.LED_Drive2.Invert = false;
            this.LED_Drive2.LedColor = System.Drawing.Color.Red;
            this.LED_Drive2.Location = new System.Drawing.Point(1585, 102);
            this.LED_Drive2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_Drive2.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Drive2.Name = "LED_Drive2";
            this.LED_Drive2.Size = new System.Drawing.Size(40, 40);
            this.LED_Drive2.TabIndex = 74;
            this.LED_Drive2.TabStop = false;
            // 
            // LED_Drive1
            // 
            this.LED_Drive1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_Drive1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_Drive1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_Drive1.BackgroundImage")));
            this.LED_Drive1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_Drive1.Brightness = 4;
            this.LED_Drive1.ErrorImage = null;
            this.LED_Drive1.HousingColor = System.Drawing.Color.Gray;
            this.LED_Drive1.InitialImage = null;
            this.LED_Drive1.Invert = false;
            this.LED_Drive1.LedColor = System.Drawing.Color.Red;
            this.LED_Drive1.Location = new System.Drawing.Point(1585, 56);
            this.LED_Drive1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_Drive1.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Drive1.Name = "LED_Drive1";
            this.LED_Drive1.Size = new System.Drawing.Size(40, 40);
            this.LED_Drive1.TabIndex = 74;
            this.LED_Drive1.TabStop = false;
            // 
            // LED_Drive0
            // 
            this.LED_Drive0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_Drive0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_Drive0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_Drive0.BackgroundImage")));
            this.LED_Drive0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_Drive0.Brightness = 1;
            this.LED_Drive0.ErrorImage = null;
            this.LED_Drive0.HousingColor = System.Drawing.Color.Gray;
            this.LED_Drive0.InitialImage = null;
            this.LED_Drive0.Invert = false;
            this.LED_Drive0.LedColor = System.Drawing.Color.Red;
            this.LED_Drive0.Location = new System.Drawing.Point(1585, 10);
            this.LED_Drive0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_Drive0.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Drive0.Name = "LED_Drive0";
            this.LED_Drive0.Size = new System.Drawing.Size(40, 40);
            this.LED_Drive0.TabIndex = 74;
            this.LED_Drive0.TabStop = false;
            // 
            // LED_CassetteData
            // 
            this.LED_CassetteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_CassetteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_CassetteData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_CassetteData.BackgroundImage")));
            this.LED_CassetteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_CassetteData.Brightness = 1;
            this.LED_CassetteData.ContextMenuStrip = this.CMS_CassetteOptions;
            this.LED_CassetteData.ErrorImage = null;
            this.LED_CassetteData.HousingColor = System.Drawing.Color.Gray;
            this.LED_CassetteData.InitialImage = null;
            this.LED_CassetteData.Invert = false;
            this.LED_CassetteData.LedColor = System.Drawing.Color.Red;
            this.LED_CassetteData.Location = new System.Drawing.Point(1988, 150);
            this.LED_CassetteData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_CassetteData.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_CassetteData.Name = "LED_CassetteData";
            this.LED_CassetteData.Size = new System.Drawing.Size(43, 43);
            this.LED_CassetteData.TabIndex = 73;
            this.LED_CassetteData.TabStop = false;
            // 
            // BUT_CassAudio
            // 
            this.BUT_CassAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_CassAudio.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_CassAudio.ContextMenuStrip = this.CMS_CassetteOptions;
            this.BUT_CassAudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_CassAudio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_CassAudio.ForeColor = System.Drawing.Color.Black;
            this.BUT_CassAudio.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_CassAudio.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_CassAudio.Highlighted1 = false;
            this.BUT_CassAudio.Highlighted2 = false;
            this.BUT_CassAudio.Location = new System.Drawing.Point(1986, 70);
            this.BUT_CassAudio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_CassAudio.Name = "BUT_CassAudio";
            this.BUT_CassAudio.Size = new System.Drawing.Size(160, 71);
            this.BUT_CassAudio.TabIndex = 72;
            this.BUT_CassAudio.Text = "CASSETTE\r\nAUDIO";
            this.BUT_CassAudio.UseVisualStyleBackColor = false;
            this.BUT_CassAudio.Click += new System.EventHandler(this.CassetteAudio_Clicked);
            // 
            // LED_Cassette
            // 
            this.LED_Cassette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LED_Cassette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LED_Cassette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LED_Cassette.BackgroundImage")));
            this.LED_Cassette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LED_Cassette.Brightness = 4;
            this.LED_Cassette.ContextMenuStrip = this.CMS_CassetteOptions;
            this.LED_Cassette.ErrorImage = null;
            this.LED_Cassette.HousingColor = System.Drawing.Color.Gray;
            this.LED_Cassette.InitialImage = null;
            this.LED_Cassette.Invert = false;
            this.LED_Cassette.LedColor = System.Drawing.Color.Red;
            this.LED_Cassette.Location = new System.Drawing.Point(2101, 150);
            this.LED_Cassette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LED_Cassette.MaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Cassette.Name = "LED_Cassette";
            this.LED_Cassette.Size = new System.Drawing.Size(43, 43);
            this.LED_Cassette.TabIndex = 72;
            this.LED_Cassette.TabStop = false;
            // 
            // SW_A7
            // 
            this.SW_A7.AllowRightClick = false;
            this.SW_A7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A7.BackgroundImage")));
            this.SW_A7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A7.Checked = false;
            this.SW_A7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A7.KnobColor = System.Drawing.Color.Tan;
            this.SW_A7.Location = new System.Drawing.Point(1121, 1077);
            this.SW_A7.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A7.Momentary = false;
            this.SW_A7.Name = "SW_A7";
            this.SW_A7.Size = new System.Drawing.Size(38, 77);
            this.SW_A7.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A7.TabIndex = 61;
            this.SW_A7.Tag = "7";
            this.SW_A7.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A6
            // 
            this.SW_A6.AllowRightClick = false;
            this.SW_A6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A6.BackgroundImage")));
            this.SW_A6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A6.Checked = false;
            this.SW_A6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A6.KnobColor = System.Drawing.Color.Tan;
            this.SW_A6.Location = new System.Drawing.Point(1190, 1077);
            this.SW_A6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A6.Momentary = false;
            this.SW_A6.Name = "SW_A6";
            this.SW_A6.Size = new System.Drawing.Size(38, 77);
            this.SW_A6.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A6.TabIndex = 61;
            this.SW_A6.Tag = "6";
            this.SW_A6.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A5
            // 
            this.SW_A5.AllowRightClick = false;
            this.SW_A5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A5.BackgroundImage")));
            this.SW_A5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A5.Checked = false;
            this.SW_A5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A5.KnobColor = System.Drawing.Color.Tan;
            this.SW_A5.Location = new System.Drawing.Point(1243, 1077);
            this.SW_A5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A5.Momentary = false;
            this.SW_A5.Name = "SW_A5";
            this.SW_A5.Size = new System.Drawing.Size(38, 77);
            this.SW_A5.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A5.TabIndex = 61;
            this.SW_A5.Tag = "5";
            this.SW_A5.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A4
            // 
            this.SW_A4.AllowRightClick = false;
            this.SW_A4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A4.BackgroundImage")));
            this.SW_A4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A4.Checked = false;
            this.SW_A4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A4.KnobColor = System.Drawing.Color.Tan;
            this.SW_A4.Location = new System.Drawing.Point(1296, 1077);
            this.SW_A4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A4.Momentary = false;
            this.SW_A4.Name = "SW_A4";
            this.SW_A4.Size = new System.Drawing.Size(38, 77);
            this.SW_A4.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A4.TabIndex = 61;
            this.SW_A4.Tag = "4";
            this.SW_A4.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A3
            // 
            this.SW_A3.AllowRightClick = false;
            this.SW_A3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A3.BackgroundImage")));
            this.SW_A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A3.Checked = false;
            this.SW_A3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A3.KnobColor = System.Drawing.Color.Tan;
            this.SW_A3.Location = new System.Drawing.Point(1365, 1077);
            this.SW_A3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A3.Momentary = false;
            this.SW_A3.Name = "SW_A3";
            this.SW_A3.Size = new System.Drawing.Size(38, 77);
            this.SW_A3.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A3.TabIndex = 61;
            this.SW_A3.Tag = "3";
            this.SW_A3.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A2
            // 
            this.SW_A2.AllowRightClick = false;
            this.SW_A2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A2.BackgroundImage")));
            this.SW_A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A2.Checked = false;
            this.SW_A2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A2.KnobColor = System.Drawing.Color.Tan;
            this.SW_A2.Location = new System.Drawing.Point(1418, 1077);
            this.SW_A2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A2.Momentary = false;
            this.SW_A2.Name = "SW_A2";
            this.SW_A2.Size = new System.Drawing.Size(38, 77);
            this.SW_A2.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A2.TabIndex = 61;
            this.SW_A2.Tag = "2";
            this.SW_A2.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A1
            // 
            this.SW_A1.AllowRightClick = false;
            this.SW_A1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A1.BackgroundImage")));
            this.SW_A1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A1.Checked = false;
            this.SW_A1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A1.KnobColor = System.Drawing.Color.Tan;
            this.SW_A1.Location = new System.Drawing.Point(1471, 1077);
            this.SW_A1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A1.Momentary = false;
            this.SW_A1.Name = "SW_A1";
            this.SW_A1.Size = new System.Drawing.Size(38, 77);
            this.SW_A1.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A1.TabIndex = 61;
            this.SW_A1.Tag = "1";
            this.SW_A1.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // SW_A0
            // 
            this.SW_A0.AllowRightClick = false;
            this.SW_A0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SW_A0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SW_A0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SW_A0.BackgroundImage")));
            this.SW_A0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SW_A0.Checked = false;
            this.SW_A0.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SW_A0.KnobColor = System.Drawing.Color.Tan;
            this.SW_A0.Location = new System.Drawing.Point(1540, 1077);
            this.SW_A0.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SW_A0.Momentary = false;
            this.SW_A0.Name = "SW_A0";
            this.SW_A0.Size = new System.Drawing.Size(38, 77);
            this.SW_A0.SwitchBackColor = System.Drawing.Color.Black;
            this.SW_A0.TabIndex = 61;
            this.SW_A0.Tag = "0";
            this.SW_A0.CheckedChanged += new System.EventHandler(this.FrontSwitch_Changed);
            // 
            // BUT_Capture
            // 
            this.BUT_Capture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Capture.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_Capture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Capture.ForeColor = System.Drawing.Color.Black;
            this.BUT_Capture.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Capture.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Capture.Highlighted1 = false;
            this.BUT_Capture.Highlighted2 = false;
            this.BUT_Capture.Location = new System.Drawing.Point(1430, 338);
            this.BUT_Capture.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Capture.Name = "BUT_Capture";
            this.BUT_Capture.Size = new System.Drawing.Size(233, 44);
            this.BUT_Capture.TabIndex = 30;
            this.BUT_Capture.Tag = "STOP CAPTURE";
            this.BUT_Capture.Text = "CAPTURE FROM";
            this.BUT_Capture.UseVisualStyleBackColor = false;
            this.BUT_Capture.Click += new System.EventHandler(this.BUT_Capture_Click);
            // 
            // BUT_Disk3
            // 
            this.BUT_Disk3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Disk3.BackColor = System.Drawing.Color.Gray;
            this.BUT_Disk3.ContextMenuStrip = this.CMS_DiskOptions;
            this.BUT_Disk3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Disk3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Disk3.ForeColor = System.Drawing.Color.Black;
            this.BUT_Disk3.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Disk3.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Disk3.Highlighted1 = false;
            this.BUT_Disk3.Highlighted2 = false;
            this.BUT_Disk3.Location = new System.Drawing.Point(1430, 146);
            this.BUT_Disk3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Disk3.Name = "BUT_Disk3";
            this.BUT_Disk3.Size = new System.Drawing.Size(107, 44);
            this.BUT_Disk3.TabIndex = 22;
            this.BUT_Disk3.Tag = "3";
            this.BUT_Disk3.Text = "DISK 3";
            this.BUT_Disk3.UseVisualStyleBackColor = false;
            this.BUT_Disk3.Click += new System.EventHandler(this.Disk_Button_Clicked);
            this.BUT_Disk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BUT_Disk_MouseDown);
            // 
            // BUT_Disk2
            // 
            this.BUT_Disk2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Disk2.BackColor = System.Drawing.Color.Gray;
            this.BUT_Disk2.ContextMenuStrip = this.CMS_DiskOptions;
            this.BUT_Disk2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Disk2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Disk2.ForeColor = System.Drawing.Color.Black;
            this.BUT_Disk2.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Disk2.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Disk2.Highlighted1 = false;
            this.BUT_Disk2.Highlighted2 = false;
            this.BUT_Disk2.Location = new System.Drawing.Point(1430, 100);
            this.BUT_Disk2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Disk2.Name = "BUT_Disk2";
            this.BUT_Disk2.Size = new System.Drawing.Size(107, 44);
            this.BUT_Disk2.TabIndex = 21;
            this.BUT_Disk2.Tag = "2";
            this.BUT_Disk2.Text = "DISK 2";
            this.BUT_Disk2.UseVisualStyleBackColor = false;
            this.BUT_Disk2.Click += new System.EventHandler(this.Disk_Button_Clicked);
            this.BUT_Disk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BUT_Disk_MouseDown);
            // 
            // BUT_Disk1
            // 
            this.BUT_Disk1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Disk1.BackColor = System.Drawing.Color.Gray;
            this.BUT_Disk1.ContextMenuStrip = this.CMS_DiskOptions;
            this.BUT_Disk1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Disk1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Disk1.ForeColor = System.Drawing.Color.Black;
            this.BUT_Disk1.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Disk1.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Disk1.Highlighted1 = false;
            this.BUT_Disk1.Highlighted2 = false;
            this.BUT_Disk1.Location = new System.Drawing.Point(1430, 54);
            this.BUT_Disk1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Disk1.Name = "BUT_Disk1";
            this.BUT_Disk1.Size = new System.Drawing.Size(107, 44);
            this.BUT_Disk1.TabIndex = 20;
            this.BUT_Disk1.Tag = "1";
            this.BUT_Disk1.Text = "DISK 1";
            this.BUT_Disk1.UseVisualStyleBackColor = false;
            this.BUT_Disk1.Click += new System.EventHandler(this.Disk_Button_Clicked);
            this.BUT_Disk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BUT_Disk_MouseDown);
            // 
            // BUT_Disk0
            // 
            this.BUT_Disk0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Disk0.BackColor = System.Drawing.Color.Gray;
            this.BUT_Disk0.ContextMenuStrip = this.CMS_DiskOptions;
            this.BUT_Disk0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Disk0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BUT_Disk0.ForeColor = System.Drawing.Color.Black;
            this.BUT_Disk0.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Disk0.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Disk0.Highlighted1 = false;
            this.BUT_Disk0.Highlighted2 = false;
            this.BUT_Disk0.Location = new System.Drawing.Point(1430, 8);
            this.BUT_Disk0.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Disk0.Name = "BUT_Disk0";
            this.BUT_Disk0.Size = new System.Drawing.Size(107, 44);
            this.BUT_Disk0.TabIndex = 19;
            this.BUT_Disk0.Tag = "0";
            this.BUT_Disk0.Text = "DISK 0";
            this.BUT_Disk0.UseVisualStyleBackColor = false;
            this.BUT_Disk0.Click += new System.EventHandler(this.Disk_Button_Clicked);
            this.BUT_Disk0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BUT_Disk_MouseDown);
            // 
            // BUT_Load
            // 
            this.BUT_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Load.BackColor = System.Drawing.Color.DarkGray;
            this.BUT_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_Load.ForeColor = System.Drawing.Color.Black;
            this.BUT_Load.HighlightColor1 = System.Drawing.Color.LightGoldenrodYellow;
            this.BUT_Load.HighlightColor2 = System.Drawing.Color.LightSalmon;
            this.BUT_Load.Highlighted1 = false;
            this.BUT_Load.Highlighted2 = false;
            this.BUT_Load.Location = new System.Drawing.Point(1430, 282);
            this.BUT_Load.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BUT_Load.Name = "BUT_Load";
            this.BUT_Load.Size = new System.Drawing.Size(233, 44);
            this.BUT_Load.TabIndex = 3;
            this.BUT_Load.Text = "SEND TO DEVICE";
            this.BUT_Load.UseVisualStyleBackColor = false;
            this.BUT_Load.Click += new System.EventHandler(this.BUT_Load_Click);
            // 
            // BUT_Commit
            // 
            this.BUT_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Commit.Location = new System.Drawing.Point(1966, 1018);
            this.BUT_Commit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BUT_Commit.Name = "BUT_Commit";
            this.BUT_Commit.Size = new System.Drawing.Size(173, 33);
            this.BUT_Commit.TabIndex = 76;
            this.BUT_Commit.Text = "Commit Changes";
            this.BUT_Commit.UseVisualStyleBackColor = true;
            this.BUT_Commit.Click += new System.EventHandler(this.BUT_Commit_Click);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(1442, 196);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(163, 25);
            this.label46.TabIndex = 77;
            this.label46.Text = "(C) 2022 by nicsure";
            // 
            // LL_Youtube
            // 
            this.LL_Youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LL_Youtube.AutoSize = true;
            this.LL_Youtube.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.LL_Youtube.Location = new System.Drawing.Point(1598, 196);
            this.LL_Youtube.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LL_Youtube.Name = "LL_Youtube";
            this.LL_Youtube.Size = new System.Drawing.Size(238, 25);
            this.LL_Youtube.TabIndex = 78;
            this.LL_Youtube.TabStop = true;
            this.LL_Youtube.Text = "https://youtube.com/nicsure";
            this.LL_Youtube.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LL_Youtube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Youtube_LinkClicked);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2158, 1267);
            this.Controls.Add(this.LL_Youtube);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.BUT_Commit);
            this.Controls.Add(this.BUT_Presets);
            this.Controls.Add(this.BUT_LoadHex);
            this.Controls.Add(this.LED_Drive3);
            this.Controls.Add(this.LED_Drive2);
            this.Controls.Add(this.LED_Drive1);
            this.Controls.Add(this.LED_Drive0);
            this.Controls.Add(this.LED_CassetteData);
            this.Controls.Add(this.BUT_CassAudio);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.TTB_DiskName3);
            this.Controls.Add(this.TTB_DiskName2);
            this.Controls.Add(this.TTB_DiskName1);
            this.Controls.Add(this.LED_Cassette);
            this.Controls.Add(this.TTB_DiskName0);
            this.Controls.Add(this.NUD_BinSaveLength);
            this.Controls.Add(this.NUD_BinSaveAddr);
            this.Controls.Add(this.BUT_BinSave);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.SW_A7);
            this.Controls.Add(this.SW_A6);
            this.Controls.Add(this.SW_A5);
            this.Controls.Add(this.SW_A4);
            this.Controls.Add(this.SW_A3);
            this.Controls.Add(this.SW_A2);
            this.Controls.Add(this.SW_A1);
            this.Controls.Add(this.SW_A0);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.LAB_Hint);
            this.Controls.Add(this.NUD_Speed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBOX_Monitor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.COMBO_CaptureDevices);
            this.Controls.Add(this.BUT_Capture);
            this.Controls.Add(this.BUT_Eject3);
            this.Controls.Add(this.BUT_Eject2);
            this.Controls.Add(this.BUT_Eject1);
            this.Controls.Add(this.BUT_Eject0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BUT_Disk3);
            this.Controls.Add(this.BUT_Disk2);
            this.Controls.Add(this.BUT_Disk1);
            this.Controls.Add(this.BUT_Disk0);
            this.Controls.Add(this.COMBO_SendToDevices);
            this.Controls.Add(this.BUT_BinLoad);
            this.Controls.Add(this.NUD_BinLoadAddr);
            this.Controls.Add(this.BUT_Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(2180, 1323);
            this.Name = "UI";
            this.Text = "Altair 8800 - (C) 2022 by nicsure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
            this.Shown += new System.EventHandler(this.UI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinLoadAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PC)).EndInit();
            this.CMS_DiskOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_IV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_HL)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Speed)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDd0)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEDa0)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinSaveAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_BinSaveLength)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LED_IE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_RM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_IN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_OUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_HLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_STK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_WO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_INT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_WAIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_CassetteOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Drive0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_CassetteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED_Cassette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HButton BUT_Load;
        private System.Windows.Forms.OpenFileDialog OFD_Load;
        private System.Windows.Forms.CheckBox CB_Debug;
        private System.Windows.Forms.NumericUpDown NUD_BinLoadAddr;
        private System.Windows.Forms.Button BUT_BinLoad;
        private System.Windows.Forms.NumericUpDown NUD_PC;
        private System.Windows.Forms.ComboBox COMBO_SendToDevices;
        private System.Windows.Forms.Button BUT_LoadHex;
        private HButton BUT_Disk0;
        private HButton BUT_Disk1;
        private HButton BUT_Disk2;
        private HButton BUT_Disk3;
        private SerialConsole Terminal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBOX_Monitor;
        private System.Windows.Forms.Button BUT_Eject0;
        private System.Windows.Forms.Button BUT_Eject1;
        private System.Windows.Forms.Button BUT_Eject2;
        private System.Windows.Forms.Button BUT_Eject3;
        private System.Windows.Forms.ComboBox COMBO_CaptureDevices;
        private HButton BUT_Capture;
        private System.Windows.Forms.NumericUpDown NUD_BC;
        private System.Windows.Forms.NumericUpDown NUD_DE;
        private System.Windows.Forms.NumericUpDown NUD_IV;
        private System.Windows.Forms.NumericUpDown NUD_HL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_SP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CB_EI;
        private System.Windows.Forms.CheckBox CB_PF;
        private System.Windows.Forms.CheckBox CB_CF;
        private System.Windows.Forms.CheckBox CB_HF;
        private System.Windows.Forms.CheckBox CB_ZF;
        private System.Windows.Forms.CheckBox CB_SF;
        private System.Windows.Forms.CheckBox CB_HLT;
        private System.Windows.Forms.CheckBox CB_IRQ;
        private System.Windows.Forms.NumericUpDown NUD_Speed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LAB_Hint;
        private System.Windows.Forms.SaveFileDialog SFD_Save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ContextMenuStrip CMS_DiskOptions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Label1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DiskName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Eject;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MountImage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MountRAM;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ConvertRAM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private VariableLED LEDa15;
        private VariableLED LEDa14;
        private VariableLED LEDa13;
        private VariableLED LEDa12;
        private VariableLED LEDa11;
        private VariableLED LEDa10;
        private VariableLED LEDa9;
        private VariableLED LEDa8;
        private VariableLED LEDa7;
        private VariableLED LEDa6;
        private VariableLED LEDa5;
        private VariableLED LEDa4;
        private VariableLED LEDa3;
        private VariableLED LEDa2;
        private VariableLED LEDa1;
        private VariableLED LEDd7;
        private VariableLED LEDd6;
        private VariableLED LEDd5;
        private VariableLED LEDd4;
        private VariableLED LEDd3;
        private VariableLED LEDd2;
        private VariableLED LEDd1;
        private VariableLED LEDd0;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MountBlank;
        private VariableLED LEDa0;
        private FrontSwitch SW_A0;
        private FrontSwitch SW_A1;
        private FrontSwitch SW_A2;
        private FrontSwitch SW_A3;
        private FrontSwitch SW_A4;
        private FrontSwitch SW_A5;
        private FrontSwitch SW_A6;
        private FrontSwitch SW_A7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private FrontSwitch SW_RunStop;
        private FrontSwitch SW_Reset;
        private FrontSwitch SW_Step;
        private FrontSwitch SW_Examine;
        private FrontSwitch SW_ExamineNext;
        private FrontSwitch SW_Deposit;
        private FrontSwitch SW_DepositNext;
        private System.Windows.Forms.Label label34;
        private NumberBox NB_FPAddress;
        private System.Windows.Forms.CheckBox CB_Octal;
        private NumberBox NB_FPData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label LAB_Irq;
        private System.Windows.Forms.Label LAB_Bel;
        private System.Windows.Forms.Label LAB_Flash;
        private System.Windows.Forms.Label LAB_Telnet;
        private System.Windows.Forms.Label LAB_Cls;
        private System.Windows.Forms.Label LAB_BasicBackspace;
        private System.Windows.Forms.Label LAB_Ref;
        private System.Windows.Forms.Label LAB_Echo;
        private System.Windows.Forms.Label LAB_Clear;
        private System.Windows.Forms.Button BUT_BinSave;
        private System.Windows.Forms.NumericUpDown NUD_BinSaveAddr;
        private System.Windows.Forms.NumericUpDown NUD_BinSaveLength;
        private System.Windows.Forms.Button TTB_DiskName0;
        private System.Windows.Forms.Button TTB_DiskName1;
        private System.Windows.Forms.Button TTB_DiskName2;
        private System.Windows.Forms.Button TTB_DiskName3;
        private System.Windows.Forms.CheckBox CB_SenseSwMomentary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private VariableLED LED_IE;
        private VariableLED LED_RM;
        private VariableLED LED_IN;
        private VariableLED LED_M1;
        private VariableLED LED_OUT;
        private VariableLED LED_HLT;
        private VariableLED LED_STK;
        private VariableLED LED_WO;
        private VariableLED LED_INT;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private VariableLED LED_WAIT;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private HButton BUT_CassAudio;
        private VariableLED LED_Cassette;
        private VariableLED LED_CassetteData;
        private VariableLED LED_Drive0;
        private VariableLED LED_Drive1;
        private VariableLED LED_Drive2;
        private VariableLED LED_Drive3;
        private System.Windows.Forms.Button BUT_Presets;
        private System.Windows.Forms.ContextMenuStrip CMS_CassetteOptions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CassetteAudioOptions;
        private PictureBox pictureBox1;
        private CheckBox CB_DoStatus;
        private CheckBox CBOX_Monitor;
        private Button BUT_Commit;
        private Label label46;
        private LinkLabel LL_Youtube;
    }
}


