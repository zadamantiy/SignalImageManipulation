using System;
using System.Linq;
using ZedGraph;
using SuLibrary.Graph.Params;
using SuLibrary.SuMath;

namespace SuLibrary.Graph
{
    public class GraphCreator
    {
        public static PointPairList GetRandom(GraphParamsEquation parameters, Random random)
        {
            var list = new PointPairList();

            var minValue = parameters.GetParameter("min");
            var maxValue = parameters.GetParameter("max");

            for (var x = parameters.MinCoordinate; x <= parameters.MaxCoordinate; x += parameters.Delta)
            {
                list.Add(x, random.NextDouble());
            }

            var minY = list.Min(x => x.Y);
            var maxY = list.Max(x => x.Y);

            foreach (var point in list)
            {
                point.Y = (point.Y - minY) / (maxY - minY) * (maxValue - minValue) + minValue;
            }

            return list;
        }

        public static PointPairList GetRandom(GraphParamsEquation parameters, SuRandom suRandom)
        {
            var list = new PointPairList();

            var minValue = parameters.GetParameter("min");
            var maxValue = parameters.GetParameter("max");
            
            for (var x = parameters.MinCoordinate; x <= parameters.MaxCoordinate; x += parameters.Delta)
            {
                list.Add(x, suRandom.NextDouble());
            }

            var minY = list.Min(x => x.Y);
            var maxY = list.Max(x => x.Y);

            foreach (var point in list)
            {
                point.Y = (point.Y - minY) / (maxY - minY) * (maxValue - minValue) + minValue;
            }

            return list;
        }

        public static PointPairList GetExponent(GraphParamsEquation parameters)
        {
            var list = new PointPairList();

            var a = parameters.GetParameter("a");
            var b = parameters.GetParameter("b");
            
            for (var x = parameters.MinCoordinate; x <= parameters.MaxCoordinate; x += parameters.Delta)
            {
                list.Add(x, b * Math.Exp(a * x));
            }

            return list;
        }

        public static PointPairList GetSin(GraphParamsEquation parameters)
        {
            var list = new PointPairList();

            var a = parameters.GetParameter("A");
            var f = parameters.GetParameter("f");

            for (var x = parameters.MinCoordinate; x <= parameters.MaxCoordinate; x += parameters.Delta)
            {
                list.Add(x, a * Math.Sin(2 * Math.PI * f * x));
            }

            return list;
        }

        public static PointPairList GetLinear(GraphParamsEquation parameters)
        {
            var list = new PointPairList();

            var c = parameters.GetParameter("c");
            var d = parameters.GetParameter("d");

            for (var x = parameters.MinCoordinate; x <= parameters.MaxCoordinate; x += parameters.Delta)
            {
                list.Add(x, c * x + d);
            }

            return list;
        }
    }
}
