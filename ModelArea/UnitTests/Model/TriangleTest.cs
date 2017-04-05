using System;
using ModelArea;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    ///     Набор тестов класса Triangle
    /// </summary>
    [TestFixture]
    internal class TriangleTest
    {
        /// <summary>
        ///     Набор тестовых случаев для свойства Площадь
        /// </summary>
        /// <param name="sideA"> Сторона А</param>
        /// <param name="sideB"> Сторона B</param>
        /// <param name="sideC"> Сторона C</param>
        [Test]
        [TestCase(5, 2, 6, TestName = "Тестирование площади при сторонах = 5, 2, 6.")]
        [TestCase(2, 5, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование площади при сторонах, при которых треугольник не существует (sideA).")]
        [TestCase(2, 2, 5,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование площади при сторонах, при которых треугольник не существует (sideB).")]
        [TestCase(5, 2, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование площади при сторонах, при которых треугольник не существует (sideC).")]
        [TestCase(5, -2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование площади при сторонах = 5, (ошибочная)-1, 6.")]
        [TestCase(-5, 2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование площади при сторонах = (ошибочная)-5, 2, 6.")]
        [TestCase(5, 2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование площади при сторонах = 5, 2, (ошибочная)-6.")]
        [TestCase(-5, -2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование площади при ошибочных сторонах = -5, -2, -6.")]
        [TestCase(5, "asdf", 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование площади при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase(5, 2, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование площади при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование площади при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование площади при трех ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне не являющейся числом")]
        [TestCase(5, 6, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, 6, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, 6, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void AreaTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var p = 0.5 * (sideA + sideB + sideC);
            Assert.AreEqual(Math.Pow(p * (p - sideA) * (p - sideB) * (p - sideC), 0.5), triangle.Area);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Периметр
        /// </summary>
        /// <param name="sideA"> Сторона А</param>
        /// <param name="sideB"> Сторона B</param>
        /// <param name="sideC"> Сторона C</param>
        [Test]
        [TestCase(5, 2, 6, TestName = "Тестирование периметра при сторонах = 5, 2, 6.")]
        [TestCase(2, 5, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование периметра при сторонах, при которых треугольник не существует (sideA).")]
        [TestCase(2, 2, 5,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование периметра при сторонах, при которых треугольник не существует (sideB).")]
        [TestCase(5, 2, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование периметра при сторонах, при которых треугольник не существует (sideC).")]
        [TestCase(5, -2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование периметра при сторонах = 5, (ошибочная)-1, 6.")]
        [TestCase(-5, 2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование периметра при сторонах = (ошибочная)-5, 2, 6.")]
        [TestCase(5, 2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование периметра при сторонах = 5, 2, (ошибочная)-6.")]
        [TestCase(-5, -2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование периметра при ошибочных сторонах = -5, -2, -6.")]
        [TestCase(5, "asdf", 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование периметра при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase(5, 2, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование периметра при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование периметра при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование периметра при трех ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне не являющейся числом")]
        [TestCase(5, 6, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, 6, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, 6, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void LengthTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(sideA + sideB + sideC, triangle.Length);
        }
    }
}