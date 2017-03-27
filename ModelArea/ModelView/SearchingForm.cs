using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;
using ModelView.Tools;

namespace ModelView
{
    public partial class SearchingForm : Form
    {
        private BindingList<IFigure> _figureList;
        

        public SearchingForm(BindingList<IFigure> figureList)
        {
            InitializeComponent();
            _figureList = figureList;
        }

        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DataHandler.SearchInList_ByFigureType(ref _figureList, FigureType.Circle);
        }

        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DataHandler.SearchInList_ByFigureType(ref _figureList, FigureType.Rectangle);
        }

        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DataHandler.SearchInList_ByFigureType(ref _figureList, FigureType.Triangle);
        }

        private void AnyFigureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyParamRadioButton.Enabled = false;
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
