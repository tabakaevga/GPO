using System;
using System.Globalization;
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
                    RadiusTextBox.Text = Convert.ToString(value.Length / (2 * Math.PI), CultureInfo.CurrentCulture);
                    TextBoxControl.AreaLengthBoxes = value;
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
                if (double.TryParse(RadiusTextBox.Text, out radius) && radius > 0)
                {
                    TextBoxControl.AreaLengthBoxes = new Circle(radius);
                }
                else
                {
                    TextBoxControl.AreaLengthBoxes = null;
                }
            }
        }
    }
}