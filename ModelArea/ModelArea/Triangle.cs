using System;
using System.Runtime.Serialization;
using ModelArea.Tools;

namespace ModelArea
{
    /// <summary>
    ///     Треугольник.
    /// </summary>
    [Serializable]
    public class Triangle : IFigure
    {
        /// <summary>
        ///     Конструктор класса Triangle
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
        ///     Тип фигуры
        /// </summary>
        [DataMember]
        public FigureType FigureType => FigureType.Triangle;

        /// <summary>
        ///     Свойство длина(периметр) треугольника.
        /// </summary>
        [DataMember]
        public double Length => _sideA + _sideB + _sideC;

        /// <summary>
        ///     Свойство площадь окружности.
        /// </summary>
        [DataMember]
        public double Area
        {
            get
            {
                var p = Length * 0.5;
                return Math.Pow(p * (p - _sideA) * (p - _sideB) * (p - _sideC), 0.5);
            }
        }

        #region Private members

        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        ///     Проверка сторон треугольника на предмет существования данного треугольника
        /// </summary>
        /// <param name="sideA"> Сторона А</param>
        /// <param name="sideB"> Сторона В</param>
        /// <param name="sideC"> Сторона С</param>
        private static void CheckSides(double sideA, double sideB, double sideC)
        {
            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
                throw new ArgumentException("Такой треугольник существовать не может");
        }

        #endregion
    }
}