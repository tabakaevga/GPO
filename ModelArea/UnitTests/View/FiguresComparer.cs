using System.Collections.Generic;
using ModelArea;

namespace UnitTests.View
{
    /// <summary>
    ///     Перегрузка метода Compare
    /// </summary>
    internal class FiguresComparer : Comparer<IFigure>
    {
        public override int Compare(IFigure x, IFigure y)
        {
            return x.FigureType.CompareTo(y.FigureType);
        }
    }
}