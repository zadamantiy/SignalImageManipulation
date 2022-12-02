namespace SuData
{
    partial class GraphEditor
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
            this.cb_graphType = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_minX = new System.Windows.Forms.Label();
            this.tb_minX = new System.Windows.Forms.TextBox();
            this.tb_maxX = new System.Windows.Forms.TextBox();
            this.lbl_maxX = new System.Windows.Forms.Label();
            this.tb_delta = new System.Windows.Forms.TextBox();
            this.lbl_delta = new System.Windows.Forms.Label();
            this.mergeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.setNButton = new System.Windows.Forms.Button();
            this.nTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.trendTabPage = new System.Windows.Forms.TabPage();
            this.sampleRateTextBox = new System.Windows.Forms.TextBox();
            this.sampleRateButton = new System.Windows.Forms.Button();
            this.loadFileTabPage = new System.Windows.Forms.TabPage();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.datFilePathTextBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.wavTab = new System.Windows.Forms.TabPage();
            this.saveWavButton = new System.Windows.Forms.Button();
            this.wavPathTextBox = new System.Windows.Forms.TextBox();
            this.loadWavButton = new System.Windows.Forms.Button();
            this.openWavButton = new System.Windows.Forms.Button();
            this.DtmfTab = new System.Windows.Forms.TabPage();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDatTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.trendTabPage.SuspendLayout();
            this.loadFileTabPage.SuspendLayout();
            this.wavTab.SuspendLayout();
            this.DtmfTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_graphType
            // 
            this.cb_graphType.FormattingEnabled = true;
            this.cb_graphType.Location = new System.Drawing.Point(6, 6);
            this.cb_graphType.Name = "cb_graphType";
            this.cb_graphType.Size = new System.Drawing.Size(141, 21);
            this.cb_graphType.TabIndex = 0;
            this.cb_graphType.SelectedIndexChanged += new System.EventHandler(this.cb_graphType_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(153, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(153, 32);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_minX
            // 
            this.lbl_minX.AutoSize = true;
            this.lbl_minX.Location = new System.Drawing.Point(7, 37);
            this.lbl_minX.Name = "lbl_minX";
            this.lbl_minX.Size = new System.Drawing.Size(34, 13);
            this.lbl_minX.TabIndex = 4;
            this.lbl_minX.Text = "Min X";
            // 
            // tb_minX
            // 
            this.tb_minX.Location = new System.Drawing.Point(47, 34);
            this.tb_minX.Name = "tb_minX";
            this.tb_minX.Size = new System.Drawing.Size(100, 20);
            this.tb_minX.TabIndex = 5;
            this.tb_minX.Text = "0";
            // 
            // tb_maxX
            // 
            this.tb_maxX.Location = new System.Drawing.Point(47, 60);
            this.tb_maxX.Name = "tb_maxX";
            this.tb_maxX.Size = new System.Drawing.Size(100, 20);
            this.tb_maxX.TabIndex = 7;
            this.tb_maxX.Text = "1";
            // 
            // lbl_maxX
            // 
            this.lbl_maxX.AutoSize = true;
            this.lbl_maxX.Location = new System.Drawing.Point(7, 63);
            this.lbl_maxX.Name = "lbl_maxX";
            this.lbl_maxX.Size = new System.Drawing.Size(37, 13);
            this.lbl_maxX.TabIndex = 6;
            this.lbl_maxX.Text = "Max X";
            // 
            // tb_delta
            // 
            this.tb_delta.Location = new System.Drawing.Point(47, 86);
            this.tb_delta.Name = "tb_delta";
            this.tb_delta.Size = new System.Drawing.Size(100, 20);
            this.tb_delta.TabIndex = 9;
            this.tb_delta.Text = "0,001";
            // 
            // lbl_delta
            // 
            this.lbl_delta.AutoSize = true;
            this.lbl_delta.Location = new System.Drawing.Point(7, 89);
            this.lbl_delta.Name = "lbl_delta";
            this.lbl_delta.Size = new System.Drawing.Size(32, 13);
            this.lbl_delta.TabIndex = 8;
            this.lbl_delta.Text = "Delta";
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(153, 58);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 23);
            this.mergeButton.TabIndex = 10;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(153, 84);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit Graphs";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // setNButton
            // 
            this.setNButton.Location = new System.Drawing.Point(153, 136);
            this.setNButton.Name = "setNButton";
            this.setNButton.Size = new System.Drawing.Size(75, 23);
            this.setNButton.TabIndex = 12;
            this.setNButton.Text = "Change N";
            this.setNButton.UseVisualStyleBackColor = true;
            this.setNButton.Click += new System.EventHandler(this.setNButton_Click);
            // 
            // nTextbox
            // 
            this.nTextbox.Location = new System.Drawing.Point(153, 112);
            this.nTextbox.Name = "nTextbox";
            this.nTextbox.Size = new System.Drawing.Size(75, 20);
            this.nTextbox.TabIndex = 13;
            this.nTextbox.Text = "1000";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.trendTabPage);
            this.tabControl1.Controls.Add(this.loadFileTabPage);
            this.tabControl1.Controls.Add(this.wavTab);
            this.tabControl1.Controls.Add(this.DtmfTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 253);
            this.tabControl1.TabIndex = 14;
            // 
            // trendTabPage
            // 
            this.trendTabPage.Controls.Add(this.sampleRateTextBox);
            this.trendTabPage.Controls.Add(this.sampleRateButton);
            this.trendTabPage.Controls.Add(this.cb_graphType);
            this.trendTabPage.Controls.Add(this.nTextbox);
            this.trendTabPage.Controls.Add(this.btn_add);
            this.trendTabPage.Controls.Add(this.setNButton);
            this.trendTabPage.Controls.Add(this.btn_clear);
            this.trendTabPage.Controls.Add(this.editButton);
            this.trendTabPage.Controls.Add(this.lbl_minX);
            this.trendTabPage.Controls.Add(this.mergeButton);
            this.trendTabPage.Controls.Add(this.tb_minX);
            this.trendTabPage.Controls.Add(this.tb_delta);
            this.trendTabPage.Controls.Add(this.lbl_maxX);
            this.trendTabPage.Controls.Add(this.lbl_delta);
            this.trendTabPage.Controls.Add(this.tb_maxX);
            this.trendTabPage.Location = new System.Drawing.Point(4, 22);
            this.trendTabPage.Name = "trendTabPage";
            this.trendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trendTabPage.Size = new System.Drawing.Size(234, 227);
            this.trendTabPage.TabIndex = 0;
            this.trendTabPage.Text = "Trends";
            this.trendTabPage.UseVisualStyleBackColor = true;
            // 
            // sampleRateTextBox
            // 
            this.sampleRateTextBox.Location = new System.Drawing.Point(153, 165);
            this.sampleRateTextBox.Name = "sampleRateTextBox";
            this.sampleRateTextBox.Size = new System.Drawing.Size(75, 20);
            this.sampleRateTextBox.TabIndex = 15;
            this.sampleRateTextBox.Text = "22050";
            // 
            // sampleRateButton
            // 
            this.sampleRateButton.Location = new System.Drawing.Point(153, 191);
            this.sampleRateButton.Name = "sampleRateButton";
            this.sampleRateButton.Size = new System.Drawing.Size(75, 23);
            this.sampleRateButton.TabIndex = 14;
            this.sampleRateButton.Text = "SRate to Dt";
            this.sampleRateButton.UseVisualStyleBackColor = true;
            this.sampleRateButton.Click += new System.EventHandler(this.sampleRateButton_Click);
            // 
            // loadFileTabPage
            // 
            this.loadFileTabPage.Controls.Add(this.dtDatTextBox);
            this.loadFileTabPage.Controls.Add(this.label1);
            this.loadFileTabPage.Controls.Add(this.saveFileButton);
            this.loadFileTabPage.Controls.Add(this.datFilePathTextBox);
            this.loadFileTabPage.Controls.Add(this.loadFileButton);
            this.loadFileTabPage.Controls.Add(this.openFileButton);
            this.loadFileTabPage.Location = new System.Drawing.Point(4, 22);
            this.loadFileTabPage.Name = "loadFileTabPage";
            this.loadFileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loadFileTabPage.Size = new System.Drawing.Size(234, 227);
            this.loadFileTabPage.TabIndex = 1;
            this.loadFileTabPage.Text = "Dat File";
            this.loadFileTabPage.UseVisualStyleBackColor = true;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(152, 90);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveFileButton.TabIndex = 8;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // datFilePathTextBox
            // 
            this.datFilePathTextBox.Location = new System.Drawing.Point(6, 6);
            this.datFilePathTextBox.Name = "datFilePathTextBox";
            this.datFilePathTextBox.Size = new System.Drawing.Size(221, 20);
            this.datFilePathTextBox.TabIndex = 2;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(153, 61);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Load";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(153, 32);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // wavTab
            // 
            this.wavTab.Controls.Add(this.saveWavButton);
            this.wavTab.Controls.Add(this.wavPathTextBox);
            this.wavTab.Controls.Add(this.loadWavButton);
            this.wavTab.Controls.Add(this.openWavButton);
            this.wavTab.Location = new System.Drawing.Point(4, 22);
            this.wavTab.Name = "wavTab";
            this.wavTab.Padding = new System.Windows.Forms.Padding(3);
            this.wavTab.Size = new System.Drawing.Size(234, 227);
            this.wavTab.TabIndex = 2;
            this.wavTab.Text = "Wav";
            this.wavTab.UseVisualStyleBackColor = true;
            // 
            // saveWavButton
            // 
            this.saveWavButton.Location = new System.Drawing.Point(152, 61);
            this.saveWavButton.Name = "saveWavButton";
            this.saveWavButton.Size = new System.Drawing.Size(75, 23);
            this.saveWavButton.TabIndex = 7;
            this.saveWavButton.Text = "Save";
            this.saveWavButton.UseVisualStyleBackColor = true;
            this.saveWavButton.Click += new System.EventHandler(this.saveWavButton_Click);
            // 
            // wavPathTextBox
            // 
            this.wavPathTextBox.Location = new System.Drawing.Point(7, 6);
            this.wavPathTextBox.Name = "wavPathTextBox";
            this.wavPathTextBox.Size = new System.Drawing.Size(221, 20);
            this.wavPathTextBox.TabIndex = 5;
            // 
            // loadWavButton
            // 
            this.loadWavButton.Location = new System.Drawing.Point(152, 32);
            this.loadWavButton.Name = "loadWavButton";
            this.loadWavButton.Size = new System.Drawing.Size(75, 23);
            this.loadWavButton.TabIndex = 4;
            this.loadWavButton.Text = "Load";
            this.loadWavButton.UseVisualStyleBackColor = true;
            this.loadWavButton.Click += new System.EventHandler(this.loadWavButton_Click);
            // 
            // openWavButton
            // 
            this.openWavButton.Location = new System.Drawing.Point(71, 32);
            this.openWavButton.Name = "openWavButton";
            this.openWavButton.Size = new System.Drawing.Size(75, 23);
            this.openWavButton.TabIndex = 3;
            this.openWavButton.Text = "Open";
            this.openWavButton.UseVisualStyleBackColor = true;
            this.openWavButton.Click += new System.EventHandler(this.openWavButton_Click);
            // 
            // DtmfTab
            // 
            this.DtmfTab.Controls.Add(this.addNumberButton);
            this.DtmfTab.Controls.Add(this.numberLabel);
            this.DtmfTab.Controls.Add(this.numberTextBox);
            this.DtmfTab.Location = new System.Drawing.Point(4, 22);
            this.DtmfTab.Name = "DtmfTab";
            this.DtmfTab.Padding = new System.Windows.Forms.Padding(3);
            this.DtmfTab.Size = new System.Drawing.Size(234, 227);
            this.DtmfTab.TabIndex = 3;
            this.DtmfTab.Text = "DTMF";
            this.DtmfTab.UseVisualStyleBackColor = true;
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(152, 45);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 2;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(6, 3);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(6, 19);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(221, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "dt";
            // 
            // dtDatTextBox
            // 
            this.dtDatTextBox.Location = new System.Drawing.Point(28, 32);
            this.dtDatTextBox.Name = "dtDatTextBox";
            this.dtDatTextBox.Size = new System.Drawing.Size(119, 20);
            this.dtDatTextBox.TabIndex = 10;
            this.dtDatTextBox.Text = "0.002";
            // 
            // GraphEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 268);
            this.Controls.Add(this.tabControl1);
            this.Name = "GraphEditor";
            this.Text = "Graph editor";
            this.tabControl1.ResumeLayout(false);
            this.trendTabPage.ResumeLayout(false);
            this.trendTabPage.PerformLayout();
            this.loadFileTabPage.ResumeLayout(false);
            this.loadFileTabPage.PerformLayout();
            this.wavTab.ResumeLayout(false);
            this.wavTab.PerformLayout();
            this.DtmfTab.ResumeLayout(false);
            this.DtmfTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_graphType;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_minX;
        private System.Windows.Forms.TextBox tb_minX;
        private System.Windows.Forms.TextBox tb_maxX;
        private System.Windows.Forms.Label lbl_maxX;
        private System.Windows.Forms.TextBox tb_delta;
        private System.Windows.Forms.Label lbl_delta;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button setNButton;
        private System.Windows.Forms.TextBox nTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage trendTabPage;
        private System.Windows.Forms.TabPage loadFileTabPage;
        private System.Windows.Forms.TextBox datFilePathTextBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TabPage wavTab;
        private System.Windows.Forms.TextBox wavPathTextBox;
        private System.Windows.Forms.Button loadWavButton;
        private System.Windows.Forms.Button openWavButton;
        private System.Windows.Forms.Button saveWavButton;
        private System.Windows.Forms.TabPage DtmfTab;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox sampleRateTextBox;
        private System.Windows.Forms.Button sampleRateButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TextBox dtDatTextBox;
        private System.Windows.Forms.Label label1;
    }
}