using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb24
{
    public partial class Form2 : Form
    {
        Thread t1, t2, t3;
        bool run1 = false;
        bool run2 = false;
        bool run3 = false;
        public Form2()
        {
            InitializeComponent();
        }
        void DrawRect()
        {
            Random rnd = new Random();
            Graphics g = panel1.CreateGraphics();
            while (run1)
            {
                Thread.Sleep(100);

                int w = rnd.Next(20, panel1.Width);
                int h = rnd.Next(20, panel1.Height);

                g.DrawRectangle(Pens.Red, 0, 0, w, h);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!run1)
            {
                run1 = true;
                t1 = new Thread(DrawRect);
                t1.Start();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            run1 = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!run2)
            {
                run2 = true;
                t2 = new Thread(DrawEllipse);
                t2.Start();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            run2 = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!run3)
            {
                run3 = true;
                t3 = new Thread(GenerateText);
                t3.Start();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            run3 = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
            button2_Click(null, null);
            button3_Click(null, null);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            run1 = run2 = run3 = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        void DrawEllipse()
        {
            Random rnd = new Random();
            Graphics g = panel2.CreateGraphics();

            while (run2)
            {
                Thread.Sleep(100);

                int w = rnd.Next(20, panel2.Width);
                int h = rnd.Next(20, panel2.Height);

                g.DrawEllipse(Pens.Blue, 0, 0, w, h);
            }
        }
        void GenerateText()
        {
            Random rnd = new Random();

            while (run3)
            {
                Thread.Sleep(200);

                string s = rnd.Next(1000).ToString();

                richTextBox1.Invoke((MethodInvoker)(() =>
                {
                    richTextBox1.AppendText(s + " ");
                }));
            }
        }
    }
}
