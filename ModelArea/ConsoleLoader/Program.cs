using System;
using ModelArea;



namespace ConsoleLoader
{
    class Program
    {
        /// <summary>
        /// Функция приглашения к вводу
        /// </summary>
        private static void WelcomeToDemo()
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

<<<<<<< HEAD
=======
        private static double InputSide()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

>>>>>>> Development
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация нахождения площадей.");
            Console.WriteLine("Площадь окружности с радиусом 4");
<<<<<<< HEAD
            //TODO:
=======
>>>>>>> Development
            IFigure circleTest = new Circle(4);
            Console.WriteLine("Площадь окружности = {0}", circleTest.Area);
            Console.WriteLine("Площадь прямоугольника со сторонами A=4 и B=3.26");
            IFigure rectangleTest = new Rectangle(4, 3.26);
            Console.WriteLine("Площадь прямоугольника = {0}", rectangleTest.Area);
            Console.WriteLine("Площадь треугольника со сторонами А=2, B=3, C=4.2");
            IFigure triangleTest = new Triangle(2, 3, 4.2);
            Console.WriteLine("Площадь треугольника = {0}", triangleTest.Area);

            
            while (true)
            {
                WelcomeToDemo();
                int option = Convert.ToInt32(Console.ReadLine());
                //TODO:
                IFigure figure;
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Введите радиус (вещ. число)");
<<<<<<< HEAD
                        figure = new Circle(Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Circle(InputSide());
>>>>>>> Development
                        Console.WriteLine("Площадь окружности = {0}", figure.Area);
                        break;
                    case 2:
                        Console.WriteLine("Введите ширину и длину А и B (вещ. числа)");
<<<<<<< HEAD
                        figure = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Rectangle(InputSide(), InputSide());
>>>>>>> Development
                        Console.WriteLine("Площадь прямоугольника = {0}",  figure.Area);
                        break;
                    case 3:
                        Console.WriteLine("Введите стороны A, B, C (вещ. числа)");
<<<<<<< HEAD
                        figure = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Triangle(InputSide(), InputSide(), InputSide());
>>>>>>> Development
                        Console.WriteLine("Площадь треугольника = {0}", figure.Area);
                        break;
                    case 4:
                        Console.WriteLine("Введите радиус (вещ. число)");
<<<<<<< HEAD
                        figure = new Circle(Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Circle(InputSide());
>>>>>>> Development
                        Console.WriteLine("Длина окружности = {0}", figure.Length);
                        break;
                    case 5:
                        Console.WriteLine("Введите ширину и длину А и B (вещ. числа)");
<<<<<<< HEAD
                        figure = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Rectangle(InputSide(), InputSide());
>>>>>>> Development
                        Console.WriteLine("Периметр прямоугольника = {0}", figure.Length );
                        break;
                    case 6:
                        Console.WriteLine("Введите стороны A, B, C (вещ. числа)");
<<<<<<< HEAD
                        figure = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
=======
                        figure = new Triangle(InputSide(), InputSide(), InputSide());
>>>>>>> Development
                        Console.WriteLine("Периметр треугольника = {0}", figure.Length);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Введите одну из опций (целое число).");
                        break;
                    
                }
             }
            
        }
    }
}
