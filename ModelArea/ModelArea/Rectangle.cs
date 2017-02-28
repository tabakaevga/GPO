using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    class Rectangle : IForm
    {
        private double _sideA;
        private double _sideB;

        // NOTE: Будет удобно если можно будет установить стороны отдельно
        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentOutOfRangeException($"Стороны не могут быть длиной меньше 0");
            }
            else
            {
                _sideA = sideA;
                _sideB = sideB;
            }
        }
        public FormType Type => FormType.Rectangle;
        public double GetResult()
        {
            return _sideA * _sideB;
        }
    }
}
