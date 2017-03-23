using System;

namespace ModelArea
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Тип фигуры
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
