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
        static void Welcoming()
        {
            Console.WriteLine("Введите цифру для выбора функции:");
            Console.WriteLine("1) Вычисление площади окружности");
            Console.WriteLine("2) Вычисление площади прямоугольника");
            Console.WriteLine("3) Вычисление площади треугольника");
            Console.WriteLine("4) Вычисление длины окружности");
            Console.WriteLine("5) Вычисление длины прямоугольника");
            Console.WriteLine("6) Вычисление длины треугольника");
            Console.WriteLine("0) Выход из меню");

        }
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

            bool breakingEverything = false;
            while (true)
            {
                Welcoming();
                int option = Convert.ToInt32(Console.ReadLine());
                if (breakingEverything)
                {
                    break;
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Введите радиус");
                        double radius = Convert.ToInt32(Console.ReadLine());
                        circle.Radius = radius;
                        Console.WriteLine("Площадь окружности = {0}", circle.GetArea);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 0:
                        breakingEverything = true;
                        break;
                }
                if (breakingEverything)
                {
                    break;
                }

            }
            Console.Read();
        }
    }
}
