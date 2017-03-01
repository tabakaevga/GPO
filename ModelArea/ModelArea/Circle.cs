using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    public class Circle : IFigure
    {
        private double _radius;

        public FigureType FigureType => FigureType.Circle;

        public Circle(double radius)
        {
            Radius = radius;
        }

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
        public double Length
        {
            get
            {
                return 2 * Math.PI * _radius;
            }
        }
        public double Area
        {
            get
            {
                return 3.14 * Math.Pow(_radius, 2);
            }
        }
        
    }
}
