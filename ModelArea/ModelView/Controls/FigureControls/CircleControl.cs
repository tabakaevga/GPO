using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls.FigureControls
{
    public partial class CircleControl : UserControl
    {
        /// <summary>
        ///     Переменная свойства "только для чтения"
        /// </summary>
        private bool _readOnly;

        /// <summary>
        ///     Конструктор контрола Окружности
        /// </summary>
        public CircleControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Свойство Окружность
        /// </summary>
        public Circle ObjectCircle
        {
            set
            {
                if (value != null)
                {
                    RadiusTextBox.Text = Convert.ToString(value.Length / (2 * Math.PI), CultureInfo.InvariantCulture);
                    RadiusTextBox.Text = RadiusTextBox.Text.Replace('.', ',');
                    AreaTextBox.Text = Convert.ToString(value.Area, CultureInfo.InvariantCulture);
                    AreaTextBox.Text = AreaTextBox.Text.Replace('.', ',');
                    LengthTextBox.Text = Convert.ToString(value.Length, CultureInfo.InvariantCulture);
                    LengthTextBox.Text = LengthTextBox.Text.Replace('.', ',');
                }
            }
            get
            {
                if (RadiusTextBox.Text != "")
                    return new Circle(Convert.ToDouble(RadiusTextBox.Text));
                return null;
            }
        }

        /// <summary>
        ///     Свойство "только для чтения"
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                _readOnly = value;
                RadiusTextBox.ReadOnly = value;
                AreaTextBox.ReadOnly = value;
                LengthTextBox.ReadOnly = value;
            }
            get { return _readOnly; }
        }

        /// <summary>
        ///     Обработчик изменяемого Радиуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RadiusTextBox.Focused)
            {
                double radius;
                if (RadiusTextBox.Text != "" && double.TryParse(RadiusTextBox.Text, out radius)
                    && RadiusTextBox.Text != "0," && RadiusTextBox.Text != "0")
                {
                    var figure = new Circle(radius);
                    AreaTextBox.Text = figure.Area.ToString(CultureInfo.InvariantCulture);
                    AreaTextBox.Text = AreaTextBox.Text.Replace('.', ',');
                    LengthTextBox.Text = figure.Length.ToString(CultureInfo.InvariantCulture);
                    LengthTextBox.Text = LengthTextBox.Text.Replace('.', ',');
                }
                else
                {
                    AreaTextBox.Text = "";
                    LengthTextBox.Text = "";
                }
            }
        }

        /// <summary>
        ///     Обработчик нажатия кнопки на всех TextBox контрола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllCircleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[0-9,\b]");
            if (!regex.IsMatch(e.KeyChar.ToString()))
                e.Handled = true;
        }

        /// <summary>
        ///     Обработчик изменяемой Площади
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AreaTextBox.Focused)
            {
                double area;
                if (AreaTextBox.Text != "" && double.TryParse(AreaTextBox.Text, out area)
                    && AreaTextBox.Text != "0," && AreaTextBox.Text != "0")
                {
                    var figure = new Circle(Math.Pow(area / Math.PI, 0.5));
                    LengthTextBox.Text = figure.Length.ToString(CultureInfo.InvariantCulture);
                    LengthTextBox.Text = LengthTextBox.Text.Replace('.', ',');
                    RadiusTextBox.Text = Convert.ToString(Math.Pow(area / Math.PI, 0.5), CultureInfo.InvariantCulture);
                    RadiusTextBox.Text = RadiusTextBox.Text.Replace('.', ',');
                }
                else
                {
                    RadiusTextBox.Text = "";
                    LengthTextBox.Text = "";
                }
            }
        }

        /// <summary>
        ///     Обработчик изменяемой длины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthTextBox.Focused)
            {
                double length;
                if (LengthTextBox.Text != "" && double.TryParse(LengthTextBox.Text, out length)
                    && LengthTextBox.Text != "0," && LengthTextBox.Text != "0")
                {
                    var figure = new Circle(length / (2 * Math.PI));
                    AreaTextBox.Text = figure.Area.ToString(CultureInfo.InvariantCulture);
                    AreaTextBox.Text = AreaTextBox.Text.Replace('.', ',');
                    RadiusTextBox.Text = Convert.ToString(length / (2 * Math.PI), CultureInfo.InvariantCulture);
                    RadiusTextBox.Text = RadiusTextBox.Text.Replace('.', ',');
                }
                else
                {
                    AreaTextBox.Text = "";
                    RadiusTextBox.Text = "";
                }
            }
        }
    }
}