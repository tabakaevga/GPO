using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    /// <summary>
    /// 
    /// </summary>
    interface IFigure
    {
        FigureType FigureType { get; }
        double Area { get; }
        double Length { get; }
    }
}
