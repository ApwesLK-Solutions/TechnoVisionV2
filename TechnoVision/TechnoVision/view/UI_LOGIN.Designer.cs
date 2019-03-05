namespace TechnoVision.view
{
    partial class UI_LOGIN
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
            this.TxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnForgetPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            // 
            // 
            // 
            this.TxtUsername.CustomButton.Image = null;
            this.TxtUsername.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.TxtUsername.CustomButton.Name = "";
            this.TxtUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsername.CustomButton.TabIndex = 1;
            this.TxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsername.CustomButton.UseSelectable = true;
            this.TxtUsername.CustomButton.Visible = false;
            this.TxtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtUsername.Lines = new string[0];
            this.TxtUsername.Location = new System.Drawing.Point(183, 145);
            this.TxtUsername.MaxLength = 32767;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.PromptText = "Enter Username";
            this.TxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.ShortcutsEnabled = true;
            this.TxtUsername.Size = new System.Drawing.Size(213, 30);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.UseSelectable = true;
            this.TxtUsername.WaterMark = "Enter Username";
            this.TxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(183, 181);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PromptText = "Enter Password";
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(213, 30);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMark = "Enter Password";
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.ActiveControl = null;
            this.BtnLogin.Location = new System.Drawing.Point(217, 226);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 46);
            this.BtnLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // BtnForgetPassword
            // 
            this.BtnForgetPassword.AutoSize = true;
            this.BtnForgetPassword.Location = new System.Drawing.Point(420, 255);
            this.BtnForgetPassword.Name = "BtnForgetPassword";
            this.BtnForgetPassword.Size = new System.Drawing.Size(114, 17);
            this.BtnForgetPassword.TabIndex = 3;
            this.BtnForgetPassword.TabStop = true;
            this.BtnForgetPassword.Text = "Forget Password";
            this.BtnForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnForgetPassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechnoVision.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UI_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(547, 281);
            this.Controls.Add(this.BtnForgetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_LOGIN";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtUsername;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroTile BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel BtnForgetPassword;
    }
}