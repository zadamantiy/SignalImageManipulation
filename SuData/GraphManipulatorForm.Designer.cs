namespace SuData
{
    partial class GraphManipulatorForm
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
            this.graphListBox = new System.Windows.Forms.CheckedListBox();
            this.shiftGroupBox = new System.Windows.Forms.GroupBox();
            this.shiftButton = new System.Windows.Forms.Button();
            this.shiftParTextbox = new System.Windows.Forms.TextBox();
            this.AntishiftGroupBox = new System.Windows.Forms.GroupBox();
            this.antishiftButton = new System.Windows.Forms.Button();
            this.spikeGroupBox = new System.Windows.Forms.GroupBox();
            this.spikeCountTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.spikeMinLabel = new System.Windows.Forms.Label();
            this.spikeMaxValueTextbox = new System.Windows.Forms.TextBox();
            this.spikeMinValueTextbox = new System.Windows.Forms.TextBox();
            this.addSpikesButton = new System.Windows.Forms.Button();
            this.antiSpikeGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sTextBox = new System.Windows.Forms.TextBox();
            this.proceedAntiSpikeButton = new System.Windows.Forms.Button();
            this.antiTrendGroupBox = new System.Windows.Forms.GroupBox();
            this.antinoiseButton = new System.Windows.Forms.Button();
            this.WindowSizeLabel = new System.Windows.Forms.Label();
            this.antiTrendButton = new System.Windows.Forms.Button();
            this.winSizeTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manipulationsTab = new System.Windows.Forms.TabPage();
            this.cutGroupBox = new System.Windows.Forms.GroupBox();
            this.cutToTextBox = new System.Windows.Forms.TextBox();
            this.cutToLabel = new System.Windows.Forms.Label();
            this.cutFromTextBox = new System.Windows.Forms.TextBox();
            this.cutFromLabel = new System.Windows.Forms.Label();
            this.cutProceedButton = new System.Windows.Forms.Button();
            this.experimentsTab = new System.Windows.Forms.TabPage();
            this.buttonGetDerivative = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repairGraphButton = new System.Windows.Forms.Button();
            this.potterGroupBox = new System.Windows.Forms.GroupBox();
            this.autoDtCheckBox = new System.Windows.Forms.CheckBox();
            this.potterType = new System.Windows.Forms.Label();
            this.filterNameComboBox = new System.Windows.Forms.ComboBox();
            this.fc2TextBox = new System.Windows.Forms.TextBox();
            this.fc2Label = new System.Windows.Forms.Label();
            this.applyPotterButton = new System.Windows.Forms.Button();
            this.dtPotterTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.fcTextBox = new System.Windows.Forms.TextBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.dTPotterLabel = new System.Windows.Forms.Label();
            this.fcLabel = new System.Windows.Forms.Label();
            this.plotPotterButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeHeartButton = new System.Windows.Forms.Button();
            this.spikeHeartCheckbox = new System.Windows.Forms.CheckBox();
            this.addHeartButton = new System.Windows.Forms.Button();
            this.graphNumberLabel = new System.Windows.Forms.Label();
            this.graphNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomExpGroupBox = new System.Windows.Forms.GroupBox();
            this.plotSigmasButton = new System.Windows.Forms.Button();
            this.useGraphCheckBox = new System.Windows.Forms.CheckBox();
            this.timesTextBox = new System.Windows.Forms.TextBox();
            this.timesLabel = new System.Windows.Forms.Label();
            this.maxYTextBox = new System.Windows.Forms.TextBox();
            this.minYTextBox = new System.Windows.Forms.TextBox();
            this.maxY = new System.Windows.Forms.Label();
            this.minY = new System.Windows.Forms.Label();
            this.addAntiRandom = new System.Windows.Forms.Button();
            this.dtmfTab = new System.Windows.Forms.TabPage();
            this.getDtmf = new System.Windows.Forms.Button();
            this.dtmfResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textBoxAlphaNoiseDeconvolution = new System.Windows.Forms.TextBox();
            this.shiftGroupBox.SuspendLayout();
            this.AntishiftGroupBox.SuspendLayout();
            this.spikeGroupBox.SuspendLayout();
            this.antiSpikeGroupBox.SuspendLayout();
            this.antiTrendGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.manipulationsTab.SuspendLayout();
            this.cutGroupBox.SuspendLayout();
            this.experimentsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.potterGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphNumericUpDown)).BeginInit();
            this.randomExpGroupBox.SuspendLayout();
            this.dtmfTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphListBox
            // 
            this.graphListBox.FormattingEnabled = true;
            this.graphListBox.Location = new System.Drawing.Point(12, 12);
            this.graphListBox.Name = "graphListBox";
            this.graphListBox.Size = new System.Drawing.Size(209, 409);
            this.graphListBox.TabIndex = 0;
            // 
            // shiftGroupBox
            // 
            this.shiftGroupBox.Controls.Add(this.shiftButton);
            this.shiftGroupBox.Controls.Add(this.shiftParTextbox);
            this.shiftGroupBox.Location = new System.Drawing.Point(6, 6);
            this.shiftGroupBox.Name = "shiftGroupBox";
            this.shiftGroupBox.Size = new System.Drawing.Size(192, 55);
            this.shiftGroupBox.TabIndex = 1;
            this.shiftGroupBox.TabStop = false;
            this.shiftGroupBox.Text = "Shift";
            // 
            // shiftButton
            // 
            this.shiftButton.Location = new System.Drawing.Point(111, 19);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(75, 23);
            this.shiftButton.TabIndex = 1;
            this.shiftButton.Text = "Shift";
            this.shiftButton.UseVisualStyleBackColor = true;
            this.shiftButton.Click += new System.EventHandler(this.shiftButton_Click);
            // 
            // shiftParTextbox
            // 
            this.shiftParTextbox.Location = new System.Drawing.Point(6, 21);
            this.shiftParTextbox.Name = "shiftParTextbox";
            this.shiftParTextbox.Size = new System.Drawing.Size(100, 20);
            this.shiftParTextbox.TabIndex = 0;
            this.shiftParTextbox.Text = "0";
            // 
            // AntishiftGroupBox
            // 
            this.AntishiftGroupBox.Controls.Add(this.antishiftButton);
            this.AntishiftGroupBox.Location = new System.Drawing.Point(204, 6);
            this.AntishiftGroupBox.Name = "AntishiftGroupBox";
            this.AntishiftGroupBox.Size = new System.Drawing.Size(88, 55);
            this.AntishiftGroupBox.TabIndex = 2;
            this.AntishiftGroupBox.TabStop = false;
            this.AntishiftGroupBox.Text = "Anti Shift";
            // 
            // antishiftButton
            // 
            this.antishiftButton.Location = new System.Drawing.Point(6, 19);
            this.antishiftButton.Name = "antishiftButton";
            this.antishiftButton.Size = new System.Drawing.Size(75, 23);
            this.antishiftButton.TabIndex = 0;
            this.antishiftButton.Text = "Proceed";
            this.antishiftButton.UseVisualStyleBackColor = true;
            this.antishiftButton.Click += new System.EventHandler(this.antishiftButton_Click);
            // 
            // spikeGroupBox
            // 
            this.spikeGroupBox.Controls.Add(this.spikeCountTextbox);
            this.spikeGroupBox.Controls.Add(this.label1);
            this.spikeGroupBox.Controls.Add(this.maxLabel);
            this.spikeGroupBox.Controls.Add(this.spikeMinLabel);
            this.spikeGroupBox.Controls.Add(this.spikeMaxValueTextbox);
            this.spikeGroupBox.Controls.Add(this.spikeMinValueTextbox);
            this.spikeGroupBox.Controls.Add(this.addSpikesButton);
            this.spikeGroupBox.Location = new System.Drawing.Point(6, 67);
            this.spikeGroupBox.Name = "spikeGroupBox";
            this.spikeGroupBox.Size = new System.Drawing.Size(515, 47);
            this.spikeGroupBox.TabIndex = 3;
            this.spikeGroupBox.TabStop = false;
            this.spikeGroupBox.Text = "Spike";
            // 
            // spikeCountTextbox
            // 
            this.spikeCountTextbox.Location = new System.Drawing.Point(326, 16);
            this.spikeCountTextbox.Name = "spikeCountTextbox";
            this.spikeCountTextbox.Size = new System.Drawing.Size(100, 20);
            this.spikeCountTextbox.TabIndex = 6;
            this.spikeCountTextbox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(146, 19);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 4;
            this.maxLabel.Text = "Max";
            // 
            // spikeMinLabel
            // 
            this.spikeMinLabel.AutoSize = true;
            this.spikeMinLabel.Location = new System.Drawing.Point(6, 19);
            this.spikeMinLabel.Name = "spikeMinLabel";
            this.spikeMinLabel.Size = new System.Drawing.Size(24, 13);
            this.spikeMinLabel.TabIndex = 3;
            this.spikeMinLabel.Text = "Min";
            // 
            // spikeMaxValueTextbox
            // 
            this.spikeMaxValueTextbox.Location = new System.Drawing.Point(179, 16);
            this.spikeMaxValueTextbox.Name = "spikeMaxValueTextbox";
            this.spikeMaxValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.spikeMaxValueTextbox.TabIndex = 2;
            this.spikeMaxValueTextbox.Text = "1000";
            // 
            // spikeMinValueTextbox
            // 
            this.spikeMinValueTextbox.Location = new System.Drawing.Point(42, 16);
            this.spikeMinValueTextbox.Name = "spikeMinValueTextbox";
            this.spikeMinValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.spikeMinValueTextbox.TabIndex = 1;
            this.spikeMinValueTextbox.Text = "1000";
            // 
            // addSpikesButton
            // 
            this.addSpikesButton.Location = new System.Drawing.Point(432, 13);
            this.addSpikesButton.Name = "addSpikesButton";
            this.addSpikesButton.Size = new System.Drawing.Size(75, 23);
            this.addSpikesButton.TabIndex = 0;
            this.addSpikesButton.Text = "Add";
            this.addSpikesButton.UseVisualStyleBackColor = true;
            this.addSpikesButton.Click += new System.EventHandler(this.addSpikesButton_Click);
            // 
            // antiSpikeGroupBox
            // 
            this.antiSpikeGroupBox.Controls.Add(this.label2);
            this.antiSpikeGroupBox.Controls.Add(this.sTextBox);
            this.antiSpikeGroupBox.Controls.Add(this.proceedAntiSpikeButton);
            this.antiSpikeGroupBox.Location = new System.Drawing.Point(6, 177);
            this.antiSpikeGroupBox.Name = "antiSpikeGroupBox";
            this.antiSpikeGroupBox.Size = new System.Drawing.Size(216, 47);
            this.antiSpikeGroupBox.TabIndex = 4;
            this.antiSpikeGroupBox.TabStop = false;
            this.antiSpikeGroupBox.Text = "AntiSpike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "S";
            // 
            // sTextBox
            // 
            this.sTextBox.Location = new System.Drawing.Point(26, 20);
            this.sTextBox.Name = "sTextBox";
            this.sTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTextBox.TabIndex = 7;
            this.sTextBox.Text = "1";
            // 
            // proceedAntiSpikeButton
            // 
            this.proceedAntiSpikeButton.Location = new System.Drawing.Point(132, 18);
            this.proceedAntiSpikeButton.Name = "proceedAntiSpikeButton";
            this.proceedAntiSpikeButton.Size = new System.Drawing.Size(75, 23);
            this.proceedAntiSpikeButton.TabIndex = 0;
            this.proceedAntiSpikeButton.Text = "Proceed";
            this.proceedAntiSpikeButton.UseVisualStyleBackColor = true;
            this.proceedAntiSpikeButton.Click += new System.EventHandler(this.proceedAntiSpikeButton_Click);
            // 
            // antiTrendGroupBox
            // 
            this.antiTrendGroupBox.Controls.Add(this.antinoiseButton);
            this.antiTrendGroupBox.Controls.Add(this.WindowSizeLabel);
            this.antiTrendGroupBox.Controls.Add(this.antiTrendButton);
            this.antiTrendGroupBox.Controls.Add(this.winSizeTextBox);
            this.antiTrendGroupBox.Location = new System.Drawing.Point(6, 120);
            this.antiTrendGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.antiTrendGroupBox.Name = "antiTrendGroupBox";
            this.antiTrendGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.antiTrendGroupBox.Size = new System.Drawing.Size(352, 52);
            this.antiTrendGroupBox.TabIndex = 5;
            this.antiTrendGroupBox.TabStop = false;
            this.antiTrendGroupBox.Text = "AntiTrend";
            // 
            // antinoiseButton
            // 
            this.antinoiseButton.Location = new System.Drawing.Point(268, 20);
            this.antinoiseButton.Name = "antinoiseButton";
            this.antinoiseButton.Size = new System.Drawing.Size(75, 23);
            this.antinoiseButton.TabIndex = 9;
            this.antinoiseButton.Text = "Antinoise";
            this.antinoiseButton.UseVisualStyleBackColor = true;
            this.antinoiseButton.Click += new System.EventHandler(this.antiNoiseButton_Click);
            // 
            // WindowSizeLabel
            // 
            this.WindowSizeLabel.AutoSize = true;
            this.WindowSizeLabel.Location = new System.Drawing.Point(6, 25);
            this.WindowSizeLabel.Name = "WindowSizeLabel";
            this.WindowSizeLabel.Size = new System.Drawing.Size(69, 13);
            this.WindowSizeLabel.TabIndex = 8;
            this.WindowSizeLabel.Text = "Window Size";
            // 
            // antiTrendButton
            // 
            this.antiTrendButton.Location = new System.Drawing.Point(187, 20);
            this.antiTrendButton.Name = "antiTrendButton";
            this.antiTrendButton.Size = new System.Drawing.Size(75, 23);
            this.antiTrendButton.TabIndex = 0;
            this.antiTrendButton.Text = "Antitrend";
            this.antiTrendButton.UseVisualStyleBackColor = true;
            this.antiTrendButton.Click += new System.EventHandler(this.antiTrendButton_Click);
            // 
            // winSizeTextBox
            // 
            this.winSizeTextBox.Location = new System.Drawing.Point(81, 21);
            this.winSizeTextBox.Name = "winSizeTextBox";
            this.winSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.winSizeTextBox.TabIndex = 7;
            this.winSizeTextBox.Text = "100";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manipulationsTab);
            this.tabControl1.Controls.Add(this.experimentsTab);
            this.tabControl1.Controls.Add(this.dtmfTab);
            this.tabControl1.Location = new System.Drawing.Point(227, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 409);
            this.tabControl1.TabIndex = 6;
            // 
            // manipulationsTab
            // 
            this.manipulationsTab.Controls.Add(this.cutGroupBox);
            this.manipulationsTab.Controls.Add(this.shiftGroupBox);
            this.manipulationsTab.Controls.Add(this.antiTrendGroupBox);
            this.manipulationsTab.Controls.Add(this.AntishiftGroupBox);
            this.manipulationsTab.Controls.Add(this.antiSpikeGroupBox);
            this.manipulationsTab.Controls.Add(this.spikeGroupBox);
            this.manipulationsTab.Location = new System.Drawing.Point(4, 22);
            this.manipulationsTab.Name = "manipulationsTab";
            this.manipulationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.manipulationsTab.Size = new System.Drawing.Size(545, 383);
            this.manipulationsTab.TabIndex = 0;
            this.manipulationsTab.Text = "Manipulations";
            this.manipulationsTab.UseVisualStyleBackColor = true;
            // 
            // cutGroupBox
            // 
            this.cutGroupBox.Controls.Add(this.cutToTextBox);
            this.cutGroupBox.Controls.Add(this.cutToLabel);
            this.cutGroupBox.Controls.Add(this.cutFromTextBox);
            this.cutGroupBox.Controls.Add(this.cutFromLabel);
            this.cutGroupBox.Controls.Add(this.cutProceedButton);
            this.cutGroupBox.Location = new System.Drawing.Point(6, 230);
            this.cutGroupBox.Name = "cutGroupBox";
            this.cutGroupBox.Size = new System.Drawing.Size(361, 47);
            this.cutGroupBox.TabIndex = 9;
            this.cutGroupBox.TabStop = false;
            this.cutGroupBox.Text = "Cut";
            // 
            // cutToTextBox
            // 
            this.cutToTextBox.Location = new System.Drawing.Point(172, 19);
            this.cutToTextBox.Name = "cutToTextBox";
            this.cutToTextBox.Size = new System.Drawing.Size(100, 20);
            this.cutToTextBox.TabIndex = 4;
            this.cutToTextBox.Text = "1000";
            // 
            // cutToLabel
            // 
            this.cutToLabel.AutoSize = true;
            this.cutToLabel.Location = new System.Drawing.Point(146, 22);
            this.cutToLabel.Name = "cutToLabel";
            this.cutToLabel.Size = new System.Drawing.Size(20, 13);
            this.cutToLabel.TabIndex = 3;
            this.cutToLabel.Text = "To";
            // 
            // cutFromTextBox
            // 
            this.cutFromTextBox.Location = new System.Drawing.Point(39, 19);
            this.cutFromTextBox.Name = "cutFromTextBox";
            this.cutFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.cutFromTextBox.TabIndex = 2;
            this.cutFromTextBox.Text = "0";
            // 
            // cutFromLabel
            // 
            this.cutFromLabel.AutoSize = true;
            this.cutFromLabel.Location = new System.Drawing.Point(6, 22);
            this.cutFromLabel.Name = "cutFromLabel";
            this.cutFromLabel.Size = new System.Drawing.Size(27, 13);
            this.cutFromLabel.TabIndex = 1;
            this.cutFromLabel.Text = "from";
            // 
            // cutProceedButton
            // 
            this.cutProceedButton.Location = new System.Drawing.Point(278, 17);
            this.cutProceedButton.Name = "cutProceedButton";
            this.cutProceedButton.Size = new System.Drawing.Size(75, 23);
            this.cutProceedButton.TabIndex = 0;
            this.cutProceedButton.Text = "Proceed";
            this.cutProceedButton.UseVisualStyleBackColor = true;
            this.cutProceedButton.Click += new System.EventHandler(this.cutProceedButton_Click);
            // 
            // experimentsTab
            // 
            this.experimentsTab.Controls.Add(this.buttonGetDerivative);
            this.experimentsTab.Controls.Add(this.groupBox2);
            this.experimentsTab.Controls.Add(this.potterGroupBox);
            this.experimentsTab.Controls.Add(this.groupBox1);
            this.experimentsTab.Controls.Add(this.graphNumberLabel);
            this.experimentsTab.Controls.Add(this.graphNumericUpDown);
            this.experimentsTab.Controls.Add(this.randomExpGroupBox);
            this.experimentsTab.Location = new System.Drawing.Point(4, 22);
            this.experimentsTab.Name = "experimentsTab";
            this.experimentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.experimentsTab.Size = new System.Drawing.Size(545, 383);
            this.experimentsTab.TabIndex = 1;
            this.experimentsTab.Text = "Experiments";
            this.experimentsTab.UseVisualStyleBackColor = true;
            // 
            // buttonGetDerivative
            // 
            this.buttonGetDerivative.Location = new System.Drawing.Point(276, 344);
            this.buttonGetDerivative.Name = "buttonGetDerivative";
            this.buttonGetDerivative.Size = new System.Drawing.Size(95, 23);
            this.buttonGetDerivative.TabIndex = 10;
            this.buttonGetDerivative.Text = "Get Derivative";
            this.buttonGetDerivative.UseVisualStyleBackColor = true;
            this.buttonGetDerivative.Click += new System.EventHandler(this.buttonGetDerivative_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.repairGraphButton);
            this.groupBox2.Location = new System.Drawing.Point(377, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph from spec";
            // 
            // repairGraphButton
            // 
            this.repairGraphButton.Location = new System.Drawing.Point(6, 20);
            this.repairGraphButton.Name = "repairGraphButton";
            this.repairGraphButton.Size = new System.Drawing.Size(143, 23);
            this.repairGraphButton.TabIndex = 0;
            this.repairGraphButton.Text = "Repair Graph";
            this.repairGraphButton.UseVisualStyleBackColor = true;
            this.repairGraphButton.Click += new System.EventHandler(this.repairGraphButton_Click);
            // 
            // potterGroupBox
            // 
            this.potterGroupBox.Controls.Add(this.autoDtCheckBox);
            this.potterGroupBox.Controls.Add(this.potterType);
            this.potterGroupBox.Controls.Add(this.filterNameComboBox);
            this.potterGroupBox.Controls.Add(this.fc2TextBox);
            this.potterGroupBox.Controls.Add(this.fc2Label);
            this.potterGroupBox.Controls.Add(this.applyPotterButton);
            this.potterGroupBox.Controls.Add(this.dtPotterTextBox);
            this.potterGroupBox.Controls.Add(this.mTextBox);
            this.potterGroupBox.Controls.Add(this.fcTextBox);
            this.potterGroupBox.Controls.Add(this.mLabel);
            this.potterGroupBox.Controls.Add(this.dTPotterLabel);
            this.potterGroupBox.Controls.Add(this.fcLabel);
            this.potterGroupBox.Controls.Add(this.plotPotterButton);
            this.potterGroupBox.Location = new System.Drawing.Point(6, 168);
            this.potterGroupBox.Name = "potterGroupBox";
            this.potterGroupBox.Size = new System.Drawing.Size(371, 82);
            this.potterGroupBox.TabIndex = 2;
            this.potterGroupBox.TabStop = false;
            this.potterGroupBox.Text = "Potter";
            // 
            // autoDtCheckBox
            // 
            this.autoDtCheckBox.AutoSize = true;
            this.autoDtCheckBox.Checked = true;
            this.autoDtCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoDtCheckBox.Location = new System.Drawing.Point(219, 53);
            this.autoDtCheckBox.Name = "autoDtCheckBox";
            this.autoDtCheckBox.Size = new System.Drawing.Size(59, 17);
            this.autoDtCheckBox.TabIndex = 25;
            this.autoDtCheckBox.Text = "auto dt";
            this.autoDtCheckBox.UseVisualStyleBackColor = true;
            this.autoDtCheckBox.CheckedChanged += new System.EventHandler(this.autoDtCheckBox_CheckedChanged);
            // 
            // potterType
            // 
            this.potterType.AutoSize = true;
            this.potterType.Location = new System.Drawing.Point(98, 54);
            this.potterType.Name = "potterType";
            this.potterType.Size = new System.Drawing.Size(31, 13);
            this.potterType.TabIndex = 24;
            this.potterType.Text = "Type";
            // 
            // comboBox1
            // 
            this.filterNameComboBox.FormattingEnabled = true;
            this.filterNameComboBox.Items.AddRange(new object[] {
            "Low Pass",
            "High Pass",
            "Band Pass",
            "Band Stop"});
            this.filterNameComboBox.Location = new System.Drawing.Point(130, 51);
            this.filterNameComboBox.Name = "filterNameComboBox";
            this.filterNameComboBox.Size = new System.Drawing.Size(83, 21);
            this.filterNameComboBox.TabIndex = 23;
            this.filterNameComboBox.Text = "Low Pass";
            // 
            // fc2TextBox
            // 
            this.fc2TextBox.Location = new System.Drawing.Point(28, 51);
            this.fc2TextBox.Name = "fc2TextBox";
            this.fc2TextBox.Size = new System.Drawing.Size(64, 20);
            this.fc2TextBox.TabIndex = 22;
            this.fc2TextBox.Text = "40";
            // 
            // fc2Label
            // 
            this.fc2Label.AutoSize = true;
            this.fc2Label.Location = new System.Drawing.Point(6, 54);
            this.fc2Label.Name = "fc2Label";
            this.fc2Label.Size = new System.Drawing.Size(22, 13);
            this.fc2Label.TabIndex = 21;
            this.fc2Label.Text = "fc2";
            // 
            // applyPotterButton
            // 
            this.applyPotterButton.Location = new System.Drawing.Point(290, 49);
            this.applyPotterButton.Name = "applyPotterButton";
            this.applyPotterButton.Size = new System.Drawing.Size(75, 23);
            this.applyPotterButton.TabIndex = 20;
            this.applyPotterButton.Text = "Apply Potter";
            this.applyPotterButton.UseVisualStyleBackColor = true;
            this.applyPotterButton.Click += new System.EventHandler(this.applyPotterButton_Click);
            // 
            // dtPotterTextBox
            // 
            this.dtPotterTextBox.Enabled = false;
            this.dtPotterTextBox.Location = new System.Drawing.Point(211, 22);
            this.dtPotterTextBox.Name = "dtPotterTextBox";
            this.dtPotterTextBox.Size = new System.Drawing.Size(64, 20);
            this.dtPotterTextBox.TabIndex = 19;
            this.dtPotterTextBox.Text = "0.01";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(119, 22);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(64, 20);
            this.mTextBox.TabIndex = 18;
            this.mTextBox.Text = "64";
            // 
            // fcTextBox
            // 
            this.fcTextBox.Location = new System.Drawing.Point(28, 22);
            this.fcTextBox.Name = "fcTextBox";
            this.fcTextBox.Size = new System.Drawing.Size(64, 20);
            this.fcTextBox.TabIndex = 17;
            this.fcTextBox.Text = "25";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(98, 25);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(15, 13);
            this.mLabel.TabIndex = 12;
            this.mLabel.Text = "m";
            // 
            // dTPotterLabel
            // 
            this.dTPotterLabel.AutoSize = true;
            this.dTPotterLabel.Location = new System.Drawing.Point(189, 25);
            this.dTPotterLabel.Name = "dTPotterLabel";
            this.dTPotterLabel.Size = new System.Drawing.Size(16, 13);
            this.dTPotterLabel.TabIndex = 13;
            this.dTPotterLabel.Text = "dt";
            // 
            // fcLabel
            // 
            this.fcLabel.AutoSize = true;
            this.fcLabel.Location = new System.Drawing.Point(6, 25);
            this.fcLabel.Name = "fcLabel";
            this.fcLabel.Size = new System.Drawing.Size(16, 13);
            this.fcLabel.TabIndex = 11;
            this.fcLabel.Text = "fc";
            // 
            // plotPotterButton
            // 
            this.plotPotterButton.Location = new System.Drawing.Point(290, 20);
            this.plotPotterButton.Name = "plotPotterButton";
            this.plotPotterButton.Size = new System.Drawing.Size(75, 23);
            this.plotPotterButton.TabIndex = 10;
            this.plotPotterButton.Text = "Add Potter";
            this.plotPotterButton.UseVisualStyleBackColor = true;
            this.plotPotterButton.Click += new System.EventHandler(this.plotPotterButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAlphaNoiseDeconvolution);
            this.groupBox1.Controls.Add(this.removeHeartButton);
            this.groupBox1.Controls.Add(this.spikeHeartCheckbox);
            this.groupBox1.Controls.Add(this.addHeartButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heart";
            // 
            // removeHeartButton
            // 
            this.removeHeartButton.Location = new System.Drawing.Point(225, 21);
            this.removeHeartButton.Name = "removeHeartButton";
            this.removeHeartButton.Size = new System.Drawing.Size(75, 23);
            this.removeHeartButton.TabIndex = 2;
            this.removeHeartButton.Text = "Remove";
            this.removeHeartButton.UseVisualStyleBackColor = true;
            this.removeHeartButton.Click += new System.EventHandler(this.removeHeartButton_Click);
            // 
            // spikeHeartCheckbox
            // 
            this.spikeHeartCheckbox.AutoSize = true;
            this.spikeHeartCheckbox.Location = new System.Drawing.Point(10, 24);
            this.spikeHeartCheckbox.Name = "spikeHeartCheckbox";
            this.spikeHeartCheckbox.Size = new System.Drawing.Size(58, 17);
            this.spikeHeartCheckbox.TabIndex = 1;
            this.spikeHeartCheckbox.Text = "Spikes";
            this.spikeHeartCheckbox.UseVisualStyleBackColor = true;
            // 
            // addHeartButton
            // 
            this.addHeartButton.Location = new System.Drawing.Point(74, 20);
            this.addHeartButton.Name = "addHeartButton";
            this.addHeartButton.Size = new System.Drawing.Size(75, 23);
            this.addHeartButton.TabIndex = 0;
            this.addHeartButton.Text = "Add <3";
            this.addHeartButton.UseVisualStyleBackColor = true;
            this.addHeartButton.Click += new System.EventHandler(this.addHeartButton_Click);
            // 
            // graphNumberLabel
            // 
            this.graphNumberLabel.AutoSize = true;
            this.graphNumberLabel.Location = new System.Drawing.Point(6, 8);
            this.graphNumberLabel.Name = "graphNumberLabel";
            this.graphNumberLabel.Size = new System.Drawing.Size(36, 13);
            this.graphNumberLabel.TabIndex = 8;
            this.graphNumberLabel.Text = "Graph";
            // 
            // graphNumericUpDown
            // 
            this.graphNumericUpDown.Location = new System.Drawing.Point(48, 6);
            this.graphNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.graphNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graphNumericUpDown.Name = "graphNumericUpDown";
            this.graphNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.graphNumericUpDown.TabIndex = 9;
            this.graphNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // randomExpGroupBox
            // 
            this.randomExpGroupBox.Controls.Add(this.plotSigmasButton);
            this.randomExpGroupBox.Controls.Add(this.useGraphCheckBox);
            this.randomExpGroupBox.Controls.Add(this.timesTextBox);
            this.randomExpGroupBox.Controls.Add(this.timesLabel);
            this.randomExpGroupBox.Controls.Add(this.maxYTextBox);
            this.randomExpGroupBox.Controls.Add(this.minYTextBox);
            this.randomExpGroupBox.Controls.Add(this.maxY);
            this.randomExpGroupBox.Controls.Add(this.minY);
            this.randomExpGroupBox.Controls.Add(this.addAntiRandom);
            this.randomExpGroupBox.Location = new System.Drawing.Point(6, 33);
            this.randomExpGroupBox.Name = "randomExpGroupBox";
            this.randomExpGroupBox.Size = new System.Drawing.Size(533, 70);
            this.randomExpGroupBox.TabIndex = 0;
            this.randomExpGroupBox.TabStop = false;
            this.randomExpGroupBox.Text = "Anti Random Experiment";
            // 
            // plotSigmasButton
            // 
            this.plotSigmasButton.Location = new System.Drawing.Point(452, 40);
            this.plotSigmasButton.Name = "plotSigmasButton";
            this.plotSigmasButton.Size = new System.Drawing.Size(75, 23);
            this.plotSigmasButton.TabIndex = 10;
            this.plotSigmasButton.Text = "Plot sigmas";
            this.plotSigmasButton.UseVisualStyleBackColor = true;
            this.plotSigmasButton.Click += new System.EventHandler(this.plotSigmasButton_Click);
            // 
            // useGraphCheckBox
            // 
            this.useGraphCheckBox.AutoSize = true;
            this.useGraphCheckBox.Location = new System.Drawing.Point(10, 42);
            this.useGraphCheckBox.Name = "useGraphCheckBox";
            this.useGraphCheckBox.Size = new System.Drawing.Size(77, 17);
            this.useGraphCheckBox.TabIndex = 7;
            this.useGraphCheckBox.Text = "Use Graph";
            this.useGraphCheckBox.UseVisualStyleBackColor = true;
            // 
            // timesTextBox
            // 
            this.timesTextBox.Location = new System.Drawing.Point(343, 16);
            this.timesTextBox.Name = "timesTextBox";
            this.timesTextBox.Size = new System.Drawing.Size(100, 20);
            this.timesTextBox.TabIndex = 6;
            this.timesTextBox.Text = "10";
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Location = new System.Drawing.Point(302, 19);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(35, 13);
            this.timesLabel.TabIndex = 5;
            this.timesLabel.Text = "Times";
            // 
            // maxYTextBox
            // 
            this.maxYTextBox.Location = new System.Drawing.Point(196, 16);
            this.maxYTextBox.Name = "maxYTextBox";
            this.maxYTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxYTextBox.TabIndex = 4;
            this.maxYTextBox.Text = "1";
            // 
            // minYTextBox
            // 
            this.minYTextBox.Location = new System.Drawing.Point(47, 16);
            this.minYTextBox.Name = "minYTextBox";
            this.minYTextBox.Size = new System.Drawing.Size(100, 20);
            this.minYTextBox.TabIndex = 3;
            this.minYTextBox.Text = "-1";
            // 
            // maxY
            // 
            this.maxY.AutoSize = true;
            this.maxY.Location = new System.Drawing.Point(153, 19);
            this.maxY.Name = "maxY";
            this.maxY.Size = new System.Drawing.Size(37, 13);
            this.maxY.TabIndex = 2;
            this.maxY.Text = "Max Y";
            // 
            // minY
            // 
            this.minY.AutoSize = true;
            this.minY.Location = new System.Drawing.Point(7, 19);
            this.minY.Name = "minY";
            this.minY.Size = new System.Drawing.Size(34, 13);
            this.minY.TabIndex = 1;
            this.minY.Text = "Min Y";
            // 
            // addAntiRandom
            // 
            this.addAntiRandom.Location = new System.Drawing.Point(452, 14);
            this.addAntiRandom.Name = "addAntiRandom";
            this.addAntiRandom.Size = new System.Drawing.Size(75, 23);
            this.addAntiRandom.TabIndex = 0;
            this.addAntiRandom.Text = "Add";
            this.addAntiRandom.UseVisualStyleBackColor = true;
            this.addAntiRandom.Click += new System.EventHandler(this.addAntiRandom_Click);
            // 
            // dtmfTab
            // 
            this.dtmfTab.Controls.Add(this.getDtmf);
            this.dtmfTab.Controls.Add(this.dtmfResultRichTextBox);
            this.dtmfTab.Location = new System.Drawing.Point(4, 22);
            this.dtmfTab.Name = "dtmfTab";
            this.dtmfTab.Padding = new System.Windows.Forms.Padding(3);
            this.dtmfTab.Size = new System.Drawing.Size(545, 383);
            this.dtmfTab.TabIndex = 2;
            this.dtmfTab.Text = "DTMF";
            this.dtmfTab.UseVisualStyleBackColor = true;
            // 
            // getDtmf
            // 
            this.getDtmf.Location = new System.Drawing.Point(464, 354);
            this.getDtmf.Name = "getDtmf";
            this.getDtmf.Size = new System.Drawing.Size(75, 23);
            this.getDtmf.TabIndex = 1;
            this.getDtmf.Text = "Get";
            this.getDtmf.UseVisualStyleBackColor = true;
            this.getDtmf.Click += new System.EventHandler(this.getDtmf_Click);
            // 
            // dtmfResultRichTextBox
            // 
            this.dtmfResultRichTextBox.Location = new System.Drawing.Point(6, 6);
            this.dtmfResultRichTextBox.Name = "dtmfResultRichTextBox";
            this.dtmfResultRichTextBox.Size = new System.Drawing.Size(533, 342);
            this.dtmfResultRichTextBox.TabIndex = 0;
            this.dtmfResultRichTextBox.Text = "";
            // 
            // textBoxAlphaNoiseDeconvolution
            // 
            this.textBoxAlphaNoiseDeconvolution.Location = new System.Drawing.Point(155, 22);
            this.textBoxAlphaNoiseDeconvolution.Name = "textBoxAlphaNoiseDeconvolution";
            this.textBoxAlphaNoiseDeconvolution.Size = new System.Drawing.Size(64, 20);
            this.textBoxAlphaNoiseDeconvolution.TabIndex = 26;
            this.textBoxAlphaNoiseDeconvolution.Text = "0.1";
            // 
            // GraphManipulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.graphListBox);
            this.Name = "GraphManipulatorForm";
            this.Text = "Graph Manipulator";
            this.shiftGroupBox.ResumeLayout(false);
            this.shiftGroupBox.PerformLayout();
            this.AntishiftGroupBox.ResumeLayout(false);
            this.spikeGroupBox.ResumeLayout(false);
            this.spikeGroupBox.PerformLayout();
            this.antiSpikeGroupBox.ResumeLayout(false);
            this.antiSpikeGroupBox.PerformLayout();
            this.antiTrendGroupBox.ResumeLayout(false);
            this.antiTrendGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.manipulationsTab.ResumeLayout(false);
            this.cutGroupBox.ResumeLayout(false);
            this.cutGroupBox.PerformLayout();
            this.experimentsTab.ResumeLayout(false);
            this.experimentsTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.potterGroupBox.ResumeLayout(false);
            this.potterGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphNumericUpDown)).EndInit();
            this.randomExpGroupBox.ResumeLayout(false);
            this.randomExpGroupBox.PerformLayout();
            this.dtmfTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox graphListBox;
        private System.Windows.Forms.GroupBox shiftGroupBox;
        private System.Windows.Forms.Button shiftButton;
        private System.Windows.Forms.TextBox shiftParTextbox;
        private System.Windows.Forms.GroupBox AntishiftGroupBox;
        private System.Windows.Forms.Button antishiftButton;
        private System.Windows.Forms.GroupBox spikeGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label spikeMinLabel;
        private System.Windows.Forms.TextBox spikeMaxValueTextbox;
        private System.Windows.Forms.TextBox spikeMinValueTextbox;
        private System.Windows.Forms.Button addSpikesButton;
        private System.Windows.Forms.TextBox spikeCountTextbox;
        private System.Windows.Forms.GroupBox antiSpikeGroupBox;
        private System.Windows.Forms.Button proceedAntiSpikeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sTextBox;
        private System.Windows.Forms.GroupBox antiTrendGroupBox;
        private System.Windows.Forms.Button antiTrendButton;
        private System.Windows.Forms.Label WindowSizeLabel;
        private System.Windows.Forms.TextBox winSizeTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manipulationsTab;
        private System.Windows.Forms.TabPage experimentsTab;
        private System.Windows.Forms.GroupBox randomExpGroupBox;
        private System.Windows.Forms.Button plotSigmasButton;
        private System.Windows.Forms.NumericUpDown graphNumericUpDown;
        private System.Windows.Forms.Label graphNumberLabel;
        private System.Windows.Forms.CheckBox useGraphCheckBox;
        private System.Windows.Forms.TextBox timesTextBox;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.TextBox maxYTextBox;
        private System.Windows.Forms.TextBox minYTextBox;
        private System.Windows.Forms.Label maxY;
        private System.Windows.Forms.Label minY;
        private System.Windows.Forms.Button addAntiRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addHeartButton;
        private System.Windows.Forms.CheckBox spikeHeartCheckbox;
        private System.Windows.Forms.Button plotPotterButton;
        private System.Windows.Forms.GroupBox potterGroupBox;
        private System.Windows.Forms.TextBox dtPotterTextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox fcTextBox;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label dTPotterLabel;
        private System.Windows.Forms.Label fcLabel;
        private System.Windows.Forms.Button applyPotterButton;
        private System.Windows.Forms.TextBox fc2TextBox;
        private System.Windows.Forms.Label fc2Label;
        private System.Windows.Forms.CheckBox autoDtCheckBox;
        private System.Windows.Forms.Label potterType;
        private System.Windows.Forms.ComboBox filterNameComboBox;
        private System.Windows.Forms.Button antinoiseButton;
        private System.Windows.Forms.TabPage dtmfTab;
        private System.Windows.Forms.Button getDtmf;
        private System.Windows.Forms.RichTextBox dtmfResultRichTextBox;
        private System.Windows.Forms.GroupBox cutGroupBox;
        private System.Windows.Forms.TextBox cutToTextBox;
        private System.Windows.Forms.Label cutToLabel;
        private System.Windows.Forms.TextBox cutFromTextBox;
        private System.Windows.Forms.Label cutFromLabel;
        private System.Windows.Forms.Button cutProceedButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button repairGraphButton;
        private System.Windows.Forms.Button buttonGetDerivative;
        private System.Windows.Forms.Button removeHeartButton;
        private System.Windows.Forms.TextBox textBoxAlphaNoiseDeconvolution;
    }
}