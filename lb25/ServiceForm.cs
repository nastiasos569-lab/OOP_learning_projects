using lb25.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lb25.Models;

namespace lb25
{
    public partial class ServiceForm : Form
    {
        ServiceRepository repo = new ServiceRepository();
        public ServiceForm()
        {
            InitializeComponent();
            this.Load += ServiceForm_Load;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            LoadServices();
        }

        void LoadServices()
        {
            dataGridViewServices.DataSource = repo.GetAll();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var service = new Service
            {
                ServiceName = textBoxServiceName.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };

            repo.Add(service);
            LoadServices();
        }

        private void buttonReport1_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow == null) return;

            var service = new Service
            {
                Id = (int)dataGridViewServices.CurrentRow.Cells["Id"].Value,
                ServiceName = textBoxServiceName.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };

            repo.Update(service);
            LoadServices();
        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow == null) return;

            int id = (int)dataGridViewServices.CurrentRow.Cells["Id"].Value;

            repo.Delete(id);
            LoadServices();
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            dataGridViewServices.DataSource =
                repo.Search(textBoxSearchService.Text);
        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewServices.CurrentRow == null) return;

            textBoxServiceName.Text =
                dataGridViewServices.CurrentRow.Cells["ServiceName"].Value.ToString();

            textBoxPrice.Text =
                dataGridViewServices.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
