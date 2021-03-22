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
    public partial class frmSaleProducts : DevExpress.XtraEditors.XtraForm
    {
        // ส่งค่า user_id มาจาก frmMain
        int user_id;
        public frmSaleProducts(int userID)
        {
            InitializeComponent();
            this.user_id = userID;
        }

        private async void FillData()
        {
            DataCenter dc = new DataCenter();
            DataTable dtSale = new DataTable();

            dgvSaleProducts.DataSource = null;
            string sql = string.Format(@"SELECT * FROM saledata_dummy");
            dtSale = await dc.SelectDataAsync(sql);

            dgvSaleProducts.DataSource = dtSale;

            // นับแถว
            lblCount.Visible = true;
            lblCount.Text = "ทั้งหมด " + (dgvSaleProducts.Rows.Count - 1)  +" รายการ";

            // มูลค่ารวม
            lblTotalPrice.Visible = true;
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgvSaleProducts.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells[9].Value);
            }
            lblTotalPrice.Text = Convert.ToString(totalPrice) ;
        }

        private void ClearForm()
        {
            txtDrug.Text = "";
            lblDrugID.Text = "";
            txtQty.Text = "";
            txtPack.Text = "";
            txtPrice.Text = "";
            txtTotalPrice.Text = "";
            txtDrug.Focus();
        }

        private void Cancel()
        {
            txtSaleNo.Text = "";
            cmbDepartment.SelectedIndex = 0;
            txtSaleNo.Focus();
            txtDrug.Text = "";
            lblDrugID.Text = "";
            txtQty.Text = "";
            txtPack.Text = "";
            txtPrice.Text = "";
            txtTotalPrice.Text = "";
            lblCount.Visible = false;
            lblTotalPrice.Visible = false;
        }

        private void frmSaleProducts_Load(object sender, EventArgs e)
        {
            DatabaseLayer.DataCenter dc = new DatabaseLayer.DataCenter();
            // เติมข้อมูลใส่ combobox Department บันทึกโดยใช้ combobox.SelectedValue
            DataTable dtDepartment = dc.ComboboxHelper(cmbDepartment, "departmentName", "---เลือกรายการ---", "SELECT department_id, departmentName FROM department");
            cmbDepartment.DataSource = dtDepartment;
            cmbDepartment.DisplayMember = "departmentName";
            cmbDepartment.ValueMember = "department_id";

            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if(txtSaleNo.Text.Trim().Length != 7)
            {
                ep.SetError(txtSaleNo, "กรุณาตรวจสอบข้อมูลใบเบิกด้วยครับ");
                txtSaleNo.SelectAll();
                txtSaleNo.Focus();
                return;
            }
            if(cmbDepartment.SelectedIndex == 0)
            {
                ep.SetError(cmbDepartment, "กรุณาเลือกหน่วยงานที่ต้องการเบิกด้วยครับ");
                return;
            }
            if(txtDrug.Text.Trim().Length == 0)
            {
                ep.SetError(txtDrug, "กรุณาตรวจสอบรายการเวชภัณฑ์ด้วยครับ");
                txtDrug.SelectAll();
                txtDrug.Focus();
                return;
            }
            if (txtQty.Text.Trim().Length == 0)
            {
                ep.SetError(txtQty, "กรุณาตรวจสอบจำนวนเวชภัณฑ์ด้วยครับ");
                txtQty.SelectAll();
                txtQty.Focus();
                return;
            }
            if (txtPack.Text.Trim().Length == 0)
            {
                ep.SetError(txtPack, "กรุณาตรวจสอบขนาดบรรจุด้วยครับ");
                txtPack.SelectAll();
                txtPack.Focus();
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                ep.SetError(txtPrice, "กรุณาตรวจสอบราคาเวชภัณฑ์ด้วยครับ");
                txtPrice.SelectAll();
                txtPrice.Focus();
                return;
            }
            if (txtTotalPrice.Text.Trim().Length == 0)
            {
                ep.SetError(txtTotalPrice, "กรุณาตรวจสอบมูลค่าเวชภัณฑ์ทั้งหมดด้วยครับ");
                txtTotalPrice.SelectAll();
                txtTotalPrice.Focus();
                return;
            }

            try
            {
                //ตรวจสอบว่า เบิกเกินจากที่เหลือในแต่ละล็อตหรือไม่
                int remain = Convert.ToInt32(txtRemaining.Text);
                int sale = Convert.ToInt32(txtQty.Text);
                if (sale > remain)
                {
                    ep.SetError(txtQty, "กรุณาตรวจสอบจำนวนที่จะเบิก กับ จำนวนคงเหลือด้วยครับ");
                    txtQty.SelectAll();
                    txtQty.Focus();
                    return;
                }
            }
            catch
            {
                
            }

            // รูปแบบ วันเดือนปี ใช้แบบนี้ทั้งหมดนะ
            string saleDate = (Convert.ToDateTime(dtSaleDate.Value)).ToString("yyyy-MM-dd");

            //insert 
            string sql = string.Format(@"INSERT INTO saledata_dummy VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", 
                null, 
                user_id, 
                cmbDepartment.SelectedValue, 
                txtSaleNo.Text.Trim(), 
                lblDrugID.Text.Trim(), 
                lblLastStock.Text.Trim(), 
                txtQty.Text.Trim(), 
                txtPack.Text.Trim(), 
                txtPrice.Text.Trim(), 
                txtTotalPrice.Text.Trim(), 
                Convert.ToInt32(lblLastStock.Text.Trim()) - (Convert.ToInt32(txtQty.Text.Trim()) * Convert.ToInt32(txtPack.Text.Trim())),
                saleDate, 
                txtLotNo.Text.Trim());

            DataCenter dc = new DataCenter();
            bool result = dc.Insert(sql);
            if (result)
            {
                XtraMessageBox.Show("บันทึกสำเร็จ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData();
                ClearForm();
            }

        }

        private void txtDrug_KeyDown(object sender, KeyEventArgs e)
        {
            // press enter and show search result in another form 
            if (e.KeyCode == Keys.Enter)
            {
                frmSearchSaleDrugs frm = new frmSearchSaleDrugs(txtDrug.Text.Trim(), this);
                frm.ShowDialog();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal qty;
                decimal.TryParse(txtQty.Text.Trim(), out qty);

                decimal price;
                decimal.TryParse(txtPrice.Text.Trim(), out price);

                txtTotalPrice.Text = Convert.ToString(qty * price);
            }
            catch
            {

            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal qty;
                decimal.TryParse(txtQty.Text.Trim(), out qty);

                decimal price;
                decimal.TryParse(txtPrice.Text.Trim(), out price);

                txtTotalPrice.Text = Convert.ToString(qty * price);
            }
            catch
            {

            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDepartment.Visible = true;
            lblDepartment.Text = cmbDepartment.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPack_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            DataCenter dc = new DataCenter();

            // รูปแบบ วันเดือนปี ใช้แบบนี้ทั้งหมดนะ
            string saleDate = (Convert.ToDateTime(dtSaleDate.Value)).ToString("yyyy-MM-dd");

            if (dgvSaleProducts != null)
            {
                if(dgvSaleProducts.Rows.Count > 0)
                {
                    if (XtraMessageBox.Show("ตรวจสอบข้อมูลแล้ว ต้องการบันทึกใช่หรือไม่", "แจ้งทราบ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        // insert into saledata
                        string sqlSaleData = string.Format(@"INSERT INTO saledata VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", null, user_id, cmbDepartment.SelectedValue, dgvSaleProducts.Rows.Count, lblTotalPrice.Text.Trim(), saleDate);
                        dc.Insert(sqlSaleData);

                        // select lastest sale_id from saledata
                        DataTable dtSaleID = dc.SelectData(string.Format(@"SELECT MAX(sale_id) FROM saledata LIMIT 1"));

                        //insert into saledatadetails
                        foreach (DataGridViewRow row in dgvSaleProducts.Rows)
                        {
                            string sqlSaleDataDetails = string.Format(@"INSERT INTO saledatadetails VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                                null,
                                dtSaleID.Rows[0][0].ToString(),
                                user_id,
                                row.Cells[3].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[5].Value.ToString(),
                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[10].Value.ToString(),
                                saleDate,row.Cells[12].Value.ToString());
                            dc.Insert(sqlSaleDataDetails);
                        }

                        // insert into stockcard
                        foreach (DataGridViewRow row in dgvSaleProducts.Rows)
                        {
                            // qty * pack * price
                            int qty = Convert.ToInt32(row.Cells[6].Value.ToString());
                            int pack = Convert.ToInt32(row.Cells[7].Value.ToString());
                            decimal price = Convert.ToDecimal(row.Cells[8].Value.ToString());
                            decimal totalPrice = qty * price;
                            decimal unitPrice = totalPrice / (qty * pack);

                            string sqlStockCard = string.Format(@"INSERT INTO stockcard VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                            null,
                            row.Cells[4].Value.ToString(),
                            saleDate,
                            row.Cells[3].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            null, 
                            null, 
                            null, 
                            qty,
                            pack,
                            price,
                            unitPrice,
                            totalPrice,
                            Convert.ToInt32(row.Cells[5].Value.ToString()) - (qty * pack),
                            row.Cells[12].Value.ToString(),
                            "");
                            dc.Insert(sqlStockCard);

                            //update drug
                            string sqlUpdate = string.Format(@"UPDATE drug SET stock = '{0}' WHERE drug_id = '{1}'", Convert.ToInt32(lblLastStock.Text) - (qty * pack), row.Cells[4].Value.ToString());
                            dc.Update(sqlUpdate);
                        }

                        dc.Delete(string.Format(@"DELETE FROM saledata_dummy"));
                        XtraMessageBox.Show("บันทึกสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSaleProducts.DataSource = null;
                        ClearForm();
                    }
                }
                else
                {
                    XtraMessageBox.Show("กรุณาทำรายการด้วยครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show("กรุณาทำรายการด้วยครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}