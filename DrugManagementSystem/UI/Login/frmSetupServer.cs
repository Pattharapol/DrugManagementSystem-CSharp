using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using System.IO;
using DrugManagementSystem.DatabaseLayer;
using MySql.Data.MySqlClient;

namespace DrugManagementSystem.UI
{
    public partial class frmSetupServer : DevExpress.XtraEditors.XtraForm
    {
        public frmSetupServer()
        {
            InitializeComponent();
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text.Trim().Length == 0)
            {
                txtPassword.Text = "";
            }
            string path = @"C:\Temp\config.txt";
            StreamWriter sw = new StreamWriter(path);

            string str = txtServer.Text.Trim() + Environment.NewLine;
            str += txtUsername.Text.Trim() + Environment.NewLine;
            str += txtPassword.Text.Trim() + Environment.NewLine;

            sw.WriteLine(str);
            sw.Close();
            this.Close();
        }

        private void ReadSettingTextFile()
        {
            string path = @"C:\Temp\config.txt";
            //StreamReader sr = new StreamReader(path);
            var txt = File.ReadLines(path).ToArray();
            txtServer.Text = txt[0];
            txtPassword.Text = txt[2];
            txtUsername.Text = txt[1];
            //sr.Close();
        }

        private void CheckConnection()
        {
            try
            {
                // check connection
                MySqlConnection conn = new MySqlConnection("server=" + txtServer.Text + ";user=" + txtUsername.Text + ";password=" + txtPassword.Text + ";database=drugmanagement;");
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    XtraMessageBox.Show("เชื่อมต่อสำเร็จแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (conn.State == ConnectionState.Closed)
                {
                    XtraMessageBox.Show("เชื่อมต่อไม่สำเร็จครับ กรุณาแก้ไข...", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("เชื่อมต่อไม่สำเร็จครับ กรุณาแก้ไข...", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmSetupServer_Load(object sender, EventArgs e)
        {
            ReadSettingTextFile();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }
    }
}