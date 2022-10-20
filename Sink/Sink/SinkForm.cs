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
        }





        private void WidthSink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            
        }

        private void LengthSink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            
        }

        private void HeightSink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            
        }

        private void RadSink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            
        }

        private void RadTapSink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            
        }

        private void WidthSink_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void BuildingButton_Click(object sender, EventArgs e)
        {
          
        }

        private void SinkForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
}
