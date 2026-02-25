using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lb16
{
    public partial class Form1 : Form
    {
        Circle c;
        RectangleShape r;
        Square s;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            c = new Circle(50, 50, 40);
            r = new RectangleShape(200, 80, 120, 70);
            s = new Square(400, 150, 60);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            c.Draw(e.Graphics);
            r.Draw(e.Graphics);
            s.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int dx = Convert.ToInt32(textBox1.Text);
                int dy = Convert.ToInt32(textBox2.Text);

                c.Move(dx, dy);
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Введіть правильні числа!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double scale = Convert.ToDouble(textBox3.Text);

                c.Resize(scale);
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Введіть правильний коефіцієнт!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int dx = Convert.ToInt32(textBox1.Text);
                int dy = Convert.ToInt32(textBox2.Text);

                r.Move(dx, dy);
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double scale = Convert.ToDouble(textBox3.Text);

                r.Resize(scale);
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int dx = Convert.ToInt32(textBox1.Text);
                int dy = Convert.ToInt32(textBox2.Text);

                s.Move(dx, dy);
                Invalidate();
            }
            catch
            {
                MessageBox.Show("Помилка введення!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string msg =
       $"Коло: {c.Area():F2}\n" +
       $"Прямокутник: {r.Area():F2}\n" +
       $"Квадрат: {s.Area():F2}";

            MessageBox.Show(msg, "Площі фігур");
        }
    }
}
