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
        /// <summary> //TODO: Не стоит писать название свойства - оперируйте терминами предметной области (площадь, периметр и пр.)
        ///     Набор тестовых случаев для свойства Area
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [Test]
        [TestCase(5, TestName = "Тестирование Area при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Area при радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Area при радиусе, явлюящимся отрицательной бесконечностью")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Area);
        }

        /// <summary>
        ///     Набор тестовых случаев для свойства Length
        /// </summary>
        /// <param name="radius"> Радиус окружности</param>
        [Test]
        [TestCase(5, TestName = "Тестирование Length при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тестирование Length при радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Length при радиусе не выраженном вещественным числом.")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при радиусе не являющимся числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при радиусе, являющимся положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование Length при радиусе, являющимся отрицательной бесконечностью")]
        public void LengthTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * 2 * radius, circle.Length);
        }
    }
}