using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        double a = 1;

        private void btnDraw_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxA.Text);
            this.Invalidate(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int scale = 40;

            DrawAxes(g, centerX, centerY);

            Pen pen = new Pen(Color.Blue, 2);

            Point? prev = null;

            for (double t = -5; t <= 5; t += 0.01)
            {
                if (Math.Abs(1 + Math.Pow(t, 3)) < 0.0001)
                    continue;

                double x = (3 * a * t) / (1 + Math.Pow(t, 3));
                double y = (3 * a * Math.Pow(t, 2)) / (1 + Math.Pow(t, 3));

                int px = centerX + (int)(x * scale);
                int py = centerY - (int)(y * scale);

                Point p = new Point(px, py);

                if (prev != null)
                {
                    g.DrawLine(pen, prev.Value, p);
                }

                prev = p;
            }
        }

        private void DrawAxes(Graphics g, int cx, int cy)
        {
            Pen axisPen = new Pen(Color.Black, 2);

            g.DrawLine(axisPen, 0, cy, this.ClientSize.Width, cy);
            g.DrawLine(axisPen, cx, 0, cx, this.ClientSize.Height);

            Font font = new Font("Arial", 10);

            g.DrawString("X", font, Brushes.Black, this.ClientSize.Width - 20, cy + 5);
            g.DrawString("Y", font, Brushes.Black, cx + 5, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
