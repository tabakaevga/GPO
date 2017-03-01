using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private bool CheckSides(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        public FigureType FigureType => FigureType.Triangle;
        

        public Triangle(double sideA, double sideB, double sideC)
        {

            if (CheckSides(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideС = sideC;
            }
            else
            {
                throw new ArgumentException($"Такой треугольник существовать не может.");
            }
        }
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
        public double SideС
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Длина стороны C не может быть меньше либо равна 0");
                }
                else
                {
                    _sideC = value;
                }
            }
        }

       

        public double Length
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
        public double Area
        {
            get
            {
                if (CheckSides(_sideA, _sideB, _sideC))
                {
                    double p = Length * 0.5;
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
