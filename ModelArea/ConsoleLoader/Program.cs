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

        private static double InputSide()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация нахождения площадей.");
            Console.WriteLine("Площадь окружности с радиусом 4");
            IFigure circleTest = new Circle(4);
            Console.WriteLine("Площадь окружности = {0}", circleTest.Area);
            Console.WriteLine("Площадь прямоугольника со сторонами A=4 и B=3.26");
            IFigure rectangleTest = new Rectangle(4, 3.26);
            Console.WriteLine("Площадь прямоугольника = {0}", rectangleTest.Area);
            Console.WriteLine("Площадь треугольника со сторонами А=2, B=3, C=4.2");
            IFigure triangleTest = new Triangle(2, 3, 4.2);
            Console.WriteLine("Площадь треугольника = {0}", triangleTest.Area);
            //Ты далее демонстрируешь нахождение площадей, может можно сделать выбор(автодемонстрация или ручная проверка)
            while (true)
            {
                WelcomeToDemo();
                //TODO: Может стоит сделать метод, который будет предоставлять меню для ввода.
                //Т.е. будет выводиться не только список действий, и потом ты в коде будешь считывать данные с консоли
                //Но и считываение данные будет происходить в методе.
                //тогда ты можешь запихать все в цикл.
                //и сделать как то так
                /*
                 * int WhatDoYouWant()
                 * {
                 *  .....
                 * }
                 *  ......
                 *  while (WhatDoYouWant()!=-1) do
                 *  {
                 *      ......Действия
                 *  }
                 *  Или сделать enum с действиями и работать не с цифрами а с ним.
                 */
                int option = Convert.ToInt32(Console.ReadLine());
                //TODO:
                IFigure figure;
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Введите радиус (вещ. число)");
                        figure = new Circle(InputSide());
                        Console.WriteLine("Площадь окружности = {0}", figure.Area);
                        break;
                    case 2:
                        Console.WriteLine("Введите ширину и длину А и B (вещ. числа)");
                        figure = new Rectangle(InputSide(), InputSide());
                        Console.WriteLine("Площадь прямоугольника = {0}",  figure.Area);
                        break;
                    case 3:
                        Console.WriteLine("Введите стороны A, B, C (вещ. числа)");
                        figure = new Triangle(InputSide(), InputSide(), InputSide());
                        Console.WriteLine("Площадь треугольника = {0}", figure.Area);
                        break;
                    case 4:
                        Console.WriteLine("Введите радиус (вещ. число)");
                        figure = new Circle(InputSide());
                        Console.WriteLine("Длина окружности = {0}", figure.Length);
                        break;
                    case 5:
                        Console.WriteLine("Введите ширину и длину А и B (вещ. числа)");
                        figure = new Rectangle(InputSide(), InputSide());
                        Console.WriteLine("Периметр прямоугольника = {0}", figure.Length );
                        break;
                    case 6:
                        Console.WriteLine("Введите стороны A, B, C (вещ. числа)");
                        figure = new Triangle(InputSide(), InputSide(), InputSide());
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
