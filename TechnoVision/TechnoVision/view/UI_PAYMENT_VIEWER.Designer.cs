namespace TechnoVision.view
{
    partial class UI_PAYMENT_VIEWER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_PAYMENT_VIEWER));
            this.BtnNewPayment = new MetroFramework.Controls.MetroButton();
            this.BtnPrintReceipt = new MetroFramework.Controls.MetroButton();
            this.GridPayments = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPayment = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.receiptTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.receiptTableAdapter();
            this.LblCustomer = new MetroFramework.Controls.MetroLabel();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            this.LblDue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtReceiptSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewPayment
            // 
            this.BtnNewPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNewPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNewPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNewPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewPayment.Highlight = true;
            this.BtnNewPayment.Location = new System.Drawing.Point(850, 3);
            this.BtnNewPayment.Name = "BtnNewPayment";
            this.BtnNewPayment.Size = new System.Drawing.Size(276, 52);
            this.BtnNewPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnNewPayment.TabIndex = 4;
            this.BtnNewPayment.Text = "Make New Payment";
            this.BtnNewPayment.UseCustomBackColor = true;
            this.BtnNewPayment.UseCustomForeColor = true;
            this.BtnNewPayment.UseSelectable = true;
            this.BtnNewPayment.UseStyleColors = true;
            this.BtnNewPayment.Click += new System.EventHandler(this.BtnNewPayment_Click);
            // 
            // BtnPrintReceipt
            // 
            this.BtnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrintReceipt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnPrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrintReceipt.Highlight = true;
            this.BtnPrintReceipt.Location = new System.Drawing.Point(1132, 3);
            this.BtnPrintReceipt.Name = "BtnPrintReceipt";
            this.BtnPrintReceipt.Size = new System.Drawing.Size(279, 52);
            this.BtnPrintReceipt.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnPrintReceipt.TabIndex = 5;
            this.BtnPrintReceipt.Text = "Print Receipt";
            this.BtnPrintReceipt.UseCustomBackColor = true;
            this.BtnPrintReceipt.UseCustomForeColor = true;
            this.BtnPrintReceipt.UseSelectable = true;
            this.BtnPrintReceipt.UseStyleColors = true;
            this.BtnPrintReceipt.Click += new System.EventHandler(this.BtnPrintReceipt_Click);
            // 
            // GridPayments
            // 
            this.GridPayments.AllowUserToAddRows = false;
            this.GridPayments.AllowUserToDeleteRows = false;
            this.GridPayments.AllowUserToResizeRows = false;
            this.GridPayments.AutoGenerateColumns = false;
            this.GridPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.receiptNumberDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPayments.EnableHeadersVisualStyles = false;
            this.GridPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayments.Location = new System.Drawing.Point(24, 77);
            this.GridPayments.Name = "GridPayments";
            this.GridPayments.ReadOnly = true;
            this.GridPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayments.RowTemplate.Height = 24;
            this.GridPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayments.Size = new System.Drawing.Size(1081, 524);
            this.GridPayments.Style = MetroFramework.MetroColorStyle.Green;
            this.GridPayments.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptNumberDataGridViewTextBoxColumn
            // 
            this.receiptNumberDataGridViewTextBoxColumn.DataPropertyName = "ReceiptNumber";
            this.receiptNumberDataGridViewTextBoxColumn.HeaderText = "ReceiptNumber";
            this.receiptNumberDataGridViewTextBoxColumn.Name = "receiptNumberDataGridViewTextBoxColumn";
            this.receiptNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GridPayment
            // 
            this.GridPayment.AllowUserToAddRows = false;
            this.GridPayment.AllowUserToDeleteRows = false;
            this.GridPayment.AllowUserToOrderColumns = true;
            this.GridPayment.AllowUserToResizeRows = false;
            this.GridPayment.AutoGenerateColumns = false;
            this.GridPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.orderNumberDataGridViewTextBoxColumn1,
            this.receiptNumberDataGridViewTextBoxColumn1,
            this.receiptDateDataGridViewTextBoxColumn1,
            this.orderTypeDataGridViewTextBoxColumn1,
            this.paymentAmountDataGridViewTextBoxColumn1,
            this.branchDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.CustId});
            this.GridPayment.DataSource = this.receiptBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPayment.EnableHeadersVisualStyles = false;
            this.GridPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayment.Location = new System.Drawing.Point(3, 97);
            this.GridPayment.Name = "GridPayment";
            this.GridPayment.ReadOnly = true;
            this.GridPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayment.RowTemplate.Height = 24;
            this.GridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayment.Size = new System.Drawing.Size(1414, 468);
            this.GridPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.GridPayment.TabIndex = 2;
            this.GridPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPayment_CellContentClick);
            this.GridPayment.Click += new System.EventHandler(this.GridPayment_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderNumberDataGridViewTextBoxColumn1
            // 
            this.orderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn1.Name = "orderNumberDataGridViewTextBoxColumn1";
            this.orderNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // receiptNumberDataGridViewTextBoxColumn1
            // 
            this.receiptNumberDataGridViewTextBoxColumn1.DataPropertyName = "ReceiptNumber";
            this.receiptNumberDataGridViewTextBoxColumn1.HeaderText = "Receipt Number";
            this.receiptNumberDataGridViewTextBoxColumn1.Name = "receiptNumberDataGridViewTextBoxColumn1";
            this.receiptNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // receiptDateDataGridViewTextBoxColumn1
            // 
            this.receiptDateDataGridViewTextBoxColumn1.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn1.HeaderText = "Receipt Date";
            this.receiptDateDataGridViewTextBoxColumn1.Name = "receiptDateDataGridViewTextBoxColumn1";
            this.receiptDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderTypeDataGridViewTextBoxColumn1
            // 
            this.orderTypeDataGridViewTextBoxColumn1.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn1.HeaderText = "Order Type";
            this.orderTypeDataGridViewTextBoxColumn1.Name = "orderTypeDataGridViewTextBoxColumn1";
            this.orderTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paymentAmountDataGridViewTextBoxColumn1
            // 
            this.paymentAmountDataGridViewTextBoxColumn1.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn1.HeaderText = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn1.Name = "paymentAmountDataGridViewTextBoxColumn1";
            this.paymentAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn1
            // 
            this.branchDataGridViewTextBoxColumn1.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn1.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn1.Name = "branchDataGridViewTextBoxColumn1";
            this.branchDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "Customer ID";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCustomer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblCustomer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblCustomer.Location = new System.Drawing.Point(220, 0);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(429, 35);
            this.LblCustomer.TabIndex = 10;
            this.LblCustomer.Text = "Customer Name";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblTotal.Location = new System.Drawing.Point(1240, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(171, 35);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total";
            // 
            // LblDue
            // 
            this.LblDue.AutoSize = true;
            this.LblDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblDue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDue.Location = new System.Drawing.Point(854, 0);
            this.LblDue.Name = "LblDue";
            this.LblDue.Size = new System.Drawing.Size(235, 35);
            this.LblDue.TabIndex = 10;
            this.LblDue.Text = "Due Amount";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(59, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 35);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Customer Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(722, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 35);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Due Amount";
            // 
            // TxtReceiptSearch
            // 
            // 
            // 
            // 
            this.TxtReceiptSearch.CustomButton.Image = null;
            this.TxtReceiptSearch.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.TxtReceiptSearch.CustomButton.Name = "";
            this.TxtReceiptSearch.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.TxtReceiptSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtReceiptSearch.CustomButton.TabIndex = 1;
            this.TxtReceiptSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtReceiptSearch.CustomButton.UseSelectable = true;
            this.TxtReceiptSearch.CustomButton.Visible = false;
            this.TxtReceiptSearch.DisplayIcon = true;
            this.TxtReceiptSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtReceiptSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtReceiptSearch.Icon = global::TechnoVision.Properties.Resources.search;
            this.TxtReceiptSearch.Lines = new string[0];
            this.TxtReceiptSearch.Location = new System.Drawing.Point(992, 3);
            this.TxtReceiptSearch.MaxLength = 32767;
            this.TxtReceiptSearch.Name = "TxtReceiptSearch";
            this.TxtReceiptSearch.PasswordChar = '\0';
            this.TxtReceiptSearch.PromptText = "Search by Order Number and Receipt No...";
            this.TxtReceiptSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtReceiptSearch.SelectedText = "";
            this.TxtReceiptSearch.SelectionLength = 0;
            this.TxtReceiptSearch.SelectionStart = 0;
            this.TxtReceiptSearch.ShortcutsEnabled = true;
            this.TxtReceiptSearch.Size = new System.Drawing.Size(419, 41);
            this.TxtReceiptSearch.TabIndex = 1;
            this.TxtReceiptSearch.UseSelectable = true;
            this.TxtReceiptSearch.WaterMark = "Search by Order Number and Receipt No...";
            this.TxtReceiptSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtReceiptSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtReceiptSearch.TextChanged += new System.EventHandler(this.TxtReceiptSearch_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(1179, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 35);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Total";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridPayment, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.386076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.487342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1420, 632);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtnNewPayment, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnPrintReceipt, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 571);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1414, 58);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.40357F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.80715F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.08914F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.10824F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.26905F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.32286F));
            this.tableLayoutPanel3.Controls.Add(this.LblTotal, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblCustomer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblDue, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel3, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1414, 35);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.TxtReceiptSearch, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1414, 47);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // UI_PAYMENT_VIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI_PAYMENT_VIEWER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payment Viewer";
            this.Load += new System.EventHandler(this.UI_PAYMENT_VIEWER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnNewPayment;
        private MetroFramework.Controls.MetroButton BtnPrintReceipt;
        private MetroFramework.Controls.MetroGrid GridPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid GridPayment;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private technovisionDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private MetroFramework.Controls.MetroLabel LblCustomer;
        private MetroFramework.Controls.MetroLabel LblTotal;
        private MetroFramework.Controls.MetroLabel LblDue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private MetroFramework.Controls.MetroTextBox TxtReceiptSearch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
