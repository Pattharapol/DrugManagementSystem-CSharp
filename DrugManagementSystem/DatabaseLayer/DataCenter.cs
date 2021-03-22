
using DrugManagementSystem.BussinessLayer;
using DrugManagementSystem.Dataset;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugManagementSystem.DatabaseLayer
{
    public class DataCenter
    {
        ServerInfo serverInfo = new ServerInfo();

        private const string SecurityKey = "Juan roman Riquelme";

        private static MySqlConnection conn;

        # region getServer from TextFile
        public void getServer()
        {
            string path = @"C:\Temp\config.txt";
            //StreamReader sr = new StreamReader(path);
            var txt = File.ReadLines(path).ToArray();
            serverInfo.server= txt[0];
            serverInfo.username = txt[1];
            serverInfo.password = txt[2];
        }
        #endregion
        
        #region Open the connection
        public MySqlConnection ConnOpen()
        {
            getServer();
            if (conn == null)
            {
                conn = new MySqlConnection("server=" + serverInfo.server + ";user=" + serverInfo.username + ";password=" + serverInfo.password + ";database=drugmanagement;port=3306;");
                //conn = new MySqlConnection("server=localhost;uid=root;password=;database=drugmanagement;");
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        #endregion

        #region Datatable SelectData
        public DataTable SelectData(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, ConnOpen());
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region Datatable SelectDataAsync
        public async Task<DataTable> SelectDataAsync(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, ConnOpen());
            await adapter.FillAsync(dt);
            conn.Close();
            return dt;
        }
        #endregion

        #region Fill data to combobox
        public DataTable ComboboxHelper(ComboBox cmb, string myColumn, string myChoice, string sql)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(myColumn);
            dt.Rows.Add(myChoice);
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, ConnOpen());
            adapter.Fill(dt);
            conn.Close();
            return dt;
            
        }
        #endregion

        #region Insert To Any
        public bool Insert(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConnOpen());
                int row = cmd.ExecuteNonQuery();
                if (row > 0) { result = true; };
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
            return result;
        }
        #endregion

        #region Update any
        public bool Update(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConnOpen());
                int row = cmd.ExecuteNonQuery();
                if (row > 0) { result = true; };
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
            return result;
        }
        #endregion

        #region Delete any
        public bool Delete(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, ConnOpen());
                int row = cmd.ExecuteNonQuery();
                if (row > 0) { result = true; };
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
            return result;
        }
        #endregion

        #region Decrypt Password
        public string DecryptPassword(string PlainText)
        {
            // Getting the bytes of Input String.
            byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(PlainText);

            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
            //De-allocatinng the memory after doing the Job.
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            //Assigning the Security key to the TripleDES Service Provider.
            objTripleDESCryptoService.Key = securityKeyArray;
            //Mode of the Crypto service is Electronic Code Book.
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            //Padding Mode is PKCS7 if there is any extra byte is added.
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;


            var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
            //Transform the bytes array to resultArray
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
            objTripleDESCryptoService.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        #endregion


        #region Encrypt Password
        public string EncryptPassword(string txtPassword)
        {
            try
            {
                byte[] toEncryptArray = Convert.FromBase64String(txtPassword);
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

                //Gettting the bytes from the Security Key and Passing it to compute the Corresponding Hash Value.
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
                objMD5CryptoService.Clear();

                var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
                //Assigning the Security key to the TripleDES Service Provider.
                objTripleDESCryptoService.Key = securityKeyArray;
                //Mode of the Crypto service is Electronic Code Book.
                objTripleDESCryptoService.Mode = CipherMode.ECB;
                //Padding Mode is PKCS7 if there is any extra byte is added.
                objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
                //Transform the bytes array to resultArray
                byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                objTripleDESCryptoService.Clear();

                //Convert and return the decrypted data/byte into string format.
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        #region Fill Data to DataSet for Reports
        public async Task<DataSet> FillDataSet(DataSet ds, string dsTable, string sql)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, ConnOpen());
            await da.FillAsync(ds, ds.Tables[0].TableName);
            return ds;
        }
        #endregion

    }
}
