using System;
using System.ComponentModel;
using System.IO;
using ModelArea;
using ModelView.Tools;
using NUnit.Framework;
using UnitTests.View.TestData;

namespace UnitTests.View
{
    /// <summary>
    ///     Набор тестов для класса Serializer
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
            foreach (var entry in TestDataDictionaries.FileNames)
                if (File.Exists(entry.Value))
                    File.Delete(entry.Value);
        }

        /// <summary>
        ///     Избавления от данных после тестирования
        /// </summary>
        [TearDown]
        public void SerializationTearDown()
        {
            foreach (var entry in TestDataDictionaries.FileNames)
                if (File.Exists(entry.Value))
                    File.Delete(entry.Value);
        }

        /// <summary>
        ///     Тестирование бинарного десериализатора
        /// </summary>
        /// <param name="fileNameDeserialized"> Название десериализируемого файла</param>
        /// <param name="listExpectedKey"> Ключ ожидаемого списка</param>
        [Test]
        [TestCase("CorrectDeserializable", "Standard list", TestName = "Корректная десериализация файла.")]
        [TestCase("EmptyListFile", "EmptyList", TestName = "Десериализация файла с пустым списком")]
        [TestCase("EmptyFile", "EmptyList", TestName = "Десериализация пустого файла (возвратит пустой список)")]
        [TestCase("DamagedFile", "EmptyList", ExpectedException = typeof(OverflowException),
            TestName = "Десериализация поврежденного файла")]
        public void BinaryDeserializerTest(string fileNameDeserialized, string listExpectedKey)
        {
            var listExpected = TestDataDictionaries.DictionaryOfLists[listExpectedKey];
            var listActual = new BindingList<IFigure>();
            Serializer.DeserializeBinary(TestDataDictionaries.PermanentFiles[fileNameDeserialized], ref listActual);
            CollectionAssert.AreEqual(listExpected, listActual, new FiguresComparer());
        }

        /// <summary>
        ///     Тестирование метода двоичного сериализатора
        /// </summary>
        /// <param name="fileNameSerialized"> Наименование файла </param>
        /// <param name="listKey"> Ключ сериализируемого списка </param>
        /// <param name="fileExpected"> Ожидаемый файл </param>
        [Test]
        [TestCase("CorrectSerialization", "Standard list", "ExpectedResult",
            TestName = "Сериализация корректных данных")]
        [TestCase("SerializationDifferentList", "ExpectedListNo1", "ExpectedResult",
            ExpectedException = typeof(AssertionException), TestName = "Сериализация списка, отличного от ожидаемого")]
        [TestCase("DifferentExtension", "Standard list", "ExpectedResult",
            TestName = "Сериализация списка в файл с другим расширением")]
        public void BinarySerializerTest(string fileNameSerialized, string listKey, string fileExpected)
        {
            var list = TestDataDictionaries.DictionaryOfLists[listKey];
            Serializer.SerializeBinary(TestDataDictionaries.FileNames[fileNameSerialized], ref list);
            FileAssert.AreEqual(TestDataDictionaries.PermanentFiles[fileExpected],
                TestDataDictionaries.FileNames[fileNameSerialized]);
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
            var listToSearchOn = TestDataDictionaries.DictionaryOfLists[dictionaryKey];
            var listExpected = TestDataDictionaries.DictionaryOfLists[expectedResultKey];
            listToSearchOn = Searcher.SearchInList_ByFigureType(ref listToSearchOn, figureType);
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
            var listToSearchOn = TestDataDictionaries.DictionaryOfLists[dictionaryKey];
            var listExpected = TestDataDictionaries.DictionaryOfLists[expectedResultKey];
            listToSearchOn = Searcher.SearchInList(ref listToSearchOn, param, paramValue);
            CollectionAssert.AreEqual(listToSearchOn, listExpected, new FiguresComparer());
        }
    }
}