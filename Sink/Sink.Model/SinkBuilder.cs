using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sink.Model
{
    class SinkBuilder
    {
        SinkParameters _parameters;

        public SinkBuilder(SinkParameters parameters)
        {
            _parameters = parameters;
        }
    }
}
