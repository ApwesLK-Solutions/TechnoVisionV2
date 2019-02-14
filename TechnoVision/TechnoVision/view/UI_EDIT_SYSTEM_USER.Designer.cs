namespace TechnoVision.view
{
    partial class UI_EDIT_SYSTEM_USER
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
            this.BtnEditUser = new MetroFramework.Controls.MetroButton();
            this.CmbBranch = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditUser.Highlight = true;
            this.BtnEditUser.Location = new System.Drawing.Point(205, 248);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(181, 45);
            this.BtnEditUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditUser.TabIndex = 6;
            this.BtnEditUser.Text = "Edit System User";
            this.BtnEditUser.UseCustomBackColor = true;
            this.BtnEditUser.UseCustomForeColor = true;
            this.BtnEditUser.UseSelectable = true;
            this.BtnEditUser.UseStyleColors = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // CmbBranch
            // 
            this.CmbBranch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "BranchId", true));
            this.CmbBranch.DataSource = this.usersBindingSource;
            this.CmbBranch.DisplayMember = "BranchId";
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.ItemHeight = 24;
            this.CmbBranch.Location = new System.Drawing.Point(157, 197);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(400, 30);
            this.CmbBranch.Style = MetroFramework.MetroColorStyle.Green;
            this.CmbBranch.TabIndex = 5;
            this.CmbBranch.UseSelectable = true;
            this.CmbBranch.ValueMember = "BranchId";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(28, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(54, 20);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Branch";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(28, 167);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Contact Number";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(28, 131);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 20);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(28, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Username";
            // 
            // TxtContactNumber
            // 
            // 
            // 
            // 
            this.TxtContactNumber.CustomButton.Image = null;
            this.TxtContactNumber.CustomButton.Location = new System.Drawing.Point(372, 2);
            this.TxtContactNumber.CustomButton.Name = "";
            this.TxtContactNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtContactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContactNumber.CustomButton.TabIndex = 1;
            this.TxtContactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContactNumber.CustomButton.UseSelectable = true;
            this.TxtContactNumber.CustomButton.Visible = false;
            this.TxtContactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ContactNumber", true));
            this.TxtContactNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtContactNumber.Lines = new string[0];
            this.TxtContactNumber.Location = new System.Drawing.Point(157, 162);
            this.TxtContactNumber.MaxLength = 32767;
            this.TxtContactNumber.Name = "TxtContactNumber";
            this.TxtContactNumber.PasswordChar = '\0';
            this.TxtContactNumber.PromptText = "Enter Contact Number...";
            this.TxtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContactNumber.SelectedText = "";
            this.TxtContactNumber.SelectionLength = 0;
            this.TxtContactNumber.SelectionStart = 0;
            this.TxtContactNumber.ShortcutsEnabled = true;
            this.TxtContactNumber.Size = new System.Drawing.Size(400, 30);
            this.TxtContactNumber.TabIndex = 4;
            this.TxtContactNumber.UseSelectable = true;
            this.TxtContactNumber.WaterMark = "Enter Contact Number...";
            this.TxtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(372, 2);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.TxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(157, 126);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PromptText = "Enter Password...";
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(400, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMark = "Enter Password...";
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtUsername
            // 
            // 
            // 
            // 
            this.TxtUserName.CustomButton.Image = null;
            this.TxtUserName.CustomButton.Location = new System.Drawing.Point(372, 2);
            this.TxtUserName.CustomButton.Name = "";
            this.TxtUserName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserName.CustomButton.TabIndex = 1;
            this.TxtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserName.CustomButton.UseSelectable = true;
            this.TxtUserName.CustomButton.Visible = false;
            this.TxtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.TxtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtUserName.Lines = new string[0];
            this.TxtUserName.Location = new System.Drawing.Point(157, 91);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PromptText = "Enter Username...";
            this.TxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.ShortcutsEnabled = true;
            this.TxtUserName.Size = new System.Drawing.Size(400, 30);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.UseSelectable = true;
            this.TxtUserName.WaterMark = "Enter Username...";
            this.TxtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UI_EDIT_SYSTEM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 304);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtContactNumber);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.MaximizeBox = false;
            this.Name = "UI_EDIT_SYSTEM_USER";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit System User";
            this.Load += new System.EventHandler(this.UI_EDIT_SYSTEM_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEditUser;
        private MetroFramework.Controls.MetroComboBox CmbBranch;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtContactNumber;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTextBox TxtUserName;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private technovisionDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}