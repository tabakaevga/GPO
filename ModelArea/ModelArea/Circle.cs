using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    class Circle : IForm
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException($"Радиус круга не может быть меньше либо равен нулю.");
            }
            else
            {
                _radius = radius;
            }
           
        }
        public FormType Type => FormType.Circle;
        public double GetResult()
        {
            return 3.14 * Math.Pow(_radius, 2);
        }
    }
}
