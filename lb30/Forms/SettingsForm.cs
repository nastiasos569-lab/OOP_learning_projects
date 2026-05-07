using lb30.Models;
using lb30.Utils;
using System;
using System.Windows.Forms;

namespace lb30.Forms
{
    public partial class SettingsForm : Form
    {
        public AppSettings Settings { get; private set; }
        public SettingsForm(AppSettings s)
        {
            InitializeComponent();

            tbHost.Text = s.Host;
            tbUser.Text = s.User;
            tbPass.Text = s.Password;
            numPort.Value = s.Port == 0 ? 21 : s.Port;
            tbPath.Text = s.DefaultPath;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings = new AppSettings
            {
                Host = tbHost.Text,
                User = tbUser.Text,
                Password = tbPass.Text,
                Port = (int)numPort.Value,
                DefaultPath = tbPath.Text
            };

            ConfigManager.Save(Settings);
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
