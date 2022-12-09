using System;
using System.Collections.Generic;

namespace Sink.Model
{
    /// <summary>
    /// Класс для проверки диапазона.
    /// </summary>
    class CheckParameter
    {
        /// <summary>
        /// Проверка диапазона.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="parameters"></param>
        /// <param name="errors"></param>
        public void RangeCheck(double value, double min, double max,
           ParameterType parameters, Dictionary<ParameterType, string> errors)
        {
            errors.Remove(parameters);
            if (value < min || value > max)
            {
                errors.Add(parameters, "Выход за диапазон");
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}


