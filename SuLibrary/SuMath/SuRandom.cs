using System;

namespace SuLibrary.SuMath
{
    public class SuRandom
    {
        private double _seed;
        public SuRandom()
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var diff = DateTime.Now.ToUniversalTime() - origin;
            _seed = Math.Floor(diff.TotalSeconds);
        }

        public SuRandom(double seed)
        {
            _seed = seed;
        }

        public double NextDouble()
        {
            _seed = _seed * /*16807*/Math.Pow(Math.PI, 7) % 2147483647;
            return _seed / 2147483647;
        }
    }
}
