using NUnit.Framework;
using System;
using Sink.Model;

namespace SinkTest
{
    public class SinkParametersTest
    {

        [TestCase(Description = "Позитивный тест WidthSink")]
        public void Test_WidthSink_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 450;
            sinkParameters.LengthSink = 450;
            sinkParameters.WidthSink = expected;
            var actual = sinkParameters.WidthSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 450 до 630");

        }


        [TestCase(430, Description = "Негативный тест сеттера WidthSink")]
        [TestCase(650, Description = "Негативный тест сеттера WidthSink")]

        public void Test_WidthSink_Set_UnCorrectValue(double wrongWidthSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.WidthSink = wrongWidthSink;
            }, "Должно возникать исключение, если значение не входит в " +
            "диапазон от 450 до 630");
        }

        [TestCase(Description = "Негативный тест сеттера WidthSink")]
        public void Test_WidthSink_Set_UnCorrectValueAddiction()
        {

            SinkParameter sinkParameters = new SinkParameter();
            var actualWidthSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            sinkParameters.WidthSink = 430);
            Console.WriteLine(actualWidthSink.Message);
            Assert.That(actualWidthSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }

        [TestCase(Description = "Позитивный тест геттера LengthSink")]
        public void Test_LengthSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 470;
            sinkParameters.LengthSink = expected;
            var actual = sinkParameters.LengthSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 450 до 630");

        }

        [TestCase(450, Description = "Позитивный тест сеттера LengthSink")]
        public void Test_LengthSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            Assert.AreEqual(value, sinkParameters.LengthSink,
                "Значение должно входить в диапазон от 450 до 630");

        }

        [TestCase(420, Description = "Негативный тест сеттера LengthSink")]
        [TestCase(670, Description = "Негативный тест сеттера LengthSink")]
        public void Test_LengthSink_Set_UnCorrectValue(double wrongLengthSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.LengthSink = wrongLengthSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 450 до 630");
        }

        [TestCase(Description = "Позитивный тест геттера HeightSink")]
        public void Test_HeightSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            var expected = 150;
            sinkParameters.HeightSink = expected;
            var actual = sinkParameters.HeightSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 150 до 210"); /// 1k3 150=450
        }

        [TestCase(150, Description = "Позитивный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            sinkParameters.HeightSink = 150;
            Assert.AreEqual(value, sinkParameters.HeightSink,
                "Значение должно входить в диапазон от 150 до 210"); ///1k3
        }

        [TestCase(Description = "Негативный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValueAddiction()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var actualHeightSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            sinkParameters.HeightSink = 555);
            Console.WriteLine(actualHeightSink.Message);
            Assert.That(actualHeightSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }


        [TestCase(149, Description = "Негативный тест сеттера HeightSink")]
        [TestCase(216, Description = "Негативный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValue(double wrongHeightSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.HeightSink = wrongHeightSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 150 до 210");
        }

        [TestCase(Description = "Позитивный тест геттера RadSink")]
        public void Test_RadSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 55;
            sinkParameters.RadSink = expected;
            var actual = sinkParameters.RadSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 50 до 70");

        }

        [TestCase(65, Description = "Позитивный тест сеттера RadSink")]
        public void Test_RadSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.RadSink = 65;
            Assert.AreEqual(value, sinkParameters.RadSink,
                "Значение должно входить в диапазон от 50 до 70");

        }

        [TestCase(40, Description = "Негативный тест сеттера RadSink")]
        [TestCase(90, Description = "Негативный тест сеттера RadSink")]
        public void Test_RadSink_Set_UnCorrectValue(double wrongRadSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.RadSink = wrongRadSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 50 до 70");
        }

        [TestCase(Description = "Позитивный тест геттера RadTapSink")]
        public void Test_RadTapSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 22;
            sinkParameters.RadTapSink = expected;
            var actual = sinkParameters.RadTapSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 20 до 30");
        }

        [TestCase(28, Description = "Позитивный тест сеттера RadTapSink")]
        public void Test_NumberOfHoles_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.RadTapSink = 28;
            Assert.AreEqual(value, sinkParameters.RadTapSink,
                "Значение должно входить в диапазон от 20 до 30");
        }

        [TestCase(18, Description = "Негативный тест сеттера RadTapSink")]
        [TestCase(35, Description = "Негативный тест сеттера RadTapSink")]

        public void Test_RadTapSink_Set_UnCorrectValue(double wrongRadTapSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.RadTapSink = wrongRadTapSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 20 до 30");
        }
    }
}