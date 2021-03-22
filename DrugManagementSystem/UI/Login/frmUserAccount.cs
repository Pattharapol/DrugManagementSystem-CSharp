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

namespace DrugManagementSystem.UI.Login
{
    public partial class frmUserAccount : DevExpress.XtraEditors.XtraForm
    {
        public frmUserAccount()
        {
            InitializeComponent();
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            FillData(string.Empty);
        }

        private void ClearForm()
        {
            txtFirstname.Text = "";
            txtLastName.Text = "";
            txtUserLogin.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            lblConfirmPassword.Visible = false;
            pbConfirmPassword.Visible = false;
            txtFirstname.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            dgvUserAccount.Enabled = true;
        }

        private async void FillData(string searchValue)
        {
            dgvUserAccount.Rows.Clear();
            DataCenter dc = new DataCenter();
            DataTable dt = new DataTable();
            string sql = "";

            if (string.IsNullOrEmpty(searchValue))
            {
                sql = string.Format(@"SELECT * FROM user");
            }
            else
            {
                sql = string.Format(@"SELECT * FROM user WHERE userLogin LIKE '%{0}%' OR userFirstName LIKE '%{1}%'", searchValue, searchValue);
            }

            dt = await dc.SelectDataAsync(sql);
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["user_isActive"].ToString().Equals("1"))
                    {
                        dgvUserAccount.Rows.Add(row["user_id"].ToString(), row["userFirstName"].ToString(), row["userLastName"].ToString(), row["userLogin"].ToString(), row["userPassword"].ToString(), row["user_isActive"].ToString(), "Active");
                    }
                    else
                    {
                        dgvUserAccount.Rows.Add(row["user_id"].ToString(), row["userFirstName"].ToString(), row["userLastName"].ToString(), row["userLogin"].ToString(), row["userPassword"].ToString(), row["user_isActive"].ToString(), "inActive");
                    }
                }
            }
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        private void dgvUserAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUserAccount.Columns[e.ColumnIndex].Name;

            if(colName == "status")
            {
                if(XtraMessageBox.Show("คุณต้องการเปลี่ยนแแปลงสถานะผู้ใช้งาน ใช่หรือไม่", "แจ้งทราบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataCenter dc = new DataCenter();

                    string isActive = dc.SelectData(string.Format(@"SELECT user_isActive FROM user WHERE user_id = '{0}'", dgvUserAccount.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();
                    if (isActive.Equals("1"))
                    {
                        bool result = dc.Update(string.Format(@"UPDATE user SET user_isActive = 0 WHERE user_id = '{0}' ", dgvUserAccount.CurrentRow.Cells[0].Value.ToString()));
                        XtraMessageBox.Show("เปลี่ยนแแปลงสถานะผู้ใช้งานสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        FillData(string.Empty);
                        ClearForm();
                    }
                    else
                    {
                        bool result = dc.Update(string.Format(@"UPDATE user SET user_isActive = 1 WHERE user_id = '{0}' ", dgvUserAccount.CurrentRow.Cells[0].Value.ToString()));
                        XtraMessageBox.Show("เปลี่ยนแแปลงสถานะผู้ใช้งานสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        FillData(string.Empty);
                        ClearForm();
                    }
                    
                }
            }
        }

        private void txtConfirmPassword_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblConfirmPassword.Visible = true;
                lblConfirmPassword.Text = "**รหัสผ่านไม่ตรงกัน**";
            }
            else
            {
                lblConfirmPassword.Visible = false;
                pbConfirmPassword.Visible = true;
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
            if(txtFirstname.Text.Trim().Length == 0)
            {
                ep.SetError(txtFirstname, "กรุณากรอกข้อมูลให้เรียบร้อยด้วยครับ");
                txtFirstname.Focus();
                return;
            }
            if (txtLastName.Text.Trim().Length == 0)
            {
                ep.SetError(txtLastName, "กรุณากรอกข้อมูลให้เรียบร้อยด้วยครับ");
                txtLastName.Focus();
                return;
            }
            if (txtUserLogin.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserLogin, "กรุณากรอกข้อมูลให้เรียบร้อยด้วยครับ");
                txtUserLogin.Focus();
                return;
            }
            if(txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "กรุณากรอกข้อมูลให้เรียบร้อยด้วยครับ");
                txtPassword.Focus();
                return;
            }
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                ep.SetError(txtConfirmPassword, "กรุณาตรวจสอบรหัสผ่านยืนยันด้วยครับ");
                txtConfirmPassword.Focus();
                return;
            }
            
            DataCenter dc = new DataCenter();

            // encode
            string encryptPass = Base64Encode(txtPassword.Text);

            string sql = string.Format(@"INSERT INTO user VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
                null, txtFirstname.Text.Trim(), txtLastName.Text.Trim(), txtUserLogin.Text.Trim(), encryptPass, 1);
            bool result = dc.Insert(sql);
            if (result)
            {
                XtraMessageBox.Show("บันทึกสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillData(string.Empty);
                ClearForm();
            }

        }

        //encode
        static string key = "iknowcsharp";
        public static string Base64Encode(string plainText)
        {
            string secureKey = key + plainText;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(secureKey);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void แกไขToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvUserAccount != null)
            {
                if(dgvUserAccount.Rows.Count > 0)
                {
                    DataCenter dc = new DataCenter();

                    dgvUserAccount.Enabled = false;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;

                    txtFirstname.Text = Convert.ToString(dgvUserAccount.CurrentRow.Cells[1].Value);
                    txtLastName.Text = Convert.ToString(dgvUserAccount.CurrentRow.Cells[2].Value);
                    txtUserLogin.Text = Convert.ToString(dgvUserAccount.CurrentRow.Cells[3].Value);
                    txtPassword.Text = dc.DecryptPassword(dgvUserAccount.CurrentRow.Cells[4].Value.ToString());
                    txtConfirmPassword.Text = txtPassword.Text;
                }
            }
        }
    }
}