using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBox1.Text.Split(' ');
                double c = Convert.ToDouble(textBox2.Text);
                double d = Convert.ToDouble(textBox3.Text);

                string result = "";

                foreach (string p in parts)
                {
                    double number = Convert.ToDouble(p);

                    if (number >= c && number <= d)
                        result += number.ToString() + " ";
                }

                label5.Text = "Елементи: " + result;
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "Результат:";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
