using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls.FigureControls
{
    public partial class TriangleControl : UserControl
    {
        private bool _readOnly;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public TriangleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство, возвращающее истину, если был активирован ToolTip
        /// </summary>
        public bool ToolTipShown { get; private set; }

        /// <summary>
        /// Свойство объекта типа Треугольник
        /// </summary>
        public Triangle ObjectTriangle
        {
            set
            {
                if (value != null)
                {
                    SideATextBox.Text = Convert.ToString(value.SideA, CultureInfo.CurrentCulture);
                    SideBTextBox.Text = Convert.ToString(value.SideB, CultureInfo.CurrentCulture);
                    SideCTextBox.Text = Convert.ToString(value.SideB, CultureInfo.CurrentCulture);
                    TextBoxControl.AreaLengthBoxes = value;
                }
            }
            get
            {
                if (!(SideATextBox.Text == "" || SideBTextBox.Text == "" || SideCTextBox.Text == ""))
                {
                    return new Triangle(Convert.ToDouble(SideATextBox.Text),
                        Convert.ToDouble(SideBTextBox.Text), Convert.ToDouble(SideCTextBox.Text));
                }
                return null;
            }
        }

        /// <summary>
        /// Свойство "только для чтения"
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                _readOnly = value;
                SideATextBox.ReadOnly = value;
                SideCTextBox.ReadOnly = value;
                SideBTextBox.ReadOnly = value;
            }
            get { return _readOnly; }
        }


        /// <summary>
        /// Обработчик изменения текста на всех TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllTriangleTextBox_TextChanged(object sender, EventArgs e)
        {
            double sideA;
            double sideB;
            double sideC;
            if (double.TryParse(SideATextBox.Text, out sideA)
                && double.TryParse(SideBTextBox.Text, out sideB) && double.TryParse(SideCTextBox.Text, out sideC)
                && sideA > 0 && sideB > 0 && sideC > 0)
            {
                try
                {
                    TextBoxControl.AreaLengthBoxes = new Triangle(sideA, sideB, sideC);
                    ToolTipTriangle.RemoveAll();
                    ToolTipShown = false;
                }
                catch (ArgumentException)
                {
                    ToolTipShown = true;
                    ToolTipTriangle.Show("Triangle is not Valid", TextBoxControl);
                }
            }
            else
            {
                TextBoxControl.AreaLengthBoxes = null;
            }
        }
    }
}