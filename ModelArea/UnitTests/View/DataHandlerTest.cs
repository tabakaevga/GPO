using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelArea;
using ModelView.Tools;
using NUnit.Framework;

namespace UnitTests.View
{
    /// <summary>
    /// Набор тестов для класса DataHandler
    /// </summary>
    [TestFixture]
    class DataHandlerTest
    {
        
        private object[] _sourceObjectsValid =
        {
            new object[]
            {
                new BindingList<IFigure>
                {
                    new Circle(4),
                    new Rectangle(4, 8),
                    new Triangle(5, 4, 3),
                    new Circle(7),
                    new Rectangle(16, 2)
                },
                new BindingList<IFigure>
                {
                    new Rectangle(4,8),
                    new Rectangle(16, 2)
                }, 
                0,
                "32"

            },
            new object[]
            {
                new BindingList<IFigure>(),
                new BindingList<IFigure>(), 
                0,
                "80" 
            }
        };

        [Test, TestCaseSource(nameof(_sourceObjectsValid))]
        public void SearchInListTest(BindingList<IFigure> list, BindingList<IFigure> expectedList, int param, string paramValue)
        {
            BindingList<IFigure> searchedList = DataHandler.SearchInList(ref list, param, paramValue);
            CollectionAssert.AreEqual(searchedList, expectedList, new FiguresComparer());
        }
    }
}
