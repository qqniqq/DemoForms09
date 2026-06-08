using DemoLib.Models;
using DemoLib.Repositories;

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoForms.Forms
{
    public partial class ProductEditForm : Form
    {
        private readonly ProductRepository repository;

        private readonly CategoryRepository categoryRepository;

        private readonly ManufacturerRepository manufacturerRepository;

        private readonly SupplierRepository supplierRepository;

        private Product currentProduct;

        private bool editMode;

        public ProductEditForm()
        {
            InitializeComponent();

            repository =
                new ProductRepository();

            categoryRepository =
                new CategoryRepository();

            manufacturerRepository =
                new ManufacturerRepository();

            supplierRepository =
                new SupplierRepository();

            editMode = false;
        }

        public ProductEditForm(
            Product product)
        {
            InitializeComponent();

            repository =
                new ProductRepository();

            categoryRepository =
                new CategoryRepository();

            manufacturerRepository =
                new ManufacturerRepository();

            supplierRepository =
                new SupplierRepository();

            currentProduct =
                product;

            editMode = true;
        }

        private void ProductEditForm_Load(
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
            cmbCategory.DataSource =
                categoryRepository.GetAll();

            cmbCategory.DisplayMember =
                "Name";

            cmbCategory.ValueMember =
                "Id";

            cmbManufacturer.DataSource =
                manufacturerRepository.GetAll();

            cmbManufacturer.DisplayMember =
                "Name";

            cmbManufacturer.ValueMember =
                "Id";

            cmbSupplier.DataSource =
                supplierRepository.GetAll();

            cmbSupplier.DisplayMember =
                "Name";

            cmbSupplier.ValueMember =
                "Id";
        }
        private void FillData()
        {
            txtArticle.Text =
                currentProduct.Article;

            txtName.Text =
                currentProduct.Name;

            txtUnit.Text =
                currentProduct.Unit;

            txtPrice.Text =
                currentProduct.Price.ToString();

            txtDiscount.Text =
                currentProduct.Discount.ToString();

            txtStock.Text =
                currentProduct.StockQuantity.ToString();

            txtDescription.Text =
                currentProduct.Description;

            txtImage.Text =
                currentProduct.ImagePath;

            cmbCategory.SelectedValue =
                currentProduct.CategoryId;

            cmbManufacturer.SelectedValue =
                currentProduct.ManufacturerId;

            cmbSupplier.SelectedValue =
                currentProduct.SupplierId;

            LoadImage();
        }
        private void LoadImage()
        {
            string path =
                Path.Combine(
                    Application.StartupPath,
                    "Images",
                    txtImage.Text);

            if (File.Exists(path))
            {
                pictureProduct.Image =
                    Image.FromFile(path);
            }
        }
        //выбор изображения
        private void btnBrowse_Click(
    object sender,
    EventArgs e)
        {
            OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Filter =
                "Изображения|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog()
                != DialogResult.OK)
            {
                return;
            }

            pictureProduct.Image =
                Image.FromFile(
                    dialog.FileName);

            txtImage.Text =
                Path.GetFileName(
                    dialog.FileName);
        }
        private void btnSave_Click(
    object sender,
    EventArgs e)
        {
            Product product =
                currentProduct ??
                new Product();

            product.Article =
                txtArticle.Text;

            product.Name =
                txtName.Text;

            product.Unit =
                txtUnit.Text;

            product.Price =
                Convert.ToDecimal(
                    txtPrice.Text);

            product.Discount =
                Convert.ToDecimal(
                    txtDiscount.Text);

            product.StockQuantity =
                Convert.ToInt32(
                    txtStock.Text);

            product.Description =
                txtDescription.Text;

            product.ImagePath =
                txtImage.Text;

            product.CategoryId =
                Convert.ToInt32(
                    cmbCategory.SelectedValue);

            product.ManufacturerId =
                Convert.ToInt32(
                    cmbManufacturer.SelectedValue);

            product.SupplierId =
                Convert.ToInt32(
                    cmbSupplier.SelectedValue);

            if (editMode)
            {
                repository.Update(product);
            }
            else
            {
                repository.Add(product);
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