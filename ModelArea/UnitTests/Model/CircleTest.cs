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
        ///     Набор тестовых случаев для свойства Area
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [Test]
        [TestCase(5, TestName = "Тестирование Area при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при ошибочном радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при ошибочном радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочном радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочном радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при ошибочном радиусе, являющимся отрицательной бесконечностью")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Area);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Length
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [TestCase(5, TestName = "Тестирование Length при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при ошибочном радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при ошибочном радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочном радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочном радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при ошибочном радиусе, являющимсящимся отрицательной бесконечностью")]
        public void LengthTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * 2 * radius, circle.Length);
        }
    }
}