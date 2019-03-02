namespace TechnoVision.view
{
    partial class UI_EDIT_CUSTOMER
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
            this.BtnDiscard = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.TxtAge = new MetroFramework.Controls.MetroTextBox();
            this.TxtProffession = new MetroFramework.Controls.MetroTextBox();
            this.TxtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.TxtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lael = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LblCustomerId = new MetroFramework.Controls.MetroLabel();
            this.customerTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.customerTableAdapter();
            this.TxtBranch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDiscard
            // 
            this.BtnDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDiscard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDiscard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDiscard.Highlight = true;
            this.BtnDiscard.Location = new System.Drawing.Point(671, 408);
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(126, 45);
            this.BtnDiscard.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnDiscard.TabIndex = 9;
            this.BtnDiscard.Text = "Discard Changes";
            this.BtnDiscard.UseCustomBackColor = true;
            this.BtnDiscard.UseCustomForeColor = true;
            this.BtnDiscard.UseSelectable = true;
            this.BtnDiscard.UseStyleColors = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Highlight = true;
            this.BtnSave.Location = new System.Drawing.Point(803, 408);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 45);
            this.BtnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save Changes";
            this.BtnSave.UseCustomBackColor = true;
            this.BtnSave.UseCustomForeColor = true;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.UseStyleColors = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.TxtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Age", true));
            this.TxtAge.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAge.Lines = new string[0];
            this.TxtAge.Location = new System.Drawing.Point(643, 306);
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
            this.TxtProffession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Profession", true));
            this.TxtProffession.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtProffession.Lines = new string[0];
            this.TxtProffession.Location = new System.Drawing.Point(158, 351);
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
            // TxtContactNumber
            // 
            this.TxtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.TxtContactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.TxtContactNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtContactNumber.Lines = new string[0];
            this.TxtContactNumber.Location = new System.Drawing.Point(158, 306);
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
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.TxtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(158, 261);
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
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.TxtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(158, 151);
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
            this.TxtCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.TxtCustomerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtCustomerName.Lines = new string[0];
            this.TxtCustomerName.Location = new System.Drawing.Point(158, 106);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(562, 351);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Branch";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(562, 306);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Age";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(34, 351);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 20);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Profession";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(34, 306);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Contact Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(34, 261);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 20);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "E-Mail";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(34, 151);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Address";
            // 
            // lael
            // 
            this.lael.AutoSize = true;
            this.lael.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lael.Location = new System.Drawing.Point(34, 111);
            this.lael.Name = "lael";
            this.lael.Size = new System.Drawing.Size(49, 20);
            this.lael.TabIndex = 16;
            this.lael.Text = "Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(34, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 20);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Customer ID";
            // 
            // LblCustomerId
            // 
            this.LblCustomerId.AutoSize = true;
            this.LblCustomerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Id", true));
            this.LblCustomerId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblCustomerId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblCustomerId.Location = new System.Drawing.Point(158, 60);
            this.LblCustomerId.Name = "LblCustomerId";
            this.LblCustomerId.Size = new System.Drawing.Size(116, 25);
            this.LblCustomerId.TabIndex = 16;
            this.LblCustomerId.Text = "Customer ID";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // TxtBranch
            // 
            this.TxtBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtBranch.CustomButton.Image = null;
            this.TxtBranch.CustomButton.Location = new System.Drawing.Point(258, 2);
            this.TxtBranch.CustomButton.Name = "";
            this.TxtBranch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtBranch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBranch.CustomButton.TabIndex = 1;
            this.TxtBranch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBranch.CustomButton.UseSelectable = true;
            this.TxtBranch.CustomButton.Visible = false;
            this.TxtBranch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Branch", true));
            this.TxtBranch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBranch.Lines = new string[0];
            this.TxtBranch.Location = new System.Drawing.Point(643, 342);
            this.TxtBranch.MaxLength = 32767;
            this.TxtBranch.Name = "TxtBranch";
            this.TxtBranch.PasswordChar = '\0';
            this.TxtBranch.PromptText = "Enter Branch...";
            this.TxtBranch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBranch.SelectedText = "";
            this.TxtBranch.SelectionLength = 0;
            this.TxtBranch.SelectionStart = 0;
            this.TxtBranch.ShortcutsEnabled = true;
            this.TxtBranch.Size = new System.Drawing.Size(286, 30);
            this.TxtBranch.TabIndex = 6;
            this.TxtBranch.UseSelectable = true;
            this.TxtBranch.WaterMark = "Enter Branch...";
            this.TxtBranch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBranch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UI_EDIT_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 470);
            this.Controls.Add(this.BtnDiscard);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtBranch);
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
            this.Controls.Add(this.LblCustomerId);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lael);
            this.MaximizeBox = false;
            this.Name = "UI_EDIT_CUSTOMER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit Customer Details";
            this.Load += new System.EventHandler(this.UI_EDIT_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnDiscard;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroTextBox TxtAge;
        private MetroFramework.Controls.MetroTextBox TxtProffession;
        private MetroFramework.Controls.MetroTextBox TxtContactNumber;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtAddress;
        private MetroFramework.Controls.MetroTextBox TxtCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lael;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel LblCustomerId;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private technovisionDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private MetroFramework.Controls.MetroTextBox TxtBranch;
    }
}