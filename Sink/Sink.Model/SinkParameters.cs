using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sink.Model
{
    public class SinkParameters
    {
        private Dictionary<SinkParametersType, SinkParameter> _parameters;

        private double _widthSink;

        public SinkParameters()
        {
            _parameters = new Dictionary<SinkParametersType, SinkParameter>()
            {
                { SinkParametersType.WidthSink, new SinkParameter(450, 630) },
                { SinkParametersType.LengthSink, new SinkParameter(450, 630) },
                { SinkParametersType.HeightSink, new SinkParameter(150, 210) },
                { SinkParametersType.RadSink, new SinkParameter(50, 70) },
                { SinkParametersType.RadTapSink, new SinkParameter(20, 30) },
            };
        }

        public void SetParameterValue(SinkParametersType type, double value)
        {
            if (_parameters.TryGetValue(type, out SinkParameter parameter))
            {
                parameter.Value = value;
            }
        }

        public double GetParameterValue(SinkParametersType type)
        {
            if (_parameters.TryGetValue(type, out SinkParameter parameter))
            {
                throw new ArgumentOutOfRangeException("type");
            }
            return parameter.Value;
        }

        public double WidthSink
        {
            get
            {
                return _widthSink;
            }
            set
            {
                if (value < 80 || value > 100)
                {
                    throw new ArgumentException(
                        $"The upper diametr must be in range from 80 to 100"
                        + $" But was {value}");
                }
                this._widthSink = value;
            }
        }
    }
}
