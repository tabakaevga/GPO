using System;
using System.Windows.Forms;
using ModelArea;

namespace ModelView
{
    public partial class AddingForm : Form
    {
        #region Private members

        private IFigure _figure;
        private FigureType _figureType;

        #endregion

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AddingForm()
        {
            //BUG: Создал рандомные данные, потом нажал добавить,
            //Ввел радиус круга 11, нажал ОК, и не обнаружил в таблице круга с радиусом 11
            InitializeComponent();
        }

        /// <summary>
        /// Свойство передачи данных фигуры
        /// </summary>
        public IFigure Figure => _figure;

        /// <summary>
        /// Радио-кнопка Окружность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioSelectCircle_CheckedChanged(object sender, EventArgs e)
        {
            SideATextBox.Visible = false;
            SideBTextBox.Visible = false;
            SideCTextBox.Visible = false;
            RadiusTextBox.Visible = true;
            SideALabel.Visible = false;
            SideBLabel.Visible = false;
            SideCLabel.Visible = false;
            RadiusLabel.Visible = true;
            _figureType = FigureType.Circle;
        }

        /// <summary>
        /// Радио-кнопка Прямоугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioSelectRectangle_CheckedChanged(object sender, EventArgs e)
        {
            SideATextBox.Visible = true;
            SideBTextBox.Visible = true;
            SideCTextBox.Visible = false;
            RadiusTextBox.Visible = false;
            SideALabel.Visible = true;
            SideBLabel.Visible = true;
            SideCLabel.Visible = false;
            RadiusLabel.Visible = false;
            _figureType = FigureType.Rectangle;
            
        }

        /// <summary>
        /// Радио-кнопка Треугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioSelectTriangle_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * Можно сделать комбоБокс с фигурами
             * Что бы не писать 3 метода, которые у тебя скрывают контролы, можно
             * написать один:
             * При изменениии индекса комбо бокса:
             * SideATextBox.Visible = sampleComboBox.SelectedIndex == 0;
             * итд
             */
            SideATextBox.Visible = true;
            SideBTextBox.Visible = true;
            SideCTextBox.Visible = true;
            RadiusTextBox.Visible = false;
            SideALabel.Visible = true;
            SideBLabel.Visible = true;
            SideCLabel.Visible = true;
            RadiusLabel.Visible = false;
            _figureType = FigureType.Triangle;
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
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(@"Введите числа больше 0", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotFiniteNumberException)
            {
                MessageBox.Show(@"Введите вещественное число", @"Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                if (_figureType == FigureType.Triangle)
                {
                    //TODO: У тебя же в классе исключение выбрасывается с сообщением, 
                    //почему бы не использовать exception.message 
                    MessageBox.Show(@"Стороны треугольника должны соответстовать условию существования треугольника",
                        @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _figure = null;
        }
    }
}

