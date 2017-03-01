using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : IFigure
    {
        private double _sideA;
        private double _sideB;

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public FigureType FigureType => FigureType.Rectangle;
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

        public double Length
        {
            get
            {
                return (_sideA + _sideB) * 2;
            }
        }
        public double Area
        {
            get
            {
                return _sideA * _sideB;
            }
        }
    }

    
}
