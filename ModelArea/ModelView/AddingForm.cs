using System;
using System.Drawing;
using System.Windows.Forms;
using ModelArea;
using Rectangle = ModelArea.Rectangle;

namespace ModelView
{
    public partial class AddingForm : Form
    {
        #region Private members

        private IFigure _figure;
        private FigureType _figureType;
        private bool _mouseDown;
        private Point _lastLocation;

        #endregion

        /// <summary>
        /// Кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Зажатие кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        /// <summary>
        /// Перемещение формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        /// <summary>
        /// Отжатие кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AddingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство передачи данных фигуры
        /// </summary>
        public IFigure Figure => _figure;

        /// <summary>
        /// Метод выбора фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiguresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SideATextBox.Visible = FiguresComboBox.SelectedIndex == 1 || FiguresComboBox.SelectedIndex == 2;
            SideBTextBox.Visible = FiguresComboBox.SelectedIndex == 1 || FiguresComboBox.SelectedIndex == 2;
            SideCTextBox.Visible = FiguresComboBox.SelectedIndex == 1;
            RadiusTextBox.Visible = FiguresComboBox.SelectedIndex == 0;
            SideALabel.Visible = FiguresComboBox.SelectedIndex == 1 || FiguresComboBox.SelectedIndex == 2;
            SideBLabel.Visible = FiguresComboBox.SelectedIndex == 1 || FiguresComboBox.SelectedIndex == 2;
            SideCLabel.Visible = FiguresComboBox.SelectedIndex == 1;
            RadiusLabel.Visible = FiguresComboBox.SelectedIndex == 0;
            _figureType = (FigureType)FiguresComboBox.SelectedIndex;
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_figureType)
                {
                    case FigureType.Circle:
                        _figure = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                        break;
                    case FigureType.Triangle:
                        double sideA = Convert.ToDouble(SideATextBox.Text);
                        double sideB = Convert.ToDouble(SideBTextBox.Text);
                        double sideC = Convert.ToDouble(SideCTextBox.Text);
                        _figure = new Triangle(sideA, sideB, sideC);
                        break;
                    case FigureType.Rectangle:
                        double height = Convert.ToDouble(SideATextBox.Text);
                        double width = Convert.ToDouble(SideBTextBox.Text);
                        _figure = new Rectangle(height, width);
                        break;
                }
                Close();
            }
            catch (ArgumentOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotFiniteNumberException exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException exception)
            {
                if (_figureType == FigureType.Triangle)
                {
                    MessageBox.Show(exception.Message, @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}

