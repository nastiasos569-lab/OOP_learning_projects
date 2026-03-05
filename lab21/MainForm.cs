using lab21;
using System;
using System.Windows.Forms;

namespace lab21
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm editor = new EditorForm();
            editor.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm editor = new EditorForm();
            editor.OpenFile();
            editor.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Файл";
            newToolStripMenuItem.Text = "Новий";
            openToolStripMenuItem.Text = "Відкрити";
            exitToolStripMenuItem.Text = "Вихід";
            ukrainianToolStripMenuItem.Text = "Українська";
            languageToolStripMenuItem.Text = "Мова";
            englishToolStripMenuItem.Text = "Англійська";
            MainForm.ActiveForm.Text = "Меню текстового редактора";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            newToolStripMenuItem.Text = "New";
            openToolStripMenuItem.Text = "Open";
            exitToolStripMenuItem.Text = "Exit";
            englishToolStripMenuItem.Text = "English";
            ukrainianToolStripMenuItem.Text = "Ukrainian";
            languageToolStripMenuItem.Text = "Language";
            MainForm.ActiveForm.Text = "Menu";         }

    }
}