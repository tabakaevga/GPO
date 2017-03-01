using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            Console.WriteLine("5) Вычисление периметра прямоугольника");
            Console.WriteLine("6) Вычисление периметра треугольника");
            Console.WriteLine("0) Выход из меню");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация нахождения площадей.");
            Console.WriteLine("Площадь окружности с радиусом 4");
            Circle circle = new Circle(4);
            Console.WriteLine("Площадь окружности = {0}", circle.Area);
            Console.WriteLine("Площадь прямоугольника со сторонами A=4 и B=3.26");
            Rectangle rectangle = new Rectangle(4, 3.26);
            Console.WriteLine("Площадь прямоугольника = {0}", rectangle.Area);
            Console.WriteLine("Площадь треугольника со сторонами А=2, B=3, C=4.2");
            Triangle triangle = new Triangle(2, 3, 4.2);
            Console.WriteLine("Площадь треугольника = {0}", triangle.Area);

            bool breakingEverything = false;
            while (true)
            {
                Welcoming();
                int option = Convert.ToInt32(Console.ReadLine());
                if (breakingEverything)
                {
                    break;
                }
                double sideA;
                double sideB;
                double sideC;
                double width;
                double height;
                double radius;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Введите радиус");
                        radius = Convert.ToDouble(Console.ReadLine());
                        circle.Radius = radius;
                        Console.WriteLine("Площадь окружности = {0}", circle.Area);
                        break;
                    case 2:
                        Console.WriteLine("Введите ширину А");
                        width = Convert.ToDouble(Console.ReadLine());
                        rectangle.SideA = width;
                        Console.WriteLine("Введите ширину B");
                        height = Convert.ToDouble(Console.ReadLine());
                        rectangle.SideB = height;
                        Console.WriteLine("Площадь прямоугольника = {0}", rectangle.Area);
                        break;
                    case 3:
                        Console.WriteLine("Введите ширину А");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        triangle.SideA = sideA;
                        Console.WriteLine("Введите ширину B");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        triangle.SideB = sideB;
                        Console.WriteLine("Введите ширину B");
                        sideC = Convert.ToDouble(Console.ReadLine());
                        triangle.SideB = sideC;
                        Console.WriteLine("Площадь треугольника = {0}", triangle.Area);
                        break;
                    case 4:
                        Console.WriteLine("Введите радиус");
                        radius = Convert.ToDouble(Console.ReadLine());
                        circle.Radius = radius;
                        Console.WriteLine("Площадь окружности = {0}", circle.Area);
                        break;
                        break;
                    case 5:
                        Console.WriteLine("Введите ширину А");
                        width = Convert.ToDouble(Console.ReadLine());
                        rectangle.SideA = width;
                        Console.WriteLine("Введите ширину B");
                        height = Convert.ToDouble(Console.ReadLine());
                        rectangle.SideB = height;
                        Console.WriteLine("Периметр прямоугольника = {0}", rectangle.Length);
                        break;
                    case 6:
                        Console.WriteLine("Введите ширину А");
                        sideA = Convert.ToDouble(Console.ReadLine());
                        triangle.SideA = sideA;
                        Console.WriteLine("Введите ширину B");
                        sideB = Convert.ToDouble(Console.ReadLine());
                        triangle.SideB = sideB;
                        Console.WriteLine("Введите ширину B");
                        sideC = Convert.ToDouble(Console.ReadLine());
                        triangle.SideB = sideC;
                        Console.WriteLine("Периметр треугольника = {0}", triangle.Length);
                        break;
                    case 0:
                        breakingEverything = true;
                        break;
                    default:
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
