using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SuLibrary.Misc;
using ZedGraph;

namespace SuData
{
    public partial class MainForm : Form
    {
        //Image drawing
        public Image CurImage;
        public ImageData imgData = new ImageData();

        private ZedGraphControl _selectedGraph;
        private CopyPaster _copyPaster;
        
        private float _multiplier = 1;
        private PointF _imagePos = new Point(0, 0);
        private bool _mouseDown = false;
        private Point startMousePos;

        private string _lastFile = null;
        public MainForm()
        {
            InitializeComponent();
            _selectedGraph = zg_1;
            KeyPreview = true;
            _copyPaster = new CopyPaster();
        }

        private void CreateEditor(ZedGraphControl control)
        {
            var list = new List<ZedGraphControl> { zg_1, zg_2, zg_3, zg_4 };
            Form settingForm = new GraphEditor(control, list, _copyPaster);
            settingForm.Show();
        }

        private void CreateAnalyzer(ZedGraphControl control)
        {
            var list = new List<ZedGraphControl> {zg_1, zg_2, zg_3, zg_4};

            Form settingForm = new GraphAnalyzer(control, _copyPaster, list);
            settingForm.Show();
        }

        private void zg_1_DoubleClick(object sender, EventArgs e)
        {
            CreateEditor(zg_1);
        }

        private void zg_2_DoubleClick(object sender, EventArgs e)
        {
            CreateEditor(zg_2);
        }

        private void zg_3_DoubleClick(object sender, EventArgs e)
        {
            CreateEditor(zg_3);
        }

        private void zg_4_DoubleClick(object sender, EventArgs e)
        {
            CreateEditor(zg_4);
        }

        private void DoActionsOnSelected(ZedGraphControl control)
        {
            ControlEditor.UpdateGraphs(control, graphList);
            _selectedGraph = control;
            panelSelection.Location = new Point(control.Location.X - 3, control.Location.Y - 3);
            panelSelection.Size = new Size(control.Width + 6, control.Height + 6);
        }

        private void zg_1_Paint(object sender, PaintEventArgs e)
        {
            if (_selectedGraph == zg_1)
                ControlEditor.UpdateGraphs(zg_1, graphList);
        }

        private void zg_1_Enter(object sender, EventArgs e)
        {
            DoActionsOnSelected(zg_1);
        }

        private void zg_2_Paint(object sender, PaintEventArgs e)
        {
            if (_selectedGraph == zg_2)
                ControlEditor.UpdateGraphs(zg_2, graphList);
        }

        private void zg_2_Enter(object sender, EventArgs e)
        {
            DoActionsOnSelected(zg_2);
        }

        private void zg_3_Enter(object sender, EventArgs e)
        {
            DoActionsOnSelected(zg_3);
        }

        private void zg_3_Paint(object sender, PaintEventArgs e)
        {
            if (_selectedGraph == zg_3)
                ControlEditor.UpdateGraphs(zg_3, graphList);
        }

        private void zg_4_Enter(object sender, EventArgs e)
        {
            DoActionsOnSelected(zg_4);
        }

        private void zg_4_Paint(object sender, PaintEventArgs e)
        {
            if (_selectedGraph == zg_4)
                ControlEditor.UpdateGraphs(zg_4, graphList);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CreateEditor(_selectedGraph);
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            CreateAnalyzer(_selectedGraph);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            _copyPaster.GetCopy(_selectedGraph);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            _copyPaster.PasteCopy(_selectedGraph);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            UpdateGraphPos();
        }

        private void UpdateGraphPos()
        {
            var sizeX = (graphTabPage.Size.Width - 18) / 2; //(graphGroupBox.Location.X - 18) / 2;
            var sizeY = (graphTabPage.Size.Height - 18) / 2; //(ClientSize.Height - 18) / 2;

            zg_1.Size = new Size(sizeX, sizeY);
            zg_2.Size = new Size(sizeX, sizeY);
            zg_3.Size = new Size(sizeX, sizeY);
            zg_4.Size = new Size(sizeX, sizeY);

            panelSelection.Size = new Size(sizeX + 6, sizeY + 6);


            zg_1.Location = new Point(6, 6);
            zg_2.Location = new Point(zg_1.Location.X + zg_1.Size.Width + 6, zg_1.Location.Y);
            zg_3.Location = new Point(zg_1.Location.X, zg_1.Location.Y + zg_1.Size.Height + 6);
            zg_4.Location = new Point(zg_1.Location.X + zg_1.Size.Width + 6, zg_1.Location.Y + zg_1.Size.Height + 6);

            DoActionsOnSelected(_selectedGraph);
        }

        private void resetViewButton_Click(object sender, EventArgs e)
        {
            _selectedGraph.RestoreScale(_selectedGraph.GraphPane);
            //_selectedGraph.ZoomOutAll(_selectedGraph.GraphPane);
            _selectedGraph.Invalidate();
        }

        

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                resetViewButton_Click(sender, e);
            }

            if (!e.Control) return;

            // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
            switch (e.KeyCode)
            {
                case Keys.C:
                    _copyPaster.GetCopy(_selectedGraph);
                    break;
                case Keys.V:
                    _copyPaster.PasteCopy(_selectedGraph);
                    break;
                case Keys.B:
                    _copyPaster.AddCopy(_selectedGraph);
                    break;
                case Keys.R:
                    ReOpen();
                    break;
                default:
                    break;
            }
        }

        private void manipulateButton_Click(object sender, EventArgs e)
        {
            var list = new List<ZedGraphControl> { zg_1, zg_2, zg_3, zg_4 };
            Form settingForm = new GraphManipulatorForm(_selectedGraph, list, _copyPaster);
            settingForm.Show();
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Jpeg (*.jpg)|*.jpg|Xcr (*.xcr)|*.xcr|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fname = openFileDialog.FileName.ToLower();

                    if (fname.EndsWith("xcr"))
                        imgData.LoadXCR(openFileDialog.FileName);
                    else if (fname.EndsWith("dat"))
                        imgData.LoadDat(openFileDialog.FileName);
                    else if (fname.EndsWith("bin"))
                        imgData.LoadBin(openFileDialog.FileName);
                    else
                        imgData.LoadImage(openFileDialog.FileName);

                    //imgData.ColorDepth = (int)nUpDownColorDepth.Value;
                    CurImage = imgData.GetBitmap(checkBoxForceColorChange.Checked);
                    //picBox.Invalidate();
                    ResetImage();

                    _lastFile = openFileDialog.FileName;
                }
            }
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            if (CurImage == null)
                return;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            //e.Graphics.DrawImage(_curImage, GetScaledImageRect(_curImage, (Control) sender));

            var z = new RectangleF(0, 0, CurImage.Width * _multiplier, CurImage.Height * _multiplier);

            z.X += _imagePos.X;
            z.Y += _imagePos.Y;

            e.Graphics.DrawImage(CurImage, z);
        }

        private void editImageButton_Click(object sender, EventArgs e)
        {
            Form settingForm = new ImageEditor(picBox, this, _copyPaster);
            settingForm.Show();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Jpeg (*.jpg)|*.jpg|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                CurImage.Save(saveFileDialog.FileName);
            }
        }

        private void nUpDownColorDepth_ValueChanged(object sender, EventArgs e)
        {
            imgData.ColorDepth = (int) nUpDownColorDepth.Value;
            CurImage = imgData.GetBitmap(checkBoxForceColorChange.Checked);
            picBox.Invalidate();
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            startMousePos = picBox.PointToClient(MousePosition);
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;

            var mousePos = picBox.PointToClient(MousePosition);
            _imagePos.X += mousePos.X - startMousePos.X;
            _imagePos.Y += mousePos.Y - startMousePos.Y;
            startMousePos = mousePos;
            picBox.Invalidate();
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            // Do not use MouseEventArgs.X, Y because they are relative!
            var ptMouseAbs = MousePosition;
            Control iCtrl = picBox;
            do
            {
                var rCtrl = iCtrl.RectangleToScreen(iCtrl.ClientRectangle);
                if (!rCtrl.Contains(ptMouseAbs))
                {
                    base.OnMouseWheel(e);
                    return; // mouse position is outside the picturebox or it's parents
                }

                iCtrl = iCtrl.Parent;
            } while (iCtrl != null && iCtrl != this);

            var ptMouseRel = picBox.PointToClient(ptMouseAbs);

            var delta = e.Delta / SystemInformation.MouseWheelScrollDelta;

            if (_multiplier > 1 && (delta < 0) || _multiplier >= 1 && (delta > 0 && _multiplier < 30))
            {
                var tmpMultiplier = _multiplier + delta;
                tmpMultiplier = (float) (int) Math.Round(tmpMultiplier * 10) / 10;
                if (tmpMultiplier < 0.1)
                    tmpMultiplier = 0.1f;

                if (tmpMultiplier > 30)
                    tmpMultiplier = 30f;

                var multiplierChange = (float) tmpMultiplier / _multiplier;
                _imagePos.X = ptMouseRel.X - (ptMouseRel.X - _imagePos.X) * multiplierChange;
                _imagePos.Y = ptMouseRel.Y - (ptMouseRel.Y - _imagePos.Y) * multiplierChange;
                ChangeMultiplier(tmpMultiplier);

                if (float.IsInfinity(_imagePos.X) || float.IsInfinity(_imagePos.Y))
                {
                    _imagePos.X = 0;
                    _imagePos.Y = 0;
                }

                picBox.Invalidate();
            }
            else if (_multiplier <= 1 && delta > 0 || _multiplier >= 0.1 && delta < 0)
            {
                var tmpMultiplier = _multiplier + (float) delta / 10;
                tmpMultiplier = (float)(int)Math.Round(tmpMultiplier * 10) / 10;

                if (tmpMultiplier < 0.1)
                    tmpMultiplier = 0.1f;

                if (tmpMultiplier > 30)
                    tmpMultiplier = 30f;

                var multiplierChange = (float) tmpMultiplier / _multiplier;
                _imagePos.X = ptMouseRel.X - (ptMouseRel.X - _imagePos.X) * multiplierChange;
                _imagePos.Y = ptMouseRel.Y - (ptMouseRel.Y - _imagePos.Y) * multiplierChange;
                ChangeMultiplier(tmpMultiplier);

                if (float.IsInfinity(_imagePos.X) || float.IsInfinity(_imagePos.Y))
                {
                    _imagePos.X = 0;
                    _imagePos.Y = 0;
                }

                picBox.Invalidate();
            }
        }

        private void ChangeMultiplier(float newValue)
        {
            _multiplier = newValue;
            labelZoom.Text = $"Zoom: {_multiplier * 100}%";
        }

        private void buttonResetImage_Click(object sender, EventArgs e)
        {
            ResetImage();
        }

        private void ResetImage()
        {
            ChangeMultiplier(1);
            _imagePos = new PointF(0, 0);
            picBox.Invalidate();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraphPos();
        }

        private void checkBoxForceColorChange_CheckedChanged(object sender, EventArgs e)
        {
            CurImage = imgData.GetBitmap(checkBoxForceColorChange.Checked);
            picBox.Invalidate();
        }

        private void reOpenButton_Click(object sender, EventArgs e)
        {
            ReOpen();
        }

        private void ReOpen()
        {
            if (_lastFile == null) return;

            if (_lastFile.EndsWith("xcr"))
                imgData.LoadXCR(_lastFile);
            else if (_lastFile.EndsWith("dat"))
                imgData.LoadDat(_lastFile);
            else if (_lastFile.EndsWith("bin"))
                imgData.LoadBin(_lastFile);
            else
                imgData.LoadImage(_lastFile);

            CurImage = imgData.GetBitmap(checkBoxForceColorChange.Checked);
            ResetImage();
        }
    }
}
