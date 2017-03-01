using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

        /// <summary>
        /// Конструктор класса Rectangle
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина) </param>
        /// <param name="sideB"> Сторона B (высота) </param>
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public FigureType FigureType => FigureType.Rectangle;

        /// <summary>
        /// Свойства стороны А
        /// </summary>
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны A не может быть меньше либо равна 0");
                }
                else
                {
                    _sideA = value;
                }
            }
        }

        /// <summary>
        /// Свойства стороны B
        /// </summary>
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны B не может быть меньше либо равна 0");
                }
                else
                {
                    _sideB = value;
                }
            }
        }

        /// <summary>
        /// Свойство периметр прямоугольника
        /// </summary>
        public double Length
        {
            get
            {
                return (_sideA + _sideB) * 2;
            }
        }

        /// <summary>
        /// Свойство площадь прямоугольника
        /// </summary>
        public double Area
        {
            get
            {
                return _sideA * _sideB;
            }
        }
    }

    
}
