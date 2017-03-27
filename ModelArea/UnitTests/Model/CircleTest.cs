using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelArea;
using NUnit.Framework;


namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса Circle
    /// </summary>
    [TestFixture]
    class CircleTest
    {
        [Test]
        [TestCase(5,  TestName = "Тестирование Area при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException), 
            TestName = "Тестирование Area при радиусе = -1.")]
        [TestCase("asdf", ExpectedException = typeof(ArgumentException), 
            TestName = "Тестирование Area при радиусе не выраженном вещественным числом.")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Area);
            
        }
        [Test]
        [TestCase(5, TestName = "Тестирование Length при радиусе = 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Length при радиусе = -1.")]
        public void LengthTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * 2 * radius, circle.Length);

        }


    }
}
