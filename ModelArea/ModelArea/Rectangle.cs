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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        private bool CheckIfNaNOrInf(double sideA, double sideB)
=======
        private void ChecksCorrectInput(double sideA, double sideB)
>>>>>>> Development
        {
            if (double.IsNaN(sideA) || double.IsInfinity(sideA) || double.IsNaN(sideB) || double.IsInfinity(sideB))
            {
                throw new ArgumentException($"Введенные данные - не вещественное число.");
            }
            if ((sideA <= 0) || (sideB <= 0))
            {
                throw new ArgumentOutOfRangeException($"Длина стороны B не может быть меньше либо равна 0");
            }

        }
=======
        
>>>>>>> Development

>>>>>>> Development
        #endregion

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина) </param>
        /// <param name="sideB"> Сторона B (высота) </param>
        public Rectangle(double sideA, double sideB)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
            CheckIfNaNOrInf(sideA, sideB);
>>>>>>> Development
            if ((sideA <= 0) || (sideB <=0))
            {
                throw new ArgumentOutOfRangeException($"Длина стороны B не может быть меньше либо равна 0");
            }
            else
            {
                _sideA = sideA;
                _sideB = sideB;
            }
=======
            ChecksCorrectInput(sideA, sideB);
=======
            CheckCorrectInput.CheckDouble(sideA);
            CheckCorrectInput.CheckDouble(sideB);
>>>>>>> Development
            _sideA = sideA;
            _sideB = sideB;
>>>>>>> Development
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
