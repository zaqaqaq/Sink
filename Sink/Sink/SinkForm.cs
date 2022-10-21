using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sink.Model;

namespace Sink
{
    public partial class SinkForm : Form
    {

        private SinkParameters Parameters;

        private Dictionary<TextBox, SinkParametersType> TextBoxToParameter;

        private SinkParameters _sinkParameters = new SinkParameters();

        /// <summary>
        /// Константа для корректного цвета. 
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Константа для цвета ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        private String _validationError = "";


        public SinkForm()
        {
            InitializeComponent();
            Parameters = new Model.SinkParameters();
            TextBoxToParameter = new Dictionary<TextBox, SinkParametersType>()
            {
                { WidthSink, SinkParametersType.WidthSink },
                { LengthSink, SinkParametersType.LengthSink },
                { HeightSink, SinkParametersType.HeightSink },
                { RadSink, SinkParametersType.RadSink },
                { RadTapSink, SinkParametersType.RadTapSink },

            };
        }


        private void WidthSink_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _sinkParameters.WidthSink = Convert.ToDouble(WidthSink.Text);
                WidthSink.BackColor = _correctColor;
            }
            catch (Exception exception)
            {
                WidthSink.BackColor = _errorColor;
                _validationError = _validationError + exception.Message;
            }
        }

        private void BuildingButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(WidthSink.Text, System.Globalization.NumberStyles.Number);
                WidthSink.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Значения должны быть в диапазоне от 450 мм до 630 мм", "Ошибка построения");
            }
        }

        private void SinkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    

