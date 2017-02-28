using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelArea;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация нахождения площадей.");
            Console.WriteLine("Площадь окружности с радиусом 4");
            Circle circle = new Circle(4);
            Console.WriteLine("Площадь окружности = {0}", circle.GetArea);
            Console.WriteLine("Площадь прямоугольника со сторонами A=4 и B=3.26");
            Rectangle rectangle = new Rectangle(4, 3.26);
            Console.WriteLine("Площадь прямоугольника = {0}", rectangle.GetArea);
            Console.WriteLine("Площадь треугольника со сторонами А=2, B=3, C=4.2");
            Triangle triangle = new Triangle(2, 3, 4.2);
            Console.WriteLine("Площадь треугольника = {0}", triangle.GetArea);
            Console.Read();
        }
    }
}
