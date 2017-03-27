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
        private readonly BindingList<IFigure> _figureListInitial;
        private FigureType _figureType;

        private void ParamSearchingRoutine()
        {
            if (LengthRadioButton.Checked)
            {
                _figureList = DataHandler.SearchInList(ref _figureList, 1, AreaLengthTextBox.Text);
            }
            else
            {
                _figureList = DataHandler.SearchInList(ref _figureList, 0, AreaLengthTextBox.Text);
            }
        }

        public BindingList<IFigure> FigureList => _figureList;

        public SearchingForm(BindingList<IFigure> figureList )
        {
            _figureList = figureList;
            _figureListInitial = figureList;
            InitializeComponent();
        }

        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Circle;
            AnyParamRadioButton.Enabled = true;
        }

        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Rectangle;
            AnyParamRadioButton.Enabled = true;
        }   

        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Triangle;
            AnyParamRadioButton.Enabled = true;
        }

        private void AnyFigureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyParamRadioButton.Enabled = false;
            AnyParamRadioButton.Checked = false;
        }

        private void AnyParamRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = false;
            AnyFigureRadioButton.Checked = false;
            AreaLengthLabel.Visible = false;
            AreaLengthTextBox.Visible = false;

        }

        private void LengthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = true;
            AreaLengthLabel.Visible = true;
            AreaLengthTextBox.Visible = true;
            AreaLengthLabel.Text = @"Периметр";
        }

        private void AreaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = true;
            AreaLengthLabel.Visible = true;
            AreaLengthTextBox.Visible = true;
            AreaLengthLabel.Text = @"Площадь";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (AnyFigureRadioButton.Checked)
            {
                ParamSearchingRoutine();
            }
            else
            {
                _figureList = DataHandler.SearchInList_ByFigureType(ref _figureList, _figureType);
                if (!AnyParamRadioButton.Checked)
                {
                    ParamSearchingRoutine();
                }
            }
            Close();  
        }

        
    }
}
