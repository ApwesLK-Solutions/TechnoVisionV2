﻿namespace TechnoVision.view
{
    partial class UI_CONTACT_LENSE_FORM_ONE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_CONTACT_LENSE_FORM_ONE));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblReceiptNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtOrderNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.TxtLensesTotal = new MetroFramework.Controls.MetroTextBox();
            this.TxtAdvance = new MetroFramework.Controls.MetroTextBox();
            this.TxtBalance = new MetroFramework.Controls.MetroTextBox();
            this.DateOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.DateDueDate = new MetroFramework.Controls.MetroDateTime();
            this.CmbJobType = new MetroFramework.Controls.MetroComboBox();
            this.CmbOrderStatus = new MetroFramework.Controls.MetroComboBox();
            this.CmbTestedBy = new MetroFramework.Controls.MetroComboBox();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.CmbPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.CmbPaymentPlan = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.TxtRemindDays = new MetroFramework.Controls.MetroTextBox();
            this.BtnCalculate = new MetroFramework.Controls.MetroTile();
            this.BtnNext = new MetroFramework.Controls.MetroButton();
            this.BtnClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TxtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.testersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.testersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(535, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Receipt Number";
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblReceiptNo.Location = new System.Drawing.Point(727, 34);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(123, 20);
            this.LblReceiptNo.TabIndex = 0;
            this.LblReceiptNo.Text = "Receipt Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(33, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "Order No";
            // 
            // TxtOrderNo
            // 
            this.TxtOrderNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtOrderNo.CustomButton.Image = null;
            this.TxtOrderNo.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtOrderNo.CustomButton.Name = "";
            this.TxtOrderNo.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtOrderNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtOrderNo.CustomButton.TabIndex = 1;
            this.TxtOrderNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtOrderNo.CustomButton.UseSelectable = true;
            this.TxtOrderNo.CustomButton.Visible = false;
            this.TxtOrderNo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtOrderNo.Lines = new string[0];
            this.TxtOrderNo.Location = new System.Drawing.Point(195, 96);
            this.TxtOrderNo.MaxLength = 32767;
            this.TxtOrderNo.Name = "TxtOrderNo";
            this.TxtOrderNo.PasswordChar = '\0';
            this.TxtOrderNo.ReadOnly = true;
            this.TxtOrderNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtOrderNo.SelectedText = "";
            this.TxtOrderNo.SelectionLength = 0;
            this.TxtOrderNo.SelectionStart = 0;
            this.TxtOrderNo.ShortcutsEnabled = true;
            this.TxtOrderNo.Size = new System.Drawing.Size(290, 36);
            this.TxtOrderNo.TabIndex = 24;
            this.TxtOrderNo.UseSelectable = true;
            this.TxtOrderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtOrderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(33, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 20);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Order Date";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(32, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 20);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Due Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(33, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 20);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Job Type";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(33, 275);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 20);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Order Status";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(32, 317);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Tested By";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(493, 107);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(121, 20);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Payment Method";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(493, 149);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(97, 20);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Payment Plan";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(493, 189);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 20);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Lenses Total";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(493, 270);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(66, 20);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Advance";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(493, 314);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 20);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Balance";
            // 
            // TxtLensesTotal
            // 
            this.TxtLensesTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtLensesTotal.CustomButton.Image = null;
            this.TxtLensesTotal.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtLensesTotal.CustomButton.Name = "";
            this.TxtLensesTotal.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtLensesTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLensesTotal.CustomButton.TabIndex = 1;
            this.TxtLensesTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLensesTotal.CustomButton.UseSelectable = true;
            this.TxtLensesTotal.CustomButton.Visible = false;
            this.TxtLensesTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtLensesTotal.Lines = new string[] {
        "0"};
            this.TxtLensesTotal.Location = new System.Drawing.Point(662, 181);
            this.TxtLensesTotal.MaxLength = 32767;
            this.TxtLensesTotal.Name = "TxtLensesTotal";
            this.TxtLensesTotal.PasswordChar = '\0';
            this.TxtLensesTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLensesTotal.SelectedText = "";
            this.TxtLensesTotal.SelectionLength = 0;
            this.TxtLensesTotal.SelectionStart = 0;
            this.TxtLensesTotal.ShortcutsEnabled = true;
            this.TxtLensesTotal.Size = new System.Drawing.Size(290, 36);
            this.TxtLensesTotal.TabIndex = 8;
            this.TxtLensesTotal.Text = "0";
            this.TxtLensesTotal.UseSelectable = true;
            this.TxtLensesTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLensesTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtLensesTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLensesTotal_KeyPress);
            // 
            // TxtAdvance
            // 
            this.TxtAdvance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtAdvance.CustomButton.Image = null;
            this.TxtAdvance.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtAdvance.CustomButton.Name = "";
            this.TxtAdvance.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtAdvance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAdvance.CustomButton.TabIndex = 1;
            this.TxtAdvance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAdvance.CustomButton.UseSelectable = true;
            this.TxtAdvance.CustomButton.Visible = false;
            this.TxtAdvance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAdvance.Lines = new string[] {
        "0"};
            this.TxtAdvance.Location = new System.Drawing.Point(662, 262);
            this.TxtAdvance.MaxLength = 32767;
            this.TxtAdvance.Name = "TxtAdvance";
            this.TxtAdvance.PasswordChar = '\0';
            this.TxtAdvance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAdvance.SelectedText = "";
            this.TxtAdvance.SelectionLength = 0;
            this.TxtAdvance.SelectionStart = 0;
            this.TxtAdvance.ShortcutsEnabled = true;
            this.TxtAdvance.Size = new System.Drawing.Size(290, 36);
            this.TxtAdvance.TabIndex = 10;
            this.TxtAdvance.Text = "0";
            this.TxtAdvance.UseSelectable = true;
            this.TxtAdvance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAdvance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAdvance_KeyPress);
            // 
            // TxtBalance
            // 
            this.TxtBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtBalance.CustomButton.Image = null;
            this.TxtBalance.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.TxtBalance.CustomButton.Name = "";
            this.TxtBalance.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBalance.CustomButton.TabIndex = 1;
            this.TxtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBalance.CustomButton.UseSelectable = true;
            this.TxtBalance.CustomButton.Visible = false;
            this.TxtBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBalance.Lines = new string[] {
        "0"};
            this.TxtBalance.Location = new System.Drawing.Point(662, 306);
            this.TxtBalance.MaxLength = 32767;
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.PasswordChar = '\0';
            this.TxtBalance.ReadOnly = true;
            this.TxtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBalance.SelectedText = "";
            this.TxtBalance.SelectionLength = 0;
            this.TxtBalance.SelectionStart = 0;
            this.TxtBalance.ShortcutsEnabled = true;
            this.TxtBalance.Size = new System.Drawing.Size(254, 36);
            this.TxtBalance.TabIndex = 25;
            this.TxtBalance.Text = "0";
            this.TxtBalance.UseSelectable = true;
            this.TxtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DateOrderDate
            // 
            this.DateOrderDate.Location = new System.Drawing.Point(195, 141);
            this.DateOrderDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateOrderDate.Name = "DateOrderDate";
            this.DateOrderDate.Size = new System.Drawing.Size(290, 30);
            this.DateOrderDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOrderDate.TabIndex = 0;
            // 
            // DateDueDate
            // 
            this.DateDueDate.Location = new System.Drawing.Point(195, 181);
            this.DateDueDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateDueDate.Name = "DateDueDate";
            this.DateDueDate.Size = new System.Drawing.Size(290, 30);
            this.DateDueDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateDueDate.TabIndex = 1;
            // 
            // CmbJobType
            // 
            this.CmbJobType.FormattingEnabled = true;
            this.CmbJobType.ItemHeight = 24;
            this.CmbJobType.Items.AddRange(new object[] {
            "NEW",
            "REPLACEMENT"});
            this.CmbJobType.Location = new System.Drawing.Point(195, 223);
            this.CmbJobType.Name = "CmbJobType";
            this.CmbJobType.Size = new System.Drawing.Size(290, 30);
            this.CmbJobType.TabIndex = 2;
            this.CmbJobType.UseSelectable = true;
            // 
            // CmbOrderStatus
            // 
            this.CmbOrderStatus.FormattingEnabled = true;
            this.CmbOrderStatus.ItemHeight = 24;
            this.CmbOrderStatus.Items.AddRange(new object[] {
            "PENDING",
            "DELEVERED"});
            this.CmbOrderStatus.Location = new System.Drawing.Point(195, 267);
            this.CmbOrderStatus.Name = "CmbOrderStatus";
            this.CmbOrderStatus.Size = new System.Drawing.Size(290, 30);
            this.CmbOrderStatus.TabIndex = 3;
            this.CmbOrderStatus.UseSelectable = true;
            // 
            // CmbTestedBy
            // 
            this.CmbTestedBy.DataSource = this.testersBindingSource;
            this.CmbTestedBy.DisplayMember = "Name";
            this.CmbTestedBy.FormattingEnabled = true;
            this.CmbTestedBy.ItemHeight = 24;
            this.CmbTestedBy.Location = new System.Drawing.Point(195, 309);
            this.CmbTestedBy.Name = "CmbTestedBy";
            this.CmbTestedBy.Size = new System.Drawing.Size(290, 30);
            this.CmbTestedBy.TabIndex = 4;
            this.CmbTestedBy.UseSelectable = true;
            this.CmbTestedBy.ValueMember = "Name";
            // 
            // testersBindingSource
            // 
            this.testersBindingSource.DataMember = "testers";
            this.testersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CmbPaymentMethod
            // 
            this.CmbPaymentMethod.FormattingEnabled = true;
            this.CmbPaymentMethod.ItemHeight = 24;
            this.CmbPaymentMethod.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD",
            "DEBIT CARD",
            "N-C",
            "UNKNOWN"});
            this.CmbPaymentMethod.Location = new System.Drawing.Point(662, 102);
            this.CmbPaymentMethod.Name = "CmbPaymentMethod";
            this.CmbPaymentMethod.Size = new System.Drawing.Size(288, 30);
            this.CmbPaymentMethod.TabIndex = 6;
            this.CmbPaymentMethod.UseSelectable = true;
            // 
            // CmbPaymentPlan
            // 
            this.CmbPaymentPlan.FormattingEnabled = true;
            this.CmbPaymentPlan.ItemHeight = 24;
            this.CmbPaymentPlan.Items.AddRange(new object[] {
            "FULL PAYMENT",
            "INSTALLAMENT"});
            this.CmbPaymentPlan.Location = new System.Drawing.Point(662, 144);
            this.CmbPaymentPlan.Name = "CmbPaymentPlan";
            this.CmbPaymentPlan.Size = new System.Drawing.Size(290, 30);
            this.CmbPaymentPlan.TabIndex = 7;
            this.CmbPaymentPlan.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(32, 365);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(117, 20);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Reminding Days";
            // 
            // TxtRemindDays
            // 
            this.TxtRemindDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtRemindDays.CustomButton.Image = null;
            this.TxtRemindDays.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtRemindDays.CustomButton.Name = "";
            this.TxtRemindDays.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtRemindDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRemindDays.CustomButton.TabIndex = 1;
            this.TxtRemindDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRemindDays.CustomButton.UseSelectable = true;
            this.TxtRemindDays.CustomButton.Visible = false;
            this.TxtRemindDays.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtRemindDays.Lines = new string[0];
            this.TxtRemindDays.Location = new System.Drawing.Point(195, 354);
            this.TxtRemindDays.MaxLength = 32767;
            this.TxtRemindDays.Name = "TxtRemindDays";
            this.TxtRemindDays.PasswordChar = '\0';
            this.TxtRemindDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRemindDays.SelectedText = "";
            this.TxtRemindDays.SelectionLength = 0;
            this.TxtRemindDays.SelectionStart = 0;
            this.TxtRemindDays.ShortcutsEnabled = true;
            this.TxtRemindDays.Size = new System.Drawing.Size(290, 36);
            this.TxtRemindDays.TabIndex = 5;
            this.TxtRemindDays.UseSelectable = true;
            this.TxtRemindDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRemindDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRemindDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRemindDays_KeyPress);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.ActiveControl = null;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.Location = new System.Drawing.Point(914, 306);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(38, 36);
            this.BtnCalculate.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCalculate.TabIndex = 11;
            this.BtnCalculate.TileImage = global::TechnoVision.Properties.Resources.cal_GUh_icon;
            this.BtnCalculate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCalculate.UseSelectable = true;
            this.BtnCalculate.UseTileImage = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNext.Highlight = true;
            this.BtnNext.Location = new System.Drawing.Point(832, 372);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(118, 45);
            this.BtnNext.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnNext.TabIndex = 12;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseCustomBackColor = true;
            this.BtnNext.UseCustomForeColor = true;
            this.BtnNext.UseSelectable = true;
            this.BtnNext.UseStyleColors = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Highlight = true;
            this.BtnClear.Location = new System.Drawing.Point(708, 372);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(118, 45);
            this.BtnClear.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseCustomBackColor = true;
            this.BtnClear.UseCustomForeColor = true;
            this.BtnClear.UseSelectable = true;
            this.BtnClear.UseStyleColors = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(493, 229);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(67, 20);
            this.metroLabel14.TabIndex = 1;
            this.metroLabel14.Text = "Discount";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtDiscount.CustomButton.Image = null;
            this.TxtDiscount.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtDiscount.CustomButton.Name = "";
            this.TxtDiscount.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDiscount.CustomButton.TabIndex = 1;
            this.TxtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDiscount.CustomButton.UseSelectable = true;
            this.TxtDiscount.CustomButton.Visible = false;
            this.TxtDiscount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtDiscount.Lines = new string[] {
        "0"};
            this.TxtDiscount.Location = new System.Drawing.Point(662, 221);
            this.TxtDiscount.MaxLength = 32767;
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.PasswordChar = '\0';
            this.TxtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDiscount.SelectedText = "";
            this.TxtDiscount.SelectionLength = 0;
            this.TxtDiscount.SelectionStart = 0;
            this.TxtDiscount.ShortcutsEnabled = true;
            this.TxtDiscount.Size = new System.Drawing.Size(290, 36);
            this.TxtDiscount.TabIndex = 9;
            this.TxtDiscount.Text = "0";
            this.TxtDiscount.UseSelectable = true;
            this.TxtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDiscount_KeyPress);
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // UI_CONTACT_LENSE_FORM_ONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 440);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.CmbTestedBy);
            this.Controls.Add(this.CmbOrderStatus);
            this.Controls.Add(this.CmbPaymentPlan);
            this.Controls.Add(this.CmbPaymentMethod);
            this.Controls.Add(this.CmbJobType);
            this.Controls.Add(this.DateDueDate);
            this.Controls.Add(this.DateOrderDate);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtAdvance);
            this.Controls.Add(this.TxtRemindDays);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.TxtLensesTotal);
            this.Controls.Add(this.TxtOrderNo);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LblReceiptNo);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI_CONTACT_LENSE_FORM_ONE";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Contact Lenses - Order Summary";
            this.Load += new System.EventHandler(this.UI_CONTACT_LENSE_FORM_ONE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblReceiptNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox TxtLensesTotal;
        private MetroFramework.Controls.MetroTextBox TxtAdvance;
        private MetroFramework.Controls.MetroTextBox TxtBalance;
        private MetroFramework.Controls.MetroDateTime DateOrderDate;
        private MetroFramework.Controls.MetroDateTime DateDueDate;
        private MetroFramework.Controls.MetroComboBox CmbJobType;
        private MetroFramework.Controls.MetroComboBox CmbOrderStatus;
        private MetroFramework.Controls.MetroComboBox CmbTestedBy;
        private MetroFramework.Controls.MetroComboBox CmbPaymentMethod;
        private MetroFramework.Controls.MetroComboBox CmbPaymentPlan;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox TxtRemindDays;
        private MetroFramework.Controls.MetroTile BtnCalculate;
        private MetroFramework.Controls.MetroButton BtnNext;
        private MetroFramework.Controls.MetroButton BtnClear;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox TxtDiscount;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
    }
}