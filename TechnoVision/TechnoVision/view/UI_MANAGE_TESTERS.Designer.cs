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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtAddTester = new MetroFramework.Controls.MetroTextBox();
            this.BtnDeleteTester = new MetroFramework.Controls.MetroButton();
            this.BtnAddTester = new MetroFramework.Controls.MetroButton();
            this.GridTesters = new MetroFramework.Controls.MetroGrid();
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.testersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testersTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.testersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTesters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAddTester
            // 
            // 
            // 
            // 
            this.TxtAddTester.CustomButton.Image = null;
            this.TxtAddTester.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.TxtAddTester.CustomButton.Name = "";
            this.TxtAddTester.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtAddTester.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddTester.CustomButton.TabIndex = 1;
            this.TxtAddTester.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddTester.CustomButton.UseSelectable = true;
            this.TxtAddTester.CustomButton.Visible = false;
            this.TxtAddTester.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtAddTester.Lines = new string[0];
            this.TxtAddTester.Location = new System.Drawing.Point(23, 553);
            this.TxtAddTester.MaxLength = 32767;
            this.TxtAddTester.Name = "TxtAddTester";
            this.TxtAddTester.PasswordChar = '\0';
            this.TxtAddTester.PromptText = "Enter Tester Name";
            this.TxtAddTester.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddTester.SelectedText = "";
            this.TxtAddTester.SelectionLength = 0;
            this.TxtAddTester.SelectionStart = 0;
            this.TxtAddTester.ShortcutsEnabled = true;
            this.TxtAddTester.Size = new System.Drawing.Size(269, 35);
            this.TxtAddTester.TabIndex = 11;
            this.TxtAddTester.UseSelectable = true;
            this.TxtAddTester.WaterMark = "Enter Tester Name";
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
            // GridTesters
            // 
            this.GridTesters.AllowUserToAddRows = false;
            this.GridTesters.AllowUserToDeleteRows = false;
            this.GridTesters.AllowUserToOrderColumns = true;
            this.GridTesters.AllowUserToResizeRows = false;
            this.GridTesters.AutoGenerateColumns = false;
            this.GridTesters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTesters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTesters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTesters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTesters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTesters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTesters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTesters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.GridTesters.DataSource = this.testersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTesters.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridTesters.EnableHeadersVisualStyles = false;
            this.GridTesters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTesters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTesters.Location = new System.Drawing.Point(24, 64);
            this.GridTesters.Name = "GridTesters";
            this.GridTesters.ReadOnly = true;
            this.GridTesters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTesters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridTesters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTesters.RowTemplate.Height = 24;
            this.GridTesters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTesters.Size = new System.Drawing.Size(520, 465);
            this.GridTesters.Style = MetroFramework.MetroColorStyle.Green;
            this.GridTesters.TabIndex = 12;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testersBindingSource
            // 
            this.testersBindingSource.DataMember = "testers";
            this.testersBindingSource.DataSource = this.technovisionDataSet;
            // 
            // testersTableAdapter
            // 
            this.testersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UI_MANAGE_TESTERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 601);
            this.Controls.Add(this.GridTesters);
            this.Controls.Add(this.TxtAddTester);
            this.Controls.Add(this.BtnDeleteTester);
            this.Controls.Add(this.BtnAddTester);
            this.MaximizeBox = false;
            this.Name = "UI_MANAGE_TESTERS";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Testers";
            this.Load += new System.EventHandler(this.UI_MANAGE_TESTERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTesters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtAddTester;
        private MetroFramework.Controls.MetroButton BtnDeleteTester;
        private MetroFramework.Controls.MetroButton BtnAddTester;
        private MetroFramework.Controls.MetroGrid GridTesters;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource testersBindingSource;
        private technovisionDataSetTableAdapters.testersTableAdapter testersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}