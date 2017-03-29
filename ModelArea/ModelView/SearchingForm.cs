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
        
        private FigureType _figureType = FigureType.Circle;

        /// <summary>
        /// Метод, отбирающий поисковые методы
        /// </summary>
        private void ParamSearchingRoutine()
        {
            //TODO: Код переписывается проще, Resharper подскажет 
            //NOTE: посчитал выражение слишком длинным
            CheckCorrectInput.CheckDouble(Convert.ToDouble(AreaLengthTextBox.Text));
            _figureList = LengthRadioButton.Checked ? DataHandler.SearchInList(ref _figureList, 1, AreaLengthTextBox.Text)
                : DataHandler.SearchInList(ref _figureList, 0, AreaLengthTextBox.Text);
        }

        #endregion

        /// <summary>
        /// Свойство для передачи обработанного списка
        /// </summary>
        public BindingList<IFigure> FigureList => _figureList;

        /// <summary>
        /// Конструктор формы SearchingForm
        /// </summary>
        /// <param name="figureList"> Список объектов Фигура </param>
        public SearchingForm(BindingList<IFigure> figureList )
        {
            //BUG: Открыл форму, поочередно потыкал радиобаттоны из группы Ареа\ленс сверху вниз
            //Потом так же потыкал радиобаттоны из группы фигуры, и загрыл форму.
            //Данные в гридВью почему то изменились, хотя я не нажимал кнопку поиска
            _figureList = figureList;
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
            AreaLengthLabel.Text = @"Length";
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
            AreaLengthLabel.Text = @"Area";
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

            catch (NotFiniteNumberException)
            {
                MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Введите числа больше 0", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
