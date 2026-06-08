using DemoLib.Models;
using DemoLib.Repositories;

using System;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DemoForms.Forms
{
    public partial class OrderEditForm : Form
    {
        private readonly OrderRepository repository;

        private readonly PickupPointRepository
            pickupRepository;

        private readonly OrderStatusRepository
            statusRepository;

        private Order currentOrder;

        private bool editMode;

        public OrderEditForm()
        {
            InitializeComponent();

            repository =
                new OrderRepository();

            pickupRepository =
                new PickupPointRepository();

            statusRepository =
                new OrderStatusRepository();

            editMode = false;
        }

        public OrderEditForm(
            Order order)
        {
            InitializeComponent();

            repository =
                new OrderRepository();

            pickupRepository =
                new PickupPointRepository();

            statusRepository =
                new OrderStatusRepository();

            currentOrder =
                repository.GetById(
                    order.Id);

            editMode = true;
        }

        private void OrderEditForm_Load(
            object sender,
            EventArgs e)
        {
            LoadLists();

            if (editMode)
            {
                FillData();
            }
        }
        private void LoadLists()
        {
            cmbPickup.DataSource =
                pickupRepository.GetAll();

            cmbPickup.DisplayMember =
                "Address";

            cmbPickup.ValueMember =
                "Id";

            cmbStatus.DataSource =
                statusRepository.GetAll();

            cmbStatus.DisplayMember =
                "Name";

            cmbStatus.ValueMember =
                "Id";
        }
        private void FillData()
        {
            txtNumber.Text =
                currentOrder.OrderNumber
                .ToString();

            txtClient.Text =
                currentOrder.ClientName;

            txtCode.Text =
                currentOrder.ReceiveCode;

            dtOrderDate.Value =
                currentOrder.OrderDate;

            dtDeliveryDate.Value =
                currentOrder.DeliveryDate;

            cmbPickup.SelectedValue =
                currentOrder.PickupPointId;

            cmbStatus.SelectedValue =
                currentOrder.StatusId;
        }
        private void btnSave_Click(
    object sender,
    EventArgs e)
        {
            Order order =
                currentOrder ??
                new Order();

            order.OrderNumber =
                Convert.ToInt32(
                    txtNumber.Text);

            order.ClientName =
                txtClient.Text;

            order.ReceiveCode =
                txtCode.Text;

            order.OrderDate =
                dtOrderDate.Value;

            order.DeliveryDate =
                dtDeliveryDate.Value;

            order.PickupPointId =
                Convert.ToInt32(
                    cmbPickup.SelectedValue);

            order.StatusId =
                Convert.ToInt32(
                    cmbStatus.SelectedValue);

            if (editMode)
            {
                repository.Update(
                    order);
            }
            else
            {
                repository.Add(
                    order);
            }

            DialogResult =
                DialogResult.OK;

            Close();
        }
        private void btnCancel_Click(
    object sender,
    EventArgs e)
        {
            Close();
        }
    }
}