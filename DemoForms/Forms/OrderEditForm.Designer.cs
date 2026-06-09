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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEditForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPickup = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Заказ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(20, 70);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Номер заказа";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(20, 135);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(54, 16);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Клиент";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 200);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(105, 16);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Код получения";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(20, 265);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(89, 16);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "Дата заказа";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(280, 265);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(91, 16);
            this.lblDeliveryDate.TabIndex = 9;
            this.lblDeliveryDate.Text = "Дата выдачи";
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Location = new System.Drawing.Point(20, 335);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(99, 16);
            this.lblPickup.TabIndex = 11;
            this.lblPickup.Text = "Пункт выдачи";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 405);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Статус";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 95);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(220, 22);
            this.txtNumber.TabIndex = 2;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(20, 160);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(420, 22);
            this.txtClient.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(20, 225);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(220, 22);
            this.txtCode.TabIndex = 6;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(20, 290);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(220, 22);
            this.dtOrderDate.TabIndex = 8;
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Location = new System.Drawing.Point(280, 290);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(220, 22);
            this.dtDeliveryDate.TabIndex = 10;
            // 
            // cmbPickup
            // 
            this.cmbPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPickup.Location = new System.Drawing.Point(20, 360);
            this.cmbPickup.Name = "cmbPickup";
            this.cmbPickup.Size = new System.Drawing.Size(420, 24);
            this.cmbPickup.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(20, 430);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 24);
            this.cmbStatus.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(80, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrderEditForm
            // 
            this.ClientSize = new System.Drawing.Size(560, 620);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}