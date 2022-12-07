using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sink.Model;

namespace Sink.Wrapper
{
    public class Builder
    { 
        /// <summary>
        /// Сапр апи.
        /// </summary>
        private KompasWrapper _apiService = new KompasWrapper();

        /// <summary>
        /// Метод для создания раковины.
        /// </summary>
        /// <param name="tableParameters">Параметры стола</param>
        /// <param name="apiService">Сапр апи</param>

        public void BuildSink()
        {
            _apiService.CreateDocument();
        }
    }
}