using lb30.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using lb30.Models;
using lb30.Forms;

namespace lb30.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void SetupRequest(FtpWebRequest req)
        {
            req.Credentials = new NetworkCredential(
        tbUser.Text.Trim(),
        tbPass.Text.Trim()
    );

            req.UsePassive = true;
            req.UseBinary = true;
            req.KeepAlive = false;

            req.Timeout = 10000;
            req.ReadWriteTimeout = 10000;
        }
        string BuildPath(string path, string name = "")
        {
            string host = tbHost.Text.Trim().TrimEnd('/');

            if (!host.StartsWith("ftp://"))
                host = "ftp://" + host;

            string url = host;

            if (!string.IsNullOrEmpty(path))
                url += "/" + path.Trim('/');

            if (!string.IsNullOrEmpty(name))
                url += "/" + name;

            return url;
        }
        bool IsDirectory(string line)
        {
            return line.StartsWith("d"); 
        }
        private void LoadTree(string path, TreeNode parent = null)
        {
            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            SetupRequest(req);
            req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (var resp = (FtpWebResponse)req.GetResponse())
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string line = reader.ReadLine();

                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        int index = line.LastIndexOf(' ');
                        if (index == -1)
                            continue;

                        string name = line.Substring(index + 1);

                        TreeNode node = new TreeNode(FormatNode(line));
                        node.ToolTipText = line;
                        node.Tag = name;

                        if (IsDirectory(line))
                            node.Nodes.Add("...");

                        if (parent == null)
                            treeViewFtp.Nodes.Add(node);
                        else
                            parent.Nodes.Add(node);
                    }
                    catch
                    {
                        // пропускаємо биті рядки FTP
                    }
                }
            }
        }

        private void treeViewFtp_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewFtp.SelectedNode = e.Node;
        }
        string GetSelectedPath()
        {
            if (treeViewFtp.SelectedNode == null) return null;

            return treeViewFtp.SelectedNode.FullPath.Replace("\\", "/");
        }

        private void downloadRETRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = Path.GetFileName(path);

            if (dlg.ShowDialog() != DialogResult.OK) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            using (var resp = (FtpWebResponse)req.GetResponse())
            using (var stream = resp.GetResponseStream())
            using (var fs = new FileStream(dlg.FileName, FileMode.Create))
            {
                stream.CopyTo(fs);
            }

            MessageBox.Show("Скачано");
        }

        private void uploadSTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            string fileName = Path.GetFileName(dlg.FileName);
            string path = GetSelectedPath();
            if (path == null) path = "";

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path, fileName));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.UploadFile;

            byte[] data = File.ReadAllBytes(dlg.FileName);

            using (var stream = req.GetRequestStream())
                stream.Write(data, 0, data.Length);

            MessageBox.Show("Завантажено");
        }

        private void uploadUniqueSTOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string path = GetSelectedPath();
            if (path == null) path = "";

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.UploadFileWithUniqueName;

            byte[] data = File.ReadAllBytes(dlg.FileName);

            using (var stream = req.GetRequestStream())
                stream.Write(data, 0, data.Length);

            MessageBox.Show("Завантажено (STOU)");
        }

        private void appendAPPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.AppendFile;

            byte[] data = File.ReadAllBytes(dlg.FileName);

            using (var stream = req.GetRequestStream())
                stream.Write(data, 0, data.Length);

            MessageBox.Show("Дописано");
        }

        private void deleteDELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
     tbUser.Text.Trim(),
     tbPass.Text.Trim()
 );
            req.Method = WebRequestMethods.Ftp.DeleteFile;

            req.GetResponse().Close();

            MessageBox.Show("Видалено");
        }

        private void renameRENAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            string newName = Microsoft.VisualBasic.Interaction.InputBox("Нове ім'я:");

            if (string.IsNullOrWhiteSpace(newName)) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.Rename;
            req.RenameTo = newName;

            req.GetResponse().Close();

            MessageBox.Show("Перейменовано");
        }

        private void sizeSIZEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.GetFileSize;

            var resp = (FtpWebResponse)req.GetResponse();

            MessageBox.Show("Розмір: " + resp.ContentLength + " байт");
        }

        private void sizeSIZEDateMDTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            req.Credentials = new NetworkCredential(
     tbUser.Text.Trim(),
     tbPass.Text.Trim()
 );
            req.Method = WebRequestMethods.Ftp.GetDateTimestamp;

            var resp = (FtpWebResponse)req.GetResponse();

            MessageBox.Show("Дата: " + resp.LastModified);
        }

        private void createMKDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Назва папки:");
            if (string.IsNullOrWhiteSpace(name)) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath("", name));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.MakeDirectory;

            req.GetResponse().Close();

            MessageBox.Show("Створено");
        }

        private void removeRMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();
            if (path == null) return;

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(path));
            SetupRequest(req);
            req.Method = WebRequestMethods.Ftp.RemoveDirectory;

            req.GetResponse().Close();

            req.GetResponse().Close();

            MessageBox.Show("Папку видалено");
        }

        private void listLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewFtp.Nodes.Clear();

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(""));
            req.Credentials = new NetworkCredential(
    tbUser.Text.Trim(),
    tbPass.Text.Trim()
);
            req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (var resp = (FtpWebResponse)req.GetResponse())
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                while (!reader.EndOfStream)
                {
                    treeViewFtp.Nodes.Add(reader.ReadLine());
                }
            }
        }

        private void simpleListNLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewFtp.Nodes.Clear();

            var req = (FtpWebRequest)WebRequest.Create(BuildPath(""));
            req.Credentials = new NetworkCredential(
     tbUser.Text.Trim(),
     tbPass.Text.Trim()
 );
            req.Method = WebRequestMethods.Ftp.ListDirectory;

            using (var resp = (FtpWebResponse)req.GetResponse())
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                while (!reader.EndOfStream)
                {
                    treeViewFtp.Nodes.Add(reader.ReadLine());
                }
            }
        }

        private void treeViewFtp_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "...")
            {
                e.Node.Nodes.Clear();

                string path = e.Node.FullPath.Replace("\\", "/");
                LoadTree("/" + path, e.Node);
            }
        }
        string FormatNode(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return "";

            int index = line.LastIndexOf(' ');
            if (index == -1)
                return line;

            string name = line.Substring(index + 1);

            if (comboBoxView.Text == "Simple")
                return name;

            return line;
        }
        void UploadFolder(string localPath, string ftpPath)
        {
            foreach (var file in Directory.GetFiles(localPath))
            {
                string name = Path.GetFileName(file);

                var req = (FtpWebRequest)WebRequest.Create(BuildPath(ftpPath, name));
                req.Credentials = new NetworkCredential(
     tbUser.Text.Trim(),
     tbPass.Text.Trim()
 );
                req.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = File.ReadAllBytes(file);
                using (var s = req.GetRequestStream())
                    s.Write(data, 0, data.Length);
            }

            foreach (var dir in Directory.GetDirectories(localPath))
            {
                string name = Path.GetFileName(dir);

                // створити папку
                var mkd = (FtpWebRequest)WebRequest.Create(BuildPath(ftpPath, name));
                mkd.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                mkd.Method = WebRequestMethods.Ftp.MakeDirectory;
                try
                {
                    mkd.GetResponse().Close();
                }
                catch
                {
                }
                UploadFolder(dir, ftpPath + "/" + name);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewFtp.Nodes.Clear();
                LoadTree("/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                treeViewFtp.Nodes.Clear();
                LoadTree("/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                string path = GetSelectedPath();
                if (path == null) path = "";

                UploadFolder(dlg.SelectedPath, path);

                MessageBox.Show("Папку завантажено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm(ConfigManager.Load());

            if (form.ShowDialog() == DialogResult.OK)
            {
                var s = form.Settings;

                tbHost.Text = s.Host;
                tbUser.Text = s.User;
                tbPass.Text = s.Password;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
