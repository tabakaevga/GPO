using System;
using ModelArea;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    ///     Набор тестов для класса Circle
    /// </summary>
    [TestFixture]
    internal class CircleTest
    {
        /// <summary>
        ///     Набор тестовых случаев для свойства Периметр
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [TestCase(5, TestName = "Тестирование периметра при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование периметра при ошибочном радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование периметра при ошибочном радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочном радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочном радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование периметра при ошибочном радиусе, являющимсящимся отрицательной бесконечностью")]
        public void LengthTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * 2 * radius, circle.Length);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Площадь
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [Test]
        [TestCase(5, TestName = "Тестирование площади при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование площади при ошибочном радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование площади при ошибочном радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочном радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочном радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при ошибочном радиусе, являющимся отрицательной бесконечностью")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Area);
        }
    }
}