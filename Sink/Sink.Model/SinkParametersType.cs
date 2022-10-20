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
    public enum SinkParametersType
    {
        /// <summary>
        /// Диаметер горла кружки.
        /// </summary>
        WidthSink,

        /// <summary>
        /// Высота кружки.
        /// </summary>
        LengthSink,

        /// <summary>
        /// Толщина стенок кружки.
        /// </summary>
        HeightSink,

        /// <summary>
        /// Длина ручки кружки.
        /// </summary>
        RadSink,

        /// <summary>
        /// Диаметер внутренней части ручки.
        /// </summary>
        RadTapSink
    }
}
