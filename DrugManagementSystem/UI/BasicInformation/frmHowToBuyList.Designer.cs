namespace DrugManagementSystem.UI.BasicInformation
{
    partial class frmHowToBuyList
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
            this.dgvHTB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.แกไขToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.txtSearch.Location = new System.Drawing.Point(696, 40);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(267, 40);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(640, 50);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 25);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "ค้นหา";
            // 
            // dgvHTB
            // 
            this.dgvHTB.AllowUserToAddRows = false;
            this.dgvHTB.AllowUserToDeleteRows = false;
            this.dgvHTB.AllowUserToResizeColumns = false;
            this.dgvHTB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHTB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHTB.BackgroundColor = System.Drawing.Color.White;
            this.dgvHTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHTB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHTB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHTB.ColumnHeadersHeight = 30;
            this.dgvHTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHTB.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHTB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHTB.EnableHeadersVisualStyles = false;
            this.dgvHTB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHTB.Location = new System.Drawing.Point(640, 92);
            this.dgvHTB.MultiSelect = false;
            this.dgvHTB.Name = "dgvHTB";
            this.dgvHTB.ReadOnly = true;
            this.dgvHTB.RowHeadersVisible = false;
            this.dgvHTB.RowTemplate.Height = 24;
            this.dgvHTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHTB.Size = new System.Drawing.Size(608, 600);
            this.dgvHTB.TabIndex = 36;
            this.dgvHTB.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvHTB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHTB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHTB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHTB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHTB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHTB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHTB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHTB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHTB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHTB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvHTB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHTB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHTB.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvHTB.ThemeStyle.ReadOnly = true;
            this.dgvHTB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHTB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHTB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvHTB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvHTB.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHTB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHTB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(412, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(136, 43);
            this.btnUpdate.TabIndex = 35;
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
            this.btnSave.Location = new System.Drawing.Point(270, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 34;
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
            this.btnCancel.Location = new System.Drawing.Point(412, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(136, 43);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 25);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "วิธีการสั่งซื้อ";
            // 
            // txtHTB
            // 
            this.txtHTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHTB.DefaultText = "";
            this.txtHTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHTB.DisabledState.Parent = this.txtHTB;
            this.txtHTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHTB.FocusedState.Parent = this.txtHTB;
            this.txtHTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHTB.ForeColor = System.Drawing.Color.Black;
            this.txtHTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHTB.HoverState.Parent = this.txtHTB;
            this.txtHTB.Location = new System.Drawing.Point(210, 118);
            this.txtHTB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtHTB.Name = "txtHTB";
            this.txtHTB.PasswordChar = '\0';
            this.txtHTB.PlaceholderText = "";
            this.txtHTB.SelectedText = "";
            this.txtHTB.ShadowDecoration.Parent = this.txtHTB;
            this.txtHTB.Size = new System.Drawing.Size(338, 40);
            this.txtHTB.TabIndex = 31;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 64);
            // 
            // แกไขToolStripMenuItem
            // 
            this.แกไขToolStripMenuItem.Name = "แกไขToolStripMenuItem";
            this.แกไขToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.แกไขToolStripMenuItem.Text = "แก้ไข";
            this.แกไขToolStripMenuItem.Click += new System.EventHandler(this.แกไขToolStripMenuItem_Click);
            // 
            // frmHowToBuy
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 733);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dgvHTB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtHTB);
            this.Name = "frmHowToBuy";
            this.Text = "วิธีการสั่งซื้อ";
            this.Load += new System.EventHandler(this.frmHowToBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHTB;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtHTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ToolStripMenuItem แกไขToolStripMenuItem;
    }
}