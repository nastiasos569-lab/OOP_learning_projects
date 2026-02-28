using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            try
            {
              
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

        
                if (a == 0)
                    throw new Exception("Коефіцієнт a не може дорівнювати 0!");

                double D = b * b - 4 * a * c;

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    labelResult.Text = $"Два корені: x1 = {x1:F2}, x2 = {x2:F2}";
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    labelResult.Text = $"Один корінь: x = {x:F2}";
                }
                else
                {
                    labelResult.Text = "Дійсних коренів немає.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка! Введіть числові значення.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Обчислення завершено.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
