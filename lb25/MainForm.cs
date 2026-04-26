using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceForm form = new ServiceForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
