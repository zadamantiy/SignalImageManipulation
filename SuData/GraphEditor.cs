using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SuLibrary;
using SuLibrary.Graph;
using SuLibrary.Graph.Params;
using SuLibrary.Misc;
using SuLibrary.SuMath;
using ZedGraph;
using Label = System.Windows.Forms.Label;

namespace SuData
{
    public partial class GraphEditor : Form
    {
        private readonly ZedGraphControl _control;
        private readonly List<Control> _createdControls = new List<Control>();
        private readonly List<ZedGraphControl> _controlList;

        private int _createPosX;
        private int _createPosY;

        private readonly SuRandom _sRnd = new SuRandom();
        private readonly Random _rnd = new Random();

        private readonly CopyPaster _cp;

        public GraphEditor(ZedGraphControl control, List<ZedGraphControl> controlList, CopyPaster cp)
        {
            InitializeComponent();
            _control = control;
            cb_graphType.DataSource = Enum.GetValues(typeof(GraphType));
            cb_graphType.SelectedIndex = 0;
            _controlList = controlList;
            ResetCurPos();
            _cp = cp;
        }

        private void ResetCurPos()
        {
            _createPosX = lbl_delta.Location.X;
            //TODO: calculate
            _createPosY = nTextbox.Location.Y;//92 + 26; 
        }

        private void cb_graphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((GraphType) cb_graphType.SelectedIndex)
            {
                case GraphType.Exponential:
                    CreateExponentialParams();
                    break;
                case GraphType.Linear:
                    CreateLinearParams();
                    break;
                case GraphType.MyRandom:
                    CreateRandomParams();
                    break;
                case GraphType.Random:
                    CreateRandomParams();
                    break;
                case GraphType.Sin:
                    CreateSinParams();
                    break;
                default:
                    break;
            }
        }

        private void ClearControls()
        {
            foreach (var control in _createdControls)
            {
                foreach (var control2 in trendTabPage.Controls.OfType<Control>())
                {
                    if (control2.Name == control.Name)
                    {
                        trendTabPage.Controls.Remove(control2);
                    }
                }
            }

            ResetCurPos();
        }

        private void AddParam(string name, double val = 0)
        {
            var label = new Label
            {
                Location = new Point(_createPosX, _createPosY),
                Text = name,
                AutoSize = true,
                Name = "lbl_" + name
            };

            var textBox = new TextBox
            {
                //TODO: calculate
                Location = new Point(_createPosX + 40, _createPosY),
                Text = $"{val}",
                Name = name
            };

            trendTabPage.Controls.Add(label);
            trendTabPage.Controls.Add(textBox);

            _createdControls.Add(label);
            _createdControls.Add(textBox);

            //TODO: increase function
            _createPosY += 26;
        }

        private void CreateRandomParams()
        {
            ClearControls();
            AddParam("min", -1);
            AddParam("max", 1);
        }

        private void CreateExponentialParams()
        {
            ClearControls();
            AddParam("a", 0.05);
            AddParam("b", 0.5);
        }

        private void CreateLinearParams()
        {
            ClearControls();
            AddParam("c", 1);
            AddParam("d", 1);
        }

        private void CreateSinParams()
        {
            ClearControls();
            AddParam("A", 1);
            AddParam("f", 1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            GraphDrawer.ClearGraph(_control);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var pars = new GraphParamsEquation {MinCoordinate = 0, MaxCoordinate = 50, Delta = 1};
            var parsed = true;

            parsed &= double.TryParse(tb_minX.Text.Replace('.', ','), out var minX);
            parsed &= double.TryParse(tb_maxX.Text.Replace('.', ','), out var maxX);
            parsed &= double.TryParse(tb_delta.Text.Replace('.', ','), out var delta);

            if (parsed)
            {
                pars.MinCoordinate = minX;
                pars.MaxCoordinate = maxX;
                pars.Delta = delta;
            }
            else
            {
                //TODO: PARSE ERROR
                return;
            }

            foreach (var control in trendTabPage.Controls.OfType<Control>())
            {
                if (!(control is TextBox)) continue;

                parsed &= double.TryParse(control.Text.Replace('.', ','), out var value);
                if (parsed)
                { 
                    pars.AddParameter(control.Name, value);
                }
                else
                {
                    //TODO: PARSE ERROR
                    return;
                }
            }

            switch ((GraphType)cb_graphType.SelectedIndex)
            {
                case GraphType.Exponential:
                    GraphDrawer.AddGraph(_control, GetName("Exponent"), GraphCreator.GetExponent(pars));
                    break;
                case GraphType.Linear:
                    GraphDrawer.AddGraph(_control, GetName("Linear"), GraphCreator.GetLinear(pars));
                    break;
                case GraphType.MyRandom:
                    GraphDrawer.AddGraph(_control, GetName("MyRandom"), GraphCreator.GetRandom(pars, _sRnd));
                    break;
                case GraphType.Random:
                    GraphDrawer.AddGraph(_control, GetName("Random"), GraphCreator.GetRandom(pars, _rnd));
                    break;
                case GraphType.Sin:
                    GraphDrawer.AddGraph(_control, GetName("Sin"), GraphCreator.GetSin(pars));
                    break;
                default:
                    break;
            }
        }
        
        private string GetName(string name)
        {
            var i = 1;
            var newName = name + "_" + i;

            while (_control.GraphPane.CurveList.Find(curve => curve.Label.Text == newName) != null)
            {
                newName = name + "_" + ++i;
            }

            return newName;
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            var ppl = new PointPairList();

            foreach (var curve in _control.GraphPane.CurveList)
            {
                for (var i = 0; i < curve.Points.Count; i++)
                {
                    ppl.Add(curve.Points[i].X, curve.Points[i].Y);
                }
            }

            ppl.Sort();

            for (var i = 1; i < ppl.Count; i++)
            {
                if (ppl[i].X != ppl[i - 1].X) continue;

                ppl[i - 1].Y += ppl[i].Y;
                ppl.RemoveAt(i);
                i--;
            }

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, GetName("Merged"), ppl);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form settingForm = new GraphManipulatorForm(_control, _controlList, _cp);
            settingForm.Show();
        }

        private void setNButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(tb_minX.Text.Replace('.', ','), out var minX);
            parsed &= double.TryParse(tb_delta.Text.Replace('.', ','), out var delta);
            parsed &= double.TryParse(nTextbox.Text.Replace('.', ','), out var n);

            if (!parsed)
                //TODO: parse error
                return;

            tb_maxX.Text = $"{minX + delta * n}";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    datFilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(dtDatTextBox.Text.Replace('.', ','), out var dT);

            if (!parsed)
                //TODO: parse error
                return;

            var ppl = SuDatFileReader.ReadDatFile(datFilePathTextBox.Text, dT);
            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, GetName("Merged"), ppl);
        }

        private void openWavButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "wave files (*.wav)|*.wav|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    wavPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void loadWavButton_Click(object sender, EventArgs e)
        {
            var wf = new WavFile();
            wf.OpenWav(wavPathTextBox.Text);
            var ppl = wf.GetPpl();
            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, GetName("Wav"), ppl);
        }

        private void saveWavButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "wave files (*.wav)|*.wav|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
                WavFile.WritePplToWav(saveFileDialog.FileName, ppl);
            }
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            var input = new List<Pair<char, double>>();
            foreach (var c in numberTextBox.Text.Where(DTMF.CheckChar))
            {
                input.Add(new Pair<char, double>(c, 0.100));
                input.Add(new Pair<char, double>('p', 0.040));
            }

            var ppl = DTMF.GenerateSound(input, 0.00004535147392290249);

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, GetName("DTMF"), ppl);
        }

        private void sampleRateButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(sampleRateTextBox.Text.Replace('.', ','), out var sampleRate);

            if (!parsed)
                //TODO: parse error
                return;

            tb_delta.Text = $"{(1.0 / sampleRate).ToString("0." + new string('#', 339))}";
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

                var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
                SuDatFileReader.WriteDatFile(ppl, saveFileDialog.FileName);
            }
        }
    }
}
