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
using DrugManagementSystem.BussinessLayer;

namespace DrugManagementSystem.UI.Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // encode
        static string key = "iknowcsharp";
        public static string Base64Encode(string plainText)
        {
            string secureKey = key + plainText;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(secureKey);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataCenter dc = new DataCenter();
            UserInfo ui = new UserInfo();

            // encode
            string password = Base64Encode(txtPassword.Text);

            string sql = string.Format(@"SELECT * FROM user WHERE userLogin = '{0}' AND userPassword = '{1}'", txtUsername.Text.Trim(), password);
            DataTable dtLogin = dc.SelectData(sql);
            if(dtLogin.Rows.Count > 0)
            {
                if(dtLogin.Rows[0]["user_isActive"].ToString() == "1")
                {


                    //  get user_id and userFullname


                    ui.user_ID = Convert.ToInt32(dtLogin.Rows[0]["user_id"].ToString());
                    ui.user_Fullname = Convert.ToString(dtLogin.Rows[0]["userFirstName"].ToString()) + ' ' + Convert.ToString(dtLogin.Rows[0]["userLastName"].ToString()); ;

                    XtraMessageBox.Show($"สวัสดี คุณ {ui.user_Fullname} นี่คือการทดสอบระบบนะ...");

                    this.Hide();
                    frmMain frm = new frmMain(ui.user_ID);
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("ไม่สามารถใช้งานได้ กรุณาติดต่อผู้ดูแลระบบ...","แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show("ชื่อผู้ใช้งาน หรือ รหัสผ่านไม่ถูกต้อง", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter from txtPassword instead of CLICK
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            frmSetupServer frm = new frmSetupServer();
            frm.ShowDialog();
        }
    }
}