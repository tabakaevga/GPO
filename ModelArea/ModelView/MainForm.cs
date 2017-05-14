using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ModelArea;
using ModelView.Tools;

namespace ModelView
{
    public partial class MainForm : Form
    {
        private BindingList<IFigure> _figures = new BindingList<IFigure>();
        private BindingList<IFigure> _figuresSearched;


        /// <summary>
        ///     Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DataGridView.DataSource = _figures;
            _figuresSearched = null;
#if DEBUG
            GenerateRandomButton.Visible = true;
#endif
        }

        public MainForm(string filepath)
        {
            InitializeComponent();
            try
            {
                Serializer.DeserializeBinary(filepath, ref _figures);
                DataGridView.DataSource = null;
                DataGridView.DataSource = _figures;
            }
            catch (Exception)
            {
                MessageBox.Show(@"File is damaged.", @"Opening error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _figuresSearched = null;
#if DEBUG
            GenerateRandomButton.Visible = true;
#endif
        }

        /// <summary>
        ///     Кнопка "Удалить объект"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                if (_figuresSearched != null && _figuresSearched.Any())
                    if (DataGridView.CurrentRow != null)
                    {
                        var currentFigure = (IFigure) DataGridView.CurrentRow.DataBoundItem;
                        _figures.Remove(currentFigure);
                    }
                DataGridView.Rows.Remove(row);
            }
        }

        /// <summary>
        ///     Кнопка "Сохранить как"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        ///     Событие Файл-диалога, сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Serializer.SerializeBinary(saveFileDialog.FileName, ref _figures);
        }

        /// <summary>
        ///     Кнопка "Открыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        /// <summary>
        ///     Событие Файл-диалога, открытие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Serializer.DeserializeBinary(openFileDialog.FileName, ref _figures);
                DataGridView.DataSource = null;
                DataGridView.DataSource = _figures;
            }
            catch (Exception)
            {
                MessageBox.Show(@"File is damaged.", @"Opening error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Генерация случайных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateRandomButton_Click(object sender, EventArgs e)
        {
#if DEBUG
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                var option = random.Next(0, 3);
                double sideB;
                double sideA;
                switch (option)
                {
                    case 0:
                        var radius = random.NextDouble() * random.Next(1, 11);
                        _figures.Add(new Circle(radius));
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
        ///     Кнопка Найти объекты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchingObjectsButton_Click(object sender, EventArgs e)
        {
            _figuresSearched = _figures;
            var searchFigures = new SearchingForm(_figuresSearched) {Owner = this};
            searchFigures.ShowDialog();
            if (_figuresSearched != searchFigures.FigureList)
                ReturnListButton.Visible = true;
            _figuresSearched = searchFigures.FigureList;
            DataGridView.DataSource = null;
            DataGridView.DataSource = _figuresSearched;
        }

        /// <summary>
        ///     Кнопка возврата списка к начальному состоянию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnListButton_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = _figures;
            ReturnListButton.Visible = false;
        }

        /// <summary>
        ///     Обработчик выбора элемента в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count == 1)
            {
                if (DataGridView.CurrentRow != null)
                    AddOrModifyObjectButton.Text = "Modify Object";
            }
            else
            {
                AddOrModifyObjectButton.Text = "Add Object";
            }
        }

        /// <summary>
        ///     Кнопка добавления или изменения объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrModifyObjectButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count == 1)
            {
                if (DataGridView.CurrentRow != null)
                {
                    var figure = _figures.ElementAt(DataGridView.CurrentRow.Index);
                    var modFigure = new ModifyObject(figure);
                    modFigure.ShowDialog();

                    figure = modFigure.FigureSent;
                    if (figure != null)
                    {
                        if (_figures.Count == 1)
                        {
                            _figures.RemoveAt(DataGridView.CurrentRow.Index);
                            _figures.Add(figure);
                        }
                        else
                        {
                            _figures.RemoveAt(DataGridView.CurrentRow.Index);
                            _figures.Insert(DataGridView.CurrentRow.Index, figure);
                        }
                    }
                }
            }
            else
            {
                var addFigure = new ModifyObject();
                addFigure.ShowDialog();
                if (addFigure.FigureSent != null)
                    _figures.Add(addFigure.FigureSent);
            }


            DataGridView.DataSource = null;
            DataGridView.DataSource = _figures;
        }
    }
}