using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls.FigureControls
{
    public partial class CircleControl : UserControl
    {
        private IFigure _objectFigure;
        private bool _readOnly;

        public Circle Object;
    }
}