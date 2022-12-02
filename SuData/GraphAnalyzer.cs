using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SuLibrary;
using SuLibrary.Analyzer;
using SuLibrary.Graph;
using SuLibrary.Misc;
using ZedGraph;

namespace SuData
{
    public partial class GraphAnalyzer : Form
    {
        private readonly ZedGraphControl _control;
        private readonly List<ZedGraphControl> _controlList;

        private readonly CopyPaster _cp;

        public GraphAnalyzer(ZedGraphControl control, CopyPaster cp, List<ZedGraphControl> controls)
        {
            InitializeComponent();
            _control = control;
            KeyPreview = true;
            FillGraphList();
            _cp = cp;
            _controlList = controls;
        }

        //TODO move func to class
        private void FillGraphList()
        {
            ControlEditor.UpdateGraphs(_control, graphListBox);
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                graphListBox.SetItemChecked(i, true);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(specFromTextbox.Text.Replace('.', ','), out var minX);
            flag &= double.TryParse(specToTextbox.Text.Replace('.', ','), out var maxX);


            if (!flag)
            {
                minX = double.MinValue;
                maxX = double.MaxValue;
            }

            //TODO: to func
            var indices = new List<int>(); 
            for(var i = 0; i < graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            var selectedCurves = (from int index in indices select _control.GraphPane.CurveList[index]).ToList();
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);

            if (ppl.Count == 0)
                return;

            Analyzer.GetIndicesByRangeInSortedPointPairList(ppl, minX, maxX, out var from, out var to);

            var characteristics = Analyzer.GetAllCharacteristics(ppl, from, to);

            var final = new StringBuilder($"Characteristics (x∈[{minX}; {maxX}]):\n");
            final.Append($"Minimum: {characteristics.Min}\n");
            final.Append($"Maximum: {characteristics.Max}\n");
            final.Append($"Average: {characteristics.Average}\n");
            final.Append($"Dispersion: {characteristics.Dispersion}\n");
            final.Append($"σ: {characteristics.Sigma}\n");
            final.Append($"Ѱ²: {characteristics.MeanSquare}\n");
            final.Append($"ε (RMS): {characteristics.RootMeanSquare}\n");
            final.Append($"μ₃: {characteristics.AsymmetryMoment}\n");
            final.Append($"ˠ₁: {characteristics.AsymmetryCoefficient}\n");
            final.Append($"μ₄: {characteristics.Excess}\n");
            final.Append($"ˠ₂: {characteristics.Kurtosis}\n");

            Log(final.ToString());
        }

        private void Log(string s)
        {
            logRichTextBox.Text += $"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}] " + s;
        }

        private void calculateStationaryButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(subsetStationaryTextbox.Text.Replace('.', ','), out var subsetAmount);

            if (!flag)
            {
                subsetAmount = 10;
            }

            //TODO: to func
            var indices = new List<int>();
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            var selectedCurves = (from int index in indices select _control.GraphPane.CurveList[index]).ToList();
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);

            if (ppl.Count == 0)
                return;

            var min = ppl.Min(x => x.Y);
            var max = ppl.Max(x => x.Y);

            //TODO: maybe should get only for from-to indices
            var part = ppl.Count / subsetAmount;

            var averages = new List<double>(subsetAmount);
            var sigmas = new List<double>(subsetAmount);
            var meanSquares = new List<double>(subsetAmount);


            var ans = new StringBuilder();

            var isFirst = true;
            for (var i = 0; i < subsetAmount; i++)
            {
                averages.Add(Analyzer.GetAverageOnRange(ppl, i * part, Math.Min((i + 1) * part - 1, ppl.Count - 1))); ;
                sigmas.Add(Analyzer.GetSigmaOnRange(ppl, i * part, Math.Min((i + 1) * part - 1, ppl.Count - 1)));
                meanSquares.Add(Analyzer.GetMeanSquare(ppl, i * part, Math.Min((i + 1) * part - 1, ppl.Count - 1)));

                ans.Append($"Range [{i + 1}/{subsetAmount}]\n");
                ans.Append($"Average: {averages[i] }\n");
                ans.Append($"Dispersion: {sigmas[i] }\n");
                ans.Append($"Mean Square: {meanSquares[i] }\n");
                
                if (!isFirst)
                {
                    ans.Append($"Average diff: {Analyzer.GetPercentDiff(averages[i], averages[i - 1], min, max)}%\n");
                    ans.Append($"Dispersion diff: {Analyzer.GetPercentDiff(sigmas[i], sigmas[i - 1], min, max)}%\n");
                    ans.Append($"Mean squares diff: {Analyzer.GetPercentDiff(meanSquares[i], meanSquares[i - 1], min, max)}%\n");
                }

                isFirst = false;
            }

            var adiff = Analyzer.GetPercentDiff(averages.Min(), averages.Max(), min, max);
            var ddiff = Analyzer.GetPercentDiff(sigmas.Min(), sigmas.Max(), min, max);
            var meandiff = Analyzer.GetPercentDiff(meanSquares.Min(), meanSquares.Max(), min, max);

            ans.Append($"Globally:\nMax average diff: {adiff}%\nMax dispersion diff: {ddiff}%\nMax mean square diff: {meandiff}%\n");

            var percent = 2.5;
            ans.Append($"So process is {(adiff < percent * 2 && ddiff < percent * 2 ? "" : "not ")}stationary.");

            Log(ans.ToString());
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            //TODO: to func
            var indices = new List<int>();
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            if (_control.GraphPane.CurveList.Count == 0)
                return;

            var selectedCurves = (from int index in indices select _control.GraphPane.CurveList[index]).ToList();
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);

            if (ppl.Count < 2)
                return;

            var graph = Analyzer.GetDistribution(ppl, ppl.Min(x => x.Y), ppl.Max(x => x.Y), 100);
            GraphDrawer.ClearGraph(distributionZedGraphControl);
            GraphDrawer.AddGraph(distributionZedGraphControl, "Distribution", graph);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            _cp.GetCopy(distributionZedGraphControl);
        }

        private void rxxPlotButton_Click(object sender, EventArgs e)
        {
            //TODO: to func
            var indices = new List<int>();
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            var selectedCurves = (from int index in indices select _control.GraphPane.CurveList[index]).ToList();
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);

            var graph = Analyzer.GetRxx(ppl);
            GraphDrawer.ClearGraph(rxxZedGraphControl);
            GraphDrawer.AddGraph(rxxZedGraphControl, "Rxx", graph);
        }

        private void copyRxxButton_Click(object sender, EventArgs e)
        {
            _cp.GetCopy(rxxZedGraphControl);
        }

        private void plotRxyButton_Click(object sender, EventArgs e)
        {
            //TODO: to func
            var indices = new List<int>();
            for (var i = 0; i < graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            var selectedCurves = (from int index in indices select _control.GraphPane.CurveList[index]).ToList();
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);

            var cv = _controlList[(int) numUpDownGraphNumber.Value - 1].GraphPane.CurveList;
            var ci = cv.ToList();
            var ppl2 = GraphManipulator.MergeGraphs(ci);

            var graph = Analyzer.GetRxy(ppl, ppl2);
            GraphDrawer.ClearGraph(rxyZedGraphControl);
            GraphDrawer.AddGraph(rxyZedGraphControl, "Rxy", graph);
        }

        private void plotSpectreButton_Click(object sender, EventArgs e)
        {
            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);
            if (ppl.Count < 2)
                return;

            var spectre = Analyzer.GetSpectre(ppl, normalizationCheckBox.Checked);
            spectre.RemoveRange(spectre.Count / 2, spectre.Count - spectre.Count / 2);
            GraphDrawer.ClearGraph(spectreZgc);
            GraphDrawer.AddGraph(spectreZgc, "Spectre", spectre);
        }

        private void copySpectreButton_Click(object sender, EventArgs e)
        {
            _cp.GetCopy(spectreZgc);
        }

        private void copyRxyButton_Click(object sender, EventArgs e)
        {
            _cp.GetCopy(rxyZedGraphControl);
        }

        private void GraphAnalyzer_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control) return;

            switch (e.KeyCode)
            {
                case Keys.C:
                    switch (tabControl.SelectedTab.Text)
                    {
                        case "Distribution":
                            _cp.GetCopy(distributionZedGraphControl);
                            break;
                        case "Rxx":
                            _cp.GetCopy(rxxZedGraphControl);
                            break;
                        case "Rxy":
                            _cp.GetCopy(rxyZedGraphControl);
                            break;
                        case "Spectre":
                            _cp.GetCopy(spectreZgc);
                            break;
                    }

                    break;
            }
        }

        private void plotSpectreButton2_Click(object sender, EventArgs e)
        {
            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);
            if (ppl.Count < 2)
                return;

            var spectre = Analyzer.GetSpectreV3(ppl, normalizationCheckBox.Checked);
            //spectre.RemoveRange(spectre.Count / 2, spectre.Count - spectre.Count / 2);
            GraphDrawer.ClearGraph(spectreZgc);
            GraphDrawer.AddGraph(spectreZgc, "Spectre", spectre);
        }

        private void buttonSpectrePlusReverse_Click(object sender, EventArgs e)
        {
            var selectedCurves = FormsExtender.GetCurves(graphListBox, _control);
            var ppl = GraphManipulator.MergeGraphs(selectedCurves);
            if (ppl.Count < 2)
                return;

            var spectre = Analyzer.GetPplFromRealPartOfComplex(Analyzer.GetReverseComplexSpectre(Analyzer.GetComplexSpectre(ppl, normalizationCheckBox.Checked)));
            //spectre.RemoveRange(spectre.Count / 2, spectre.Count - spectre.Count / 2);
            GraphDrawer.ClearGraph(spectreZgc);
            GraphDrawer.AddGraph(spectreZgc, "Reverse spectre", spectre);
        }
    }
}
