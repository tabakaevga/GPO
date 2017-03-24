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
using System.Security.Cryptography;

namespace WindowsFormsApplication1
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
        
        /// <summary>
        /// Генерация случайных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateRandomButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                int option = random.Next(0, 3);
                double sideB;
                double sideA;
                switch (option)
                {
                    case 0:
                        double radius = random.NextDouble()*random.Next(1,11);
                        _figures.Add(new Circle(radius ));
                        break;
                    case 1:
                        sideA = random.NextDouble() * random.Next(1, 11);
                        sideB = random.NextDouble() * random.Next(1, 11);
                        _figures.Add(new ModelArea.Rectangle(sideA, sideB));
                        break;
                    case 2:
                        sideA = random.NextDouble() * random.Next(1, 11);
                        sideB = random.NextDouble() * random.Next(1, 11);
                        double sideC = sideA + sideB - 0.000001; 
                        _figures.Add(new Triangle(sideA, sideB, sideC));
                        break;
                }
                    
            }

        }
    }
}
