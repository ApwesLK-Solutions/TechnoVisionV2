namespace TechnoVision.view
{
    partial class UI_PAYMENT_VIEWER
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
            this.BtnRefresh = new MetroFramework.Controls.MetroButton();
            this.BtnNewPayment = new MetroFramework.Controls.MetroButton();
            this.BtnPrintReceipt = new MetroFramework.Controls.MetroButton();
            this.TxtSearchReceipt = new MetroFramework.Controls.MetroTextBox();
            this.GridPayments = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GridPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRefresh.Highlight = true;
            this.BtnRefresh.Location = new System.Drawing.Point(641, 626);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(106, 45);
            this.BtnRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCustomBackColor = true;
            this.BtnRefresh.UseCustomForeColor = true;
            this.BtnRefresh.UseSelectable = true;
            this.BtnRefresh.UseStyleColors = true;
            // 
            // BtnNewPayment
            // 
            this.BtnNewPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnNewPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewPayment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnNewPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewPayment.Highlight = true;
            this.BtnNewPayment.Location = new System.Drawing.Point(753, 626);
            this.BtnNewPayment.Name = "BtnNewPayment";
            this.BtnNewPayment.Size = new System.Drawing.Size(173, 45);
            this.BtnNewPayment.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnNewPayment.TabIndex = 6;
            this.BtnNewPayment.Text = "Make New Payment";
            this.BtnNewPayment.UseCustomBackColor = true;
            this.BtnNewPayment.UseCustomForeColor = true;
            this.BtnNewPayment.UseSelectable = true;
            this.BtnNewPayment.UseStyleColors = true;
            // 
            // BtnPrintReceipt
            // 
            this.BtnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintReceipt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnPrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrintReceipt.Highlight = true;
            this.BtnPrintReceipt.Location = new System.Drawing.Point(932, 626);
            this.BtnPrintReceipt.Name = "BtnPrintReceipt";
            this.BtnPrintReceipt.Size = new System.Drawing.Size(173, 45);
            this.BtnPrintReceipt.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnPrintReceipt.TabIndex = 7;
            this.BtnPrintReceipt.Text = "Print Receipt";
            this.BtnPrintReceipt.UseCustomBackColor = true;
            this.BtnPrintReceipt.UseCustomForeColor = true;
            this.BtnPrintReceipt.UseSelectable = true;
            this.BtnPrintReceipt.UseStyleColors = true;
            // 
            // TxtSearchReceipt
            // 
            // 
            // 
            // 
            this.TxtSearchReceipt.CustomButton.Image = null;
            this.TxtSearchReceipt.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.TxtSearchReceipt.CustomButton.Name = "";
            this.TxtSearchReceipt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtSearchReceipt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearchReceipt.CustomButton.TabIndex = 1;
            this.TxtSearchReceipt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearchReceipt.CustomButton.UseSelectable = true;
            this.TxtSearchReceipt.CustomButton.Visible = false;
            this.TxtSearchReceipt.DisplayIcon = true;
            this.TxtSearchReceipt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtSearchReceipt.Icon = global::TechnoVision.Properties.Resources.search;
            this.TxtSearchReceipt.Lines = new string[0];
            this.TxtSearchReceipt.Location = new System.Drawing.Point(817, 33);
            this.TxtSearchReceipt.MaxLength = 32767;
            this.TxtSearchReceipt.Name = "TxtSearchReceipt";
            this.TxtSearchReceipt.PasswordChar = '\0';
            this.TxtSearchReceipt.PromptText = "Search by Receipt No  or Order Number";
            this.TxtSearchReceipt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearchReceipt.SelectedText = "";
            this.TxtSearchReceipt.SelectionLength = 0;
            this.TxtSearchReceipt.SelectionStart = 0;
            this.TxtSearchReceipt.ShortcutsEnabled = true;
            this.TxtSearchReceipt.Size = new System.Drawing.Size(288, 30);
            this.TxtSearchReceipt.TabIndex = 8;
            this.TxtSearchReceipt.UseSelectable = true;
            this.TxtSearchReceipt.WaterMark = "Search by Receipt No  or Order Number";
            this.TxtSearchReceipt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearchReceipt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridPayments
            // 
            this.GridPayments.AllowUserToResizeRows = false;
            this.GridPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPayments.EnableHeadersVisualStyles = false;
            this.GridPayments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPayments.Location = new System.Drawing.Point(24, 77);
            this.GridPayments.Name = "GridPayments";
            this.GridPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPayments.RowTemplate.Height = 24;
            this.GridPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPayments.Size = new System.Drawing.Size(1081, 524);
            this.GridPayments.Style = MetroFramework.MetroColorStyle.Green;
            this.GridPayments.TabIndex = 9;
            // 
            // UI_PAYMENT_VIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 694);
            this.Controls.Add(this.GridPayments);
            this.Controls.Add(this.TxtSearchReceipt);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnNewPayment);
            this.Controls.Add(this.BtnPrintReceipt);
            this.MaximizeBox = false;
            this.Name = "UI_PAYMENT_VIEWER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Payment Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.GridPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnRefresh;
        private MetroFramework.Controls.MetroButton BtnNewPayment;
        private MetroFramework.Controls.MetroButton BtnPrintReceipt;
        private MetroFramework.Controls.MetroTextBox TxtSearchReceipt;
        private MetroFramework.Controls.MetroGrid GridPayments;
    }
}