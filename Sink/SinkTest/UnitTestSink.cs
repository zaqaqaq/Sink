using NUnit.Framework;
using System;
using Sink.Model;

namespace SinkTest
{
    public class SinkParametersTest
    {

        [TestCase(Description = "���������� ���� WidthSink")]
        public void Test_WidthSink_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 450;
            sinkParameters.LengthSink = 450;
            sinkParameters.WidthSink = expected;
            var actual = sinkParameters.WidthSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 450 �� 630");

        }


        [TestCase(430, Description = "���������� ���� ������� WidthSink")]
        [TestCase(650, Description = "���������� ���� ������� WidthSink")]

        public void Test_WidthSink_Set_UnCorrectValue(double wrongWidthSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.WidthSink = wrongWidthSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
            "�������� �� 450 �� 630");
        }

        [TestCase(Description = "���������� ���� ������� WidthSink")]
        public void Test_WidthSink_Set_UnCorrectValueAddiction()
        {

            SinkParameter sinkParameters = new SinkParameter();
            var actualWidthSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            sinkParameters.WidthSink = 430);
            Console.WriteLine(actualWidthSink.Message);
            Assert.That(actualWidthSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }

        [TestCase(Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 470;
            sinkParameters.LengthSink = expected;
            var actual = sinkParameters.LengthSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 450 �� 630");

        }

        [TestCase(450, Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            Assert.AreEqual(value, sinkParameters.LengthSink,
                "�������� ������ ������� � �������� �� 450 �� 630");

        }

        [TestCase(420, Description = "���������� ���� ������� LengthSink")]
        [TestCase(670, Description = "���������� ���� ������� LengthSink")]
        public void Test_LengthSink_Set_UnCorrectValue(double wrongLengthSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.LengthSink = wrongLengthSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 450 �� 630");
        }

        [TestCase(Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            var expected = 150;
            sinkParameters.HeightSink = expected;
            var actual = sinkParameters.HeightSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 150 �� 210"); /// 1k3 150=450
        }

        [TestCase(150, Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.LengthSink = 450;
            sinkParameters.HeightSink = 150;
            Assert.AreEqual(value, sinkParameters.HeightSink,
                "�������� ������ ������� � �������� �� 150 �� 210"); ///1k3
        }

        [TestCase(Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValueAddiction()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var actualHeightSink = Assert.Throws<ArgumentOutOfRangeException>(() =>
            sinkParameters.HeightSink = 555);
            Console.WriteLine(actualHeightSink.Message);
            Assert.That(actualHeightSink.GetType(), Is.EqualTo(typeof(ArgumentOutOfRangeException)));
        }


        [TestCase(149, Description = "���������� ���� ������� HeightSink")]
        [TestCase(216, Description = "���������� ���� ������� HeightSink")]
        public void Test_HeightSink_Set_UnCorrectValue(double wrongHeightSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.HeightSink = wrongHeightSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 150 �� 210");
        }

        [TestCase(Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 55;
            sinkParameters.RadSink = expected;
            var actual = sinkParameters.RadSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 50 �� 70");

        }

        [TestCase(65, Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.RadSink = 65;
            Assert.AreEqual(value, sinkParameters.RadSink,
                "�������� ������ ������� � �������� �� 50 �� 70");

        }

        [TestCase(40, Description = "���������� ���� ������� RadSink")]
        [TestCase(90, Description = "���������� ���� ������� RadSink")]
        public void Test_RadSink_Set_UnCorrectValue(double wrongRadSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.RadSink = wrongRadSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 50 �� 70");
        }

        [TestCase(Description = "���������� ���� ������� RadTapSink")]
        public void Test_RadTapSink_Get_CorrectValue()
        {
            SinkParameter sinkParameters = new SinkParameter();
            var expected = 22;
            sinkParameters.RadTapSink = expected;
            var actual = sinkParameters.RadTapSink;
            Assert.AreEqual(expected, actual, "�������� ������ ������� � " +
                                              "�������� �� 20 �� 30");
        }

        [TestCase(28, Description = "���������� ���� ������� RadTapSink")]
        public void Test_NumberOfHoles_Set_CorrectValue(double value)
        {
            SinkParameter sinkParameters = new SinkParameter();
            sinkParameters.RadTapSink = 28;
            Assert.AreEqual(value, sinkParameters.RadTapSink,
                "�������� ������ ������� � �������� �� 20 �� 30");
        }

        [TestCase(18, Description = "���������� ���� ������� RadTapSink")]
        [TestCase(35, Description = "���������� ���� ������� RadTapSink")]

        public void Test_RadTapSink_Set_UnCorrectValue(double wrongRadTapSink)
        {
            SinkParameter sinkParameters = new SinkParameter();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                sinkParameters.RadTapSink = wrongRadTapSink;
            }, "������ ��������� ����������, ���� �������� �� ������ � " +
                   "�������� �� 20 �� 30");
        }
    }
}