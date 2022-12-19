using NUnit.Framework;
using System;
using Sink.Model;

namespace SinkTest
{
    public class Tests
    {
        private ChangeParameters _changeParameters;

  /*      [TestCase(Description = "Позитивный тест геттера WidthSink")]
        public void Test_WidthSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 450;
            _changeParameters.WidthSink = expected;
            var actual = _changeParameters.WidthSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 450 до 630");

        }*/
/*
        [TestCase(450, Description = "Позитивный тест сеттера WidthSink")]
        public void Test_WidthSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.WidthSink = 450;
            Assert.AreEqual(value, _changeParameters.WidthSink,
                "Значение должно входить в диапазон от 450 до 630");
        }*/

        [TestCase(430, Description = "Негативный тест сеттера WidthSink")]
        [TestCase(650, Description = "Негативный тест сеттера WidthSink")]

        public void Test_WidthSink_Set_UnCorrectValue(double wrongWidthSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.WidthSink = wrongWidthSink;
            }, "Должно возникать исключение, если значение не входит в " +
            "диапазон от 450 до 630");
        }

       /* [TestCase(450, Description = "Негативный тест сеттера WidthSink")]
        public void Test_WidthSink_Set_UnCorrectValueAddiction(double wrongWidthSink)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.WidthSink = 450;
            Assert.Throws<Exception>(() =>
            {
                _changeParameters.WidthSink = wrongWidthSink;
            }, "Длина раковина должна быть равна ширине раковины");/// длина равна ширине 1 к 1 450
        }*/

        [TestCase(Description = "Позитивный тест геттера LengthSink")]
        public void Test_LengthSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 470;
            _changeParameters.LengthSink = expected;
            var actual = _changeParameters.LengthSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 450 до 630");

        }

        [TestCase(450, Description = "Позитивный тест сеттера LengthSink")]
        public void Test_LengthSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            Assert.AreEqual(value, _changeParameters.LengthSink,
                "Значение должно входить в диапазон от 450 до 630");

        }

        [TestCase(420, Description = "Негативный тест сеттера LengthSink")]
        [TestCase(670, Description = "Негативный тест сеттера LengthSink")]
        public void Test_LengthSink_Set_UnCorrectValue(double wrongLengthSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.LengthSink = wrongLengthSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 450 до 630");
        }

        [TestCase(Description = "Позитивный тест геттера HeightSink")]
        public void Test_HeightSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            var expected = 150;
            _changeParameters.HeightSink = expected;
            var actual = _changeParameters.HeightSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 60 до 120"); /// 1k3 150=450
        }

        [TestCase(150, Description = "Позитивный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            _changeParameters.HeightSink = 150;
            Assert.AreEqual(value, _changeParameters.HeightSink,
                "Значение должно входить в диапазон от 60 до 120"); ///1k3
        }

       /* [TestCase(150, Description = "Негативный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValueAddiction(double wrongHeightSink)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.HeightSink = 450;
            Assert.Throws<Exception>(() =>
            {
                _changeParameters.HeightSink = wrongHeightSink;
            }, "Высота должна быть в 3 раза меньше длины раковины");/// 1k3 
        }*/

        [TestCase(149, Description = "Негативный тест сеттера HeightSink")]
        [TestCase(216, Description = "Негативный тест сеттера HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValue(double wrongHeightSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.HeightSink = wrongHeightSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 60 до 120");
        }

        [TestCase(Description = "Позитивный тест геттера RadSink")]
        public void Test_RadSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 55;
            _changeParameters.RadSink = expected;
            var actual = _changeParameters.RadSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 50 до 70");

        }

        [TestCase(65, Description = "Позитивный тест сеттера RadSink")]
        public void Test_RadSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.RadSink = 65;
            Assert.AreEqual(value, _changeParameters.RadSink,
                "Значение должно входить в диапазон от 50 до 70");

        }

        [TestCase(40, Description = "Негативный тест сеттера RadSink")]
        [TestCase(90, Description = "Негативный тест сеттера RadSink")]
        public void Test_RadSink_Set_UnCorrectValue(double wrongRadSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.RadSink = wrongRadSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 50 до 70");
        }

        [TestCase(Description = "Позитивный тест геттера RadTapSink")]
        public void Test_RadTapSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 22;
            _changeParameters.RadTapSink = expected;
            var actual = _changeParameters.RadTapSink;
            Assert.AreEqual(expected, actual, "Значение должно входить в " +
                                              "диапазон от 20 до 30");
        }

        [TestCase(28, Description = "Позитивный тест сеттера RadTapSink")]
        public void Test_NumberOfHoles_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.RadTapSink = 28;
            Assert.AreEqual(value, _changeParameters.RadTapSink,
                "Значение должно входить в диапазон от 20 до 30");
        }

        [TestCase(18, Description = "Негативный тест сеттера RadTapSink")]
        [TestCase(35, Description = "Негативный тест сеттера RadTapSink")]

        public void Test_RadTapSink_Set_UnCorrectValue(double wrongRadTapSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.RadTapSink = wrongRadTapSink;
            }, "Должно возникать исключение, если значение не входит в " +
                   "диапазон от 90 до 100");
        }
    }
}