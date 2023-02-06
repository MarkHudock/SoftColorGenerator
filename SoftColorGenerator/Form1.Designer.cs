namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.textBoxColorFill = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.labelSoftness = new System.Windows.Forms.Label();
            this.trackBarSoftness = new System.Windows.Forms.TrackBar();
            this.groupBoxSourceColor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSourceColorMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLightDark = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSoftnessMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSoftnessTracker = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.labelSoftnessPercent = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tableLayoutPanelSourceColor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSourceColorTextboxes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSourceColorRGB = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGeneratedColor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelGeneratedColorMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGeneratedFill = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelGeneratedColorTextboxes = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGeneratedHex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelGeneratedColorRGB = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGeneratedBlue = new System.Windows.Forms.TextBox();
            this.textBoxGeneratedRed = new System.Windows.Forms.TextBox();
            this.textBoxGeneratedGreen = new System.Windows.Forms.TextBox();
            this.groupBoxExample = new System.Windows.Forms.GroupBox();
            this.labelExampleText = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoftness)).BeginInit();
            this.groupBoxSourceColor.SuspendLayout();
            this.tableLayoutPanelSourceColorMain.SuspendLayout();
            this.tableLayoutPanelLightDark.SuspendLayout();
            this.tableLayoutPanelSoftnessMain.SuspendLayout();
            this.tableLayoutPanelSoftnessTracker.SuspendLayout();
            this.tableLayoutPanelSourceColor.SuspendLayout();
            this.tableLayoutPanelSourceColorTextboxes.SuspendLayout();
            this.tableLayoutPanelSourceColorRGB.SuspendLayout();
            this.groupBoxGeneratedColor.SuspendLayout();
            this.tableLayoutPanelGeneratedColorMain.SuspendLayout();
            this.tableLayoutPanelGeneratedColorTextboxes.SuspendLayout();
            this.tableLayoutPanelGeneratedColorRGB.SuspendLayout();
            this.groupBoxExample.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxColor.Location = new System.Drawing.Point(18, 19);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxColor.MaxLength = 6;
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 0;
            this.textBoxColor.Text = "000000";
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Checked = true;
            this.radioButtonLight.Location = new System.Drawing.Point(44, 27);
            this.radioButtonLight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLight.TabIndex = 7;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.radioButtonLight_CheckedChanged);
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.Enabled = false;
            this.radioButtonDark.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonDark.Location = new System.Drawing.Point(183, 27);
            this.radioButtonDark.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(49, 17);
            this.radioButtonDark.TabIndex = 6;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.radioButtonDark_CheckedChanged);
            // 
            // textBoxColorFill
            // 
            this.textBoxColorFill.BackColor = System.Drawing.Color.Black;
            this.textBoxColorFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColorFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxColorFill.Enabled = false;
            this.textBoxColorFill.Location = new System.Drawing.Point(142, 4);
            this.textBoxColorFill.MaxLength = 0;
            this.textBoxColorFill.Multiline = true;
            this.textBoxColorFill.Name = "textBoxColorFill";
            this.textBoxColorFill.ReadOnly = true;
            this.textBoxColorFill.Size = new System.Drawing.Size(132, 116);
            this.textBoxColorFill.TabIndex = 0;
            this.textBoxColorFill.TabStop = false;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRed.Location = new System.Drawing.Point(8, 19);
            this.textBoxRed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxRed.MaxLength = 3;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.ReadOnly = true;
            this.textBoxRed.Size = new System.Drawing.Size(28, 22);
            this.textBoxRed.TabIndex = 1;
            this.textBoxRed.Text = "0";
            this.textBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGreen.Location = new System.Drawing.Point(53, 19);
            this.textBoxGreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGreen.MaxLength = 3;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.ReadOnly = true;
            this.textBoxGreen.Size = new System.Drawing.Size(28, 22);
            this.textBoxGreen.TabIndex = 2;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxBlue.Location = new System.Drawing.Point(99, 19);
            this.textBoxBlue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxBlue.MaxLength = 3;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.ReadOnly = true;
            this.textBoxBlue.Size = new System.Drawing.Size(28, 22);
            this.textBoxBlue.TabIndex = 3;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            // 
            // labelSoftness
            // 
            this.labelSoftness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSoftness.AutoSize = true;
            this.labelSoftness.Location = new System.Drawing.Point(3, 11);
            this.labelSoftness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoftness.Name = "labelSoftness";
            this.labelSoftness.Size = new System.Drawing.Size(126, 13);
            this.labelSoftness.TabIndex = 10;
            this.labelSoftness.Text = "Softness (transparency)";
            // 
            // trackBarSoftness
            // 
            this.trackBarSoftness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarSoftness.Location = new System.Drawing.Point(31, 3);
            this.trackBarSoftness.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoftness.Name = "trackBarSoftness";
            this.trackBarSoftness.Size = new System.Drawing.Size(169, 22);
            this.trackBarSoftness.TabIndex = 5;
            this.trackBarSoftness.Value = 2;
            this.trackBarSoftness.Scroll += new System.EventHandler(this.trackBarSoftness_Scroll);
            // 
            // groupBoxSourceColor
            // 
            this.groupBoxSourceColor.BackColor = System.Drawing.Color.White;
            this.groupBoxSourceColor.Controls.Add(this.tableLayoutPanelSourceColorMain);
            this.groupBoxSourceColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSourceColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSourceColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxSourceColor.Location = new System.Drawing.Point(2, 3);
            this.groupBoxSourceColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSourceColor.Name = "groupBoxSourceColor";
            this.groupBoxSourceColor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSourceColor.Size = new System.Drawing.Size(288, 305);
            this.groupBoxSourceColor.TabIndex = 19;
            this.groupBoxSourceColor.TabStop = false;
            this.groupBoxSourceColor.Text = "Source Color";
            // 
            // tableLayoutPanelSourceColorMain
            // 
            this.tableLayoutPanelSourceColorMain.ColumnCount = 1;
            this.tableLayoutPanelSourceColorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSourceColorMain.Controls.Add(this.tableLayoutPanelLightDark, 0, 2);
            this.tableLayoutPanelSourceColorMain.Controls.Add(this.tableLayoutPanelSoftnessMain, 0, 1);
            this.tableLayoutPanelSourceColorMain.Controls.Add(this.tableLayoutPanelSourceColor, 0, 0);
            this.tableLayoutPanelSourceColorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSourceColorMain.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanelSourceColorMain.Name = "tableLayoutPanelSourceColorMain";
            this.tableLayoutPanelSourceColorMain.RowCount = 3;
            this.tableLayoutPanelSourceColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelSourceColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanelSourceColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanelSourceColorMain.Size = new System.Drawing.Size(284, 284);
            this.tableLayoutPanelSourceColorMain.TabIndex = 11;
            // 
            // tableLayoutPanelLightDark
            // 
            this.tableLayoutPanelLightDark.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLightDark.ColumnCount = 2;
            this.tableLayoutPanelLightDark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightDark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightDark.Controls.Add(this.radioButtonLight, 0, 0);
            this.tableLayoutPanelLightDark.Controls.Add(this.radioButtonDark, 1, 0);
            this.tableLayoutPanelLightDark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLightDark.Location = new System.Drawing.Point(3, 209);
            this.tableLayoutPanelLightDark.Name = "tableLayoutPanelLightDark";
            this.tableLayoutPanelLightDark.RowCount = 1;
            this.tableLayoutPanelLightDark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLightDark.Size = new System.Drawing.Size(278, 72);
            this.tableLayoutPanelLightDark.TabIndex = 0;
            // 
            // tableLayoutPanelSoftnessMain
            // 
            this.tableLayoutPanelSoftnessMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSoftnessMain.ColumnCount = 1;
            this.tableLayoutPanelSoftnessMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSoftnessMain.Controls.Add(this.labelSoftness, 0, 0);
            this.tableLayoutPanelSoftnessMain.Controls.Add(this.tableLayoutPanelSoftnessTracker, 0, 1);
            this.tableLayoutPanelSoftnessMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSoftnessMain.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanelSoftnessMain.Name = "tableLayoutPanelSoftnessMain";
            this.tableLayoutPanelSoftnessMain.RowCount = 2;
            this.tableLayoutPanelSoftnessMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSoftnessMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSoftnessMain.Size = new System.Drawing.Size(278, 70);
            this.tableLayoutPanelSoftnessMain.TabIndex = 1;
            // 
            // tableLayoutPanelSoftnessTracker
            // 
            this.tableLayoutPanelSoftnessTracker.ColumnCount = 4;
            this.tableLayoutPanelSoftnessTracker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSoftnessTracker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSoftnessTracker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSoftnessTracker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSoftnessTracker.Controls.Add(this.buttonMinus, 0, 0);
            this.tableLayoutPanelSoftnessTracker.Controls.Add(this.labelSoftnessPercent, 3, 0);
            this.tableLayoutPanelSoftnessTracker.Controls.Add(this.buttonPlus, 2, 0);
            this.tableLayoutPanelSoftnessTracker.Controls.Add(this.trackBarSoftness, 1, 0);
            this.tableLayoutPanelSoftnessTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSoftnessTracker.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanelSoftnessTracker.Name = "tableLayoutPanelSoftnessTracker";
            this.tableLayoutPanelSoftnessTracker.RowCount = 1;
            this.tableLayoutPanelSoftnessTracker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSoftnessTracker.Size = new System.Drawing.Size(270, 28);
            this.tableLayoutPanelSoftnessTracker.TabIndex = 11;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMinus.Location = new System.Drawing.Point(2, 3);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(25, 22);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // labelSoftnessPercent
            // 
            this.labelSoftnessPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSoftnessPercent.AutoSize = true;
            this.labelSoftnessPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoftnessPercent.ForeColor = System.Drawing.Color.DimGray;
            this.labelSoftnessPercent.Location = new System.Drawing.Point(233, 6);
            this.labelSoftnessPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoftnessPercent.Name = "labelSoftnessPercent";
            this.labelSoftnessPercent.Size = new System.Drawing.Size(35, 15);
            this.labelSoftnessPercent.TabIndex = 0;
            this.labelSoftnessPercent.Text = "20%";
            this.labelSoftnessPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPlus.Location = new System.Drawing.Point(204, 3);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(25, 22);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // tableLayoutPanelSourceColor
            // 
            this.tableLayoutPanelSourceColor.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSourceColor.ColumnCount = 2;
            this.tableLayoutPanelSourceColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColor.Controls.Add(this.textBoxColorFill, 1, 0);
            this.tableLayoutPanelSourceColor.Controls.Add(this.tableLayoutPanelSourceColorTextboxes, 0, 0);
            this.tableLayoutPanelSourceColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSourceColor.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSourceColor.Name = "tableLayoutPanelSourceColor";
            this.tableLayoutPanelSourceColor.RowCount = 1;
            this.tableLayoutPanelSourceColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColor.Size = new System.Drawing.Size(278, 124);
            this.tableLayoutPanelSourceColor.TabIndex = 2;
            // 
            // tableLayoutPanelSourceColorTextboxes
            // 
            this.tableLayoutPanelSourceColorTextboxes.ColumnCount = 1;
            this.tableLayoutPanelSourceColorTextboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColorTextboxes.Controls.Add(this.textBoxColor, 0, 0);
            this.tableLayoutPanelSourceColorTextboxes.Controls.Add(this.tableLayoutPanelSourceColorRGB, 0, 1);
            this.tableLayoutPanelSourceColorTextboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSourceColorTextboxes.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanelSourceColorTextboxes.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSourceColorTextboxes.Name = "tableLayoutPanelSourceColorTextboxes";
            this.tableLayoutPanelSourceColorTextboxes.RowCount = 2;
            this.tableLayoutPanelSourceColorTextboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColorTextboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceColorTextboxes.Size = new System.Drawing.Size(137, 122);
            this.tableLayoutPanelSourceColorTextboxes.TabIndex = 1;
            // 
            // tableLayoutPanelSourceColorRGB
            // 
            this.tableLayoutPanelSourceColorRGB.ColumnCount = 3;
            this.tableLayoutPanelSourceColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSourceColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSourceColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSourceColorRGB.Controls.Add(this.textBoxRed, 0, 0);
            this.tableLayoutPanelSourceColorRGB.Controls.Add(this.textBoxBlue, 2, 0);
            this.tableLayoutPanelSourceColorRGB.Controls.Add(this.textBoxGreen, 1, 0);
            this.tableLayoutPanelSourceColorRGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSourceColorRGB.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanelSourceColorRGB.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSourceColorRGB.Name = "tableLayoutPanelSourceColorRGB";
            this.tableLayoutPanelSourceColorRGB.RowCount = 1;
            this.tableLayoutPanelSourceColorRGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSourceColorRGB.Size = new System.Drawing.Size(137, 61);
            this.tableLayoutPanelSourceColorRGB.TabIndex = 1;
            // 
            // groupBoxGeneratedColor
            // 
            this.groupBoxGeneratedColor.BackColor = System.Drawing.Color.White;
            this.groupBoxGeneratedColor.Controls.Add(this.tableLayoutPanelGeneratedColorMain);
            this.groupBoxGeneratedColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGeneratedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGeneratedColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxGeneratedColor.Location = new System.Drawing.Point(2, 3);
            this.groupBoxGeneratedColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxGeneratedColor.Name = "groupBoxGeneratedColor";
            this.groupBoxGeneratedColor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxGeneratedColor.Size = new System.Drawing.Size(288, 149);
            this.groupBoxGeneratedColor.TabIndex = 20;
            this.groupBoxGeneratedColor.TabStop = false;
            this.groupBoxGeneratedColor.Text = "Generated Color";
            // 
            // tableLayoutPanelGeneratedColorMain
            // 
            this.tableLayoutPanelGeneratedColorMain.ColumnCount = 2;
            this.tableLayoutPanelGeneratedColorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorMain.Controls.Add(this.textBoxGeneratedFill, 1, 0);
            this.tableLayoutPanelGeneratedColorMain.Controls.Add(this.tableLayoutPanelGeneratedColorTextboxes, 0, 0);
            this.tableLayoutPanelGeneratedColorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneratedColorMain.Location = new System.Drawing.Point(2, 18);
            this.tableLayoutPanelGeneratedColorMain.Name = "tableLayoutPanelGeneratedColorMain";
            this.tableLayoutPanelGeneratedColorMain.RowCount = 1;
            this.tableLayoutPanelGeneratedColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanelGeneratedColorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanelGeneratedColorMain.Size = new System.Drawing.Size(284, 128);
            this.tableLayoutPanelGeneratedColorMain.TabIndex = 0;
            // 
            // textBoxGeneratedFill
            // 
            this.textBoxGeneratedFill.BackColor = System.Drawing.Color.White;
            this.textBoxGeneratedFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGeneratedFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGeneratedFill.Enabled = false;
            this.textBoxGeneratedFill.Location = new System.Drawing.Point(145, 3);
            this.textBoxGeneratedFill.MaxLength = 0;
            this.textBoxGeneratedFill.Multiline = true;
            this.textBoxGeneratedFill.Name = "textBoxGeneratedFill";
            this.textBoxGeneratedFill.ReadOnly = true;
            this.textBoxGeneratedFill.Size = new System.Drawing.Size(136, 122);
            this.textBoxGeneratedFill.TabIndex = 11;
            this.textBoxGeneratedFill.TabStop = false;
            // 
            // tableLayoutPanelGeneratedColorTextboxes
            // 
            this.tableLayoutPanelGeneratedColorTextboxes.ColumnCount = 1;
            this.tableLayoutPanelGeneratedColorTextboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorTextboxes.Controls.Add(this.textBoxGeneratedHex, 0, 0);
            this.tableLayoutPanelGeneratedColorTextboxes.Controls.Add(this.tableLayoutPanelGeneratedColorRGB, 0, 1);
            this.tableLayoutPanelGeneratedColorTextboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneratedColorTextboxes.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelGeneratedColorTextboxes.Name = "tableLayoutPanelGeneratedColorTextboxes";
            this.tableLayoutPanelGeneratedColorTextboxes.RowCount = 2;
            this.tableLayoutPanelGeneratedColorTextboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorTextboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGeneratedColorTextboxes.Size = new System.Drawing.Size(136, 122);
            this.tableLayoutPanelGeneratedColorTextboxes.TabIndex = 12;
            // 
            // textBoxGeneratedHex
            // 
            this.textBoxGeneratedHex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGeneratedHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGeneratedHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxGeneratedHex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxGeneratedHex.Location = new System.Drawing.Point(18, 19);
            this.textBoxGeneratedHex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGeneratedHex.MaxLength = 6;
            this.textBoxGeneratedHex.Name = "textBoxGeneratedHex";
            this.textBoxGeneratedHex.ReadOnly = true;
            this.textBoxGeneratedHex.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeneratedHex.TabIndex = 12;
            // 
            // tableLayoutPanelGeneratedColorRGB
            // 
            this.tableLayoutPanelGeneratedColorRGB.ColumnCount = 3;
            this.tableLayoutPanelGeneratedColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGeneratedColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGeneratedColorRGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGeneratedColorRGB.Controls.Add(this.textBoxGeneratedBlue, 2, 0);
            this.tableLayoutPanelGeneratedColorRGB.Controls.Add(this.textBoxGeneratedRed, 0, 0);
            this.tableLayoutPanelGeneratedColorRGB.Controls.Add(this.textBoxGeneratedGreen, 1, 0);
            this.tableLayoutPanelGeneratedColorRGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneratedColorRGB.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanelGeneratedColorRGB.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelGeneratedColorRGB.Name = "tableLayoutPanelGeneratedColorRGB";
            this.tableLayoutPanelGeneratedColorRGB.RowCount = 1;
            this.tableLayoutPanelGeneratedColorRGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneratedColorRGB.Size = new System.Drawing.Size(136, 61);
            this.tableLayoutPanelGeneratedColorRGB.TabIndex = 13;
            // 
            // textBoxGeneratedBlue
            // 
            this.textBoxGeneratedBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGeneratedBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGeneratedBlue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxGeneratedBlue.Location = new System.Drawing.Point(99, 19);
            this.textBoxGeneratedBlue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGeneratedBlue.Name = "textBoxGeneratedBlue";
            this.textBoxGeneratedBlue.ReadOnly = true;
            this.textBoxGeneratedBlue.Size = new System.Drawing.Size(28, 22);
            this.textBoxGeneratedBlue.TabIndex = 15;
            this.textBoxGeneratedBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGeneratedRed
            // 
            this.textBoxGeneratedRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGeneratedRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGeneratedRed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxGeneratedRed.Location = new System.Drawing.Point(8, 19);
            this.textBoxGeneratedRed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGeneratedRed.Name = "textBoxGeneratedRed";
            this.textBoxGeneratedRed.ReadOnly = true;
            this.textBoxGeneratedRed.Size = new System.Drawing.Size(28, 22);
            this.textBoxGeneratedRed.TabIndex = 13;
            this.textBoxGeneratedRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGeneratedGreen
            // 
            this.textBoxGeneratedGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGeneratedGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGeneratedGreen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxGeneratedGreen.Location = new System.Drawing.Point(53, 19);
            this.textBoxGeneratedGreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxGeneratedGreen.Name = "textBoxGeneratedGreen";
            this.textBoxGeneratedGreen.ReadOnly = true;
            this.textBoxGeneratedGreen.Size = new System.Drawing.Size(28, 22);
            this.textBoxGeneratedGreen.TabIndex = 14;
            this.textBoxGeneratedGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxExample
            // 
            this.groupBoxExample.Controls.Add(this.labelExampleText);
            this.groupBoxExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExample.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxExample.Location = new System.Drawing.Point(2, 158);
            this.groupBoxExample.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxExample.Name = "groupBoxExample";
            this.groupBoxExample.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxExample.Size = new System.Drawing.Size(288, 150);
            this.groupBoxExample.TabIndex = 0;
            this.groupBoxExample.TabStop = false;
            this.groupBoxExample.Text = "Example";
            // 
            // labelExampleText
            // 
            this.labelExampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelExampleText.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleText.ForeColor = System.Drawing.Color.LightGray;
            this.labelExampleText.Location = new System.Drawing.Point(38, 17);
            this.labelExampleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExampleText.Name = "labelExampleText";
            this.labelExampleText.Size = new System.Drawing.Size(212, 129);
            this.labelExampleText.TabIndex = 0;
            this.labelExampleText.Text = "Example Text";
            this.labelExampleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSourceColor, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelRight, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(584, 311);
            this.tableLayoutPanelMain.TabIndex = 21;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxGeneratedColor, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxExample, 0, 1);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(292, 0);
            this.tableLayoutPanelRight.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 2;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(292, 311);
            this.tableLayoutPanelRight.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Form1";
            this.Text = "SoftColorGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoftness)).EndInit();
            this.groupBoxSourceColor.ResumeLayout(false);
            this.tableLayoutPanelSourceColorMain.ResumeLayout(false);
            this.tableLayoutPanelLightDark.ResumeLayout(false);
            this.tableLayoutPanelLightDark.PerformLayout();
            this.tableLayoutPanelSoftnessMain.ResumeLayout(false);
            this.tableLayoutPanelSoftnessMain.PerformLayout();
            this.tableLayoutPanelSoftnessTracker.ResumeLayout(false);
            this.tableLayoutPanelSoftnessTracker.PerformLayout();
            this.tableLayoutPanelSourceColor.ResumeLayout(false);
            this.tableLayoutPanelSourceColor.PerformLayout();
            this.tableLayoutPanelSourceColorTextboxes.ResumeLayout(false);
            this.tableLayoutPanelSourceColorTextboxes.PerformLayout();
            this.tableLayoutPanelSourceColorRGB.ResumeLayout(false);
            this.tableLayoutPanelSourceColorRGB.PerformLayout();
            this.groupBoxGeneratedColor.ResumeLayout(false);
            this.tableLayoutPanelGeneratedColorMain.ResumeLayout(false);
            this.tableLayoutPanelGeneratedColorMain.PerformLayout();
            this.tableLayoutPanelGeneratedColorTextboxes.ResumeLayout(false);
            this.tableLayoutPanelGeneratedColorTextboxes.PerformLayout();
            this.tableLayoutPanelGeneratedColorRGB.ResumeLayout(false);
            this.tableLayoutPanelGeneratedColorRGB.PerformLayout();
            this.groupBoxExample.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.RadioButton radioButtonLight;
        private System.Windows.Forms.RadioButton radioButtonDark;
        private System.Windows.Forms.TextBox textBoxColorFill;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label labelSoftness;
        private System.Windows.Forms.TrackBar trackBarSoftness;
        private System.Windows.Forms.GroupBox groupBoxSourceColor;
        private System.Windows.Forms.GroupBox groupBoxGeneratedColor;
        private System.Windows.Forms.GroupBox groupBoxExample;
        private System.Windows.Forms.Label labelExampleText;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label labelSoftnessPercent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneratedColorMain;
        private System.Windows.Forms.TextBox textBoxGeneratedFill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneratedColorTextboxes;
        private System.Windows.Forms.TextBox textBoxGeneratedHex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneratedColorRGB;
        private System.Windows.Forms.TextBox textBoxGeneratedBlue;
        private System.Windows.Forms.TextBox textBoxGeneratedRed;
        private System.Windows.Forms.TextBox textBoxGeneratedGreen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSourceColorMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLightDark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSoftnessMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSoftnessTracker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSourceColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSourceColorTextboxes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSourceColorRGB;
    }
}

