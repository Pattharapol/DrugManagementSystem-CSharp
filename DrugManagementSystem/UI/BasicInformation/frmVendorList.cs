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

namespace DrugManagementSystem.UI.BasicInformation
{
    public partial class frmVendorList : DevExpress.XtraEditors.XtraForm
    {
        public frmVendorList()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtVendorCode.Clear();
            txtVendorName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtPostCode.Clear();
            txtVendorCode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private async void FillData(string searchValue)
        {
            DataTable dt = new DataTable();
            DataCenter dc = new DataCenter();

            dgvVendorList.DataSource = null;
            dt = await dc.SelectDataAsync(string.Format(@"SELECT * FROM vendor WHERE vendorName LIKE '%{0}%' OR vendorCode LIKE '%{1}%'", searchValue, searchValue));
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    dgvVendorList.DataSource = dt;
                    dgvVendorList.Columns[0].Visible = false;
                    dgvVendorList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvVendorList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvVendorList.Columns[5].Visible = false;
                }
            }
        }

        private void frmVendorList_Load(object sender, EventArgs e)
        {
            FillData(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            // validate input data
            if (txtVendorCode.Text.Trim().Length == 0)
            {
                ep.SetError(txtVendorCode, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtVendorCode.SelectAll();
                txtVendorCode.Focus();
                return;
            }
            if (txtVendorName.Text.Trim().Length == 0)
            {
                ep.SetError(txtVendorName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtVendorName.SelectAll();
                txtVendorName.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check vendorCode
            DataTable dtCheckvendorCode = dc.SelectData(string.Format(@"SELECT vendorCode FROM vendor WHERE vendorCode = '{0}'", txtVendorCode.Text.Trim()));
            if (dtCheckvendorCode != null)
            {
                if(dtCheckvendorCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtVendorCode, "มีรหัสนี้แล้วในระบบ กรุณาหรอกใหม่ครับ");
                        txtVendorCode.SelectAll();
                        txtVendorCode.Focus();
                        return;
                }
            }
            // check vendorName
            DataTable dtCheckvendorname = dc.SelectData(string.Format(@"SELECT vendorName FROM vendor WHERE vendorName = '{0}'", txtVendorName.Text.Trim()));
            if (dtCheckvendorname != null)
            {
                if (dtCheckvendorname.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อบริษัทนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtVendorName, "มีชื่อบริษัทนี้แล้วในระบบ กรุณาหรอกใหม่ครับ");
                    txtVendorName.SelectAll();
                    txtVendorName.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"INSERT INTO vendor VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", null, txtVendorCode.Text.Trim(), txtVendorName.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(), txtPostCode.Text.Trim()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกข้อมูลสำเร็จแล้วครับ","แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvVendorList != null)
            {
                if(dgvVendorList.SelectedRows.Count == 1)
                {
                    try
                    {
                        btnSave.Enabled = false;
                        btnUpdate.Enabled = true;
                        txtVendorCode.Text = dgvVendorList.CurrentRow.Cells[1].Value.ToString();
                        txtVendorName.Text = dgvVendorList.CurrentRow.Cells[2].Value.ToString();
                        txtAddress1.Text = dgvVendorList.CurrentRow.Cells[3].Value.ToString();
                        txtAddress2.Text = dgvVendorList.CurrentRow.Cells[4].Value.ToString();
                        txtPostCode.Text = dgvVendorList.CurrentRow.Cells[5].Value.ToString();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("คุณต้องการแก้ไข ใช่หรือไม่", "แจ้งทราบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // validate input data
                if (txtVendorCode.Text.Trim().Length == 0)
                {
                    ep.SetError(txtVendorCode, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                    txtVendorCode.SelectAll();
                    txtVendorCode.Focus();
                    return;
                }
                if (txtVendorName.Text.Trim().Length == 0)
                {
                    ep.SetError(txtVendorName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                    txtVendorName.SelectAll();
                    txtVendorName.Focus();
                    return;
                }

                // check if code or name is already exists...
                DataCenter dc = new DataCenter();
                // check vendorCode
                DataTable dtCheckvendorCode = dc.SelectData(string.Format(@"SELECT vendorCode FROM vendor WHERE vendorCode = '{0}'", txtVendorCode.Text.Trim()));
                if (dtCheckvendorCode != null)
                {
                    if (dtCheckvendorCode.Rows.Count > 0)
                    {
                        XtraMessageBox.Show("มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ep.SetError(txtVendorCode, "มีรหัสนี้แล้วในระบบ กรุณาหรอกใหม่ครับ");
                        txtVendorCode.SelectAll();
                        txtVendorCode.Focus();
                        return;
                    }
                }
                // check vendorName
                DataTable dtCheckvendorname = dc.SelectData(string.Format(@"SELECT vendorName FROM vendor WHERE vendorName = '{0}'", txtVendorName.Text.Trim()));
                if (dtCheckvendorname != null)
                {
                    if (dtCheckvendorname.Rows.Count > 0)
                    {
                        XtraMessageBox.Show("มีชื่อบริษัทนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ep.SetError(txtVendorName, "มีชื่อบริษัทนี้แล้วในระบบ กรุณาหรอกใหม่ครับ");
                        txtVendorName.SelectAll();
                        txtVendorName.Focus();
                        return;
                    }
                }

                bool result = false;
                result = dc.Update(string.Format(@"UPDATE vendor SET vendorCode = '{0}', vendorName = '{1}', Address1 = '{2}', Address2 = '{3}', Postcode = '{4}' WHERE vendor_id = '{5}'", txtVendorCode.Text.Trim(), txtVendorName.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(), txtPostCode.Text.Trim(), dgvVendorList.CurrentRow.Cells[0].Value.ToString()));
                if (result)
                {
                    XtraMessageBox.Show("บันทึกการแก้ไขข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillData(string.Empty);
                    ClearForm();
                }
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
    }
}