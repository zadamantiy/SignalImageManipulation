namespace SuData
{
    partial class GraphAnalyzer
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
            this.graphListBox = new System.Windows.Forms.CheckedListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.logTab = new System.Windows.Forms.TabPage();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.analyzeTab = new System.Windows.Forms.TabPage();
            this.stationaryGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateStationaryButton = new System.Windows.Forms.Button();
            this.subsetStationaryTextbox = new System.Windows.Forms.TextBox();
            this.paramsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.specToTextbox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.specFromTextbox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.distributionTabPage = new System.Windows.Forms.TabPage();
            this.copyButton = new System.Windows.Forms.Button();
            this.plotButton = new System.Windows.Forms.Button();
            this.distributionZedGraphControl = new ZedGraph.ZedGraphControl();
            this.rxxTabPage = new System.Windows.Forms.TabPage();
            this.copyRxxButton = new System.Windows.Forms.Button();
            this.rxxPlotButton = new System.Windows.Forms.Button();
            this.rxxZedGraphControl = new ZedGraph.ZedGraphControl();
            this.rxyTab = new System.Windows.Forms.TabPage();
            this.copyRxyButton = new System.Windows.Forms.Button();
            this.numUpDownGraphNumber = new System.Windows.Forms.NumericUpDown();
            this.plotRxyButton = new System.Windows.Forms.Button();
            this.rxyZedGraphControl = new ZedGraph.ZedGraphControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plotSpectreButton2 = new System.Windows.Forms.Button();
            this.normalizationCheckBox = new System.Windows.Forms.CheckBox();
            this.copySpectreButton = new System.Windows.Forms.Button();
            this.plotSpectreButton = new System.Windows.Forms.Button();
            this.spectreZgc = new ZedGraph.ZedGraphControl();
            this.buttonSpectrePlusReverse = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.logTab.SuspendLayout();
            this.analyzeTab.SuspendLayout();
            this.stationaryGroupBox.SuspendLayout();
            this.paramsGroupBox1.SuspendLayout();
            this.distributionTabPage.SuspendLayout();
            this.rxxTabPage.SuspendLayout();
            this.rxyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGraphNumber)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphListBox
            // 
            this.graphListBox.FormattingEnabled = true;
            this.graphListBox.Location = new System.Drawing.Point(12, 12);
            this.graphListBox.Name = "graphListBox";
            this.graphListBox.Size = new System.Drawing.Size(238, 424);
            this.graphListBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.logTab);
            this.tabControl.Controls.Add(this.analyzeTab);
            this.tabControl.Controls.Add(this.distributionTabPage);
            this.tabControl.Controls.Add(this.rxxTabPage);
            this.tabControl.Controls.Add(this.rxyTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(256, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(532, 422);
            this.tabControl.TabIndex = 6;
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logRichTextBox);
            this.logTab.Location = new System.Drawing.Point(4, 22);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(524, 396);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(6, 6);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(512, 384);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // analyzeTab
            // 
            this.analyzeTab.Controls.Add(this.stationaryGroupBox);
            this.analyzeTab.Controls.Add(this.paramsGroupBox1);
            this.analyzeTab.Location = new System.Drawing.Point(4, 22);
            this.analyzeTab.Name = "analyzeTab";
            this.analyzeTab.Padding = new System.Windows.Forms.Padding(3);
            this.analyzeTab.Size = new System.Drawing.Size(524, 396);
            this.analyzeTab.TabIndex = 0;
            this.analyzeTab.Text = "Analyze";
            this.analyzeTab.UseVisualStyleBackColor = true;
            // 
            // stationaryGroupBox
            // 
            this.stationaryGroupBox.Controls.Add(this.label1);
            this.stationaryGroupBox.Controls.Add(this.calculateStationaryButton);
            this.stationaryGroupBox.Controls.Add(this.subsetStationaryTextbox);
            this.stationaryGroupBox.Location = new System.Drawing.Point(7, 61);
            this.stationaryGroupBox.Name = "stationaryGroupBox";
            this.stationaryGroupBox.Size = new System.Drawing.Size(511, 46);
            this.stationaryGroupBox.TabIndex = 4;
            this.stationaryGroupBox.TabStop = false;
            this.stationaryGroupBox.Text = "Stationary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subset Amount";
            // 
            // calculateStationaryButton
            // 
            this.calculateStationaryButton.Location = new System.Drawing.Point(407, 16);
            this.calculateStationaryButton.Name = "calculateStationaryButton";
            this.calculateStationaryButton.Size = new System.Drawing.Size(98, 23);
            this.calculateStationaryButton.TabIndex = 6;
            this.calculateStationaryButton.Text = "Calculate";
            this.calculateStationaryButton.UseVisualStyleBackColor = true;
            this.calculateStationaryButton.Click += new System.EventHandler(this.calculateStationaryButton_Click);
            // 
            // subsetStationaryTextbox
            // 
            this.subsetStationaryTextbox.Location = new System.Drawing.Point(91, 18);
            this.subsetStationaryTextbox.Name = "subsetStationaryTextbox";
            this.subsetStationaryTextbox.Size = new System.Drawing.Size(87, 20);
            this.subsetStationaryTextbox.TabIndex = 6;
            // 
            // paramsGroupBox1
            // 
            this.paramsGroupBox1.Controls.Add(this.specToTextbox);
            this.paramsGroupBox1.Controls.Add(this.toLabel);
            this.paramsGroupBox1.Controls.Add(this.specFromTextbox);
            this.paramsGroupBox1.Controls.Add(this.fromLabel);
            this.paramsGroupBox1.Controls.Add(this.calculateButton);
            this.paramsGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.paramsGroupBox1.Name = "paramsGroupBox1";
            this.paramsGroupBox1.Size = new System.Drawing.Size(512, 48);
            this.paramsGroupBox1.TabIndex = 3;
            this.paramsGroupBox1.TabStop = false;
            this.paramsGroupBox1.Text = "Specifications";
            // 
            // specToTextbox
            // 
            this.specToTextbox.Location = new System.Drawing.Point(161, 21);
            this.specToTextbox.Name = "specToTextbox";
            this.specToTextbox.Size = new System.Drawing.Size(87, 20);
            this.specToTextbox.TabIndex = 5;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(135, 24);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            // 
            // specFromTextbox
            // 
            this.specFromTextbox.Location = new System.Drawing.Point(42, 21);
            this.specFromTextbox.Name = "specFromTextbox";
            this.specFromTextbox.Size = new System.Drawing.Size(87, 20);
            this.specFromTextbox.TabIndex = 3;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(6, 24);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(408, 19);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // distributionTabPage
            // 
            this.distributionTabPage.Controls.Add(this.copyButton);
            this.distributionTabPage.Controls.Add(this.plotButton);
            this.distributionTabPage.Controls.Add(this.distributionZedGraphControl);
            this.distributionTabPage.Location = new System.Drawing.Point(4, 22);
            this.distributionTabPage.Name = "distributionTabPage";
            this.distributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.distributionTabPage.Size = new System.Drawing.Size(524, 396);
            this.distributionTabPage.TabIndex = 2;
            this.distributionTabPage.Text = "Distribution";
            this.distributionTabPage.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(6, 367);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(443, 367);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(75, 23);
            this.plotButton.TabIndex = 1;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // distributionZedGraphControl
            // 
            this.distributionZedGraphControl.Location = new System.Drawing.Point(6, 6);
            this.distributionZedGraphControl.Name = "distributionZedGraphControl";
            this.distributionZedGraphControl.ScrollGrace = 0D;
            this.distributionZedGraphControl.ScrollMaxX = 0D;
            this.distributionZedGraphControl.ScrollMaxY = 0D;
            this.distributionZedGraphControl.ScrollMaxY2 = 0D;
            this.distributionZedGraphControl.ScrollMinX = 0D;
            this.distributionZedGraphControl.ScrollMinY = 0D;
            this.distributionZedGraphControl.ScrollMinY2 = 0D;
            this.distributionZedGraphControl.Size = new System.Drawing.Size(512, 355);
            this.distributionZedGraphControl.TabIndex = 0;
            this.distributionZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // rxxTabPage
            // 
            this.rxxTabPage.Controls.Add(this.copyRxxButton);
            this.rxxTabPage.Controls.Add(this.rxxPlotButton);
            this.rxxTabPage.Controls.Add(this.rxxZedGraphControl);
            this.rxxTabPage.Location = new System.Drawing.Point(4, 22);
            this.rxxTabPage.Name = "rxxTabPage";
            this.rxxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rxxTabPage.Size = new System.Drawing.Size(524, 396);
            this.rxxTabPage.TabIndex = 3;
            this.rxxTabPage.Text = "Rxx";
            this.rxxTabPage.UseVisualStyleBackColor = true;
            // 
            // copyRxxButton
            // 
            this.copyRxxButton.Location = new System.Drawing.Point(6, 367);
            this.copyRxxButton.Name = "copyRxxButton";
            this.copyRxxButton.Size = new System.Drawing.Size(75, 23);
            this.copyRxxButton.TabIndex = 3;
            this.copyRxxButton.Text = "Copy";
            this.copyRxxButton.UseVisualStyleBackColor = true;
            this.copyRxxButton.Click += new System.EventHandler(this.copyRxxButton_Click);
            // 
            // rxxPlotButton
            // 
            this.rxxPlotButton.Location = new System.Drawing.Point(443, 367);
            this.rxxPlotButton.Name = "rxxPlotButton";
            this.rxxPlotButton.Size = new System.Drawing.Size(75, 23);
            this.rxxPlotButton.TabIndex = 2;
            this.rxxPlotButton.Text = "Plot";
            this.rxxPlotButton.UseVisualStyleBackColor = true;
            this.rxxPlotButton.Click += new System.EventHandler(this.rxxPlotButton_Click);
            // 
            // rxxZedGraphControl
            // 
            this.rxxZedGraphControl.Location = new System.Drawing.Point(6, 6);
            this.rxxZedGraphControl.Name = "rxxZedGraphControl";
            this.rxxZedGraphControl.ScrollGrace = 0D;
            this.rxxZedGraphControl.ScrollMaxX = 0D;
            this.rxxZedGraphControl.ScrollMaxY = 0D;
            this.rxxZedGraphControl.ScrollMaxY2 = 0D;
            this.rxxZedGraphControl.ScrollMinX = 0D;
            this.rxxZedGraphControl.ScrollMinY = 0D;
            this.rxxZedGraphControl.ScrollMinY2 = 0D;
            this.rxxZedGraphControl.Size = new System.Drawing.Size(512, 355);
            this.rxxZedGraphControl.TabIndex = 1;
            this.rxxZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // rxyTab
            // 
            this.rxyTab.Controls.Add(this.copyRxyButton);
            this.rxyTab.Controls.Add(this.numUpDownGraphNumber);
            this.rxyTab.Controls.Add(this.plotRxyButton);
            this.rxyTab.Controls.Add(this.rxyZedGraphControl);
            this.rxyTab.Location = new System.Drawing.Point(4, 22);
            this.rxyTab.Name = "rxyTab";
            this.rxyTab.Padding = new System.Windows.Forms.Padding(3);
            this.rxyTab.Size = new System.Drawing.Size(524, 396);
            this.rxyTab.TabIndex = 4;
            this.rxyTab.Text = "Rxy";
            this.rxyTab.UseVisualStyleBackColor = true;
            // 
            // copyRxyButton
            // 
            this.copyRxyButton.Location = new System.Drawing.Point(6, 367);
            this.copyRxyButton.Name = "copyRxyButton";
            this.copyRxyButton.Size = new System.Drawing.Size(75, 23);
            this.copyRxyButton.TabIndex = 5;
            this.copyRxyButton.Text = "Copy";
            this.copyRxyButton.UseVisualStyleBackColor = true;
            this.copyRxyButton.Click += new System.EventHandler(this.copyRxyButton_Click);
            // 
            // numUpDownGraphNumber
            // 
            this.numUpDownGraphNumber.Location = new System.Drawing.Point(381, 370);
            this.numUpDownGraphNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDownGraphNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownGraphNumber.Name = "numUpDownGraphNumber";
            this.numUpDownGraphNumber.Size = new System.Drawing.Size(56, 20);
            this.numUpDownGraphNumber.TabIndex = 4;
            this.numUpDownGraphNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // plotRxyButton
            // 
            this.plotRxyButton.Location = new System.Drawing.Point(443, 367);
            this.plotRxyButton.Name = "plotRxyButton";
            this.plotRxyButton.Size = new System.Drawing.Size(75, 23);
            this.plotRxyButton.TabIndex = 3;
            this.plotRxyButton.Text = "Plot";
            this.plotRxyButton.UseVisualStyleBackColor = true;
            this.plotRxyButton.Click += new System.EventHandler(this.plotRxyButton_Click);
            // 
            // rxyZedGraphControl
            // 
            this.rxyZedGraphControl.Location = new System.Drawing.Point(6, 6);
            this.rxyZedGraphControl.Name = "rxyZedGraphControl";
            this.rxyZedGraphControl.ScrollGrace = 0D;
            this.rxyZedGraphControl.ScrollMaxX = 0D;
            this.rxyZedGraphControl.ScrollMaxY = 0D;
            this.rxyZedGraphControl.ScrollMaxY2 = 0D;
            this.rxyZedGraphControl.ScrollMinX = 0D;
            this.rxyZedGraphControl.ScrollMinY = 0D;
            this.rxyZedGraphControl.ScrollMinY2 = 0D;
            this.rxyZedGraphControl.Size = new System.Drawing.Size(512, 355);
            this.rxyZedGraphControl.TabIndex = 2;
            this.rxyZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSpectrePlusReverse);
            this.tabPage1.Controls.Add(this.plotSpectreButton2);
            this.tabPage1.Controls.Add(this.normalizationCheckBox);
            this.tabPage1.Controls.Add(this.copySpectreButton);
            this.tabPage1.Controls.Add(this.plotSpectreButton);
            this.tabPage1.Controls.Add(this.spectreZgc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 396);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Spectre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // plotSpectreButton2
            // 
            this.plotSpectreButton2.Location = new System.Drawing.Point(276, 365);
            this.plotSpectreButton2.Name = "plotSpectreButton2";
            this.plotSpectreButton2.Size = new System.Drawing.Size(75, 23);
            this.plotSpectreButton2.TabIndex = 6;
            this.plotSpectreButton2.Text = "Plot V2";
            this.plotSpectreButton2.UseVisualStyleBackColor = true;
            this.plotSpectreButton2.Click += new System.EventHandler(this.plotSpectreButton2_Click);
            // 
            // normalizationCheckBox
            // 
            this.normalizationCheckBox.AutoSize = true;
            this.normalizationCheckBox.Checked = true;
            this.normalizationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalizationCheckBox.Location = new System.Drawing.Point(357, 371);
            this.normalizationCheckBox.Name = "normalizationCheckBox";
            this.normalizationCheckBox.Size = new System.Drawing.Size(72, 17);
            this.normalizationCheckBox.TabIndex = 5;
            this.normalizationCheckBox.Text = "Normalize";
            this.normalizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // copySpectreButton
            // 
            this.copySpectreButton.Location = new System.Drawing.Point(6, 367);
            this.copySpectreButton.Name = "copySpectreButton";
            this.copySpectreButton.Size = new System.Drawing.Size(75, 23);
            this.copySpectreButton.TabIndex = 4;
            this.copySpectreButton.Text = "Copy";
            this.copySpectreButton.UseVisualStyleBackColor = true;
            this.copySpectreButton.Click += new System.EventHandler(this.copySpectreButton_Click);
            // 
            // plotSpectreButton
            // 
            this.plotSpectreButton.Location = new System.Drawing.Point(443, 367);
            this.plotSpectreButton.Name = "plotSpectreButton";
            this.plotSpectreButton.Size = new System.Drawing.Size(75, 23);
            this.plotSpectreButton.TabIndex = 1;
            this.plotSpectreButton.Text = "Plot";
            this.plotSpectreButton.UseVisualStyleBackColor = true;
            this.plotSpectreButton.Click += new System.EventHandler(this.plotSpectreButton_Click);
            // 
            // spectreZgc
            // 
            this.spectreZgc.Location = new System.Drawing.Point(6, 6);
            this.spectreZgc.Name = "spectreZgc";
            this.spectreZgc.ScrollGrace = 0D;
            this.spectreZgc.ScrollMaxX = 0D;
            this.spectreZgc.ScrollMaxY = 0D;
            this.spectreZgc.ScrollMaxY2 = 0D;
            this.spectreZgc.ScrollMinX = 0D;
            this.spectreZgc.ScrollMinY = 0D;
            this.spectreZgc.ScrollMinY2 = 0D;
            this.spectreZgc.Size = new System.Drawing.Size(512, 355);
            this.spectreZgc.TabIndex = 0;
            this.spectreZgc.UseExtendedPrintDialog = true;
            // 
            // buttonSpectrePlusReverse
            // 
            this.buttonSpectrePlusReverse.Location = new System.Drawing.Point(195, 365);
            this.buttonSpectrePlusReverse.Name = "buttonSpectrePlusReverse";
            this.buttonSpectrePlusReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonSpectrePlusReverse.TabIndex = 7;
            this.buttonSpectrePlusReverse.Text = "Reverse";
            this.buttonSpectrePlusReverse.UseVisualStyleBackColor = true;
            this.buttonSpectrePlusReverse.Click += new System.EventHandler(this.buttonSpectrePlusReverse_Click);
            // 
            // GraphAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.graphListBox);
            this.Name = "GraphAnalyzer";
            this.Text = "GraphAnalyzer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphAnalyzer_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.logTab.ResumeLayout(false);
            this.analyzeTab.ResumeLayout(false);
            this.stationaryGroupBox.ResumeLayout(false);
            this.stationaryGroupBox.PerformLayout();
            this.paramsGroupBox1.ResumeLayout(false);
            this.paramsGroupBox1.PerformLayout();
            this.distributionTabPage.ResumeLayout(false);
            this.rxxTabPage.ResumeLayout(false);
            this.rxyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGraphNumber)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox graphListBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TabPage analyzeTab;
        private System.Windows.Forms.GroupBox paramsGroupBox1;
        private System.Windows.Forms.TextBox specToTextbox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox specFromTextbox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox stationaryGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateStationaryButton;
        private System.Windows.Forms.TextBox subsetStationaryTextbox;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.TabPage distributionTabPage;
        private System.Windows.Forms.Button plotButton;
        private ZedGraph.ZedGraphControl distributionZedGraphControl;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TabPage rxxTabPage;
        private System.Windows.Forms.Button rxxPlotButton;
        private ZedGraph.ZedGraphControl rxxZedGraphControl;
        private System.Windows.Forms.Button copyRxxButton;
        private System.Windows.Forms.TabPage rxyTab;
        private ZedGraph.ZedGraphControl rxyZedGraphControl;
        private System.Windows.Forms.NumericUpDown numUpDownGraphNumber;
        private System.Windows.Forms.Button plotRxyButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button plotSpectreButton;
        private ZedGraph.ZedGraphControl spectreZgc;
        private System.Windows.Forms.Button copyRxyButton;
        private System.Windows.Forms.Button copySpectreButton;
        private System.Windows.Forms.CheckBox normalizationCheckBox;
        private System.Windows.Forms.Button plotSpectreButton2;
        private System.Windows.Forms.Button buttonSpectrePlusReverse;
    }
}