namespace TechnoVision.view
{
    partial class UI_SELECT_OPTION_SYSTEM_USER
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
            this.BtnAddSystemUser = new MetroFramework.Controls.MetroTile();
            this.BtnEditSystemUser = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BtnAddSystemUser
            // 
            this.BtnAddSystemUser.ActiveControl = null;
            this.BtnAddSystemUser.Location = new System.Drawing.Point(47, 111);
            this.BtnAddSystemUser.Name = "BtnAddSystemUser";
            this.BtnAddSystemUser.Size = new System.Drawing.Size(215, 212);
            this.BtnAddSystemUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddSystemUser.TabIndex = 0;
            this.BtnAddSystemUser.Text = "Add System User";
            this.BtnAddSystemUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddSystemUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddSystemUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnAddSystemUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnAddSystemUser.UseSelectable = true;
            this.BtnAddSystemUser.Click += new System.EventHandler(this.BtnAddSystemUser_Click);
            // 
            // BtnEditSystemUser
            // 
            this.BtnEditSystemUser.ActiveControl = null;
            this.BtnEditSystemUser.Location = new System.Drawing.Point(292, 111);
            this.BtnEditSystemUser.Name = "BtnEditSystemUser";
            this.BtnEditSystemUser.Size = new System.Drawing.Size(215, 212);
            this.BtnEditSystemUser.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditSystemUser.TabIndex = 0;
            this.BtnEditSystemUser.Text = "Edit System User";
            this.BtnEditSystemUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditSystemUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditSystemUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnEditSystemUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnEditSystemUser.UseSelectable = true;
            this.BtnEditSystemUser.Click += new System.EventHandler(this.BtnEditSystemUser_Click);
            // 
            // UI_SELECT_OPTION_SYSTEM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 422);
            this.Controls.Add(this.BtnEditSystemUser);
            this.Controls.Add(this.BtnAddSystemUser);
            this.MaximizeBox = false;
            this.Name = "UI_SELECT_OPTION_SYSTEM_USER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Select Option";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnAddSystemUser;
        private MetroFramework.Controls.MetroTile BtnEditSystemUser;
    }
}