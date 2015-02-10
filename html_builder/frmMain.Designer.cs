namespace HTML_Builder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.containers = new System.Windows.Forms.SplitContainer();
            this.splitEditor = new System.Windows.Forms.SplitContainer();
            this.box_props = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.numBorder = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnSetProps = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.codesplitter = new System.Windows.Forms.SplitContainer();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbEncoding = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtTitle = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colors = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbPreview = new System.Windows.Forms.ToolStripComboBox();
            this.lblFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPreview = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.tbButton = new System.Windows.Forms.Button();
            this.tbForm = new System.Windows.Forms.Button();
            this.tbSubmit = new System.Windows.Forms.Button();
            this.tbDiv = new System.Windows.Forms.Button();
            this.tbTextbox = new System.Windows.Forms.Button();
            this.tbTextarea = new System.Windows.Forms.Button();
            this.tbCheckbox = new System.Windows.Forms.Button();
            this.tbRange = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containers)).BeginInit();
            this.containers.Panel1.SuspendLayout();
            this.containers.Panel2.SuspendLayout();
            this.containers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEditor)).BeginInit();
            this.splitEditor.Panel2.SuspendLayout();
            this.splitEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_props)).BeginInit();
            this.box_props.Panel1.SuspendLayout();
            this.box_props.Panel2.SuspendLayout();
            this.box_props.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesplitter)).BeginInit();
            this.codesplitter.SuspendLayout();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightGray;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(916, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFile,
            this.mnuSave,
            this.btnSaveAs,
            this.mnuExport});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Name = "mnuNewFile";
            this.mnuNewFile.Size = new System.Drawing.Size(150, 24);
            this.mnuNewFile.Text = "New";
            this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(150, 24);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(150, 24);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Gainsboro;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFilePath});
            this.status.Location = new System.Drawing.Point(0, 765);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(916, 26);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // containers
            // 
            this.containers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.containers.Location = new System.Drawing.Point(5, 56);
            this.containers.Name = "containers";
            this.containers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containers.Panel1
            // 
            this.containers.Panel1.Controls.Add(this.splitEditor);
            // 
            // containers.Panel2
            // 
            this.containers.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.containers.Panel2.Controls.Add(this.codesplitter);
            this.containers.Size = new System.Drawing.Size(907, 706);
            this.containers.SplitterDistance = 560;
            this.containers.TabIndex = 2;
            // 
            // splitEditor
            // 
            this.splitEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEditor.Location = new System.Drawing.Point(0, 0);
            this.splitEditor.Name = "splitEditor";
            // 
            // splitEditor.Panel1
            // 
            this.splitEditor.Panel1.BackColor = System.Drawing.Color.White;
            // 
            // splitEditor.Panel2
            // 
            this.splitEditor.Panel2.AutoScroll = true;
            this.splitEditor.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitEditor.Panel2.Controls.Add(this.box_props);
            this.splitEditor.Size = new System.Drawing.Size(907, 560);
            this.splitEditor.SplitterDistance = 704;
            this.splitEditor.TabIndex = 0;
            // 
            // box_props
            // 
            this.box_props.BackColor = System.Drawing.Color.LightGray;
            this.box_props.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_props.Location = new System.Drawing.Point(0, 0);
            this.box_props.Name = "box_props";
            this.box_props.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // box_props.Panel1
            // 
            this.box_props.Panel1.AutoScroll = true;
            this.box_props.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box_props.Panel1.Controls.Add(this.label1);
            this.box_props.Panel1.Controls.Add(this.tbButton);
            this.box_props.Panel1.Controls.Add(this.tbForm);
            this.box_props.Panel1.Controls.Add(this.tbSubmit);
            this.box_props.Panel1.Controls.Add(this.tbDiv);
            this.box_props.Panel1.Controls.Add(this.tbTextbox);
            this.box_props.Panel1.Controls.Add(this.label2);
            this.box_props.Panel1.Controls.Add(this.tbTextarea);
            this.box_props.Panel1.Controls.Add(this.tbCheckbox);
            this.box_props.Panel1.Controls.Add(this.tbRange);
            // 
            // box_props.Panel2
            // 
            this.box_props.Panel2.AutoScroll = true;
            this.box_props.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.box_props.Panel2.Controls.Add(this.label11);
            this.box_props.Panel2.Controls.Add(this.numY);
            this.box_props.Panel2.Controls.Add(this.label12);
            this.box_props.Panel2.Controls.Add(this.label13);
            this.box_props.Panel2.Controls.Add(this.numX);
            this.box_props.Panel2.Controls.Add(this.label10);
            this.box_props.Panel2.Controls.Add(this.numRadius);
            this.box_props.Panel2.Controls.Add(this.label9);
            this.box_props.Panel2.Controls.Add(this.label8);
            this.box_props.Panel2.Controls.Add(this.label3);
            this.box_props.Panel2.Controls.Add(this.numWidth);
            this.box_props.Panel2.Controls.Add(this.label6);
            this.box_props.Panel2.Controls.Add(this.label7);
            this.box_props.Panel2.Controls.Add(this.btnFont);
            this.box_props.Panel2.Controls.Add(this.lblName);
            this.box_props.Panel2.Controls.Add(this.numBorder);
            this.box_props.Panel2.Controls.Add(this.label4);
            this.box_props.Panel2.Controls.Add(this.txtValue);
            this.box_props.Panel2.Controls.Add(this.label5);
            this.box_props.Panel2.Controls.Add(this.numHeight);
            this.box_props.Panel2.Controls.Add(this.btnSetProps);
            this.box_props.Panel2.Controls.Add(this.btnColor);
            this.box_props.Size = new System.Drawing.Size(199, 560);
            this.box_props.SplitterDistance = 302;
            this.box_props.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inputs:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Containers:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Y:";
            // 
            // numY
            // 
            this.numY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numY.Location = new System.Drawing.Point(33, 454);
            this.numY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(146, 23);
            this.numY.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Position:";
            // 
            // numX
            // 
            this.numX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numX.Location = new System.Drawing.Point(33, 425);
            this.numX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(146, 23);
            this.numX.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Radius:";
            // 
            // numRadius
            // 
            this.numRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numRadius.Location = new System.Drawing.Point(52, 252);
            this.numRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(127, 23);
            this.numRadius.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Font:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "BackColor:";
            // 
            // numWidth
            // 
            this.numWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numWidth.Location = new System.Drawing.Point(10, 123);
            this.numWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(169, 23);
            this.numWidth.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Border:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value:";
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.BackColor = System.Drawing.Color.White;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(10, 356);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(169, 30);
            this.btnFont.TabIndex = 14;
            this.btnFont.Text = "Pick a font";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click_1);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Undefined";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numBorder
            // 
            this.numBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numBorder.Location = new System.Drawing.Point(52, 223);
            this.numBorder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBorder.Name = "numBorder";
            this.numBorder.Size = new System.Drawing.Size(127, 23);
            this.numBorder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Width:";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(10, 307);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 23);
            this.txtValue.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // numHeight
            // 
            this.numHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numHeight.Location = new System.Drawing.Point(10, 172);
            this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(169, 23);
            this.numHeight.TabIndex = 6;
            // 
            // btnSetProps
            // 
            this.btnSetProps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetProps.BackColor = System.Drawing.Color.White;
            this.btnSetProps.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProps.Location = new System.Drawing.Point(10, 491);
            this.btnSetProps.Name = "btnSetProps";
            this.btnSetProps.Size = new System.Drawing.Size(169, 54);
            this.btnSetProps.TabIndex = 7;
            this.btnSetProps.Text = "Set properties";
            this.btnSetProps.UseVisualStyleBackColor = false;
            this.btnSetProps.Click += new System.EventHandler(this.btnSetProps_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(10, 58);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(169, 33);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Pick a color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // codesplitter
            // 
            this.codesplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codesplitter.Location = new System.Drawing.Point(0, 0);
            this.codesplitter.Name = "codesplitter";
            this.codesplitter.Size = new System.Drawing.Size(907, 142);
            this.codesplitter.SplitterDistance = 441;
            this.codesplitter.TabIndex = 0;
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.Gainsboro;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbEncoding,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.txtTitle,
            this.toolStripSeparator2,
            this.btnPreview,
            this.toolStripSeparator3,
            this.btnStop,
            this.toolStripSeparator4});
            this.tools.Location = new System.Drawing.Point(0, 28);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(916, 25);
            this.tools.TabIndex = 3;
            this.tools.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Encoding: ";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.BackColor = System.Drawing.Color.White;
            this.cmbEncoding.Items.AddRange(new object[] {
            "UTF-8"});
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(121, 25);
            this.cmbEncoding.SelectedIndexChanged += new System.EventHandler(this.cmbEncoding_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Title: ";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 25);
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(150, 24);
            this.mnuExport.Text = "Export CSS";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.cmbPreview});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem1.Text = "Preview";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // cmbPreview
            // 
            this.cmbPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPreview.Items.AddRange(new object[] {
            "Default browser"});
            this.cmbPreview.Name = "cmbPreview";
            this.cmbPreview.Size = new System.Drawing.Size(121, 23);
            this.cmbPreview.Text = "Built in";
            // 
            // lblFilePath
            // 
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(96, 21);
            this.lblFilePath.Text = "Unknown file";
            // 
            // btnPreview
            // 
            this.btnPreview.Image = global::HTML_Builder.Properties.Resources.debug;
            this.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(68, 22);
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::HTML_Builder.Properties.Resources.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbButton
            // 
            this.tbButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbButton.BackgroundImage")));
            this.tbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbButton.Location = new System.Drawing.Point(1, 27);
            this.tbButton.Name = "tbButton";
            this.tbButton.Size = new System.Drawing.Size(220, 30);
            this.tbButton.TabIndex = 0;
            this.tbButton.Text = "Button";
            this.tbButton.UseVisualStyleBackColor = false;
            this.tbButton.Click += new System.EventHandler(this.tbButton_Click);
            // 
            // tbForm
            // 
            this.tbForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbForm.BackgroundImage")));
            this.tbForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForm.Location = new System.Drawing.Point(0, 260);
            this.tbForm.Name = "tbForm";
            this.tbForm.Size = new System.Drawing.Size(223, 30);
            this.tbForm.TabIndex = 8;
            this.tbForm.Text = "Form";
            this.tbForm.UseVisualStyleBackColor = false;
            // 
            // tbSubmit
            // 
            this.tbSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSubmit.BackgroundImage")));
            this.tbSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubmit.Location = new System.Drawing.Point(1, 56);
            this.tbSubmit.Name = "tbSubmit";
            this.tbSubmit.Size = new System.Drawing.Size(220, 30);
            this.tbSubmit.TabIndex = 1;
            this.tbSubmit.Text = "Submit";
            this.tbSubmit.UseVisualStyleBackColor = false;
            this.tbSubmit.Click += new System.EventHandler(this.tbSubmit_Click);
            // 
            // tbDiv
            // 
            this.tbDiv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbDiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDiv.BackgroundImage")));
            this.tbDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiv.Location = new System.Drawing.Point(0, 230);
            this.tbDiv.Name = "tbDiv";
            this.tbDiv.Size = new System.Drawing.Size(223, 30);
            this.tbDiv.TabIndex = 7;
            this.tbDiv.Text = "Div";
            this.tbDiv.UseVisualStyleBackColor = false;
            this.tbDiv.Click += new System.EventHandler(this.tbDiv_Click);
            // 
            // tbTextbox
            // 
            this.tbTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTextbox.BackgroundImage")));
            this.tbTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextbox.Location = new System.Drawing.Point(1, 86);
            this.tbTextbox.Name = "tbTextbox";
            this.tbTextbox.Size = new System.Drawing.Size(220, 30);
            this.tbTextbox.TabIndex = 2;
            this.tbTextbox.Text = "Textbox";
            this.tbTextbox.UseVisualStyleBackColor = false;
            this.tbTextbox.Click += new System.EventHandler(this.tbTextbox_Click);
            // 
            // tbTextarea
            // 
            this.tbTextarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbTextarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTextarea.BackgroundImage")));
            this.tbTextarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTextarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbTextarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextarea.Location = new System.Drawing.Point(1, 116);
            this.tbTextarea.Name = "tbTextarea";
            this.tbTextarea.Size = new System.Drawing.Size(220, 30);
            this.tbTextarea.TabIndex = 3;
            this.tbTextarea.Text = "Textarea";
            this.tbTextarea.UseVisualStyleBackColor = false;
            this.tbTextarea.Click += new System.EventHandler(this.tbTextarea_Click);
            // 
            // tbCheckbox
            // 
            this.tbCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbCheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbCheckbox.BackgroundImage")));
            this.tbCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheckbox.Location = new System.Drawing.Point(1, 176);
            this.tbCheckbox.Name = "tbCheckbox";
            this.tbCheckbox.Size = new System.Drawing.Size(220, 30);
            this.tbCheckbox.TabIndex = 5;
            this.tbCheckbox.Text = "Checkbox";
            this.tbCheckbox.UseVisualStyleBackColor = false;
            this.tbCheckbox.Click += new System.EventHandler(this.tbCheckbox_Click);
            // 
            // tbRange
            // 
            this.tbRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbRange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbRange.BackgroundImage")));
            this.tbRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRange.Location = new System.Drawing.Point(1, 146);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(220, 30);
            this.tbRange.TabIndex = 4;
            this.tbRange.Text = "Range";
            this.tbRange.UseVisualStyleBackColor = false;
            this.tbRange.Click += new System.EventHandler(this.tbRange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(916, 791);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.containers);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.Text = "HTML Builder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown_1);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.containers.Panel1.ResumeLayout(false);
            this.containers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containers)).EndInit();
            this.containers.ResumeLayout(false);
            this.splitEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEditor)).EndInit();
            this.splitEditor.ResumeLayout(false);
            this.box_props.Panel1.ResumeLayout(false);
            this.box_props.Panel1.PerformLayout();
            this.box_props.Panel2.ResumeLayout(false);
            this.box_props.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_props)).EndInit();
            this.box_props.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesplitter)).EndInit();
            this.codesplitter.ResumeLayout(false);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.SplitContainer containers;
        private System.Windows.Forms.SplitContainer splitEditor;
        private System.Windows.Forms.Button tbButton;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbEncoding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPreview;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button tbSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbRange;
        private System.Windows.Forms.Button tbTextarea;
        private System.Windows.Forms.Button tbTextbox;
        private System.Windows.Forms.Button tbCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbForm;
        private System.Windows.Forms.Button tbDiv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.SplitContainer box_props;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetProps;
        private System.Windows.Forms.NumericUpDown numBorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colors;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.SplitContainer codesplitter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox cmbPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel lblFilePath;
    }
}

