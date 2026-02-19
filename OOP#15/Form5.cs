using System;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label2.Text = "Результат:";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;

            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Convert.ToDouble(textBox3.Text);

                double min = x;
                double max = x;

                if (y < min)
                    min = y;

                if (z < min)
                    min = z;

                if (y > max)
                    max = y;

                if (z > max)
                    max = z;

                double sum = min + max;

                label1.Text = "Сума мінімального і максимального: " + sum.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }
    }
}
