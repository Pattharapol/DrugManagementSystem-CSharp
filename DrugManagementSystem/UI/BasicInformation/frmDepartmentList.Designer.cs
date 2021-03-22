namespace DrugManagementSystem.UI.BasicInformation
{
    partial class frmDepartmentList
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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDepartment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartmentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(698, 41);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(267, 40);
            this.txtSearch.TabIndex = 30;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(642, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 25);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "ค้นหา";
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToResizeColumns = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartment.ColumnHeadersHeight = 30;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartment.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartment.EnableHeadersVisualStyles = false;
            this.dgvDepartment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartment.Location = new System.Drawing.Point(642, 93);
            this.dgvDepartment.MultiSelect = false;
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowHeadersVisible = false;
            this.dgvDepartment.RowTemplate.Height = 24;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(608, 600);
            this.dgvDepartment.TabIndex = 28;
            this.dgvDepartment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDepartment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDepartment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvDepartment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDepartment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartment.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDepartment.ThemeStyle.ReadOnly = true;
            this.dgvDepartment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvDepartment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDepartment.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDepartment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.แกไขToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 36);
            // 
            // แกไขToolStripMenuItem
            // 
            this.แกไขToolStripMenuItem.Name = "แกไขToolStripMenuItem";
            this.แกไขToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.แกไขToolStripMenuItem.Text = "แก้ไข";
            this.แกไขToolStripMenuItem.Click += new System.EventHandler(this.แกไขToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(414, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(136, 43);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "บันทึกแก้ไข";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(272, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(212, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 25);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "ชื่อฝ่าย/แผนก";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartmentName.DefaultText = "";
            this.txtDepartmentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDepartmentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDepartmentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepartmentName.DisabledState.Parent = this.txtDepartmentName;
            this.txtDepartmentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepartmentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepartmentName.FocusedState.Parent = this.txtDepartmentName;
            this.txtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.txtDepartmentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepartmentName.HoverState.Parent = this.txtDepartmentName;
            this.txtDepartmentName.Location = new System.Drawing.Point(212, 119);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.PasswordChar = '\0';
            this.txtDepartmentName.PlaceholderText = "";
            this.txtDepartmentName.SelectedText = "";
            this.txtDepartmentName.ShadowDecoration.Parent = this.txtDepartmentName;
            this.txtDepartmentName.Size = new System.Drawing.Size(338, 40);
            this.txtDepartmentName.TabIndex = 22;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmDepartment
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 735);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDepartmentName);
            this.Name = "frmDepartment";
            this.Text = "ฝ่าย/แผนก";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDepartment;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtDepartmentName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider ep;
    }
}