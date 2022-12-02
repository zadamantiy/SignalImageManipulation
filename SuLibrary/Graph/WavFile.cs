using System;
using System.IO;
using ZedGraph;

namespace SuLibrary.Graph
{
    public class WavFile
    {
        private readonly byte[] _header = new byte[44];
        private double[] _left;
        private double[] _right;
        private int _sampleRate;

        // convert two bytes to one double in the range -1 to 1
        static double BytesToDouble(byte firstByte, byte secondByte)
        {
            // convert two bytes to one short (little endian)
            var s = (short)((secondByte << 8) | firstByte);
            // convert to range from -1 to (just below) 1
            return s / 32768.0;
        }

        static byte[] DoubleToBytes(double input)
        {
            var s = (short)(input * 32768);
            return new[] { (byte)(s >> 8), (byte)(s % 256) };
        }

        // Returns left and right double arrays. 'right' will be null if sound is mono.
        public void OpenWav(string filename)
        {
            var wav = File.ReadAllBytes(filename);

            for (var i = 0; i < 44; i++)
                _header[i] = wav[i];

            // mono = 1, stereo = 2
            int channels = wav[22];

            var sampleRateBytes = new[] { wav[24], wav[25], wav[26], wav[27] };
            _sampleRate = BitConverter.ToInt32(sampleRateBytes, 0);

            /*
            var bitsPerSampleByte = new byte[]{wav[34], wav[35], 0x00, 0x00};
            var bitsPerSample = BitConverter.ToInt32(bitsPerSampleByte, 0);
            */

            // Get past all the other sub chunks to get to the data subchunk:
            var pos = 12; // First Subchunk ID from 12 to 16

            // Keep iterating until we find the data chunk (i.e. 64 61 74 61 ...... (i.e. 100 97 116 97 in decimal))
            while (!(wav[pos] == 100 && wav[pos + 1] == 97 && wav[pos + 2] == 116 && wav[pos + 3] == 97))
            {
                pos += 4;
                var chunkSize = wav[pos] + wav[pos + 1] * 256 + wav[pos + 2] * 65536 + wav[pos + 3] * 16777216;
                pos += 4 + chunkSize;
            }
            pos += 8;

            // Pos is now positioned to start of actual sound data.
            var samples = (wav.Length - pos) / 2; // 2 bytes per sample (16 bit sound mono)
            if (channels == 2) samples /= 2; // 4 bytes per sample (16 bit stereo)

            // Allocate memory (right will be null if only mono sound)
            _left = new double[samples];
            _right = channels == 2 ? new double[samples] : null;

            // Write to double array/s:
            var j = 0;
            while (j < samples)
            {
                _left[j] = BytesToDouble(wav[pos], wav[pos + 1]);
                pos += 2;
                if (channels == 2)
                {
                    _right[j] = BytesToDouble(wav[pos], wav[pos + 1]);
                    pos += 2;
                }

                j++;
            }
        }

        public void WriteWav(string filename)
        {
            var info = new byte[_header.Length + (_left.Length + (_right?.Length ?? 0)) * 2];
            for (var i = 0; i < _header.Length; i++)
                info[i] = _header[i];

            var pos = _header.Length;
            if (_right == null)
            {
                foreach (var d in _left)
                {
                    var l = DoubleToBytes(d);
                    info[pos++] = l[0];
                    info[pos++] = l[1];
                }
            }
            else
            {
                for (var i = 0; i < _left.Length; i++)
                {
                    var d = _left[i];
                    var l = DoubleToBytes(d);
                    info[pos++] = l[0];
                    info[pos++] = l[1];

                    d = _right[i];
                    var r = DoubleToBytes(d);
                    info[pos++] = r[0];
                    info[pos++] = r[1];
                }
            }

            File.WriteAllBytes(filename, info);
        }

        public static void WritePplToWav(string path, PointPairList data)
        {
            var info = new byte[44 + data.Count * 2];

            //ChunkID = "RIFF"
            info[0] = 0x52;
            info[1] = 0x49;
            info[2] = 0x46;
            info[3] = 0x46;

            //ChunkSize = fileSize - 8
            var size = info.Length - 8;
            info[4] = (byte)size;
            size >>= 8;
            info[5] = (byte)size;
            size >>= 8;
            info[6] = (byte)size;
            size >>= 8;
            info[7] = (byte)size;

            //Format = "WAVE"
            info[8] = 0x57;
            info[9] = 0x41;
            info[10] = 0x56;
            info[11] = 0x45;

            //Subchunk1ID = "fmt "
            info[12] = 0x66;
            info[13] = 0x6d;
            info[14] = 0x74;
            info[15] = 0x20;

            //16
            info[16] = 0x10;
            //info[17] = 0x00;
            //info[18] = 0x00;
            //info[19] = 0x00;

            //No compression (1)
            info[20] = 0x01;
            //info[21] = 0x00;

            //Channels (1)
            info[22] = 0x01;
            //info[23] = 0x00;

            //SampleRate
            var sampleRate = (int)(1.0 / (data[1].X - data[0].X));
            var sRateCopy = sampleRate;
            info[24] = (byte)sRateCopy;
            sRateCopy >>= 8;
            info[25] = (byte)sRateCopy;
            sRateCopy >>= 8;
            info[26] = (byte)sRateCopy;
            sRateCopy >>= 8;
            info[27] = (byte)sRateCopy;

            //ByteRate
            var byteRate = sampleRate * 1 * 16 / 8;
            info[28] = (byte)byteRate;
            byteRate >>= 8;
            info[29] = (byte)byteRate;
            byteRate >>= 8;
            info[30] = (byte)byteRate;
            byteRate >>= 8;
            info[31] = (byte)byteRate;

            //Block Align
            var blockAlign = 1 * 16 / 8;
            info[32] = (byte)blockAlign;
            blockAlign >>= 8;
            info[33] = (byte)blockAlign;

            //BitsPerSample = 16
            info[34] = 0x10;
            //info[35] = 0x00;

            //"data"
            info[36] = 0x64;
            info[37] = 0x61;
            info[38] = 0x74;
            info[39] = 0x61;

            //Subchunk2Size
            var subchunk2Size = data.Count * 1 * 16 / 8;
            info[40] = (byte)subchunk2Size;
            subchunk2Size >>= 8;
            info[41] = (byte)subchunk2Size;
            subchunk2Size >>= 8;
            info[42] = (byte)subchunk2Size;
            subchunk2Size >>= 8;
            info[43] = (byte)subchunk2Size;

            var pos = 44;
            foreach (var d in data)
            {
                var l = DoubleToBytes(d.Y);
                info[pos++] = l[1];
                info[pos++] = l[0];
            }

            File.WriteAllBytes(path, info);
        }

        public void ChangeData(PointPairList ppl)
        {
            for (var i = 0; i < ppl.Count; i++)
                _left[i] = ppl[i].Y;
        }

        public PointPairList GetPpl()
        {
            var ppl = new PointPairList();
            for (var i = 0; i < _left.Length; i++)
            {
                ppl.Add((double)i / _sampleRate, _left[i]);
            }
            return ppl;
        }
    }
}
