using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    class Triangle : IForm
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0  || sideC <=0)
            {
                throw new ArgumentOutOfRangeException($"Стороны не могут быть длиной меньше 0");
            }
            else
            if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA) )
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
            {
                throw new ArgumentException($"Такой треугольник существовать не может.");
            }
        }
        public FormType Type => FormType.Triangle;
        public double GetResult()
        {
            double p = (_sideA + _sideB + _sideC) * 0.5;
            return Math.Pow(p * (p - _sideA) * (p - _sideB) * (p - _sideC), 0.5);
        }
    }
}
