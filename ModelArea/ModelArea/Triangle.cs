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
        private bool CheckSides(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
        private void ChecksCorrectInput(double sideA, double sideB, double sideC)
        {
            if (double.IsNaN(sideA) || double.IsInfinity(sideA) || double.IsNaN(sideB) || double.IsInfinity(sideB)
               || double.IsNaN(sideC) || double.IsInfinity(sideC))
            {
                throw new ArgumentException($"Введенные данные - не вещественное число.");
            }

            if ((sideA <= 0) || (sideB <= 0) || (sideC <= 0))
            {
                throw new ArgumentOutOfRangeException($"Длина стороны B не может быть меньше либо равна 0");
            }

            if (!CheckSides(sideA, sideB, sideC))
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

            ChecksCorrectInput(sideA, sideB, sideC);
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        /// <summary>
        /// Свойство длина(периметр) треугольника.
        /// </summary>
        public double Length
        {
            get
            {
                if (CheckSides(_sideA, _sideB, _sideC))
                {
                    return _sideA + _sideB + _sideC;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Такой треугольник не существует.");
                }
            }
        }
        /// <summary>
        /// Свойство площадь окружности.
        /// </summary>
        public double Area
        {
            get
            {
                if (CheckSides(_sideA, _sideB, _sideC))
                {
                    double p = Length * 0.5;
                    return Math.Pow(p * (p - _sideA) * (p - _sideB) * (p - _sideC), 0.5);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Такой треугольник не существует.");
                }
                
            }
           
        }

      
    }
}
