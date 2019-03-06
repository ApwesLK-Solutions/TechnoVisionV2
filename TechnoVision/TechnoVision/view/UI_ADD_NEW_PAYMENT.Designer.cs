﻿namespace TechnoVision.view
{
    partial class UI_ADD_NEW_PAYMENT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblReceiptNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DateOrderDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.BtnAddPayment = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridPayementHistory = new MetroFramework.Controls.MetroGrid();
            this.LblOrderNumber = new MetroFramework.Controls.MetroLabel();
            this.LblDueAmount = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayementHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // LblReceiptNo
            // 
            this.LblReceiptNo.AutoSize = true;
            this.LblReceiptNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblReceiptNo.Location = new System.Drawing.Point(147, 34);
            this.LblReceiptNo.Name = "LblReceiptNo";
            this.LblReceiptNo.Size = new System.Drawing.Size(123, 20);
            this.LblReceiptNo.TabIndex = 1;
            this.LblReceiptNo.Text = "Receipt Number";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(18, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Receipt Number";
            // 
            // DateOrderDate
            // 
            this.DateOrderDate.Location = new System.Drawing.Point(146, 160);
            this.DateOrderDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateOrderDate.Name = "DateOrderDate";
            this.DateOrderDate.Size = new System.Drawing.Size(290, 30);
            this.DateOrderDate.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOrderDate.TabIndex = 68;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(12, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 20);
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Receipt Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(18, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Order No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 105);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 20);
            this.metroLabel4.TabIndex = 71;
            this.metroLabel4.Text = "Due Amount";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(12, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 20);
            this.metroLabel5.TabIndex = 71;
            this.metroLabel5.Text = "Pay Amount";
            // 
            // TxtPaymentAmount
            // 
            this.TxtPaymentAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtPaymentAmount.CustomButton.Image = null;
            this.TxtPaymentAmount.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.TxtPaymentAmount.CustomButton.Name = "";
            this.TxtPaymentAmount.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.TxtPaymentAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPaymentAmount.CustomButton.TabIndex = 1;
            this.TxtPaymentAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPaymentAmount.CustomButton.UseSelectable = true;
            this.TxtPaymentAmount.CustomButton.Visible = false;
            this.TxtPaymentAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtPaymentAmount.Lines = new string[0];
            this.TxtPaymentAmount.Location = new System.Drawing.Point(146, 196);
            this.TxtPaymentAmount.MaxLength = 32767;
            this.TxtPaymentAmount.Name = "TxtPaymentAmount";
            this.TxtPaymentAmount.PasswordChar = '\0';
            this.TxtPaymentAmount.ReadOnly = true;
            this.TxtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPaymentAmount.SelectedText = "";
            this.TxtPaymentAmount.SelectionLength = 0;
            this.TxtPaymentAmount.SelectionStart = 0;
            this.TxtPaymentAmount.ShortcutsEnabled = true;
            this.TxtPaymentAmount.Size = new System.Drawing.Size(290, 36);
            this.TxtPaymentAmount.TabIndex = 74;
            this.TxtPaymentAmount.UseSelectable = true;
            this.TxtPaymentAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPaymentAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAddPayment
            // 
            this.BtnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddPayment.Highlight = true;
            this.BtnAddPayment.Location = new System.Drawing.Point(138, 271);
            this.BtnAddPayment.Name = "BtnAddPayment";
            this.BtnAddPayment.Size = new System.Drawing.Size(177, 45);
            this.BtnAddPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddPayment.TabIndex = 75;
            this.BtnAddPayment.Text = "Add New Payment";
            this.BtnAddPayment.UseCustomBackColor = true;
            this.BtnAddPayment.UseCustomForeColor = true;
            this.BtnAddPayment.UseSelectable = true;
            this.BtnAddPayment.UseStyleColors = true;
            this.BtnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDueAmount);
            this.groupBox1.Controls.Add(this.LblOrderNumber);
            this.groupBox1.Controls.Add(this.LblReceiptNo);
            this.groupBox1.Controls.Add(this.BtnAddPayment);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.TxtPaymentAmount);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.DateOrderDate);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 331);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridPayementHistory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 331);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment History";
            // 
            // GridPayementHistory
            // 
            this.GridPayementHistory.AllowUserToResizeRows = false;
            this.GridPayementHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayementHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayementHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayementHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayementHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPayementHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayementHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPayementHistory.EnableHeadersVisualStyles = false;
            this.GridPayementHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayementHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayementHistory.Location = new System.Drawing.Point(7, 27);
            this.GridPayementHistory.Name = "GridPayementHistory";
            this.GridPayementHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayementHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPayementHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayementHistory.RowTemplate.Height = 24;
            this.GridPayementHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayementHistory.Size = new System.Drawing.Size(614, 298);
            this.GridPayementHistory.TabIndex = 0;
            // 
            // LblOrderNumber
            // 
            this.LblOrderNumber.AutoSize = true;
            this.LblOrderNumber.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblOrderNumber.Location = new System.Drawing.Point(147, 68);
            this.LblOrderNumber.Name = "LblOrderNumber";
            this.LblOrderNumber.Size = new System.Drawing.Size(123, 20);
            this.LblOrderNumber.TabIndex = 76;
            this.LblOrderNumber.Text = "Receipt Number";
            // 
            // LblDueAmount
            // 
            this.LblDueAmount.AutoSize = true;
            this.LblDueAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblDueAmount.Location = new System.Drawing.Point(146, 105);
            this.LblDueAmount.Name = "LblDueAmount";
            this.LblDueAmount.Size = new System.Drawing.Size(123, 20);
            this.LblDueAmount.TabIndex = 76;
            this.LblDueAmount.Text = "Receipt Number";
            // 
            // UI_ADD_NEW_PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UI_ADD_NEW_PAYMENT";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add New Payment";
            this.Load += new System.EventHandler(this.UI_ADD_NEW_PAYMENT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPayementHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblReceiptNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DateOrderDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtPaymentAmount;
        private MetroFramework.Controls.MetroButton BtnAddPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid GridPayementHistory;
        private MetroFramework.Controls.MetroLabel LblOrderNumber;
        private MetroFramework.Controls.MetroLabel LblDueAmount;
    }
}