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

        public TriangleControl()
        {
            InitializeComponent();
        }

        public bool ToolTipShown { get; private set; }

        public Triangle ObjectTriangle
        {
            set
            {
                if (value != null)
                {
                    SideATextBox.Text = Convert.ToString(value.SideA, CultureInfo.InvariantCulture);
                    SideATextBox.Text = SideATextBox.Text.Replace('.', ',');
                    SideBTextBox.Text = Convert.ToString(value.SideB, CultureInfo.InvariantCulture);
                    SideBTextBox.Text = SideBTextBox.Text.Replace('.', ',');
                    SideCTextBox.Text = Convert.ToString(value.SideB, CultureInfo.InvariantCulture);
                    SideCTextBox.Text = SideCTextBox.Text.Replace('.', ',');
                    AreaTextBox.Text = Convert.ToString(value.Area, CultureInfo.InvariantCulture);
                    LengthTextBox.Text = Convert.ToString(value.Length, CultureInfo.InvariantCulture);
                }
            }
            get
            {
                if (SideATextBox.Text == "" && SideBTextBox.Text == "" && SideCTextBox.Text == "")
                    return new Triangle(Convert.ToDouble(SideATextBox.Text),
                        Convert.ToDouble(SideBTextBox.Text), Convert.ToDouble(SideCTextBox.Text));
                return null;
            }
        }

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

        private void AllTriangleTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[0-9,\b]");
            if (!regex.IsMatch(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void AllTriangleTextBox_TextChanged(object sender, EventArgs e)
        {
            double sideA;
            double sideB;
            double sideC;
            if (SideATextBox.Text != "" && double.TryParse(SideATextBox.Text, out sideA)
                && SideATextBox.Text != "0," && SideATextBox.Text != "0" && SideBTextBox.Text != "" &&
                double.TryParse(SideBTextBox.Text, out sideB) && SideBTextBox.Text != "0," && SideBTextBox.Text != "0" &&
                SideCTextBox.Text != "" && double.TryParse(SideCTextBox.Text, out sideC) && SideCTextBox.Text != "0," &&
                SideCTextBox.Text != "0")
            {
                try
                {
                    var figure = new Triangle(sideA, sideB, sideC);
                    AreaTextBox.Text = figure.Area.ToString(CultureInfo.InvariantCulture);
                    LengthTextBox.Text = figure.Length.ToString(CultureInfo.InvariantCulture);
                    ToolTipTriangle.RemoveAll();
                    ToolTipShown = false;
                }
                catch (ArgumentException)
                {
                    ToolTipShown = true;
                    ToolTipTriangle.Show("Triangle is not Valid", AreaTextBox);
                }
            }
            else
            {
                AreaTextBox.Text = "";
                LengthTextBox.Text = "";
            }
        }
    }
}