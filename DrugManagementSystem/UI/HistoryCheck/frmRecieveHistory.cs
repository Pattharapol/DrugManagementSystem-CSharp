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
using DrugManagementSystem.UI.Reports;
using DrugManagementSystem.Reports;
using System.Diagnostics;
using DrugManagementSystem.Dataset;
using MySql.Data.MySqlClient;
using System.IO;
using DrugManagementSystem.BussinessLayer;

namespace DrugManagementSystem.UI.HistoryCheck
{
    public partial class frmRecieveHistory : DevExpress.XtraEditors.XtraForm
    {
        
        public frmRecieveHistory()
        {
            InitializeComponent();
            dtpFind1.EditValue = DateTime.Now;
            dtpFind2.EditValue = DateTime.Now;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSearch.Rows.Clear();
            string recDate1 = (Convert.ToDateTime(dtpFind1.EditValue)).ToString("yyyy-MM-dd");
            string recDate2 = (Convert.ToDateTime(dtpFind2.EditValue)).ToString("yyyy-MM-dd");
            

            //dgvSearch.DataSource = null;
            DataCenter dc = new DataCenter();

            string sql = string.Format(@"SELECT drg.drugName, rd.* FROM receivedatadetails AS rd LEFT JOIN drug AS drg ON rd.drug_id = drg.drug_id WHERE rd.receiveDate BETWEEN '{0}' AND '{1}'", recDate1, recDate2);
            DataTable dtSearch = await dc.SelectDataAsync(sql);
            if(dtSearch != null)
            {
                if(dtSearch.Rows.Count > 0)
                {
                    foreach(DataRow data in dtSearch.Rows)
                    {
                        if (Convert.ToInt32(data["CoSSK"]) == 1)
                        {
                            dgvSearch.Rows.Add(data["receiveDetail_id"].ToString(), data["receive_id"].ToString(), data["user_id"].ToString(), data["receiveNo"].ToString(), data["invoiceNo"].ToString(), data["orderNo"].ToString(), data["drug_id"].ToString(), data["drugName"].ToString(), data["vendor_id"].ToString(), data["lastStock"].ToString(), data["qty"].ToString(), data["pack"].ToString(), data["price"].ToString(), data["totalPrice"].ToString(), data["totalStock"].ToString(), data["lotNo"].ToString(), data["htb_id"].ToString(), data["budget_id"].ToString(), Convert.ToDateTime(data["receiveDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["expDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["orderDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["approveDate"]).ToString("yyyy-MM-dd"), "ซื้อร่วมจังหวัด", "");
                        }
                        else if (Convert.ToInt32(data["CoSubSSK"]) == 1)
                        {
                            dgvSearch.Rows.Add(data["receiveDetail_id"].ToString(), data["receive_id"].ToString(), data["user_id"].ToString(), data["receiveNo"].ToString(), data["invoiceNo"].ToString(), data["orderNo"].ToString(), data["drug_id"].ToString(), data["drugName"].ToString(), data["vendor_id"].ToString(), data["lastStock"].ToString(), data["qty"].ToString(), data["pack"].ToString(), data["price"].ToString(), data["totalPrice"].ToString(), data["totalStock"].ToString(), data["lotNo"].ToString(), data["htb_id"].ToString(), data["budget_id"].ToString(), Convert.ToDateTime(data["receiveDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["expDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["orderDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["approveDate"]).ToString("yyyy-MM-dd"), "", "ซื้อร่วมเขต");
                        }
                        else
                        {
                            dgvSearch.Rows.Add(data["receiveDetail_id"].ToString(), data["receive_id"].ToString(), data["user_id"].ToString(), data["receiveNo"].ToString(), data["invoiceNo"].ToString(), data["orderNo"].ToString(), data["drug_id"].ToString(), data["drugName"].ToString(), data["vendor_id"].ToString(), data["lastStock"].ToString(), data["qty"].ToString(), data["pack"].ToString(), data["price"].ToString(), data["totalPrice"].ToString(), data["totalStock"].ToString(), data["lotNo"].ToString(), data["htb_id"].ToString(), data["budget_id"].ToString(), Convert.ToDateTime(data["receiveDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["expDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["orderDate"]).ToString("yyyy-MM-dd"), Convert.ToDateTime(data["approveDate"]).ToString("yyyy-MM-dd"), "", "");
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("ไม่พบข้อมูลในช่วงเวลาดังกล่าว...", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            DataCenter dc = new DataCenter();
            dsReceiveProducts ds = new dsReceiveProducts(); // dataset

            string recDate1 = (Convert.ToDateTime(dtpFind1.EditValue)).ToString("yyyy-MM-dd");
            string recDate2 = (Convert.ToDateTime(dtpFind2.EditValue)).ToString("yyyy-MM-dd");

            string sql = string.Format(@"CALL getReceiveProduct('{0}', '{1}')", recDate1, recDate2);

            rptReceiveProductsHistory rpt = new rptReceiveProductsHistory();
            rpt.RequestParameters = false;
            rpt.DataSource = await dc.FillDataSet(ds, ds.Tables[0].TableName, sql);
            string path = string.Format($@"C:\Temp\{DateTime.Now.ToString("yyyyMMdd_HHmmss")}receiveProducts_pdf.pdf");
            rpt.ExportToPdf(path);
            Process.Start(@"c:\temp");
        }
    }
}