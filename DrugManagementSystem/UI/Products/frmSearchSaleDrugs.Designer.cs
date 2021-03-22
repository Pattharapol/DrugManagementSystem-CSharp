namespace DrugManagementSystem.UI.Products
{
    partial class frmSearchSaleDrugs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.dgvSearch = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.CheckedState.Parent = this.btnSelect;
            this.btnSelect.CustomImages.Parent = this.btnSelect;
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.Parent = this.btnSelect;
            this.btnSelect.Location = new System.Drawing.Point(840, 482);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(160, 45);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "เลือก";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(381, 32);
            this.txtSearch.TabIndex = 7;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearch.ColumnHeadersHeight = 35;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSearch.EnableHeadersVisualStyles = false;
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(11, 46);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(989, 430);
            this.dgvSearch.TabIndex = 6;
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
            this.dgvSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSearch.ThemeStyle.ReadOnly = true;
            this.dgvSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSearch.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearch_KeyDown);
            // 
            // frmSearchSaleDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 539);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSearch);
            this.Name = "frmSearchSaleDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหาเวชภัณฑ์";
            this.Load += new System.EventHandler(this.frmSearchSaleDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSearch;
    }
}