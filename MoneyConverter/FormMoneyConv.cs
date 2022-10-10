using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class FormMoneyConv : Form
    {
        public FormMoneyConv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter
            {
                FirstCurrency = Converter.getCurrency(comboBox1.Text),
                SecondCurrency = Converter.getCurrency(comboBox2.Text)
            };

            double input = converter.Amount;

            if (Double.TryParse(textBox1.Text, out input))
            {
                if (Double.Parse(textBox1.Text) < 0)
                {
                    MessageBox.Show("Please, input positive value.");
                    textBox2.Text = "";
                }
                else
                {
                    converter.Amount = Convert.ToDouble(textBox1.Text);

                    converter.ConvertedAmount = (converter.Amount * converter.FirstCurrency.Tecaj) / converter.SecondCurrency.Tecaj;
                    textBox2.Text = converter.ConvertedAmount.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please, input positive value without letters.");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
