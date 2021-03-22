namespace DrugManagementSystem.UI.Products
{
    partial class frmSearchDrug
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
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchDrug = new DevExpress.XtraEditors.TextEdit();
            this.dgvSearchDrug = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchDrug.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDrug)).BeginInit();
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
            this.btnSelect.Location = new System.Drawing.Point(431, 296);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(160, 45);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "เลือก";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearchDrug
            // 
            this.txtSearchDrug.Location = new System.Drawing.Point(10, 6);
            this.txtSearchDrug.Name = "txtSearchDrug";
            this.txtSearchDrug.Size = new System.Drawing.Size(381, 32);
            this.txtSearchDrug.TabIndex = 4;
            this.txtSearchDrug.EditValueChanged += new System.EventHandler(this.txtSearchDrug_EditValueChanged);
            // 
            // dgvSearchDrug
            // 
            this.dgvSearchDrug.AllowUserToAddRows = false;
            this.dgvSearchDrug.AllowUserToDeleteRows = false;
            this.dgvSearchDrug.AllowUserToResizeColumns = false;
            this.dgvSearchDrug.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSearchDrug.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchDrug.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchDrug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearchDrug.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearchDrug.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchDrug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchDrug.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchDrug.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchDrug.EnableHeadersVisualStyles = false;
            this.dgvSearchDrug.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchDrug.Location = new System.Drawing.Point(10, 44);
            this.dgvSearchDrug.MultiSelect = false;
            this.dgvSearchDrug.Name = "dgvSearchDrug";
            this.dgvSearchDrug.ReadOnly = true;
            this.dgvSearchDrug.RowHeadersVisible = false;
            this.dgvSearchDrug.RowTemplate.Height = 24;
            this.dgvSearchDrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchDrug.Size = new System.Drawing.Size(581, 246);
            this.dgvSearchDrug.TabIndex = 3;
            this.dgvSearchDrug.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSearchDrug.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchDrug.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSearchDrug.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSearchDrug.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSearchDrug.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSearchDrug.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchDrug.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSearchDrug.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSearchDrug.ThemeStyle.ReadOnly = true;
            this.dgvSearchDrug.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearchDrug.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearchDrug.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dgvSearchDrug.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSearchDrug.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSearchDrug.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearchDrug.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSearchDrug.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSearchDrug_KeyDown);
            // 
            // frmSearchDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSearchDrug);
            this.Controls.Add(this.dgvSearchDrug);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ค้นหาเวชภัณฑ์";
            this.Load += new System.EventHandler(this.frmSearchDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchDrug.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchDrug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private DevExpress.XtraEditors.TextEdit txtSearchDrug;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSearchDrug;
    }
}