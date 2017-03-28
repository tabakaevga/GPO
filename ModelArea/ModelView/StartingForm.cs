#define DEVERSION
using System;
using System.ComponentModel;
using System.Windows.Forms;
using ModelArea;
using ModelView.Tools;

namespace ModelView
{
    //BUG: Можно добавить пустой объект, если нажать на крестик при выборе фигуры
    //BUG: При переходе на Release не исчезает кнопка генерации случайных фигур
    //BUG: Пользовательский интерфейс должен оформляться в одном стиле: всё по-русски или всё по-английски
    public partial class StartingForm : Form
    {
        private BindingList<IFigure> _figures = new BindingList<IFigure>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StartingForm()
        {
            InitializeComponent();
            DataGridView.DataSource = _figures;
#if DEVERSION
            GenerateRandomButton.Visible = true;
#endif
        }

        public BindingList<IFigure> FigureList => _figures;

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
            DataGridView.DataSource = null;
            DataGridView.DataSource = _figures;
        }

        /// <summary>
        /// Кнопка "Удалить объект"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                DataGridView.Rows.Remove(row); 
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
            DataHandler.DeserializeBinary(openFileDialog.FileName, ref _figures);
            DataGridView.DataSource = null;
            DataGridView.DataSource = _figures;
        }


        /// <summary>
        /// Генерация случайных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateRandomButton_Click(object sender, EventArgs e)
        {
#if DEVERSION
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                var option = random.Next(0, 3);
                double sideB;
                double sideA;
                switch (option)
                {
                    case 0:
                        var radius = random.NextDouble()*random.Next(1,11);
                        _figures.Add(new Circle(radius ));
                        break;
                    case 1:
                        sideA = random.NextDouble() * random.Next(1, 11);
                        sideB = random.NextDouble() * random.Next(1, 11);
                        _figures.Add(new Rectangle(sideA, sideB));
                        break;
                    case 2:
                        sideA = random.NextDouble() * random.Next(1, 11);
                        sideB = random.NextDouble() * random.Next(1, 11);
                        var sideC = sideA + sideB - 0.000001; 
                        _figures.Add(new Triangle(sideA, sideB, sideC));
                        break;
                }
                    
            }
            DataGridView.DataSource = null;
            DataGridView.DataSource = _figures;
#endif
        }

        /// <summary>
        /// Кнопка Найти объекты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingObjectsButton_Click(object sender, EventArgs e)
        {
            var searchFigures = new SearchingForm(_figures) {Owner = this};
            searchFigures.ShowDialog();
            DataGridView.DataSource = null;
            DataGridView.DataSource = searchFigures.FigureList;
        }
    }
}
