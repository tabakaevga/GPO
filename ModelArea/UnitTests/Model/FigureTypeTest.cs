using ModelArea;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    internal class FigureTypeTest
    {
        /// <summary>
        ///     Набор тестов для свойства FigureType
        /// </summary>
        /// <param name="figureType"> Тип фигуры</param>
        [Test]
        [TestCase(FigureType.Circle, TestName = "Тест объекта типа \u0022Окружность\u0022.")]
        [TestCase(FigureType.Rectangle, TestName = "Тест объекта типа \u0022Прямоугольник\u0022.")]
        [TestCase(FigureType.Triangle, TestName = "Тест объекта типа \u0022Треугольник\u0022.")]
        [TestCase(5, ExpectedException = typeof(AssertionException), TestName = "Тест объекта несуществующего типа.")]
        public void TypeTest(FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    var circle = new Circle(1);
                    Assert.AreEqual(figureType, circle.FigureType);
                    break;
                case FigureType.Rectangle:
                    var rectangle = new Rectangle(1, 2);
                    Assert.AreEqual(figureType, rectangle.FigureType);
                    break;
                case FigureType.Triangle:
                    var triangle = new Triangle(1, 2, 2);
                    Assert.AreEqual(figureType, triangle.FigureType);
                    break;
                default:
                    Assert.Fail("Других типов нет.");
                    break;
            }
        }
    }
}