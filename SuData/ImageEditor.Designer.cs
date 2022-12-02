namespace SuData
{
    partial class ImageEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.shiftButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spectreResizeTextBox = new System.Windows.Forms.TextBox();
            this.multiplySpectreButton = new System.Windows.Forms.Button();
            this.divideBilinearInterpolationButton = new System.Windows.Forms.Button();
            this.divideNearestNeighbourButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bilinearInterpolationTextBox = new System.Windows.Forms.TextBox();
            this.multiplyBilinearInterpolationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nearestNeighbourMultiplier = new System.Windows.Forms.TextBox();
            this.multiplyNearestNeighbourButton = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonRotate180 = new System.Windows.Forms.Button();
            this.buttonSubtractImage = new System.Windows.Forms.Button();
            this.buttonApplyNegative = new System.Windows.Forms.Button();
            this.buttonConvertToImage = new System.Windows.Forms.Button();
            this.buttonApplyLogarithm = new System.Windows.Forms.Button();
            this.checkBoxInverseLog = new System.Windows.Forms.CheckBox();
            this.buttonApplyPower = new System.Windows.Forms.Button();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.buttonGetHistogram = new System.Windows.Forms.Button();
            this.buttonEqualize = new System.Windows.Forms.Button();
            this.buttonEnforce = new System.Windows.Forms.Button();
            this.buttonApplyCopied = new System.Windows.Forms.Button();
            this.buttonAddSaltAndPepper = new System.Windows.Forms.Button();
            this.textBoxNoisePercent = new System.Windows.Forms.TextBox();
            this.buttonAddRandomNoise = new System.Windows.Forms.Button();
            this.buttonAverageFilter = new System.Windows.Forms.Button();
            this.textBoxAverageFilterWindowSize = new System.Windows.Forms.TextBox();
            this.textBoxMedianFilterWindowSize = new System.Windows.Forms.TextBox();
            this.buttonMedianFilter = new System.Windows.Forms.Button();
            this.buttonGetLine = new System.Windows.Forms.Button();
            this.textBoxLineNumber = new System.Windows.Forms.TextBox();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.button2DSpec = new System.Windows.Forms.Button();
            this.buttonDeconvolution = new System.Windows.Forms.Button();
            this.textBoxDeconvolutionAlpha = new System.Windows.Forms.TextBox();
            this.buttonBothNoise = new System.Windows.Forms.Button();
            this.potterGroupBox = new System.Windows.Forms.GroupBox();
            this.potterType = new System.Windows.Forms.Label();
            this.filterNameComboBox = new System.Windows.Forms.ComboBox();
            this.fc2TextBox = new System.Windows.Forms.TextBox();
            this.fc2Label = new System.Windows.Forms.Label();
            this.applyPotterButton = new System.Windows.Forms.Button();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.fcTextBox = new System.Windows.Forms.TextBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.fcLabel = new System.Windows.Forms.Label();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.thresholdGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonApplyThreshold = new System.Windows.Forms.Button();
            this.buttonGradient = new System.Windows.Forms.Button();
            this.buttonLaplace = new System.Windows.Forms.Button();
            this.groupBoxDilatation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDilatationColor = new System.Windows.Forms.TextBox();
            this.dilaYLabel = new System.Windows.Forms.Label();
            this.dilaXLabel = new System.Windows.Forms.Label();
            this.textBoxDilatationHeight = new System.Windows.Forms.TextBox();
            this.buttonDilatationApply = new System.Windows.Forms.Button();
            this.textBoxDilatationWidth = new System.Windows.Forms.TextBox();
            this.groupBoxErosion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxErosionColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxErosionHeight = new System.Windows.Forms.TextBox();
            this.buttonErosionApply = new System.Windows.Forms.Button();
            this.textBoxErosionWidth = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.checkBoxLessThanMax = new System.Windows.Forms.CheckBox();
            this.buttonAutoShift = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.potterGroupBox.SuspendLayout();
            this.thresholdGroupBox.SuspendLayout();
            this.groupBoxDilatation.SuspendLayout();
            this.groupBoxErosion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shiftTextBox);
            this.groupBox1.Controls.Add(this.shiftButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Shift";
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.Location = new System.Drawing.Point(6, 19);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(100, 20);
            this.shiftTextBox.TabIndex = 1;
            this.shiftTextBox.Text = "0";
            // 
            // shiftButton
            // 
            this.shiftButton.Location = new System.Drawing.Point(112, 17);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(75, 23);
            this.shiftButton.TabIndex = 0;
            this.shiftButton.Text = "Shift";
            this.shiftButton.UseVisualStyleBackColor = true;
            this.shiftButton.Click += new System.EventHandler(this.shiftButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.spectreResizeTextBox);
            this.groupBox2.Controls.Add(this.multiplySpectreButton);
            this.groupBox2.Controls.Add(this.divideBilinearInterpolationButton);
            this.groupBox2.Controls.Add(this.divideNearestNeighbourButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bilinearInterpolationTextBox);
            this.groupBox2.Controls.Add(this.multiplyBilinearInterpolationButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nearestNeighbourMultiplier);
            this.groupBox2.Controls.Add(this.multiplyNearestNeighbourButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Spectre";
            // 
            // spectreResizeTextBox
            // 
            this.spectreResizeTextBox.Location = new System.Drawing.Point(6, 200);
            this.spectreResizeTextBox.Name = "spectreResizeTextBox";
            this.spectreResizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.spectreResizeTextBox.TabIndex = 9;
            this.spectreResizeTextBox.Text = "0";
            // 
            // multiplySpectreButton
            // 
            this.multiplySpectreButton.Location = new System.Drawing.Point(112, 198);
            this.multiplySpectreButton.Name = "multiplySpectreButton";
            this.multiplySpectreButton.Size = new System.Drawing.Size(75, 23);
            this.multiplySpectreButton.TabIndex = 8;
            this.multiplySpectreButton.Text = "Multiply";
            this.multiplySpectreButton.UseVisualStyleBackColor = true;
            this.multiplySpectreButton.Click += new System.EventHandler(this.multiplySpectreButton_Click);
            // 
            // divideBilinearInterpolationButton
            // 
            this.divideBilinearInterpolationButton.Location = new System.Drawing.Point(111, 143);
            this.divideBilinearInterpolationButton.Name = "divideBilinearInterpolationButton";
            this.divideBilinearInterpolationButton.Size = new System.Drawing.Size(75, 23);
            this.divideBilinearInterpolationButton.TabIndex = 7;
            this.divideBilinearInterpolationButton.Text = "Divide";
            this.divideBilinearInterpolationButton.UseVisualStyleBackColor = true;
            this.divideBilinearInterpolationButton.Click += new System.EventHandler(this.divideBilinearInterpolationButton_Click);
            // 
            // divideNearestNeighbourButton
            // 
            this.divideNearestNeighbourButton.Location = new System.Drawing.Point(111, 59);
            this.divideNearestNeighbourButton.Name = "divideNearestNeighbourButton";
            this.divideNearestNeighbourButton.Size = new System.Drawing.Size(75, 23);
            this.divideNearestNeighbourButton.TabIndex = 6;
            this.divideNearestNeighbourButton.Text = "Divide";
            this.divideNearestNeighbourButton.UseVisualStyleBackColor = true;
            this.divideNearestNeighbourButton.Click += new System.EventHandler(this.divideNearestNeighbourButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bilinear Interpolation";
            // 
            // bilinearInterpolationTextBox
            // 
            this.bilinearInterpolationTextBox.Location = new System.Drawing.Point(6, 116);
            this.bilinearInterpolationTextBox.Name = "bilinearInterpolationTextBox";
            this.bilinearInterpolationTextBox.Size = new System.Drawing.Size(100, 20);
            this.bilinearInterpolationTextBox.TabIndex = 4;
            this.bilinearInterpolationTextBox.Text = "0";
            // 
            // multiplyBilinearInterpolationButton
            // 
            this.multiplyBilinearInterpolationButton.Location = new System.Drawing.Point(112, 114);
            this.multiplyBilinearInterpolationButton.Name = "multiplyBilinearInterpolationButton";
            this.multiplyBilinearInterpolationButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyBilinearInterpolationButton.TabIndex = 3;
            this.multiplyBilinearInterpolationButton.Text = "Multiply";
            this.multiplyBilinearInterpolationButton.UseVisualStyleBackColor = true;
            this.multiplyBilinearInterpolationButton.Click += new System.EventHandler(this.multiplyBilinearInterpolationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nearest Neigbour";
            // 
            // nearestNeighbourMultiplier
            // 
            this.nearestNeighbourMultiplier.Location = new System.Drawing.Point(6, 32);
            this.nearestNeighbourMultiplier.Name = "nearestNeighbourMultiplier";
            this.nearestNeighbourMultiplier.Size = new System.Drawing.Size(100, 20);
            this.nearestNeighbourMultiplier.TabIndex = 1;
            this.nearestNeighbourMultiplier.Text = "0";
            // 
            // multiplyNearestNeighbourButton
            // 
            this.multiplyNearestNeighbourButton.Location = new System.Drawing.Point(112, 30);
            this.multiplyNearestNeighbourButton.Name = "multiplyNearestNeighbourButton";
            this.multiplyNearestNeighbourButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyNearestNeighbourButton.TabIndex = 0;
            this.multiplyNearestNeighbourButton.Text = "Multiply";
            this.multiplyNearestNeighbourButton.UseVisualStyleBackColor = true;
            this.multiplyNearestNeighbourButton.Click += new System.EventHandler(this.multiplyNearestNeighbourButton_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Location = new System.Drawing.Point(210, 87);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateRight.TabIndex = 3;
            this.buttonRotateRight.Text = "Rotate Right";
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Location = new System.Drawing.Point(210, 29);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateLeft.TabIndex = 4;
            this.buttonRotateLeft.Text = "Rotate Left";
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // buttonRotate180
            // 
            this.buttonRotate180.Location = new System.Drawing.Point(210, 58);
            this.buttonRotate180.Name = "buttonRotate180";
            this.buttonRotate180.Size = new System.Drawing.Size(75, 23);
            this.buttonRotate180.TabIndex = 5;
            this.buttonRotate180.Text = "Rotate 180°";
            this.buttonRotate180.UseVisualStyleBackColor = true;
            this.buttonRotate180.Click += new System.EventHandler(this.buttonRotate180_Click);
            // 
            // buttonSubtractImage
            // 
            this.buttonSubtractImage.Location = new System.Drawing.Point(210, 116);
            this.buttonSubtractImage.Name = "buttonSubtractImage";
            this.buttonSubtractImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtractImage.TabIndex = 6;
            this.buttonSubtractImage.Text = "Subtract Image";
            this.buttonSubtractImage.UseVisualStyleBackColor = true;
            this.buttonSubtractImage.Click += new System.EventHandler(this.buttonSubtractImage_Click);
            // 
            // buttonApplyNegative
            // 
            this.buttonApplyNegative.Location = new System.Drawing.Point(123, 325);
            this.buttonApplyNegative.Name = "buttonApplyNegative";
            this.buttonApplyNegative.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyNegative.TabIndex = 7;
            this.buttonApplyNegative.Text = "Negative";
            this.buttonApplyNegative.UseVisualStyleBackColor = true;
            this.buttonApplyNegative.Click += new System.EventHandler(this.buttonApplyNegative_Click);
            // 
            // buttonConvertToImage
            // 
            this.buttonConvertToImage.Location = new System.Drawing.Point(687, 28);
            this.buttonConvertToImage.Name = "buttonConvertToImage";
            this.buttonConvertToImage.Size = new System.Drawing.Size(101, 23);
            this.buttonConvertToImage.TabIndex = 8;
            this.buttonConvertToImage.Text = "Convert To Image";
            this.buttonConvertToImage.UseVisualStyleBackColor = true;
            this.buttonConvertToImage.Click += new System.EventHandler(this.buttonConvertToImage_Click);
            // 
            // buttonApplyLogarithm
            // 
            this.buttonApplyLogarithm.Location = new System.Drawing.Point(123, 354);
            this.buttonApplyLogarithm.Name = "buttonApplyLogarithm";
            this.buttonApplyLogarithm.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyLogarithm.TabIndex = 9;
            this.buttonApplyLogarithm.Text = "Logarithm";
            this.buttonApplyLogarithm.UseVisualStyleBackColor = true;
            this.buttonApplyLogarithm.Click += new System.EventHandler(this.buttonApplyLogarithm_Click);
            // 
            // checkBoxInverseLog
            // 
            this.checkBoxInverseLog.AutoSize = true;
            this.checkBoxInverseLog.Location = new System.Drawing.Point(56, 358);
            this.checkBoxInverseLog.Name = "checkBoxInverseLog";
            this.checkBoxInverseLog.Size = new System.Drawing.Size(61, 17);
            this.checkBoxInverseLog.TabIndex = 10;
            this.checkBoxInverseLog.Text = "Inverse";
            this.checkBoxInverseLog.UseVisualStyleBackColor = true;
            // 
            // buttonApplyPower
            // 
            this.buttonApplyPower.Location = new System.Drawing.Point(123, 383);
            this.buttonApplyPower.Name = "buttonApplyPower";
            this.buttonApplyPower.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyPower.TabIndex = 11;
            this.buttonApplyPower.Text = "Power";
            this.buttonApplyPower.UseVisualStyleBackColor = true;
            this.buttonApplyPower.Click += new System.EventHandler(this.buttonApplyPower_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(17, 385);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGamma.TabIndex = 12;
            this.textBoxGamma.Text = "1.00";
            // 
            // buttonGetHistogram
            // 
            this.buttonGetHistogram.Location = new System.Drawing.Point(713, 415);
            this.buttonGetHistogram.Name = "buttonGetHistogram";
            this.buttonGetHistogram.Size = new System.Drawing.Size(75, 23);
            this.buttonGetHistogram.TabIndex = 13;
            this.buttonGetHistogram.Text = "Histogram";
            this.buttonGetHistogram.UseVisualStyleBackColor = true;
            this.buttonGetHistogram.Click += new System.EventHandler(this.buttonGetHistogram_Click);
            // 
            // buttonEqualize
            // 
            this.buttonEqualize.Location = new System.Drawing.Point(123, 412);
            this.buttonEqualize.Name = "buttonEqualize";
            this.buttonEqualize.Size = new System.Drawing.Size(75, 23);
            this.buttonEqualize.TabIndex = 14;
            this.buttonEqualize.Text = "Equalize";
            this.buttonEqualize.UseVisualStyleBackColor = true;
            this.buttonEqualize.Click += new System.EventHandler(this.buttonEqualize_Click);
            // 
            // buttonEnforce
            // 
            this.buttonEnforce.Enabled = false;
            this.buttonEnforce.Location = new System.Drawing.Point(204, 412);
            this.buttonEnforce.Name = "buttonEnforce";
            this.buttonEnforce.Size = new System.Drawing.Size(75, 23);
            this.buttonEnforce.TabIndex = 15;
            this.buttonEnforce.Text = "Enforce";
            this.buttonEnforce.UseVisualStyleBackColor = true;
            this.buttonEnforce.Click += new System.EventHandler(this.buttonEnforce_Click);
            // 
            // buttonApplyCopied
            // 
            this.buttonApplyCopied.Enabled = false;
            this.buttonApplyCopied.Location = new System.Drawing.Point(285, 412);
            this.buttonApplyCopied.Name = "buttonApplyCopied";
            this.buttonApplyCopied.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyCopied.TabIndex = 16;
            this.buttonApplyCopied.Text = "Copied one";
            this.buttonApplyCopied.UseVisualStyleBackColor = true;
            this.buttonApplyCopied.Click += new System.EventHandler(this.buttonApplyCopied_Click);
            // 
            // buttonAddSaltAndPepper
            // 
            this.buttonAddSaltAndPepper.Location = new System.Drawing.Point(457, 28);
            this.buttonAddSaltAndPepper.Name = "buttonAddSaltAndPepper";
            this.buttonAddSaltAndPepper.Size = new System.Drawing.Size(84, 23);
            this.buttonAddSaltAndPepper.TabIndex = 17;
            this.buttonAddSaltAndPepper.Text = "Add S&&P";
            this.buttonAddSaltAndPepper.UseVisualStyleBackColor = true;
            this.buttonAddSaltAndPepper.Click += new System.EventHandler(this.buttonAddSaltAndPepper_Click);
            // 
            // textBoxNoisePercent
            // 
            this.textBoxNoisePercent.Location = new System.Drawing.Point(351, 30);
            this.textBoxNoisePercent.Name = "textBoxNoisePercent";
            this.textBoxNoisePercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoisePercent.TabIndex = 18;
            this.textBoxNoisePercent.Text = "15";
            // 
            // buttonAddRandomNoise
            // 
            this.buttonAddRandomNoise.Location = new System.Drawing.Point(547, 28);
            this.buttonAddRandomNoise.Name = "buttonAddRandomNoise";
            this.buttonAddRandomNoise.Size = new System.Drawing.Size(84, 23);
            this.buttonAddRandomNoise.TabIndex = 19;
            this.buttonAddRandomNoise.Text = "Add Rnd";
            this.buttonAddRandomNoise.UseVisualStyleBackColor = true;
            this.buttonAddRandomNoise.Click += new System.EventHandler(this.buttonAddRandomNoise_Click);
            // 
            // buttonAverageFilter
            // 
            this.buttonAverageFilter.Location = new System.Drawing.Point(457, 87);
            this.buttonAverageFilter.Name = "buttonAverageFilter";
            this.buttonAverageFilter.Size = new System.Drawing.Size(84, 23);
            this.buttonAverageFilter.TabIndex = 21;
            this.buttonAverageFilter.Text = "Average Filter";
            this.buttonAverageFilter.UseVisualStyleBackColor = true;
            this.buttonAverageFilter.Click += new System.EventHandler(this.buttonAverageFilter_Click);
            // 
            // textBoxAverageFilterWindowSize
            // 
            this.textBoxAverageFilterWindowSize.Location = new System.Drawing.Point(351, 89);
            this.textBoxAverageFilterWindowSize.Name = "textBoxAverageFilterWindowSize";
            this.textBoxAverageFilterWindowSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverageFilterWindowSize.TabIndex = 22;
            this.textBoxAverageFilterWindowSize.Text = "5";
            // 
            // textBoxMedianFilterWindowSize
            // 
            this.textBoxMedianFilterWindowSize.Location = new System.Drawing.Point(351, 119);
            this.textBoxMedianFilterWindowSize.Name = "textBoxMedianFilterWindowSize";
            this.textBoxMedianFilterWindowSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedianFilterWindowSize.TabIndex = 24;
            this.textBoxMedianFilterWindowSize.Text = "5";
            // 
            // buttonMedianFilter
            // 
            this.buttonMedianFilter.Location = new System.Drawing.Point(457, 117);
            this.buttonMedianFilter.Name = "buttonMedianFilter";
            this.buttonMedianFilter.Size = new System.Drawing.Size(84, 23);
            this.buttonMedianFilter.TabIndex = 23;
            this.buttonMedianFilter.Text = "Median Filter";
            this.buttonMedianFilter.UseVisualStyleBackColor = true;
            this.buttonMedianFilter.Click += new System.EventHandler(this.buttonMedianFilter_Click);
            // 
            // buttonGetLine
            // 
            this.buttonGetLine.Location = new System.Drawing.Point(457, 180);
            this.buttonGetLine.Name = "buttonGetLine";
            this.buttonGetLine.Size = new System.Drawing.Size(84, 23);
            this.buttonGetLine.TabIndex = 25;
            this.buttonGetLine.Text = "Get Line";
            this.buttonGetLine.UseVisualStyleBackColor = true;
            this.buttonGetLine.Click += new System.EventHandler(this.buttonGetLine_Click);
            // 
            // textBoxLineNumber
            // 
            this.textBoxLineNumber.Location = new System.Drawing.Point(351, 182);
            this.textBoxLineNumber.Name = "textBoxLineNumber";
            this.textBoxLineNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxLineNumber.TabIndex = 26;
            this.textBoxLineNumber.Text = "0";
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Location = new System.Drawing.Point(457, 209);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(84, 23);
            this.buttonApplyFilter.TabIndex = 27;
            this.buttonApplyFilter.Text = "Apply Filter";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // button2DSpec
            // 
            this.button2DSpec.Location = new System.Drawing.Point(457, 252);
            this.button2DSpec.Name = "button2DSpec";
            this.button2DSpec.Size = new System.Drawing.Size(84, 23);
            this.button2DSpec.TabIndex = 28;
            this.button2DSpec.Text = "Get 2D Spec";
            this.button2DSpec.UseVisualStyleBackColor = true;
            this.button2DSpec.Click += new System.EventHandler(this.button2DSpec_Click);
            // 
            // buttonDeconvolution
            // 
            this.buttonDeconvolution.Location = new System.Drawing.Point(457, 281);
            this.buttonDeconvolution.Name = "buttonDeconvolution";
            this.buttonDeconvolution.Size = new System.Drawing.Size(84, 23);
            this.buttonDeconvolution.TabIndex = 29;
            this.buttonDeconvolution.Text = "Deconvolution";
            this.buttonDeconvolution.UseVisualStyleBackColor = true;
            this.buttonDeconvolution.Click += new System.EventHandler(this.buttonDeconvolution_Click);
            // 
            // textBoxDeconvolutionAlpha
            // 
            this.textBoxDeconvolutionAlpha.Location = new System.Drawing.Point(351, 281);
            this.textBoxDeconvolutionAlpha.Name = "textBoxDeconvolutionAlpha";
            this.textBoxDeconvolutionAlpha.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeconvolutionAlpha.TabIndex = 30;
            this.textBoxDeconvolutionAlpha.Text = "0.9";
            // 
            // buttonBothNoise
            // 
            this.buttonBothNoise.Location = new System.Drawing.Point(501, 57);
            this.buttonBothNoise.Name = "buttonBothNoise";
            this.buttonBothNoise.Size = new System.Drawing.Size(84, 23);
            this.buttonBothNoise.TabIndex = 31;
            this.buttonBothNoise.Text = "Add Both";
            this.buttonBothNoise.UseVisualStyleBackColor = true;
            this.buttonBothNoise.Click += new System.EventHandler(this.buttonBothNoise_Click);
            // 
            // potterGroupBox
            // 
            this.potterGroupBox.Controls.Add(this.potterType);
            this.potterGroupBox.Controls.Add(this.filterNameComboBox);
            this.potterGroupBox.Controls.Add(this.fc2TextBox);
            this.potterGroupBox.Controls.Add(this.fc2Label);
            this.potterGroupBox.Controls.Add(this.applyPotterButton);
            this.potterGroupBox.Controls.Add(this.mTextBox);
            this.potterGroupBox.Controls.Add(this.fcTextBox);
            this.potterGroupBox.Controls.Add(this.mLabel);
            this.potterGroupBox.Controls.Add(this.fcLabel);
            this.potterGroupBox.Location = new System.Drawing.Point(379, 353);
            this.potterGroupBox.Name = "potterGroupBox";
            this.potterGroupBox.Size = new System.Drawing.Size(302, 82);
            this.potterGroupBox.TabIndex = 32;
            this.potterGroupBox.TabStop = false;
            this.potterGroupBox.Text = "Potter";
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
            // filterNameComboBox
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
            this.applyPotterButton.Location = new System.Drawing.Point(219, 49);
            this.applyPotterButton.Name = "applyPotterButton";
            this.applyPotterButton.Size = new System.Drawing.Size(75, 23);
            this.applyPotterButton.TabIndex = 20;
            this.applyPotterButton.Text = "Apply Potter";
            this.applyPotterButton.UseVisualStyleBackColor = true;
            this.applyPotterButton.Click += new System.EventHandler(this.applyPotterButton_Click);
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
            // fcLabel
            // 
            this.fcLabel.AutoSize = true;
            this.fcLabel.Location = new System.Drawing.Point(6, 25);
            this.fcLabel.Name = "fcLabel";
            this.fcLabel.Size = new System.Drawing.Size(16, 13);
            this.fcLabel.TabIndex = 11;
            this.fcLabel.Text = "fc";
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(6, 19);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreshold.TabIndex = 33;
            this.textBoxThreshold.Text = "0";
            // 
            // thresholdGroupBox
            // 
            this.thresholdGroupBox.Controls.Add(this.buttonApplyThreshold);
            this.thresholdGroupBox.Controls.Add(this.textBoxThreshold);
            this.thresholdGroupBox.Location = new System.Drawing.Point(596, 86);
            this.thresholdGroupBox.Name = "thresholdGroupBox";
            this.thresholdGroupBox.Size = new System.Drawing.Size(192, 48);
            this.thresholdGroupBox.TabIndex = 2;
            this.thresholdGroupBox.TabStop = false;
            this.thresholdGroupBox.Text = "Threshold";
            // 
            // buttonApplyThreshold
            // 
            this.buttonApplyThreshold.Location = new System.Drawing.Point(112, 17);
            this.buttonApplyThreshold.Name = "buttonApplyThreshold";
            this.buttonApplyThreshold.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyThreshold.TabIndex = 0;
            this.buttonApplyThreshold.Text = "Apply";
            this.buttonApplyThreshold.UseVisualStyleBackColor = true;
            this.buttonApplyThreshold.Click += new System.EventHandler(this.buttonApplyThreshold_Click);
            // 
            // buttonGradient
            // 
            this.buttonGradient.Location = new System.Drawing.Point(632, 57);
            this.buttonGradient.Name = "buttonGradient";
            this.buttonGradient.Size = new System.Drawing.Size(75, 23);
            this.buttonGradient.TabIndex = 33;
            this.buttonGradient.Text = "Gradient";
            this.buttonGradient.UseVisualStyleBackColor = true;
            this.buttonGradient.Click += new System.EventHandler(this.buttonGradient_Click);
            // 
            // buttonLaplace
            // 
            this.buttonLaplace.Location = new System.Drawing.Point(713, 57);
            this.buttonLaplace.Name = "buttonLaplace";
            this.buttonLaplace.Size = new System.Drawing.Size(75, 23);
            this.buttonLaplace.TabIndex = 34;
            this.buttonLaplace.Text = "Laplace";
            this.buttonLaplace.UseVisualStyleBackColor = true;
            this.buttonLaplace.Click += new System.EventHandler(this.buttonLaplace_Click);
            // 
            // groupBoxDilatation
            // 
            this.groupBoxDilatation.Controls.Add(this.label4);
            this.groupBoxDilatation.Controls.Add(this.textBoxDilatationColor);
            this.groupBoxDilatation.Controls.Add(this.dilaYLabel);
            this.groupBoxDilatation.Controls.Add(this.dilaXLabel);
            this.groupBoxDilatation.Controls.Add(this.textBoxDilatationHeight);
            this.groupBoxDilatation.Controls.Add(this.buttonDilatationApply);
            this.groupBoxDilatation.Controls.Add(this.textBoxDilatationWidth);
            this.groupBoxDilatation.Location = new System.Drawing.Point(596, 140);
            this.groupBoxDilatation.Name = "groupBoxDilatation";
            this.groupBoxDilatation.Size = new System.Drawing.Size(192, 96);
            this.groupBoxDilatation.TabIndex = 34;
            this.groupBoxDilatation.TabStop = false;
            this.groupBoxDilatation.Text = "Dilatation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Clr";
            // 
            // textBoxDilatationColor
            // 
            this.textBoxDilatationColor.Location = new System.Drawing.Point(28, 69);
            this.textBoxDilatationColor.Name = "textBoxDilatationColor";
            this.textBoxDilatationColor.Size = new System.Drawing.Size(78, 20);
            this.textBoxDilatationColor.TabIndex = 37;
            this.textBoxDilatationColor.Text = "255";
            // 
            // dilaYLabel
            // 
            this.dilaYLabel.AutoSize = true;
            this.dilaYLabel.Location = new System.Drawing.Point(8, 48);
            this.dilaYLabel.Name = "dilaYLabel";
            this.dilaYLabel.Size = new System.Drawing.Size(14, 13);
            this.dilaYLabel.TabIndex = 36;
            this.dilaYLabel.Text = "Y";
            // 
            // dilaXLabel
            // 
            this.dilaXLabel.AutoSize = true;
            this.dilaXLabel.Location = new System.Drawing.Point(8, 22);
            this.dilaXLabel.Name = "dilaXLabel";
            this.dilaXLabel.Size = new System.Drawing.Size(14, 13);
            this.dilaXLabel.TabIndex = 35;
            this.dilaXLabel.Text = "X";
            // 
            // textBoxDilatationHeight
            // 
            this.textBoxDilatationHeight.Location = new System.Drawing.Point(28, 45);
            this.textBoxDilatationHeight.Name = "textBoxDilatationHeight";
            this.textBoxDilatationHeight.Size = new System.Drawing.Size(78, 20);
            this.textBoxDilatationHeight.TabIndex = 34;
            this.textBoxDilatationHeight.Text = "3";
            // 
            // buttonDilatationApply
            // 
            this.buttonDilatationApply.Location = new System.Drawing.Point(111, 67);
            this.buttonDilatationApply.Name = "buttonDilatationApply";
            this.buttonDilatationApply.Size = new System.Drawing.Size(75, 23);
            this.buttonDilatationApply.TabIndex = 0;
            this.buttonDilatationApply.Text = "Apply";
            this.buttonDilatationApply.UseVisualStyleBackColor = true;
            this.buttonDilatationApply.Click += new System.EventHandler(this.buttonDilatationApply_Click);
            // 
            // textBoxDilatationWidth
            // 
            this.textBoxDilatationWidth.Location = new System.Drawing.Point(28, 19);
            this.textBoxDilatationWidth.Name = "textBoxDilatationWidth";
            this.textBoxDilatationWidth.Size = new System.Drawing.Size(78, 20);
            this.textBoxDilatationWidth.TabIndex = 33;
            this.textBoxDilatationWidth.Text = "3";
            // 
            // groupBoxErosion
            // 
            this.groupBoxErosion.Controls.Add(this.label5);
            this.groupBoxErosion.Controls.Add(this.textBoxErosionColor);
            this.groupBoxErosion.Controls.Add(this.label6);
            this.groupBoxErosion.Controls.Add(this.label7);
            this.groupBoxErosion.Controls.Add(this.textBoxErosionHeight);
            this.groupBoxErosion.Controls.Add(this.buttonErosionApply);
            this.groupBoxErosion.Controls.Add(this.textBoxErosionWidth);
            this.groupBoxErosion.Location = new System.Drawing.Point(596, 242);
            this.groupBoxErosion.Name = "groupBoxErosion";
            this.groupBoxErosion.Size = new System.Drawing.Size(192, 96);
            this.groupBoxErosion.TabIndex = 39;
            this.groupBoxErosion.TabStop = false;
            this.groupBoxErosion.Text = "Erosion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Clr";
            // 
            // textBoxErosionColor
            // 
            this.textBoxErosionColor.Location = new System.Drawing.Point(28, 69);
            this.textBoxErosionColor.Name = "textBoxErosionColor";
            this.textBoxErosionColor.Size = new System.Drawing.Size(78, 20);
            this.textBoxErosionColor.TabIndex = 37;
            this.textBoxErosionColor.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "X";
            // 
            // textBoxErosionHeight
            // 
            this.textBoxErosionHeight.Location = new System.Drawing.Point(28, 45);
            this.textBoxErosionHeight.Name = "textBoxErosionHeight";
            this.textBoxErosionHeight.Size = new System.Drawing.Size(78, 20);
            this.textBoxErosionHeight.TabIndex = 34;
            this.textBoxErosionHeight.Text = "3";
            // 
            // buttonErosionApply
            // 
            this.buttonErosionApply.Location = new System.Drawing.Point(111, 67);
            this.buttonErosionApply.Name = "buttonErosionApply";
            this.buttonErosionApply.Size = new System.Drawing.Size(75, 23);
            this.buttonErosionApply.TabIndex = 0;
            this.buttonErosionApply.Text = "Apply";
            this.buttonErosionApply.UseVisualStyleBackColor = true;
            this.buttonErosionApply.Click += new System.EventHandler(this.buttonErosionApply_Click);
            // 
            // textBoxErosionWidth
            // 
            this.textBoxErosionWidth.Location = new System.Drawing.Point(28, 19);
            this.textBoxErosionWidth.Name = "textBoxErosionWidth";
            this.textBoxErosionWidth.Size = new System.Drawing.Size(78, 20);
            this.textBoxErosionWidth.TabIndex = 33;
            this.textBoxErosionWidth.Text = "3";
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(210, 145);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 40;
            this.buttonSum.Text = "Sum Image";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // checkBoxLessThanMax
            // 
            this.checkBoxLessThanMax.AutoSize = true;
            this.checkBoxLessThanMax.Location = new System.Drawing.Point(211, 175);
            this.checkBoxLessThanMax.Name = "checkBoxLessThanMax";
            this.checkBoxLessThanMax.Size = new System.Drawing.Size(78, 17);
            this.checkBoxLessThanMax.TabIndex = 41;
            this.checkBoxLessThanMax.Text = "check max";
            this.checkBoxLessThanMax.UseVisualStyleBackColor = true;
            // 
            // buttonAutoShift
            // 
            this.buttonAutoShift.Location = new System.Drawing.Point(250, 239);
            this.buttonAutoShift.Name = "buttonAutoShift";
            this.buttonAutoShift.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoShift.TabIndex = 42;
            this.buttonAutoShift.Text = "AutoShift";
            this.buttonAutoShift.UseVisualStyleBackColor = true;
            this.buttonAutoShift.Click += new System.EventHandler(this.buttonAutoShift_Click);
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAutoShift);
            this.Controls.Add(this.checkBoxLessThanMax);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.groupBoxErosion);
            this.Controls.Add(this.groupBoxDilatation);
            this.Controls.Add(this.buttonLaplace);
            this.Controls.Add(this.buttonGradient);
            this.Controls.Add(this.thresholdGroupBox);
            this.Controls.Add(this.potterGroupBox);
            this.Controls.Add(this.buttonBothNoise);
            this.Controls.Add(this.textBoxDeconvolutionAlpha);
            this.Controls.Add(this.buttonDeconvolution);
            this.Controls.Add(this.button2DSpec);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.textBoxLineNumber);
            this.Controls.Add(this.buttonGetLine);
            this.Controls.Add(this.textBoxMedianFilterWindowSize);
            this.Controls.Add(this.buttonMedianFilter);
            this.Controls.Add(this.textBoxAverageFilterWindowSize);
            this.Controls.Add(this.buttonAverageFilter);
            this.Controls.Add(this.buttonAddRandomNoise);
            this.Controls.Add(this.textBoxNoisePercent);
            this.Controls.Add(this.buttonAddSaltAndPepper);
            this.Controls.Add(this.buttonApplyCopied);
            this.Controls.Add(this.buttonEnforce);
            this.Controls.Add(this.buttonEqualize);
            this.Controls.Add(this.buttonGetHistogram);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.buttonApplyPower);
            this.Controls.Add(this.checkBoxInverseLog);
            this.Controls.Add(this.buttonApplyLogarithm);
            this.Controls.Add(this.buttonConvertToImage);
            this.Controls.Add(this.buttonApplyNegative);
            this.Controls.Add(this.buttonSubtractImage);
            this.Controls.Add(this.buttonRotate180);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageEditor";
            this.Text = "Image Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.potterGroupBox.ResumeLayout(false);
            this.potterGroupBox.PerformLayout();
            this.thresholdGroupBox.ResumeLayout(false);
            this.thresholdGroupBox.PerformLayout();
            this.groupBoxDilatation.ResumeLayout(false);
            this.groupBoxDilatation.PerformLayout();
            this.groupBoxErosion.ResumeLayout(false);
            this.groupBoxErosion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.Button shiftButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nearestNeighbourMultiplier;
        private System.Windows.Forms.Button multiplyNearestNeighbourButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bilinearInterpolationTextBox;
        private System.Windows.Forms.Button multiplyBilinearInterpolationButton;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonRotate180;
        private System.Windows.Forms.Button buttonSubtractImage;
        private System.Windows.Forms.Button buttonApplyNegative;
        private System.Windows.Forms.Button buttonConvertToImage;
        private System.Windows.Forms.Button buttonApplyLogarithm;
        private System.Windows.Forms.CheckBox checkBoxInverseLog;
        private System.Windows.Forms.Button buttonApplyPower;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Button divideBilinearInterpolationButton;
        private System.Windows.Forms.Button divideNearestNeighbourButton;
        private System.Windows.Forms.Button buttonGetHistogram;
        private System.Windows.Forms.Button buttonEqualize;
        private System.Windows.Forms.Button buttonEnforce;
        private System.Windows.Forms.Button buttonApplyCopied;
        private System.Windows.Forms.Button buttonAddSaltAndPepper;
        private System.Windows.Forms.TextBox textBoxNoisePercent;
        private System.Windows.Forms.Button buttonAddRandomNoise;
        private System.Windows.Forms.Button buttonAverageFilter;
        private System.Windows.Forms.TextBox textBoxAverageFilterWindowSize;
        private System.Windows.Forms.TextBox textBoxMedianFilterWindowSize;
        private System.Windows.Forms.Button buttonMedianFilter;
        private System.Windows.Forms.Button buttonGetLine;
        private System.Windows.Forms.TextBox textBoxLineNumber;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button button2DSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox spectreResizeTextBox;
        private System.Windows.Forms.Button multiplySpectreButton;
        private System.Windows.Forms.Button buttonDeconvolution;
        private System.Windows.Forms.TextBox textBoxDeconvolutionAlpha;
        private System.Windows.Forms.Button buttonBothNoise;
        private System.Windows.Forms.GroupBox potterGroupBox;
        private System.Windows.Forms.Label potterType;
        private System.Windows.Forms.ComboBox filterNameComboBox;
        private System.Windows.Forms.TextBox fc2TextBox;
        private System.Windows.Forms.Label fc2Label;
        private System.Windows.Forms.Button applyPotterButton;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox fcTextBox;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Label fcLabel;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.GroupBox thresholdGroupBox;
        private System.Windows.Forms.Button buttonApplyThreshold;
        private System.Windows.Forms.Button buttonGradient;
        private System.Windows.Forms.Button buttonLaplace;
        private System.Windows.Forms.GroupBox groupBoxDilatation;
        private System.Windows.Forms.Label dilaYLabel;
        private System.Windows.Forms.Label dilaXLabel;
        private System.Windows.Forms.TextBox textBoxDilatationHeight;
        private System.Windows.Forms.Button buttonDilatationApply;
        private System.Windows.Forms.TextBox textBoxDilatationWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDilatationColor;
        private System.Windows.Forms.GroupBox groupBoxErosion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxErosionColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxErosionHeight;
        private System.Windows.Forms.Button buttonErosionApply;
        private System.Windows.Forms.TextBox textBoxErosionWidth;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.CheckBox checkBoxLessThanMax;
        private System.Windows.Forms.Button buttonAutoShift;
    }
}