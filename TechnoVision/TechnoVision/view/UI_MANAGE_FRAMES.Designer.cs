namespace TechnoVision.view
{
    partial class UI_MANAGE_FRAMES
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
            this.BtnAddFrame = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteFrame = new MetroFramework.Controls.MetroButton();
            this.TxtAddFrame = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // BtnAddFrame
            // 
            this.BtnAddFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddFrame.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddFrame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddFrame.Highlight = true;
            this.BtnAddFrame.Location = new System.Drawing.Point(301, 544);
            this.BtnAddFrame.Name = "BtnAddFrame";
            this.BtnAddFrame.Size = new System.Drawing.Size(120, 45);
            this.BtnAddFrame.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddFrame.TabIndex = 7;
            this.BtnAddFrame.Text = "Save Frame";
            this.BtnAddFrame.UseCustomBackColor = true;
            this.BtnAddFrame.UseCustomForeColor = true;
            this.BtnAddFrame.UseSelectable = true;
            this.BtnAddFrame.UseStyleColors = true;
            // 
            // BtnDeleteFrame
            // 
            this.BtnDeleteFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnDeleteFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteFrame.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnDeleteFrame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteFrame.Highlight = true;
            this.BtnDeleteFrame.Location = new System.Drawing.Point(427, 544);
            this.BtnDeleteFrame.Name = "BtnDeleteFrame";
            this.BtnDeleteFrame.Size = new System.Drawing.Size(120, 45);
            this.BtnDeleteFrame.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnDeleteFrame.TabIndex = 7;
            this.BtnDeleteFrame.Text = "Delete Frame";
            this.BtnDeleteFrame.UseCustomBackColor = true;
            this.BtnDeleteFrame.UseCustomForeColor = true;
            this.BtnDeleteFrame.UseSelectable = true;
            this.BtnDeleteFrame.UseStyleColors = true;
            // 
            // TxtAddFrame
            // 
            // 
            // 
            // 
            this.TxtAddFrame.CustomButton.Image = null;
            this.TxtAddFrame.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.TxtAddFrame.CustomButton.Name = "";
            this.TxtAddFrame.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAddFrame.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddFrame.CustomButton.TabIndex = 1;
            this.TxtAddFrame.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddFrame.CustomButton.UseSelectable = true;
            this.TxtAddFrame.CustomButton.Visible = false;
            this.TxtAddFrame.Lines = new string[0];
            this.TxtAddFrame.Location = new System.Drawing.Point(15, 549);
            this.TxtAddFrame.MaxLength = 32767;
            this.TxtAddFrame.Name = "TxtAddFrame";
            this.TxtAddFrame.PasswordChar = '\0';
            this.TxtAddFrame.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddFrame.SelectedText = "";
            this.TxtAddFrame.SelectionLength = 0;
            this.TxtAddFrame.SelectionStart = 0;
            this.TxtAddFrame.ShortcutsEnabled = true;
            this.TxtAddFrame.Size = new System.Drawing.Size(280, 35);
            this.TxtAddFrame.TabIndex = 8;
            this.TxtAddFrame.UseSelectable = true;
            this.TxtAddFrame.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddFrame.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UI_MANAGE_FRAMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 601);
            this.Controls.Add(this.TxtAddFrame);
            this.Controls.Add(this.BtnDeleteFrame);
            this.Controls.Add(this.BtnAddFrame);
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_FRAMES";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Frames";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAddFrame;
        private MetroFramework.Controls.MetroButton BtnDeleteFrame;
        private MetroFramework.Controls.MetroTextBox TxtAddFrame;
    }
}