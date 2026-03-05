using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab21
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        public void OpenFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "RTF files|*.rtf|Text files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName);
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF files|*.rtf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName);
            }
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void alignLeftToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void imageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetImage(Image.FromFile(open.FileName));
                richTextBox1.Paste();
            }
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Файл";
            saveToolStripMenuItem.Text = "Зберегти";
            exitToolStripMenuItem.Text = "Вихід";
            editToolStripMenuItem.Text = "Редагувати";
            fontToolStripMenuItem.Text = "Шрифт";
            languageToolStripMenuItem.Text = "Мова";
            ukrainianToolStripMenuItem.Text = "Українська";
            englishToolStripMenuItem.Text = "Англійська";
            alignLeftToolStripMenuItem.Text = "Вирівняти по лівому краю";
            alignCenterToolStripMenuItem.Text = "Вирівняти по центру";
            alignRightToolStripMenuItem.Text = "Вирівняти по правому краю";
            imageToolStripMenuItem.Text = "Зображення";
            insertToolStripMenuItem.Text = "Вставка";
            EditorForm.ActiveForm.Text = "Текстовий редактор";
            button1.Text = "Підсвітка синтаксису";
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            saveToolStripMenuItem.Text = "Save";
            exitToolStripMenuItem.Text = "Exit";
            editToolStripMenuItem.Text = "Edit";
            fontToolStripMenuItem.Text = "Font";
            languageToolStripMenuItem.Text = "Language";
            ukrainianToolStripMenuItem.Text = "Ukrainian";
            englishToolStripMenuItem.Text = "English";
            alignLeftToolStripMenuItem.Text = "Align Left";
            alignCenterToolStripMenuItem.Text = "Align Center";
            alignRightToolStripMenuItem.Text = "Align Right";
            imageToolStripMenuItem.Text = "Image";
            insertToolStripMenuItem.Text = "Insert";
            EditorForm.ActiveForm.Text = "Text Editor";
            button1.Text = "Syntax Highlighting";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;

            string[] keywords =
            {
        "int","float","double","char","string",
        "if","else","while","for","return",
        "class","public","private","void","static"
    };

            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = richTextBox1.Text.Length;
            richTextBox1.SelectionColor = Color.Black;

            foreach (string word in keywords)
            {
                int index = 0;

                while ((index = richTextBox1.Text.IndexOf(word, index)) != -1)
                {
                    richTextBox1.Select(index, word.Length);
                    richTextBox1.SelectionColor = Color.Blue;
                    index += word.Length;
                }
            }

            richTextBox1.SelectionStart = cursorPosition;
            richTextBox1.SelectionColor = Color.Black;
        }
    }
}