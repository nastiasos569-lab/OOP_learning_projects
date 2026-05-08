using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitList();
            LoadProcesses();
        }
        void InitList()
        {
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Ім'я процесу", 250);
            listView1.Columns.Add("Пам'ять (MB)", 150);
        }

        void LoadProcesses()
        {
            listView1.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                try
                {
                    ListViewItem item = new ListViewItem(proc.Id.ToString());

                    item.SubItems.Add(proc.ProcessName);

                    double mem = proc.WorkingSet64 / 1024.0 / 1024.0;
                    item.SubItems.Add(mem.ToString("F2"));

                    item.Tag = proc;

                    listView1.Items.Add(item);
                }
                catch
                {

                }
            }
        }
        Process GetSelectedProcess()
        {
            if (listView1.SelectedItems.Count == 0)
                return null;

            return (Process)listView1.SelectedItems[0].Tag;
        }

        private void інформаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = GetSelectedProcess();

            if (proc == null)
                return;

            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("ID: " + proc.Id);
                sb.AppendLine("Назва: " + proc.ProcessName);
                sb.AppendLine("Пам'ять: " + proc.WorkingSet64);
                sb.AppendLine("Час запуску: " + proc.StartTime);
                sb.AppendLine("Машина: " + proc.MachineName);

                MessageBox.Show(sb.ToString(),
                    "Інформація про процес");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void завершитиПроцесToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = GetSelectedProcess();

            if (proc == null)
                return;

            try
            {
                proc.Kill();

                LoadProcesses();

                MessageBox.Show("Процес завершено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void потокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = GetSelectedProcess();

            if (proc == null)
                return;

            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (ProcessThread thread in proc.Threads)
                {
                    sb.AppendLine(
                        "Thread ID: " + thread.Id +
                        " Priority: " + thread.CurrentPriority);
                }

                MessageBox.Show(sb.ToString(),
                    "Потоки процесу");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void модуліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = GetSelectedProcess();

            if (proc == null)
                return;

            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (ProcessModule module in proc.Modules)
                {
                    sb.AppendLine(
                        module.ModuleName +
                        "\n" +
                        module.FileName +
                        "\n");
                }

                MessageBox.Show(sb.ToString(),
                    "Модулі процесу");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void оновитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void експортУTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(sfd.FileName))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        sw.WriteLine(
                            item.SubItems[0].Text + " | " +
                            item.SubItems[1].Text + " | " +
                            item.SubItems[2].Text);
                    }
                }

                MessageBox.Show("Експорт завершено");
            }
        }
    }
}
