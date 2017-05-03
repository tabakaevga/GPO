using System;
using System.Windows.Forms;
using ModelArea;

namespace ModelView
{
    public partial class ModifyObject : Form
    {
        /// <summary>
        ///     Переменная отвечающая за закрытие формы
        /// </summary>
        private bool _adding;

        /// <summary>
        ///     Конструктор для добавления элемента
        /// </summary>
        public ModifyObject()
        {
            InitializeComponent();
            Text = @"Add Object";
        }

        /// <summary>
        ///     Конструктор для изменения элемента
        /// </summary>
        /// <param name="figure"> Элемент из списка главной формы</param>
        public ModifyObject(IFigure figure)
        {
            InitializeComponent();
            Text = @"Modify Object";
            FigureControl.Figure = figure;
        }

        /// <summary>
        ///     Отправляемая фигура
        /// </summary>
        public IFigure FigureSent { get; private set; }

        /// <summary>
        ///     Обработчик кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                _adding = true;
                if (!FigureControl.TriangleInvalid)
                {
                    FigureSent = FigureControl.Figure;
                    Close();
                }
                else
                {
                    MessageBox.Show("Triangle is NOT Valid. Try other values", "Triangle Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Value must be above 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///     Обработчик кнопки Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_adding)
                FigureSent = null;
        }
    }
}