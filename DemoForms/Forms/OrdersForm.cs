using DemoLib.Models;
using DemoLib.Repositories;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoForms.Forms
{
    public partial class OrdersForm : Form
    {
        private readonly OrderRepository repository;

        private List<Order> orders;

        public OrdersForm()
        {
            InitializeComponent();

            repository =
                new OrderRepository();
        }

        private void OrdersForm_Load(
            object sender,
            EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            orders =
                repository.GetAll();

            dgvOrders.Rows.Clear();

            foreach (Order order in orders)
            {
                dgvOrders.Rows.Add(
                    order.Id,
                    order.OrderNumber,
                    order.ClientName,
                    order.OrderDate.ToShortDateString(),
                    order.DeliveryDate.ToShortDateString(),
                    order.PickupPoint.Address,
                    order.ReceiveCode,
                    order.Status.Name);
            }
        }

        private Order GetSelectedOrder()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                return null;
            }

            int id =
                Convert.ToInt32(
                    dgvOrders.SelectedRows[0]
                    .Cells["colId"]
                    .Value);

            foreach (Order order in orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }

            return null;
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            OrderEditForm form =
                new OrderEditForm();

            form.ShowDialog();

            LoadOrders();
        }

        private void btnEdit_Click(
            object sender,
            EventArgs e)
        {
            Order order =
                GetSelectedOrder();

            if (order == null)
            {
                MessageBox.Show(
                    "Выберите заказ");

                return;
            }

            OrderEditForm form =
                new OrderEditForm(order);

            form.ShowDialog();

            LoadOrders();
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            Order order =
                GetSelectedOrder();

            if (order == null)
            {
                MessageBox.Show(
                    "Выберите заказ");

                return;
            }

            if (MessageBox.Show(
                "Удалить заказ?",
                "Подтверждение",
                MessageBoxButtons.YesNo)
                != DialogResult.Yes)
            {
                return;
            }

            repository.Delete(
                order.Id);

            LoadOrders();
        }

        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}