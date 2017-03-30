using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelArea.Tools;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов класса CheckCorrectInput
    /// </summary>
    class CheckCorrectInputTest
    {
        [Test]
        [TestCase(-4, ExpectedException = typeof(ArgumentOutOfRangeException), 
            TestName = "Проверка корректности ввода отрицательного числа -4")]
        [TestCase(5, TestName = "Проверка ввода корректного числа 5")]
        [TestCase(double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода не являющегося числом")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода положительной бесконечностью")]
        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Проверка ввода отрицательной бесконечностью")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование Area при радиусе не выраженном вещественным числом.")]
        public void CheckDoubleTest(double input)
        {
            CheckCorrectInput.CheckDouble(input);
        }
    }
}
