namespace DrugManagementSystem.UI.Products
{
    partial class frmCooperateCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCheck2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CoSSK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CoSubSSK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnProcess = new Guna.UI2.WinForms.Guna2Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheck2
            // 
            this.dgvCheck2.AllowUserToAddRows = false;
            this.dgvCheck2.AllowUserToDeleteRows = false;
            this.dgvCheck2.AllowUserToResizeColumns = false;
            this.dgvCheck2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCheck2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheck2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheck2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheck2.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheck2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheck2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheck2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheck2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheck2.ColumnHeadersHeight = 35;
            this.dgvCheck2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheck2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoSSK,
            this.CoSubSSK});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheck2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheck2.EnableHeadersVisualStyles = false;
            this.dgvCheck2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheck2.Location = new System.Drawing.Point(35, 138);
            this.dgvCheck2.Name = "dgvCheck2";
            this.dgvCheck2.RowHeadersVisible = false;
            this.dgvCheck2.RowTemplate.Height = 24;
            this.dgvCheck2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheck2.Size = new System.Drawing.Size(1390, 562);
            this.dgvCheck2.TabIndex = 0;
            this.dgvCheck2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCheck2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheck2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCheck2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCheck2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCheck2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCheck2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheck2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheck2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCheck2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheck2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvCheck2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCheck2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheck2.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCheck2.ThemeStyle.ReadOnly = false;
            this.dgvCheck2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheck2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheck2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvCheck2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCheck2.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCheck2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheck2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CoSSK
            // 
            this.CoSSK.HeaderText = "CoSSK";
            this.CoSSK.Name = "CoSSK";
            this.CoSSK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CoSSK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CoSubSSK
            // 
            this.CoSubSSK.HeaderText = "CoSubSSK";
            this.CoSubSSK.Name = "CoSubSSK";
            this.CoSubSSK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CoSubSSK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(333, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(106, 52);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.CheckedState.Parent = this.btnProcess;
            this.btnProcess.CustomImages.Parent = this.btnProcess;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.HoverState.Parent = this.btnProcess;
            this.btnProcess.Location = new System.Drawing.Point(1245, 70);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.ShadowDecoration.Parent = this.btnProcess;
            this.btnProcess.Size = new System.Drawing.Size(180, 52);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "ประมวลผล";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(757, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "รายการ";
            // 
            // lblCount
            // 
            this.lblCount.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblCount.Appearance.Options.UseFont = true;
            this.lblCount.Appearance.Options.UseForeColor = true;
            this.lblCount.Location = new System.Drawing.Point(723, 92);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 31);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPrice.Appearance.Options.UseFont = true;
            this.lblTotalPrice.Appearance.Options.UseForeColor = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(1021, 93);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(13, 31);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(917, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "รวมมูลค่า";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(640, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 25);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "ทั้งหมด";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1165, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 25);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "บาท";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(35, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(149, 25);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "ค้นหาจากเลขรับเข้า";
            // 
            // frmCooperateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 740);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCheck2);
            this.Name = "frmCooperateCheck";
            this.Text = "ประมวลผล";
            this.Load += new System.EventHandler(this.frmCooperateCheck2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCheck2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnProcess;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoSSK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoSubSSK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCount;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}