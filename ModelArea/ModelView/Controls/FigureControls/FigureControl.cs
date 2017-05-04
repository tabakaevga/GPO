using System;
using System.Windows.Forms;
using ModelArea;

namespace ModelView.Controls.FigureControls
{
    public partial class FigureControl : UserControl
    {
        /// <summary>
        ///     Тип фигуры
        /// </summary>
        private FigureType _figureType;

        /// <summary>
        ///     Объект свойства фигуры
        /// </summary>
        private IFigure _objectFigure;

        /// <summary>
        ///     Конструктор Контрола
        /// </summary>
        public FigureControl()
        {
            InitializeComponent();
            if (Figure != null)
                FiguresComboBox.SelectedIndex = (int) Figure.FigureType;
        }

        public bool TriangleInvalid => TriangleControl.ToolTipShown;

        /// <summary>
        ///     Свойство фигуры
        /// </summary>
        public IFigure Figure
        {
            get
            {
                switch (_figureType)
                {
                    case FigureType.Circle:
                        return CircleControl.ObjectCircle;
                    case FigureType.Rectangle:
                        return RectangleControl.ObjectRectangle;
                    case FigureType.Triangle:
                        return TriangleControl.ObjectTriangle;
                }
                throw new ArgumentNullException("Не выбран тип объекта");
            }
            set
            {
                _objectFigure = value;
                if (value != null)
                    switch (value.FigureType)
                    {
                        case FigureType.Circle:
                            FiguresComboBox.SelectedIndex = 0;
                            CircleControl.ObjectCircle = (Circle) _objectFigure;
                            break;
                        case FigureType.Triangle:
                            FiguresComboBox.SelectedIndex = 1;
                            TriangleControl.ObjectTriangle = (Triangle) _objectFigure;
                            break;
                        case FigureType.Rectangle:
                            FiguresComboBox.SelectedIndex = 2;
                            RectangleControl.ObjectRectangle = (Rectangle) _objectFigure;
                            break;
                        default:
                            return;
                    }
            }
        }

        /// <summary>
        ///     Обработчик изменения индекса Комбобокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiguresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FiguresComboBox.SelectedIndex)
            {
                case 0:
                    _figureType = FigureType.Circle;
                    CircleControl.Visible = true;
                    TriangleControl.Visible = false;
                    RectangleControl.Visible = false;
                    break;
                case 1:
                    _figureType = FigureType.Triangle;
                    CircleControl.Visible = false;
                    TriangleControl.Visible = true;
                    RectangleControl.Visible = false;
                    break;
                case 2:
                    _figureType = FigureType.Rectangle;
                    CircleControl.Visible = false;
                    TriangleControl.Visible = false;
                    RectangleControl.Visible = true;
                    break;
            }
        }
    }
}