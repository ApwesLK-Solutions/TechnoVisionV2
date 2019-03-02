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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAddFrame = new MetroFramework.Controls.MetroButton();
            this.BtnDeleteFrame = new MetroFramework.Controls.MetroButton();
            this.TxtAddFrame = new MetroFramework.Controls.MetroTextBox();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.GridFrame = new MetroFramework.Controls.MetroGrid();
            this.framesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.framesTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.framesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
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
            this.TxtAddFrame.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.TxtAddFrame.CustomButton.Name = "";
            this.TxtAddFrame.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAddFrame.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddFrame.CustomButton.TabIndex = 1;
            this.TxtAddFrame.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddFrame.CustomButton.UseSelectable = true;
            this.TxtAddFrame.CustomButton.Visible = false;
            this.TxtAddFrame.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAddFrame.Lines = new string[0];
            this.TxtAddFrame.Location = new System.Drawing.Point(23, 554);
            this.TxtAddFrame.MaxLength = 32767;
            this.TxtAddFrame.Name = "TxtAddFrame";
            this.TxtAddFrame.PasswordChar = '\0';
            this.TxtAddFrame.PromptText = "Enter Frame...";
            this.TxtAddFrame.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddFrame.SelectedText = "";
            this.TxtAddFrame.SelectionLength = 0;
            this.TxtAddFrame.SelectionStart = 0;
            this.TxtAddFrame.ShortcutsEnabled = true;
            this.TxtAddFrame.Size = new System.Drawing.Size(272, 35);
            this.TxtAddFrame.TabIndex = 8;
            this.TxtAddFrame.UseSelectable = true;
            this.TxtAddFrame.WaterMark = "Enter Frame...";
            this.TxtAddFrame.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddFrame.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(243, 2);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(261, 33);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PromptText = "Search Frames...";
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.ShortcutsEnabled = true;
            this.TxtSearch.Size = new System.Drawing.Size(271, 30);
            this.TxtSearch.TabIndex = 9;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMark = "Search Frames...";
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // GridFrame
            // 
            this.GridFrame.AllowUserToAddRows = false;
            this.GridFrame.AllowUserToDeleteRows = false;
            this.GridFrame.AllowUserToOrderColumns = true;
            this.GridFrame.AllowUserToResizeRows = false;
            this.GridFrame.AutoGenerateColumns = false;
            this.GridFrame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridFrame.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridFrame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFrame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFrame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridFrame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFrame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFrame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFrame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.frameNameDataGridViewTextBoxColumn});
            this.GridFrame.DataSource = this.framesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFrame.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridFrame.EnableHeadersVisualStyles = false;
            this.GridFrame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridFrame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFrame.Location = new System.Drawing.Point(24, 81);
            this.GridFrame.Name = "GridFrame";
            this.GridFrame.ReadOnly = true;
            this.GridFrame.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFrame.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridFrame.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridFrame.RowTemplate.Height = 24;
            this.GridFrame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFrame.Size = new System.Drawing.Size(508, 437);
            this.GridFrame.Style = MetroFramework.MetroColorStyle.Green;
            this.GridFrame.TabIndex = 10;
            // 
            // framesBindingSource
            // 
            this.framesBindingSource.DataMember = "frames";
            this.framesBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // framesTableAdapter
            // 
            this.framesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frameNameDataGridViewTextBoxColumn
            // 
            this.frameNameDataGridViewTextBoxColumn.DataPropertyName = "FrameName";
            this.frameNameDataGridViewTextBoxColumn.HeaderText = "Frame Name";
            this.frameNameDataGridViewTextBoxColumn.Name = "frameNameDataGridViewTextBoxColumn";
            this.frameNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UI_MANAGE_FRAMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 601);
            this.Controls.Add(this.GridFrame);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtAddFrame);
            this.Controls.Add(this.BtnDeleteFrame);
            this.Controls.Add(this.BtnAddFrame);
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_FRAMES";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Frames";
            this.Load += new System.EventHandler(this.UI_MANAGE_FRAMES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAddFrame;
        private MetroFramework.Controls.MetroButton BtnDeleteFrame;
        private MetroFramework.Controls.MetroTextBox TxtAddFrame;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroGrid GridFrame;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource framesBindingSource;
        private technovisionDataSetTableAdapters.framesTableAdapter framesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameNameDataGridViewTextBoxColumn;
    }
}