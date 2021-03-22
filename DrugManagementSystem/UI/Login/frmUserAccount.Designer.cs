namespace DrugManagementSystem.UI.Login
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUserAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.txtUserLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.lblConfirmPassword = new DevExpress.XtraEditors.LabelControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pbConfirmPassword = new DevExpress.XtraEditors.PictureEdit();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(92, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ชื่อผู้ใช้งาน";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 765);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUserAccount);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 765);
            this.panel2.TabIndex = 2;
            // 
            // dgvUserAccount
            // 
            this.dgvUserAccount.AllowUserToAddRows = false;
            this.dgvUserAccount.AllowUserToDeleteRows = false;
            this.dgvUserAccount.AllowUserToResizeColumns = false;
            this.dgvUserAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUserAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserAccount.ColumnHeadersHeight = 30;
            this.dgvUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.status});
            this.dgvUserAccount.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserAccount.EnableHeadersVisualStyles = false;
            this.dgvUserAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUserAccount.Location = new System.Drawing.Point(577, 90);
            this.dgvUserAccount.MultiSelect = false;
            this.dgvUserAccount.Name = "dgvUserAccount";
            this.dgvUserAccount.ReadOnly = true;
            this.dgvUserAccount.RowHeadersVisible = false;
            this.dgvUserAccount.RowTemplate.Height = 24;
            this.dgvUserAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAccount.Size = new System.Drawing.Size(647, 653);
            this.dgvUserAccount.TabIndex = 3;
            this.dgvUserAccount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvUserAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUserAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUserAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUserAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUserAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUserAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUserAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUserAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvUserAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUserAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserAccount.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvUserAccount.ThemeStyle.ReadOnly = true;
            this.dgvUserAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvUserAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUserAccount.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUserAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUserAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUserAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccount_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(657, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 32);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(593, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ค้นหา";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pbConfirmPassword);
            this.groupControl1.Controls.Add(this.lblConfirmPassword);
            this.groupControl1.Controls.Add(this.txtConfirmPassword);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.lbl);
            this.groupControl1.Controls.Add(this.txtUserLogin);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtLastName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtFirstname);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(27, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(516, 503);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "รายละเอียดผู้ใช้งาน";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(197, 254);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(204, 32);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.EditValueChanged += new System.EventHandler(this.txtConfirmPassword_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(66, 257);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(109, 25);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "ยืนยันรหัสผ่าน";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.Enabled = false;
            this.btnEdit.FillColor = System.Drawing.Color.Blue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(266, 326);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(135, 41);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "บันทึกแก้ไข";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(133, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(127, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(204, 32);
            this.txtPassword.TabIndex = 9;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(110, 209);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 25);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "รหัสผ่าน";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(197, 157);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(204, 32);
            this.txtUserLogin.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(78, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 25);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "ชื่อเข้าใช้งาน";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(197, 108);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 32);
            this.txtLastName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 25);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "นามสกุลผู้ใช้งาน";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(197, 59);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(204, 32);
            this.txtFirstname.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPassword.Appearance.Options.UseForeColor = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(197, 292);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(148, 25);
            this.lblConfirmPassword.TabIndex = 15;
            this.lblConfirmPassword.Text = "**รหัสผ่านไม่ตรงกัน";
            this.lblConfirmPassword.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "FirstName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "LastName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Login";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 86;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Password";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "isActive";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Width = 66;
            // 
            // pbConfirmPassword
            // 
            this.pbConfirmPassword.EditValue = ((object)(resources.GetObject("pbConfirmPassword.EditValue")));
            this.pbConfirmPassword.Location = new System.Drawing.Point(365, 286);
            this.pbConfirmPassword.Name = "pbConfirmPassword";
            this.pbConfirmPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pbConfirmPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbConfirmPassword.Size = new System.Drawing.Size(36, 36);
            this.pbConfirmPassword.TabIndex = 16;
            this.pbConfirmPassword.Visible = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
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
            // frmUserAccount
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUserAccount";
            this.Text = "จัดการข้อมูลผู้ใช้งาน";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserAccount;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.TextEdit txtUserLogin;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblConfirmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewLinkColumn status;
        private DevExpress.XtraEditors.PictureEdit pbConfirmPassword;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
    }
}