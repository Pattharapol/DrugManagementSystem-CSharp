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
    public partial class frmDrugList : DevExpress.XtraEditors.XtraForm
    {
        public frmDrugList()
        {
            InitializeComponent();
        }

        private void frmDrugList_Load(object sender, EventArgs e)
        {
            FillData(string.Empty);
            FillCombobox();
        }

        private void ClearForm()
        {
            cmbDruggroup.SelectedIndex = 0;
            cmbDrugtype.SelectedIndex = 0;
            txtDrugName.Text = "";
            txtContain.Text = "";
            txtPack.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            txtVolume.Text = "";
            dgvDrugList.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void FillCombobox()
        {
            DatabaseLayer.DataCenter dc = new DatabaseLayer.DataCenter();
            // เติมข้อมูลใส่ combobox cmbDruggroup บันทึกโดยใช้ combobox.SelectedValue
            DataTable dtDruggroup = dc.ComboboxHelper(cmbDruggroup, "druggroupName", "---เลือกรายการ---", "select druggroup_id, druggroupName from druggroup");
            cmbDruggroup.DataSource = dtDruggroup;
            cmbDruggroup.DisplayMember = "druggroupName";
            cmbDruggroup.ValueMember = "druggroup_id";

            // เติมข้อมูลใส่ combobox cmbDruggroup บันทึกโดยใช้ combobox.SelectedValue
            DataTable dtDrugtype = dc.ComboboxHelper(cmbDrugtype, "typeName", "---เลือกรายการ---", "select type_id, typeName from type");
            cmbDrugtype.DataSource = dtDrugtype;
            cmbDrugtype.DisplayMember = "typeName";
            cmbDrugtype.ValueMember = "type_id";
        }

        private async void FillData(string searchValue)
        {
            string sql = null;
            dgvDrugList.DataSource = null;
            DataCenter dc = new DataCenter();

            if (string.IsNullOrEmpty(searchValue))
            {
                sql = string.Format(@"SELECT d.drug_id, dg.druggroup_id, dg.druggroupName, d.drugName, d.contain, d.volume, t.type_id ,t.typeName, d.pack, d.price, d.stock, d.unit FROM drug AS d LEFT JOIN druggroup AS dg ON d.druggroup_id = dg.druggroup_id LEFT JOIN type AS t ON d.type_id = t.type_id ");
            }
            else
            {
                sql = string.Format(@"SELECT d.drug_id, dg.druggroup_id, dg.druggroupName, d.drugName, d.contain, d.volume, t.type_id ,t.typeName, d.pack, d.price, d.stock, d.unit FROM drug AS d LEFT JOIN druggroup AS dg ON d.druggroup_id = dg.druggroup_id LEFT JOIN type AS t ON d.type_id = t.type_id WHERE drugName = '{0}'", searchValue);
            }
            
            DataTable dt = await dc.SelectDataAsync(sql);
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    dgvDrugList.DataSource = dt;

                    dgvDrugList.Columns[0].Visible = false;
                    dgvDrugList.Columns[1].Visible = false;
                    dgvDrugList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvDrugList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[6].Visible = false;
                    dgvDrugList.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvDrugList.Columns[10].Visible = false;
                    dgvDrugList.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            lblCount.Text = dgvDrugList.Rows.Count + " รายการ";
        }

        // btnSave ลืมเปลี่ยนชื่อ
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if(cmbDrugtype.SelectedIndex == 0)
            {
                ep.SetError(cmbDrugtype, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                cmbDrugtype.Focus();
                return;
            }
            if (cmbDruggroup.SelectedIndex == 0)
            {
                ep.SetError(cmbDruggroup, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                cmbDruggroup.Focus();
                return;
            }
            if (txtDrugName.Text.Trim().Length == 0)
            {
                ep.SetError(txtDrugName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtDrugName.Focus();
                return;
            }
            if (txtContain.Text.Trim().Length == 0)
            {
                ep.SetError(txtContain, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtContain.Focus();
                return;
            }
            if (txtPack.Text.Trim().Length == 0)
            {
                ep.SetError(txtPack, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtPack.Focus();
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                ep.SetError(txtPrice, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtPrice.Focus();
                return;
            }
            if (txtVolume.Text.Trim().Length == 0)
            {
                ep.SetError(txtVolume, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtVolume.Focus();
                return;
            }
            if (txtUnit.Text.Trim().Length == 0)
            {
                ep.SetError(txtUnit, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtUnit.Focus();
                return;
            }

            // check if already exist
            DataCenter dc = new DataCenter();
            string sql = string.Format(@"SELECT drugName FROM drug WHERE drugName = '{0}'", txtDrugName.Text);
            DataTable dtCheck = dc.SelectData(sql);
            if(dtCheck!= null)
            {
                if(dtCheck.Rows.Count > 0)
                {
                    XtraMessageBox.Show("มีชื่อยานี้แล้วในระบบ กรุณาตรวจสอบอีกครั้งครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDrugName.SelectAll();
                    txtDrugName.Focus();
                    return;
                }
            }

            // insert
            string sqlInsert = string.Format(@"INSERT INTO drug VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", 
                null,
                cmbDruggroup.SelectedValue, 
                txtDrugName.Text, 
                txtContain.Text.Trim(), 
                txtVolume.Text.Trim(), 
                cmbDrugtype.SelectedValue, 
                txtPack.Text.Trim(), 
                txtPrice.Text.Trim(), 
                0, 
                txtUnit.Text.Trim());
            bool result = dc.Insert(sqlInsert);
            if (result)
            {
                XtraMessageBox.Show("บันทึกข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearForm();
                FillData(string.Empty);
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvDrugList != null)
            {
                if(dgvDrugList.SelectedRows.Count == 1)
                {
                    dgvDrugList.Enabled = false;
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    cmbDruggroup.SelectedIndex = Convert.ToInt32(dgvDrugList.CurrentRow.Cells[1].Value);
                    txtDrugName.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[3].Value);
                    txtContain.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[4].Value);
                    txtVolume.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[5].Value);
                    cmbDrugtype.SelectedIndex = Convert.ToInt32(dgvDrugList.CurrentRow.Cells[6].Value);
                    txtPack.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[8].Value);
                    txtPrice.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[9].Value);
                    txtUnit.Text = Convert.ToString(dgvDrugList.CurrentRow.Cells[11].Value);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            ep.Clear();
            if (cmbDrugtype.SelectedIndex == 0)
            {
                ep.SetError(cmbDrugtype, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                cmbDrugtype.Focus();
                return;
            }
            if (cmbDruggroup.SelectedIndex == 0)
            {
                ep.SetError(cmbDruggroup, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                cmbDruggroup.Focus();
                return;
            }
            if (txtDrugName.Text.Trim().Length == 0)
            {
                ep.SetError(txtDrugName, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtDrugName.Focus();
                return;
            }
            if (txtContain.Text.Trim().Length == 0)
            {
                ep.SetError(txtContain, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtContain.Focus();
                return;
            }
            if (txtPack.Text.Trim().Length == 0)
            {
                ep.SetError(txtPack, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtPack.Focus();
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                ep.SetError(txtPrice, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtPrice.Focus();
                return;
            }
            if (txtVolume.Text.Trim().Length == 0)
            {
                ep.SetError(txtVolume, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtVolume.Focus();
                return;
            }
            if (txtUnit.Text.Trim().Length == 0)
            {
                ep.SetError(txtUnit, "กรุณากรอกข้อมูลให้ครบถ้วนด้วยครับ");
                txtUnit.Focus();
                return;
            }
            

            // insert
            string sqlUpdate = string.Format(@"UPDATE drug SET druggroup_id = '{0}', drugName = '{1}', contain = '{2}', volume = '{3}', type_id = '{4}', pack = '{5}', price = '{6}', unit = '{7}' WHERE drug_id = '{8}'",
                cmbDruggroup.SelectedValue,
                txtDrugName.Text,
                txtContain.Text.Trim(),
                txtVolume.Text.Trim(),
                cmbDrugtype.SelectedValue,
                txtPack.Text.Trim(),
                txtPrice.Text.Trim(),
                txtUnit.Text.Trim(), 
                Convert.ToString(dgvDrugList.CurrentRow.Cells[0].Value));

            DataCenter dc = new DataCenter();
            bool result = dc.Insert(sqlUpdate);
            if (result)
            {
                XtraMessageBox.Show("บันทึกการแก้ไขข้อมูลสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearForm();
                FillData(string.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}