using System.Windows.Forms;
using ZedGraph;

namespace SuLibrary.Misc
{
    public static class ControlEditor
    {
        public static void UpdateGraphs(ZedGraphControl control, ListBox graphList)
        {
            graphList.Items.Clear();
            var i = 1;
            foreach (var curve in control.GraphPane.CurveList)
            {
                if (curve.Label.Text != "")
                {
                    graphList.Items.Add(curve.Label.Text);
                }
                else
                {
                    graphList.Items.Add("Unnamed graph " + i++);
                }
            }
        }
    }
}
