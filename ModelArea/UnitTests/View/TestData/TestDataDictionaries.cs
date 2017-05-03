using System;
using System.Collections.Generic;
using System.ComponentModel;
using ModelArea;

namespace UnitTests.View.TestData
{
    internal class TestDataDictionaries
    {
        /// <summary>
        ///     Директория работы с файлами
        /// </summary>
        private static readonly string FileDir = Environment.CurrentDirectory + "\\View\\TestData\\";

        /// <summary>
        ///     Словарь списков объектов
        /// </summary>
        internal static readonly Dictionary<string, BindingList<IFigure>> DictionaryOfLists = new Dictionary
            <string, BindingList<IFigure>>
            {
                {
                    "Standard list", new BindingList<IFigure>
                    {
                        new Circle(3.191538),
                        new Rectangle(4, 8),
                        new Triangle(4, 5, 4),
                        new Rectangle(16, 2),
                        new Rectangle(3.5, 3)
                    }
                },

                {
                    "ExpectedListNo1", new BindingList<IFigure>
                    {
                        new Circle(3.191538),
                        new Rectangle(4, 8),
                        new Rectangle(16, 2)
                    }
                },

                {
                    "ExpectedListNo2", new BindingList<IFigure>
                    {
                        new Triangle(4, 5, 4),
                        new Rectangle(3.5, 3)
                    }
                },

                {
                    "FigureTypeExpectedListNo1", new BindingList<IFigure>
                    {
                        new Circle(3.191538)
                    }
                },

                {
                    "FigureTypeExpectedListNo2", new BindingList<IFigure>
                    {
                        new Rectangle(4, 8),
                        new Rectangle(16, 2),
                        new Rectangle(3.5, 3)
                    }
                },

                {
                    "FigureTypeExpectedListNo3", new BindingList<IFigure>
                    {
                        new Triangle(4, 5, 4)
                    }
                },
                {"EmptyList", new BindingList<IFigure>()}
            };

        /// <summary>
        ///     Наименования файлов
        /// </summary>
        internal static readonly Dictionary<string, string> FileNames = new Dictionary<string, string>
        {
            {"CorrectSerialization", FileDir + "CorrectSerializationResult.fg"},
            {"SerializationDifferentList", FileDir + "SerializationResultDifferentList.fg"},
            {"DifferentExtension", FileDir + "SerializationResultDifferentExtension.differ"}
        };

        /// <summary>
        ///     Файлы, на сравнение и десериализацию
        /// </summary>
        internal static readonly Dictionary<string, string> PermanentFiles = new Dictionary<string, string>
        {
            {"ExpectedResult", FileDir + "CorrectList.fg"},
            {"CorrectDeserializable", FileDir + "CorrectDeserializable.fg"},
            {"EmptyListFile", FileDir + "EmtpyList.fg"},
            {"DamagedFile", FileDir + "DamagedFile.fg"},
            {"EmptyFile", FileDir + "EmptyFile.fg"}
        };
    }
}