using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.src.db
{
    class DBConnection
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        static string host = ConfigurationManager.AppSettings.Get("host");
        static string database = ConfigurationManager.AppSettings.Get("database");
        static string userDB = ConfigurationManager.AppSettings.Get("userDB");
        static string password = ConfigurationManager.AppSettings.Get("password");
        public static string strProvider = "server=" + host + ";database=" + database + ";uid=" + userDB + ";pwd=" + password;
        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";database=" + database + ";uid=" + userDB + ";pwd=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public int ExecuteQueryWithParameters(String query, ParameterClass[] parameters)
        {
            try
            {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();

                MySqlCommand updateCommand = new MySqlCommand(query, conn);

                for(int i =0; i<parameters.Length; i++)
                {

                    updateCommand.Parameters.AddWithValue(parameters[i].getParameterKey(), parameters[i].getParameterValue());
                }

                affected = updateCommand.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: "+ ex.Message, "Error!");
            }
            return -1;
        }
    }
}
