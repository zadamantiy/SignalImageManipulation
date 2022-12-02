using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using ZedGraph;

namespace SuLibrary.Analyzer
{
    public static class Analyzer
    {
        public static void GetIndicesByRangeInSortedPointPairList(PointPairList ppl, double minX, double maxX, out int minI,
            out int maxI)
        {
            int l = -1, r = ppl.Count;
            while (r - l > 1)
            {
                var m = (r + l) / 2;
                if (ppl[m].X >= minX)
                    r = m;
                else
                    l = m;
            }

            minI = r;

            l = -1;
            r = ppl.Count;
            while (r - l > 1)
            {
                var m = (r + l) / 2;
                if (ppl[m].X <= maxX)
                    l = m;
                else
                    r = m;
            }

            maxI = l;

            if (minI <= maxI) return;

            minI = -1;
            maxI = -1;
        }

        public static double GetMaxOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var max = double.MinValue;
            for (var i = minI; i <= maxI; i++)
            {
                var dot = ppl[i];
                if (max < dot.Y)
                {
                    max = dot.Y;
                }
            }

            return max;
        }

        public static double GetMinOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var min = double.MaxValue;
            for (var i = minI; i <= maxI; i++)
            {
                var dot = ppl[i];
                if (min > dot.Y)
                {
                    min = dot.Y;
                }
            }

            return min;
        }

        public static double GetAverageOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += ppl[i].Y;
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetDispersionOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);
            return GetDispersionOnRange(ppl, average, minI, maxI);
        }

        public static double GetDispersionOnRange(PointPairList ppl, double average, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 2);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetSigmaOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);
            return Math.Sqrt(GetDispersionOnRange(ppl, average, minI, maxI));
        }

        public static double GetSigmaByDispersion(double dispersion)
        {
            return Math.Sqrt(dispersion);
        }

        public static double GetMeanSquare(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y, 2);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetRootMeanSquare(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            return Math.Sqrt(GetMeanSquare(ppl, minI, maxI));
        }

        public static double GetRootMeanSquare(double meanSquare)
        {
            return Math.Sqrt(meanSquare);
        }

        public static double GetAsymmetryMoment(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);

            var sum = 0.0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 3);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetAsymmetryCoefficient(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            return GetAsymmetryMoment(ppl, minI, maxI) / Math.Pow(GetSigmaOnRange(ppl, minI, maxI), 3);
        }

        public static double GetExcess(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);

            var sum = 0.0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 4);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetKurtosis(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var excess = GetExcess(ppl, minI, maxI);
            var sigma = GetSigmaOnRange(ppl, minI, maxI);

            return excess / Math.Pow(sigma, 4) - 3;
        }

        public static double GetPercentDiff(double a, double b, double min, double max)
        {
            if (b > a)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            return Math.Abs((a - b) / (max - min) * 100);
            //return Math.Abs((a - b) / ((a + b) / 2)) * 100;
        }

        public static Characteristics GetAllCharacteristics(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            var chars = new Characteristics
            {
                Min = GetMinOnRange(ppl, minI, maxI),
                Max = GetMaxOnRange(ppl, minI, maxI),
                Average = GetAverageOnRange(ppl, minI, maxI),
                Dispersion = GetDispersionOnRange(ppl, minI, maxI),
                MeanSquare = GetMeanSquare(ppl, minI, maxI),
                AsymmetryMoment = GetAsymmetryMoment(ppl, minI, maxI),
                AsymmetryCoefficient = GetAsymmetryCoefficient(ppl, minI, maxI),
                Excess = GetExcess(ppl, minI, maxI),
                Kurtosis = GetKurtosis(ppl, minI, maxI),
            };

            chars.Sigma = GetSigmaByDispersion(chars.Dispersion);
            chars.RootMeanSquare = GetRootMeanSquare(chars.MeanSquare);

            return chars;
        }

        public static PointPairList GetDistribution(PointPairList ppl, double fromY, double toY, int partAmount = 100)
        {
            //ppl.Sort();
            var res = new PointPairList();

            var partSize = (toY - fromY) / partAmount;
            var parts = new List<int>(partAmount);
            parts.AddRange(Enumerable.Repeat(0, partAmount));

            foreach (var point in ppl)
            {
                parts[Math.Min((int) ((point.Y - fromY) / partSize), parts.Count - 1)]++;
            }

            for (var i = 0; i < parts.Count; i++)
            {
                res.Add(fromY + partSize * i, parts[i]);
            }

            return res;
        }

        private static double GetRxxL(PointPairList ppl, int l)
        {
            var ans = 0.0;
            var upBorder = ppl.Count - l;
            for (var i = 0; i < upBorder; i++)
            {
                ans += ppl[i].Y * ppl[i + l].Y;
            }

            return ans / ppl.Count;
        }

        private static double GetRxyL(PointPairList ppl, PointPairList ppl2, int l)
        {
            var ans = 0.0;
            var upBorder = Math.Min(ppl.Count - l, ppl2.Count - l);
            for (var i = 0; i < upBorder; i++)
            {
                ans += ppl[i].Y * ppl2[i + l].Y;
            }

            return ans / ppl.Count;
        }

        public static PointPairList GetRxx(PointPairList ppl)
        {
            var ans = new PointPairList();
            for (var i = 0; i < ppl.Count; i++)
            {
                ans.Add(i, GetRxxL(ppl, i));
            }
            return ans;
        }

        public static PointPairList GetRxy(PointPairList ppl, PointPairList ppl2)
        {
            var ans = new PointPairList();
            for (var i = 0; i < ppl.Count; i++)
            {
                ans.Add(i, GetRxyL(ppl, ppl2, i));
            }
            return ans;
        }

        public static PointPairList GetRe(PointPairList ppl, bool norm = true)
        {
            var res = new PointPairList();
            for (var n = 0; n < ppl.Count; n++)
            {
                var sum = ppl.Select((t, k) => t.Y * Math.Cos(2.0 * Math.PI * n * k / ppl.Count)).Sum();
                if (norm)
                    sum /= ppl.Count;
                
                res.Add(n, sum);
            }

            return res;
        }

        public static PointPairList GetIm(PointPairList ppl, bool norm = true)
        {
            var res = new PointPairList();
            for (var n = 0; n < ppl.Count; n++)
            {
                var sum = ppl.Select((t, k) => t.Y * Math.Sin(2.0 * Math.PI * n * k / ppl.Count)).Sum();
                if (norm)
                    sum /= ppl.Count;

                res.Add(n, sum);
            }

            return res;
        }

        public static double GetDf(PointPairList ppl)
        {
            var dt = ppl[1].X - ppl[0].X;
            return 1.0 / dt / ppl.Count;
        }

        public static PointPairList GetSpectre(PointPairList ppl, bool norm = true)
        {
            var res = new PointPairList();
            var im = GetIm(ppl, norm);
            var re = GetRe(ppl, norm);
            var df = GetDf(ppl);
            
            for (var i = 0; i < im.Count; i++)
            {
                res.Add(i * df, Math.Sqrt(re[i].Y * re[i].Y + im[i].Y * im[i].Y));
            }

            return res;
        }

        public static PointPairList GetSpectreV3(PointPairList ppl, bool norm = true)
        {
            var res = new PointPairList();

            //var spectre = GetReverseComplexSpectre(GetComplexSpectre(ppl, norm));
            //var df = ppl[1].X - ppl[0].X;
            //for (var i = 0; i < spectre.Count; i++)
            //    res.Add(i * df, spectre[i].Real);

            var spectre = GetComplexSpectre(ppl, norm);
            var df = GetDf(ppl);
            for (var i = 0; i < spectre.Count; i++)
                res.Add(i * df, Math.Sqrt(spectre[i].Real * spectre[i].Real + spectre[i].Imaginary * spectre[i].Imaginary));
            
            return res;
        }

        public static List<Complex> GetComplexSpectre(List<Complex> inputComplexes, bool norm = true)
        {
            var spectre = new List<Complex>(inputComplexes.Count);
            for(var k = 0; k < inputComplexes.Count; k++)
            { 
                var sum = Complex.Zero;
                for (var n = 0; n < inputComplexes.Count; n++)
                    sum += inputComplexes[n] * Complex.Exp(-Complex.ImaginaryOne * 2 * Math.PI / inputComplexes.Count * k * n);
                spectre.Add(norm ? sum / inputComplexes.Count : sum);
            }
            return spectre;
        }

        public static List<Complex> GetReverseComplexSpectre(List<Complex> x)
        {
            var res = new List<Complex>();
            for (var k = 0; k < x.Count; k++)
            {
                var sum = Complex.Zero;
                for (var n = 0; n < x.Count; n++)
                    sum += x[n] * Complex.Exp(Complex.ImaginaryOne * 2 * Math.PI / x.Count * k * n);

                res.Add(sum);
            }

            return res;
        }

        public static List<Complex> GetComplexSpectre(PointPairList ppl, bool norm = true)
        {
            return GetComplexSpectre(ppl.Select(point => new Complex(point.Y, 0)).ToList(), norm);
        }

        public static PointPairList GetPplFromRealPartOfComplex(List<Complex> input)
        {
            var res = new PointPairList();
            for (var i = 0; i < input.Count; i++)
                res.Add(i, input[i].Real);
            return res;
        }
    }
}
