using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelArea;

namespace UnitTests
{
    class FiguresComparer : Comparer<IFigure>
    {
        public override int Compare(IFigure x, IFigure y)
        {
            return x.FigureType.CompareTo(y.FigureType);
        }
    }
}
