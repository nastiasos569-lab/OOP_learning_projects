using lb25.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb25
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        ClientRepository clientRepo = new ClientRepository();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
        void LoadClients()
        {
            dataGridViewClients.DataSource = clientRepo.GetAll();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var client = new Models.Client
            {
                Name = textBoxClientName.Text,
                Phone = textBoxClientPhone.Text
            };

            clientRepo.Add(client);
            LoadClients();
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource =
        clientRepo.Search(textBoxSearchClient.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null) return;

            var client = new Models.Client
            {
                Id = (int)dataGridViewClients.CurrentRow.Cells["Id"].Value,
                Name = textBoxClientName.Text,
                Phone = textBoxClientPhone.Text
            };

            clientRepo.Update(client);
            LoadClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null) return;

            int id = (int)dataGridViewClients.CurrentRow.Cells["Id"].Value;

            clientRepo.Delete(id);
            LoadClients();
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null) return;

            textBoxClientName.Text =
                dataGridViewClients.CurrentRow.Cells["Name"].Value.ToString();

            textBoxClientPhone.Text =
                dataGridViewClients.CurrentRow.Cells["Phone"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
