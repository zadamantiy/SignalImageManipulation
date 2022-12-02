using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SuLibrary;
using SuLibrary.Analyzer;
using SuLibrary.Graph;
using SuLibrary.Graph.Params;
using SuLibrary.Misc;
using ZedGraph;

namespace SuData
{
    public partial class GraphManipulatorForm : Form
    {
        private readonly List<ZedGraphControl> _controlList;
        private readonly ZedGraphControl _control;
        private readonly CopyPaster _cp;
        private readonly Random _random = new Random();

        public GraphManipulatorForm(ZedGraphControl control, List<ZedGraphControl> controlList, CopyPaster copyPaster)
        {
            InitializeComponent();
            _control = control;
            _cp = copyPaster;
            _controlList = controlList;
            FillGraphList();
        }

        //TODO: move to another class
        private void FillGraphList()
        {
            ControlEditor.UpdateGraphs(_control, graphListBox);
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                graphListBox.SetItemChecked(i, true);
            }
        }

        private void shiftButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(shiftParTextbox.Text.Replace('.', ','), out var shift);

            if (!parsed)
            {
                //TODO: WARNING
                return;
            }

            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);

            foreach (var curve in selectedCurves)
            {
                GraphManipulator.Shift(curve, shift);
            }

            _control.AxisChange();
            _control.Invalidate();
        }

        private void antishiftButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(shiftParTextbox.Text.Replace('.', ','), out var shift);

            if (!parsed)
            {
                //TODO: WARNING
                return;
            }

            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);

            foreach (var curve in selectedCurves)
            {
                GraphManipulator.AntiShift(curve);
            }

            _control.AxisChange();
            _control.Invalidate();
        }

        private void addSpikesButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(spikeMinValueTextbox.Text.Replace('.', ','), out var minValue);
            parsed &= double.TryParse(spikeMaxValueTextbox.Text.Replace('.', ','), out var maxValue);
            parsed &= int.TryParse(spikeCountTextbox.Text, out var count);

            if (!parsed)
            {
                //TODO: WARNING
                return;
            }

            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);

            foreach (var curve in selectedCurves)
            {
                GraphManipulator.AddRandomSpikes(curve, minValue, maxValue, count, new Random());
            }

            _control.AxisChange();
            _control.Invalidate();
        }

        private void proceedAntiSpikeButton_Click(object sender, EventArgs e)
        {
            var parsed = true;
            parsed &= double.TryParse(sTextBox.Text.Replace('.', ','), out var s);

            if (!parsed)
                return;

            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);

            foreach (var curve in selectedCurves)
            {
                GraphManipulator.RemoveSpikes(curve, s);
            }

            _control.AxisChange();
            _control.Invalidate();
        }

        private void antiTrendButton_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(winSizeTextBox.Text, out var winSize);

            if (!parsed)
                return;

            var ppl = new PointPairList();
            var curve = _control.GraphPane.CurveList[0];
            for (var i = 0; i < curve.Points.Count; i++)
            {
                ppl.Add(curve.Points[i].X, curve.Points[i].Y);
            }
            ppl = GraphManipulator.AntiTrend(ppl, winSize);

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, "AntiTrend", ppl);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void addAntiRandom_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(minYTextBox.Text.Replace('.', ','), out var minY);
            parsed &= double.TryParse(maxYTextBox.Text.Replace('.', ','), out var maxY);
            parsed &= int.TryParse(timesTextBox.Text, out var times);

            if (!parsed)
                return;

            var graph = (int) graphNumericUpDown.Value - 1;

            var res = new PointPairList();

            var gpe = new GraphParamsEquation();
            gpe.AddParameter("min", minY);
            gpe.AddParameter("max", maxY);


            PointPairList graphPpl;
            if (useGraphCheckBox.Checked)
            { 
                graphPpl = GraphManipulator.MergeGraphs(FormsExtender.GetCurves(graphListBox, _control));
                gpe.MinCoordinate = graphPpl.Min(t => t.X);
                gpe.MaxCoordinate = graphPpl.Max(t => t.X);
                gpe.Delta = graphPpl[1].X - graphPpl[0].X;
            }
            else
            {
                //TODO: maybe rework
                graphPpl = new PointPairList();
                gpe.MinCoordinate = 0;
                gpe.MaxCoordinate = 1;
                gpe.Delta = 0.001;
            }

            var rnd = GraphCreator.GetRandom(gpe, _random);
            res = GraphManipulator.SumGraphs(res, rnd);
            res = GraphManipulator.SumGraphs(res, graphPpl);

            for (var i = 0; i < times - 1; i++)
            {
                res = GraphManipulator.SumGraphs(res, graphPpl);
                rnd = GraphCreator.GetRandom(gpe, _random);
                res = GraphManipulator.SumGraphs(res, rnd);
            }

            foreach (var pointPair in res)
            {
                pointPair.Y /= times;
            }

            GraphDrawer.ClearGraph(_controlList[graph]);
            GraphDrawer.AddGraph(_controlList[graph], "AntiRandom", res);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void plotSigmasButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(minYTextBox.Text.Replace('.', ','), out var minY);
            parsed &= double.TryParse(maxYTextBox.Text.Replace('.', ','), out var maxY);
            parsed &= int.TryParse(timesTextBox.Text, out var times);

            if (!parsed)
            {
                return;
            }

            var graph = (int)graphNumericUpDown.Value - 1;

            var res = new PointPairList();

            var gpe = new GraphParamsEquation();
            gpe.AddParameter("min", minY);
            gpe.AddParameter("max", maxY);


            PointPairList graphPpl;
            if (useGraphCheckBox.Checked)
            {
                graphPpl = GraphManipulator.MergeGraphs(FormsExtender.GetCurves(graphListBox, _control));
                gpe.MinCoordinate = graphPpl.Min(t => t.X);
                gpe.MaxCoordinate = graphPpl.Max(t => t.X);
                gpe.Delta = graphPpl[1].X - graphPpl[0].X;
            }
            else
            {
                //TODO: maybe rework
                graphPpl = new PointPairList();
                gpe.MinCoordinate = 0;
                gpe.MaxCoordinate = 1;
                gpe.Delta = 0.001;
            }

            var sigmaGraph = new PointPairList {{0, Analyzer.GetSigmaOnRange(graphPpl)}};

            var rnd = GraphCreator.GetRandom(gpe, _random);
            res = GraphManipulator.SumGraphs(res, rnd);
            sigmaGraph.Add(1, Analyzer.GetSigmaOnRange(res));

            for (var i = 2; i <= times; i++)
            {
                res = GraphManipulator.SumGraphs(res, graphPpl);
                rnd = GraphCreator.GetRandom(gpe, _random);
                res = GraphManipulator.SumGraphs(res, rnd);
                var tmp = new PointPairList();
                foreach (var point in res)
                {
                    tmp.Add(point.X, point.Y / i);
                }

                sigmaGraph.Add(i, Analyzer.GetSigmaOnRange(tmp));
            }

            GraphDrawer.ClearGraph(_controlList[graph]);
            GraphDrawer.AddGraph(_controlList[graph], "SigmaGraph", sigmaGraph);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void addHeartButton_Click(object sender, EventArgs e)
        {
            var N = 1000;

            var x = new PointPairList();
            for (var i = 0; i < N; i++)
                x.Add(i, 0);

            if (spikeHeartCheckbox.Checked)
            { 
                var nums = Enumerable.Range(0, N).ToList();
                var times = 3;
                while (times-- > 0)
                {
                    var tmp = _random.Next(0, nums.Count);
                    var i = nums[tmp];
                    nums.RemoveAt(tmp);
                    x[i].Y += _random.NextDouble() * (130 - 110) + 110;
                }
            }
            else
            {
                x[200].Y += 120;
                x[400].Y += 110;
                x[600].Y += 130;
                //for (var i = 100; i < 100 + 3 * M; i += M)
                //x[i].Y += _random.NextDouble() * (130 - 110) + 110;
            }

            //var h = new PointPairList();
            //for (var i = 0; i < M; i++)
            //{
            //    var t = dt * i;
            //    h.Add(t, Math.Sin(2 * Math.PI * f_0 * t) * Math.Exp(-alpha * t));
            //}

            var h = GetOneHeartBit();
            var y = GraphManipulator.GetСonvolution(x, h);
            //y.RemoveRange(0, 100);
            //y.RemoveRange(1000, 200);

            var graph = (int)graphNumericUpDown.Value - 1;
            GraphDrawer.ClearGraph(_controlList[graph]);
            GraphDrawer.AddGraph(_controlList[graph], "Heart <3", y);

            _control.AxisChange();
            _control.Invalidate();
        }

        private PointPairList GetOneHeartBit()
        {
            const double f_0 = 4;
            const double dt = 0.005;
            const int M = 200;
            const int alpha = 20;
            var h = new PointPairList();
            for (var i = 0; i < M; i++)
            {
                var t = dt * i;
                h.Add(t, Math.Sin(2 * Math.PI * f_0 * t) * Math.Exp(-alpha * t));
            }
            return h;
        }

        private void plotPotterButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(fcTextBox.Text.Replace('.', ','), out var fc);

            double fc2 = 0;
            if (filterNameComboBox.Text == "Band Pass" || filterNameComboBox.Text == "Band Stop")
                parsed &= double.TryParse(fc2TextBox.Text.Replace('.', ','), out fc2);

            double dT;
            if (autoDtCheckBox.Checked && _control.GraphPane.CurveList.Count > 0)
                dT = _control.GraphPane.CurveList[0].Points[1].X - _control.GraphPane.CurveList[0].Points[0].X;
            else
                parsed &= double.TryParse(dtPotterTextBox.Text.Replace('.', ','), out dT);

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

            var graph = (int)graphNumericUpDown.Value - 1;
            GraphDrawer.ClearGraph(_controlList[graph]);
            GraphDrawer.AddGraph(_controlList[graph], "Potter", y);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void applyPotterButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(minYTextBox.Text.Replace('.', ','), out var minY);
            parsed &= double.TryParse(fcTextBox.Text.Replace('.', ','), out var fc);

            double fc2 = 0;
            if (filterNameComboBox.Text == "Band Pass" || filterNameComboBox.Text == "Band Stop")
                parsed &= double.TryParse(fc2TextBox.Text.Replace('.', ','), out fc2);

            double dT;
            if (autoDtCheckBox.Checked && _control.GraphPane.CurveList.Count > 0)
                dT = _control.GraphPane.CurveList[0].Points[1].X - _control.GraphPane.CurveList[0].Points[0].X;
            else
                parsed &= double.TryParse(dtPotterTextBox.Text.Replace('.', ','), out dT);

            parsed &= int.TryParse(mTextBox.Text, out var m);

            if (!parsed)
                return;

            var ppl = GraphManipulator.MergeGraphs(FormsExtender.GetCurves(graphListBox, _control));
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

            y = GraphManipulator.GetСonvolution(ppl, y);

            var graph = (int)graphNumericUpDown.Value - 1;
            GraphDrawer.ClearGraph(_controlList[graph]);
            GraphDrawer.AddGraph(_controlList[graph], "Filtered", y);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void autoDtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox) sender;
            dtPotterTextBox.Enabled = !cb.Checked;
        }

        private void antiNoiseButton_Click(object sender, EventArgs e)
        {
            var parsed = int.TryParse(winSizeTextBox.Text, out var winSize);

            if (!parsed)
                return;

            var ppl = new PointPairList();
            var curve = _control.GraphPane.CurveList[0];
            for (var i = 0; i < curve.Points.Count; i++)
            {
                ppl.Add(curve.Points[i].X, curve.Points[i].Y);
            }
            ppl = GraphManipulator.AntiNoise(ppl, winSize);

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, "AntiTrend", ppl);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void getDtmf_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
            var res = DTMF.DetectDtmf(ppl);
            sw.Stop();
            dtmfResultRichTextBox.Text = "";
            double t = 0;
            foreach (var p in res)
            {
                if (p.First != 'p' && p.Second > 0.064)
                {
                    dtmfResultRichTextBox.Text += $"{p.First} pressed from {t}s for {p.Second}s\n";
                }
                t += p.Second;
            }
            dtmfResultRichTextBox.Text += $"\nElapsed time {sw.ElapsedMilliseconds}ms\n";
        }

        private void cutProceedButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(cutFromTextBox.Text.Replace('.', ','), out var from);
            parsed &= double.TryParse(cutToTextBox.Text.Replace('.', ','), out var to);

            if (!parsed)
                return;

            var curve = _control.GraphPane.CurveList[0];
            for (var i = 0; i < curve.Points.Count; i++)
            {
                if (curve.Points[i].X > to || curve.Points[i].X < from)
                {
                    curve.RemovePoint(i--);
                }
            }

            for (var i = 1; i < curve.Points.Count; i++)
            {
                curve.Points[i].X -= curve.Points[0].X;
            }
            curve.Points[0].X = 0;

            _control.AxisChange();
            _control.Invalidate();
        }

        private void repairGraphButton_Click(object sender, EventArgs e)
        {
            var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
            ppl = GraphManipulator.GetGraphFromSpectre(ppl);

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, "AntiTrend", ppl);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void buttonGetDerivative_Click(object sender, EventArgs e)
        {
            var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
            ppl = GraphManipulator.GetDerivative(ppl);

            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, "Derivative", ppl);

            _control.AxisChange();
            _control.Invalidate();
        }

        private void removeHeartButton_Click(object sender, EventArgs e)
        {
            var parsed = double.TryParse(textBoxAlphaNoiseDeconvolution.Text.Replace('.', ','), out var alpha);

            if (!parsed)
                return;

            var ppl = GraphManipulator.ConvertToPointPairList(_control.GraphPane.CurveList[0]);
            var h = GetOneHeartBit();
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            var res = alpha == 0 ? GraphManipulator.GetDeconvolution(ppl, h) : GraphManipulator.GetNoiseDeconvolution(ppl, h, alpha);
            GraphDrawer.ClearGraph(_control);
            GraphDrawer.AddGraph(_control, "No Heart T-T", res);
            _control.AxisChange();
            _control.Invalidate();
        }

    }
}
