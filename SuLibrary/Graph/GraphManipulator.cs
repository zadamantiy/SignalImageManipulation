using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using SuLibrary.Graph.Params;
using ZedGraph;

namespace SuLibrary.Graph
{
    public static class GraphManipulator
    {
        public static PointPairList ConvertToPointPairList(CurveItem curve)
        {
            var ppl = new PointPairList();
            for (var i = 0; i < curve.Points.Count; i++)
                ppl.Add(curve.Points[i]);
            return ppl;
        }

        //TODO: speed up?
        public static PointPairList MergeGraphs(List<CurveItem> lci)
        {
            var ppl = new PointPairList();

            foreach (var curve in lci)
            {
                for (var i = 0; i < curve.Points.Count; i++)
                {
                    ppl.Add(curve.Points[i]);
                }
            }

            ppl.Sort();
            return ppl;
        }

        public static PointPairList SumGraphs(CurveList cl)
        {
            var ppl = new PointPairList();
            foreach (var curve in cl)
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

            return ppl;
        }

        public static PointPairList GetСonvolution(PointPairList ppl1, PointPairList ppl2)
        {
            var dt = ppl1[1].X - ppl1[0].X;
            var y = new PointPairList();
            for (var k = 0; k < ppl1.Count + ppl2.Count; k++)
            {
                var sum = 0.0;
                for (var j = 0; j < ppl2.Count; j++)
                {
                    if (k - j < 0 || k - j > ppl1.Count - 1)
                        continue;

                    sum += ppl2[j].Y * ppl1[k - j].Y;
                }
                y.Add(dt * k, sum);
            }

            return y;
        }

        public static PointPairList GetСonvolution(CurveItem c1, CurveItem c2)
        {
            var res = new PointPairList();
            for (var k = 0; k < c1.Points.Count + c2.Points.Count; k++)
            {
                var sum = 0.0;
                for (var j = 0; j < c2.Points.Count; j++)
                {
                    if (k - j < 0 || k - j > c1.Points.Count - 1)
                        continue;

                    sum += c2[j].Y * c1[k - j].Y;
                }
                res.Add(k, sum);
            }

            return res;
        }

        public static PointPairList SumGraphs(PointPairList ppl1, PointPairList ppl2)
        {
            var ppl = new PointPairList();
            var pointer1 = 0;
            var pointer2 = 0;

            while (pointer1 != ppl1.Count && pointer2 != ppl2.Count)
            {
                if (ppl1[pointer1].X == ppl2[pointer2].X)
                {
                    ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y + ppl2[pointer2].Y);
                    pointer1++;
                    pointer2++;
                }
                else if (ppl1[pointer1].X < ppl2[pointer2].X)
                {
                    ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y);
                    pointer1++;
                }
                else
                {
                    ppl.Add(ppl2[pointer2].X, ppl1[pointer2].Y);
                    pointer2++;
                }
            }

            while (pointer1 != ppl1.Count)
            {
                ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y);
                pointer1++;
            }

            while (pointer2 != ppl2.Count)
            {
                ppl.Add(ppl2[pointer2].X, ppl2[pointer2].Y);
                pointer2++;
            }

            return ppl;
        }

        public static PointPairList SubtractGraphs(PointPairList ppl1, PointPairList ppl2)
        {
            var ppl = new PointPairList();
            var pointer1 = 0;
            var pointer2 = 0;

            while (pointer1 != ppl1.Count && pointer2 != ppl2.Count)
            {
                if (ppl1[pointer1].X == ppl2[pointer2].X)
                {
                    ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y - ppl2[pointer2].Y);
                    pointer1++;
                    pointer2++;
                }
                else if (ppl1[pointer1].X < ppl2[pointer2].X)
                {
                    ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y);
                    pointer1++;
                }
                else
                {
                    ppl.Add(ppl2[pointer2].X, ppl2[pointer2].Y);
                    pointer2++;
                }
            }

            while (pointer1 != ppl1.Count)
            {
                ppl.Add(ppl1[pointer1].X, ppl1[pointer1].Y);
                pointer1++;
            }

            while (pointer2 != ppl2.Count)
            {
                ppl.Add(ppl2[pointer2].X, ppl2[pointer2].Y);
                pointer2++;
            }

            return ppl;
        }

        public static void Shift(CurveItem ci, double c)
        {
            for (var i = 0; i < ci.Points.Count; i++)
            {
                ci.Points[i].Y += c;
            }
        }

        public static void Shift(PointPairList ppl, double c)
        {
            foreach (var pp in ppl)
            {
                pp.Y += c;
            }
        }

        public static void AntiShift(CurveItem ci)
        {
            var ppl = new PointPairList();
            for (var i = 0; i < ci.Points.Count; i++)
            {
                ppl.Add(ci.Points[i].X, ci.Points[i].Y);
            }

            var average = Analyzer.Analyzer.GetAverageOnRange(ppl);
            Shift(ci, -average);
        }

        public static void AntiShift(PointPairList ppl)
        {
            var average = Analyzer.Analyzer.GetAverageOnRange(ppl);
            Shift(ppl, -average);
        }

        public static void AddSpike(CurveItem ci, int pos, double value)
        {
            if (pos < 0 || pos >= ci.Points.Count)
            {
                throw new ArgumentException();
            }

            ci.Points[pos].Y += value;
        }

        public static void AddSpike(PointPairList ppl, int pos, double value)
        {
            if (pos < 0 || pos >= ppl.Count)
            {
                throw new ArgumentException();
            }

            ppl[pos].Y += value;
        }

        public static void AddRandomSpikes(PointPairList ppl, double min, double max, double count, Random rnd)
        {
            while (count-- > 0)
            {
                var i = rnd.Next(0, ppl.Count);
                var value = rnd.NextDouble() * (max - min) + min;
                var sign = rnd.Next(0, 2);
                ppl[i].Y += sign > 0 ? value : -value;
            }
        }

        public static void AddRandomSpikes(CurveItem ci, double min, double max, int count, Random rnd)
        {
            // ReSharper disable once PossibleLossOfFraction
            if (ci.Points.Count / 100 < count)
                // ReSharper disable once PossibleLossOfFraction
                count = ci.Points.Count / 100;

            var nums = Enumerable.Range(0, ci.Points.Count).ToList();
            while (count-- > 0)
            {
                var tmp = rnd.Next(0, nums.Count);
                var i = nums[tmp];
                nums.RemoveAt(tmp);

                var value = rnd.NextDouble() * (max - min) + min;
                var sign = rnd.Next(0, 2);
                ci.Points[i].Y += sign > 0 ? value : -value;
            }
        }

        public static void RemoveSpikes(CurveItem ci, double s)
        {
            for (var i = 0; i < ci.Points.Count; i++)
            {
                if (!(Math.Abs(ci.Points[i].Y) > 2 * s)) continue;

                var max = i;
                for (var j = i + 1; j < ci.Points.Count; j++)
                {
                    if (Math.Abs(ci.Points[j].Y) < 2 * s) break;

                    max = j;
                }

                if (i == 0 || max == ci.Points.Count - 1)
                {
                    for (var j = i; j <= max; j++)
                    {
                        ci.RemovePoint(j);
                        j--;
                        max--;
                    }
                }
                else
                {
                    var average = (ci.Points[i - 1].Y + ci.Points[max + 1].Y) / 2;
                    for (var j = i; j <= max; j++)
                    {
                        ci.Points[j].Y = average;
                    }

                    i += max - i;
                }
            }
        }

        public static PointPairList AntiNoise(PointPairList ppl, int windowSize)
        {
            var output = new PointPairList();
            var n = ppl.Count - windowSize;

            for (var i = 1; i <= windowSize; i += 2)
            {
                var avrg = Analyzer.Analyzer.GetAverageOnRange(ppl, 0, i);
                output.Add(ppl[i / 2].X, avrg);
            }

            for (var i = 0; i < n; i++)
            {
                var avrg = Analyzer.Analyzer.GetAverageOnRange(ppl, i, i + windowSize);
                output.Add(ppl[(i + i + windowSize) / 2].X, avrg);
            }

            for (var i = windowSize; i >= 1; i -= 2)
            {
                var avrg = Analyzer.Analyzer.GetAverageOnRange(ppl, ppl.Count - i - 1, ppl.Count - 1);
                output.Add(ppl[(ppl.Count - i + ppl.Count - 2) / 2].X, avrg);
            }

            return output;
        }

        public static PointPairList AntiTrend(PointPairList ppl, int windowSize)
        {
            var withoutNoise = AntiNoise(ppl, windowSize);
            return SubtractGraphs(ppl, withoutNoise);
        }

        //Potter
        public static PointPairList GetLPPotter(double fc, int m, double dt)
        {
            //1st step
            var w = new PointPairList();
            var fact = 2.0 * fc * dt;
            w.Add(0, fact);
            fact *= Math.PI;
            for (var i = 1; i <= m; i++)
                w.Add(i, Math.Sin(fact * i) / (Math.PI * i));

            //2nd step
            w[m].Y /= 2;

            //3rd step
            var d = new[] { 0.35577019, 0.2436983, 0.07211497, 0.00630164 };
            var sumg = w[0].Y;
            for (var i = 1; i <= m; i++)
            {
                var sum = d[0];
                fact = Math.PI * i / m;
                for (var k = 1; k <= 3; k++)
                    sum += 2.0 * d[k] * Math.Cos(fact * k);

                w[i].Y *= sum;
                sumg += 2.0 * w[i].Y;
            }

            for (var i = 0; i <= m; i++)
                w[i].Y /= sumg;

            //4th step
            for (var i = 1; i <= m; i++)
                w.Add(i + m, w[i].Y);

            var middle = m / 2;
            for (var i = 0; i < middle; i++)
            {
                var tmp = w[m - i];
                w[m - i] = w[i];
                w[i] = tmp;
            }

            for (var i = 0; i <= 2 * m; i++)
                w[i].X = i * dt;

            return w;
        }

        public static PointPairList GetHPPotter(double fc, int m, double dt)
        {
            var wh = GetLPPotter(fc, m, dt);
            for (var i = 0; i <= 2 * m; i++)
            {
                if (i == m)
                    wh[i].Y = 1.0 - wh[i].Y;
                else
                    wh[i].Y = -wh[i].Y;
            }

            return wh;
        }

        public static PointPairList GetBPPotter(double fc1, double fc2, int m, double dt)
        {
            var lpw1 = GetLPPotter(fc1, m, dt);
            var lpw2 = GetLPPotter(fc2, m, dt);

            for (var i = 0; i <= 2 * m; i++)
                lpw2[i].Y -= lpw1[i].Y;

            return lpw2;
        }

        public static PointPairList GetBSPotter(double fc1, double fc2, int m, double dt)
        {
            var lpw1 = GetLPPotter(fc1, m, dt);
            var lpw2 = GetLPPotter(fc2, m, dt);

            for (var i = 0; i <= 2 * m; i++)
            {
                if (i == m)
                    lpw1[i].Y += 1.0 - lpw2[i].Y;
                else
                    lpw1[i].Y -= lpw2[i].Y;
            }

            return lpw1;
        }

        public static PointPairList GetGraphFromSpectre(PointPairList input)
        {
            var res = new PointPairList();
            var fs = new List<int> {8000, 11025, 22050, 44100, 48000};

            var ff = 144000;

            foreach (var f in fs)
            {
                if (input[input.Count - 1].X * 2 < f)
                { 
                    ff = f;
                    break;
                }
            }

            foreach (var point in input)
            {
                var gp = new GraphParamsEquation {MinCoordinate = 0, MaxCoordinate = 0.5, Delta = 1.0 / ff};
                gp.AddParameter("A", point.Y * 2);
                gp.AddParameter("f", point.X);

                var s = GraphCreator.GetSin(gp);
                res = SumGraphs(res, s);
            }

            return res;
        }

        public static PointPairList GetDerivative(PointPairList input)
        {
            var ppl = new PointPairList();

            for (var i = 1; i < input.Count; i++)
            {
                ppl.Add(i, input[i].Y - input[i - 1].Y);
            }

            return ppl;
        }

        public static PointPairList GetDeconvolution(PointPairList input, PointPairList kernel)
        {
            if (kernel.Count < input.Count)
                for (var i = kernel.Count; i < input.Count; i++)
                    kernel.Add(i, 0);
            return GetDeconvolution(input, Analyzer.Analyzer.GetComplexSpectre(kernel, false));
        }

        public static PointPairList GetDeconvolution(PointPairList input, List<Complex> kernelSpectre)
        {
            var spectre = Analyzer.Analyzer.GetComplexSpectre(input, false);
            var dividedRow = spectre.Select((t, i) => t / kernelSpectre[i]).ToList();
            var reversedRow = Analyzer.Analyzer.GetReverseComplexSpectre(dividedRow);
            return Analyzer.Analyzer.GetPplFromRealPartOfComplex(reversedRow);
        }

        public static PointPairList GetNoiseDeconvolution(PointPairList input, PointPairList kernel, double alpha)
        {
            if (kernel.Count < input.Count)
                for (var i = kernel.Count; i < input.Count; i++)
                    kernel.Add(i, 0);

            var kernelSpectre = Analyzer.Analyzer.GetComplexSpectre(kernel);
            return GetNoiseDeconvolution(input, kernelSpectre, alpha);
        }

        public static PointPairList GetNoiseDeconvolution(PointPairList input, List<Complex> kernelSpectre, double alpha)
        {
            var spectre = Analyzer.Analyzer.GetComplexSpectre(input);
            var dividedRow = spectre.Select((g, i) => g * Complex.Conjugate(kernelSpectre[i]) / (Complex.Pow(Complex.Abs(kernelSpectre[i]), 2) + alpha * alpha)).ToList();
            var reversedRow = Analyzer.Analyzer.GetReverseComplexSpectre(dividedRow);
            var tmp = Analyzer.Analyzer.GetPplFromRealPartOfComplex(reversedRow);
            return tmp;
        }
    }
}
