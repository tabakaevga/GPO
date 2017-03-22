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
    public partial class StartingForm : Form
    {
        private BindingList<IFigure> _figures = new BindingList<IFigure>();
        public StartingForm()
        {
            InitializeComponent();
            
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            AddingForm addFigure = new AddingForm();
            addFigure.ShowDialog();
            _figures.Add(AddingForm.FigureAdded);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _figures;
        }

        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); 
            }
        }
    }
}
