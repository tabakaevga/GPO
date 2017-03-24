using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ModelArea
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    [Serializable]
    public class Rectangle : IFigure
    {
        #region Private members

        private readonly double _sideA;
        private readonly double _sideB;

        #endregion

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина) </param>
        /// <param name="sideB"> Сторона B (высота) </param>
        public Rectangle(double sideA, double sideB)
        {
            CheckCorrectInput.CheckDouble(sideA);
            CheckCorrectInput.CheckDouble(sideB);
            _sideA = sideA;
            _sideB = sideB;
        }
        
        /// <summary>
        /// Тип фигуры
        /// </summary>
        [DataMember]
        public FigureType FigureType => FigureType.Rectangle;

        /// <summary>
        /// Свойство периметр прямоугольника
        /// </summary>
        [DataMember]
        public double Length => (_sideA + _sideB) * 2;

        /// <summary>
        /// Свойство площадь прямоугольника
        /// </summary>
        [DataMember]
        public double Area => _sideA * _sideB;
    }

    
}
