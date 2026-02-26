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

namespace lb17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[]
            {
        "Прямокутний",
        "Рівнобедрений",
        "Рівносторонній"
            });

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Оберіть тип трикутника!");
                    return;
                }

                string type = comboBox1.SelectedItem.ToString();
                Triangle triangle = null;

                double a, b, angle;

                if (type == "Прямокутний")
                {
           
                    if (!double.TryParse(textBoxA.Text, out a) ||
                        !double.TryParse(textBoxB.Text, out b) ||
                        !double.TryParse(textBoxAngle.Text, out angle))
                    {
                        MessageBox.Show("Введіть правильні числа для сторін!");
                        return;
                    }

                    if (a <= 0 || b <= 0)
                    {
                        MessageBox.Show("Сторони трикутника повинні бути більші за нуль!");
                        return;
                    }

                    
                    triangle = new RightTriangle(a, b, angle);
                }
                else if (type == "Рівнобедрений")
                {
                   
                    if (!double.TryParse(textBoxA.Text, out a) ||
                        !double.TryParse(textBoxB.Text, out b) ||
                        !double.TryParse(textBoxAngle.Text, out angle))
                    {
                        MessageBox.Show("Введіть правильні числа для сторін та кута!");
                        return;
                    }

                    
                    if (a <= 0 || b <= 0)
                    {
                        MessageBox.Show("Сторони трикутника повинні бути більші за нуль!");
                        return;
                    }

                    if (angle <= 0 || angle >= 180)
                    {
                        MessageBox.Show("Кут повинен бути в межах (0°, 180°)!");
                        return;
                    }

                
                    triangle = new IsoscelesTriangle(a, b, angle);
                }
                else if (type == "Рівносторонній")
                {
                  
                    if (!double.TryParse(textBoxA.Text, out a))
                    {
                        MessageBox.Show("Введіть правильне число для сторони!");
                        return;
                    }

                    if (a <= 0)
                    {
                        MessageBox.Show("Сторона трикутника повинна бути більшою за нуль!");
                        return;
                    }

                   
                    if (!double.TryParse(textBoxA.Text, out a) ||
                        !double.TryParse(textBoxB.Text, out b) ||
                        !double.TryParse(textBoxAngle.Text, out angle))
                    {
                        MessageBox.Show("Для рівностороннього трикутника вводиться тільки одна сторона!");
                        return;
                    }

                   
                    triangle = new EquilateralTriangle(a, b, angle);
                }
                else
                {
                    MessageBox.Show("Невідомий тип трикутника!");
                    return;
                }

                
                double area = triangle.GetArea();
                double perimeter = triangle.GetPerimeter();

         
                labelResult.Text = $"Площа: {area:F2}\nПериметр: {perimeter:F2}";
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Невідома помилка!");
            }
        }


    }
}   
