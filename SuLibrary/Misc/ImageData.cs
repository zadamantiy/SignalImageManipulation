using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization.Configuration;
using SuLibrary.Graph;
using ZedGraph;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace SuLibrary.Misc
{
    public enum DataRotate
    {
        Left,
        Right,
        Degree180
    }

    public class ImageData
    {
        public int ColorDepth
        {
            get => _colorDepth;
            set => _colorDepth = _colorDepth > 8 ? 8 : value;
        }
        private int _colorDepth;
        private Random _rnd = new Random();

        public List<PointPairList> Data { get; set; }

        public ImageData()
        {
            Data = new List<PointPairList>();
            _colorDepth = 8;
        }

        public ImageData(int colorDepth)
        {
            Data = new List<PointPairList>();
            _colorDepth = colorDepth;
        }

        public void ReloadAsBitmap()
        {
            var bmp = GetBitmap();
            Data.Clear();
            LoadBitmap(bmp);
        }

        public void LoadImage(string path)
        {
            Data.Clear();
            LoadBitmap(Image.FromFile(path) as Bitmap);
        }

        public void LoadBitmap(Bitmap bmp)
        {
            var dirBmp = new DirectBitmap(bmp.Width, bmp.Height);
            dirBmp.Bitmap.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            //TODO: Think about it
            using (var g = Graphics.FromImage(dirBmp.Bitmap))
            {
                g.DrawImage(bmp, new Point(0, 0));
            }

            for (var i = 0; i < dirBmp.Height; i++)
            {
                var ppl = new PointPairList();
                for (var j = 0; j < dirBmp.Width; j++)
                {
                    var clr = dirBmp.GetPixel(j, i);
                    // ReSharper disable once PossibleLossOfFraction
                    ppl.Add(j, (clr.R + clr.G + clr.B) / 3);
                }

                Data.Add(ppl);
            }
        }

        public void LoadDat(string path, int h = 221, int w = 307)
        {
            if (!File.Exists(path)) 
                return;

            Data.Clear();

            using (var reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                for (var i = 0; i < h; i++)
                {
                    var ppl = new PointPairList();
                    for (var j = 0; j < w; j++)
                        ppl.Add(j, reader.ReadSingle());
                    Data.Add(ppl);
                }
            }

            Data.Reverse();
        }

        public double GetMin()
        {
            return Data.AsParallel().Min(row => row.Min(v => v.Y));
        }

        public double GetMax()
        {
            return Data.AsParallel().Max(row => row.Max(v => v.Y));
        }

        public Bitmap GetBitmap(bool forceColorChange = false)
        {
            if (Data.Count == 0 || Data[0].Count == 0)
                return new Bitmap(1, 1);

            var colors = (int) Math.Pow(2, ColorDepth) - 1;
            if (colors > 255)
                colors = 255;

            var dirBmp = new DirectBitmap(Data[0].Count, Data.Count);

            double xMin = GetMin(), xMax = GetMax();

            if (forceColorChange || xMin < 0 || xMax > colors)
            { 
                for (var i = 0; i < dirBmp.Height; i++)
                {
                    for (var j = 0; j < dirBmp.Width; j++)
                    {
                        var value = (int) (255 * (Data[i][j].Y - xMin) / (xMax - xMin)); //0..255
                        value = (int) Math.Round(colors * (double) value / 255); //0..3
                        value = (int) Math.Round(255 * (double) value / colors); //0..255
                        dirBmp.SetPixel(j, i, Color.FromArgb(value, value, value));
                    }
                }
            }
            else
            {
                for (var i = 0; i < dirBmp.Height; i++)
                {
                    for (var j = 0; j < dirBmp.Width; j++)
                    {
                        var value = (int) Data[i][j].Y;
                        dirBmp.SetPixel(j, i, Color.FromArgb(value, value, value));
                    }
                }
            }

            return dirBmp.Bitmap;
        }

        public void LoadXCR(string path)
        {
            Data.Clear();
            if (!File.Exists(path)) return;

            using (var reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                reader.BaseStream.Position += 608;

                //Reading horizontal size
                var hSize = 0;
                for (var i = 0; i < 16; i++)
                {
                    var b = reader.ReadByte();
                    if (b != 0x00)
                        hSize = hSize * 10 + b - 0x30;
                }

                //Reading vertical size
                var vSize = 0;
                for (var i = 0; i < 16; i++)
                {
                    var b = reader.ReadByte();
                    if (b != 0x00)
                        vSize = vSize * 10 + b - 0x30;
                }

                reader.BaseStream.Position += 1408;

                for (var i = 0; i < hSize; i++)
                {
                    var ppl = new PointPairList();
                    for (var j = 0; j < vSize; j++)
                    {
                        var b = reader.ReadByte();
                        byte[] bytes = {reader.ReadByte(), b, 0, 0};
                        var data = BitConverter.ToInt32(bytes, 0);
                        ppl.Add(j, data);
                    }
                    Data.Add(ppl);
                }
            }
        }

        public void LoadBin(string path)
        {
            Data.Clear();
            if (!File.Exists(path)) return;

            using (var reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                var res = path.Substring(path.Length - 7, 3);
                var size = Convert.ToInt32(res);

                for (var i = 0; i < size; i++)
                {
                    var ppl = new PointPairList();
                    for (var j = 0; j < size; j++)
                    {
                        var b = reader.ReadByte();
                        byte[] bytes = { b, reader.ReadByte(),  0, 0 };
                        var data = BitConverter.ToInt32(bytes, 0);
                        ppl.Add(j, data);
                    }
                    Data.Add(ppl);
                }
            }
        }

        public void Shift(double value)
        {
            foreach (var row in Data)
                GraphManipulator.Shift(row, value);
        }

        public void NearestNeighbourResize(double multiplier)
        {
            var newHeight = (int) Math.Round(Data.Count * multiplier);
            var newWidth = (int) Math.Round(Data[0].Count * multiplier);

            if (newHeight == 0 || newWidth == 0)
                return;

            var newData = new List<PointPairList>(newHeight);

            for (var i = 0; i < newHeight; i++)
            {
                newData.Add(new PointPairList());

                var closestY = (int) (i / multiplier);

                for (var j = 0; j < newWidth; j++)
                {
                    var closestX = (int) (j / multiplier);
                    newData[i].Add(Data[closestY][closestX]);
                }
            }

            Data = newData;
        }

        public void BilinearInterpolationResize(double multiplier)
        {
            var newHeight = (int) Math.Round(Data.Count * multiplier);
            var newWidth = (int) Math.Round(Data[0].Count * multiplier);

            if (newHeight == 0 || newWidth == 0)
                return;

            var newData = new List<PointPairList>(newHeight);

            //Extrapolation
            foreach (var ppl in Data)
                ppl.Add(ppl[ppl.Count - 1]);
            Data.Add(Data[Data.Count - 1]);

            for (var i = 0; i < newHeight; i++)
            {
                newData.Add(new PointPairList());

                var newY = i / multiplier;
                var lowClosestY = (int)Math.Floor(newY);
                var highClosestY = lowClosestY + 1;
                
                for (var j = 0; j < newWidth; j++)
                {
                    var newX = j / multiplier;
                    var lowClosestX = (int)Math.Floor(newX);
                    var highClosestX = lowClosestX + 1; 

                    var x1_y = (highClosestX - newX) * Data[lowClosestY][lowClosestX].Y
                                  + (newX - lowClosestX) * Data[lowClosestY][highClosestX].Y;

                    var x2_y = (highClosestX - newX) * Data[highClosestY][lowClosestX].Y
                               + (newX - lowClosestX) * Data[highClosestY][highClosestX].Y;

                    var pp = new PointPair(j, (highClosestY - newY) * x1_y + (newY - lowClosestY) * x2_y);
                    
                    newData[i].Add(pp);
                }
            }

            Data = newData;
        }

        public void Rotate(DataRotate r = DataRotate.Right)
        {
            int newHeight;
            int newWidth;
            List<PointPairList> newData;
            switch (r)
            {
                case DataRotate.Right:
                    newHeight = Data[0].Count;
                    newData = new List<PointPairList>(newHeight);
                    for (var i = 0; i < newHeight; i++)
                    {
                        var ppl = new PointPairList();
                        for (var j = Data.Count - 1; j >= 0; j--)
                        {
                            ppl.Add(Data.Count - 1 - j, Data[j][i].Y);
                        }
                        newData.Add(ppl);
                    }
                    Data = newData;
                    break;
                case DataRotate.Degree180:
                    newHeight = Data[0].Count;
                    newData = new List<PointPairList>(newHeight);
                    for (var j = Data.Count - 1; j >= 0; j--)
                    {
                        var ppl = new PointPairList();
                        for (var i = newHeight - 1; i >= 0; i--)
                        {
                            ppl.Add(newHeight - 1 - j, Data[j][i].Y);
                        }
                        newData.Add(ppl);
                    }
                    Data = newData;
                    break;
                case DataRotate.Left:
                    newHeight = Data[0].Count;
                    newWidth = Data.Count;
                    newData = new List<PointPairList>(newHeight);
                    for (var i = newHeight - 1; i >= 0; i--)
                    {
                        var ppl = new PointPairList();
                        for (var j = 0; j < newWidth; j++)
                        {
                            ppl.Add(j, Data[j][i].Y);
                        }
                        newData.Add(ppl);
                    }
                    Data = newData;
                    break;
            }
        }

        public void SubtractImage(string path)
        {
            var img2 = new ImageData();
            if (path.EndsWith("xcr"))
                img2.LoadXCR(path);
            if (path.EndsWith("dat"))
                img2.LoadDat(path);
            if (path.EndsWith("bin"))
                img2.LoadBin(path);
            else
                img2.LoadImage(path);

            var width = img2.Data[0].Count;
            for (var i = 0; i < img2.Data.Count; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y -= img2.Data[i][j].Y;
                    //Data[i][j].Y = Math.Abs(Data[i][j].Y);
                }
            }
        }

        public void SumImage(string path, bool lessWhenMax = true)
        {
            var img2 = new ImageData();
            if (path.EndsWith("xcr"))
                img2.LoadXCR(path);
            if (path.EndsWith("dat"))
                img2.LoadDat(path);
            if (path.EndsWith("bin"))
                img2.LoadBin(path);
            else
                img2.LoadImage(path);

            var mx = GetMax();
            if (mx < 255)
                mx = 255;

            var width = img2.Data[0].Count;
            for (var i = 0; i < img2.Data.Count; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y += img2.Data[i][j].Y;
                    if (!lessWhenMax)
                    {
                        if (Data[i][j].Y > mx)
                            Data[i][j].Y = mx;
                        else if (Data[i][j].Y < 0)
                            Data[i][j].Y = 0;
                    }
                    
                }
            }
        }

        public void ApplyNegative()
        {
            var min = GetMin();
            var max = GetMax();

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = max - (Data[i][j].Y - min);
                }
            }
        }

        public void ApplyLogarithm()
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Log(tmpMax + 1);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = c * Math.Log(Data[i][j].Y + 1 - min) + min;
                }
            }
        }

        public void ApplyInverseLogarithm()
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Log(tmpMax + 1);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = Math.Exp((Data[i][j].Y - min) / c) - 1 + min;
                }
            }
        }

        public void ApplyPower(double power)
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Pow(tmpMax, power);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = c * Math.Pow(Data[i][j].Y - min, power) + min;
                }
            }
        }

        public int[] GetHistogram()
        {
            var min = GetMin();
            var max = GetMax();
            var nBins = (int)max - (int)min + 1;
            return GetHistogram(nBins, min);
        }

        public int[] GetHistogram(int preCalcNBins, double preCalcMin)
        {
            var hist = new int[preCalcNBins];
            var width = Data[0].Count;
            var height = Data.Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    hist[(int)(Data[i][j].Y - preCalcMin)]++;
                }
            }

            return hist;
        }

        private int[] GetEqualizeGonzalez()
        {
            var min = GetMin();
            var max = GetMax();
            var nBins = (int)max - (int)min + 1;


            var width = Data[0].Count;
            var height = Data.Count;

            var total = width * height;

            var hist = GetHistogram(nBins, min);

            var scale = (nBins - 1.0) / total;
            var lut = new int[nBins];

            var sum = 0;
            for (var histPointer = 0; histPointer < hist.Length; histPointer++)
            {
                sum += hist[histPointer];
                lut[histPointer] = (int)(Math.Max(0, Math.Min((int)Math.Round(sum * scale), max - min)) + min);
            }

            return lut;
        }

        public int[] GetEqualizeMine()
        {
            var min = GetMin();
            var max = GetMax();
            var nBins = (int)max - (int)min + 1;

            var width = Data[0].Count;
            var height = Data.Count;

            var total = width * height;

            var hist = GetHistogram(nBins, min);

            var histPointer = 0;
            while (hist[histPointer] == 0)
                ++histPointer;

            var scale = (nBins - 1.0) / (total - hist[histPointer]);
            var lut = new int[nBins];
            histPointer++;

            var sum = 0;
            for (var i = 0; i < histPointer; i++)
                lut[i] = (int)min;

            for (; histPointer < hist.Length; histPointer++)
            {
                sum += hist[histPointer];
                lut[histPointer] = (int)(Math.Max(0, Math.Min((int)Math.Round(sum * scale), max - min)) + min);
            }

            return lut;
        }

        public int[] EqualizeHistogram()
        {
            var min = GetMin();
            var lut = GetEqualizeGonzalez();
            ApplyFunction(lut, (int)min);
            return lut;
        }

        public int[] EnforceHistogram()
        {
            var min = GetMin();

            var lut = GetEqualizeGonzalez();

            var maxBackLut = GetBackFunc(lut, (int) min);

            ApplyFunction(maxBackLut, (int) min);

            return maxBackLut;
        }

        public void ApplyFunction(int[] func, int min)
        {
            var width = Data[0].Count;
            var height = Data.Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = func[(int)(Data[i][j].Y - min)];
                }
            }
        }

        public void AddSaltAndPepper(double percent)
        {
            var snr = percent / 100;
            var min = GetMin();
            var max = GetMax();
            var snr2 = snr / 2;
            
            foreach (var ppl in Data)
            {
                foreach (var point in ppl)
                {
                    var tmp = _rnd.NextDouble();
                    if (!(tmp <= snr)) 
                        continue;

                    point.Y = tmp <= snr2 ? min : max;
                }
            }
        }

        private double GetMs(List<PointPairList> input)
        {
            var res = 0.0;
            var n = input[0].Count * input.Count;
            foreach (var ppl in input)
            {
                foreach (var point in ppl)
                {
                    res += (point.Y * point.Y) / n;
                }
            }

            return res;
        }

        private double GetMs()
        {
            return GetMs(Data);
        }

        private double GetRms()
        {
            return Math.Sqrt(GetMs());
        }

        public void AddRandomNoise(double percent)
        {
            var a = Math.Sqrt(GetMs() / 100 * percent * 3);
            foreach (var ppl in Data)
                foreach (var point in ppl)
                    point.Y += _rnd.NextDouble() * 2 * a - a;
        }

        public void AddRandomNoiseOld(double percent)
        {
            var rms = GetRms();
            var t = 100 / percent;
            var a = Math.Sqrt(rms / t * rms / t * 3);
            //https://www.wolframalpha.com/input/?i=%28integral+x%5E2+from+0+to+y%29+%2F+y+%3D+783.776

            foreach (var point in Data.SelectMany(ppl => ppl))
            {
                point.Y += _rnd.NextDouble() * 2 * a - a;
            }
        }

        public void MixNoise(double percent)
        {
            var half = percent / 2;
            AddRandomNoiseOld(half);
            AddSaltAndPepper(half);
        }

        public void AvrgFilterOld(int windowSize)
        {
            var halfSize = windowSize / 2;
            var final = -halfSize + windowSize;
            var count = windowSize * windowSize;

            var newData = new List<PointPairList>(Data.Count);

            for (var i = 0; i < Data.Count; i++)
            {
                var newLine = new PointPairList();
                for (var j = 0; j < Data[0].Count; j++)
                {
                    double sum = 0;
                    for (var k = -halfSize; k < final; k++)
                    {
                        for (var l = -halfSize; l < final; l++)
                        {
                            sum += Pixel(i + k, j + l) / count;
                        }
                    }
                    newLine.Add(j, sum);
                }
                newData.Add(newLine);
            }

            Data = newData;
        }

        private double Pixel(int y, int x)
        {
            if (y < 0)
                y = -y - 1;
            else if (y >= Data.Count)
            {
                //var tmp = y - Data.Count + 1;
                //y = Data.Count - tmp;
                y = Data.Count + Data.Count - y - 1;
            }

            if (x < 0)
                x = -x - 1;
            else if (x >= Data[0].Count)
            {
                //var tmp = x - Data[0].Count + 1;
                //x = Data[0].Count - tmp;
                x = Data[0].Count + Data[0].Count - x - 1;
            }

            return Data[y][x].Y;
        }

        public void AverageFilter(int windowSize)
        {
            var halfSize = windowSize / 2;
            var final = -halfSize + windowSize;
            var count = windowSize * windowSize;
            var newData = new List<PointPairList>(Data.Count);
            for (var i = 0; i < Data.Count; i++)
            {
                var newLine = new PointPairList();
                for (var j = 0; j < Data[0].Count; j++)
                {
                    var curArray = new List<double>(count);
                    for (var k = -halfSize; k < final; k++)
                    for (var l = -halfSize; l < final; l++)
                        curArray.Add(Pixel(i + k, j + l));
                    newLine.Add(j, curArray.Average());
                }
                newData.Add(newLine);
            }

            Data = newData;
        }

        public void MedianFilter(int windowSize)
        {
            var halfSize = windowSize / 2;
            var final = -halfSize + windowSize;
            var count = windowSize * windowSize;
            var newData = new List<PointPairList>(Data.Count);
            for (var i = 0; i < Data.Count; i++)
            {
                var newLine = new PointPairList();
                for (var j = 0; j < Data[0].Count; j++)
                {
                    var curArray = new List<double>(count);
                    for (var k = -halfSize; k < final; k++)
                    for (var l = -halfSize; l < final; l++)
                        curArray.Add(Pixel(i + k, j + l));

                    curArray.Sort();

                    var middle = count / 2;
                    newLine.Add(j, count % 2 == 0 ? (curArray[middle] + curArray[middle - 1]) / 2 : curArray[middle]);
                }
                newData.Add(newLine);
            }

            Data = newData;
        }

        private int[] GetBackFunc(int[] input, int min = 0)
        {
            var nBins = input.Length;

            var minBackLut = new int[nBins];
            var maxBackLut = new int[nBins];

            for (var i = 1; i < nBins - 1; i++)
            {
                minBackLut[i] = int.MaxValue;
                maxBackLut[i] = int.MinValue;
            }

            for (var i = 1; i < nBins - 1; i++)
            {
                var value = i + min;

                if (minBackLut[input[i] - min] > value)
                    minBackLut[input[i] - min] = value;

                if (maxBackLut[input[i] - min] < value)
                    maxBackLut[input[i] - min] = value;
            }

            maxBackLut[0] = 0;
            minBackLut[nBins - 1] = input[nBins - 1];
            maxBackLut[nBins - 1] = input[nBins - 1];

            for (var i = 1; i < nBins; i++)
            {
                if (minBackLut[i] == int.MaxValue)
                {
                    var start = i - 1;
                    var finish = nBins - 1;
                    for (var j = i + 1; j < nBins; j++)
                    {
                        if (minBackLut[j] == int.MaxValue)
                            continue;

                        finish = j;
                        break;
                    }

                    var l = finish - start;
                    var d = (double)(minBackLut[finish] - maxBackLut[start]) / l;

                    double curValue = maxBackLut[start];
                    for (var j = i; j < finish; j++)
                    {
                        curValue += d;
                        maxBackLut[j] = (int)Math.Round(curValue);
                    }

                    i = finish;
                }
            }

            return maxBackLut;
        }

        public void AutoFilter()
        {
            var line0 = GraphManipulator.GetDerivative(Data[0]);

            var sum = 0.0;
            var count = 0;

            for (var i = 10; i < Data.Count; i+=10)
            {
                var curLine = GraphManipulator.GetDerivative(Data[i]);
                curLine = Analyzer.Analyzer.GetRxy(line0, curLine);
                curLine = Analyzer.Analyzer.GetSpectre(curLine);
                var curMax = curLine.Count / 4;
                for (var j = curMax + 1; j < curLine.Count / 2; j++)
                {
                    if (curLine[j].Y > curLine[curMax].Y)
                        curMax = j;
                }

                sum += curLine[curMax].X;
                count++;
            }
            sum /= count;

            var y = GraphManipulator.GetBSPotter(sum - 0.015, sum + 0.015, 64, 1);
            var newData = new List<PointPairList>();
            foreach (var ppl in Data)
            {
                var ppl2 = GraphManipulator.GetСonvolution(ppl, y);
                ppl2.RemoveRange(0, 64);
                ppl2.RemoveRange(ppl.Count, ppl2.Count - ppl.Count);
                newData.Add(ppl2);
            }

            Data = newData;
        }

        public ImageData Get2DSpectre()
        {
            var prepIm = Data.Select(ppl => Analyzer.Analyzer.GetIm(ppl)).ToList();
            var finalIm = new List<PointPairList>();
            for (var i = 0; i < prepIm[0].Count; i++)
            {
                var ppl = new PointPairList();
                foreach (var point in prepIm)
                {
                    ppl.Add(point[i]);
                }
                finalIm.Add(Analyzer.Analyzer.GetIm(ppl));
            }

            var prepRe = Data.Select(ppl => Analyzer.Analyzer.GetRe(ppl)).ToList();
            var finalRe = new List<PointPairList>();
            for (var i = 0; i < prepRe[0].Count; i++)
            {
                var ppl = new PointPairList();
                foreach (var point in prepRe)
                {
                    ppl.Add(point[i]);
                }
                finalRe.Add(Analyzer.Analyzer.GetRe(ppl));
            }

            var data = new ImageData {Data = new List<PointPairList>()};
            for (var i = 0; i < finalIm.Count; i++)
            {
                var ppl = new PointPairList();
                for (var j = 0; j < finalIm[0].Count; j++)
                {
                    ppl.Add(j, Math.Sqrt(finalIm[i][j].Y * finalIm[i][j].Y + finalRe[i][j].Y * finalRe[i][j].Y));
                }
                data.Data.Add(ppl);
            }

            return data;
        }

        public ImageData Get2DSpectreV2()
        {
            var cmp = new Complex(-2, 2);
            var t = Complex.ImaginaryOne * -1;

            var data = new ImageData
            {
                Data = new List<PointPairList>()
            };
            for (var i = 0; i < Data.Count; i++)
            {
                var ppl = new PointPairList();
                for (var j = 0; j < Data[0].Count; j++)
                {
                    double ak = 0;
                    double bk = 0;

                    for (var ii = 0; ii < Data.Count; ii++)
                    {
                        for (var jj = 0; jj < Data[0].Count; jj++)
                        {

                            var x = -2.0 * Math.PI * i * ii / Data.Count;
                            var y = -2.0 * Math.PI * j * jj / Data[0].Count;
                            ak += Data[ii][jj].Y * Math.Cos(x + y);
                            bk += Data[ii][jj].Y * Math.Sin(x + y);
                        }
                    }
                    ppl.Add(j, Math.Sqrt(ak * ak + bk * bk));
                }
                data.Data.Add(ppl);
            }

            return data;
        }

        public Complex[,] Get2DComplexSpectre()
        {
            var spectrePre = new Complex[Data.Count, Data[0].Count];
            Parallel.For(0, Data.Count, i =>
            //for(var i = 0; i < Data.Count; i++)
            {
                //var N = Data[i].Count;
                //for (var j = 0; j < N; j++)
                //{
                //    var sum = Complex.Zero;
                //    for (var x = 0; x < N; x++)
                //    {
                //        var cur = Complex.Exp(-1 * Complex.ImaginaryOne * 2 * Math.PI * x * j / N);
                //        cur *= Data[i][x].Y;
                //        sum += cur;
                //    }
                //
                //    sum /= N;
                //    spectrePre[i, j] = sum;
                //}

                var tmp = Analyzer.Analyzer.GetComplexSpectre(Data[i]);
                for (var j = 0; j < Data[i].Count; j++)
                    spectrePre[i, j] = tmp[j];
            }
            );
            //;

            //var spectre = new Complex[Data.Count, Data[0].Count];
            Parallel.For(0, Data[0].Count, i =>
            //for (var i = 0; i < Data[0].Count; i++)
            {
                var N = Data.Count;
                var column = new List<Complex>();
                for (var j = 0; j < N; j++)
                    column.Add(spectrePre[j, i]);
                column = Analyzer.Analyzer.GetComplexSpectre(column);
                for (var j = 0; j < N; j++)
                    spectrePre[j, i] = column[j];

                //for (var j = 0; j < N; j++)
                //{
                //    var sum = Complex.Zero;
                //    for (var x = 0; x < N; x++)
                //    {
                //        var cur = Complex.Exp(-1 * Complex.ImaginaryOne * 2 * Math.PI * x * j / N);
                //        cur *= spectrePre[x, i];
                //        sum += cur;
                //    }
                //
                //    sum /= N;
                //    spectrePre[j, i] = sum;
                //}
            }
            );
            //;

            return spectrePre;
        }

        public Complex[,] Get2DSpectreReverse(Complex[,] input)
        {
            var res = new Complex[input.GetLength(0),input.GetLength(1)];
            Parallel.For(0, input.GetLength(0), i =>
            //for(var i = 0; i < Data.Count; i++)
            {
                //var N = input.GetLength(1);
                //for (var j = 0; j < N; j++)
                //{
                //    var sum = Complex.Zero;
                //    for (var x = 0; x < N; x++)
                //    {
                //        var cur = Complex.Exp(Complex.ImaginaryOne * 2 * Math.PI * x * j / N);
                //        cur *= input[i, x];
                //        sum += cur;
                //    }
                //
                //    //sum /= N;
                //    res[i, j] = sum;
                //}

                var N = input.GetLength(1);
                var ppl = new List<Complex>();
                for (var j = 0; j < N; j++)
                    ppl.Add(input[i, j]);
                ppl = Analyzer.Analyzer.GetReverseComplexSpectre(ppl);
                for (var j = 0; j < N; j++)
                    res[i, j] = ppl[j];
            }
            );
            ;
            

            var spectre = new Complex[input.GetLength(0), input.GetLength(1)];
            Parallel.For(0, input.GetLength(1), i =>
            //for (var i = 0; i < input.GetLength(1); i++)
            {
                //var N = input.GetLength(0);
                //for (var j = 0; j < N; j++)
                //{
                //    var sum = Complex.Zero;
                //    for (var x = 0; x < N; x++)
                //    {
                //        var cur = Complex.Exp(Complex.ImaginaryOne * 2 * Math.PI * x * j / N);
                //        cur *= res[x, i];
                //        sum += cur;
                //    }
                //
                //    //sum /= N;
                //    spectre[j, i] = sum;
                //}

                var N = input.GetLength(0); ;
                var ppl = new List<Complex>();
                for (var j = 0; j < N; j++)
                    ppl.Add(res[j, i]);
                ppl = Analyzer.Analyzer.GetReverseComplexSpectre(ppl);
                for (var j = 0; j < N; j++)
                    spectre[j, i] = ppl[j];
            }
            );
            ;

            return spectre;
        }

        public ImageData Get2DSpectreImage()
        {
            var spectre = Get2DComplexSpectre();
            //spectre = Get2DSpectreReverse(spectre);

            var h = spectre.GetLength(0);
            var w = spectre.GetLength(1);

            var res = new ImageData();

            for (var i = h / 2; i < h; i++)
            {
                var ppl = new PointPairList();
                for (var j = w / 2; j < w; j++)
                {
                    ppl.Add(j, Math.Log(Math.Pow(spectre[i, j].Real * spectre[i, j].Real + spectre[i, j].Imaginary * spectre[i, j].Imaginary, 1.0 / 2) + 1));
                }
                for (var j = 0; j < w / 2; j++)
                {
                    ppl.Add(j, Math.Log(Math.Pow(spectre[i, j].Real * spectre[i, j].Real + spectre[i, j].Imaginary * spectre[i, j].Imaginary, 1.0 / 2) + 1));
                }
                res.Data.Add(ppl);
            }
            
            for (var i = 0; i < h / 2; i++)
            {
                var ppl = new PointPairList();
                for (var j = w / 2; j < w; j++)
                {
                    ppl.Add(j, Math.Log(Math.Pow(spectre[i, j].Real * spectre[i, j].Real + spectre[i, j].Imaginary * spectre[i, j].Imaginary, 1.0 / 2) + 1));
                }
                for (var j = 0; j < w / 2; j++)
                {
                    ppl.Add(j, Math.Log(Math.Pow(spectre[i, j].Real * spectre[i, j].Real + spectre[i, j].Imaginary * spectre[i, j].Imaginary, 1.0 / 2) + 1));
                }
                res.Data.Add(ppl);
            }

            Data = res.Data;
            return res;
        }

        public void SpectreResize(double multiplier)
        {
            if (multiplier < 1)
            {
                MessageBox.Show(
                    "Ошибка, уменьшение не поддерживатся",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var spectre = Get2DComplexSpectre();
            var h = spectre.GetLength(0);
            var w = spectre.GetLength(1);
            var newH = (int)(h * multiplier);
            var newW = (int)(w * multiplier);

            var diffW = newW - w;
            var diffH = newH - h;

            //Adding zeros
            var res = new Complex[newH, newW];
            for (var i = 0; i < h / 2; i++)
            {
                for (var j = 0; j < w / 2; j++)
                {
                    res[i, j] = spectre[i, j];
                }
                for (var j = w / 2; j < w; j++)
                {
                    res[i, j + diffW] = spectre[i, j];
                }
            }

            for (var i = h / 2; i < h; i++)
            {
                for (var j = 0; j < w / 2; j++)
                {
                    res[i + diffH, j] = spectre[i, j];
                }

                for (var j = w / 2; j < w; j++)
                {
                    res[i + diffH, j + diffW] = spectre[i, j];
                }
            }

            //Rendering image
            //var newData = new List<PointPairList>();
            //for (var i = 0; i < res.GetLength(0); i++)
            //{
            //    var ppl = new PointPairList();
            //    for (var j = 0; j < res.GetLength(1); j++)
            //    {
            //        ppl.Add(j, Math.Log(Math.Pow(res[i, j].Real * res[i, j].Real + res[i, j].Imaginary * res[i, j].Imaginary, 1.0 / 2) + 1));
            //    }
            //    newData.Add(ppl);
            //}
            //Data = newData;
            //return;

            var image = Get2DSpectreReverse(res);

            var newData = new List<PointPairList>();
            for (var i = 0; i < res.GetLength(0); i++)
            {
                var ppl = new PointPairList();
                for (var j = 0; j < res.GetLength(1); j++)
                {
                    ppl.Add(j, image[i, j].Real);
                }
                newData.Add(ppl);
            }

            Data = newData;
        }

        public void Deconvolution(PointPairList kernel)
        {
            var width = Data[0].Count;
            if (kernel.Count < width)
            {
                for (var i = kernel.Count; i < width; i++)
                    kernel.Add(i, 0);
            }

            var kernelSpectre = Analyzer.Analyzer.GetComplexSpectre(kernel, false);

            

            Parallel.For(0, Data.Count, i =>
            //for (var i = 0; i < Data.Count; i++)
            {
                Data[i] = GraphManipulator.GetDeconvolution(Data[i], kernelSpectre);
                
            });
        }

        public void Deconvolution(PointPairList kernel, double alpha)
        {
            var width = Data[0].Count;
            if (kernel.Count < width)
            {
                for (var i = kernel.Count; i < width; i++)
                    kernel.Add(i, 0);
            }

            var kernelSpectre = Analyzer.Analyzer.GetComplexSpectre(kernel, false);

            //var potter = GraphManipulator.GetLPPotter(0.1, 64, 1);

            Parallel.For(0, Data.Count, i =>
            //for (var i = 0; i < Data.Count; i++)
            {
                Data[i] = GraphManipulator.GetNoiseDeconvolution(Data[i], kernelSpectre, alpha);
                //Data[i] = GraphManipulator.GetСonvolution(Data[i], potter);
            });
        }

        public void DeconvolutionIterative(PointPairList kernel, double alpha)
        {
            var width = Data[0].Count;
            if (kernel.Count < width)
            {
                for (var i = kernel.Count; i < width; i++)
                    kernel.Add(i, 0);
            }

            var kernelSpectre = Analyzer.Analyzer.GetComplexSpectre(kernel, false);

                //var potter = GraphManipulator.GetLPPotter(0.1, 64, 1);
            
            Parallel.For(0, Data.Count, i =>
            {
                var lines = new List<PointPairList>();
                for (var j = 0; j < 40; j++)
                {
                    lines.Add(GraphManipulator.GetNoiseDeconvolution(Data[i], kernelSpectre, alpha - 0.1 + j * 0.005));
                }
                
                for (var k = 0; k < Data[i].Count; k++)
                {
                    Data[i][k].Y = 0;
                    for (var j = 0; j < 40; j++)
                    {
                        Data[i][k].Y += lines[j][k].Y / 40;
                    }
                }
            });
        }

        public void ConvolutionAllLines(PointPairList kernel)
        {
            var size = kernel.Count / 2;
            var pictureWidth = Data[0].Count;
            Parallel.For(0, Data.Count, i =>
            {
                Data[i] = GraphManipulator.GetСonvolution(Data[i], kernel);
                Data[i].RemoveRange(0, size);
                Data[i].RemoveRange(pictureWidth, Data[i].Count - pictureWidth);
            });
        }

        public void ConvolutionLinesAndColumns(PointPairList kernel)
        {
            var size = kernel.Count / 2;
            var pictureWidth = Data[0].Count;
            var pictureHeight = Data.Count;
            Parallel.For(0, Data.Count, i =>
            {
                Data[i] = GraphManipulator.GetСonvolution(Data[i], kernel);
                Data[i].RemoveRange(0, size);
                Data[i].RemoveRange(pictureWidth, Data[i].Count - pictureWidth);
            });

            Parallel.For(0, pictureWidth, j =>
            {
                var ppl = new PointPairList();
                for (var i = 0; i < pictureHeight; i++)
                    ppl.Add(Data[i][j]);

                ppl = GraphManipulator.GetСonvolution(ppl, kernel);
                ppl.RemoveRange(0, size);
                ppl.RemoveRange(pictureHeight, ppl.Count - pictureHeight);

                for (var i = 0; i < pictureHeight; i++)
                    Data[i][j].Y = ppl[i].Y;
            });
        }

        public void ThresholdFilter(double threshold)
        {
            Parallel.ForEach(Data.SelectMany(row => row), point =>
            {
                point.Y = point.Y > threshold ? 255 : 0;
            });
        }

        public void Gradient()
        {
            var width = Data[0].Count;
            var height = Data.Count;
            var newData = new List<PointPairList>();

            for (var j = 0; j < height; j++)
            {
                var line = new PointPairList();
                for (var i = 0; i < width; i++)
                {
                    var prevY = j - 1;
                    if (prevY < 0) prevY = 0;
                    var nextY = j + 1;
                    if (nextY >= height) nextY = height - 1;
                    var prevX = i - 1;
                    if (prevX < 0) prevX = 0;
                    var nextX = i + 1;
                    if (nextX >= width) nextX = width - 1;

                    var gx = (Data[nextY][nextX].Y + 2*Data[j][nextX].Y + Data[prevY][nextX].Y) - (Data[nextY][prevX].Y + 2*Data[j][prevX].Y + Data[prevY][prevX].Y);
                    var gy = (Data[nextY][prevX].Y + 2*Data[nextY][i].Y + Data[nextY][nextX].Y) - (Data[prevY][prevX].Y + 2*Data[prevY][i].Y + Data[prevY][nextX].Y);
                    
                    line.Add(i, Math.Sqrt(gx * gx + gy * gy));
                }
                newData.Add(line);
            }

            Data = newData;
        }

        public void Laplace()
        {
            var width = Data[0].Count;
            var height = Data.Count;
            var newData = new List<PointPairList>();

            var mask = new[,]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            for (var j = 0; j < height; j++)
            {
                var line = new PointPairList();
                for (var i = 0; i < width; i++)
                {
                    double sum = 0;
                    for (var m = j - 1; m <= j + 1; m++)
                    {
                        if (m < 0) 
                            continue;
                        if (m == height) 
                            break;
                        for (var k = i - 1; k <= i + 1; k++)
                        {
                            if (k < 0) 
                                continue;
                            if (k == width) 
                                break;
                            sum += Data[m][k].Y * mask[m - j + 1, k - i + 1];
                        }
                    }
                    line.Add(i, sum);
                }
                newData.Add(line);
            }
            Data = newData;
        }

        public void DilatationSquared(int maskHeight, int maskWidth, double color)
        {
            var width = Data[0].Count;
            var height = Data.Count;

            maskHeight /= 2;
            maskWidth /= 2;

            var newData = new List<PointPairList>();

            //Parallel.For(0, height, i =>
            for (var i = 0; i < height; i++)
            {
                var line = new PointPairList();
                for (var j = 0; j < width; j++)
                {
                    if (Math.Abs(Data[i][j].Y - color) < 1e-14)
                    {
                        line.Add(j, Data[i][j].Y);
                    }
                    else
                    {
                        var minPosX = Math.Max(j - maskWidth, 0);
                        var minPosY = Math.Max(i - maskHeight, 0);
                        var maxPosX = Math.Min(j + maskWidth, width - 1);
                        var maxPosY = Math.Min(i + maskHeight, height - 1);

                        var flag = false;
                        for (var k = minPosY; k <= maxPosY && !flag; k++)
                        {
                            for (var l = minPosX; l <= maxPosX; l++)
                            {
                                if (Math.Abs(Data[k][l].Y - color) > 1e-14)
                                    continue;

                                flag = true;
                                break;
                            }
                        }

                        line.Add(j, flag ? color : Data[i][j].Y);
                    }
                }

                newData.Add(line);
            }
            Data = newData;
        }

        public void ErosionSquared(int maskHeight, int maskWidth, double color)
        {
            var width = Data[0].Count;
            var height = Data.Count;

            maskHeight /= 2;
            maskWidth /= 2;

            var newData = new List<PointPairList>();

            //Parallel.For(0, height, i =>
            for (var i = 0; i < height; i++)
            {
                var line = new PointPairList();
                for (var j = 0; j < width; j++)
                {
                    if (Math.Abs(Data[i][j].Y - color) > 1e-14)
                    {
                        line.Add(j, Data[i][j].Y);
                    }
                    else
                    {
                        var minPosX = Math.Max(j - maskWidth, 0);
                        var minPosY = Math.Max(i - maskHeight, 0);
                        var maxPosX = Math.Min(j + maskWidth, width - 1);
                        var maxPosY = Math.Min(i + maskHeight, height - 1);

                        var flag = false;
                        for (var k = minPosY; k <= maxPosY; k++)
                        {
                            for (var l = minPosX; l <= maxPosX; l++)
                            {
                                if (Math.Abs(Data[k][l].Y - color) < 1e-14)
                                    continue;

                                flag = true;
                                break;
                            }
                        }

                        line.Add(j, flag ? 0 : color);
                    }
                }

                newData.Add(line);
            };
            Data = newData;
        }
    }
}

