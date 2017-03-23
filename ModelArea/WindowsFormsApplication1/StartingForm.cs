using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;

namespace WindowsFormsApplication1
{
    public partial class StartingForm : Form
    {
        public BindingList<IFigure> _figures = new BindingList<IFigure>();
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

        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataHandler.SerializeBinary(saveFileDialog.FileName, ref _figures);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string extension = Path.GetExtension(openFileDialog.FileName);

                DataHandler.DeserializeBinary(openFileDialog.FileName, ref _figures);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _figures;
            }
            catch (SerializationException exception)
            {
                MessageBox.Show("Выберите файл с расширением .fg", "Ошибка формата",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
    }
}
