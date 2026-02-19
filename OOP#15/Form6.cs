using System;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
            label3.Text = "Результат:";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                int M = Convert.ToInt32(textBox2.Text);

                if (M <= 0 || M >= 5)
                {
                    MessageBox.Show("M має бути від 1 до 4");
                    return;
                }

                if (N < 1 || N > 30)
                {
                    MessageBox.Show("N має бути від 1 до 30");
                    return;
                }

                int count = 0;

                int start = (int)Math.Pow(10, M - 1);
                int end = (int)Math.Pow(10, M) - 1;

                for (int number = start; number <= end; number++)
                {
                    int temp = number;
                    int position = 1;
                    int sum = 0;

                    while (temp > 0)
                    {
                        int digit = temp % 10;

                        if (position % 2 != 0) // непарний розряд
                            sum += digit;

                        temp /= 10;
                        position++;
                    }

                    if (sum == N)
                        count++;
                }

                label5.Text = "Кількість: " + count;
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }
    }
}
