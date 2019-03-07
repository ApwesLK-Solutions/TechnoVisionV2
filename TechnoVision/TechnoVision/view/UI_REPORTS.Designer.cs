namespace TechnoVision.view
{
    partial class UI_REPORTS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSpectacles = new MetroFramework.Controls.MetroButton();
            this.BtnContactLenses = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DateDailyReport = new MetroFramework.Controls.MetroDateTime();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DateEndDate = new MetroFramework.Controls.MetroDateTime();
            this.DateStartDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSpectacles);
            this.groupBox1.Controls.Add(this.BtnContactLenses);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.DateDailyReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Reports";
            // 
            // BtnSpectacles
            // 
            this.BtnSpectacles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSpectacles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSpectacles.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnSpectacles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSpectacles.Highlight = true;
            this.BtnSpectacles.Location = new System.Drawing.Point(41, 173);
            this.BtnSpectacles.Name = "BtnSpectacles";
            this.BtnSpectacles.Size = new System.Drawing.Size(287, 45);
            this.BtnSpectacles.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSpectacles.TabIndex = 2;
            this.BtnSpectacles.Text = "Spectacles Sales Report";
            this.BtnSpectacles.UseCustomBackColor = true;
            this.BtnSpectacles.UseCustomForeColor = true;
            this.BtnSpectacles.UseSelectable = true;
            this.BtnSpectacles.UseStyleColors = true;
            this.BtnSpectacles.Click += new System.EventHandler(this.BtnSpectacles_Click);
            // 
            // BtnContactLenses
            // 
            this.BtnContactLenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnContactLenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContactLenses.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnContactLenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContactLenses.Highlight = true;
            this.BtnContactLenses.Location = new System.Drawing.Point(41, 122);
            this.BtnContactLenses.Name = "BtnContactLenses";
            this.BtnContactLenses.Size = new System.Drawing.Size(287, 45);
            this.BtnContactLenses.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnContactLenses.TabIndex = 1;
            this.BtnContactLenses.Text = "Contact Lense Sales Report";
            this.BtnContactLenses.UseCustomBackColor = true;
            this.BtnContactLenses.UseCustomForeColor = true;
            this.BtnContactLenses.UseSelectable = true;
            this.BtnContactLenses.UseStyleColors = true;
            this.BtnContactLenses.Click += new System.EventHandler(this.BtnContactLenses_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(15, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select a Date";
            // 
            // DateDailyReport
            // 
            this.DateDailyReport.Location = new System.Drawing.Point(15, 71);
            this.DateDailyReport.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateDailyReport.Name = "DateDailyReport";
            this.DateDailyReport.Size = new System.Drawing.Size(340, 30);
            this.DateDailyReport.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.DateEndDate);
            this.groupBox2.Controls.Add(this.DateStartDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(398, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Reports";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(62, 173);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(287, 45);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Spectacles Sales Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(62, 122);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(287, 45);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Contact Lense Sales Report";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(206, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "End Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(15, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Start Date";
            // 
            // DateEndDate
            // 
            this.DateEndDate.Location = new System.Drawing.Point(206, 71);
            this.DateEndDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateEndDate.Name = "DateEndDate";
            this.DateEndDate.Size = new System.Drawing.Size(185, 30);
            this.DateEndDate.TabIndex = 0;
            // 
            // DateStartDate
            // 
            this.DateStartDate.Location = new System.Drawing.Point(15, 71);
            this.DateStartDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateStartDate.Name = "DateStartDate";
            this.DateStartDate.Size = new System.Drawing.Size(185, 30);
            this.DateStartDate.TabIndex = 0;
            // 
            // UI_REPORTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UI_REPORTS";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Reports Viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DateDailyReport;
        private MetroFramework.Controls.MetroButton BtnContactLenses;
        private MetroFramework.Controls.MetroButton BtnSpectacles;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime DateEndDate;
        private MetroFramework.Controls.MetroDateTime DateStartDate;
    }
}