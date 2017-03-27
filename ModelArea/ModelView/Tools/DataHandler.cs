using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using ModelArea;

namespace ModelView.Tools
{
    /// <summary>
    /// Класс реализующий различные манипуляции с данными
    /// (сохранение в файл, загрузка из файла, поиск по списку)
    /// </summary>
    public class DataHandler
    {
        /// <summary>
        /// Сериализатор данных
        /// </summary>
        /// <typeparam name="T"> Тип данных, поступающий на сериализацию </typeparam>
        /// <param name="fileName"> Название файла, куда записывается серия </param>
        /// <param name="container"> Контейнер данных </param>
        public static void SerializeBinary<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var serializeFileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(serializeFileStream, container);
            serializeFileStream.Close();
        }

        /// <summary>
        /// Десериализатор данных
        /// </summary>
        /// <typeparam name="T"> Тип данных, поступающий на десериализацию </typeparam>
        /// <param name="fileName"> Название файла, откуда происходит десериализация </param>
        /// <param name="container"> Контейнер данных </param>
        public static void DeserializeBinary<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var deserializeFile = new FileStream(fileName, FileMode.OpenOrCreate);
            if (deserializeFile.Length > 0)
            {
                container = (T)formatter.Deserialize(deserializeFile);
            }
            deserializeFile.Close();
        }

        public static BindingList<IFigure> SearchInList_ByFigureType(ref BindingList<IFigure> list, FigureType figureType) =>
            new BindingList<IFigure>(list.Where(figure => figure.FigureType == figureType).ToList());

        public static BindingList<IFigure> SearchInList(ref BindingList<IFigure> list, int paramNumber, string paramValue)
        {
            switch (paramNumber)
            {
                case 0:
                    return new BindingList<IFigure>(list.Where(figure => Math.Abs(figure.Area - Convert.ToDouble(paramValue)) < 0.01).ToList());
                case 1:
                    return new BindingList<IFigure>(list.Where(figure => Math.Abs(figure.Length - Convert.ToDouble(paramValue)) < 0.01).ToList());
                default:
                    return new BindingList<IFigure>();
            }
                
        }


    }
}

