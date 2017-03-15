using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;

namespace WindowsFormsApplication1
{
    //TODO: Поменять название с Форм1 на что-то более понятное
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TODO: Изменить название метода.
        private void button1_Click(object sender, EventArgs e)
        {
            AddingObjects addFigure = new AddingObjects();
            //TODO: Может стоит показать форму как диалог, что бы заблокировать управление главной формой?
            addFigure.Show();
        }
    }
}
