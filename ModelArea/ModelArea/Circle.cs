using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ModelArea
{
    /// <summary>
    /// Окружность
    /// </summary>
    [DataContract]
    public class Circle : IFigure
    {
        #region Private members

        private readonly double _radius;

        #endregion

        /// <summary>
        /// Тип фигуры.
        /// </summary>
        [DataMember]
        public FigureType FigureType => FigureType.Circle;

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            CheckCorrectInput.CheckDouble(radius);
            _radius = radius;
        }
       
        /// <summary>
        /// Свойство длины окружности.
        /// </summary>
        [DataMember]
        public double Length => 2 * Math.PI * _radius;

        /// <summary>
        /// Свойство площади окружности.
        /// </summary>
        [DataMember]
        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}
