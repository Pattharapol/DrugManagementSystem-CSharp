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
    public partial class frmDepartmentList : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartmentList()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            FillData(string.Empty);
        }

        private void ClearForm()
        {
            txtDepartmentName.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtDepartmentName.Focus();
        }

        private async void FillData(string searchValue)
        {
            DataTable dt = new DataTable();
            DataCenter dc = new DataCenter();
            string sql = "";
            if (string.IsNullOrEmpty(searchValue))
            {
                sql = string.Format(@"SELECT * FROM department");
            }
            else
            {
                sql = string.Format(@"SELECT * FROM department WHERE departmentName like '%{0}%' ", searchValue);
            }

            dgvDepartment.DataSource = null;
            dt = await dc.SelectDataAsync(sql);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvDepartment.DataSource = dt;
                    dgvDepartment.Columns[0].Visible = false;
                    dgvDepartment.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            if (txtDepartmentName.Text.Trim().Length == 0)
            {
                ep.SetError(txtDepartmentName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtDepartmentName.SelectAll();
                txtDepartmentName.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check departmentName
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT departmentName FROM department WHERE departmentName = '{0}'", txtDepartmentName.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtDepartmentName, "มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtDepartmentName.SelectAll();
                    txtDepartmentName.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"INSERT INTO department VALUES ('{0}', '{1}')", null, txtDepartmentName.Text.Trim()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvDepartment != null)
            {
                if(dgvDepartment.SelectedRows.Count == 1)
                {
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    txtDepartmentName.Text = dgvDepartment.CurrentRow.Cells[1].Value.ToString();
                    txtDepartmentName.SelectAll();
                    txtDepartmentName.Focus();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if (txtDepartmentName.Text.Trim().Length == 0)
            {
                ep.SetError(txtDepartmentName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtDepartmentName.SelectAll();
                txtDepartmentName.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check departmentName
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT departmentName FROM department WHERE departmentName = '{0}'", txtDepartmentName.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtDepartmentName, "มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtDepartmentName.SelectAll();
                    txtDepartmentName.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"UPDATE department SET departmentName = '{0}' WHERE department_id = '{1}')", txtDepartmentName.Text.Trim(), dgvDepartment.CurrentRow.Cells[0].Value.ToString()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกการแก้ไขข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }
    }
}