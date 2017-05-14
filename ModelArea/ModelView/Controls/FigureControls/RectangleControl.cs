using System;
using System.Globalization;
using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls.FigureControls
{
    public partial class RectangleControl : UserControl
    {
        private bool _readOnly;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public RectangleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство объекта типа Прямоугольник
        /// </summary>
        public Rectangle ObjectRectangle
        {
            set
            {
                if (value != null)
                {
                    WidthTextBox.Text = Convert.ToString(value.Width, CultureInfo.CurrentCulture);
                    HeightTextBox.Text = Convert.ToString(value.Height, CultureInfo.CurrentCulture);
                    TextBoxControl.AreaLengthBoxes = value;
                }
            }
            get
            {
                if (WidthTextBox.Text != "" && HeightTextBox.Text != "")
                    return new Rectangle(Convert.ToDouble(WidthTextBox.Text), Convert.ToDouble(HeightTextBox.Text));
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
                WidthTextBox.ReadOnly = value;
                HeightTextBox.ReadOnly = value;
            }
            get { return _readOnly; }
        }

        /// <summary>
        /// Обработчик изменения текста на всех TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            double width;
            double height;
            if (double.TryParse(WidthTextBox.Text, out width) && 
                double.TryParse(HeightTextBox.Text, out height) && height > 0 && width > 0)
            {
                TextBoxControl.AreaLengthBoxes = new Rectangle(width, height);
            }
            else
            {
                TextBoxControl.AreaLengthBoxes = null;
            }
        }
    }
}