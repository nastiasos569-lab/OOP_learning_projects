using lb26.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb26.Forms
{
    public partial class FindReplaceForm : Form
    {
        private readonly WordService wordService;
        private string activeFile;
        public FindReplaceForm(WordService service)
        {
            InitializeComponent();
            wordService = service;

            LoadDocuments();
        }
        private void LoadDocuments()
        {
            cmbDocuments.Items.Clear();

            foreach (var file in wordService.CreatedDocuments)
            {
                cmbDocuments.Items.Add(file);
            }

            if (cmbDocuments.Items.Count > 0)
                cmbDocuments.SelectedIndex = 0;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(activeFile))
            {
                MessageBox.Show("Виберіть або відкрийте файл!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFind.Text))
            {
                MessageBox.Show("Введіть текст для пошуку!");
                return;
            }
            wordService.SetActiveDocument(activeFile);

            wordService.FindAndReplace(
                txtFind.Text,
                txtReplace.Text
            );

            wordService.SaveAs(activeFile);

            MessageBox.Show("Заміна виконана і файл збережено!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocuments.SelectedItem == null) return;

            activeFile = cmbDocuments.SelectedItem.ToString();
            wordService.OpenDocument(activeFile);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Word files (*.docx)|*.docx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    activeFile = ofd.FileName;

                    wordService.OpenDocument(activeFile);

                    MessageBox.Show("Файл відкрито:\n" + activeFile);
                }
            }
        }
    }
}
