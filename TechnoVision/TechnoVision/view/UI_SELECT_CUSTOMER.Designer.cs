namespace TechnoVision.view
{
    partial class UI_SELECT_CUSTOMER
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
            this.TxtSearchCustomer = new MetroFramework.Controls.MetroTextBox();
            this.BtnRefresh = new MetroFramework.Controls.MetroButton();
            this.BtnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.GridSelectCustomer = new MetroFramework.Controls.MetroGrid();
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
            this.BtnSelect = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridSelectCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchCustomer
            // 
            // 
            // 
            // 
            this.TxtSearchCustomer.CustomButton.Image = null;
            this.TxtSearchCustomer.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.TxtSearchCustomer.CustomButton.Name = "";
            this.TxtSearchCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtSearchCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchCustomer.CustomButton.TabIndex = 1;
            this.TxtSearchCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchCustomer.CustomButton.UseSelectable = true;
            this.TxtSearchCustomer.CustomButton.Visible = false;
            this.TxtSearchCustomer.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearchCustomer.Lines = new string[0];
            this.TxtSearchCustomer.Location = new System.Drawing.Point(902, 51);
            this.TxtSearchCustomer.MaxLength = 32767;
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.PasswordChar = '\0';
            this.TxtSearchCustomer.PromptText = "Search by Name or Phone...";
            this.TxtSearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchCustomer.SelectedText = "";
            this.TxtSearchCustomer.SelectionLength = 0;
            this.TxtSearchCustomer.SelectionStart = 0;
            this.TxtSearchCustomer.ShortcutsEnabled = true;
            this.TxtSearchCustomer.Size = new System.Drawing.Size(288, 30);
            this.TxtSearchCustomer.TabIndex = 5;
            this.TxtSearchCustomer.UseSelectable = true;
            this.TxtSearchCustomer.WaterMark = "Search by Name or Phone...";
            this.TxtSearchCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearchCustomer.TextChanged += new System.EventHandler(this.TxtSearchCustomer_TextChanged);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRefresh.Highlight = true;
            this.BtnRefresh.Location = new System.Drawing.Point(798, 518);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 45);
            this.BtnRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCustomBackColor = true;
            this.BtnRefresh.UseCustomForeColor = true;
            this.BtnRefresh.UseSelectable = true;
            this.BtnRefresh.UseStyleColors = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddCustomer.Highlight = true;
            this.BtnAddCustomer.Location = new System.Drawing.Point(910, 518);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(142, 45);
            this.BtnAddCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddCustomer.TabIndex = 9;
            this.BtnAddCustomer.Text = "Add New Customer";
            this.BtnAddCustomer.UseCustomBackColor = true;
            this.BtnAddCustomer.UseCustomForeColor = true;
            this.BtnAddCustomer.UseSelectable = true;
            this.BtnAddCustomer.UseStyleColors = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // GridSelectCustomer
            // 
            this.GridSelectCustomer.AllowUserToAddRows = false;
            this.GridSelectCustomer.AllowUserToDeleteRows = false;
            this.GridSelectCustomer.AllowUserToOrderColumns = true;
            this.GridSelectCustomer.AllowUserToResizeRows = false;
            this.GridSelectCustomer.AutoGenerateColumns = false;
            this.GridSelectCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridSelectCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridSelectCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSelectCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSelectCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridSelectCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSelectCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridSelectCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSelectCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn});
            this.GridSelectCustomer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSelectCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridSelectCustomer.EnableHeadersVisualStyles = false;
            this.GridSelectCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridSelectCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSelectCustomer.Location = new System.Drawing.Point(20, 87);
            this.GridSelectCustomer.Name = "GridSelectCustomer";
            this.GridSelectCustomer.ReadOnly = true;
            this.GridSelectCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSelectCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridSelectCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridSelectCustomer.RowTemplate.Height = 24;
            this.GridSelectCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSelectCustomer.Size = new System.Drawing.Size(1170, 425);
            this.GridSelectCustomer.Style = MetroFramework.MetroColorStyle.Green;
            this.GridSelectCustomer.TabIndex = 6;
            this.GridSelectCustomer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridSelectCustomer_MouseDoubleClick);
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
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSelect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSelect.Highlight = true;
            this.BtnSelect.Location = new System.Drawing.Point(1058, 518);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(142, 45);
            this.BtnSelect.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSelect.TabIndex = 9;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseCustomBackColor = true;
            this.BtnSelect.UseCustomForeColor = true;
            this.BtnSelect.UseSelectable = true;
            this.BtnSelect.UseStyleColors = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // UI_SELECT_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 580);
            this.Controls.Add(this.TxtSearchCustomer);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.GridSelectCustomer);
            this.MaximizeBox = false;
            this.Name = "UI_SELECT_CUSTOMER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Select Customer";
            this.Load += new System.EventHandler(this.UI_SELECT_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSelectCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtSearchCustomer;
        private MetroFramework.Controls.MetroButton BtnRefresh;
        private MetroFramework.Controls.MetroButton BtnAddCustomer;
        private MetroFramework.Controls.MetroGrid GridSelectCustomer;
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
        private MetroFramework.Controls.MetroButton BtnSelect;
    }
}