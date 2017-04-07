using System;
using System.Runtime.Serialization;
using ModelArea.Tools;

namespace ModelArea
{
    /// <summary>
    ///     Окружность
    /// </summary>
    [Serializable]
    public class Circle : IFigure
    {
        #region Private members

        private readonly double _radius;

        #endregion

        /// <summary>
        ///     Конструктор класса Circle
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            CheckCorrectInput.CheckDouble(radius);
            _radius = radius;
        }

        /// <summary>
        ///     Тип фигуры.
        /// </summary>
        [DataMember]
        public FigureType FigureType => FigureType.Circle;

        /// <summary>
        ///     Свойство длины окружности.
        /// </summary>
        [DataMember]
        public double Length => 2 * Math.PI * _radius;

        /// <summary>
        ///     Свойство площади окружности.
        /// </summary>
        [DataMember]
        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}