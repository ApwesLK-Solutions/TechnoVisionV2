namespace TechnoVision.view
{
    partial class UI_FORGET_PASSWORD
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
            this.BtnChangePassword = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.TxtNic = new MetroFramework.Controls.MetroTextBox();
            this.TxtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.TxtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassword.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnChangePassword.Highlight = true;
            this.BtnChangePassword.Location = new System.Drawing.Point(248, 340);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(181, 54);
            this.BtnChangePassword.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnChangePassword.TabIndex = 5;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.UseCustomBackColor = true;
            this.BtnChangePassword.UseCustomForeColor = true;
            this.BtnChangePassword.UseSelectable = true;
            this.BtnChangePassword.UseStyleColors = true;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(28, 196);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Contact Number";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(28, 149);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "NIC";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(28, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "New Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 20);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(28, 100);
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
            this.TxtContactNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtContactNumber.Lines = new string[0];
            this.TxtContactNumber.Location = new System.Drawing.Point(234, 189);
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
            this.TxtContactNumber.TabIndex = 2;
            this.TxtContactNumber.UseSelectable = true;
            this.TxtContactNumber.WaterMark = "Enter Contact Number...";
            this.TxtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNic
            // 
            // 
            // 
            // 
            this.TxtNic.CustomButton.Image = null;
            this.TxtNic.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtNic.CustomButton.Name = "";
            this.TxtNic.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtNic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNic.CustomButton.TabIndex = 1;
            this.TxtNic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNic.CustomButton.UseSelectable = true;
            this.TxtNic.CustomButton.Visible = false;
            this.TxtNic.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtNic.Lines = new string[0];
            this.TxtNic.Location = new System.Drawing.Point(234, 142);
            this.TxtNic.MaxLength = 32767;
            this.TxtNic.Name = "TxtNic";
            this.TxtNic.PasswordChar = '\0';
            this.TxtNic.PromptText = "Enter Nic...";
            this.TxtNic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNic.SelectedText = "";
            this.TxtNic.SelectionLength = 0;
            this.TxtNic.SelectionStart = 0;
            this.TxtNic.ShortcutsEnabled = true;
            this.TxtNic.Size = new System.Drawing.Size(400, 35);
            this.TxtNic.TabIndex = 1;
            this.TxtNic.UseSelectable = true;
            this.TxtNic.WaterMark = "Enter Nic...";
            this.TxtNic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNewPassword
            // 
            // 
            // 
            // 
            this.TxtNewPassword.CustomButton.Image = null;
            this.TxtNewPassword.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtNewPassword.CustomButton.Name = "";
            this.TxtNewPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNewPassword.CustomButton.TabIndex = 1;
            this.TxtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNewPassword.CustomButton.UseSelectable = true;
            this.TxtNewPassword.CustomButton.Visible = false;
            this.TxtNewPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtNewPassword.Lines = new string[0];
            this.TxtNewPassword.Location = new System.Drawing.Point(234, 236);
            this.TxtNewPassword.MaxLength = 32767;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '\0';
            this.TxtNewPassword.PromptText = "Enter new Password...";
            this.TxtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNewPassword.SelectedText = "";
            this.TxtNewPassword.SelectionLength = 0;
            this.TxtNewPassword.SelectionStart = 0;
            this.TxtNewPassword.ShortcutsEnabled = true;
            this.TxtNewPassword.Size = new System.Drawing.Size(400, 35);
            this.TxtNewPassword.TabIndex = 3;
            this.TxtNewPassword.UseSelectable = true;
            this.TxtNewPassword.WaterMark = "Enter new Password...";
            this.TxtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.TxtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtUsername.Lines = new string[0];
            this.TxtUsername.Location = new System.Drawing.Point(234, 95);
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
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.UseSelectable = true;
            this.TxtUsername.WaterMark = "Enter Username...";
            this.TxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtConfirmPassword
            // 
            // 
            // 
            // 
            this.TxtConfirmPassword.CustomButton.Image = null;
            this.TxtConfirmPassword.CustomButton.Location = new System.Drawing.Point(366, 1);
            this.TxtConfirmPassword.CustomButton.Name = "";
            this.TxtConfirmPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtConfirmPassword.CustomButton.TabIndex = 1;
            this.TxtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtConfirmPassword.CustomButton.UseSelectable = true;
            this.TxtConfirmPassword.CustomButton.Visible = false;
            this.TxtConfirmPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtConfirmPassword.Lines = new string[0];
            this.TxtConfirmPassword.Location = new System.Drawing.Point(234, 283);
            this.TxtConfirmPassword.MaxLength = 32767;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '\0';
            this.TxtConfirmPassword.PromptText = "Enter Password...";
            this.TxtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtConfirmPassword.SelectedText = "";
            this.TxtConfirmPassword.SelectionLength = 0;
            this.TxtConfirmPassword.SelectionStart = 0;
            this.TxtConfirmPassword.ShortcutsEnabled = true;
            this.TxtConfirmPassword.Size = new System.Drawing.Size(400, 35);
            this.TxtConfirmPassword.TabIndex = 4;
            this.TxtConfirmPassword.UseSelectable = true;
            this.TxtConfirmPassword.WaterMark = "Enter Password...";
            this.TxtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(28, 290);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(125, 20);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "confirm Password";
            // 
            // UI_FORGET_PASSWORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtContactNumber);
            this.Controls.Add(this.TxtNic);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.TxtUsername);
            this.MaximizeBox = false;
            this.Name = "UI_FORGET_PASSWORD";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnChangePassword;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtContactNumber;
        private MetroFramework.Controls.MetroTextBox TxtNic;
        private MetroFramework.Controls.MetroTextBox TxtNewPassword;
        private MetroFramework.Controls.MetroTextBox TxtUsername;
        private MetroFramework.Controls.MetroTextBox TxtConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}