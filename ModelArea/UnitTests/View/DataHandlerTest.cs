using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using ModelArea;
using ModelView.Tools;
using NUnit.Framework;

namespace UnitTests.View
{
    /// <summary>
    ///     Набор тестов для класса DataHandler
    /// </summary>
    [TestFixture]
    internal class DataHandlerTest
    {
        /// <summary>
        ///     Подготовка данных к тестированию
        /// </summary>
        [SetUp]
        public void SerializationSetup()
        {
            for (var i = 0; i < 3; i++)
                if (File.Exists(FileNames[i]))
                    File.Delete(FileNames[i]);
            var listForFile = DictionaryOfLists["Standard list"];
            DataHandler.SerializeBinary(FileNames[3], ref listForFile);
            DataHandler.SerializeBinary(FileNames[4], ref listForFile);
        }

        /// <summary>
        ///     Избавления от данных после тестирования
        /// </summary>
        [TearDown]
        public void SerializationTearDown()
        {
            for (var i = 0; i < 5; i++)
                File.Delete(FileNames[i]);
        }

        /// <summary>
        ///     Директория файлов
        /// </summary>
        private const string FileDir = "C:\\Users\\Администратор\\Desktop\\GPO\\ModelArea\\UnitTests\\View\\";

        /// <summary>
        ///     Словарь списков объектов
        /// </summary>
        private static readonly Dictionary<string, BindingList<IFigure>> DictionaryOfLists = new Dictionary
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
        private static readonly string[] FileNames =
        {
            FileDir + "CorrectSerializationResult.fg",
            FileDir + "SerializationResultDifferentList.fg",
            FileDir + "SerializationResultDifferentExtension.differ",
            FileDir + "CorrectList.fg",
            FileDir + "CorrectDeserializable.fg",
            FileDir + "IncorrectDeserializable.fg"
        };

        /// <summary>
        /// Тестирование бинарного десериализатора
        /// </summary>
        /// <param name="fileNameDeserialized"> Название десериализируемого файла</param>
        /// <param name="listExpectedKey"> Ключ ожидаемого списка</param>
        [Test]
        [TestCase(FileDir + "CorrectDeserializable.fg", "Standard list", TestName = "Корректная десериализация файла.")]
        public void BinaryDeserializerTest(string fileNameDeserialized, string listExpectedKey)
        {
            var listExpected = DictionaryOfLists[listExpectedKey];
            var listActual = new BindingList<IFigure>();
            DataHandler.DeserializeBinary(fileNameDeserialized, ref listActual);
            CollectionAssert.AreEqual(listExpected, listActual, new FiguresComparer());
        }

        /// <summary>
        ///     Тестирование метода двоичного сериализатора
        /// </summary>
        /// <param name="fileNameSerialized"> Наименование файла </param>
        /// <param name="listKey"> Ключ сериализируемого списка </param>
        /// <param name="fileExpected"> Ожидаемый файл </param>
        [Test]
        [TestCase(FileDir + "CorrectSerializationResult.fg", "Standard list", FileDir + "CorrectList.fg",
            TestName = "Сериализация корректных данных")]
        [TestCase(FileDir + "SerializationResultDifferentList.fg", "ExpectedListNo1", FileDir + "CorrectList.fg",
            ExpectedException = typeof(AssertionException), TestName = "Сериализация списка, отличного от ожидаемого")]
        [TestCase(FileDir + "SerializationResultDifferentExtension.differ", "Standard list", FileDir + "CorrectList.fg",
            TestName = "Сериализация списка в файл с другим расширением")]
        public void BinarySerializerTest(string fileNameSerialized, string listKey, string fileExpected)
        {
            var list = DictionaryOfLists[listKey];
            DataHandler.SerializeBinary(fileNameSerialized, ref list);
            FileAssert.AreEqual(fileExpected, fileNameSerialized);
        }

        /// <summary>
        ///     Тест поиска по типу фигуры
        /// </summary>
        /// <param name="dictionaryKey"> Ключ списка, в котором производится поиск</param>
        /// <param name="expectedResultKey"> Ключ ожидаемого списка</param>
        /// <param name="figureType"> Тип фигуры</param>
        [Test]
        [TestCase("Standard list", "FigureTypeExpectedListNo1", FigureType.Circle,
            TestName = "Тестирование поиска по типу Окружность")]
        [TestCase("Standard list", "FigureTypeExpectedListNo2", FigureType.Rectangle,
            TestName = "Тестирование поиска по типу Прямоугольник")]
        [TestCase("Standard list", "FigureTypeExpectedListNo3", FigureType.Triangle,
            TestName = "Тестирование поиска по типу Треугольник")]
        [TestCase("Standard list", "EmptyList", 7,
            TestName = "Тестирование поиска по несуществующему типу (вернет пустой список)")]
        public void SearchByTypeTest(string dictionaryKey, string expectedResultKey, FigureType figureType)
        {
            var listToSearchOn = DictionaryOfLists[dictionaryKey];
            var listExpected = DictionaryOfLists[expectedResultKey];
            listToSearchOn = DataHandler.SearchInList_ByFigureType(ref listToSearchOn, figureType);
            CollectionAssert.AreEqual(listToSearchOn, listExpected, new FiguresComparer());
        }

        /// <summary>
        ///     Тестирование поиска по площади и периметру
        /// </summary>
        /// <param name="dictionaryKey"> Ключ списка, в котором производится поиск</param>
        /// <param name="expectedResultKey"> Ключ ожидаемого списка</param>
        /// <param name="param"> Параметр поиска (площадь или периметр)</param>
        /// <param name="paramValue"> Значение параметра</param>
        [Test]
        [TestCase("Standard list", "ExpectedListNo1", 0, "32",
            TestName = "Тест по площади, корректный (поиск возвращает 2 Rectangle и Circle с площадью 32).")]
        [TestCase("Standard list", "EmptyList", 0, "12",
            TestName = "Тест по площади, корректный (поиск возвращает пустой лист).")]
        [TestCase("Standard list", "ExpectedListNo2", 1, "13",
            TestName = "Тест по периметру, корректный (Поиск возвращает Rectangle и Triangle с периметром 13).")]
        [TestCase("Standard list", "EmptyList", 1, "132",
            TestName = "Тест по периметру, корректный (поиск возвращает пустой лист).")]
        [TestCase("Standard list", "EmptyList", 4, "132",
            TestName = "Тест по ошибочному параметру поиска (не площадь или периметр).")]
        [TestCase("Standard list", "EmptyList", 0, "-132", ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тест по ошибочному параметру значения площади (отрицательное число).")]
        [TestCase("Standard list", "EmptyList", 1, "-132", ExpectedException = typeof(ArgumentOutOfRangeException),
            TestName = "Тест по ошибочному параметру значения периметра (отрицательное число.")]
        [TestCase("Standard list", "EmptyList", 0, "asdf", ExpectedException = typeof(FormatException),
            TestName = "Тест по ошибочному параметру значения площади (не число).")]
        [TestCase("Standard list", "EmptyList", 1, "asdf", ExpectedException = typeof(FormatException),
            TestName = "Тест по ошибочному параметру значения периметра (не число).")]
        public void SearchInListTest(string dictionaryKey, string expectedResultKey, int param, string paramValue)
        {
            var listToSearchOn = DictionaryOfLists[dictionaryKey];
            var listExpected = DictionaryOfLists[expectedResultKey];
            listToSearchOn = DataHandler.SearchInList(ref listToSearchOn, param, paramValue);
            CollectionAssert.AreEqual(listToSearchOn, listExpected, new FiguresComparer());
        }
    }
}