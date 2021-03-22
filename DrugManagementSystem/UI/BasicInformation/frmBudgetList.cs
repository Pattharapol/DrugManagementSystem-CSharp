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
    public partial class frmBudgetList : DevExpress.XtraEditors.XtraForm
    {
        public frmBudgetList()
        {
            InitializeComponent();
        }

        private void frmBudgetList_Load(object sender, EventArgs e)
        {
            FillData(string.Empty);
        }

        private void ClearForm()
        {
            txtBudgetCode.Clear();
            txtBudgetType.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBudgetCode.Focus();
        }

        private async void FillData(string searchValue)
        {
            DataTable dt = new DataTable();
            DataCenter dc = new DataCenter();

            dgvBudgetTypeList.DataSource = null;
            dt = await dc.SelectDataAsync(string.Format(@"SELECT * FROM budget WHERE budgetType like '%{0}%' ", searchValue));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvBudgetTypeList.DataSource = dt;
                    dgvBudgetTypeList.Columns[0].Visible = false;
                    dgvBudgetTypeList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvBudgetTypeList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBudgetTypeList != null)
            {
                if (dgvBudgetTypeList.SelectedRows.Count == 1)
                {
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    txtBudgetCode.Text = dgvBudgetTypeList.CurrentRow.Cells[1].Value.ToString();
                    txtBudgetType.Text = dgvBudgetTypeList.CurrentRow.Cells[2].Value.ToString();
                    txtBudgetCode.SelectAll();
                    txtBudgetCode.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if(txtBudgetCode.Text.Trim().Length == 0)
            {
                ep.SetError(txtBudgetCode, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtBudgetCode.SelectAll();
                txtBudgetCode.Focus();
                return;
            }
            if (txtBudgetType.Text.Trim().Length == 0)
            {
                ep.SetError(txtBudgetType, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtBudgetType.SelectAll();
                txtBudgetType.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check BudgetCode
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT budgetCode FROM budget WHERE budgetCode = '{0}'", txtBudgetCode.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtBudgetCode, "มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtBudgetCode.SelectAll();
                    txtBudgetCode.Focus();
                    return;
                }
            }
            // check vendorName
            DataTable dtType= dc.SelectData(string.Format(@"SELECT budgetType FROM budget WHERE budgetType = '{0}'", txtBudgetType.Text.Trim()));
            if (dtType != null)
            {
                if (dtType.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อเงินงบประมาณนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtBudgetType, "มีชื่อเงินงบประมาณนี้แล้วในระบบ กรุณาหรอกใหม่ครับ");
                    txtBudgetType.SelectAll();
                    txtBudgetType.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"INSERT INTO budget VALUES ('{0}', '{1}','{2}')", null, txtBudgetCode.Text.Trim(), txtBudgetType.Text.Trim()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if (txtBudgetCode.Text.Trim().Length == 0)
            {
                ep.SetError(txtBudgetCode, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtBudgetCode.SelectAll();
                txtBudgetCode.Focus();
                return;
            }
            if (txtBudgetType.Text.Trim().Length == 0)
            {
                ep.SetError(txtBudgetType, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtBudgetType.SelectAll();
                txtBudgetType.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check BudgetCode
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT budgetCode FROM budget WHERE budgetCode = '{0}'", txtBudgetCode.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtBudgetCode, "มีรหัสนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtBudgetCode.SelectAll();
                    txtBudgetCode.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"UPDATE budget SET budgetCode = '{0}', budgetType = '{1}' WHERE budget_id = '{2}'", txtBudgetCode.Text.Trim(), txtBudgetType.Text.Trim(), dgvBudgetTypeList.CurrentRow.Cells[0].Value.ToString()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกการแก้ไขข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }
    }
}