namespace DrugManagementSystem.UI.BasicInformation
{
    partial class frmVendorList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dgvVendorList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPostCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVendorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVendorCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 741);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.dgvVendorList);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtPostCode);
            this.panel2.Controls.Add(this.txtAddress2);
            this.panel2.Controls.Add(this.txtVendorName);
            this.panel2.Controls.Add(this.txtVendorCode);
            this.panel2.Controls.Add(this.txtAddress1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 741);
            this.panel2.TabIndex = 1;
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
            // dgvVendorList
            // 
            this.dgvVendorList.AllowUserToAddRows = false;
            this.dgvVendorList.AllowUserToDeleteRows = false;
            this.dgvVendorList.AllowUserToResizeColumns = false;
            this.dgvVendorList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVendorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendorList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendorList.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVendorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendorList.ColumnHeadersHeight = 30;
            this.dgvVendorList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendorList.EnableHeadersVisualStyles = false;
            this.dgvVendorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendorList.Location = new System.Drawing.Point(550, 99);
            this.dgvVendorList.MultiSelect = false;
            this.dgvVendorList.Name = "dgvVendorList";
            this.dgvVendorList.ReadOnly = true;
            this.dgvVendorList.RowHeadersVisible = false;
            this.dgvVendorList.RowTemplate.Height = 24;
            this.dgvVendorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendorList.Size = new System.Drawing.Size(626, 600);
            this.dgvVendorList.TabIndex = 18;
            this.dgvVendorList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvVendorList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendorList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVendorList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVendorList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVendorList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVendorList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendorList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendorList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVendorList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVendorList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvVendorList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVendorList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVendorList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvVendorList.ThemeStyle.ReadOnly = true;
            this.dgvVendorList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVendorList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVendorList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvVendorList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVendorList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvVendorList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVendorList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnUpdate.Location = new System.Drawing.Point(379, 606);
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
            this.btnSave.Location = new System.Drawing.Point(237, 606);
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
            this.btnCancel.Location = new System.Drawing.Point(379, 656);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 566);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 25);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "รหัสไปรษณีย์";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(104, 352);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 25);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "ที่อยู่ 2";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(104, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 25);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "ที่อยู่ 1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(66, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 25);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "ชื่อบริษัทยา";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 25);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "รหัสบริษัทยา";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostCode.DefaultText = "";
            this.txtPostCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPostCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPostCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostCode.DisabledState.Parent = this.txtPostCode;
            this.txtPostCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostCode.FocusedState.Parent = this.txtPostCode;
            this.txtPostCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.ForeColor = System.Drawing.Color.Black;
            this.txtPostCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostCode.HoverState.Parent = this.txtPostCode;
            this.txtPostCode.Location = new System.Drawing.Point(177, 557);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.PasswordChar = '\0';
            this.txtPostCode.PlaceholderText = "";
            this.txtPostCode.SelectedText = "";
            this.txtPostCode.ShadowDecoration.Parent = this.txtPostCode;
            this.txtPostCode.Size = new System.Drawing.Size(267, 40);
            this.txtPostCode.TabIndex = 4;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress2.DefaultText = "";
            this.txtAddress2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress2.DisabledState.Parent = this.txtAddress2;
            this.txtAddress2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress2.FocusedState.Parent = this.txtAddress2;
            this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.ForeColor = System.Drawing.Color.Black;
            this.txtAddress2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress2.HoverState.Parent = this.txtAddress2;
            this.txtAddress2.Location = new System.Drawing.Point(177, 351);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.PasswordChar = '\0';
            this.txtAddress2.PlaceholderText = "";
            this.txtAddress2.SelectedText = "";
            this.txtAddress2.ShadowDecoration.Parent = this.txtAddress2;
            this.txtAddress2.Size = new System.Drawing.Size(338, 191);
            this.txtAddress2.TabIndex = 3;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorName.DefaultText = "";
            this.txtVendorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorName.DisabledState.Parent = this.txtVendorName;
            this.txtVendorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorName.FocusedState.Parent = this.txtVendorName;
            this.txtVendorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorName.ForeColor = System.Drawing.Color.Black;
            this.txtVendorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorName.HoverState.Parent = this.txtVendorName;
            this.txtVendorName.Location = new System.Drawing.Point(177, 99);
            this.txtVendorName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.PasswordChar = '\0';
            this.txtVendorName.PlaceholderText = "";
            this.txtVendorName.SelectedText = "";
            this.txtVendorName.ShadowDecoration.Parent = this.txtVendorName;
            this.txtVendorName.Size = new System.Drawing.Size(338, 40);
            this.txtVendorName.TabIndex = 1;
            // 
            // txtVendorCode
            // 
            this.txtVendorCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVendorCode.DefaultText = "";
            this.txtVendorCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVendorCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVendorCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorCode.DisabledState.Parent = this.txtVendorCode;
            this.txtVendorCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVendorCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorCode.FocusedState.Parent = this.txtVendorCode;
            this.txtVendorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorCode.ForeColor = System.Drawing.Color.Black;
            this.txtVendorCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVendorCode.HoverState.Parent = this.txtVendorCode;
            this.txtVendorCode.Location = new System.Drawing.Point(177, 49);
            this.txtVendorCode.Margin = new System.Windows.Forms.Padding(6);
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.PasswordChar = '\0';
            this.txtVendorCode.PlaceholderText = "";
            this.txtVendorCode.SelectedText = "";
            this.txtVendorCode.ShadowDecoration.Parent = this.txtVendorCode;
            this.txtVendorCode.Size = new System.Drawing.Size(267, 40);
            this.txtVendorCode.TabIndex = 0;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress1.DefaultText = "";
            this.txtAddress1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress1.DisabledState.Parent = this.txtAddress1;
            this.txtAddress1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress1.FocusedState.Parent = this.txtAddress1;
            this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.ForeColor = System.Drawing.Color.Black;
            this.txtAddress1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress1.HoverState.Parent = this.txtAddress1;
            this.txtAddress1.Location = new System.Drawing.Point(177, 151);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.PasswordChar = '\0';
            this.txtAddress1.PlaceholderText = "";
            this.txtAddress1.SelectedText = "";
            this.txtAddress1.ShadowDecoration.Parent = this.txtAddress1;
            this.txtAddress1.Size = new System.Drawing.Size(338, 191);
            this.txtAddress1.TabIndex = 2;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmVendorList
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVendorList";
            this.Text = "ข้อมูลบริษัทยา";
            this.Load += new System.EventHandler(this.frmVendorList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress2;
        private Guna.UI2.WinForms.Guna2TextBox txtVendorName;
        private Guna.UI2.WinForms.Guna2TextBox txtVendorCode;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress1;
        private Guna.UI2.WinForms.Guna2TextBox txtPostCode;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVendorList;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
    }
}