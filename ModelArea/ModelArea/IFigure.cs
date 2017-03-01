using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelArea
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Типы фигур
        /// </summary>
        FigureType FigureType { get; }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        double Area { get; }
        /// <summary>
        /// Вычисление длины/периметра
        /// </summary>
        double Length { get; }
    }
}
