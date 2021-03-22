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
using DrugManagementSystem.Reports;
using System.Diagnostics;
using DrugManagementSystem.Dataset;
using System.IO;
using MySql.Data.MySqlClient;
using DrugManagementSystem.BussinessLayer;

namespace DrugManagementSystem.UI.Products
{
    public partial class frmCheckExpDate : DevExpress.XtraEditors.XtraForm
    {

        public frmCheckExpDate()
        {
            InitializeComponent();
        }


        // เรียกข้อมูลเลย หลังจาก กดปุ่มจากแถบเมนู ตรวจสอบเวชภัณฑ์ใกล้หมดอายุ
        private async void frmCheckExpDate_Load(object sender, EventArgs e)
        {
            DataCenter dc = new DataCenter();
            DataTable dt = new DataTable();

            string sql = string.Format(@"SELECT drg.drugName, rcd.lotNo, stc.TotalRemain, rcd.expDate  from receivedatadetails AS rcd INNER JOIN drug AS drg ON rcd.drug_id = drg.drug_id INNER JOIN stockcard AS stc ON rcd.drug_id = stc.drug_id where rcd.expDate between CURDATE() AND CURDATE() + 180 AND stc.TotalRemain > 0 GROUP BY rcd.lotNo ORDER BY rcd.expDate ASC");

            dt = await dc.SelectDataAsync(sql);
            dgvCheckExpDate.DataSource = dt;
            dgvCheckExpDate.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCheckExpDate.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCheckExpDate.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCheckExpDate.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        // ส่งออก PDF
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            DataCenter dc = new DataCenter();
            dsCheckExpDate ds = new dsCheckExpDate();
            string sql = string.Format(@"SELECT drg.drugName, rcd.lotNo, stc.TotalRemain, rcd.expDate  from receivedatadetails AS rcd INNER JOIN drug AS drg ON rcd.drug_id = drg.drug_id INNER JOIN stockcard AS stc ON rcd.drug_id = stc.drug_id where rcd.expDate between CURDATE() AND CURDATE() + 180 AND stc.TotalRemain > 0 GROUP BY rcd.lotNo ORDER BY rcd.expDate ASC");

            rptCheckExpDate rpt = new rptCheckExpDate();
            rpt.RequestParameters = false;
            //rpt.DataSource = await FillData();
            rpt.DataSource = await dc.FillDataSet(ds, ds.Tables[0].TableName, sql);
            string path = string.Format($@"C:\Temp\{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_CheckExpiryDate_pdf.pdf");
            rpt.ExportToPdf(path);
            Process.Start(@"c:\temp");
            
        }

        private async Task<DataSet> FillData()
        {
            DataCenter dc = new DataCenter();
            dsCheckExpDate ds = new dsCheckExpDate();

            MySqlConnection cn = dc.ConnOpen(); // getConnection

            string sql = string.Format(@"SELECT drg.drugName, rcd.lotNo, stc.TotalRemain, rcd.expDate  from receivedatadetails AS rcd INNER JOIN drug AS drg ON rcd.drug_id = drg.drug_id INNER JOIN stockcard AS stc ON rcd.drug_id = stc.drug_id where rcd.expDate between CURDATE() AND CURDATE() + 180 AND stc.TotalRemain > 0 GROUP BY rcd.lotNo ORDER BY rcd.expDate ASC");
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
            await da.FillAsync(ds, ds.Tables[0].TableName);
            return ds;
        }       
    }
}