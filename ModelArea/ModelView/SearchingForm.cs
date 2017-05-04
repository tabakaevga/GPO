using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ModelArea;
using ModelArea.Tools;
using ModelView.Tools;

namespace ModelView
{
    public partial class SearchingForm : Form
    {
        /// <summary>
        ///     Конструктор формы SearchingForm
        /// </summary>
        /// <param name="figureList"> Список объектов Фигура </param>
        public SearchingForm(BindingList<IFigure> figureList)
        {
            _figuresInitial = figureList;
            _figureList = figureList;
            InitializeComponent();
        }

        /// <summary>
        ///     Свойство для передачи обработанного списка
        /// </summary>
        public BindingList<IFigure> FigureList => _figureList;

        /// <summary>
        ///     Обработчик зажатой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        /// <summary>
        ///     Перемещение формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, Location.Y - _lastLocation.Y + e.Y);

                Update();
            }
        }

        /// <summary>
        ///     Переработчик отжатой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        /// <summary>
        ///     Радио-кнопка Окружность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Circle;
            AnyParamRadioButton.Enabled = true;
        }

        /// <summary>
        ///     Радио-кнопка Прямоугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Rectangle;
            AnyParamRadioButton.Enabled = true;
        }

        /// <summary>
        ///     Радио-кнопка Треугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _figureType = FigureType.Triangle;
            AnyParamRadioButton.Enabled = true;
        }

        /// <summary>
        ///     Радио-кнопка Любая фигура
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyFigureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AnyParamRadioButton.Enabled = false;
            AnyParamRadioButton.Checked = false;
        }

        /// <summary>
        ///     Радио-кнопка Любой параметр
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
        ///     Радио-кнопка Периметр
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
        ///     Радио-кнопка Площадь
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
        ///     Кнопка OK
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
                    if (!AnyParamRadioButton.Checked)
                        ParamSearchingRoutine();
                    _figureList = Searcher.SearchInList_ByFigureType(ref _figureList, _figureType);
                }
                Close();
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Value can't be less than 0", @"Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Invalid input type (not real).", @"Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotFiniteNumberException)
            {
                MessageBox.Show(@"Value must be finite.", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            _figureList = _figuresInitial;
            Close();
        }

        #region Private members

        private BindingList<IFigure> _figureList;
        private readonly BindingList<IFigure> _figuresInitial;
        private FigureType _figureType = FigureType.Circle;
        private bool _mouseDown;
        private Point _lastLocation;

        /// <summary>
        ///     Метод, отбирающий поисковые методы
        /// </summary>
        private void ParamSearchingRoutine()
        {
            //TODO: Код переписывается проще, Resharper подскажет 
            //NOTE: посчитал выражение слишком длинным
            //NOTE: Решарпер длинно сделал - переписал ниже
            CheckCorrectInput.CheckDouble(Convert.ToDouble(AreaLengthTextBox.Text));
            _figureList = Searcher.SearchInList(ref _figureList,
                LengthRadioButton.Checked ? 1 : 0,
                AreaLengthTextBox.Text);
        }

        #endregion
    }
}