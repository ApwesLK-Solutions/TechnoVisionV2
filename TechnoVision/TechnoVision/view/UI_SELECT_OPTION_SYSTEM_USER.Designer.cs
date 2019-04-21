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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_SELECT_OPTION_SYSTEM_USER));
            this.BtnAddSystemUser = new MetroFramework.Controls.MetroTile();
            this.BtnEditSystemUser = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddSystemUser
            // 
            this.BtnAddSystemUser.ActiveControl = null;
            this.BtnAddSystemUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddSystemUser.Location = new System.Drawing.Point(3, 3);
            this.BtnAddSystemUser.Name = "BtnAddSystemUser";
            this.BtnAddSystemUser.Size = new System.Drawing.Size(415, 314);
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
            this.BtnEditSystemUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditSystemUser.Location = new System.Drawing.Point(424, 3);
            this.BtnEditSystemUser.Name = "BtnEditSystemUser";
            this.BtnEditSystemUser.Size = new System.Drawing.Size(416, 314);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAddSystemUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditSystemUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 320);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UI_SELECT_OPTION_SYSTEM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI_SELECT_OPTION_SYSTEM_USER";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Select Option";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnAddSystemUser;
        private MetroFramework.Controls.MetroTile BtnEditSystemUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}