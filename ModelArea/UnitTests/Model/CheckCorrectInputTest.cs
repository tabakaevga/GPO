using System;
using ModelArea.Tools;
using NUnit.Framework;

namespace UnitTests.Model
{
    //TODO: Нужны ещё тесты для DataHandler
    /// <summary>
    ///     Набор тестов класса CheckCorrectInput
    /// </summary>
    internal class CheckCorrectInputTest
    {
        /// <summary>
        /// Набор тестовых случаев для метода CheckDouble
        /// </summary>
        /// <param name="input"> Входящие данные</param>
        [Test]
        [TestCase(-4, ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Проверка корректности ввода отрицательного числа -4")]
        [TestCase(5, TestName = "Проверка ввода корректного числа 5")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода не являющегося числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода положительной бесконечностью")]
        [TestCase(double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода отрицательной бесконечностью")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Проверка ввода не выраженном вещественным числом.")]
        public void CheckDoubleTest(double input)
        {
            CheckCorrectInput.CheckDouble(input);
        }
    }
}