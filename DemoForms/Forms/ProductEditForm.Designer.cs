namespace DemoForms.Forms
{
    partial class ProductEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblStock;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSupplier;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;

        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtStock;

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtImage;

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbSupplier;

        private System.Windows.Forms.PictureBox pictureProduct;

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblArticle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();

            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();

            this.lblCategory = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();

            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();

            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();

            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();

            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();

            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();

            this.pictureProduct = new System.Windows.Forms.PictureBox();

            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.pictureProduct))
                .BeginInit();

            this.SuspendLayout();

            // Title

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Calibri",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(
                    20,
                    15);

            this.lblTitle.Text =
                "Товар";

            // Article

            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(20, 70);
            this.lblArticle.Text = "Артикул";

            this.txtArticle.Location = new System.Drawing.Point(20, 95);
            this.txtArticle.Size = new System.Drawing.Size(250, 27);

            // Name

            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 135);
            this.lblName.Text = "Наименование";

            this.txtName.Location = new System.Drawing.Point(20, 160);
            this.txtName.Size = new System.Drawing.Size(420, 27);

            // Unit

            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(20, 200);
            this.lblUnit.Text = "Ед. измерения";

            this.txtUnit.Location = new System.Drawing.Point(20, 225);
            this.txtUnit.Size = new System.Drawing.Size(180, 27);

            // Price

            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 265);
            this.lblPrice.Text = "Цена";

            this.txtPrice.Location = new System.Drawing.Point(20, 290);
            this.txtPrice.Size = new System.Drawing.Size(120, 27);

            // Discount

            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(170, 265);
            this.lblDiscount.Text = "Скидка";

            this.txtDiscount.Location = new System.Drawing.Point(170, 290);
            this.txtDiscount.Size = new System.Drawing.Size(120, 27);

            // Stock

            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(320, 265);
            this.lblStock.Text = "Количество";

            this.txtStock.Location = new System.Drawing.Point(320, 290);
            this.txtStock.Size = new System.Drawing.Size(120, 27);

            // Category

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 330);
            this.lblCategory.Text = "Категория";

            this.cmbCategory.Location = new System.Drawing.Point(20, 355);
            this.cmbCategory.Size = new System.Drawing.Size(300, 28);

            // Manufacturer

            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(20, 395);
            this.lblManufacturer.Text = "Производитель";

            this.cmbManufacturer.Location = new System.Drawing.Point(20, 420);
            this.cmbManufacturer.Size = new System.Drawing.Size(300, 28);

            // Supplier

            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(20, 460);
            this.lblSupplier.Text = "Поставщик";

            this.cmbSupplier.Location = new System.Drawing.Point(20, 485);
            this.cmbSupplier.Size = new System.Drawing.Size(300, 28);

            // Description

            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 525);
            this.lblDescription.Text = "Описание";

            this.txtDescription.Location =
                new System.Drawing.Point(
                    20,
                    550);

            this.txtDescription.Multiline = true;

            this.txtDescription.Size =
                new System.Drawing.Size(
                    450,
                    120);

            // Image

            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(20, 690);
            this.lblImage.Text = "Изображение";

            this.txtImage.Location = new System.Drawing.Point(20, 715);
            this.txtImage.Size = new System.Drawing.Size(250, 27);

            // Browse

            this.btnBrowse.Location =
                new System.Drawing.Point(
                    280,
                    712);

            this.btnBrowse.Size =
                new System.Drawing.Size(
                    120,
                    35);

            this.btnBrowse.Text =
                "Обзор";

            this.btnBrowse.Click +=
                new System.EventHandler(
                    this.btnBrowse_Click);

            // Picture

            this.pictureProduct.Location =
                new System.Drawing.Point(
                    520,
                    80);

            this.pictureProduct.Size =
                new System.Drawing.Size(
                    280,
                    280);

            this.pictureProduct.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.pictureProduct.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            // Save

            this.btnSave.Location =
                new System.Drawing.Point(
                    520,
                    710);

            this.btnSave.Size =
                new System.Drawing.Size(
                    120,
                    40);

            this.btnSave.Text =
                "Сохранить";

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // Cancel

            this.btnCancel.Location =
                new System.Drawing.Point(
                    680,
                    710);

            this.btnCancel.Size =
                new System.Drawing.Size(
                    120,
                    40);

            this.btnCancel.Text =
                "Отмена";

            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // Controls

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.txtArticle);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);

            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtUnit);

            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);

            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);

            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);

            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.cmbManufacturer);

            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbSupplier);

            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);

            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtImage);

            this.Controls.Add(this.btnBrowse);

            this.Controls.Add(this.pictureProduct);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ClientSize =
                new System.Drawing.Size(
                    850,
                    780);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Товар";

            this.Load +=
                new System.EventHandler(
                    this.ProductEditForm_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.pictureProduct))
                .EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}