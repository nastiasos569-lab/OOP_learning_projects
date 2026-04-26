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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb24
{
    public partial class Form3 : Form
    {
        bool run1 = false;
        bool run2 = false;
        bool run3 = false;

        public Form3()
        {
            InitializeComponent();
        }
        async Task RunMMB()
        {
            MMB mmb = new MMB();

            while (run1)
            {
                await Task.Delay(200);

                string input = DateTime.Now.ToString();
                string result = mmb.Encrypt(input);

                Invoke((MethodInvoker)(() =>
                {
                    richTextBox1.AppendText("MMB: " + result + "\n");
                }));
            }
        }
        async Task RunHash()
        {
            ARHash hash = new ARHash();

            while (run2)
            {
                await Task.Delay(300);

                string input = DateTime.Now.ToString();
                int result = hash.Compute(input);

                Invoke((MethodInvoker)(() =>
                {
                    richTextBox2.AppendText("Hash: " + result + "\n");
                }));
            }
        }
        async Task RunPless()
        {
            PlessGenerator gen = new PlessGenerator();

            while (run3)
            {
                await Task.Delay(400);

                string result = gen.Generate(5);

                Invoke((MethodInvoker)(() =>
                {
                    richTextBox3.AppendText("Pless: " + result + "\n");
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!run1)
            {
                run1 = true;
                Task.Run(RunMMB);
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
                Task.Run(RunHash);
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
                Task.Run(RunPless);
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
    }
}
