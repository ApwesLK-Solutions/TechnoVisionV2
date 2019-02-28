namespace TechnoVision.view
{
    partial class UI_VIEW_CUSTOMER
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
            this.GridManageCustomer = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.customerTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.customerTableAdapter();
            this.BtnEditCustomer = new MetroFramework.Controls.MetroButton();
            this.BtnShowOrders = new MetroFramework.Controls.MetroButton();
            this.TxtSearchCustomer = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridManageCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GridManageCustomer
            // 
            this.GridManageCustomer.AllowUserToAddRows = false;
            this.GridManageCustomer.AllowUserToDeleteRows = false;
            this.GridManageCustomer.AllowUserToResizeRows = false;
            this.GridManageCustomer.AutoGenerateColumns = false;
            this.GridManageCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridManageCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridManageCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridManageCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridManageCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridManageCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridManageCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn});
            this.GridManageCustomer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridManageCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridManageCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridManageCustomer.EnableHeadersVisualStyles = false;
            this.GridManageCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridManageCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridManageCustomer.Location = new System.Drawing.Point(20, 60);
            this.GridManageCustomer.Name = "GridManageCustomer";
            this.GridManageCustomer.ReadOnly = true;
            this.GridManageCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridManageCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridManageCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridManageCustomer.RowTemplate.Height = 24;
            this.GridManageCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridManageCustomer.Size = new System.Drawing.Size(1170, 425);
            this.GridManageCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.GridManageCustomer.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 56;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 91;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 94;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 86;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 109;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.ReadOnly = true;
            this.professionDataGridViewTextBoxColumn.Width = 129;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 74;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn.Width = 98;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEditCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditCustomer.Highlight = true;
            this.BtnEditCustomer.Location = new System.Drawing.Point(982, 512);
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(173, 45);
            this.BtnEditCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditCustomer.TabIndex = 2;
            this.BtnEditCustomer.Text = "Edit Customer Details";
            this.BtnEditCustomer.UseCustomBackColor = true;
            this.BtnEditCustomer.UseCustomForeColor = true;
            this.BtnEditCustomer.UseSelectable = true;
            this.BtnEditCustomer.UseStyleColors = true;
            this.BtnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // BtnShowOrders
            // 
            this.BtnShowOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnShowOrders.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnShowOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnShowOrders.Highlight = true;
            this.BtnShowOrders.Location = new System.Drawing.Point(803, 512);
            this.BtnShowOrders.Name = "BtnShowOrders";
            this.BtnShowOrders.Size = new System.Drawing.Size(173, 45);
            this.BtnShowOrders.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnShowOrders.TabIndex = 1;
            this.BtnShowOrders.Text = "Show Orders";
            this.BtnShowOrders.UseCustomBackColor = true;
            this.BtnShowOrders.UseCustomForeColor = true;
            this.BtnShowOrders.UseSelectable = true;
            this.BtnShowOrders.UseStyleColors = true;
            // 
            // TxtSearchCustomer
            // 
            // 
            // 
            // 
            this.TxtSearchCustomer.CustomButton.Image = null;
            this.TxtSearchCustomer.CustomButton.Location = new System.Drawing.Point(198, 2);
            this.TxtSearchCustomer.CustomButton.Name = "";
            this.TxtSearchCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtSearchCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchCustomer.CustomButton.TabIndex = 1;
            this.TxtSearchCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchCustomer.CustomButton.UseSelectable = true;
            this.TxtSearchCustomer.CustomButton.Visible = false;
            this.TxtSearchCustomer.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearchCustomer.Lines = new string[0];
            this.TxtSearchCustomer.Location = new System.Drawing.Point(964, 22);
            this.TxtSearchCustomer.MaxLength = 32767;
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.PasswordChar = '\0';
            this.TxtSearchCustomer.PromptText = "Search by Name or Phone...";
            this.TxtSearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchCustomer.SelectedText = "";
            this.TxtSearchCustomer.SelectionLength = 0;
            this.TxtSearchCustomer.SelectionStart = 0;
            this.TxtSearchCustomer.ShortcutsEnabled = true;
            this.TxtSearchCustomer.Size = new System.Drawing.Size(226, 30);
            this.TxtSearchCustomer.TabIndex = 3;
            this.TxtSearchCustomer.UseSelectable = true;
            this.TxtSearchCustomer.WaterMark = "Search by Name or Phone...";
            this.TxtSearchCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchCustomer.TextChanged += new System.EventHandler(this.TxtSearchCustomer_TextChanged);
            // 
            // UI_VIEW_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 580);
            this.Controls.Add(this.TxtSearchCustomer);
            this.Controls.Add(this.BtnShowOrders);
            this.Controls.Add(this.BtnEditCustomer);
            this.Controls.Add(this.GridManageCustomer);
            this.MaximizeBox = false;
            this.Name = "UI_VIEW_CUSTOMER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Customer Details";
            this.Load += new System.EventHandler(this.UI_VIEW_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridManageCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridManageCustomer;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private technovisionDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton BtnEditCustomer;
        private MetroFramework.Controls.MetroButton BtnShowOrders;
        private MetroFramework.Controls.MetroTextBox TxtSearchCustomer;
    }
}