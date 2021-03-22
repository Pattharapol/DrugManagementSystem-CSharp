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
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using DrugManagementSystem.Reports;
using DevExpress.XtraReports.UI;

namespace DrugManagementSystem.UI.Reports
{
    public partial class frmReports : DevExpress.XtraEditors.XtraForm
    {
        string date_1;
        string date_2;
        public frmReports(string date1, string date2)
        {
            InitializeComponent();
            this.date_1 = date1;
            this.date_2 = date2;

        }

        private void rdlcReport()
        {
            MySqlConnection cn = new MySqlConnection("server=localhost;uid=root;password=;database=drugmanagement;");
            cn.Open();
            string sql = string.Format(@"CALL getReceiveProduct('{0}', '{1}')", date_1, date_2);
            MySqlCommand cm = new MySqlCommand(sql, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);

            //DataSet ds = new DataSet();
            //da.Fill(ds);

            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("dsReceiveProducts", dt);
            //XtraReport1 rpt = new XtraReport1()
            //{
            //    DataSource = dt,
            //    DataMember = "dsReceiveProducts",
            //};

            //ReportDesignTool designTool = new ReportDesignTool(rpt);
            //designTool.ShowRibbonDesignerDialog();

            reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.ReportPath = @"..\..\Reports\rptReceiveProducts.rdlc";
            reportViewer1.LocalReport.ReportPath = @"..\..\Reports\XtraReport1.cs";
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            cn.Close();
        }

        private async void frmReports_Load(object sender, EventArgs e)
        {
            
        }

        private async Task<DataTable> FillData()
        {
            DataTable dt = new DataTable();


            return dt;
        }
    }
}