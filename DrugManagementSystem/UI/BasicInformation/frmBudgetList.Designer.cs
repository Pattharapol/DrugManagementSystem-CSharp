namespace DrugManagementSystem.UI.BasicInformation
{
    partial class frmBudgetList
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dgvBudgetTypeList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBudgetType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBudgetCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetTypeList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
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
            this.txtSearch.Location = new System.Drawing.Point(606, 47);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(267, 40);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(550, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 25);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "ค้นหา";
            // 
            // dgvBudgetTypeList
            // 
            this.dgvBudgetTypeList.AllowUserToAddRows = false;
            this.dgvBudgetTypeList.AllowUserToDeleteRows = false;
            this.dgvBudgetTypeList.AllowUserToResizeColumns = false;
            this.dgvBudgetTypeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBudgetTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBudgetTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgetTypeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBudgetTypeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBudgetTypeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBudgetTypeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBudgetTypeList.ColumnHeadersHeight = 30;
            this.dgvBudgetTypeList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBudgetTypeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBudgetTypeList.EnableHeadersVisualStyles = false;
            this.dgvBudgetTypeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBudgetTypeList.Location = new System.Drawing.Point(550, 99);
            this.dgvBudgetTypeList.MultiSelect = false;
            this.dgvBudgetTypeList.Name = "dgvBudgetTypeList";
            this.dgvBudgetTypeList.ReadOnly = true;
            this.dgvBudgetTypeList.RowHeadersVisible = false;
            this.dgvBudgetTypeList.RowTemplate.Height = 24;
            this.dgvBudgetTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBudgetTypeList.Size = new System.Drawing.Size(608, 600);
            this.dgvBudgetTypeList.TabIndex = 18;
            this.dgvBudgetTypeList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBudgetTypeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBudgetTypeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBudgetTypeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBudgetTypeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBudgetTypeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBudgetTypeList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBudgetTypeList.ThemeStyle.ReadOnly = true;
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBudgetTypeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.แกไขToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
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
            this.btnUpdate.Location = new System.Drawing.Point(322, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(136, 43);
            this.btnUpdate.TabIndex = 17;
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
            this.btnSave.Location = new System.Drawing.Point(180, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 16;
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
            this.btnCancel.Location = new System.Drawing.Point(322, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.dgvBudgetTypeList);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtBudgetType);
            this.panel2.Controls.Add(this.txtBudgetCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1274, 737);
            this.panel2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(120, 175);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(163, 25);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "ประเภทเงินงบประมาณ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(120, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 25);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "รหัสเงินประมาณ";
            // 
            // txtBudgetType
            // 
            this.txtBudgetType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBudgetType.DefaultText = "";
            this.txtBudgetType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBudgetType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBudgetType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetType.DisabledState.Parent = this.txtBudgetType;
            this.txtBudgetType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetType.FocusedState.Parent = this.txtBudgetType;
            this.txtBudgetType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudgetType.ForeColor = System.Drawing.Color.Black;
            this.txtBudgetType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetType.HoverState.Parent = this.txtBudgetType;
            this.txtBudgetType.Location = new System.Drawing.Point(120, 201);
            this.txtBudgetType.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtBudgetType.Name = "txtBudgetType";
            this.txtBudgetType.PasswordChar = '\0';
            this.txtBudgetType.PlaceholderText = "";
            this.txtBudgetType.SelectedText = "";
            this.txtBudgetType.ShadowDecoration.Parent = this.txtBudgetType;
            this.txtBudgetType.Size = new System.Drawing.Size(338, 40);
            this.txtBudgetType.TabIndex = 1;
            // 
            // txtBudgetCode
            // 
            this.txtBudgetCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBudgetCode.DefaultText = "";
            this.txtBudgetCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBudgetCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBudgetCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetCode.DisabledState.Parent = this.txtBudgetCode;
            this.txtBudgetCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetCode.FocusedState.Parent = this.txtBudgetCode;
            this.txtBudgetCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudgetCode.ForeColor = System.Drawing.Color.Black;
            this.txtBudgetCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetCode.HoverState.Parent = this.txtBudgetCode;
            this.txtBudgetCode.Location = new System.Drawing.Point(120, 130);
            this.txtBudgetCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtBudgetCode.Name = "txtBudgetCode";
            this.txtBudgetCode.PasswordChar = '\0';
            this.txtBudgetCode.PlaceholderText = "";
            this.txtBudgetCode.SelectedText = "";
            this.txtBudgetCode.ShadowDecoration.Parent = this.txtBudgetCode;
            this.txtBudgetCode.Size = new System.Drawing.Size(267, 40);
            this.txtBudgetCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 737);
            this.panel1.TabIndex = 2;
            // 
            // frmBudgetList
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBudgetList";
            this.Text = "ข้อมูลประเภทเงินงบประมาณ";
            this.Load += new System.EventHandler(this.frmBudgetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgetTypeList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBudgetTypeList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtBudgetType;
        private Guna.UI2.WinForms.Guna2TextBox txtBudgetCode;
        private System.Windows.Forms.Panel panel1;
    }
}