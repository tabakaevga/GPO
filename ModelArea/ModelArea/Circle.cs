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
        // NOTE: Есть стандартный метод GetType почему бы не сделать через него
        public FormType Type => FormType.Circle;
        
        
        public double GetArea
        {
            get
            {
                return 3.14 * Math.Pow(_radius, 2);
            }
        }
        public double GetLength
        {
            get
            {
                return 2 * 3.14 * _radius;
            }
        }
    }
}
