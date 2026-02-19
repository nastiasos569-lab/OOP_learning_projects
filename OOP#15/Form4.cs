using System;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Результат:";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(textBox1.Text);

                int a = N / 100;
                int b = (N / 10) % 10;
                int c = N % 10;

                bool result = (a + b == c) || (a + c == b) || (b + c == a);

                label2.Text = "Результат: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }
    }
}
