namespace TechnoVision.view
{
    partial class UI_ADD_BRANCH
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
            this.GrdBranch = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technovisionDataSet = new TechnoVision.technovisionDataSet();
            this.branchTableAdapter = new TechnoVision.technovisionDataSetTableAdapters.branchTableAdapter();
            this.TxtBranchName = new MetroFramework.Controls.MetroTextBox();
            this.BtnAddBranch = new MetroFramework.Controls.MetroButton();
            this.TxtMasterPassword = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdBranch
            // 
            this.GrdBranch.AllowUserToAddRows = false;
            this.GrdBranch.AllowUserToDeleteRows = false;
            this.GrdBranch.AllowUserToOrderColumns = true;
            this.GrdBranch.AllowUserToResizeRows = false;
            this.GrdBranch.AutoGenerateColumns = false;
            this.GrdBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdBranch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdBranch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBranch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdBranch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdBranch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBranch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.branchNameDataGridViewTextBoxColumn});
            this.GrdBranch.DataSource = this.branchBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdBranch.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdBranch.EnableHeadersVisualStyles = false;
            this.GrdBranch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdBranch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdBranch.Location = new System.Drawing.Point(3, 3);
            this.GrdBranch.Name = "GrdBranch";
            this.GrdBranch.ReadOnly = true;
            this.GrdBranch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdBranch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdBranch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdBranch.RowTemplate.Height = 24;
            this.GrdBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdBranch.Size = new System.Drawing.Size(561, 496);
            this.GrdBranch.Style = MetroFramework.MetroColorStyle.Green;
            this.GrdBranch.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "BranchName";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.technovisionDataSet;
            // 
            // technovisionDataSet
            // 
            this.technovisionDataSet.DataSetName = "technovisionDataSet";
            this.technovisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtBranchName.CustomButton.Image = null;
            this.TxtBranchName.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.TxtBranchName.CustomButton.Name = "";
            this.TxtBranchName.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.TxtBranchName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBranchName.CustomButton.TabIndex = 1;
            this.TxtBranchName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBranchName.CustomButton.UseSelectable = true;
            this.TxtBranchName.CustomButton.Visible = false;
            this.TxtBranchName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBranchName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtBranchName.Lines = new string[0];
            this.TxtBranchName.Location = new System.Drawing.Point(3, 3);
            this.TxtBranchName.MaxLength = 32767;
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.PasswordChar = '\0';
            this.TxtBranchName.PromptText = "Enter Branch Name...";
            this.TxtBranchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBranchName.SelectedText = "";
            this.TxtBranchName.SelectionLength = 0;
            this.TxtBranchName.SelectionStart = 0;
            this.TxtBranchName.ShortcutsEnabled = true;
            this.TxtBranchName.Size = new System.Drawing.Size(227, 39);
            this.TxtBranchName.TabIndex = 1;
            this.TxtBranchName.UseSelectable = true;
            this.TxtBranchName.WaterMark = "Enter Branch Name...";
            this.TxtBranchName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBranchName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAddBranch
            // 
            this.BtnAddBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddBranch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAddBranch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddBranch.Highlight = true;
            this.BtnAddBranch.Location = new System.Drawing.Point(469, 3);
            this.BtnAddBranch.Name = "BtnAddBranch";
            this.BtnAddBranch.Size = new System.Drawing.Size(89, 39);
            this.BtnAddBranch.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnAddBranch.TabIndex = 7;
            this.BtnAddBranch.Text = "Add Branch";
            this.BtnAddBranch.UseCustomBackColor = true;
            this.BtnAddBranch.UseCustomForeColor = true;
            this.BtnAddBranch.UseSelectable = true;
            this.BtnAddBranch.UseStyleColors = true;
            this.BtnAddBranch.Click += new System.EventHandler(this.BtnAddBranch_Click);
            // 
            // TxtMasterPassword
            // 
            // 
            // 
            // 
            this.TxtMasterPassword.CustomButton.Image = null;
            this.TxtMasterPassword.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.TxtMasterPassword.CustomButton.Name = "";
            this.TxtMasterPassword.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.TxtMasterPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMasterPassword.CustomButton.TabIndex = 1;
            this.TxtMasterPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMasterPassword.CustomButton.UseSelectable = true;
            this.TxtMasterPassword.CustomButton.Visible = false;
            this.TxtMasterPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMasterPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtMasterPassword.Lines = new string[0];
            this.TxtMasterPassword.Location = new System.Drawing.Point(236, 3);
            this.TxtMasterPassword.MaxLength = 32767;
            this.TxtMasterPassword.Name = "TxtMasterPassword";
            this.TxtMasterPassword.PasswordChar = '*';
            this.TxtMasterPassword.PromptText = "Enter Branch Master Password...";
            this.TxtMasterPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMasterPassword.SelectedText = "";
            this.TxtMasterPassword.SelectionLength = 0;
            this.TxtMasterPassword.SelectionStart = 0;
            this.TxtMasterPassword.ShortcutsEnabled = true;
            this.TxtMasterPassword.Size = new System.Drawing.Size(227, 39);
            this.TxtMasterPassword.TabIndex = 2;
            this.TxtMasterPassword.UseSelectable = true;
            this.TxtMasterPassword.WaterMark = "Enter Branch Master Password...";
            this.TxtMasterPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMasterPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GrdBranch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 553);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.TxtBranchName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnAddBranch, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtMasterPassword, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 505);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UI_ADD_BRANCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "UI_ADD_BRANCH";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Add Branches";
            this.Load += new System.EventHandler(this.UI_ADD_BRANCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technovisionDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GrdBranch;
        private technovisionDataSet technovisionDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private technovisionDataSetTableAdapters.branchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox TxtBranchName;
        private MetroFramework.Controls.MetroButton BtnAddBranch;
        private MetroFramework.Controls.MetroTextBox TxtMasterPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}