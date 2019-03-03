namespace TechnoVision.view
{
    partial class UI_ADD_CUSTOMER
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
            this.lael = new MetroFramework.Controls.MetroLabel();
            this.TxtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtAge = new MetroFramework.Controls.MetroTextBox();
            this.TxtProffession = new MetroFramework.Controls.MetroTextBox();
            this.CmbBranch = new MetroFramework.Controls.MetroComboBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnClear = new MetroFramework.Controls.MetroButton();
            this.branchTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.branchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lael
            // 
            this.lael.AutoSize = true;
            this.lael.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lael.Location = new System.Drawing.Point(45, 77);
            this.lael.Name = "lael";
            this.lael.Size = new System.Drawing.Size(49, 20);
            this.lael.TabIndex = 0;
            this.lael.Text = "Name";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtCustomerName.CustomButton.Image = null;
            this.TxtCustomerName.CustomButton.Location = new System.Drawing.Point(743, 2);
            this.TxtCustomerName.CustomButton.Name = "";
            this.TxtCustomerName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCustomerName.CustomButton.TabIndex = 1;
            this.TxtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCustomerName.CustomButton.UseSelectable = true;
            this.TxtCustomerName.CustomButton.Visible = false;
            this.TxtCustomerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtCustomerName.Lines = new string[0];
            this.TxtCustomerName.Location = new System.Drawing.Point(169, 72);
            this.TxtCustomerName.MaxLength = 32767;
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.PasswordChar = '\0';
            this.TxtCustomerName.PromptText = "Enter Name...";
            this.TxtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCustomerName.SelectedText = "";
            this.TxtCustomerName.SelectionLength = 0;
            this.TxtCustomerName.SelectionStart = 0;
            this.TxtCustomerName.ShortcutsEnabled = true;
            this.TxtCustomerName.Size = new System.Drawing.Size(771, 30);
            this.TxtCustomerName.TabIndex = 1;
            this.TxtCustomerName.UseSelectable = true;
            this.TxtCustomerName.WaterMark = "Enter Name...";
            this.TxtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAddress
            // 
            this.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtAddress.CustomButton.Image = null;
            this.TxtAddress.CustomButton.Location = new System.Drawing.Point(679, 1);
            this.TxtAddress.CustomButton.Name = "";
            this.TxtAddress.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddress.CustomButton.TabIndex = 1;
            this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddress.CustomButton.UseSelectable = true;
            this.TxtAddress.CustomButton.Visible = false;
            this.TxtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(169, 117);
            this.TxtAddress.MaxLength = 32767;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PromptText = "Enter Address...";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.SelectionLength = 0;
            this.TxtAddress.SelectionStart = 0;
            this.TxtAddress.ShortcutsEnabled = true;
            this.TxtAddress.Size = new System.Drawing.Size(771, 93);
            this.TxtAddress.TabIndex = 2;
            this.TxtAddress.UseSelectable = true;
            this.TxtAddress.WaterMark = "Enter Address...";
            this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(743, 2);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(169, 227);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "Enter E-mail address...";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(771, 30);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "Enter E-mail address...";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtContactNumber
            // 
            // 
            // 
            // 
            this.TxtContactNumber.CustomButton.Image = null;
            this.TxtContactNumber.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.TxtContactNumber.CustomButton.Name = "";
            this.TxtContactNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtContactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContactNumber.CustomButton.TabIndex = 1;
            this.TxtContactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContactNumber.CustomButton.UseSelectable = true;
            this.TxtContactNumber.CustomButton.Visible = false;
            this.TxtContactNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtContactNumber.Lines = new string[0];
            this.TxtContactNumber.Location = new System.Drawing.Point(169, 272);
            this.TxtContactNumber.MaxLength = 32767;
            this.TxtContactNumber.Name = "TxtContactNumber";
            this.TxtContactNumber.PasswordChar = '\0';
            this.TxtContactNumber.PromptText = "Enter Contact number...";
            this.TxtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContactNumber.SelectedText = "";
            this.TxtContactNumber.SelectionLength = 0;
            this.TxtContactNumber.SelectionStart = 0;
            this.TxtContactNumber.ShortcutsEnabled = true;
            this.TxtContactNumber.Size = new System.Drawing.Size(266, 30);
            this.TxtContactNumber.TabIndex = 4;
            this.TxtContactNumber.UseSelectable = true;
            this.TxtContactNumber.WaterMark = "Enter Contact number...";
            this.TxtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContactNumber_KeyPress);
            // 
            // TxtAge
            // 
            this.TxtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtAge.CustomButton.Image = null;
            this.TxtAge.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.TxtAge.CustomButton.Name = "";
            this.TxtAge.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAge.CustomButton.TabIndex = 1;
            this.TxtAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAge.CustomButton.UseSelectable = true;
            this.TxtAge.CustomButton.Visible = false;
            this.TxtAge.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAge.Lines = new string[0];
            this.TxtAge.Location = new System.Drawing.Point(654, 272);
            this.TxtAge.MaxLength = 32767;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.PasswordChar = '\0';
            this.TxtAge.PromptText = "Enter Age...";
            this.TxtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAge.SelectedText = "";
            this.TxtAge.SelectionLength = 0;
            this.TxtAge.SelectionStart = 0;
            this.TxtAge.ShortcutsEnabled = true;
            this.TxtAge.Size = new System.Drawing.Size(286, 30);
            this.TxtAge.TabIndex = 6;
            this.TxtAge.UseSelectable = true;
            this.TxtAge.WaterMark = "Enter Age...";
            this.TxtAge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtProffession
            // 
            this.TxtProffession.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtProffession.CustomButton.Image = null;
            this.TxtProffession.CustomButton.Location = new System.Drawing.Point(238, 2);
            this.TxtProffession.CustomButton.Name = "";
            this.TxtProffession.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtProffession.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProffession.CustomButton.TabIndex = 1;
            this.TxtProffession.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProffession.CustomButton.UseSelectable = true;
            this.TxtProffession.CustomButton.Visible = false;
            this.TxtProffession.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtProffession.Lines = new string[0];
            this.TxtProffession.Location = new System.Drawing.Point(169, 317);
            this.TxtProffession.MaxLength = 32767;
            this.TxtProffession.Name = "TxtProffession";
            this.TxtProffession.PasswordChar = '\0';
            this.TxtProffession.PromptText = "Enter profession...";
            this.TxtProffession.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProffession.SelectedText = "";
            this.TxtProffession.SelectionLength = 0;
            this.TxtProffession.SelectionStart = 0;
            this.TxtProffession.ShortcutsEnabled = true;
            this.TxtProffession.Size = new System.Drawing.Size(266, 30);
            this.TxtProffession.TabIndex = 5;
            this.TxtProffession.UseSelectable = true;
            this.TxtProffession.WaterMark = "Enter profession...";
            this.TxtProffession.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProffession.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbBranch
            // 
            this.CmbBranch.DataSource = this.branchBindingSource;
            this.CmbBranch.DisplayMember = "BranchName";
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.ItemHeight = 24;
            this.CmbBranch.Location = new System.Drawing.Point(654, 317);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(286, 30);
            this.CmbBranch.TabIndex = 7;
            this.CmbBranch.UseSelectable = true;
            this.CmbBranch.ValueMember = "Id";
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(45, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Address";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(45, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "E-Mail";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(45, 272);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Contact Number";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(45, 317);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Profession";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(573, 272);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Age";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(573, 317);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Branch";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Highlight = true;
            this.BtnSave.Location = new System.Drawing.Point(814, 404);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 45);
            this.BtnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseCustomBackColor = true;
            this.BtnSave.UseCustomForeColor = true;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.UseStyleColors = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Highlight = true;
            this.BtnClear.Location = new System.Drawing.Point(682, 404);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(126, 45);
            this.BtnClear.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseCustomBackColor = true;
            this.BtnClear.UseCustomForeColor = true;
            this.BtnClear.UseSelectable = true;
            this.BtnClear.UseStyleColors = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // UI_ADD_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 470);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtProffession);
            this.Controls.Add(this.TxtContactNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lael);
            this.MaximizeBox = false;
            this.Name = "UI_ADD_CUSTOMER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.UI_ADD_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lael;
        private MetroFramework.Controls.MetroTextBox TxtCustomerName;
        private MetroFramework.Controls.MetroTextBox TxtAddress;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtContactNumber;
        private MetroFramework.Controls.MetroTextBox TxtAge;
        private MetroFramework.Controls.MetroTextBox TxtProffession;
        private MetroFramework.Controls.MetroComboBox CmbBranch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnClear;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private technovisionDataSetTableAdapters.branchTableAdapter branchTableAdapter;
    }
}