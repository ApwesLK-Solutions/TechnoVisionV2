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
            this.UserName = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnForgetPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            // 
            // 
            // 
            this.UserName.CustomButton.Image = null;
            this.UserName.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.UserName.CustomButton.Name = "";
            this.UserName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.UserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName.CustomButton.TabIndex = 1;
            this.UserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName.CustomButton.UseSelectable = true;
            this.UserName.CustomButton.Visible = false;
            this.UserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UserName.Lines = new string[0];
            this.UserName.Location = new System.Drawing.Point(183, 145);
            this.UserName.MaxLength = 32767;
            this.UserName.Name = "UserName";
            this.UserName.PasswordChar = '\0';
            this.UserName.PromptText = "Enter Username";
            this.UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName.SelectedText = "";
            this.UserName.SelectionLength = 0;
            this.UserName.SelectionStart = 0;
            this.UserName.ShortcutsEnabled = true;
            this.UserName.Size = new System.Drawing.Size(213, 30);
            this.UserName.TabIndex = 0;
            this.UserName.UseSelectable = true;
            this.UserName.WaterMark = "Enter Username";
            this.UserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.Password.Lines = new string[0];
            this.Password.Location = new System.Drawing.Point(183, 181);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PromptText = "Enter Password";
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(213, 30);
            this.Password.TabIndex = 1;
            this.Password.UseSelectable = true;
            this.Password.WaterMark = "Enter Password";
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_LOGIN";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.UI_LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UserName;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroTile BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel BtnForgetPassword;
    }
}