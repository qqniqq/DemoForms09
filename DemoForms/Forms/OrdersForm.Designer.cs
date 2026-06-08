namespace DemoForms.Forms
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.DataGridView dgvOrders;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle =
                new System.Windows.Forms.Label();

            this.dgvOrders =
                new System.Windows.Forms.DataGridView();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.btnEdit =
                new System.Windows.Forms.Button();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.btnClose =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvOrders))
                .BeginInit();

            this.SuspendLayout();

            // lblTitle

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
                "Заказы";

            // dgvOrders

            this.dgvOrders.Location =
                new System.Drawing.Point(
                    20,
                    60);

            this.dgvOrders.Size =
                new System.Drawing.Size(
                    1160,
                    500);

            this.dgvOrders.AllowUserToAddRows =
                false;

            this.dgvOrders.AllowUserToDeleteRows =
                false;

            this.dgvOrders.ReadOnly =
                true;

            this.dgvOrders.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvOrders.MultiSelect =
                false;

            this.dgvOrders.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvOrders.Columns.Add(
                "colId",
                "ID");

            this.dgvOrders.Columns.Add(
                "colNumber",
                "Номер");

            this.dgvOrders.Columns.Add(
                "colClient",
                "Клиент");

            this.dgvOrders.Columns.Add(
                "colOrderDate",
                "Дата заказа");

            this.dgvOrders.Columns.Add(
                "colDeliveryDate",
                "Дата выдачи");

            this.dgvOrders.Columns.Add(
                "colPickup",
                "Пункт выдачи");

            this.dgvOrders.Columns.Add(
                "colCode",
                "Код");

            this.dgvOrders.Columns.Add(
                "colStatus",
                "Статус");

            // btnAdd

            this.btnAdd.Location =
                new System.Drawing.Point(
                    20,
                    580);

            this.btnAdd.Size =
                new System.Drawing.Size(
                    140,
                    40);

            this.btnAdd.Text =
                "Добавить";

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // btnEdit

            this.btnEdit.Location =
                new System.Drawing.Point(
                    180,
                    580);

            this.btnEdit.Size =
                new System.Drawing.Size(
                    140,
                    40);

            this.btnEdit.Text =
                "Изменить";

            this.btnEdit.Click +=
                new System.EventHandler(
                    this.btnEdit_Click);

            // btnDelete

            this.btnDelete.Location =
                new System.Drawing.Point(
                    340,
                    580);

            this.btnDelete.Size =
                new System.Drawing.Size(
                    140,
                    40);

            this.btnDelete.Text =
                "Удалить";

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // btnClose

            this.btnClose.Location =
                new System.Drawing.Point(
                    1040,
                    580);

            this.btnClose.Size =
                new System.Drawing.Size(
                    140,
                    40);

            this.btnClose.Text =
                "Закрыть";

            this.btnClose.Click +=
                new System.EventHandler(
                    this.btnClose_Click);

            this.Controls.Add(
                this.lblTitle);

            this.Controls.Add(
                this.dgvOrders);

            this.Controls.Add(
                this.btnAdd);

            this.Controls.Add(
                this.btnEdit);

            this.Controls.Add(
                this.btnDelete);

            this.Controls.Add(
                this.btnClose);

            this.ClientSize =
                new System.Drawing.Size(
                    1200,
                    650);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Заказы";

            this.Load +=
                new System.EventHandler(
                    this.OrdersForm_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvOrders))
                .EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }
    }
}