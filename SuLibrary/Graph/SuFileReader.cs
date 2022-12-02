using System.IO;
using ZedGraph;

namespace SuLibrary.Graph
{
    public static class SuDatFileReader
    {
        public static PointPairList ReadDatFile(string filename, double dT = 0.002)
        {
            var res = new PointPairList();

            if (!File.Exists(filename)) return res;

            var i = 0;
            using (var reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                    res.Add(dT * i++, reader.ReadSingle());
            }

            return res;
        }

        public static void WriteDatFile(PointPairList input, string path)
        {
            using (var writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (var point in input)
                    writer.Write((float) point.Y);
            }
        }
    }
}
