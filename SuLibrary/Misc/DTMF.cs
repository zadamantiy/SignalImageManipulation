using System;
using System.Collections.Generic;
using System.Linq;
using ZedGraph;

namespace SuLibrary.Misc
{
    public static class DTMF
    {
        private static readonly Dictionary<char, Tuple<double, double>> CharToFreq = new Dictionary<char, Tuple<double, double>>()
        {
            {'1', new Tuple<double, double>(697, 1209)},
            {'2', new Tuple<double, double>(697, 1336)},
            {'3', new Tuple<double, double>(697, 1477)},
            {'A', new Tuple<double, double>(697, 1633)},

            {'4', new Tuple<double, double>(770, 1209)},
            {'5', new Tuple<double, double>(770, 1336)},
            {'6', new Tuple<double, double>(770, 1477)},
            {'B', new Tuple<double, double>(770, 1633)},

            {'7', new Tuple<double, double>(852, 1209)},
            {'8', new Tuple<double, double>(852, 1336)},
            {'9', new Tuple<double, double>(852, 1477)},
            {'C', new Tuple<double, double>(852, 1633)},

            {'*', new Tuple<double, double>(941, 1209)},
            {'0', new Tuple<double, double>(941, 1336)},
            {'#', new Tuple<double, double>(941, 1477)},
            {'D', new Tuple<double, double>(941, 1633)},
        };

        private static readonly Dictionary<double, Dictionary<double, char>> FreqToChar = new Dictionary<double, Dictionary<double, char>>()
        {
            {697, new Dictionary<double, char>(){ {1209,  '1'}, {1336,  '2'}, {1477,  '3'}, {1633,  'A'}}},
            {770, new Dictionary<double, char>(){ {1209,  '4'}, {1336,  '5'}, {1477,  '6'}, {1633,  'B'}}},
            {852, new Dictionary<double, char>(){ {1209,  '7'}, {1336,  '8'}, {1477,  '9'}, {1633,  'C'}}},
            {941, new Dictionary<double, char>(){ {1209,  '*'}, {1336,  '0'}, {1477,  '#'}, {1633,  'D'}}}
        };

        private static readonly double[] Frequencies = {697.0, 770.0, 852.0, 941.0, 1209.0, 1336.0, 1477.0, 1633.0};

        public static bool CheckChar(char c)
        {
            return CharToFreq.ContainsKey(c);
        }

        public static PointPairList GenerateSound(List<Pair<char, double>> s, double dT)
        {
            var res = new PointPairList();
            const double a = 0.185;

            var finish = 0.0;
            var t = 0.0;
            foreach (var c in s)
            {
                finish += c.Second;
                if (c.First == 'p')
                {
                    while (t < finish)
                    {
                        res.Add(t, 0);
                        t += dT;
                    }
                }
                else
                {
                    if (!CharToFreq.ContainsKey(c.First))
                        continue;

                        var (f1, f2) = CharToFreq[c.First];
                    while (t < finish)
                    { 
                        res.Add(t, a * Math.Sin(2 * Math.PI * f1 * t) + a * Math.Sin(2 * Math.PI * f2 * t));
                        t += dT;
                    }
                }
            }

            return res;
        }

        private static double CalculateGoertzel(PointPairList samples, int start, int count, double frequency, int sampleRate)
        {
            var k = 2.0 * Math.Cos(2.0 * Math.PI * frequency * count / sampleRate / count);
            var q1 = 0.0;
            var q2 = 0.0;

            for (var i = start; i < start + count; i++)
            {
                var q0 = k * q1 - q2 + samples[i].Y;
                q2 = q1;
                q1 = q0;
            }

            return Math.Sqrt(q1 * q1 + q2 * q2 - q1 * q2 * k);
        }

        public static List<Pair<char, double>> DetectDtmf(PointPairList ppl)
        {
            var res = new List<Pair<char, double>>();

            var dT = ppl[1].X - ppl[0].X;
            var sampleRate = (int) (1.0 / dT);

            const double adjustmentFactor = 1.6;

            var sampleSize = (int) (0.04 / dT);
            var start = 0.0;

            for (var i = 0; i < ppl.Count - sampleSize; i += sampleSize / 2)
            {
                var powers = Frequencies.Select(f => new
                {
                    Frequency = f,
                    Power = CalculateGoertzel(ppl, i, sampleSize, f, sampleRate)
                }).OrderByDescending(x => x.Power).ToList();

                var adjustedMeanPower = adjustmentFactor * powers.Average(x => x.Power);
                var highestPowers = powers.Take(2).OrderBy(x => x.Frequency).ToList();
                //var adjustedMeanPower = adjustmentFactor * powers.OrderBy(x => x.Power).Take(6).Average(x => x.Power);
                var c = highestPowers[0].Frequency < 1000 && highestPowers[1].Frequency > 1000 &&
                            highestPowers.All(x => x.Power > adjustedMeanPower)
                    ? FreqToChar[highestPowers[0].Frequency][highestPowers[1].Frequency]
                    : 'p';

                if (res.Count == 0)
                {
                    res.Add(new Pair<char, double>(c, 0.04));
                }
                else if (res[res.Count - 1].First != c)
                {
                    res[res.Count - 1].Second = (i - 1) * dT - start;
                    start = (i - 1) * dT;
                    res.Add(new Pair<char, double>(c, 0.04));
                }
            }

            res[res.Count - 1].Second = (ppl.Count - sampleSize / 2 - 1) * dT - start;

            return res;
        }
    }
}
