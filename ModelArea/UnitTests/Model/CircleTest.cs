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
        [TestCase(5, TestName = "Тестирование Area при радиусе = 5.")]
        [TestCase(0, TestName = "Тестирование Area при радиусе = 0.")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.Area);
            
        }
    }
}
