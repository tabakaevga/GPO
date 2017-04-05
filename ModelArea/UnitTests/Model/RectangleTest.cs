using System;
using ModelArea;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    ///     Набор тестов для класса Rectangle
    /// </summary>
    [TestFixture]
    internal class RectangleTest
    {
        /// <summary>
        ///     Набор тестовых случаев для свойства Area
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина)</param>
        /// <param name="sideB"> Сторона B (длина)</param>
        [Test]
        [TestCase(5, 2, TestName = "Тестирование Area при сторонах = 5 и 2.")]
        [TestCase(5, -1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при стороне = 5 и ошибочной стороне = -1.")]
        [TestCase(-5, 1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при ошибочной стороне = -5 и 1.")]
        [TestCase(-5, -1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при ошибочных сторонах = -5 и -1.")]
        [TestCase(5, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при обеих ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void AreaTest(double sideA, double sideB)
        {
            var rectangle = new Rectangle(sideA, sideB);
            Assert.AreEqual(sideA * sideB, rectangle.Area);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Length
        /// </summary>
        /// <param name="sideA"> Сторона А (ширина)</param>
        /// <param name="sideB"> Сторона B (длина)</param>
        [Test]
        [TestCase(5, 2, TestName = "Тестирование Length при сторонах = 5 и 2.")]
        [TestCase(5, -1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при стороне = 5 и ошибочной стороне = -1.")]
        [TestCase(-5, 1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при ошибочной стороне = -5 и 1.")]
        [TestCase(-5, -1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при ошибочных сторонах = -5 и -1.")]
        [TestCase(5, "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", 5, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочной стороне не выраженной вещественным числом.")]
        [TestCase("asdf", "asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при обеих ошибочных сторонах не выраженных вещественным числом.")]
        [TestCase(double.NaN, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне не являющейся числом")]
        [TestCase(5, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне не являющейся числом")]
        [TestCase(double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах не являющихся числом")]
        [TestCase(double.PositiveInfinity, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(5, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах, являющихся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, 5, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(5, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочной стороне, являющейся отрицательной бесконечностью")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочных сторонах, являющихся отрицательной бесконечностью")]
        public void LengthTest(double sideA, double sideB)
        {
            var rectangle = new Rectangle(sideA, sideB);
            Assert.AreEqual(2 * (sideA + sideB), rectangle.Length);
        }
    }
}