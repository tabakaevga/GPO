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
        public void CheckDoubleTest(double input)
        {
            CheckCorrectInput.CheckDouble(input);
        }
    }
}
