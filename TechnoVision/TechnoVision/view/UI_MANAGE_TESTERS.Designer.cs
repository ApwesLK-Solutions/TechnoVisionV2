namespace TechnoVision.view
{
    partial class UI_MANAGE_TESTERS
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
            this.TxtAddTester = new MetroFramework.Controls.MetroTextBox();
            this.BtnDeleteTester = new MetroFramework.Controls.MetroButton();
            this.BtnAddTester = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtAddTester
            // 
            // 
            // 
            // 
            this.TxtAddTester.CustomButton.Image = null;
            this.TxtAddTester.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.TxtAddTester.CustomButton.Name = "";
            this.TxtAddTester.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAddTester.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddTester.CustomButton.TabIndex = 1;
            this.TxtAddTester.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddTester.CustomButton.UseSelectable = true;
            this.TxtAddTester.CustomButton.Visible = false;
            this.TxtAddTester.Lines = new string[0];
            this.TxtAddTester.Location = new System.Drawing.Point(12, 553);
            this.TxtAddTester.MaxLength = 32767;
            this.TxtAddTester.Name = "TxtAddTester";
            this.TxtAddTester.PasswordChar = '\0';
            this.TxtAddTester.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddTester.SelectedText = "";
            this.TxtAddTester.SelectionLength = 0;
            this.TxtAddTester.SelectionStart = 0;
            this.TxtAddTester.ShortcutsEnabled = true;
            this.TxtAddTester.Size = new System.Drawing.Size(280, 35);
            this.TxtAddTester.TabIndex = 11;
            this.TxtAddTester.UseSelectable = true;
            this.TxtAddTester.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddTester.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnDeleteTester
            // 
            this.BtnDeleteTester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDeleteTester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteTester.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDeleteTester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteTester.Highlight = true;
            this.BtnDeleteTester.Location = new System.Drawing.Point(424, 548);
            this.BtnDeleteTester.Name = "BtnDeleteTester";
            this.BtnDeleteTester.Size = new System.Drawing.Size(120, 45);
            this.BtnDeleteTester.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnDeleteTester.TabIndex = 9;
            this.BtnDeleteTester.Text = "Delete Tester";
            this.BtnDeleteTester.UseCustomBackColor = true;
            this.BtnDeleteTester.UseCustomForeColor = true;
            this.BtnDeleteTester.UseSelectable = true;
            this.BtnDeleteTester.UseStyleColors = true;
            // 
            // BtnAddTester
            // 
            this.BtnAddTester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddTester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddTester.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddTester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddTester.Highlight = true;
            this.BtnAddTester.Location = new System.Drawing.Point(298, 548);
            this.BtnAddTester.Name = "BtnAddTester";
            this.BtnAddTester.Size = new System.Drawing.Size(120, 45);
            this.BtnAddTester.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddTester.TabIndex = 10;
            this.BtnAddTester.Text = "Save Tester";
            this.BtnAddTester.UseCustomBackColor = true;
            this.BtnAddTester.UseCustomForeColor = true;
            this.BtnAddTester.UseSelectable = true;
            this.BtnAddTester.UseStyleColors = true;
            // 
            // UI_MANAGE_TESTERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 601);
            this.Controls.Add(this.TxtAddTester);
            this.Controls.Add(this.BtnDeleteTester);
            this.Controls.Add(this.BtnAddTester);
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_TESTERS";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Testers";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtAddTester;
        private MetroFramework.Controls.MetroButton BtnDeleteTester;
        private MetroFramework.Controls.MetroButton BtnAddTester;
    }
}