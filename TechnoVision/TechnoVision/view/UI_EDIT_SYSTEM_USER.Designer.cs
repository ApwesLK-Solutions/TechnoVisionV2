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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtFullName = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.usersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.usersTableAdapter();
            this.TxtMasterPassword = new MetroFramework.Controls.MetroTextBox();
            this.TmrMasterPassword = new System.Windows.Forms.Timer(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditUser.Highlight = true;
            this.BtnEditUser.Location = new System.Drawing.Point(228, 400);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(158, 64);
            this.BtnEditUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditUser.TabIndex = 7;
            this.BtnEditUser.Text = "Save changes";
            this.BtnEditUser.UseCustomBackColor = true;
            this.BtnEditUser.UseCustomForeColor = true;
            this.BtnEditUser.UseSelectable = true;
            this.BtnEditUser.UseStyleColors = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(31, 227);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Contact Number";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(31, 183);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 20);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Full Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(31, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(31, 95);
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
            this.TxtContactNumber.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtContactNumber.CustomButton.Name = "";
            this.TxtContactNumber.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtContactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContactNumber.CustomButton.TabIndex = 1;
            this.TxtContactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContactNumber.CustomButton.UseSelectable = true;
            this.TxtContactNumber.CustomButton.Visible = false;
            this.TxtContactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ContactNumber", true));
            this.TxtContactNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtContactNumber.Lines = new string[0];
            this.TxtContactNumber.Location = new System.Drawing.Point(180, 220);
            this.TxtContactNumber.MaxLength = 32767;
            this.TxtContactNumber.Name = "TxtContactNumber";
            this.TxtContactNumber.PasswordChar = '\0';
            this.TxtContactNumber.PromptText = "Enter Contact Number...";
            this.TxtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContactNumber.SelectedText = "";
            this.TxtContactNumber.SelectionLength = 0;
            this.TxtContactNumber.SelectionStart = 0;
            this.TxtContactNumber.ShortcutsEnabled = true;
            this.TxtContactNumber.Size = new System.Drawing.Size(400, 35);
            this.TxtContactNumber.TabIndex = 4;
            this.TxtContactNumber.UseSelectable = true;
            this.TxtContactNumber.WaterMark = "Enter Contact Number...";
            this.TxtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtFullName
            // 
            // 
            // 
            // 
            this.TxtFullName.CustomButton.Image = null;
            this.TxtFullName.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtFullName.CustomButton.Name = "";
            this.TxtFullName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtFullName.CustomButton.TabIndex = 1;
            this.TxtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtFullName.CustomButton.UseSelectable = true;
            this.TxtFullName.CustomButton.Visible = false;
            this.TxtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.TxtFullName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtFullName.Lines = new string[0];
            this.TxtFullName.Location = new System.Drawing.Point(180, 176);
            this.TxtFullName.MaxLength = 32767;
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.PasswordChar = '\0';
            this.TxtFullName.PromptText = "Enter Full Name...";
            this.TxtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtFullName.SelectedText = "";
            this.TxtFullName.SelectionLength = 0;
            this.TxtFullName.SelectionStart = 0;
            this.TxtFullName.ShortcutsEnabled = true;
            this.TxtFullName.Size = new System.Drawing.Size(400, 35);
            this.TxtFullName.TabIndex = 3;
            this.TxtFullName.UseSelectable = true;
            this.TxtFullName.WaterMark = "Enter Full Name...";
            this.TxtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.TxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(180, 132);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PromptText = "Enter Password...";
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(400, 35);
            this.TxtPassword.TabIndex = 2;
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
            this.TxtUsername.CustomButton.Image = null;
            this.TxtUsername.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtUsername.CustomButton.Name = "";
            this.TxtUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsername.CustomButton.TabIndex = 1;
            this.TxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsername.CustomButton.UseSelectable = true;
            this.TxtUsername.CustomButton.Visible = false;
            this.TxtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.TxtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtUsername.Lines = new string[0];
            this.TxtUsername.Location = new System.Drawing.Point(180, 88);
            this.TxtUsername.MaxLength = 32767;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.PromptText = "Enter Username...";
            this.TxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.ShortcutsEnabled = true;
            this.TxtUsername.Size = new System.Drawing.Size(400, 35);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.UseSelectable = true;
            this.TxtUsername.WaterMark = "Enter Username...";
            this.TxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // TxtMasterPassword
            // 
            // 
            // 
            // 
            this.TxtMasterPassword.CustomButton.Image = null;
            this.TxtMasterPassword.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.TxtMasterPassword.CustomButton.Name = "";
            this.TxtMasterPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtMasterPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMasterPassword.CustomButton.TabIndex = 1;
            this.TxtMasterPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMasterPassword.CustomButton.UseSelectable = true;
            this.TxtMasterPassword.CustomButton.Visible = false;
            this.TxtMasterPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtMasterPassword.Lines = new string[0];
            this.TxtMasterPassword.Location = new System.Drawing.Point(190, 349);
            this.TxtMasterPassword.MaxLength = 32767;
            this.TxtMasterPassword.Name = "TxtMasterPassword";
            this.TxtMasterPassword.PasswordChar = '#';
            this.TxtMasterPassword.PromptText = "Enter Master Password...";
            this.TxtMasterPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMasterPassword.SelectedText = "";
            this.TxtMasterPassword.SelectionLength = 0;
            this.TxtMasterPassword.SelectionStart = 0;
            this.TxtMasterPassword.ShortcutsEnabled = true;
            this.TxtMasterPassword.Size = new System.Drawing.Size(236, 35);
            this.TxtMasterPassword.TabIndex = 6;
            this.TxtMasterPassword.UseSelectable = true;
            this.TxtMasterPassword.WaterMark = "Enter Master Password...";
            this.TxtMasterPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMasterPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TmrMasterPassword
            // 
            this.TmrMasterPassword.Enabled = true;
            this.TmrMasterPassword.Tick += new System.EventHandler(this.TmrMasterPassword_Tick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(120, 282);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(393, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Please Enter Master Password To Enable Below Button.";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(152, 302);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(316, 20);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = " Master Password is Unique for each Branch";
            // 
            // UI_EDIT_SYSTEM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 487);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtContactNumber);
            this.Controls.Add(this.TxtMasterPassword);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.MaximizeBox = false;
            this.Name = "UI_EDIT_SYSTEM_USER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit System User Details";
            this.Load += new System.EventHandler(this.UI_EDIT_SYSTEM_USER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEditUser;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtContactNumber;
        private MetroFramework.Controls.MetroTextBox TxtFullName;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTextBox TxtUsername;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private technovisionDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private MetroFramework.Controls.MetroTextBox TxtMasterPassword;
        private System.Windows.Forms.Timer TmrMasterPassword;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}