using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sink.Model
{
    /// <summary>
    /// Перечисление параметров кружки.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>
        /// Ширина раковины.
        /// </summary>
        WidthSink,

        /// <summary>
        /// Длина раковины.
        /// </summary>
        LengthSink,

        /// <summary>
        /// Глубина раковины.
        /// </summary>
        HeightSink,

        /// <summary>
        /// Диаметр сливного отверстия.
        /// </summary>
        RadSink,

        /// <summary>
        /// Диаметер отверстия под кран.
        /// </summary>
        RadTapSink
    }
}
