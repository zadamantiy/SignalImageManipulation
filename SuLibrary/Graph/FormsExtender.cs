using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace SuLibrary.Graph
{
    public static class FormsExtender
    {
        public static List<CurveItem> GetCurves(CheckedListBox graphListBox, ZedGraphControl zgc)
        { 
            var indices = new List<int>(); 
            for(var i = 0; i<graphListBox.Items.Count; i++)
            {
                if (graphListBox.GetItemChecked(i))
                {
                    indices.Add(i);
                }
            }

            return (from int index in indices select zgc.GraphPane.CurveList[index]).ToList();
        }
    }
}
