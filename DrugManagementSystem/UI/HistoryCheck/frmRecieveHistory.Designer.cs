namespace DrugManagementSystem.UI.HistoryCheck
{
    partial class frmRecieveHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecieveHistory));
            this.dtpFind1 = new DevExpress.XtraEditors.DateEdit();
            this.dtpFind2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgvSearch = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoSSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoSubSSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFind1
            // 
            this.dtpFind1.EditValue = null;
            this.dtpFind1.Location = new System.Drawing.Point(221, 37);
            this.dtpFind1.Name = "dtpFind1";
            this.dtpFind1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFind1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFind1.Size = new System.Drawing.Size(259, 32);
            this.dtpFind1.TabIndex = 2;
            // 
            // dtpFind2
            // 
            this.dtpFind2.EditValue = null;
            this.dtpFind2.Location = new System.Drawing.Point(537, 37);
            this.dtpFind2.Name = "dtpFind2";
            this.dtpFind2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFind2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFind2.Size = new System.Drawing.Size(259, 32);
            this.dtpFind2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(142, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ค้นหาจากวันที่รับ : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(499, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "ถึง";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSearch.ColumnHeadersHeight = 35;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.CoSSK,
            this.CoSubSSK});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(51, 98);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(1406, 622);
            this.dgvSearch.TabIndex = 7;
            this.dgvSearch.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSearch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSearch.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSearch.ThemeStyle.ReadOnly = true;
            this.dgvSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSearch.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "receiveNo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 124;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "invoiceNo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 124;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "orderNo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "drugName";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 129;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "qty";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 65;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "pack";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 78;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column13.HeaderText = "price";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.Width = 81;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column14.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column14.HeaderText = "totalPrice";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.Width = 119;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column16.HeaderText = "lotNo";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.Width = 86;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column19.HeaderText = "receiveDate";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column19.Width = 138;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column20.HeaderText = "expDate";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column20.Width = 108;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column21.HeaderText = "orderDate";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column21.Width = 124;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column22.HeaderText = "approveDate";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column22.Width = 147;
            // 
            // CoSSK
            // 
            this.CoSSK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoSSK.HeaderText = "CoSSK";
            this.CoSSK.Name = "CoSSK";
            this.CoSSK.ReadOnly = true;
            this.CoSSK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoSSK.Width = 93;
            // 
            // CoSubSSK
            // 
            this.CoSubSSK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoSubSSK.HeaderText = "CoSubSSK";
            this.CoSubSSK.Name = "CoSubSSK";
            this.CoSubSSK.ReadOnly = true;
            this.CoSubSSK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CoSubSSK.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(839, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(160, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1018, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(160, 45);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "PDF";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmRecieveHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 756);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtpFind2);
            this.Controls.Add(this.dtpFind1);
            this.Name = "frmRecieveHistory";
            this.Text = "ดูประวัติการรับเข้า";
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFind2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dtpFind1;
        private DevExpress.XtraEditors.DateEdit dtpFind2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoSSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoSubSSK;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}