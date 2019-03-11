namespace TechnoVision.view
{
    partial class UI_ADD_NEW_PAYMENT
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
            this.LblOrderNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblDueAmount = new MetroFramework.Controls.MetroLabel();
            this.LblReceiptNo = new MetroFramework.Controls.MetroLabel();
            this.DateOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtAmount = new MetroFramework.Controls.MetroTextBox();
            this.BtnAddPayment = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridPayementHistory = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.receiptTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.receiptTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayementHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOrderNo
            // 
            this.LblOrderNo.AutoSize = true;
            this.LblOrderNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblOrderNo.Location = new System.Drawing.Point(173, 120);
            this.LblOrderNo.Name = "LblOrderNo";
            this.LblOrderNo.Size = new System.Drawing.Size(74, 20);
            this.LblOrderNo.TabIndex = 96;
            this.LblOrderNo.Text = "Order No";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(45, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 20);
            this.metroLabel1.TabIndex = 90;
            this.metroLabel1.Text = "Receipt Number";
            // 
            // LblDueAmount
            // 
            this.LblDueAmount.AutoSize = true;
            this.LblDueAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDueAmount.Location = new System.Drawing.Point(173, 157);
            this.LblDueAmount.Name = "LblDueAmount";
            this.LblDueAmount.Size = new System.Drawing.Size(123, 20);
            this.LblDueAmount.TabIndex = 95;
            this.LblDueAmount.Text = "Receipt Number";
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblReceiptNo.Location = new System.Drawing.Point(174, 86);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(123, 20);
            this.LblReceiptNo.TabIndex = 89;
            this.LblReceiptNo.Text = "Receipt Number";
            // 
            // DateOrderDate
            // 
            this.DateOrderDate.Location = new System.Drawing.Point(174, 194);
            this.DateOrderDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateOrderDate.Name = "DateOrderDate";
            this.DateOrderDate.Size = new System.Drawing.Size(290, 30);
            this.DateOrderDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOrderDate.TabIndex = 91;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(45, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 20);
            this.metroLabel4.TabIndex = 93;
            this.metroLabel4.Text = "Due Amount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(45, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 20);
            this.metroLabel3.TabIndex = 92;
            this.metroLabel3.Text = "Receipt Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(45, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Order No";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(45, 244);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 20);
            this.metroLabel5.TabIndex = 92;
            this.metroLabel5.Text = "Payment Amount";
            // 
            // TxtAmount
            // 
            // 
            // 
            // 
            this.TxtAmount.CustomButton.Image = null;
            this.TxtAmount.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TxtAmount.CustomButton.Name = "";
            this.TxtAmount.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAmount.CustomButton.TabIndex = 1;
            this.TxtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAmount.CustomButton.UseSelectable = true;
            this.TxtAmount.CustomButton.Visible = false;
            this.TxtAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAmount.Lines = new string[0];
            this.TxtAmount.Location = new System.Drawing.Point(173, 244);
            this.TxtAmount.MaxLength = 32767;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PasswordChar = '\0';
            this.TxtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAmount.SelectedText = "";
            this.TxtAmount.SelectionLength = 0;
            this.TxtAmount.SelectionStart = 0;
            this.TxtAmount.ShortcutsEnabled = true;
            this.TxtAmount.Size = new System.Drawing.Size(290, 35);
            this.TxtAmount.TabIndex = 97;
            this.TxtAmount.UseSelectable = true;
            this.TxtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAddPayment
            // 
            this.BtnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddPayment.Highlight = true;
            this.BtnAddPayment.Location = new System.Drawing.Point(109, 311);
            this.BtnAddPayment.Name = "BtnAddPayment";
            this.BtnAddPayment.Size = new System.Drawing.Size(261, 45);
            this.BtnAddPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddPayment.TabIndex = 98;
            this.BtnAddPayment.Text = "Add New Payment";
            this.BtnAddPayment.UseCustomBackColor = true;
            this.BtnAddPayment.UseCustomForeColor = true;
            this.BtnAddPayment.UseSelectable = true;
            this.BtnAddPayment.UseStyleColors = true;
            this.BtnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridPayementHistory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(472, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 348);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment History";
            // 
            // GridPayementHistory
            // 
            this.GridPayementHistory.AllowUserToAddRows = false;
            this.GridPayementHistory.AllowUserToDeleteRows = false;
            this.GridPayementHistory.AllowUserToOrderColumns = true;
            this.GridPayementHistory.AllowUserToResizeRows = false;
            this.GridPayementHistory.AutoGenerateColumns = false;
            this.GridPayementHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridPayementHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPayementHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayementHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayementHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayementHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayementHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPayementHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPayementHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn});
            this.GridPayementHistory.DataSource = this.receiptBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayementHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPayementHistory.EnableHeadersVisualStyles = false;
            this.GridPayementHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayementHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayementHistory.Location = new System.Drawing.Point(9, 26);
            this.GridPayementHistory.Name = "GridPayementHistory";
            this.GridPayementHistory.ReadOnly = true;
            this.GridPayementHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayementHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPayementHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayementHistory.RowTemplate.Height = 24;
            this.GridPayementHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayementHistory.Size = new System.Drawing.Size(614, 299);
            this.GridPayementHistory.Style = MetroFramework.MetroColorStyle.Green;
            this.GridPayementHistory.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 56;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 162;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.receiptDateDataGridViewTextBoxColumn.Width = 144;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentAmountDataGridViewTextBoxColumn.Width = 185;
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
            // UI_ADD_NEW_PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAddPayment);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.LblOrderNo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LblDueAmount);
            this.Controls.Add(this.LblReceiptNo);
            this.Controls.Add(this.DateOrderDate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.Name = "UI_ADD_NEW_PAYMENT";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add New Payment";
            this.Load += new System.EventHandler(this.UI_ADD_NEW_PAYMENT_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPayementHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblDueAmount;
        private MetroFramework.Controls.MetroLabel LblReceiptNo;
        private MetroFramework.Controls.MetroDateTime DateOrderDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtAmount;
        private MetroFramework.Controls.MetroButton BtnAddPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid GridPayementHistory;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private technovisionDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
    }
}