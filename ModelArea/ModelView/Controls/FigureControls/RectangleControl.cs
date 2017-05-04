using System;
using System.Globalization;
using System.Text.RegularExpressions;
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
                    WidthTextBox.Text = Convert.ToString(value.Width, CultureInfo.InvariantCulture);
                    WidthTextBox.Text = WidthTextBox.Text.Replace('.', ',');
                    HeightTextBox.Text = Convert.ToString(value.Height, CultureInfo.InvariantCulture);
                    HeightTextBox.Text = HeightTextBox.Text.Replace('.', ',');
                    AreaTextBox.Text = Convert.ToString(value.Area, CultureInfo.InvariantCulture);
                    LengthTextBox.Text = Convert.ToString(value.Length, CultureInfo.InvariantCulture);
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
        /// Обработчик нажатия клавиши на все TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllRectangleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[0-9,\b]");
            if (!regex.IsMatch(e.KeyChar.ToString()))
                e.Handled = true;
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
            if (WidthTextBox.Text != "" && double.TryParse(WidthTextBox.Text, out width)
                && WidthTextBox.Text != "0," && WidthTextBox.Text != "0" && HeightTextBox.Text != "" &&
                double.TryParse(HeightTextBox.Text, out height) && HeightTextBox.Text != "0," &&
                HeightTextBox.Text != "0")
            {
                var figure = new Rectangle(width, height);
                AreaTextBox.Text = figure.Area.ToString(CultureInfo.InvariantCulture);
                LengthTextBox.Text = figure.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                AreaTextBox.Text = "";
                LengthTextBox.Text = "";
            }
        }
    }
}