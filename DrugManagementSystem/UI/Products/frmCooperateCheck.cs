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

namespace DrugManagementSystem.UI.Products
{
    public partial class frmCooperateCheck : DevExpress.XtraEditors.XtraForm
    {
        public frmCooperateCheck()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillData(txtSearch.Text.Trim());
        }

        // Fill Data into dgvUncheck by DataTable
        private async void FillData(string searchValue)
        {
            dgvCheck2.DataSource = null;
            DatabaseLayer.DataCenter dc = new DatabaseLayer.DataCenter();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(searchValue))
            {
                dt = await dc.SelectDataAsync(string.Format(@"SELECT dummy.*, bg.budgetType, vd.vendorName FROM receivedata_dummy AS dummy LEFT JOIN vendor AS vd ON dummy.vendor_id = vd.vendor_id LEFT JOIN budget as bg ON dummy.budget_id = bg.budget_id "));
            }
            else
            {
                
                dt = await dc.SelectDataAsync(string.Format(@"SELECT dummy.*, bg.budgetType, vd.vendorName FROM receivedata_dummy AS dummy LEFT JOIN vendor AS vd ON dummy.vendor_id = vd.vendor_id LEFT JOIN budget as bg ON dummy.budget_id = bg.budget_id WHERE dummy.receiveNo = '{0}' ", searchValue));
            }
            // create 8 DGV columns in dgvUncheck before do this coz we have to add 2 buttons to DGV for choose either ซื้อร่วมจังหวัด or ซื้อร่วมเขต
            //foreach (DataRow data in dt.Rows)
            //{
            //    dgvCheck2.Rows.Add();
            //}

            //
            if(dt.Rows.Count > 0)
            {
                // column + 2 coz checkbox CoSSK, CoSubSSK
                dgvCheck2.DataSource = dt;
                dgvCheck2.Columns[0].Visible = true;
                dgvCheck2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvCheck2.Columns[1].Visible = true;
                dgvCheck2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                dgvCheck2.Columns[2].Visible = false;
                dgvCheck2.Columns[3].Visible = false;
                dgvCheck2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvCheck2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvCheck2.Columns[6].Visible = false;
                dgvCheck2.Columns[7].Visible = false;
                dgvCheck2.Columns[8].Visible = false;
                dgvCheck2.Columns[9].Visible = false;
                dgvCheck2.Columns[10].Visible = false;
                dgvCheck2.Columns[11].Visible = false;
                dgvCheck2.Columns[12].Visible = false;
                dgvCheck2.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvCheck2.Columns[14].Visible = false;
                dgvCheck2.Columns[15].Visible = false;
                dgvCheck2.Columns[16].Visible = false;
                dgvCheck2.Columns[17].Visible = false;
                dgvCheck2.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvCheck2.Columns[19].Visible = false;
                dgvCheck2.Columns[20].Visible = false;
                dgvCheck2.Columns[21].Visible = false;
                dgvCheck2.Columns[22].Visible = false;
                dgvCheck2.Columns[23].Visible = false;
                dgvCheck2.Columns[23].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvCheck2.Columns[23].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            decimal totalPrice = 0;
            foreach (DataGridViewRow data in dgvCheck2.Rows)
            {
                totalPrice += Convert.ToDecimal(data.Cells[13].Value.ToString());
            }

            lblCount.Text = Convert.ToString(dgvCheck2.Rows.Count);
            lblTotalPrice.Text = Convert.ToString(totalPrice);
            

        }

        private void frmCooperateCheck2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtSearch.Enabled = false;
            DataCenter dc = new DataCenter();
            UserInfo ui = new UserInfo();

            DateTime date = DateTime.Now;
            string permitDate = date.ToString("yyyy-MM-dd");
            if(dgvCheck2 == null || dgvCheck2.Rows.Count == 0)
            {
                XtraMessageBox.Show("ไม่มีรายการที่ต้องประมวลผล", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("ตรวจสอบข้อมูลเรียบร้อยแล้ว ต้องการบันทึกใช่หรือไม่?","แจ้งทราบ" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // update ซื้อร่วมเขตหรือไม่
                foreach (DataGridViewRow row in dgvCheck2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["CoSSK"].Value) == true)
                    {
                        string sql = string.Format(@"UPDATE receivedata_dummy SET CoSSK = 1 WHERE dummy_id = '{0}'", row.Cells[2].Value.ToString());
                        bool result2 = dc.Update(sql);
                        if (result2)
                        {
                            //XtraMessageBox.Show("OK CoSSK");
                        }

                    }

                    if (Convert.ToBoolean(row.Cells["CoSubSSK"].Value) == true)
                    {
                        string sql = string.Format(@"UPDATE receivedata_dummy SET CoSubSSK = 1 WHERE dummy_id = '{0}'", row.Cells[2].Value.ToString());
                        bool result2 = dc.Update(sql);
                        if (result2)
                        {
                            //XtraMessageBox.Show("OK CoSubSSK");
                        }
                    }
                }

                // clear dgvCheck2 เพื่อดึงข้อมูลใหม่ หลังจากอัพเดท
                //dgvCheck2.Rows.Clear();
                dgvCheck2.DataSource = null;
                FillData(txtSearch.Text.Trim());


                // insert into receivedata
                string query = string.Format(@"INSERT INTO receivedata VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", null, ui.user_ID, lblCount.Text, lblTotalPrice.Text, '1', permitDate);
                bool result = dc.Insert(query);
                if (result)
                {
                    // select receive_id from receivedata first then insert into  receivedatadetails in every transaction
                    string queryReceiveID = string.Format(@"SELECT MAX(receive_id) FROM receivedata LIMIT 1");
                    string receive_id = dc.SelectData(queryReceiveID).Rows[0][0].ToString(); // แปลง Datatable เป็น string

                    foreach (DataGridViewRow data in dgvCheck2.Rows)
                    {
                        //insert into receivedatadetails
                        string query2 = string.Format(@"INSERT INTO receivedatadetails VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}')", 
                            null,
                            receive_id,
                            data.Cells[3].Value.ToString(),
                            data.Cells[4].Value.ToString(),
                            data.Cells[5].Value.ToString(),
                            data.Cells[6].Value.ToString(),
                            data.Cells[7].Value.ToString(),
                            data.Cells[8].Value.ToString(),
                            data.Cells[9].Value.ToString(),
                            data.Cells[10].Value.ToString(),
                            data.Cells[11].Value.ToString(),
                            data.Cells[12].Value.ToString(),
                            data.Cells[13].Value.ToString(),
                            data.Cells[14].Value.ToString(),
                            data.Cells[15].Value.ToString(),
                            data.Cells[16].Value.ToString(),
                            data.Cells[17].Value.ToString(),
                            Convert.ToDateTime(data.Cells[18].Value.ToString()).ToString("yyyy-MM-dd"),
                            Convert.ToDateTime(data.Cells[19].Value.ToString()).ToString("yyyy-MM-dd"),
                            Convert.ToDateTime(data.Cells[20].Value.ToString()).ToString("yyyy-MM-dd"),
                            Convert.ToDateTime(data.Cells[21].Value.ToString()).ToString("yyyy-MM-dd"),
                            data.Cells[22].Value.ToString(), 
                            data.Cells[23].Value.ToString());
                        bool result2 = dc.Insert(query2);


                        if (result2)
                        {
                            //XtraMessageBox.Show("OK na krub");
                        }
                    }
                }

                // ต้องเช็คก่อนว่า ในของแต่ละล็อต ของหมดรึยัง
                // เพราะราคาของแต่ละล็อตไม่เท่ากัน และ ต้อง FIFO
                // insert into stockcard if not exist
                foreach (DataGridViewRow row in dgvCheck2.Rows)
                {
                    // qty * pack * price
                    int qty = Convert.ToInt32(row.Cells[10].Value.ToString());
                    int pack = Convert.ToInt32(row.Cells[11].Value.ToString());
                    decimal price = Convert.ToDecimal(row.Cells[12].Value.ToString());
                    decimal totalPrice = qty * price;

                    // totalRemain
                    int lastStock = Convert.ToInt32(row.Cells[9].Value.ToString());

                    string sql = string.Format(@"INSERT INTO stockcard VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')", 
                        null, 
                        row.Cells[7].Value.ToString(),
                        Convert.ToDateTime(row.Cells[18].Value.ToString()).ToString("yyyy-MM-dd"), 
                        row.Cells[4].Value.ToString(), 
                        null, 
                        lastStock, 
                        qty, 
                        pack, 
                        price, 
                        null, 
                        null, 
                        null, 
                        totalPrice / (qty * pack), 
                        totalPrice, 
                        lastStock + (qty * pack), 
                        row.Cells[15].Value.ToString(),
                        Convert.ToDateTime(row.Cells[19].Value.ToString()).ToString("yyyy-MM-dd")
                        );
                    bool a = dc.Insert(sql);
                    if (a)
                    {
                        //XtraMessageBox.Show("OK");
                    }
                }

                //update STOCK and PRICE to drug for liveStock
                foreach (DataGridViewRow row in dgvCheck2.Rows)
                {
                    string sql = string.Format(@"UPDATE drug SET price = '{0}', stock = '{1}' WHERE drug_id = '{2}' ", row.Cells[12].Value.ToString(), row.Cells[14].Value.ToString(), row.Cells[7].Value.ToString());
                    bool updateStock = dc.Update(sql);
                    if (updateStock)
                    {
                        //XtraMessageBox.Show("OK");
                    }
                }
            }
            else
            {

            }

            // clear data in dummy table
            bool delete_dummy = dc.Delete("DELETE FROM receivedata_dummy");
            if (delete_dummy)
            {
                XtraMessageBox.Show("บันทึกเรียบร้อยแล้วครับ", "แจ้งทราบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCheck2.DataSource = null;
                txtSearch.Enabled = true;
                lblCount.Text = "0";
                lblTotalPrice.Text = "0.00";
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}