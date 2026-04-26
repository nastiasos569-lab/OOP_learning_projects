using lb26.Services;
using lb26.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb26.Forms
{
    public partial class TemplatePreviewForm : Form
    {
        private WordService wordService;
        private string selectedTemplatePath;

        public TemplatePreviewForm(WordService service)
        {
            InitializeComponent();
            wordService = service;
            LoadTemplates();
        }

        private void LoadTemplates()
        {
            lstTemplates.Items.Clear();

            string path = FileHelper.GetTemplatesPath();

            MessageBox.Show("Шлях: " + path);

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Папка Templates не знайдена!");
                return;
            }

            var files = Directory.GetFiles(path, "*.dotx");

            MessageBox.Show("Знайдено файлів: " + files.Length);

            foreach (var file in files)
            {
                lstTemplates.Items.Add(Path.GetFileName(file));
            }

            if (lstTemplates.Items.Count > 0)
                lstTemplates.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(selectedTemplatePath))
            {
                MessageBox.Show("Файл не знайдено!");
                return;
            }

            wordService.CreateDocument(selectedTemplatePath);

            MessageBox.Show("Шаблон відкрито для роботи!");
            this.Close();
        }

        private void lstTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTemplates.SelectedItem == null) return;

            selectedTemplatePath = FileHelper.GetTemplatePath(
                lstTemplates.SelectedItem.ToString()
            );
        }
    }
}
