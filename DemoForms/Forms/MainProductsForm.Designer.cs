namespace DemoForms.Forms
{
    partial class MainProductsForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCount;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.ComboBox cmbSort;

        private System.Windows.Forms.Button btnOrders;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelTop;

        private System.Windows.Forms.DataGridView dgvProducts;
        protected override void Dispose(
    bool disposing)
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

            this.panelTop =
                new System.Windows.Forms.Panel();

            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblUser =
                new System.Windows.Forms.Label();

            this.lblCount =
                new System.Windows.Forms.Label();

            this.txtSearch =
                new System.Windows.Forms.TextBox();

            this.cmbSort =
                new System.Windows.Forms.ComboBox();

            this.btnOrders =
                new System.Windows.Forms.Button();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.btnEdit =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnLogout =
                new System.Windows.Forms.Button();

            this.dgvProducts =
                new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts))
                .BeginInit();

            this.SuspendLayout();
            this.panelTop.BackColor =
    System.Drawing.Color.Goldenrod;

            this.panelTop.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.panelTop.Height = 80;
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Calibri",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.Location =
                new System.Drawing.Point(
                    20,
                    20);

            this.lblTitle.Text =
                "Каталог товаров";
            this.lblUser.AutoSize = true;

            this.lblUser.Font =
                new System.Drawing.Font(
                    "Calibri",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblUser.Location =
                new System.Drawing.Point(
                    950,
                    25);

            this.lblUser.Text =
                "Пользователь";
            this.txtSearch.Location =
    new System.Drawing.Point(
        20,
        100);

            this.txtSearch.Size =
                new System.Drawing.Size(
                    300,
                    27);

            this.txtSearch.TextChanged +=
                new System.EventHandler(
                    this.txtSearch_TextChanged);
            this.cmbSort.DropDownStyle =
    System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbSort.Items.AddRange(
                new object[]
                {
        "Цена ↑",
        "Цена ↓",
        "Скидка ↑",
        "Скидка ↓"
                });

            this.cmbSort.Location =
                new System.Drawing.Point(
                    350,
                    100);

            this.cmbSort.Size =
                new System.Drawing.Size(
                    180,
                    28);

            this.cmbSort.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbSort_SelectedIndexChanged);

            this.btnOrders.Location =
    new System.Drawing.Point(
        560,
        95);

            this.btnOrders.Size =
                new System.Drawing.Size(
                    130,
                    35);

            this.btnOrders.Text =
                "Заказы";

            this.btnOrders.Click +=
                new System.EventHandler(
                    this.btnOrders_Click);
            this.btnAdd.Location =
    new System.Drawing.Point(
        710,
        95);

            this.btnAdd.Size =
                new System.Drawing.Size(
                    120,
                    35);

            this.btnAdd.Text =
                "Добавить";

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);
            this.btnEdit.Location =
    new System.Drawing.Point(
        850,
        95);

            this.btnEdit.Size =
                new System.Drawing.Size(
                    120,
                    35);

            this.btnEdit.Text =
                "Изменить";

            this.btnEdit.Click +=
                new System.EventHandler(
                    this.btnEdit_Click);
            this.btnDelete.Location =
    new System.Drawing.Point(
        990,
        95);

            this.btnDelete.Size =
                new System.Drawing.Size(
                    120,
                    35);

            this.btnDelete.Text =
                "Удалить";

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);
            this.btnLogout.Location =
    new System.Drawing.Point(
        1130,
        95);

            this.btnLogout.Size =
                new System.Drawing.Size(
                    120,
                    35);

            this.btnLogout.Text =
                "Выход";

            this.btnLogout.Click +=
                new System.EventHandler(
                    this.btnLogout_Click);
            this.lblCount.AutoSize = true;

            this.lblCount.Font =
                new System.Drawing.Font(
                    "Calibri",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.lblCount.Location =
                new System.Drawing.Point(
                    20,
                    140);

            this.lblCount.Text =
                "Товаров: 0";
            this.dgvProducts.Location =
    new System.Drawing.Point(
        20,
        180);

            this.dgvProducts.Size =
                new System.Drawing.Size(
                    1230,
                    520);

            this.dgvProducts.AllowUserToAddRows =
                false;

            this.dgvProducts.AllowUserToDeleteRows =
                false;

            this.dgvProducts.ReadOnly =
                true;

            this.dgvProducts.MultiSelect =
                false;

            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvProducts.RowTemplate.Height =
                80;

            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.CellDoubleClick +=

    new System.Windows.Forms.DataGridViewCellEventHandler(
        this.dgvProducts_CellDoubleClick);

            System.Windows.Forms.DataGridViewImageColumn
    colImage =
    new System.Windows.Forms.DataGridViewImageColumn();


            colImage.Name =
                "colImage";

            colImage.HeaderText =
                "Фото";

            colImage.ImageLayout =
                System.Windows.Forms.DataGridViewImageCellLayout.Zoom;

            colImage.Width = 80;
            this.dgvProducts.Columns.Add(
    "colId",
    "ID");

            this.dgvProducts.Columns["colId"]
                .Visible = false;
            this.dgvProducts.Columns.Add(
                colImage);
            this.dgvProducts.Columns.Add(
    "colName",
    "Наименование");

            this.dgvProducts.Columns.Add(
                "colCategory",
                "Категория");

            this.dgvProducts.Columns.Add(
                "colManufacturer",
                "Производитель");

            this.dgvProducts.Columns.Add(
                "colSupplier",
                "Поставщик");

            this.dgvProducts.Columns.Add(
                "colPrice",
                "Цена");

            this.dgvProducts.Columns.Add(
                "colDiscount",
                "Скидка");

            this.dgvProducts.Columns.Add(
                "colFinalPrice",
                "Цена со скидкой");

            this.dgvProducts.Columns.Add(
                "colStock",
                "Остаток");
            this.panelTop.Controls.Add(
    this.lblTitle);

            this.panelTop.Controls.Add(
                this.lblUser);
            this.Controls.Add(
    this.panelTop);

            this.Controls.Add(
                this.txtSearch);

            this.Controls.Add(
                this.cmbSort);

            this.Controls.Add(
                this.btnOrders);

            this.Controls.Add(
                this.btnAdd);

            this.Controls.Add(
                this.btnEdit);

            this.Controls.Add(
                this.btnDelete);

            this.Controls.Add(
                this.btnLogout);

            this.Controls.Add(
                this.lblCount);

            this.Controls.Add(
                this.dgvProducts);
            this.AutoScaleDimensions =
    new System.Drawing.SizeF(
        8F,
        20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.White;

            this.ClientSize =
                new System.Drawing.Size(
                    1280,
                    730);

            this.Font =
                new System.Drawing.Font(
                    "Calibri",
                    10F);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Каталог товаров";
            this.Load +=
    new System.EventHandler(
        this.MainProductsForm_Load);

            ((System.ComponentModel.ISupportInitialize)
    (this.dgvProducts))
    .EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }
    }
}