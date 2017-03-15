using System;

namespace ModelArea
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IFigure
    {
        #region Private members

<<<<<<< HEAD
        private readonly double _radius;
=======
        private double _radius;

        private static void CheckIfNaNOrInf(double radius)
        {
            if (double.IsNaN(radius) || double.IsInfinity(radius))
            {
                throw new ArgumentException($"Введенные данные - не вещественное число.");
            }
        }
>>>>>>> Development

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
<<<<<<< HEAD
=======
            CheckIfNaNOrInf(radius);
>>>>>>> Development
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
