namespace TechnoVision.view
{
    partial class UI_ADD_ADVANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_ADD_ADVANCE));
            this.BtnAddPayment = new MetroFramework.Controls.MetroButton();
            this.TxtAmount = new MetroFramework.Controls.MetroTextBox();
            this.LblOrderNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblDueAmount = new MetroFramework.Controls.MetroLabel();
            this.LblReceiptNo = new MetroFramework.Controls.MetroLabel();
            this.DateOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BtnAddPayment
            // 
            this.BtnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddPayment.Highlight = true;
            this.BtnAddPayment.Location = new System.Drawing.Point(92, 297);
            this.BtnAddPayment.Name = "BtnAddPayment";
            this.BtnAddPayment.Size = new System.Drawing.Size(261, 45);
            this.BtnAddPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddPayment.TabIndex = 110;
            this.BtnAddPayment.Text = "Add New Payment";
            this.BtnAddPayment.UseCustomBackColor = true;
            this.BtnAddPayment.UseCustomForeColor = true;
            this.BtnAddPayment.UseSelectable = true;
            this.BtnAddPayment.UseStyleColors = true;
            this.BtnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // TxtAmount
            // 
            // 
            // 
            // 
            this.TxtAmount.CustomButton.Image = null;
            this.TxtAmount.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.TxtAmount.CustomButton.Name = "";
            this.TxtAmount.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAmount.CustomButton.TabIndex = 1;
            this.TxtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAmount.CustomButton.UseSelectable = true;
            this.TxtAmount.CustomButton.Visible = false;
            this.TxtAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAmount.Lines = new string[0];
            this.TxtAmount.Location = new System.Drawing.Point(156, 230);
            this.TxtAmount.MaxLength = 32767;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PasswordChar = '\0';
            this.TxtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAmount.SelectedText = "";
            this.TxtAmount.SelectionLength = 0;
            this.TxtAmount.SelectionStart = 0;
            this.TxtAmount.ShortcutsEnabled = true;
            this.TxtAmount.Size = new System.Drawing.Size(290, 35);
            this.TxtAmount.TabIndex = 109;
            this.TxtAmount.UseSelectable = true;
            this.TxtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            // 
            // LblOrderNo
            // 
            this.LblOrderNo.AutoSize = true;
            this.LblOrderNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblOrderNo.Location = new System.Drawing.Point(156, 106);
            this.LblOrderNo.Name = "LblOrderNo";
            this.LblOrderNo.Size = new System.Drawing.Size(74, 20);
            this.LblOrderNo.TabIndex = 108;
            this.LblOrderNo.Text = "Order No";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(28, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 20);
            this.metroLabel1.TabIndex = 101;
            this.metroLabel1.Text = "Receipt Number";
            // 
            // LblDueAmount
            // 
            this.LblDueAmount.AutoSize = true;
            this.LblDueAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDueAmount.Location = new System.Drawing.Point(156, 143);
            this.LblDueAmount.Name = "LblDueAmount";
            this.LblDueAmount.Size = new System.Drawing.Size(123, 20);
            this.LblDueAmount.TabIndex = 107;
            this.LblDueAmount.Text = "Receipt Number";
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblReceiptNo.Location = new System.Drawing.Point(157, 72);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(123, 20);
            this.LblReceiptNo.TabIndex = 100;
            this.LblReceiptNo.Text = "Receipt Number";
            // 
            // DateOrderDate
            // 
            this.DateOrderDate.Location = new System.Drawing.Point(157, 180);
            this.DateOrderDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateOrderDate.Name = "DateOrderDate";
            this.DateOrderDate.Size = new System.Drawing.Size(290, 30);
            this.DateOrderDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOrderDate.TabIndex = 102;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(28, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 20);
            this.metroLabel4.TabIndex = 105;
            this.metroLabel4.Text = "Due Amount";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(28, 237);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 20);
            this.metroLabel5.TabIndex = 103;
            this.metroLabel5.Text = "Payment Amount";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(28, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 20);
            this.metroLabel3.TabIndex = 104;
            this.metroLabel3.Text = "Receipt Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 106;
            this.metroLabel2.Text = "Order No";
            // 
            // UI_ADD_ADVANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 392);
            this.Controls.Add(this.BtnAddPayment);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.LblOrderNo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LblDueAmount);
            this.Controls.Add(this.LblReceiptNo);
            this.Controls.Add(this.DateOrderDate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI_ADD_ADVANCE";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "New Advance Payment";
            this.Load += new System.EventHandler(this.UI_ADD_ADVANCE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnAddPayment;
        private MetroFramework.Controls.MetroTextBox TxtAmount;
        private MetroFramework.Controls.MetroLabel LblOrderNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblDueAmount;
        private MetroFramework.Controls.MetroLabel LblReceiptNo;
        private MetroFramework.Controls.MetroDateTime DateOrderDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}