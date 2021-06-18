using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static E_PupilStdMgt.DBConnection;

namespace E_PupilStdMgt.forms.screens
{
    public partial class SchoolMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        String schoolName;

        public SchoolMgtScreenForm()
        {
            InitializeComponent();

            try
            {
                con.Open();
                string query = "select SCHOOL_NAME from core_school";
                MySqlDataReader row;
                row = con.ExecuteReader(query);

                if (row.HasRows)
                {

                    while (row.Read())
                    {
                        schoolName = row["SCHOOL_NAME"].ToString();
                    }
                    MessageBox.Show(schoolName);
                }
                else
                {
                    MessageBox.Show("Data not found", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void schoolBadgeImageUploader_Click(object sender, EventArgs e)
        {
            if (schoolBadgeFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = schoolBadgeFileDialog.FileName;
                MessageBox.Show(selectedFile);
            }
        }
    }
}
