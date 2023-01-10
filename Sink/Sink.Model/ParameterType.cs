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
        /// Диаметр отверстия под кран.
        /// </summary>
        RadTapSink,

        /// <summary>
        /// Координата X отверстия под фильтр.
        /// </summary>
        FilterSinkX,

        /// <summary>
        /// Координата Y отверстия под фильтр.
        /// </summary>
        FilterSinkY
    }
}