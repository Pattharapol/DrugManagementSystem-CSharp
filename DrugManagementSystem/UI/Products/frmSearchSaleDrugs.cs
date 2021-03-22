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
using DrugManagementSystem.DatabaseLayer;

namespace DrugManagementSystem.UI.Products
{
    public partial class frmSearchSaleDrugs : DevExpress.XtraEditors.XtraForm
    {
        frmSaleProducts saleProducts;
        public frmSearchSaleDrugs(string searchValue, frmSaleProducts frmSaleProducts)
        {
            InitializeComponent();
            this.txtSearch.Text = searchValue;
            this.saleProducts = frmSaleProducts;
        }

        private void frmSearchSaleDrugs_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private async void FillData()
        {
            DataCenter dc = new DataCenter();
            DataTable dtSearch = new DataTable();

            string sql = string.Format(@"SELECT stc.stock_id, drg.drug_id, drg.drugName, drg.pack, drg.price ,stc.lastStock, stc.lotNo, stc.expDate, drg.stock FROM stockcard AS stc LEFT JOIN drug AS drg ON stc.drug_id = drg.drug_id WHERE drg.drugname LIKE '%{0}%' AND stc.lastStock > 0  GROUP BY stc.lotNo ORDER BY stc.stock_id DESC ", txtSearch.Text.Trim());
            dtSearch = await dc.SelectDataAsync(sql);
            if(dtSearch != null)
            {
                if(dtSearch.Rows.Count > 0)
                {
                    dgvSearch.DataSource = dtSearch;

                    dgvSearch.Columns[0].Visible = false;
                    dgvSearch.Columns[1].Visible = false;

                    dgvSearch.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvSearch.Columns[3].Width = 60;
                    dgvSearch.Columns[4].Width = 60;
                    dgvSearch.Columns[5].Width = 60;
                    dgvSearch.Columns[6].Width = 80;
                    dgvSearch.Columns[7].Width = 80;
                    dgvSearch.Columns[8].Visible = false;

                }
            }
            else
            {
                XtraMessageBox.Show("ไม่พบข้อมูลเวชภัณฑ์ดังกล่าว กรุณาลองใหม่อีกครั้ง", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(saleProducts != null)
                {
                    if(dgvSearch.SelectedRows.Count == 1)
                    {
                        saleProducts.lblDrugID.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                        saleProducts.txtDrug.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                        saleProducts.txtPack.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
                        saleProducts.txtPrice.Text = dgvSearch.CurrentRow.Cells[4].Value.ToString();
                        saleProducts.txtRemaining.Text = dgvSearch.CurrentRow.Cells[5].Value.ToString();
                        saleProducts.txtLotNo.Text = dgvSearch.CurrentRow.Cells[6].Value.ToString();
                        saleProducts.lblLastStock.Text = dgvSearch.CurrentRow.Cells[8].Value.ToString();
                        saleProducts.txtQty.Focus();
                        this.Close();
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (saleProducts != null)
            {
                if (dgvSearch.SelectedRows.Count == 1)
                {
                    saleProducts.lblDrugID.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();
                    saleProducts.txtDrug.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();
                    saleProducts.txtPack.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();
                    saleProducts.txtPrice.Text = dgvSearch.CurrentRow.Cells[4].Value.ToString();
                    saleProducts.txtRemaining.Text = dgvSearch.CurrentRow.Cells[5].Value.ToString();
                    saleProducts.txtLotNo.Text = dgvSearch.CurrentRow.Cells[6].Value.ToString();
                    saleProducts.lblLastStock.Text = dgvSearch.CurrentRow.Cells[8].Value.ToString();
                    saleProducts.txtQty.Focus();
                    this.Close();
                }
            }
        }
    }
}