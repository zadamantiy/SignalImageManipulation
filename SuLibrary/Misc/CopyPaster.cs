using ZedGraph;

namespace SuLibrary.Misc
{
    public class CopyPaster
    {
        private CurveList _copiedList;

        public CopyPaster()
        {
            _copiedList = new CurveList();
        }

        public CopyPaster(CurveList copiedList)
        {
            _copiedList = copiedList.Clone();
        }

        public void GetCopy(ZedGraphControl control)
        {
            _copiedList = control.GraphPane.CurveList.Clone();
        }

        public void GetCopy(CurveList copiedList)
        {
            _copiedList = copiedList.Clone();
        }

        public void PasteCopy(ZedGraphControl control)
        {
            control.GraphPane.CurveList = _copiedList.Clone();
            control.RestoreScale(control.GraphPane);
            control.AxisChange();
            control.Invalidate();
        }

        public void AddCopy(ZedGraphControl control)
        {
            control.GraphPane.CurveList.AddRange(_copiedList.Clone());
            control.RestoreScale(control.GraphPane);
            control.AxisChange();
            control.Invalidate();
        }
    }
}
