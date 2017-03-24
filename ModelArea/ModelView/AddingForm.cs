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
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            _figureType = FigureType.Circle;
        }

        /// <summary>
        /// Радио-кнопка Прямоугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioSelectRectangle_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            _figureType = FigureType.Rectangle;
            
        }

        /// <summary>
        /// Радио-кнопка Треугольник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioSelectTriangle_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
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
                        _figure = new Circle(Convert.ToDouble(textBox4.Text));
                        break;
                    case FigureType.Triangle:
                        sideA = Convert.ToDouble(textBox1.Text);
                        sideB = Convert.ToDouble(textBox2.Text);
                        double sideC = Convert.ToDouble(textBox3.Text);
                        _figure = new Triangle(sideA, sideB, sideC);
                        break;
                    case FigureType.Rectangle:
                        sideA = Convert.ToDouble(textBox1.Text);
                        sideB = Convert.ToDouble(textBox2.Text);
                        _figure = new ModelArea.Rectangle(sideA, sideB);
                        break;
                }
                Close();
            }
            catch (Exception ex)
            {
                if (ex is NotFiniteNumberException || ex is FormatException)
                {
                    MessageBox.Show(@"Введите вещественное число", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex is ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Введите числа больше 0", "Ошибка ввода",
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
