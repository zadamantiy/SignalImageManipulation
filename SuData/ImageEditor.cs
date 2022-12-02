using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuLibrary.Graph;
using SuLibrary.Misc;
using ZedGraph;

namespace SuData
{
    public partial class ImageEditor : Form
    {
        private CopyPaster _cp;
        private PictureBox _picBox;
        //private Image _image;
        private MainForm _mf { get; }

        private int[] tmpHist = null;
        public ImageEditor(PictureBox picBox, MainForm mf, CopyPaster cp)
        {
            InitializeComponent();
            
            _picBox = picBox;
            //_image = image;
            _cp = cp;
            _mf = mf;
        }

        private void shiftButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(shiftTextBox.Text.Replace('.', ','), out var shift);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.Shift(shift);
            UpdateImage();
        }

        private void multiplyNearestNeighbourButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(nearestNeighbourMultiplier.Text.Replace('.', ','), out var multiplier);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.NearestNeighbourResize(multiplier);
            UpdateImage();
        }

        private void multiplyBilinearInterpolationButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(bilinearInterpolationTextBox.Text.Replace('.', ','), out var multiplier);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.BilinearInterpolationResize(multiplier);
            UpdateImage();
        }

        private void divideNearestNeighbourButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(nearestNeighbourMultiplier.Text.Replace('.', ','), out var multiplier);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.NearestNeighbourResize(1 / multiplier);
            UpdateImage();
        }

        private void divideBilinearInterpolationButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(bilinearInterpolationTextBox.Text.Replace('.', ','), out var multiplier);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.BilinearInterpolationResize(1 / multiplier);
            UpdateImage();
        }

        private void buttonRotateRight_Click(object sender, EventArgs e)
        {
            _mf.imgData.Rotate(DataRotate.Right);
            UpdateImage();
        }

        private void buttonRotate180_Click(object sender, EventArgs e)
        {
            _mf.imgData.Rotate(DataRotate.Degree180);
            UpdateImage();
        }

        private void buttonRotateLeft_Click(object sender, EventArgs e)
        {
            _mf.imgData.Rotate(DataRotate.Left);
            UpdateImage();
        }

        private void buttonSubtractImage_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Jpeg (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                _mf.imgData.SubtractImage(openFileDialog.FileName);
                UpdateImage();
            }
        }

        private void buttonApplyNegative_Click(object sender, EventArgs e)
        {
            _mf.imgData.ApplyNegative();
            UpdateImage();
        }

        private void UpdateImage()
        {
            _mf.CurImage = _mf.imgData.GetBitmap(_mf.checkBoxForceColorChange.Checked);
            _picBox.Invalidate();
        }

        private void buttonConvertToImage_Click(object sender, EventArgs e)
        {
            _mf.imgData.ReloadAsBitmap();
            UpdateImage();
        }

        private void buttonApplyLogarithm_Click(object sender, EventArgs e)
        {
            if (checkBoxInverseLog.Checked)
            {
                _mf.imgData.ApplyInverseLogarithm();
            }
            else
            {
                _mf.imgData.ApplyLogarithm();
            }

            UpdateImage();
        }

        private void buttonApplyPower_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(textBoxGamma.Text.Replace('.', ','), out var power);

            if (!parsed)
                return;

            _mf.imgData.ApplyPower(power);
            UpdateImage();
        }

        private void buttonGetHistogram_Click(object sender, EventArgs e)
        {
            var hist = _mf.imgData.GetHistogram();
            var min = _mf.imgData.GetMin();
            _cp.GetCopy(ConvertIntArrayToCurveList(hist, min));
        }

        private static CurveList ConvertIntArrayToCurveList(IEnumerable<int> array, double min = 0)
        {
            var curveList = new CurveList();
            var lineItem = new LineItem("Histogram");
            var i = 0;
            lineItem.Symbol = new Symbol(SymbolType.None, Color.Transparent);
            foreach (var value in array)
                lineItem.AddPoint(new PointPair(min + i++, value));
            curveList.Add(lineItem);
            return curveList;
        }

        private void buttonEqualize_Click(object sender, EventArgs e)
        {
            var min = _mf.imgData.GetMin();
            var tmp = _mf.imgData.EqualizeHistogram();
            _cp.GetCopy(ConvertIntArrayToCurveList(tmp, min));
            UpdateImage();
        }

        private void buttonEnforce_Click(object sender, EventArgs e)
        {
            var min = _mf.imgData.GetMin();
            var tmp = _mf.imgData.EnforceHistogram();
            _cp.GetCopy(ConvertIntArrayToCurveList(tmp, min));
            UpdateImage();

            tmpHist = tmp;
        }

        private void buttonApplyCopied_Click(object sender, EventArgs e)
        {
            _mf.imgData.ApplyFunction(tmpHist, 0);
            UpdateImage();
        }

        private void buttonAddSaltAndPepper_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(textBoxNoisePercent.Text.Replace('.', ','), out var percent);
            if (!parsed)
                return;

            _mf.imgData.AddSaltAndPepper(percent);
            UpdateImage();
        }

        private void buttonAddRandomNoise_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(textBoxNoisePercent.Text.Replace('.', ','), out var percent);
            if (!parsed)
                return;

            _mf.imgData.AddRandomNoise(percent);
            UpdateImage();
        }

        private void buttonAverageFilter_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(textBoxAverageFilterWindowSize.Text, out var winSize);
            if (!parsed)
                return;

            _mf.imgData.AverageFilter(winSize);
            UpdateImage();
        }

        private void buttonMedianFilter_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(textBoxMedianFilterWindowSize.Text, out var winSize);
            if (!parsed)
                return;

            _mf.imgData.MedianFilter(winSize);
            UpdateImage();
        }

        private static CurveList ConvertPplToCurveList(PointPairList array, double min = 0)
        {
            var curveList = new CurveList();
            var lineItem = new LineItem("Curve") {Symbol = new Symbol(SymbolType.None, Color.Transparent)};
            foreach (var value in array)
                lineItem.AddPoint(new PointPair(value.X, value.Y));
            curveList.Add(lineItem);
            return curveList;
        }

        private void buttonGetLine_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(textBoxLineNumber.Text, out var n);
            if (!parsed)
                return;

            var tmp = _mf.imgData.Data[n];
            _cp.GetCopy(ConvertPplToCurveList(tmp));
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            /*
            //var y= GraphManipulator.GetBSPotter(0.240, 0.330, 64, 1);
            //var y2 = GraphManipulator.GetBSPotter(0.375, 0.445, 64, 1);
            var y = GraphManipulator.GetBSPotter(0.28, 0.31, 64, 1);
            var newData = new List<PointPairList>();
            foreach (var ppl in _mf.imgData.Data)
            {
                var ppl2 = GraphManipulator.GetСonvolution(ppl, y);
                var ppl3 = new PointPairList();
                for(int i = 64; i < 64 + _mf.imgData.Data[0].Count; i++)
                    ppl3.Add(ppl2[i]);
                //ppl2 = GraphManipulator.GetСonvolution(ppl, y2);
                newData.Add(ppl3);
            }

            _mf.imgData.Data = newData;*/
            _mf.imgData.AutoFilter();
            UpdateImage();
        }

        private void button2DSpec_Click(object sender, EventArgs e)
        {
            _mf.imgData = _mf.imgData.Get2DSpectreImage();
            UpdateImage();
        }

        private void multiplySpectreButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(spectreResizeTextBox.Text.Replace('.', ','), out var multiplier);

            if (!parsed)
            {
                return;
            }

            _mf.imgData.SpectreResize(multiplier);
            UpdateImage();
        }

        private void buttonDeconvolution_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(textBoxDeconvolutionAlpha.Text.Replace('.', ','), out var alpha);

            if (!parsed)
            {
                return;
            }

            var filename = "";
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Dat (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) 
                    return;

                filename = openFileDialog.FileName;
            }

            var kernel = SuDatFileReader.ReadDatFile(filename, 1);

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (alpha == 0)
            { 
                _mf.imgData.Deconvolution(kernel);
            }
            else
            {
                _mf.imgData.Deconvolution(kernel, alpha);
            }

            UpdateImage();
        }

        private void buttonBothNoise_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(textBoxNoisePercent.Text.Replace('.', ','), out var percent);
            if (!parsed)
                return;

            _mf.imgData.MixNoise(percent);
            UpdateImage();
        }

        private void applyPotterButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(fcTextBox.Text.Replace('.', ','), out var fc);

            double fc2 = 0;
            if (filterNameComboBox.Text == "Band Pass" || filterNameComboBox.Text == "Band Stop")
                parsed &= double.TryParse(fc2TextBox.Text.Replace('.', ','), out fc2);

            double dT = 1;

            parsed &= int.TryParse(mTextBox.Text, out var m);

            if (!parsed)
                return;

            PointPairList y = null;
            switch (filterNameComboBox.Text)
            {
                case "Low Pass":
                    y = GraphManipulator.GetLPPotter(fc, m, dT);
                    break;
                case "High Pass":
                    y = GraphManipulator.GetHPPotter(fc, m, dT);
                    break;
                case "Band Pass":
                    y = GraphManipulator.GetBPPotter(fc, fc2, m, dT);
                    break;
                case "Band Stop":
                    y = GraphManipulator.GetBSPotter(fc, fc2, m, dT);
                    break;
            }

            //_mf.imgData.ConvolutionAllLines(y);
            _mf.imgData.ConvolutionLinesAndColumns(y);
            
            UpdateImage();
        }

        private void buttonApplyThreshold_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(textBoxThreshold.Text.Replace('.', ','), out var threshold);
            
            if (!parsed)
                return;

            _mf.imgData.ThresholdFilter(threshold);
            UpdateImage();
        }

        private void buttonGradient_Click(object sender, EventArgs e)
        {
            _mf.imgData.Gradient();
            UpdateImage();
        }

        private void buttonLaplace_Click(object sender, EventArgs e)
        {
            _mf.imgData.Laplace();
            UpdateImage();
        }

        private void buttonDilatationApply_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(textBoxDilatationWidth.Text, out var width);
            parsed &= int.TryParse(textBoxDilatationHeight.Text, out var height);
            parsed &= double.TryParse(textBoxDilatationColor.Text.Replace('.', ','), out var color);

            if (!parsed)
                return;

            _mf.imgData.DilatationSquared(height, width, color);
            UpdateImage();
        }

        private void buttonErosionApply_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(textBoxErosionWidth.Text, out var width);
            parsed &= int.TryParse(textBoxErosionHeight.Text, out var height);
            parsed &= double.TryParse(textBoxErosionColor.Text.Replace('.', ','), out var color);

            if (!parsed)
                return;

            _mf.imgData.ErosionSquared(height, width, color);
            UpdateImage();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Jpeg (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                _mf.imgData.SumImage(openFileDialog.FileName, checkBoxLessThanMax.Checked);
                UpdateImage();
            }
        }

        private void buttonAutoShift_Click(object sender, EventArgs e)
        {
            var min = _mf.imgData.GetMin();
            _mf.imgData.Shift(-min);
            UpdateImage();
        }
    }
}
