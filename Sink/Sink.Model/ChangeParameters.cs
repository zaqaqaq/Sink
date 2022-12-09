using System;
using System.Collections.Generic;

namespace Sink.Model
{
    /// <summary>
    /// Класс параметров.
    /// </summary>
    public class ChangeParameters
    {
        /// <summary>
        /// Параметр ширины раковины. 
        /// </summary>
        private double _widthSink;

        /// <summary>
        /// Параметр длины раковины.
        /// </summary>
        private double _lengthSink;

        /// <summary>
        /// Параметр глубины.
        /// </summary>
        private double _heightSink;

        /// <summary>
        /// Параметр сливного отверстия.
        /// </summary>
        private double _radSink;

        /// <summary>
        /// Параметр отверстия под кран.
        /// </summary>
        private double _radTapSink;

        /// <summary>
        /// Словарь перечисления параметров и ошибки
        /// </summary>
        public Dictionary<ParameterType, string> Parameters =
            new Dictionary<ParameterType, string>();

        /// <summary>
        /// Экземпляр класса CheckParameter
        /// </summary>
        private CheckParameter _parameterCheck = new CheckParameter();

        /// <summary>
        /// Возвращает и устанавливает значение ширины раковины
        /// </summary>
        public double WidthSink
        {
            get
            {
                return _widthSink;
            }

            set
            {
                const double min = 450;
                const double max = 630;
                _parameterCheck.RangeCheck
                    (value, min, max,
                    ParameterType.WidthSink, Parameters);
                if (value != LengthSink)
                {
                    Parameters.Add(ParameterType.WidthSink,
                        "Выход за диапазон");
                    throw new Exception();
                }
                _widthSink = value;
            }
        }

        /// <summary>
        /// Возвращает и устанавливает значение длины раковины.
        /// </summary>
        public double LengthSink
        {
            get
            {
                return _lengthSink;
            }

            set
            {
                const double min = 450;
                const double max = 630;
                _parameterCheck.RangeCheck
                    (value, min, max,
                    ParameterType.LengthSink, Parameters);
                if (WidthSink == value)
                {
                    Parameters.Add(ParameterType.WidthSink,
                        "Выход за диапазон");
                    throw new Exception();
                }
                _lengthSink = value;
            }
        }

        /// <summary>
        /// Возвращает и устанавливает значение глубины раковины.
        /// </summary>
        public double HeightSink
        {
            get
            {
                return _heightSink;
            }
            set
            {
                const double min = 150;
                const double max = 210;
                _parameterCheck.RangeCheck
                    (value, min, max,
                    ParameterType.HeightSink, Parameters);
                if (LengthSink != value * 3)
                {
                    throw new Exception();
                    Parameters.Add(ParameterType.HeightSink,
                        "Выход за диапазон");
                }
                _heightSink = value;
            }
        }

        /// <summary>
        /// Возвращает и устанавливает значение сливного отверстия.
        /// </summary>
        public double RadSink
        {
            get
            {
                return _radSink;
            }

            set
            {
                const double min = 50;
                const double max = 70;
                _parameterCheck.RangeCheck
                    (value, min, max,
                    ParameterType.RadSink, Parameters);
                _radSink = value;
            }
        }

        /// <summary>
        /// Возвращает и устанавливает значение отверстия под кран.
        /// </summary>
        public double RadTapSink
        {
            get
            {
                return _radTapSink;
            }

            set
            {
                const double min = 20;
                const double max = 30;
                _parameterCheck.RangeCheck
                    (value, min, max,
                    ParameterType.RadTapSink, Parameters);
                _radTapSink = value;
            }
        }
    }
}
