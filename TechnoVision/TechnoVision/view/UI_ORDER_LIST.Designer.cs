namespace TechnoVision.view
{
    partial class UI_ORDER_LIST
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
            this.BtnViewCompanyCopy = new MetroFramework.Controls.MetroButton();
            this.BtnViewCustomerCopy = new MetroFramework.Controls.MetroButton();
            this.CmbSetAs = new MetroFramework.Controls.MetroComboBox();
            this.BtnMarkAs = new MetroFramework.Controls.MetroButton();
            this.RadioContactLense = new MetroFramework.Controls.MetroRadioButton();
            this.RadioSpectacles = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.SpecGrid = new MetroFramework.Controls.MetroGrid();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectaclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.spectaclesTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.spectaclesTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LenseGrid = new MetroFramework.Controls.MetroGrid();
            this.orderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentPlanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactlenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactlenseTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.contactlenseTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactlenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnViewCompanyCopy
            // 
            this.BtnViewCompanyCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnViewCompanyCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewCompanyCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnViewCompanyCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnViewCompanyCopy.Highlight = true;
            this.BtnViewCompanyCopy.Location = new System.Drawing.Point(970, 594);
            this.BtnViewCompanyCopy.Name = "BtnViewCompanyCopy";
            this.BtnViewCompanyCopy.Size = new System.Drawing.Size(162, 45);
            this.BtnViewCompanyCopy.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnViewCompanyCopy.TabIndex = 5;
            this.BtnViewCompanyCopy.Text = "View Company Copy";
            this.BtnViewCompanyCopy.UseCustomBackColor = true;
            this.BtnViewCompanyCopy.UseCustomForeColor = true;
            this.BtnViewCompanyCopy.UseSelectable = true;
            this.BtnViewCompanyCopy.UseStyleColors = true;
            // 
            // BtnViewCustomerCopy
            // 
            this.BtnViewCustomerCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnViewCustomerCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewCustomerCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnViewCustomerCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnViewCustomerCopy.Highlight = true;
            this.BtnViewCustomerCopy.Location = new System.Drawing.Point(812, 594);
            this.BtnViewCustomerCopy.Name = "BtnViewCustomerCopy";
            this.BtnViewCustomerCopy.Size = new System.Drawing.Size(152, 45);
            this.BtnViewCustomerCopy.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnViewCustomerCopy.TabIndex = 4;
            this.BtnViewCustomerCopy.Text = "View Customer Copy";
            this.BtnViewCustomerCopy.UseCustomBackColor = true;
            this.BtnViewCustomerCopy.UseCustomForeColor = true;
            this.BtnViewCustomerCopy.UseSelectable = true;
            this.BtnViewCustomerCopy.UseStyleColors = true;
            // 
            // CmbSetAs
            // 
            this.CmbSetAs.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CmbSetAs.FormattingEnabled = true;
            this.CmbSetAs.ItemHeight = 29;
            this.CmbSetAs.Items.AddRange(new object[] {
            "DELEVERED",
            "CANCELED"});
            this.CmbSetAs.Location = new System.Drawing.Point(19, 599);
            this.CmbSetAs.Name = "CmbSetAs";
            this.CmbSetAs.Size = new System.Drawing.Size(228, 35);
            this.CmbSetAs.TabIndex = 2;
            this.CmbSetAs.UseSelectable = true;
            // 
            // BtnMarkAs
            // 
            this.BtnMarkAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnMarkAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMarkAs.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnMarkAs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMarkAs.Highlight = true;
            this.BtnMarkAs.Location = new System.Drawing.Point(253, 594);
            this.BtnMarkAs.Name = "BtnMarkAs";
            this.BtnMarkAs.Size = new System.Drawing.Size(152, 45);
            this.BtnMarkAs.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnMarkAs.TabIndex = 3;
            this.BtnMarkAs.Text = "Mark As";
            this.BtnMarkAs.UseCustomBackColor = true;
            this.BtnMarkAs.UseCustomForeColor = true;
            this.BtnMarkAs.UseSelectable = true;
            this.BtnMarkAs.UseStyleColors = true;
            this.BtnMarkAs.Click += new System.EventHandler(this.BtnMarkAs_Click);
            // 
            // RadioContactLense
            // 
            this.RadioContactLense.AutoSize = true;
            this.RadioContactLense.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioContactLense.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.RadioContactLense.Location = new System.Drawing.Point(288, 31);
            this.RadioContactLense.Name = "RadioContactLense";
            this.RadioContactLense.Size = new System.Drawing.Size(160, 25);
            this.RadioContactLense.Style = MetroFramework.MetroColorStyle.Green;
            this.RadioContactLense.TabIndex = 6;
            this.RadioContactLense.Text = "Contact Lenses";
            this.RadioContactLense.UseSelectable = true;
            // 
            // RadioSpectacles
            // 
            this.RadioSpectacles.AutoSize = true;
            this.RadioSpectacles.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioSpectacles.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.RadioSpectacles.Location = new System.Drawing.Point(120, 31);
            this.RadioSpectacles.Name = "RadioSpectacles";
            this.RadioSpectacles.Size = new System.Drawing.Size(119, 25);
            this.RadioSpectacles.Style = MetroFramework.MetroColorStyle.Green;
            this.RadioSpectacles.TabIndex = 6;
            this.RadioSpectacles.Text = "Spectacles";
            this.RadioSpectacles.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Controls.Add(this.RadioContactLense);
            this.groupBox1.Controls.Add(this.RadioSpectacles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(196, 2);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(879, 26);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PromptText = "Search By Order Number...";
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.ShortcutsEnabled = true;
            this.TxtSearch.Size = new System.Drawing.Size(224, 30);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMark = "Search By Order Number...";
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // SpecGrid
            // 
            this.SpecGrid.AllowUserToAddRows = false;
            this.SpecGrid.AllowUserToDeleteRows = false;
            this.SpecGrid.AllowUserToOrderColumns = true;
            this.SpecGrid.AllowUserToResizeRows = false;
            this.SpecGrid.AutoGenerateColumns = false;
            this.SpecGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SpecGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SpecGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpecGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpecGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SpecGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpecGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SpecGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.paymentPlanDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.reminderDateDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.testByDataGridViewTextBoxColumn});
            this.SpecGrid.DataSource = this.spectaclesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SpecGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SpecGrid.EnableHeadersVisualStyles = false;
            this.SpecGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SpecGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpecGrid.Location = new System.Drawing.Point(19, 157);
            this.SpecGrid.Name = "SpecGrid";
            this.SpecGrid.ReadOnly = true;
            this.SpecGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpecGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SpecGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SpecGrid.RowTemplate.Height = 24;
            this.SpecGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecGrid.Size = new System.Drawing.Size(1109, 388);
            this.SpecGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.SpecGrid.TabIndex = 6;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn.Width = 167;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "Order Status";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderStatusDataGridViewTextBoxColumn.Width = 148;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 136;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 81;
            // 
            // advanceDataGridViewTextBoxColumn
            // 
            this.advanceDataGridViewTextBoxColumn.DataPropertyName = "Advance";
            this.advanceDataGridViewTextBoxColumn.HeaderText = "Advance";
            this.advanceDataGridViewTextBoxColumn.Name = "advanceDataGridViewTextBoxColumn";
            this.advanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.advanceDataGridViewTextBoxColumn.Width = 114;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 116;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 105;
            // 
            // paymentPlanDataGridViewTextBoxColumn
            // 
            this.paymentPlanDataGridViewTextBoxColumn.DataPropertyName = "PaymentPlan";
            this.paymentPlanDataGridViewTextBoxColumn.HeaderText = "Payment Plan";
            this.paymentPlanDataGridViewTextBoxColumn.Name = "paymentPlanDataGridViewTextBoxColumn";
            this.paymentPlanDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentPlanDataGridViewTextBoxColumn.Width = 156;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 189;
            // 
            // reminderDateDataGridViewTextBoxColumn
            // 
            this.reminderDateDataGridViewTextBoxColumn.DataPropertyName = "ReminderDate";
            this.reminderDateDataGridViewTextBoxColumn.HeaderText = "Reminder Days";
            this.reminderDateDataGridViewTextBoxColumn.Name = "reminderDateDataGridViewTextBoxColumn";
            this.reminderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reminderDateDataGridViewTextBoxColumn.Width = 169;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn.Width = 98;
            // 
            // testByDataGridViewTextBoxColumn
            // 
            this.testByDataGridViewTextBoxColumn.DataPropertyName = "TestBy";
            this.testByDataGridViewTextBoxColumn.HeaderText = "Test By";
            this.testByDataGridViewTextBoxColumn.Name = "testByDataGridViewTextBoxColumn";
            this.testByDataGridViewTextBoxColumn.ReadOnly = true;
            this.testByDataGridViewTextBoxColumn.Width = 98;
            // 
            // spectaclesBindingSource
            // 
            this.spectaclesBindingSource.DataMember = "spectacles";
            this.spectaclesBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spectaclesTableAdapter
            // 
            this.spectaclesTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LenseGrid
            // 
            this.LenseGrid.AllowUserToAddRows = false;
            this.LenseGrid.AllowUserToDeleteRows = false;
            this.LenseGrid.AllowUserToOrderColumns = true;
            this.LenseGrid.AllowUserToResizeRows = false;
            this.LenseGrid.AutoGenerateColumns = false;
            this.LenseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LenseGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LenseGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LenseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LenseGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LenseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LenseGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LenseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LenseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn1,
            this.orderStatusDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.dueDateDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn1,
            this.discountDataGridViewTextBoxColumn1,
            this.advanceDataGridViewTextBoxColumn1,
            this.balanceDataGridViewTextBoxColumn1,
            this.ReminderDays,
            this.paymentMethodDataGridViewTextBoxColumn1,
            this.paymentPlanDataGridViewTextBoxColumn1,
            this.branchDataGridViewTextBoxColumn1,
            this.testedByDataGridViewTextBoxColumn});
            this.LenseGrid.DataSource = this.contactlenseBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LenseGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.LenseGrid.EnableHeadersVisualStyles = false;
            this.LenseGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LenseGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LenseGrid.Location = new System.Drawing.Point(23, 157);
            this.LenseGrid.Name = "LenseGrid";
            this.LenseGrid.ReadOnly = true;
            this.LenseGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LenseGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.LenseGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LenseGrid.RowTemplate.Height = 24;
            this.LenseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LenseGrid.Size = new System.Drawing.Size(1109, 388);
            this.LenseGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.LenseGrid.TabIndex = 7;
            // 
            // orderNumberDataGridViewTextBoxColumn1
            // 
            this.orderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.orderNumberDataGridViewTextBoxColumn1.Name = "orderNumberDataGridViewTextBoxColumn1";
            this.orderNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderNumberDataGridViewTextBoxColumn1.Width = 167;
            // 
            // orderStatusDataGridViewTextBoxColumn1
            // 
            this.orderStatusDataGridViewTextBoxColumn1.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn1.HeaderText = "Order Status";
            this.orderStatusDataGridViewTextBoxColumn1.Name = "orderStatusDataGridViewTextBoxColumn1";
            this.orderStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderStatusDataGridViewTextBoxColumn1.Width = 148;
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "Order Date";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            this.orderDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn1.Width = 136;
            // 
            // dueDateDataGridViewTextBoxColumn1
            // 
            this.dueDateDataGridViewTextBoxColumn1.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn1.HeaderText = "Due Date";
            this.dueDateDataGridViewTextBoxColumn1.Name = "dueDateDataGridViewTextBoxColumn1";
            this.dueDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dueDateDataGridViewTextBoxColumn1.Width = 120;
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            this.totalDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn1.Width = 81;
            // 
            // discountDataGridViewTextBoxColumn1
            // 
            this.discountDataGridViewTextBoxColumn1.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn1.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn1.Name = "discountDataGridViewTextBoxColumn1";
            this.discountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn1.Width = 116;
            // 
            // advanceDataGridViewTextBoxColumn1
            // 
            this.advanceDataGridViewTextBoxColumn1.DataPropertyName = "Advance";
            this.advanceDataGridViewTextBoxColumn1.HeaderText = "Advance";
            this.advanceDataGridViewTextBoxColumn1.Name = "advanceDataGridViewTextBoxColumn1";
            this.advanceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.advanceDataGridViewTextBoxColumn1.Width = 114;
            // 
            // balanceDataGridViewTextBoxColumn1
            // 
            this.balanceDataGridViewTextBoxColumn1.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn1.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn1.Name = "balanceDataGridViewTextBoxColumn1";
            this.balanceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn1.Width = 105;
            // 
            // ReminderDays
            // 
            this.ReminderDays.DataPropertyName = "ReminderDays";
            this.ReminderDays.HeaderText = "Reminder Days";
            this.ReminderDays.Name = "ReminderDays";
            this.ReminderDays.ReadOnly = true;
            this.ReminderDays.Width = 169;
            // 
            // paymentMethodDataGridViewTextBoxColumn1
            // 
            this.paymentMethodDataGridViewTextBoxColumn1.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn1.HeaderText = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn1.Name = "paymentMethodDataGridViewTextBoxColumn1";
            this.paymentMethodDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn1.Width = 189;
            // 
            // paymentPlanDataGridViewTextBoxColumn1
            // 
            this.paymentPlanDataGridViewTextBoxColumn1.DataPropertyName = "PaymentPlan";
            this.paymentPlanDataGridViewTextBoxColumn1.HeaderText = "Payment Plan";
            this.paymentPlanDataGridViewTextBoxColumn1.Name = "paymentPlanDataGridViewTextBoxColumn1";
            this.paymentPlanDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentPlanDataGridViewTextBoxColumn1.Width = 156;
            // 
            // branchDataGridViewTextBoxColumn1
            // 
            this.branchDataGridViewTextBoxColumn1.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn1.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn1.Name = "branchDataGridViewTextBoxColumn1";
            this.branchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn1.Width = 98;
            // 
            // testedByDataGridViewTextBoxColumn
            // 
            this.testedByDataGridViewTextBoxColumn.DataPropertyName = "TestedBy";
            this.testedByDataGridViewTextBoxColumn.HeaderText = "Tested By";
            this.testedByDataGridViewTextBoxColumn.Name = "testedByDataGridViewTextBoxColumn";
            this.testedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.testedByDataGridViewTextBoxColumn.Width = 120;
            // 
            // contactlenseBindingSource
            // 
            this.contactlenseBindingSource.DataMember = "contactlense";
            this.contactlenseBindingSource.DataSource = this.technovisionDataSet;
            // 
            // contactlenseTableAdapter
            // 
            this.contactlenseTableAdapter.ClearBeforeFill = true;
            // 
            // UI_ORDER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 650);
            this.Controls.Add(this.LenseGrid);
            this.Controls.Add(this.SpecGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbSetAs);
            this.Controls.Add(this.BtnViewCompanyCopy);
            this.Controls.Add(this.BtnMarkAs);
            this.Controls.Add(this.BtnViewCustomerCopy);
            this.MaximizeBox = false;
            this.Name = "UI_ORDER_LIST";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Order List";
            this.Load += new System.EventHandler(this.UI_ORDER_LIST_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactlenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnViewCompanyCopy;
        private MetroFramework.Controls.MetroButton BtnViewCustomerCopy;
        private MetroFramework.Controls.MetroComboBox CmbSetAs;
        private MetroFramework.Controls.MetroButton BtnMarkAs;
        private MetroFramework.Controls.MetroRadioButton RadioContactLense;
        private MetroFramework.Controls.MetroRadioButton RadioSpectacles;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroGrid SpecGrid;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource spectaclesBindingSource;
        private technovisionDataSetTableAdapters.spectaclesTableAdapter spectaclesTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroGrid LenseGrid;
        private System.Windows.Forms.BindingSource contactlenseBindingSource;
        private technovisionDataSetTableAdapters.contactlenseTableAdapter contactlenseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentPlanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testedByDataGridViewTextBoxColumn;
    }
}
