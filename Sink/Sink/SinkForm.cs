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
                MessageBox.Show("Введите корректные данные", "Ошибка");
            }
        }

        private void SinkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    

