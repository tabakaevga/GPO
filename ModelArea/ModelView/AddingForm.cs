using System;
using System.Windows.Forms;
using ModelArea;

namespace ModelView
{
    public partial class AddingForm : Form
    {
        private IFigure _figure;
        private FigureType _figureType;

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
                double sideB;
                double sideA;
                switch (_figureType)
                {
                    case FigureType.Circle:
                        _figure = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                        break;
                    case FigureType.Triangle:
                        sideA = Convert.ToDouble(SideATextBox.Text);
                        sideB = Convert.ToDouble(SideBTextBox.Text);
                        double sideC = Convert.ToDouble(SideCTextBox.Text);
                        _figure = new Triangle(sideA, sideB, sideC);
                        break;
                    case FigureType.Rectangle:
                        sideA = Convert.ToDouble(SideATextBox.Text);
                        sideB = Convert.ToDouble(SideBTextBox.Text);
                        _figure = new Rectangle(sideA, sideB);
                        break;
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
                if (ex is ArgumentException && (_figureType == FigureType.Triangle))
                {
                    MessageBox.Show(@"Стороны треугольника должны соответстовать условию существования треугольника",
                        @"Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
