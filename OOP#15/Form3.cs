using System;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Результат:";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;
            double area, perimeter;

            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);

                // Площа
                area = 0.5 * x * y;

                // Гіпотенуза
                double c = Math.Sqrt(x * x + y * y);

                // Периметр
                perimeter = x + y + c;

                // Вивід результатів
                label3.Text = $"Результат:\nПлоща = {area:F4}\nПериметр = {perimeter:F4}";
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }
    }
}
