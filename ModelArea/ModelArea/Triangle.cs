using System;

namespace ModelArea
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IFigure
    {
        #region Private members

        private double _sideA;
        private double _sideB;
        private double _sideC;

        private static void CheckSides(double sideA, double sideB, double sideC)
        {
            if (!((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA)))
            {
                throw new ArgumentException($"Такой треугольник существовать не может");
            }
        }

        #endregion

        /// <summary>
        /// Тип фигуры
        /// </summary>
        public FigureType FigureType => FigureType.Triangle;
        
        /// <summary>
        /// Конструктор класса Triangle
        /// </summary>
        /// <param name="sideA"> Сторона А </param>
        /// <param name="sideB"> Сторона B </param>
        /// <param name="sideC"> Сторона C </param>
        public Triangle(double sideA, double sideB, double sideC)
        {

            CheckCorrectInput.CheckDouble(sideA);
            CheckCorrectInput.CheckDouble(sideB);
            CheckCorrectInput.CheckDouble(sideC);
            CheckSides(sideA, sideB, sideC);
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Свойство длина(периметр) треугольника.
        /// </summary>
        public double Length => _sideA + _sideB + _sideC;

        /// <summary>
        /// Свойство площадь окружности.
        /// </summary>
        public double Area
        {
            get
            {
                double p = Length * 0.5;
                return Math.Pow(p * (p - _sideA) * (p - _sideB) * (p - _sideC), 0.5);
            }

        }

      
    }
}
