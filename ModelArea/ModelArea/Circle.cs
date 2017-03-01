using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IFigure
    {
        #region Private members
        private double _radius;
        #endregion
        //TODO: Наверное нужны пробелы между функцией, и комментами для другой функцией

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
            Radius = radius;
        }
        
        /// <summary>
        /// Свойство радиус окружности.
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
                
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Значение радиуса окружности не может быть меньше либо равно 0");
                }
                else
                {
                    _radius = value;
                }
            }
        }
        /// <summary>
        /// Свойство длины окружности.
        /// </summary>
        public double Length
        {
            get
            {
                return 2 * Math.PI * _radius;
            }
        }

        /// <summary>
        /// Свойство площади окружности.
        /// </summary>
        // NOTE: Если ты делаешь получение типа через лямбда выражение, почему бы и тут не сделать ? ) 
        public double Area
        {
            get
            {
                return 3.14 * Math.Pow(_radius, 2);
            }
            
        }
    }
}
