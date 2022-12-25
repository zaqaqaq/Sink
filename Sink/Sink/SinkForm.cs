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
using Sink.Wrapper;

namespace Sink
{
    /// <summary>
    /// Класс для взаимодействия с формой.
    /// </summary>
    public partial class SinkForm : Form
    {
        /// <summary>
        /// Экземпляр класса ChangeableParametrs
        /// </summary>
        private ChangeParameters _changeableParameters = new ChangeParameters();

        /// <summary>
        /// Переменная белого цвета
        /// </summary>  
        private Color _colorWhite = Color.White;

        /// <summary>
        /// Переменная розового цвета
        /// </summary>  
        private Color _colorLightPink = Color.LightPink;

        /// <summary>
        /// Словарь, cвязывающий параметр раковины
        /// и соотвествующий ему textbox
        /// </summary>
        private Dictionary<TextBox, Action<double>> _valueTextBox
            = new Dictionary<TextBox, Action<double>>();

        public SinkForm()
        {
            InitializeComponent();

            _valueTextBox = new Dictionary<TextBox, Action<double>>();
            _valueTextBox.Add(widthSink, (widthSink)
                => _changeableParameters.WidthSink = widthSink);
            _valueTextBox.Add(lengthSink, (lengthSink)
                => _changeableParameters.LengthSink = lengthSink);
            _valueTextBox.Add(heightSink, (heightSink)
                => _changeableParameters.HeightSink = heightSink);
            _valueTextBox.Add(radSink, (radSink)
                => _changeableParameters.RadSink = radSink);
            _valueTextBox.Add(radTapSink, (radTapSink)
                => _changeableParameters.RadTapSink = radTapSink);
        }

        /// <summary>
        /// Обработчик кнопки построения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingButton_Click(object sender, EventArgs e)
        {
            if (widthSink.Text == string.Empty ||
                 lengthSink.Text == string.Empty ||
                 heightSink.Text == string.Empty ||
                 radSink.Text == string.Empty ||
                 radTapSink.Text == string.Empty ||
                 /*TextBoxLengthOfHoles.Text == string.Empty ||*/
                 _changeableParameters.Parameters.Count > 0)
            {
                MessageBox.Show("Модель не может быть построена!", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var builder = new SinkBuilder();
                builder.BuildSink(_changeableParameters);
            }
        }

        /// <summary>
        /// Валидация для текстбоксов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxValidator_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Focus();
            if (textBox.Text == string.Empty || textBox.Text == ".")
            {
                textBox.Text = string.Empty;
                return;
            }
            try
            {
                _valueTextBox[textBox](double.Parse(textBox.Text));
                textBox.BackColor = _colorWhite;
                if (textBox == lengthSink)
                {
                    TextBoxValidator_TextChanged(widthSink, e);
                    TextBoxValidator_TextChanged(heightSink, e);
                    lengthSink.Focus();
                }
            }
            catch
            {
                textBox.BackColor = _colorLightPink;
            }
        }

        /// <summary>
        /// Проверка, чтобы textbox содержал только одну запятую и цифры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckForCommasAndNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar))
                && !(char.IsDigit(e.KeyChar))
                && !((e.KeyChar == ',')
                     && (((TextBox)sender).Text.IndexOf(",") == -1)
                    ))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Проверка, чтобы textbox содержал только цифры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntegerCheck_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}