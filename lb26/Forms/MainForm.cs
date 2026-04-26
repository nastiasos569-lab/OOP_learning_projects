using lb26.Models;
using lb26.Services;
using lb26.Utils;
using System;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lb26.Forms
{
    public partial class MainForm : Form
    {
        private WordService wordService = new WordService();
        private string currentTemplatePath = "";

        public MainForm()
        {
            InitializeComponent();
            LoadTemplates();
        }
        private void LoadTemplates()
        {
            cmbTemplates.Items.Add("gas1.dotx");
            cmbTemplates.Items.Add("gas2.dotx");
            cmbTemplates.Items.Add("gas3.dotx");

            cmbTemplates.SelectedIndex = 0;
        }
        private ReceiptData GetData()
        {
            double.TryParse(txtVolume.Text, out double volume);
            double.TryParse(txtTariff.Text, out double tariff);

            return new ReceiptData
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Account = txtAccount.Text,
                Volume = volume,
                Tariff = tariff
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                currentTemplatePath = FileHelper.GetTemplatePath(cmbTemplates.SelectedItem.ToString());

                if (!FileHelper.FileExists(currentTemplatePath))
                {
                    MessageBox.Show("Шаблон не знайдено!");
                    return;
                }

                var data = GetData();

                wordService.CreateDocument(currentTemplatePath);
                wordService.FillDocument(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemplatePreviewForm form = new TemplatePreviewForm(wordService);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document (*.docx)|*.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wordService.SaveAs(sfd.FileName);
                MessageBox.Show("Документ збережено!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wordService.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindReplaceForm form = new FindReplaceForm(wordService);
            form.ShowDialog();
        }
    }
}