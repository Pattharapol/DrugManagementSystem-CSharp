using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DrugManagementSystem.UI;
using DrugManagementSystem.UI.Products;
using DrugManagementSystem.UI.HistoryCheck;
using DrugManagementSystem.UI.BasicInformation;
using DrugManagementSystem.UI.Login;

namespace DrugManagementSystem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        // รับมาจาก login เพื่อส่งต่อไปยัง addProducts และ saleProducts
        int userID;
        public frmMain(int id)
        {
            InitializeComponent();
            userID = id;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmAddProducts frm = Application.OpenForms["FormAdd"] as frmAddProducts;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmAddProducts(userID);
                frm.Name = "FormAdd";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmCooperateCheck frm = Application.OpenForms["FormCheck"] as frmCooperateCheck;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmCooperateCheck();
                frm.Name = "FormCheck";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmCooperateCheck frm = Application.OpenForms["FormCheck2"] as frmCooperateCheck;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmCooperateCheck();
                frm.Name = "FormCheck2";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmRecieveHistory frm = Application.OpenForms["FormCheckHistory"] as frmRecieveHistory;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmRecieveHistory();
                frm.Name = "FormCheckHistory";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmVendorList frm = Application.OpenForms["frmVendorList"] as frmVendorList;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmVendorList();
                frm.Name = "frmVendorList";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmBudgetList frm = Application.OpenForms["frmBudgetList"] as frmBudgetList;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmBudgetList();
                frm.Name = "frmBudgetList";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmDrugList frm = Application.OpenForms["frmDrugList"] as frmDrugList;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmDrugList();
                frm.Name = "frmDrugList";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmDepartmentList frm = Application.OpenForms["frmDepartment"] as frmDepartmentList;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmDepartmentList();
                frm.Name = "frmDepartment";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmUserAccount frm = Application.OpenForms["frmUserAccount"] as frmUserAccount;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmUserAccount();
                frm.Name = "frmUserAccount";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            // เช็คว่า เปิดแล้วหรือยัง ถ้าเปิด ก็ให้ focus ไปเลย
            frmSaleProducts frm = Application.OpenForms["frmSaleProducts"] as frmSaleProducts;
            if (frm != null)
                frm.Focus();
            else
            {
                frm = new frmSaleProducts(userID);
                frm.Name = "frmSaleProducts";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCheckExpDate frm = new frmCheckExpDate();
            frm.ShowDialog();
        }
    }
}