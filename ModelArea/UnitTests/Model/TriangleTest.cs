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
        ///     Набор тестовых случаев для свойства Area
        /// </summary>
        /// <param name="sideA"> Сторона А</param>
        /// <param name="sideB"> Сторона B</param>
        /// <param name="sideC"> Сторона C</param>
        [Test]
        [TestCase(5, 2, 6, TestName = "Тестирование Area при сторонах = 5, 2, 6.")]
        [TestCase(5, 2, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование Area при сторонах, при которых треугольник не существует")]
        [TestCase(5, -2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при сторонах = 5, (ошибочная)-1, 6.")]
        [TestCase(-5, 2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при сторонах = (ошибочная)-5, 2, 6.")]
        [TestCase(5, 2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при сторонах = 5, 2, (ошибочная)-6.")]
        [TestCase(-5, -2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при ошибочных сторонах = -5, -2, -6.")]
        [TestCase(5, "asdf", 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase(5, 2, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при трех ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне не являющейся числом")]
        [TestCase(5, 6, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, 6, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, 6, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void AreaTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var p = 0.5 * (sideA + sideB + sideC);
            Assert.AreEqual(Math.Pow(p * (p - sideA) * (p - sideB) * (p - sideC), 0.5), triangle.Area);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Length
        /// </summary>
        /// <param name="sideA"> Сторона А</param>
        /// <param name="sideB"> Сторона B</param>
        /// <param name="sideC"> Сторона C</param>
        [Test]
        [TestCase(5, 2, 6, TestName = "Тестирование Length при сторонах = 5, 2, 6.")]
        [TestCase(5, 2, 2,
            ExpectedException = typeof(ArgumentException), ExpectedMessage = "Такой треугольник существовать не может",
            TestName = "Тестирование Length при сторонах, при которых треугольник не существует")]
        [TestCase(5, -2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при сторонах = 5, (ошибочная)-1, 6.")]
        [TestCase(-5, 2, 6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при сторонах = (ошибочная)-5, 2, 6.")]
        [TestCase(5, 2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при сторонах = 5, 2, (ошибочная)-6.")]
        [TestCase(-5, -2, -6, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при ошибочных сторонах = -5, -2, -6.")]
        [TestCase(5, "asdf", 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase(5, 2, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, 6, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при трех ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне не являющейся числом")]
        [TestCase(5, 6, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, 6, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, 6, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, 6, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
            ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void LengthTest(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            Assert.AreEqual(sideA + sideB + sideC, triangle.Length);
        }
    }
}