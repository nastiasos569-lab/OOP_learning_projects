using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace lb27
{
    public partial class Form1 : Form
    {
        string currentPath = "";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        string GetFileSecurityInfo(string path)
        {
            try
            {
                FileSecurity security = File.GetAccessControl(path);

                var owner = security.GetOwner(typeof(NTAccount));

                var rules = security.GetAccessRules(true, true, typeof(NTAccount));

                string result = $"Власник: {owner}\r\n\r\nПрава доступу:\r\n";

                foreach (FileSystemAccessRule rule in rules)
                {
                    result += $"{rule.IdentityReference} - {rule.FileSystemRights} - {rule.AccessControlType}\r\n";
                }

                return result;
            }
            catch
            {
                return "Немає доступу до атрибутів безпеки";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDrives.Items.Clear();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                try
                {
                    if (drive.IsReady)
                        comboBoxDrives.Items.Add(drive.Name);
                }
                catch { }
            }

            if (comboBoxDrives.Items.Count > 0)
                comboBoxDrives.SelectedIndex = 0;
            else
                MessageBox.Show("Диски не знайдені!");
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
        }
        void LoadFiles(string path)
        {
            listBoxFiles.Items.Clear();

            try
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    listBoxFiles.Items.Add(file);
                }
            }
            catch
            {
                MessageBox.Show("Помилка доступу до файлів");
            }
        }
        void LoadData(string path)
        {
            try
            {
                treeView1.Nodes.Clear();
                listBoxFiles.Items.Clear();
                pictureBoxPreview.Image = null;
                richTextBoxContent.Clear();

                DirectoryInfo rootDir = new DirectoryInfo(path);

                TreeNode rootNode = new TreeNode(rootDir.Name);
                rootNode.Tag = rootDir.FullName;

                treeView1.Nodes.Add(rootNode);

                LoadSubDirs(rootNode);

                foreach (var file in Directory.GetFiles(path))
                {
                    listBoxFiles.Items.Add(file);
                }
            }
            catch
            {
                MessageBox.Show("Немає доступу");
            }
        }
        void LoadSubDirs(TreeNode node)
        {
            try
            {
                string path = node.Tag.ToString();

                foreach (var dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    TreeNode subNode = new TreeNode(di.Name);
                    subNode.Tag = di.FullName;

                    node.Nodes.Add(subNode);
                }
            }
            catch { }
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPath = comboBoxDrives.SelectedItem.ToString();
            textBoxPath.Text = currentPath;
            LoadData(currentPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir = Directory.GetParent(currentPath);

                if (dir != null)
                {
                    currentPath = dir.FullName;
                    textBoxPath.Text = currentPath;

                    LoadData(currentPath);
                }
            }
            catch { }
        }
        private void textBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPath = textBoxPath.Text;

                if (Directory.Exists(newPath))
                {
                    currentPath = newPath;
                    LoadData(currentPath);
                }
                else
                {
                    MessageBox.Show("Шлях не існує!");
                }
            }
        }

        private void textBoxPath_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPath = textBoxPath.Text;

                if (Directory.Exists(newPath))
                {
                    currentPath = newPath;
                    LoadData(currentPath);
                }
                else
                {
                    MessageBox.Show("Шлях не існує!");
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

                textBoxInfo.Text =
                    $"Назва: {dir.Name}\r\n" +
                    $"Повний шлях: {dir.FullName}\r\n" +
                    $"Створено: {dir.CreationTime}\r\n" +
                    $"Остання зміна: {dir.LastWriteTime}";

                currentPath = path;
                textBoxPath.Text = currentPath;

                LoadFiles(currentPath);
            }
            catch
            {
                textBoxInfo.Text = "Помилка";
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            currentPath = path;
            textBoxPath.Text = currentPath;

            LoadData(currentPath);
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string filePath = listBoxFiles.SelectedItem.ToString();

            try
            {
                FileInfo file = new FileInfo(filePath);

                textBoxInfo.Text =
                    $"Ім'я: {file.Name}\r\n" +
                    $"Шлях: {file.FullName}\r\n" +
                    $"Розмір: {file.Length} байт\r\n" +
                    $"Тип: {file.Extension}\r\n" +
                    $"Створено: {file.CreationTime}";

                textBoxInfo.Text += GetFileSecurityInfo(file.FullName);

                string ext = file.Extension.ToLower();

                if (ext == ".jpg" || ext == ".png" || ext == ".bmp")
                {
                    pictureBoxPreview.Image = null;

                    using (var bmpTemp = new Bitmap(filePath))
                    {
                        pictureBoxPreview.Image = new Bitmap(bmpTemp);
                    }
                    richTextBoxContent.Clear();
                }
                else if (ext == ".txt")
                {
                    pictureBoxPreview.Image = null;

                    try
                    {
                        richTextBoxContent.Text = File.ReadAllText(filePath, Encoding.UTF8);
                    }
                    catch
                    {
                        richTextBoxContent.Text = File.ReadAllText(filePath, Encoding.Default);
                    }
                }
                else
                {
                    pictureBoxPreview.Image = null;
                    richTextBoxContent.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Помилка відкриття файлу");
            }
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            try
            {
                string filePath = listBoxFiles.SelectedItem.ToString();

                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                MessageBox.Show("Не вдалося відкрити файл");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath)) return;

            try
            {
                listBoxFiles.Items.Clear();

                string filter = textBoxFilterFiles.Text.ToLower();

                var files = Directory.GetFiles(currentPath);

                foreach (var file in files)
                {
                    if (Path.GetFileName(file).ToLower().Contains(filter))
                    {
                        listBoxFiles.Items.Add(file);
                    }
                }
            }
            catch { }
        }

        void FilterDirs(string path, string filter)
        {
            treeView1.Nodes.Clear();

            try
            {
                DirectoryInfo rootDir = new DirectoryInfo(path);

                TreeNode rootNode = new TreeNode(rootDir.Name);
                rootNode.Tag = rootDir.FullName;

                treeView1.Nodes.Add(rootNode);

                foreach (var dir in Directory.GetDirectories(path))
                {
                    if (Path.GetFileName(dir).ToLower().Contains(filter.ToLower()))
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(dir));
                        node.Tag = dir;

                        rootNode.Nodes.Add(node);
                    }
                }
            }
            catch { }
        }

        private void textBoxFilterDirs_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath)) return;

            string filter = textBoxFilterDirs.Text;

            if (string.IsNullOrEmpty(filter))
                LoadData(currentPath);
            else
                FilterDirs(currentPath, filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
