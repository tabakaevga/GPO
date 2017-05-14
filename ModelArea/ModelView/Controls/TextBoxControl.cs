using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls
{
    public partial class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство для текстбоксов площади и длины
        /// </summary>
        public IFigure AreaLengthBoxes
        {
            set
            {
                if (value == null)
                {
                    AreaTextBox.Text = "";
                    LengthTextBox.Text = "";
                }
                else
                {
                    AreaTextBox.Text = value.Area.ToString(CultureInfo.CurrentCulture);
                    LengthTextBox.Text = value.Length.ToString(CultureInfo.CurrentCulture);
                }
            }
        }
    }
}
