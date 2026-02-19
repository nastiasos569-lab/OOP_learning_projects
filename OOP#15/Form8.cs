using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_15
{
    public partial class Form8 : Form
    {
        public Form8()
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
            label3.Text = "Результат:";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                string[] words = text.Split(' ');

                string result = "";

                foreach (string word in words)
                {
                    char[] arr = word.ToCharArray();
                    Array.Reverse(arr);
                    result += new string(arr) + " ";
                }

                label3.Text = result;
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }
    }
}
