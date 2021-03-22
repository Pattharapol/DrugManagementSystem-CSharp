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
    public partial class frmHowToBuyList : DevExpress.XtraEditors.XtraForm
    {
        public frmHowToBuyList()
        {
            InitializeComponent();
        }

        private void frmHowToBuy_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            txtHTB.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtHTB.Focus();
        }

        private async void FillData(string searchValue)
        {
            DataTable dt = new DataTable();
            DataCenter dc = new DataCenter();

            dgvHTB.DataSource = null;
            dt = await dc.SelectDataAsync(string.Format(@"SELECT * FROM howtobuy WHERE htbName like '%{0}%' ", searchValue));
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    dgvHTB.DataSource = dt;
                    dgvHTB.Columns[0].Visible = false;
                    dgvHTB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            if (txtHTB.Text.Trim().Length == 0)
            {
                ep.SetError(txtHTB, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtHTB.SelectAll();
                txtHTB.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check departmentName
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT htbName FROM howtobuy WHERE htbName = '{0}'", txtHTB.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtHTB, "มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtHTB.SelectAll();
                    txtHTB.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"INSERT INTO howtobuy VALUES ('{0}', '{1}')", null, txtHTB.Text.Trim()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if (txtHTB.Text.Trim().Length == 0)
            {
                ep.SetError(txtHTB, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtHTB.SelectAll();
                txtHTB.Focus();
                return;
            }

            // check if code or name is already exists...
            DataCenter dc = new DataCenter();
            // check departmentName
            DataTable dtCode = dc.SelectData(string.Format(@"SELECT htbName FROM howtobuy WHERE htbName = '{0}'", txtHTB.Text.Trim()));
            if (dtCode != null)
            {
                if (dtCode.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ep.SetError(txtHTB, "มีชื่อนี้แล้วในระบบ กรุณากรอกใหม่ครับ");
                    txtHTB.SelectAll();
                    txtHTB.Focus();
                    return;
                }
            }

            // insert
            bool result = false;
            result = dc.Insert(string.Format(@"UPDATE howtobuy SET htbName = '{0}' WHERE htb_id = '{1}')", txtHTB.Text.Trim(), dgvHTB.CurrentRow.Cells[1].Value.ToString()));
            if (result)
            {
                XtraMessageBox.Show("บันทึกการแก้ไขข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvHTB != null)
            {
                if(dgvHTB.SelectedRows.Count == 1)
                {
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;

                    txtHTB.Text = dgvHTB.CurrentRow.Cells[1].Value.ToString();
                }
            }
        }
    }
}