using System;
using System.ComponentModel;
using System.Linq;
using ModelArea;
using ModelArea.Tools;

namespace ModelView.Tools
{
    public static class Searcher
    {
        /// <summary>
        ///     Поиск в списке по типу фигуры
        /// </summary>
        /// <param name="list"> Список, в котором производится поиск</param>
        /// <param name="figureType"> Тип искомой фигуры</param>
        /// <returns></returns>
        public static BindingList<IFigure> SearchInList_ByFigureType(ref BindingList<IFigure> list,
            FigureType figureType) =>
            new BindingList<IFigure>(list.Where(figure => figure.FigureType == figureType).ToList());

        /// <summary>
        ///     Поиск в списке по параметрам класса
        /// </summary>
        /// <param name="list"></param>
        /// <param name="paramNumber"> Номер параметра: 0 -  Площадь фигуры, 1 - Периметр фигуры </param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public static BindingList<IFigure> SearchInList(ref BindingList<IFigure> list, int paramNumber,
            string paramValue)
        {
            CheckCorrectInput.CheckDouble(Convert.ToDouble(paramValue));
            switch (paramNumber)
            {
                case 0:
                    return new BindingList<IFigure>(list.Where
                        (figure => Math.Abs(figure.Area - Convert.ToDouble(paramValue)) < 0.01).ToList());
                case 1:
                    return new BindingList<IFigure>(list.Where
                        (figure => Math.Abs(figure.Length - Convert.ToDouble(paramValue)) < 0.01).ToList());
                default:
                    return new BindingList<IFigure>();
            }
        }
    }
}