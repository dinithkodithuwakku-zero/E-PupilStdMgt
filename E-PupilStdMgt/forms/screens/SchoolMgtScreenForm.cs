using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src;
using static E_PupilStdMgt.DBConnection;

namespace E_PupilStdMgt.forms.screens
{
    public partial class SchoolMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        String schoolId, schoolName, schoolDescription, schoolBadgeFilePath, schoolAddress, schoolContactNo;

        public SchoolMgtScreenForm()
        {
            InitializeComponent();

            LoadSchoolDetails();


            ButtonProperties();
        }

        private void LoadSchoolDetails()
        {
            try
            {
                con.Open();
                string query = "select ID_SCHOOL, SCHOOL_NAME, SCHOOL_DESCRIPTION, SCHOOL_CONTACT_NO, SCHOOL_ADDRESS, SCHOOL_BADGE_FILE_PATH from core_school";

                MySqlDataReader reader = con.ExecuteReader(query);

                if (reader.Read())
                {
                    schoolId = reader["ID_SCHOOL"].ToString();
                    schoolName = reader["SCHOOL_NAME"].ToString();
                    schoolDescription = reader["SCHOOL_DESCRIPTION"].ToString();
                    schoolContactNo = reader["SCHOOL_CONTACT_NO"].ToString();
                    schoolAddress = reader["SCHOOL_ADDRESS"].ToString();
                    schoolBadgeFilePath = reader["SCHOOL_BADGE_FILE_PATH"].ToString();

                    // MessageBox.Show(schoolName);
                    schoolNameInput.Text = schoolName;
                    schoolDescriptionInput.Text = schoolDescription;
                    schoolContactNoInput.Text = schoolContactNo;
                    schoolAddressInput.Text = schoolAddress;
                    schoolBadgeImageUploader.Image = Image.FromFile(@schoolBadgeFilePath);
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
            finally
            {
               con.Close();
            }
        }

        public void ButtonProperties()
        {
            updateSchoolDetailsButton.TabStop = false;
            updateSchoolDetailsButton.FlatStyle = FlatStyle.Flat;
            updateSchoolDetailsButton.FlatAppearance.BorderSize = 0;
        }

        private void updateSchoolDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update core_school set SCHOOL_NAME = @schoolName, SCHOOL_DESCRIPTION = @schoolDescription, SCHOOL_CONTACT_NO = @schoolContactNo, SCHOOL_ADDRESS = @schoolAddress, SCHOOL_BADGE_FILE_PATH = @schoolBadgeFilePath where ID_SCHOOL = @schoolId";

                // MySqlCommand updateCommand = new MySqlCommand(query, con.getConnection());
                // updateCommand.Parameters.AddWithValue("@schoolName", schoolNameInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolDescription", schoolDescriptionInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolContactNo", schoolContactNoInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolAddress", schoolAddressInput.Text);
                // updateCommand.Parameters.AddWithValue("@schoolBadgeFilePath", schoolBadgeFilePath);
                // updateCommand.Parameters.AddWithValue("@schoolId", schoolId);
                // updateCommand.ExecuteNonQuery();

                ParameterClass[] parameterClasses = { 
                    new ParameterClass("@schoolName", schoolNameInput.Text), 
                    new ParameterClass("@schoolDescription", schoolDescriptionInput.Text),
                    new ParameterClass("@schoolContactNo", schoolContactNoInput.Text),
                    new ParameterClass("@schoolAddress", schoolAddressInput.Text),
                    new ParameterClass("@schoolBadgeFilePath", schoolBadgeFilePath),
                    new ParameterClass("@schoolId", schoolId) 
                };
                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if(affected != -1)
                {
                    MessageBox.Show("School Details Updated!");
                }
                else
                {
                    MessageBox.Show("Unable to Update School Details!", "Error!");
                }
                
                LoadSchoolDetails();
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
            finally
            {
                con.Close();
            }
        }

        private void schoolBadgeImageUploader_Click(object sender, EventArgs e)
        {
            if (schoolBadgeFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                schoolBadgeFilePath = schoolBadgeFileDialog.FileName;
                schoolBadgeImageUploader.Image = Image.FromFile(@schoolBadgeFilePath);
            }
        }
    }
}
