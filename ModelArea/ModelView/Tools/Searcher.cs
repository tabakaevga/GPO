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
        ///     ����� � ������ �� ���� ������
        /// </summary>
        /// <param name="list"> ������, � ������� ������������ �����</param>
        /// <param name="figureType"> ��� ������� ������</param>
        /// <returns></returns>
        public static BindingList<IFigure> SearchInList_ByFigureType(ref BindingList<IFigure> list,
            FigureType figureType) =>
            new BindingList<IFigure>(list.Where(figure => figure.FigureType == figureType).ToList());

        /// <summary>
        ///     ����� � ������ �� ���������� ������
        /// </summary>
        /// <param name="list"></param>
        /// <param name="paramNumber"> ����� ���������: 0 -  ������� ������, 1 - �������� ������ </param>
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