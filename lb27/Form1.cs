using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

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

        private void button3_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Назва папки:");

            if (!string.IsNullOrEmpty(name))
            {
                string newPath = Path.Combine(currentPath, name);
                Directory.CreateDirectory(newPath);
                LoadData(currentPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            string path = treeView1.SelectedNode.Tag.ToString();

            try
            {
                Directory.Delete(path, true);
                LoadData(currentPath);
            }
            catch
            {
                MessageBox.Show("Не вдалося видалити папку");
            }
        }
        void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(dest);

            foreach (var file in Directory.GetFiles(source))
            {
                string name = Path.GetFileName(file);
                File.Copy(file, Path.Combine(dest, name), true);
            }

            foreach (var dir in Directory.GetDirectories(source))
            {
                string name = Path.GetFileName(dir);
                CopyDirectory(dir, Path.Combine(dest, name));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            string source = treeView1.SelectedNode.Tag.ToString();
            string dest = source + "_copy";

            CopyDirectory(source, dest);

            LoadData(currentPath);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Назва файлу:");

            if (!string.IsNullOrEmpty(name))
            {
                string path = Path.Combine(currentPath, name);
                File.WriteAllText(path, "");
                LoadFiles(currentPath);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string source = listBoxFiles.SelectedItem.ToString();
            string dest = Path.Combine(currentPath, "copy_" + Path.GetFileName(source));

            File.Copy(source, dest, true);
            LoadFiles(currentPath);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string file = listBoxFiles.SelectedItem.ToString();

            try
            {
                File.Delete(file);
                LoadFiles(currentPath);
            }
            catch
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string source = listBoxFiles.SelectedItem.ToString();
            string dest = Path.Combine(currentPath, "moved_" + Path.GetFileName(source));

            File.Move(source, dest);
            LoadFiles(currentPath);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string file = listBoxFiles.SelectedItem.ToString();

            FileAttributes attr = File.GetAttributes(file);
            File.SetAttributes(file, attr | FileAttributes.ReadOnly);

            MessageBox.Show("Файл зроблено тільки для читання");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string file = listBoxFiles.SelectedItem.ToString();

            if (Path.GetExtension(file).ToLower() == ".txt")
            {
                try
                {
                    File.SetAttributes(file, FileAttributes.Normal); 

                    File.WriteAllText(file, richTextBoxContent.Text, Encoding.UTF8);

                    MessageBox.Show("Збережено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string zipPath = Path.Combine(
                    Path.GetDirectoryName(currentPath),
                    Path.GetFileName(currentPath) + ".zip"
                );

                if (File.Exists(zipPath))
                    File.Delete(zipPath);

                ZipFile.CreateFromDirectory(currentPath, zipPath);

                MessageBox.Show("Архів створено:\n" + zipPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка архівації: " + ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string zip = listBoxFiles.SelectedItem.ToString();

            if (Path.GetExtension(zip).ToLower() == ".zip")
            {
                string extractPath = Path.Combine(currentPath, "unzipped");

                try
                {
                    if (Directory.Exists(extractPath))
                        Directory.Delete(extractPath, true);

                    ZipFile.ExtractToDirectory(zip, extractPath);

                    LoadData(currentPath);
                    MessageBox.Show("Розпаковано");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
       
    }
        

        private void button14_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            string source = treeView1.SelectedNode.Tag.ToString();
            string dest = Path.Combine(
                Path.GetDirectoryName(source),
                Path.GetFileName(source) + "_moved"
            );

            try
            {
                if (Directory.Exists(dest))
                    Directory.Delete(dest, true);

                Directory.Move(source, dest);

                currentPath = Path.GetDirectoryName(dest);
                LoadData(currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка переміщення: " + ex.Message);
            }
        }
    }
    }
