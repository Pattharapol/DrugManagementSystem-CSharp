using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DrugManagementSystem.UI.Products
{
    public partial class frmSearchVendor : DevExpress.XtraEditors.XtraForm
    {
        frmAddProducts addproductForm;
        public frmSearchVendor(string searchValue, frmAddProducts addproduct)
        {
            // รับค่ามาจาก frmAddProducts เพื่อค้นหา Vendor
            InitializeComponent();
            addproductForm = addproduct;
            txtSearchVendor.Text = searchValue;
            //txtSearchVendor.SelectAll();
            //txtSearchVendor.Focus();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            SearchVendor(txtSearchVendor.Text.Trim());
            //txtSearchVendor.SelectAll();
            //txtSearchVendor.Focus();
        }

        private async void SearchVendor(string searchValue)
        {
            dgvSearchVendor.DataSource = null;
            string query = string.Empty;
            if (string.IsNullOrEmpty(searchValue))
            {
                query = string.Format(@"select * from vendor");
            }
            else
            {
                query = string.Format(@"select * from vendor where vendorName like '%{0}%' or vendorCode like '%{1}%' ", searchValue.Trim(), searchValue.Trim());
            }

            DatabaseLayer.DataCenter dc = new DatabaseLayer.DataCenter();
            DataTable dt = await dc.SelectDataAsync(query);
            dgvSearchVendor.DataSource = dt;
            dgvSearchVendor.Columns[0].Visible = false;
            dgvSearchVendor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchVendor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchVendor.Columns[3].Visible = false;
            dgvSearchVendor.Columns[4].Visible = false;
            dgvSearchVendor.Columns[5].Visible = false;
        }

        private void txtSearchProduct_EditValueChanged(object sender, EventArgs e)
        {
            SearchVendor(txtSearchVendor.Text.Trim());
        }

        // สร้างฟังก์ชั่นไว้สำหรับเลือกอันที่จะใช้
        private void SelectVendor()
        {
            if(addproductForm != null)
            {
                addproductForm.txtVendor.Text = dgvSearchVendor.CurrentRow.Cells[2].Value.ToString();
                addproductForm.lblVendor_ID.Text = dgvSearchVendor.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void dgvSearchProducts_KeyDown(object sender, KeyEventArgs e)
        {
            // enter จาก datagridview 
            if(e.KeyCode == Keys.Enter)
            {
                if (dgvSearchVendor.Rows.Count > 0)
                {
                    if (dgvSearchVendor.SelectedRows.Count == 1)
                    {
                        SelectVendor();
                    }
                }
                else
                {
                    MessageBox.Show("เลือกบริษัทยาก่อนครับ");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dgvSearchVendor.Rows.Count > 0)
            {
                if (dgvSearchVendor.SelectedRows.Count == 1)
                {
                    SelectVendor();
                }
            }
            else
            {
                MessageBox.Show("เลือกบริษัทยาก่อนครับ");
            }
        }
    }
}