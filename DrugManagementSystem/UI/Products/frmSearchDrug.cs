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
    public partial class frmSearchDrug : DevExpress.XtraEditors.XtraForm
    {
        frmAddProducts addproductForm;
        public frmSearchDrug(string searchValue,frmAddProducts frmAddproduct)
        {
            InitializeComponent();
            txtSearchDrug.Text = searchValue;
            addproductForm = frmAddproduct;
        }

        private void frmSearchDrug_Load(object sender, EventArgs e)
        {
            SearchDrugs(txtSearchDrug.Text.Trim());
        }

        private async void SearchDrugs(string searchValue)
        {
            dgvSearchDrug.DataSource = null;
            string query = string.Empty;
            if (string.IsNullOrEmpty(searchValue))
            {
                query = string.Format(@"SELECT * FROM drug");
            }
            else
            {
                query = string.Format(@"SELECT * FROM drug WHERE drugName LIKE '%{0}%' ", searchValue.Trim());
            }

            DatabaseLayer.DataCenter dc = new DatabaseLayer.DataCenter();
            DataTable dt = await dc.SelectDataAsync(query);
            dgvSearchDrug.DataSource = dt;
            dgvSearchDrug.Columns[0].Visible = false;
            dgvSearchDrug.Columns[1].Visible = false;
            dgvSearchDrug.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSearchDrug.Columns[3].Visible = false;
            dgvSearchDrug.Columns[4].Visible = false;
            dgvSearchDrug.Columns[5].Visible = false;
            dgvSearchDrug.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchDrug.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSearchDrug.Columns[8].Visible = false;
            dgvSearchDrug.Columns[9].Visible = false;
        }

        private void txtSearchDrug_EditValueChanged(object sender, EventArgs e)
        {
            SearchDrugs(txtSearchDrug.Text.Trim());
        }

        // สร้างฟังก์ชั่นไว้สำหรับเลือกอันที่จะใช้
        private void SelectDrug()
        {
            if (addproductForm != null)
            {
                addproductForm.lblDrug_id.Text = dgvSearchDrug.CurrentRow.Cells[0].Value.ToString(); // drug_id
                addproductForm.txtDrugs.Text = dgvSearchDrug.CurrentRow.Cells[2].Value.ToString(); // drugName
                addproductForm.txtPack.Text = dgvSearchDrug.CurrentRow.Cells[6].Value.ToString(); // pack
                addproductForm.txtPrice.Text = dgvSearchDrug.CurrentRow.Cells[7].Value.ToString(); // price
                addproductForm.txtQty.Focus();
                this.Close();
                
            }
        }

        private void dgvSearchDrug_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgvSearchDrug.Rows.Count > 0)
                {
                    if(dgvSearchDrug.SelectedRows.Count == 1)
                    {
                        SelectDrug();
                    }
                    else
                    {
                        MessageBox.Show("เลือกรายการเวชภัณฑ์ก่อนครับ");
                    }
                }
                else
                {
                    MessageBox.Show("เลือกรายการเวชภัณฑ์ก่อนครับ");
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvSearchDrug.Rows.Count > 0)
            {
                if (dgvSearchDrug.SelectedRows.Count == 1)
                {
                    SelectDrug();
                }
                else
                {
                    MessageBox.Show("เลือกรายการเวชภัณฑ์ก่อนครับ");
                }
            }
            else
            {
                MessageBox.Show("เลือกรายการเวชภัณฑ์ก่อนครับ");
            }
        }
    }
}