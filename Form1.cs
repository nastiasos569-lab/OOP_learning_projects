using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb19_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] words;

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Рядок порожній!");
                return;
            }

            words = input.Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);

            var wordGroups = words
                .GroupBy(w => w.ToLower())
                .Where(g => g.Count() > 1);

            label3.Text = "";   // очищаємо перед виводом

            if (!wordGroups.Any())
            {
                label3.Text = "Однакових слів немає.";
            }
            else
            {
                foreach (var group in wordGroups)
                {
                    label3.Text +=
                        $"Слово \"{group.Key}\" зустрічається {group.Count()} раз(и)\r\n";
                }
            }
        }


        private void textBoxRemove_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Рядок порожній!");
                return;
            }

            words = input.Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);
            if (words == null)
            {
                MessageBox.Show("Спочатку введіть рядок і натисніть 'Знайти'!");
                return;
            }

            string wordToRemove = textBoxRemove.Text;

            if (string.IsNullOrWhiteSpace(wordToRemove))
            {
                MessageBox.Show("Введіть слово для видалення!");
                return;
            }

            string[] filteredWords = words
                .Where(w => !w.Equals(wordToRemove,
                        StringComparison.OrdinalIgnoreCase))
                .ToArray();

            string result = string.Join(" ", filteredWords);

            label3.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
