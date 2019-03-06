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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRefresh = new MetroFramework.Controls.MetroButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRefresh.Highlight = true;
            this.BtnRefresh.Location = new System.Drawing.Point(641, 626);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 45);
            this.BtnRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCustomBackColor = true;
            this.BtnRefresh.UseCustomForeColor = true;
            this.BtnRefresh.UseSelectable = true;
            this.BtnRefresh.UseStyleColors = true;
            // 
            // BtnNewPayment
            // 
            this.BtnNewPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNewPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNewPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewPayment.Highlight = true;
            this.BtnNewPayment.Location = new System.Drawing.Point(753, 626);
            this.BtnNewPayment.Name = "BtnNewPayment";
            this.BtnNewPayment.Size = new System.Drawing.Size(173, 45);
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
            this.BtnPrintReceipt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnPrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrintReceipt.Highlight = true;
            this.BtnPrintReceipt.Location = new System.Drawing.Point(932, 626);
            this.BtnPrintReceipt.Name = "BtnPrintReceipt";
            this.BtnPrintReceipt.Size = new System.Drawing.Size(173, 45);
            this.BtnPrintReceipt.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnPrintReceipt.TabIndex = 5;
            this.BtnPrintReceipt.Text = "Print Receipt";
            this.BtnPrintReceipt.UseCustomBackColor = true;
            this.BtnPrintReceipt.UseCustomForeColor = true;
            this.BtnPrintReceipt.UseSelectable = true;
            this.BtnPrintReceipt.UseStyleColors = true;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayments.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridPayments.EnableHeadersVisualStyles = false;
            this.GridPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayments.Location = new System.Drawing.Point(24, 77);
            this.GridPayments.Name = "GridPayments";
            this.GridPayments.ReadOnly = true;
            this.GridPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.GridPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayment.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridPayment.EnableHeadersVisualStyles = false;
            this.GridPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayment.Location = new System.Drawing.Point(23, 128);
            this.GridPayment.Name = "GridPayment";
            this.GridPayment.ReadOnly = true;
            this.GridPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayment.RowTemplate.Height = 24;
            this.GridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayment.Size = new System.Drawing.Size(1081, 483);
            this.GridPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.GridPayment.TabIndex = 2;
            this.GridPayment.Click += new System.EventHandler(this.GridPayment_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 58;
            // 
            // orderNumberDataGridViewTextBoxColumn1
            // 
            this.orderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn1.Name = "orderNumberDataGridViewTextBoxColumn1";
            this.orderNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn1.Width = 167;
            // 
            // receiptNumberDataGridViewTextBoxColumn1
            // 
            this.receiptNumberDataGridViewTextBoxColumn1.DataPropertyName = "ReceiptNumber";
            this.receiptNumberDataGridViewTextBoxColumn1.HeaderText = "Receipt Number";
            this.receiptNumberDataGridViewTextBoxColumn1.Name = "receiptNumberDataGridViewTextBoxColumn1";
            this.receiptNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.receiptNumberDataGridViewTextBoxColumn1.Width = 180;
            // 
            // receiptDateDataGridViewTextBoxColumn1
            // 
            this.receiptDateDataGridViewTextBoxColumn1.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn1.HeaderText = "Receipt Date";
            this.receiptDateDataGridViewTextBoxColumn1.Name = "receiptDateDataGridViewTextBoxColumn1";
            this.receiptDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.receiptDateDataGridViewTextBoxColumn1.Width = 149;
            // 
            // orderTypeDataGridViewTextBoxColumn1
            // 
            this.orderTypeDataGridViewTextBoxColumn1.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn1.HeaderText = "Order Type";
            this.orderTypeDataGridViewTextBoxColumn1.Name = "orderTypeDataGridViewTextBoxColumn1";
            this.orderTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderTypeDataGridViewTextBoxColumn1.Width = 136;
            // 
            // paymentAmountDataGridViewTextBoxColumn1
            // 
            this.paymentAmountDataGridViewTextBoxColumn1.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn1.HeaderText = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn1.Name = "paymentAmountDataGridViewTextBoxColumn1";
            this.paymentAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentAmountDataGridViewTextBoxColumn1.Width = 190;
            // 
            // branchDataGridViewTextBoxColumn1
            // 
            this.branchDataGridViewTextBoxColumn1.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn1.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn1.Name = "branchDataGridViewTextBoxColumn1";
            this.branchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn1.Width = 98;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn1.Width = 75;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "Customer ID";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Width = 147;
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
            this.LblCustomer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblCustomer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblCustomer.Location = new System.Drawing.Point(184, 91);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(155, 25);
            this.LblCustomer.TabIndex = 10;
            this.LblCustomer.Text = "Customer Name";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(986, 96);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(111, 20);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Customer Name";
            // 
            // LblDue
            // 
            this.LblDue.AutoSize = true;
            this.LblDue.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblDue.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDue.Location = new System.Drawing.Point(559, 91);
            this.LblDue.Name = "LblDue";
            this.LblDue.Size = new System.Drawing.Size(155, 25);
            this.LblDue.TabIndex = 10;
            this.LblDue.Text = "Customer Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Customer Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(427, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Due Amount";
            // 
            // TxtReceiptSearch
            // 
            // 
            // 
            // 
            this.TxtReceiptSearch.CustomButton.Image = null;
            this.TxtReceiptSearch.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.TxtReceiptSearch.CustomButton.Name = "";
            this.TxtReceiptSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtReceiptSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtReceiptSearch.CustomButton.TabIndex = 1;
            this.TxtReceiptSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtReceiptSearch.CustomButton.UseSelectable = true;
            this.TxtReceiptSearch.CustomButton.Visible = false;
            this.TxtReceiptSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtReceiptSearch.Lines = new string[0];
            this.TxtReceiptSearch.Location = new System.Drawing.Point(824, 49);
            this.TxtReceiptSearch.MaxLength = 32767;
            this.TxtReceiptSearch.Name = "TxtReceiptSearch";
            this.TxtReceiptSearch.PasswordChar = '\0';
            this.TxtReceiptSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtReceiptSearch.SelectedText = "";
            this.TxtReceiptSearch.SelectionLength = 0;
            this.TxtReceiptSearch.SelectionStart = 0;
            this.TxtReceiptSearch.ShortcutsEnabled = true;
            this.TxtReceiptSearch.Size = new System.Drawing.Size(273, 30);
            this.TxtReceiptSearch.TabIndex = 1;
            this.TxtReceiptSearch.UseSelectable = true;
            this.TxtReceiptSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtReceiptSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UI_PAYMENT_VIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 694);
            this.Controls.Add(this.TxtReceiptSearch);
            this.Controls.Add(this.LblDue);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.GridPayment);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnNewPayment);
            this.Controls.Add(this.BtnPrintReceipt);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnRefresh;
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
    }
}
