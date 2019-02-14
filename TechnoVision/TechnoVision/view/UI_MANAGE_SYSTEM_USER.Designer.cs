namespace TechnoVision.view
{
    partial class UI_MANAGE_SYSTEM_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_MANAGE_SYSTEM_USER));
            this.BtnEditUser = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteUser = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnEditUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditUser.Highlight = true;
            resources.ApplyResources(this.BtnEditUser, "BtnEditUser");
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditUser.UseCustomBackColor = true;
            this.BtnEditUser.UseCustomForeColor = true;
            this.BtnEditUser.UseSelectable = true;
            this.BtnEditUser.UseStyleColors = true;
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDeleteUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteUser.Highlight = true;
            resources.ApplyResources(this.BtnDeleteUser, "BtnDeleteUser");
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnDeleteUser.UseCustomBackColor = true;
            this.BtnDeleteUser.UseCustomForeColor = true;
            this.BtnDeleteUser.UseSelectable = true;
            this.BtnDeleteUser.UseStyleColors = true;
            // 
            // UI_MANAGE_SYSTEM_USER
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnEditUser);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_SYSTEM_USER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnEditUser;
        private MetroFramework.Controls.MetroButton BtnDeleteUser;
    }
}