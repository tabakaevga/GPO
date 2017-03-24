using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using ModelArea;
using ModelView.Tools;

namespace ModelView
{
    public partial class StartingForm : Form
    {
        private BindingList<IFigure> _figures = new BindingList<IFigure>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StartingForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _figures;
        }

        /// <summary>
        /// Кнопка "Добавить объект"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            var addFigure = new AddingForm {Owner = this};
            addFigure.ShowDialog();
            _figures.Add(addFigure.Figure);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _figures;
        }

        /// <summary>
        /// Кнопка "Удалить объект"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row); 
            }
        }

        /// <summary>
        /// Кнопка "Сохранить как"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Событие Файл-диалога, сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DataHandler.SerializeBinary(saveFileDialog.FileName, ref _figures);
        }

        /// <summary>
        /// Событие Файл-диалога, открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
