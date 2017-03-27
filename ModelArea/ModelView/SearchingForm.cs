using System;
using System.ComponentModel;
using System.Windows.Forms;
using ModelArea;
using ModelArea.Tools;
using ModelView.Tools;

namespace ModelView
{
    public partial class SearchingForm : Form
    {
        #region Private members

        private BindingList<IFigure> _figureList;
        private readonly BindingList<IFigure> _figureListInitial;
        private FigureType _figureType;

        /// <summary>
        /// Метод, отбирающий поисковые методы
        /// </summary>
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

        #endregion

        /// <summary>
        /// Метод для передачи обработанного списка
        /// </summary>
        public BindingList<IFigure> FigureList => _figureList;

        /// <summary>
        /// Конструктор формы SearchingForm
        /// </summary>
        /// <param name="figureList"> Список объектов Фигура </param>
        public SearchingForm(BindingList<IFigure> figureList )
        {
            _figureList = figureList;
            _figureListInitial = figureList;
            InitializeComponent();
        }

        /// <summary>
        /// Радио-кнопка Окружность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Circle;
            AnyParamRadioButton.Enabled = true;
        }

        /// <summary>
        /// Радио-кнопка Прямоугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Rectangle;
            AnyParamRadioButton.Enabled = true;
        }   

        /// <summary>
        /// Радио-кнопка Треугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Triangle;
            AnyParamRadioButton.Enabled = true;
        }

        /// <summary>
        /// Радио-кнопка Любая фигура
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyFigureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyParamRadioButton.Enabled = false;
            AnyParamRadioButton.Checked = false;
        }

        /// <summary>
        /// Радио-кнопка Любой параметр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyParamRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = false;
            AnyFigureRadioButton.Checked = false;
            AreaLengthLabel.Visible = false;
            AreaLengthTextBox.Visible = false;

        }

        /// <summary>
        /// Радио-кнопка Периметр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = true;
            AreaLengthLabel.Visible = true;
            AreaLengthTextBox.Visible = true;
            AreaLengthLabel.Text = @"Периметр";
        }

        /// <summary>
        /// Радио-кнопка Площадь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyFigureRadioButton.Enabled = true;
            AreaLengthLabel.Visible = true;
            AreaLengthTextBox.Visible = true;
            AreaLengthLabel.Text = @"Площадь";
        }

        /// <summary>
        /// Кнопка OK 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckCorrectInput.CheckDouble(Convert.ToDouble(AreaLengthTextBox.Text));
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
            catch (Exception ex)
            {
                if (ex is NotFiniteNumberException || ex is FormatException)
                {
                    MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(@"Введите числа больше 0", @"Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
