using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lb29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupAddress = IPAddress.Parse(HOST);
        }
        UdpClient client;
        bool alive = false;

        string userName;

        string HOST = "235.5.5.1";
        int LOCALPORT = 8001;
        int REMOTEPORT = 8001;
        int TTL = 20;
        string logFile = "chat_log.txt";

        IPAddress groupAddress;

        void SaveMessage(string msg)
        {
            try
            {
                System.IO.File.AppendAllText(logFile, msg + Environment.NewLine);
            }
            catch { }
        }

        private void ReceiveMessages()
        {
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);

                    string message = Encoding.Unicode.GetString(data);
                    string time = DateTime.Now.ToShortTimeString();
                    string fullMessage = time + " " + message;
                    SaveMessage(fullMessage);
                    this.Invoke(new MethodInvoker(() =>
                    {
                        chatTextBox.Text = fullMessage + "\r\n" + chatTextBox.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            try
            {
                HOST = textBoxHost.Text;
                LOCALPORT = int.Parse(textBoxLocalPort.Text);
                REMOTEPORT = int.Parse(textBoxRemotePort.Text);

                groupAddress = IPAddress.Parse(HOST);

                MessageBox.Show("Налаштування застосовано!");
            }
            catch
            {
                MessageBox.Show("Перевір правильність введених даних!");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (alive)
                return;
            userName = userNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введіть ім'я!");
                return;
            }

            try
            {
                client = new UdpClient();

                client.Client.SetSocketOption(
                    SocketOptionLevel.Socket,
                    SocketOptionName.ReuseAddress,
                    true
                );

                client.ExclusiveAddressUse = false;
                client.Client.Bind(new IPEndPoint(IPAddress.Any, LOCALPORT));

                client.JoinMulticastGroup(groupAddress, TTL);

                alive = true;

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " увійшов в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = userName + " покинув чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                try
                {
                    client.DropMulticastGroup(groupAddress);
                }
                catch { }
                alive = false;
                client.Close();

                loginButton.Enabled = true;
                logoutButton.Enabled = false;
                sendButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                chatTextBox.Font = fontDialog1.Font;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(messageTextBox.Text))
                    return;
                if (client == null || !alive)
                {
                    MessageBox.Show("Спочатку увійдіть у чат!");
                    return;
                }
                string message = $"{userName}: {messageTextBox.Text}";
                string time = DateTime.Now.ToShortTimeString();
                string fullMessage = time + " " + message;
                SaveMessage(fullMessage);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (alive)
            {
                try
                {
                    string message = userName + " покинув чат";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    client.Send(data, data.Length, HOST, REMOTEPORT);

                    client.DropMulticastGroup(groupAddress);
                    alive = false;
                    client.Close();
                }
                catch { }
            }
        }
    }
}
