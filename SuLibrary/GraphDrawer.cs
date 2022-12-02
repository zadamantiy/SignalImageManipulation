using ZedGraph;

namespace SuLibrary
{
    public static class GraphDrawer
    {
        private static readonly ColorSymbolRotator ColorRotator = new ColorSymbolRotator();

        public static void ClearGraph(ZedGraphControl control)
        {
            control.GraphPane.CurveList.Clear();
            control.Invalidate();
        }

        public static void AddGraph(ZedGraphControl control, string graphName, PointPairList graphPoints)
        {
            var pane = control.GraphPane;

            pane.AddCurve(graphName, graphPoints, ColorRotator.NextColor, SymbolType.None);

            control.AxisChange();
            control.Invalidate();
        }
    }
}
