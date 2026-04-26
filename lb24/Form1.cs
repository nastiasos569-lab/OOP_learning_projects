using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace lb24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(); 
            f.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}