using System;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            double result;

            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);

                result = x - 10 * Math.Sin(x) + Math.Cos(x - y);

                label3.Text = "Результат: " + result.ToString("F4");
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Результат:";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
