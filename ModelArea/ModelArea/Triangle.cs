using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    public class Triangle : IForm
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

       

        public bool CheckSides(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
        public FormType GetType
        {
            get
            {
                return FormType.Triangle;
            }
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0  || sideC <=0)
            {
                throw new ArgumentOutOfRangeException($"Стороны не могут быть длиной меньше 0");
            }
            else
            if (CheckSides(sideA, sideB, sideC))
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
        public double SetSideA
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны не может быть меньше либо равна 0");
                }
                else
                {
                    _sideA = value;
                }
            }
        }
        public double SetSideB
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны не может быть меньше либо равна 0");
                }
                else
                {
                    _sideB = value;
                }
            }
        }
        public double SetSideС
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны не может быть меньше либо равна 0");
                }
                else
                {
                    _sideC = value;
                }
            }
        }

       

        public double GetLength
        {
            get
            {
                if (CheckSides(_sideA, _sideB, _sideC))
                {
                    return _sideA + _sideB + _sideC;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Такой треугольник не существует.");
                }
            }
        }
        public double GetArea
        {
            get
            {
                if (CheckSides(_sideA, _sideB, _sideC))
                {
                    double p = GetLength * 0.5;
                    return Math.Pow(p * (p - _sideA) * (p - _sideB) * (p - _sideC), 0.5);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Такой треугольник не существует.");
                }
                
            }
           
        }

      
    }
}
