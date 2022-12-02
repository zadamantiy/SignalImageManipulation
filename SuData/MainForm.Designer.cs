namespace SuData
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zg_4 = new ZedGraph.ZedGraphControl();
            this.zg_2 = new ZedGraph.ZedGraphControl();
            this.zg_3 = new ZedGraph.ZedGraphControl();
            this.zg_1 = new ZedGraph.ZedGraphControl();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.graphGroupBox = new System.Windows.Forms.GroupBox();
            this.graphList = new System.Windows.Forms.ListBox();
            this.panelSelection = new System.Windows.Forms.Panel();
            this.pasteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.resetViewButton = new System.Windows.Forms.Button();
            this.manipulateButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.imageTabPage = new System.Windows.Forms.TabPage();
            this.checkBoxForceColorChange = new System.Windows.Forms.CheckBox();
            this.buttonResetImage = new System.Windows.Forms.Button();
            this.labelZoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpDownColorDepth = new System.Windows.Forms.NumericUpDown();
            this.editImageButton = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.openImageButton = new System.Windows.Forms.Button();
            this.graphTabPage = new System.Windows.Forms.TabPage();
            this.reOpenButton = new System.Windows.Forms.Button();
            this.graphGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.imageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownColorDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.graphTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // zg_4
            // 
            this.zg_4.Location = new System.Drawing.Point(398, 225);
            this.zg_4.Name = "zg_4";
            this.zg_4.ScrollGrace = 0D;
            this.zg_4.ScrollMaxX = 0D;
            this.zg_4.ScrollMaxY = 0D;
            this.zg_4.ScrollMaxY2 = 0D;
            this.zg_4.ScrollMinX = 0D;
            this.zg_4.ScrollMinY = 0D;
            this.zg_4.ScrollMinY2 = 0D;
            this.zg_4.Size = new System.Drawing.Size(383, 210);
            this.zg_4.TabIndex = 7;
            this.zg_4.UseExtendedPrintDialog = true;
            this.zg_4.Paint += new System.Windows.Forms.PaintEventHandler(this.zg_4_Paint);
            this.zg_4.DoubleClick += new System.EventHandler(this.zg_4_DoubleClick);
            this.zg_4.Enter += new System.EventHandler(this.zg_4_Enter);
            // 
            // zg_2
            // 
            this.zg_2.Location = new System.Drawing.Point(398, 9);
            this.zg_2.Name = "zg_2";
            this.zg_2.ScrollGrace = 0D;
            this.zg_2.ScrollMaxX = 0D;
            this.zg_2.ScrollMaxY = 0D;
            this.zg_2.ScrollMaxY2 = 0D;
            this.zg_2.ScrollMinX = 0D;
            this.zg_2.ScrollMinY = 0D;
            this.zg_2.ScrollMinY2 = 0D;
            this.zg_2.Size = new System.Drawing.Size(383, 210);
            this.zg_2.TabIndex = 5;
            this.zg_2.UseExtendedPrintDialog = true;
            this.zg_2.Paint += new System.Windows.Forms.PaintEventHandler(this.zg_2_Paint);
            this.zg_2.DoubleClick += new System.EventHandler(this.zg_2_DoubleClick);
            this.zg_2.Enter += new System.EventHandler(this.zg_2_Enter);
            // 
            // zg_3
            // 
            this.zg_3.Location = new System.Drawing.Point(9, 225);
            this.zg_3.Name = "zg_3";
            this.zg_3.ScrollGrace = 0D;
            this.zg_3.ScrollMaxX = 0D;
            this.zg_3.ScrollMaxY = 0D;
            this.zg_3.ScrollMaxY2 = 0D;
            this.zg_3.ScrollMinX = 0D;
            this.zg_3.ScrollMinY = 0D;
            this.zg_3.ScrollMinY2 = 0D;
            this.zg_3.Size = new System.Drawing.Size(383, 210);
            this.zg_3.TabIndex = 6;
            this.zg_3.UseExtendedPrintDialog = true;
            this.zg_3.Paint += new System.Windows.Forms.PaintEventHandler(this.zg_3_Paint);
            this.zg_3.DoubleClick += new System.EventHandler(this.zg_3_DoubleClick);
            this.zg_3.Enter += new System.EventHandler(this.zg_3_Enter);
            // 
            // zg_1
            // 
            this.zg_1.BackColor = System.Drawing.SystemColors.Control;
            this.zg_1.Location = new System.Drawing.Point(9, 9);
            this.zg_1.Name = "zg_1";
            this.zg_1.ScrollGrace = 0D;
            this.zg_1.ScrollMaxX = 0D;
            this.zg_1.ScrollMaxY = 0D;
            this.zg_1.ScrollMaxY2 = 0D;
            this.zg_1.ScrollMinX = 0D;
            this.zg_1.ScrollMinY = 0D;
            this.zg_1.ScrollMinY2 = 0D;
            this.zg_1.Size = new System.Drawing.Size(383, 210);
            this.zg_1.TabIndex = 4;
            this.zg_1.UseExtendedPrintDialog = true;
            this.zg_1.Paint += new System.Windows.Forms.PaintEventHandler(this.zg_1_Paint);
            this.zg_1.DoubleClick += new System.EventHandler(this.zg_1_DoubleClick);
            this.zg_1.Enter += new System.EventHandler(this.zg_1_Enter);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.analyzeButton.Location = new System.Drawing.Point(1022, 458);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 8;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(941, 458);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // graphGroupBox
            // 
            this.graphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphGroupBox.Controls.Add(this.graphList);
            this.graphGroupBox.Location = new System.Drawing.Point(817, 12);
            this.graphGroupBox.Name = "graphGroupBox";
            this.graphGroupBox.Size = new System.Drawing.Size(280, 412);
            this.graphGroupBox.TabIndex = 10;
            this.graphGroupBox.TabStop = false;
            this.graphGroupBox.Text = "Graphs";
            // 
            // graphList
            // 
            this.graphList.FormattingEnabled = true;
            this.graphList.Location = new System.Drawing.Point(6, 19);
            this.graphList.Name = "graphList";
            this.graphList.Size = new System.Drawing.Size(268, 342);
            this.graphList.TabIndex = 0;
            // 
            // panelSelection
            // 
            this.panelSelection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSelection.Location = new System.Drawing.Point(6, 6);
            this.panelSelection.Name = "panelSelection";
            this.panelSelection.Size = new System.Drawing.Size(389, 216);
            this.panelSelection.TabIndex = 11;
            // 
            // pasteButton
            // 
            this.pasteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pasteButton.Location = new System.Drawing.Point(1022, 430);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(75, 23);
            this.pasteButton.TabIndex = 12;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(941, 430);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // resetViewButton
            // 
            this.resetViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetViewButton.Location = new System.Drawing.Point(860, 430);
            this.resetViewButton.Name = "resetViewButton";
            this.resetViewButton.Size = new System.Drawing.Size(75, 23);
            this.resetViewButton.TabIndex = 14;
            this.resetViewButton.Text = "Reset View";
            this.resetViewButton.UseVisualStyleBackColor = true;
            this.resetViewButton.Click += new System.EventHandler(this.resetViewButton_Click);
            // 
            // manipulateButton
            // 
            this.manipulateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manipulateButton.Location = new System.Drawing.Point(860, 458);
            this.manipulateButton.Name = "manipulateButton";
            this.manipulateButton.Size = new System.Drawing.Size(75, 23);
            this.manipulateButton.TabIndex = 15;
            this.manipulateButton.Text = "Manipulate";
            this.manipulateButton.UseVisualStyleBackColor = true;
            this.manipulateButton.Click += new System.EventHandler(this.manipulateButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.imageTabPage);
            this.tabControl.Controls.Add(this.graphTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 471);
            this.tabControl.TabIndex = 16;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // imageTabPage
            // 
            this.imageTabPage.Controls.Add(this.reOpenButton);
            this.imageTabPage.Controls.Add(this.checkBoxForceColorChange);
            this.imageTabPage.Controls.Add(this.buttonResetImage);
            this.imageTabPage.Controls.Add(this.labelZoom);
            this.imageTabPage.Controls.Add(this.label1);
            this.imageTabPage.Controls.Add(this.nUpDownColorDepth);
            this.imageTabPage.Controls.Add(this.editImageButton);
            this.imageTabPage.Controls.Add(this.picBox);
            this.imageTabPage.Controls.Add(this.saveImageButton);
            this.imageTabPage.Controls.Add(this.openImageButton);
            this.imageTabPage.Location = new System.Drawing.Point(4, 22);
            this.imageTabPage.Name = "imageTabPage";
            this.imageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.imageTabPage.Size = new System.Drawing.Size(790, 445);
            this.imageTabPage.TabIndex = 1;
            this.imageTabPage.Text = "Image";
            this.imageTabPage.UseVisualStyleBackColor = true;
            // 
            // checkBoxForceColorChange
            // 
            this.checkBoxForceColorChange.AutoSize = true;
            this.checkBoxForceColorChange.Location = new System.Drawing.Point(437, 9);
            this.checkBoxForceColorChange.Name = "checkBoxForceColorChange";
            this.checkBoxForceColorChange.Size = new System.Drawing.Size(118, 17);
            this.checkBoxForceColorChange.TabIndex = 9;
            this.checkBoxForceColorChange.Text = "Force color change";
            this.checkBoxForceColorChange.UseVisualStyleBackColor = true;
            this.checkBoxForceColorChange.CheckedChanged += new System.EventHandler(this.checkBoxForceColorChange_CheckedChanged);
            // 
            // buttonResetImage
            // 
            this.buttonResetImage.Location = new System.Drawing.Point(356, 6);
            this.buttonResetImage.Name = "buttonResetImage";
            this.buttonResetImage.Size = new System.Drawing.Size(75, 23);
            this.buttonResetImage.TabIndex = 8;
            this.buttonResetImage.Text = "Reset";
            this.buttonResetImage.UseVisualStyleBackColor = true;
            this.buttonResetImage.Click += new System.EventHandler(this.buttonResetImage_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(284, 11);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(66, 13);
            this.labelZoom.TabIndex = 7;
            this.labelZoom.Text = "Zoom: 100%";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color Depth";
            // 
            // nUpDownColorDepth
            // 
            this.nUpDownColorDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUpDownColorDepth.Location = new System.Drawing.Point(630, 9);
            this.nUpDownColorDepth.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpDownColorDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownColorDepth.Name = "nUpDownColorDepth";
            this.nUpDownColorDepth.Size = new System.Drawing.Size(73, 20);
            this.nUpDownColorDepth.TabIndex = 5;
            this.nUpDownColorDepth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUpDownColorDepth.ValueChanged += new System.EventHandler(this.nUpDownColorDepth_ValueChanged);
            // 
            // editImageButton
            // 
            this.editImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editImageButton.Location = new System.Drawing.Point(709, 6);
            this.editImageButton.Name = "editImageButton";
            this.editImageButton.Size = new System.Drawing.Size(75, 23);
            this.editImageButton.TabIndex = 4;
            this.editImageButton.Text = "Edit";
            this.editImageButton.UseVisualStyleBackColor = true;
            this.editImageButton.Click += new System.EventHandler(this.editImageButton_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.Gray;
            this.picBox.Location = new System.Drawing.Point(6, 35);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(778, 404);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(168, 6);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(75, 23);
            this.saveImageButton.TabIndex = 2;
            this.saveImageButton.Text = "Save";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(6, 6);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(75, 23);
            this.openImageButton.TabIndex = 1;
            this.openImageButton.Text = "Open";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // graphTabPage
            // 
            this.graphTabPage.Controls.Add(this.zg_1);
            this.graphTabPage.Controls.Add(this.zg_3);
            this.graphTabPage.Controls.Add(this.zg_2);
            this.graphTabPage.Controls.Add(this.zg_4);
            this.graphTabPage.Controls.Add(this.panelSelection);
            this.graphTabPage.Location = new System.Drawing.Point(4, 22);
            this.graphTabPage.Name = "graphTabPage";
            this.graphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphTabPage.Size = new System.Drawing.Size(790, 445);
            this.graphTabPage.TabIndex = 0;
            this.graphTabPage.Text = "Graphs";
            this.graphTabPage.UseVisualStyleBackColor = true;
            // 
            // reOpenButton
            // 
            this.reOpenButton.Location = new System.Drawing.Point(87, 6);
            this.reOpenButton.Name = "reOpenButton";
            this.reOpenButton.Size = new System.Drawing.Size(75, 23);
            this.reOpenButton.TabIndex = 10;
            this.reOpenButton.Text = "Reopen";
            this.reOpenButton.UseVisualStyleBackColor = true;
            this.reOpenButton.Click += new System.EventHandler(this.reOpenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 493);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.manipulateButton);
            this.Controls.Add(this.resetViewButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.graphGroupBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.analyzeButton);
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.MinimumSize = new System.Drawing.Size(1100, 489);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.graphGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.imageTabPage.ResumeLayout(false);
            this.imageTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownColorDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.graphTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zg_4;
        private ZedGraph.ZedGraphControl zg_2;
        private ZedGraph.ZedGraphControl zg_3;
        private ZedGraph.ZedGraphControl zg_1;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox graphGroupBox;
        private System.Windows.Forms.ListBox graphList;
        private System.Windows.Forms.Panel panelSelection;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button resetViewButton;
        private System.Windows.Forms.Button manipulateButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage graphTabPage;
        private System.Windows.Forms.TabPage imageTabPage;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button editImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUpDownColorDepth;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Button buttonResetImage;
        public System.Windows.Forms.CheckBox checkBoxForceColorChange;
        private System.Windows.Forms.Button reOpenButton;
    }
}

