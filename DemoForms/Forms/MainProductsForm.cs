using DemoLib.Enums;
using DemoLib.Helpers;
using DemoLib.Models;
using DemoLib.Repositories;
using DemoLib.Services;

using DemoForms.Helpers;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DemoForms.Forms
{
    public partial class MainProductsForm : Form
    {
        private readonly ProductService productService;

        private List<Product> products;

        public MainProductsForm()
        {
            InitializeComponent();

            productService =
                new ProductService();
        }

        private void MainProductsForm_Load(
            object sender,
            EventArgs e)
        {
            ConfigureInterface();

            LoadProducts();
        }

        private void ConfigureInterface()
        {
            if (SessionManager.CurrentUser == null)
            {
                lblUser.Text =
       SessionManager.CurrentUser.FullName
       + " ("
       + SessionManager.CurrentUser.Role.Name
       + ")";

                btnOrders.Visible = false;

                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;

                return;
            }

            lblUser.Text =
                SessionManager.CurrentUser.FullName;

            UserRole role =
                (UserRole)
                SessionManager.CurrentUser.RoleId;

            switch (role)
            {
                case UserRole.Client:

                    btnOrders.Visible = false;

                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;

                    break;

                case UserRole.Manager:

                    btnOrders.Visible = true;

                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;

                    break;

                case UserRole.Admin:

                    btnOrders.Visible = true;

                    btnAdd.Visible = true;
                    btnEdit.Visible = true;
                    btnDelete.Visible = true;

                    break;
            }
        }

        private void LoadProducts()
        {
            products =
                productService.GetProducts();

            FillGrid(products);
        }

        private void FillGrid(
            List<Product> source)
        {
            dgvProducts.Rows.Clear();

            foreach (Product product in source)
            {
                decimal finalPrice =
                    ProductHelper.GetFinalPrice(
                        product.Price,
                        product.Discount);

                int row =
                    dgvProducts.Rows.Add();
                dgvProducts.Rows[row]
    .Cells["colId"]
    .Value =
    product.Id;
                dgvProducts.Rows[row]
                    .Cells["colImage"]
                    .Value =
                    ImageHelper.GetProductImage(
                        product.ImagePath);

                dgvProducts.Rows[row]
                    .Cells["colName"]
                    .Value =
                    product.Name;

                dgvProducts.Rows[row]
                    .Cells["colCategory"]
                    .Value =
                    product.Category.Name;

                dgvProducts.Rows[row]
                    .Cells["colManufacturer"]
                    .Value =
                    product.Manufacturer.Name;

                dgvProducts.Rows[row]
                    .Cells["colSupplier"]
                    .Value =
                    product.Supplier.Name;

                dgvProducts.Rows[row]
                    .Cells["colPrice"]
                    .Value =
                    product.Price.ToString("N2");

                dgvProducts.Rows[row]
                    .Cells["colDiscount"]
                    .Value =
                    product.Discount + "%";

                dgvProducts.Rows[row]
                .Cells["colFinalPrice"]
                .Value =
                finalPrice.ToString("N2");

                dgvProducts.Rows[row]
                    .Cells["colStock"]
                    .Value =
                    product.StockQuantity;

                if (product.Discount >= 15)
                {
                    dgvProducts.Rows[row]
                        .DefaultCellStyle.BackColor =
                        Color.LightGreen;
                }
                else if (product.Discount >= 5)
                {
                    dgvProducts.Rows[row]
                        .DefaultCellStyle.BackColor =
                        Color.LightYellow;
                }
                if (product.StockQuantity < 10)
                {
                    dgvProducts.Rows[row]
                        .DefaultCellStyle.ForeColor =
                        Color.Red;
                }

                if (product.StockQuantity == 0)
                {
                    dgvProducts.Rows[row]
                        .DefaultCellStyle.BackColor =
                        Color.LightGray;
                }
            }

            lblCount.Text =
                $"Товаров: {source.Count}";
        }

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string text =
                txtSearch.Text
                .Trim()
                .ToLower();

            if (string.IsNullOrWhiteSpace(text))
            {
                FillGrid(products);
                return;
            }

            FillGrid(
                products
                .Where(x =>
                    x.Name.ToLower()
                    .Contains(text))
                .ToList());
        }

        private void cmbSort_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            IEnumerable<Product> result =
                products;

            switch (cmbSort.Text)
            {
                case "Цена ↑":

                    result =
                        products
                        .OrderBy(
                            x => x.Price);

                    break;

                case "Цена ↓":

                    result =
                        products
                        .OrderByDescending(
                            x => x.Price);

                    break;

                case "Скидка ↑":

                    result =
                        products
                        .OrderBy(
                            x => x.Discount);

                    break;

                case "Скидка ↓":

                    result =
                        products
                        .OrderByDescending(
                            x => x.Discount);

                    break;
            }

            FillGrid(
                result.ToList());
        }

        private void btnOrders_Click(
            object sender,
            EventArgs e)
        {
            OrdersForm form =
                new OrdersForm();

            form.ShowDialog();
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            ProductEditForm form =
                new ProductEditForm();

            form.ShowDialog();

            LoadProducts();
        }

        private void btnEdit_Click(
     object sender,
     EventArgs e)
        {
            Product product =
                GetSelectedProduct();

            if (product == null)
            {
                MessageBox.Show(
                    "Выберите товар");

                return;
            }

            ProductEditForm form =
                new ProductEditForm(
                    product);

            form.ShowDialog();

            LoadProducts();
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            Product product =
                GetSelectedProduct();

            if (product == null)
            {
                MessageBox.Show(
                    "Выберите товар");

                return;
            }

            if (MessageBox.Show(
                "Удалить товар?",
                "Подтверждение",
                MessageBoxButtons.YesNo)
                != DialogResult.Yes)
            {
                return;
            }

            ProductRepository repository =
                new ProductRepository();

            repository.Delete(
                product.Id);

            LoadProducts();
        }

        private void btnLogout_Click(
      object sender,
      EventArgs e)
        {
            if (MessageBox.Show(
                "Выйти из системы?",
                "Подтверждение",
                MessageBoxButtons.YesNo)
                != DialogResult.Yes)
            {
                return;
            }

            Close();
        }
        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                return null;
            }

            int id =
                Convert.ToInt32(
                    dgvProducts.SelectedRows[0]
                    .Cells["colId"]
                    .Value);

            return products.Find(
                x => x.Id == id);
        }
        private void dgvProducts_CellDoubleClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (!btnEdit.Visible)
            {
                return;
            }

            btnEdit_Click(
                sender,
                EventArgs.Empty);
        }
    }

}