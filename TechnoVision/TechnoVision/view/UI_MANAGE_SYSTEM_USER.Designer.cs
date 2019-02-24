﻿namespace TechnoVision.view
{
    partial class UI_MANAGE_SYSTEM_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_MANAGE_SYSTEM_USER));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditUser = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteUser = new MetroFramework.Controls.MetroButton();
            this.UserGrid = new MetroFramework.Controls.MetroGrid();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.usersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.usersTableAdapter();
            this.BtnActivateUser = new MetroFramework.Controls.MetroButton();
            this.TxtSearchByNic = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEditUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditUser.Highlight = true;
            resources.ApplyResources(this.BtnEditUser, "BtnEditUser");
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditUser.UseCustomBackColor = true;
            this.BtnEditUser.UseCustomForeColor = true;
            this.BtnEditUser.UseSelectable = true;
            this.BtnEditUser.UseStyleColors = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDeleteUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteUser.Highlight = true;
            resources.ApplyResources(this.BtnDeleteUser, "BtnDeleteUser");
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnDeleteUser.UseCustomBackColor = true;
            this.BtnDeleteUser.UseCustomForeColor = true;
            this.BtnDeleteUser.UseSelectable = true;
            this.BtnDeleteUser.UseStyleColors = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // UserGrid
            // 
            this.UserGrid.AllowUserToAddRows = false;
            this.UserGrid.AllowUserToDeleteRows = false;
            this.UserGrid.AllowUserToResizeColumns = false;
            this.UserGrid.AllowUserToResizeRows = false;
            this.UserGrid.AutoGenerateColumns = false;
            this.UserGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.UserGrid.DataSource = this.usersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserGrid.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.UserGrid, "UserGrid");
            this.UserGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ReadOnly = true;
            this.UserGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserGrid.RowTemplate.Height = 24;
            this.UserGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGrid.ShowCellToolTips = false;
            this.UserGrid.ShowEditingIcon = false;
            this.UserGrid.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            resources.ApplyResources(this.usernameDataGridViewTextBoxColumn, "usernameDataGridViewTextBoxColumn");
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.fullNameDataGridViewTextBoxColumn, "fullNameDataGridViewTextBoxColumn");
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "Nic";
            resources.ApplyResources(this.nicDataGridViewTextBoxColumn, "nicDataGridViewTextBoxColumn");
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            this.nicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            resources.ApplyResources(this.contactNumberDataGridViewTextBoxColumn, "contactNumberDataGridViewTextBoxColumn");
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId";
            resources.ApplyResources(this.branchIdDataGridViewTextBoxColumn, "branchIdDataGridViewTextBoxColumn");
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            resources.ApplyResources(this.isActiveDataGridViewTextBoxColumn, "isActiveDataGridViewTextBoxColumn");
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // BtnActivateUser
            // 
            this.BtnActivateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnActivateUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnActivateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActivateUser.Highlight = true;
            resources.ApplyResources(this.BtnActivateUser, "BtnActivateUser");
            this.BtnActivateUser.Name = "BtnActivateUser";
            this.BtnActivateUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnActivateUser.UseCustomBackColor = true;
            this.BtnActivateUser.UseCustomForeColor = true;
            this.BtnActivateUser.UseSelectable = true;
            this.BtnActivateUser.UseStyleColors = true;
            this.BtnActivateUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // TxtSearchByNic
            // 
            // 
            // 
            // 
            this.TxtSearchByNic.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TxtSearchByNic.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TxtSearchByNic.CustomButton.Name = "";
            this.TxtSearchByNic.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TxtSearchByNic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchByNic.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TxtSearchByNic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchByNic.CustomButton.UseSelectable = true;
            this.TxtSearchByNic.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.TxtSearchByNic.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearchByNic.Lines = new string[0];
            resources.ApplyResources(this.TxtSearchByNic, "TxtSearchByNic");
            this.TxtSearchByNic.MaxLength = 32767;
            this.TxtSearchByNic.Name = "TxtSearchByNic";
            this.TxtSearchByNic.PasswordChar = '\0';
            this.TxtSearchByNic.PromptText = "Search By NIC...";
            this.TxtSearchByNic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchByNic.SelectedText = "";
            this.TxtSearchByNic.SelectionLength = 0;
            this.TxtSearchByNic.SelectionStart = 0;
            this.TxtSearchByNic.ShortcutsEnabled = true;
            this.TxtSearchByNic.UseSelectable = true;
            this.TxtSearchByNic.WaterMark = "Search By NIC...";
            this.TxtSearchByNic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchByNic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UI_MANAGE_SYSTEM_USER
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtSearchByNic);
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.BtnActivateUser);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnEditUser);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_SYSTEM_USER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.UI_MANAGE_SYSTEM_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEditUser;
        private MetroFramework.Controls.MetroButton BtnDeleteUser;
        private MetroFramework.Controls.MetroGrid UserGrid;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private technovisionDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton BtnActivateUser;
        private MetroFramework.Controls.MetroTextBox TxtSearchByNic;
    }
}