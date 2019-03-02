namespace TechnoVision.view
{
    partial class UI_SPECTACLES_FORM_ONE
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
            this.BtnClear = new MetroFramework.Controls.MetroButton();
            this.BtnNext = new MetroFramework.Controls.MetroButton();
            this.BtnCalculate = new MetroFramework.Controls.MetroTile();
            this.CmbTestedBy = new MetroFramework.Controls.MetroComboBox();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.CmbOrderStatus = new MetroFramework.Controls.MetroComboBox();
            this.CmbPaymentPlan = new MetroFramework.Controls.MetroComboBox();
            this.CmbPaymentMethod = new MetroFramework.Controls.MetroComboBox();
            this.DateDueDate = new MetroFramework.Controls.MetroDateTime();
            this.DateOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.TxtBalance = new MetroFramework.Controls.MetroTextBox();
            this.TxtAdvance = new MetroFramework.Controls.MetroTextBox();
            this.TxtRemindDays = new MetroFramework.Controls.MetroTextBox();
            this.TxtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.TxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.TxtOrderNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtLenseAmount = new MetroFramework.Controls.MetroTextBox();
            this.TxtEyeWearAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LblReceiptNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.testersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.testersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Highlight = true;
            this.BtnClear.Location = new System.Drawing.Point(668, 375);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(118, 45);
            this.BtnClear.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseCustomBackColor = true;
            this.BtnClear.UseCustomForeColor = true;
            this.BtnClear.UseSelectable = true;
            this.BtnClear.UseStyleColors = true;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNext.Highlight = true;
            this.BtnNext.Location = new System.Drawing.Point(792, 375);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(118, 45);
            this.BtnNext.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnNext.TabIndex = 14;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseCustomBackColor = true;
            this.BtnNext.UseCustomForeColor = true;
            this.BtnNext.UseSelectable = true;
            this.BtnNext.UseStyleColors = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.ActiveControl = null;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.Location = new System.Drawing.Point(872, 298);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(38, 36);
            this.BtnCalculate.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCalculate.TabIndex = 13;
            this.BtnCalculate.UseSelectable = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // CmbTestedBy
            // 
            this.CmbTestedBy.DataSource = this.testersBindingSource;
            this.CmbTestedBy.DisplayMember = "Name";
            this.CmbTestedBy.FormattingEnabled = true;
            this.CmbTestedBy.ItemHeight = 24;
            this.CmbTestedBy.Location = new System.Drawing.Point(161, 239);
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
            // CmbOrderStatus
            // 
            this.CmbOrderStatus.FormattingEnabled = true;
            this.CmbOrderStatus.ItemHeight = 24;
            this.CmbOrderStatus.Items.AddRange(new object[] {
            "PENDING",
            "DELEVERD"});
            this.CmbOrderStatus.Location = new System.Drawing.Point(161, 203);
            this.CmbOrderStatus.Name = "CmbOrderStatus";
            this.CmbOrderStatus.Size = new System.Drawing.Size(290, 30);
            this.CmbOrderStatus.TabIndex = 3;
            this.CmbOrderStatus.UseSelectable = true;
            // 
            // CmbPaymentPlan
            // 
            this.CmbPaymentPlan.FormattingEnabled = true;
            this.CmbPaymentPlan.ItemHeight = 24;
            this.CmbPaymentPlan.Items.AddRange(new object[] {
            "FULL PAYMENT",
            "INSTALLAMENT"});
            this.CmbPaymentPlan.Location = new System.Drawing.Point(161, 353);
            this.CmbPaymentPlan.Name = "CmbPaymentPlan";
            this.CmbPaymentPlan.Size = new System.Drawing.Size(290, 30);
            this.CmbPaymentPlan.TabIndex = 7;
            this.CmbPaymentPlan.UseSelectable = true;
            // 
            // CmbPaymentMethod
            // 
            this.CmbPaymentMethod.FormattingEnabled = true;
            this.CmbPaymentMethod.ItemHeight = 24;
            this.CmbPaymentMethod.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD",
            "DEBIT CARD"});
            this.CmbPaymentMethod.Location = new System.Drawing.Point(161, 317);
            this.CmbPaymentMethod.Name = "CmbPaymentMethod";
            this.CmbPaymentMethod.Size = new System.Drawing.Size(290, 30);
            this.CmbPaymentMethod.TabIndex = 6;
            this.CmbPaymentMethod.UseSelectable = true;
            // 
            // DateDueDate
            // 
            this.DateDueDate.Location = new System.Drawing.Point(161, 167);
            this.DateDueDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateDueDate.Name = "DateDueDate";
            this.DateDueDate.Size = new System.Drawing.Size(290, 30);
            this.DateDueDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateDueDate.TabIndex = 2;
            // 
            // DateOrderDate
            // 
            this.DateOrderDate.Location = new System.Drawing.Point(161, 131);
            this.DateOrderDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateOrderDate.Name = "DateOrderDate";
            this.DateOrderDate.Size = new System.Drawing.Size(290, 30);
            this.DateOrderDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOrderDate.TabIndex = 1;
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
            this.TxtBalance.Location = new System.Drawing.Point(620, 298);
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
            this.TxtBalance.TabIndex = 95;
            this.TxtBalance.Text = "0";
            this.TxtBalance.UseSelectable = true;
            this.TxtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.TxtAdvance.Location = new System.Drawing.Point(620, 254);
            this.TxtAdvance.MaxLength = 32767;
            this.TxtAdvance.Name = "TxtAdvance";
            this.TxtAdvance.PasswordChar = '\0';
            this.TxtAdvance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAdvance.SelectedText = "";
            this.TxtAdvance.SelectionLength = 0;
            this.TxtAdvance.SelectionStart = 0;
            this.TxtAdvance.ShortcutsEnabled = true;
            this.TxtAdvance.Size = new System.Drawing.Size(290, 36);
            this.TxtAdvance.TabIndex = 12;
            this.TxtAdvance.Text = "0";
            this.TxtAdvance.UseSelectable = true;
            this.TxtAdvance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAdvance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.TxtRemindDays.Location = new System.Drawing.Point(161, 275);
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
            this.TxtDiscount.Location = new System.Drawing.Point(620, 213);
            this.TxtDiscount.MaxLength = 32767;
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.PasswordChar = '\0';
            this.TxtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDiscount.SelectedText = "";
            this.TxtDiscount.SelectionLength = 0;
            this.TxtDiscount.SelectionStart = 0;
            this.TxtDiscount.ShortcutsEnabled = true;
            this.TxtDiscount.Size = new System.Drawing.Size(290, 36);
            this.TxtDiscount.TabIndex = 11;
            this.TxtDiscount.Text = "0";
            this.TxtDiscount.UseSelectable = true;
            this.TxtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtTotal
            // 
            this.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtTotal.CustomButton.Image = null;
            this.TxtTotal.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtTotal.CustomButton.Name = "";
            this.TxtTotal.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTotal.CustomButton.TabIndex = 1;
            this.TxtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTotal.CustomButton.UseSelectable = true;
            this.TxtTotal.CustomButton.Visible = false;
            this.TxtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtTotal.Lines = new string[] {
        "0"};
            this.TxtTotal.Location = new System.Drawing.Point(620, 173);
            this.TxtTotal.MaxLength = 32767;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.ShortcutsEnabled = true;
            this.TxtTotal.Size = new System.Drawing.Size(290, 36);
            this.TxtTotal.TabIndex = 10;
            this.TxtTotal.Text = "0";
            this.TxtTotal.UseSelectable = true;
            this.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.TxtOrderNo.Location = new System.Drawing.Point(161, 91);
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
            this.TxtOrderNo.TabIndex = 69;
            this.TxtOrderNo.UseSelectable = true;
            this.TxtOrderNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtOrderNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(486, 306);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 20);
            this.metroLabel12.TabIndex = 81;
            this.metroLabel12.Text = "Balance";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(486, 221);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(67, 20);
            this.metroLabel14.TabIndex = 71;
            this.metroLabel14.Text = "Discount";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(486, 262);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(66, 20);
            this.metroLabel11.TabIndex = 73;
            this.metroLabel11.Text = "Advance";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(486, 181);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(42, 20);
            this.metroLabel10.TabIndex = 77;
            this.metroLabel10.Text = "Total";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(28, 358);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(97, 20);
            this.metroLabel9.TabIndex = 78;
            this.metroLabel9.Text = "Payment Plan";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(27, 322);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(121, 20);
            this.metroLabel8.TabIndex = 79;
            this.metroLabel8.Text = "Payment Method";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(27, 283);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(117, 20);
            this.metroLabel13.TabIndex = 80;
            this.metroLabel13.Text = "Reminding Days";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(27, 244);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 72;
            this.metroLabel7.Text = "Tested By";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(28, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 20);
            this.metroLabel6.TabIndex = 69;
            this.metroLabel6.Text = "Order Status";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(27, 172);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 20);
            this.metroLabel4.TabIndex = 74;
            this.metroLabel4.Text = "Due Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(28, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 20);
            this.metroLabel3.TabIndex = 70;
            this.metroLabel3.Text = "Order Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 96;
            this.metroLabel2.Text = "Order No";
            // 
            // TxtLenseAmount
            // 
            this.TxtLenseAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtLenseAmount.CustomButton.Image = null;
            this.TxtLenseAmount.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtLenseAmount.CustomButton.Name = "";
            this.TxtLenseAmount.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtLenseAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLenseAmount.CustomButton.TabIndex = 1;
            this.TxtLenseAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLenseAmount.CustomButton.UseSelectable = true;
            this.TxtLenseAmount.CustomButton.Visible = false;
            this.TxtLenseAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtLenseAmount.Lines = new string[] {
        "0"};
            this.TxtLenseAmount.Location = new System.Drawing.Point(620, 131);
            this.TxtLenseAmount.MaxLength = 32767;
            this.TxtLenseAmount.Name = "TxtLenseAmount";
            this.TxtLenseAmount.PasswordChar = '\0';
            this.TxtLenseAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLenseAmount.SelectedText = "";
            this.TxtLenseAmount.SelectionLength = 0;
            this.TxtLenseAmount.SelectionStart = 0;
            this.TxtLenseAmount.ShortcutsEnabled = true;
            this.TxtLenseAmount.Size = new System.Drawing.Size(290, 36);
            this.TxtLenseAmount.TabIndex = 9;
            this.TxtLenseAmount.Text = "0";
            this.TxtLenseAmount.UseSelectable = true;
            this.TxtLenseAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLenseAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEyeWearAmount
            // 
            this.TxtEyeWearAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtEyeWearAmount.CustomButton.Image = null;
            this.TxtEyeWearAmount.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtEyeWearAmount.CustomButton.Name = "";
            this.TxtEyeWearAmount.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtEyeWearAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEyeWearAmount.CustomButton.TabIndex = 1;
            this.TxtEyeWearAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEyeWearAmount.CustomButton.UseSelectable = true;
            this.TxtEyeWearAmount.CustomButton.Visible = false;
            this.TxtEyeWearAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtEyeWearAmount.Lines = new string[] {
        "0"};
            this.TxtEyeWearAmount.Location = new System.Drawing.Point(620, 91);
            this.TxtEyeWearAmount.MaxLength = 32767;
            this.TxtEyeWearAmount.Name = "TxtEyeWearAmount";
            this.TxtEyeWearAmount.PasswordChar = '\0';
            this.TxtEyeWearAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEyeWearAmount.SelectedText = "";
            this.TxtEyeWearAmount.SelectionLength = 0;
            this.TxtEyeWearAmount.SelectionStart = 0;
            this.TxtEyeWearAmount.ShortcutsEnabled = true;
            this.TxtEyeWearAmount.Size = new System.Drawing.Size(290, 36);
            this.TxtEyeWearAmount.TabIndex = 8;
            this.TxtEyeWearAmount.Text = "0";
            this.TxtEyeWearAmount.UseSelectable = true;
            this.TxtEyeWearAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEyeWearAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(486, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 20);
            this.metroLabel1.TabIndex = 77;
            this.metroLabel1.Text = "Lense Amount";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(486, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 20);
            this.metroLabel5.TabIndex = 77;
            this.metroLabel5.Text = "Eye Wear";
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblReceiptNo.Location = new System.Drawing.Point(787, 46);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(123, 20);
            this.LblReceiptNo.TabIndex = 97;
            this.LblReceiptNo.Text = "Receipt Number";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(658, 46);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(123, 20);
            this.metroLabel15.TabIndex = 98;
            this.metroLabel15.Text = "Receipt Number";
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // UI_SPECTACLES_FORM_ONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 440);
            this.Controls.Add(this.LblReceiptNo);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.CmbTestedBy);
            this.Controls.Add(this.CmbOrderStatus);
            this.Controls.Add(this.CmbPaymentPlan);
            this.Controls.Add(this.CmbPaymentMethod);
            this.Controls.Add(this.DateDueDate);
            this.Controls.Add(this.DateOrderDate);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtAdvance);
            this.Controls.Add(this.TxtRemindDays);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.TxtEyeWearAmount);
            this.Controls.Add(this.TxtLenseAmount);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtOrderNo);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.Name = "UI_SPECTACLES_FORM_ONE";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Spectacles Order Summary";
            this.Load += new System.EventHandler(this.UI_SPECTACLES_FORM_ONE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnClear;
        private MetroFramework.Controls.MetroButton BtnNext;
        private MetroFramework.Controls.MetroTile BtnCalculate;
        private MetroFramework.Controls.MetroComboBox CmbTestedBy;
        private MetroFramework.Controls.MetroComboBox CmbOrderStatus;
        private MetroFramework.Controls.MetroComboBox CmbPaymentPlan;
        private MetroFramework.Controls.MetroComboBox CmbPaymentMethod;
        private MetroFramework.Controls.MetroDateTime DateDueDate;
        private MetroFramework.Controls.MetroDateTime DateOrderDate;
        private MetroFramework.Controls.MetroTextBox TxtBalance;
        private MetroFramework.Controls.MetroTextBox TxtAdvance;
        private MetroFramework.Controls.MetroTextBox TxtRemindDays;
        private MetroFramework.Controls.MetroTextBox TxtDiscount;
        private MetroFramework.Controls.MetroTextBox TxtTotal;
        private MetroFramework.Controls.MetroTextBox TxtOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtLenseAmount;
        private MetroFramework.Controls.MetroTextBox TxtEyeWearAmount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel LblReceiptNo;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
    }
}