using NUnit.Framework;
using System;
using Sink.Model;

namespace SinkTest
{
    public class Tests
    {
        private ChangeParameters _changeParameters;

        [TestCase(Description = "���������� ���� WidthSink")]
        public void Test_WidthSink_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 450;
            _changeParameters.LengthSink = 450;
            _changeParameters.WidthSink = expected;
            var actual = _changeParameters.WidthSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 450 �� 630");

        }

       
        [TestCase(430, Description = "���������� ���� ������� WidthSink")]
        [TestCase(650, Description = "���������� ���� ������� WidthSink")]

        public void Test_WidthSink_Set_UnCorrectValue(double wrongWidthSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.WidthSink = wrongWidthSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
            "�������� �� 450 �� 630");
        }

        [TestCase(Description = "���������� ���� ������� WidthSink")]
        public void Test_WidthSink_Set_UnCorrectValueAddiction()
        {

            _changeParameters = new ChangeParameters();
            var actualWidthSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            _changeParameters.WidthSink = 430);
            Console.WriteLine(actualWidthSink.Message);
            Assert.That(actualWidthSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }

        [TestCase(Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 470;
            _changeParameters.LengthSink = expected;
            var actual = _changeParameters.LengthSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 450 �� 630");

        }

        [TestCase(450, Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            Assert.AreEqual(value, _changeParameters.LengthSink,
                "�������� ������ ������� � �������� �� 450 �� 630");

        }

        [TestCase(420, Description = "���������� ���� ������� LengthSink")]
        [TestCase(670, Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Set_UnCorrectValue(double wrongLengthSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.LengthSink = wrongLengthSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 450 �� 630");
        }

        [TestCase(Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            var expected = 150;
            _changeParameters.HeightSink = expected;
            var actual = _changeParameters.HeightSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 150 �� 210"); /// 1k3 150=450
        }

        [TestCase(150, Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.LengthSink = 450;
            _changeParameters.HeightSink = 150;
            Assert.AreEqual(value, _changeParameters.HeightSink,
                "�������� ������ ������� � �������� �� 150 �� 210"); ///1k3
        }

        [TestCase( Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValueAddiction()
        {
            _changeParameters = new ChangeParameters();
            var actualHeightSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            _changeParameters.HeightSink = 555);
            Console.WriteLine(actualHeightSink.Message);
            Assert.That(actualHeightSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }


        [TestCase(149, Description = "���������� ���� ������� HeightSink")]
        [TestCase(216, Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValue(double wrongHeightSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.HeightSink = wrongHeightSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 150 �� 210");
        }

        [TestCase(Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 55;
            _changeParameters.RadSink = expected;
            var actual = _changeParameters.RadSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 50 �� 70");

        }

        [TestCase(65, Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.RadSink = 65;
            Assert.AreEqual(value, _changeParameters.RadSink,
                "�������� ������ ������� � �������� �� 50 �� 70");

        }

        [TestCase(40, Description = "���������� ���� ������� RadSink")]
        [TestCase(90, Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Set_UnCorrectValue(double wrongRadSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.RadSink = wrongRadSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 50 �� 70");
        }

        [TestCase(Description = "���������� ���� ������� RadTapSink")]
        public void Test_RadTapSink_Get_CorrectValue()
        {
            _changeParameters = new ChangeParameters();
            var expected = 22;
            _changeParameters.RadTapSink = expected;
            var actual = _changeParameters.RadTapSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 20 �� 30");
        }

        [TestCase(28, Description = "���������� ���� ������� RadTapSink")]
        public void Test_NumberOfHoles_Set_CorrectValue(double value)
        {
            _changeParameters = new ChangeParameters();
            _changeParameters.RadTapSink = 28;
            Assert.AreEqual(value, _changeParameters.RadTapSink,
                "�������� ������ ������� � �������� �� 20 �� 30");
        }

        [TestCase(18, Description = "���������� ���� ������� RadTapSink")]
        [TestCase(35, Description = "���������� ���� ������� RadTapSink")]

        public void Test_RadTapSink_Set_UnCorrectValue(double wrongRadTapSink)
        {
            _changeParameters = new ChangeParameters();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _changeParameters.RadTapSink = wrongRadTapSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 20 �� 30");
        }
    }
}