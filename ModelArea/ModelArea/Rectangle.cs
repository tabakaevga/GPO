using System;
using System.Runtime.Serialization;
using ModelArea.Tools;

namespace ModelArea
{
    /// <summary>
    ///     Прямоугольник
    /// </summary>
    [Serializable]
    public class Rectangle : IFigure
    {
        /// <summary>
        ///     Конструктор класса Rectangle
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина) </param>
        /// <param name="sideB"> Сторона B (высота) </param>
        public Rectangle(double sideA, double sideB)
        {
            CheckCorrectInput.CheckDouble(sideA);
            CheckCorrectInput.CheckDouble(sideB);
            Width = sideA;
            Height = sideB;
        }

        /// <summary>
        ///     Ширина прямоугольника
        /// </summary>
        public double Width { get; }

        /// <summary>
        ///     Высота прямоугольника
        /// </summary>
        public double Height { get; }

        /// <summary>
        ///     Тип фигуры
        /// </summary>
        [DataMember]
        public FigureType FigureType => FigureType.Rectangle;

        /// <summary>
        ///     Свойство периметр прямоугольника
        /// </summary>
        [DataMember]
        public double Length => (Width + Height) * 2;

        /// <summary>
        ///     Свойство площадь прямоугольника
        /// </summary>
        [DataMember]
        public double Area => Width * Height;

        #region Private members

        #endregion
    }
}