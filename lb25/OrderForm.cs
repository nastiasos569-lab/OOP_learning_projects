using lb25.Models;
using lb25.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lb25
{
    public partial class OrderForm : Form
    {
        OrderRepository orderRepo = new OrderRepository();
        ClientRepository clientRepo = new ClientRepository();
        ServiceRepository serviceRepo = new ServiceRepository();

        List<Client> clients;
        List<Service> services;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadOrders();

            comboBoxClient.SelectedIndex = -1;
            comboBoxService.SelectedIndex = -1;
        }
        void LoadComboBoxes()
        {
            clients = clientRepo.GetAll();
            services = serviceRepo.GetAll();

            comboBoxClient.DataSource = clients;
            comboBoxClient.DisplayMember = "Name";
            comboBoxClient.ValueMember = "Id";

            comboBoxService.DataSource = services;
            comboBoxService.DisplayMember = "ServiceName";
            comboBoxService.ValueMember = "Id";
        }
        void LoadOrders()
        {
            dataGridViewOrders.DataSource = orderRepo.GetAll();
        }
        Service GetSelectedService()
        {
            if (comboBoxService.SelectedValue == null) return null;

            int serviceId = Convert.ToInt32(comboBoxService.SelectedValue);

            return services.FirstOrDefault(s => s.Id == serviceId);
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null || comboBoxService.SelectedValue == null)
            {
                MessageBox.Show("Оберіть клієнта і послугу");
                return;
            }

            int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
            int serviceId = Convert.ToInt32(comboBoxService.SelectedValue);

            var service = GetSelectedService();
            if (service == null) return;

            int quantity = (int)numericQuantity.Value;
            decimal total = service.Price * quantity;

            var order = new Order
            {
                ClientId = clientId,
                ServiceId = serviceId,
                Date = dateTimePicker.Value,
                Quantity = quantity,
                Total = total
            };

            orderRepo.Add(order);
            LoadOrders();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;

            int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);
            int serviceId = Convert.ToInt32(comboBoxService.SelectedValue);

            var service = GetSelectedService();
            if (service == null) return;

            int quantity = (int)numericQuantity.Value;
            decimal total = service.Price * quantity;

            var order = new Order
            {
                Id = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["Id"].Value),
                ClientId = clientId,
                ServiceId = serviceId,
                Date = dateTimePicker.Value,
                Quantity = quantity,
                Total = total
            };

            orderRepo.Update(order);
            LoadOrders();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["Id"].Value);

            orderRepo.Delete(id);
            LoadOrders();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;

            int clientId = Convert.ToInt32(
                dataGridViewOrders.CurrentRow.Cells["ClientId"].Value);

            int serviceId = Convert.ToInt32(
                dataGridViewOrders.CurrentRow.Cells["ServiceId"].Value);

            comboBoxClient.SelectedValue = clientId;
            comboBoxService.SelectedValue = serviceId;

            numericQuantity.Value =
                Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["Quantity"].Value);

            dateTimePicker.Value =
                Convert.ToDateTime(dataGridViewOrders.CurrentRow.Cells["Date"].Value);
        }
    }
}