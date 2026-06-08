namespace DemoForms.Forms
{
    partial class OrderEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblCode;

        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblDeliveryDate;

        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtCode;

        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;

        private System.Windows.Forms.ComboBox cmbPickup;
        private System.Windows.Forms.ComboBox cmbStatus;

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
            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblNumber =
                new System.Windows.Forms.Label();

            this.lblClient =
                new System.Windows.Forms.Label();

            this.lblCode =
                new System.Windows.Forms.Label();

            this.lblOrderDate =
                new System.Windows.Forms.Label();

            this.lblDeliveryDate =
                new System.Windows.Forms.Label();

            this.lblPickup =
                new System.Windows.Forms.Label();

            this.lblStatus =
                new System.Windows.Forms.Label();

            this.txtNumber =
                new System.Windows.Forms.TextBox();

            this.txtClient =
                new System.Windows.Forms.TextBox();

            this.txtCode =
                new System.Windows.Forms.TextBox();

            this.dtOrderDate =
                new System.Windows.Forms.DateTimePicker();

            this.dtDeliveryDate =
                new System.Windows.Forms.DateTimePicker();

            this.cmbPickup =
                new System.Windows.Forms.ComboBox();

            this.cmbStatus =
                new System.Windows.Forms.ComboBox();

            this.btnSave =
                new System.Windows.Forms.Button();

            this.btnCancel =
                new System.Windows.Forms.Button();

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
                "Заказ";

            // lblNumber

            this.lblNumber.AutoSize = true;

            this.lblNumber.Location =
                new System.Drawing.Point(
                    20,
                    70);

            this.lblNumber.Text =
                "Номер заказа";

            // txtNumber

            this.txtNumber.Location =
                new System.Drawing.Point(
                    20,
                    95);

            this.txtNumber.Size =
                new System.Drawing.Size(
                    220,
                    27);

            // lblClient

            this.lblClient.AutoSize = true;

            this.lblClient.Location =
                new System.Drawing.Point(
                    20,
                    135);

            this.lblClient.Text =
                "Клиент";

            // txtClient

            this.txtClient.Location =
                new System.Drawing.Point(
                    20,
                    160);

            this.txtClient.Size =
                new System.Drawing.Size(
                    420,
                    27);

            // lblCode

            this.lblCode.AutoSize = true;

            this.lblCode.Location =
                new System.Drawing.Point(
                    20,
                    200);

            this.lblCode.Text =
                "Код получения";

            // txtCode

            this.txtCode.Location =
                new System.Drawing.Point(
                    20,
                    225);

            this.txtCode.Size =
                new System.Drawing.Size(
                    220,
                    27);

            // lblOrderDate

            this.lblOrderDate.AutoSize = true;

            this.lblOrderDate.Location =
                new System.Drawing.Point(
                    20,
                    265);

            this.lblOrderDate.Text =
                "Дата заказа";

            // dtOrderDate

            this.dtOrderDate.Location =
                new System.Drawing.Point(
                    20,
                    290);

            this.dtOrderDate.Size =
                new System.Drawing.Size(
                    220,
                    27);

            // lblDeliveryDate

            this.lblDeliveryDate.AutoSize = true;

            this.lblDeliveryDate.Location =
                new System.Drawing.Point(
                    280,
                    265);

            this.lblDeliveryDate.Text =
                "Дата выдачи";

            // dtDeliveryDate

            this.dtDeliveryDate.Location =
                new System.Drawing.Point(
                    280,
                    290);

            this.dtDeliveryDate.Size =
                new System.Drawing.Size(
                    220,
                    27);

            // lblPickup

            this.lblPickup.AutoSize = true;

            this.lblPickup.Location =
                new System.Drawing.Point(
                    20,
                    335);

            this.lblPickup.Text =
                "Пункт выдачи";

            // cmbPickup

            this.cmbPickup.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbPickup.Location =
                new System.Drawing.Point(
                    20,
                    360);

            this.cmbPickup.Size =
                new System.Drawing.Size(
                    420,
                    28);

            // lblStatus

            this.lblStatus.AutoSize = true;

            this.lblStatus.Location =
                new System.Drawing.Point(
                    20,
                    405);

            this.lblStatus.Text =
                "Статус";

            // cmbStatus

            this.cmbStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbStatus.Location =
                new System.Drawing.Point(
                    20,
                    430);

            this.cmbStatus.Size =
                new System.Drawing.Size(
                    250,
                    28);

            // btnSave

            this.btnSave.Location =
                new System.Drawing.Point(
                    80,
                    520);

            this.btnSave.Size =
                new System.Drawing.Size(
                    150,
                    40);

            this.btnSave.Text =
                "Сохранить";

            this.btnSave.Click +=
                new System.EventHandler(
                    this.btnSave_Click);

            // btnCancel

            this.btnCancel.Location =
                new System.Drawing.Point(
                    280,
                    520);

            this.btnCancel.Size =
                new System.Drawing.Size(
                    150,
                    40);

            this.btnCancel.Text =
                "Отмена";

            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // Controls

            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);

            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtClient);

            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);

            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.dtOrderDate);

            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.dtDeliveryDate);

            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.cmbPickup);

            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ClientSize =
                new System.Drawing.Size(
                    560,
                    620);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Заказ";

            this.Load +=
                new System.EventHandler(
                    this.OrderEditForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}