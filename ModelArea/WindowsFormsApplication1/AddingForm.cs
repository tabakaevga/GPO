using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;

namespace WindowsFormsApplication1
{
    public partial class AddingForm : Form
    {
        private List<IFigure> _figureList;
        private FigureType _figureType;
        public AddingForm()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            double sideA;
            double sideB;
            switch (_figureType)
            {
                case FigureType.Circle :
                    _figureList.Add(new Circle(Convert.ToDouble(textBox4.Text)));
                    break;
                case FigureType.Triangle :
                    sideA = Convert.ToDouble(textBox1.Text);
                    sideB = Convert.ToDouble(textBox2.Text);
                    double sideC = Convert.ToDouble(textBox3.Text);
                    _figureList.Add(new Triangle(sideA, sideB, sideC));
                    break;
                    case FigureType.Rectangle:
                    sideA = Convert.ToDouble(textBox1.Text);
                    sideB = Convert.ToDouble(textBox2.Text);
                    _figureList.Add(new ModelArea.Rectangle(sideA, sideB));
                    break;

            }
        }
    }
}
