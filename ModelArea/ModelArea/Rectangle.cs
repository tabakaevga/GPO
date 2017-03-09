using System;

namespace ModelArea
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle : IFigure
    {
        #region Private members

        private double _sideA;
        private double _sideB;

        #endregion

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина) </param>
        /// <param name="sideB"> Сторона B (высота) </param>
        public Rectangle(double sideA, double sideB)
        {
            if ((sideA <= 0) || (sideB <=0))
            {
                throw new ArgumentOutOfRangeException($"Длина стороны B не может быть меньше либо равна 0");
            }
            else
            {
                _sideA = sideA;
                _sideB = sideB;
            }
        }
        
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public FigureType FigureType => FigureType.Rectangle;

        /// <summary>
        /// Свойство периметр прямоугольника
        /// </summary>
        public double Length => (_sideA + _sideB) * 2;

        /// <summary>
        /// Свойство площадь прямоугольника
        /// </summary>
        public double Area => _sideA * _sideB;
    }

    
}
