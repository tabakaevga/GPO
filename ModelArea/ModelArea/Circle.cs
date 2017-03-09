using System;

namespace ModelArea
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IFigure
    {
        #region Private members

        private readonly double _radius;

        #endregion

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        public FigureType FigureType => FigureType.Circle;

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"Значение радиуса окружности не может быть меньше либо равно 0");
            }
            else
            {
                _radius = radius;
            }
        }
       
        /// <summary>
        /// Свойство длины окружности.
        /// </summary>
        public double Length => 2 * Math.PI * _radius;

        /// <summary>
        /// Свойство площади окружности.
        /// </summary>
        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}
