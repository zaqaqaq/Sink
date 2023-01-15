using Sink.Wrapper;
using Sink.Model;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StressTest
{
    /// <summary>
    /// Класс для нагрузочного тестирования.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Основной метод класса для запуска нагрузочного тестирования.
        /// </summary>
        private static void Main()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var sinkBuilder = new SinkBuilder();
            var changeParameters = new SinkParameter();
            double widthSink = 450;
            double lengthSink = 450;
            double hightSink = 150;
            double radSink = 50;
            double radTapSink = 20;
            double filterSinkX = 35;
            double filterSinkY = 120;
            changeParameters.WidthSink = widthSink;
            changeParameters.LengthSink = lengthSink;
            changeParameters.HeightSink = hightSink;
            changeParameters.RadSink = radSink;
            changeParameters.RadTapSink = radTapSink;
            changeParameters.FilterSinkX = filterSinkX;
            changeParameters.FilterSinkY = filterSinkY;
            var streamWriter = new StreamWriter($"StressTest.txt", true);
            var modelCounter = 0;
            var computerInfo = new ComputerInfo();

            ulong usedMemory = 0;
            while (usedMemory * 0.96 <= computerInfo.TotalPhysicalMemory)
            {
                sinkBuilder.BuildSink(changeParameters);
                usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory);
                streamWriter.WriteLine(
                    $"{++modelCounter}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}");
                streamWriter.Flush();
            }
            stopWatch.Stop();
            streamWriter.WriteLine("END");
            streamWriter.Close();
            streamWriter.Dispose();
        }
    }
}