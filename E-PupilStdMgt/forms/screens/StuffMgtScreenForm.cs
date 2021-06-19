using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src;

namespace E_PupilStdMgt.forms.screens
{
    public partial class StuffMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        public StuffMgtScreenForm()
        {
            InitializeComponent();
            LoadStuffDetails();
            ButtonProperties();

            passwordInput.PasswordChar = '*';
        }

        public void LoadStuffDetails()
        {
            try
            {
                userDataGrid.Rows.Clear();

                con.Open();
                string query = "select ID_STUFF, USER_NAME, FULL_NAME, NIC, JOB_TITLE, MOBILE_NO, EMAIL, PERMANENT_ADDRESS from core_stuff";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    this.userDataGrid.Rows.Add(reader["ID_STUFF"].ToString(), reader["USER_NAME"].ToString(), reader["FULL_NAME"].ToString(), reader["NIC"].ToString(), reader["JOB_TITLE"].ToString(), reader["MOBILE_NO"].ToString(), reader["EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString());
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
            createNewUserButton.TabStop = false;
            createNewUserButton.FlatStyle = FlatStyle.Flat;
            createNewUserButton.FlatAppearance.BorderSize = 0;

            createPanelButton.TabStop = false;
            createPanelButton.FlatStyle = FlatStyle.Flat;
            createPanelButton.FlatAppearance.BorderSize = 0;

            closePanelButton.TabStop = false;
            closePanelButton.FlatStyle = FlatStyle.Flat;
            closePanelButton.FlatAppearance.BorderSize = 0;
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            userCreatePanel.Visible = true;
        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_stuff(USER_NAME, PASSWORD, FULL_NAME, NIC, JOB_TITLE, MOBILE_NO, EMAIL, PERMANENT_ADDRESS)" +
                    " VALUES(@userName, @password, @fullName, @nic, @jobTitle, @mobileNo, @email, @permanentAddress)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@userName", userNameInput.Text),
                    new ParameterClass("@password", encryptDecrypt.Encrypt(passwordInput.Text)),
                    new ParameterClass("@fullName", fullNameInput.Text),
                    new ParameterClass("@nic", nicInput.Text),
                    new ParameterClass("@jobTitle", jobTitlePicker.SelectedItem.ToString()),
                    new ParameterClass("@mobileNo", mobileNoInput.Text),
                    new ParameterClass("@email", emailInput.Text),
                    new ParameterClass("@permanentAddress", permanentAddressInput.Text),
                };
                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    MessageBox.Show("New User Created!");
                    LoadStuffDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Create new Student!", "Error!");
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

        private void closePanelButton_Click(object sender, EventArgs e)
        {
            ClearCreateFormData();
        }

        private void ClearCreateFormData()
        {
            userNameInput.Text = null;
            passwordInput.Text = null;
            fullNameInput.Text = null;
            nicInput.Text = null;
            mobileNoInput.Text = null;
            emailInput.Text = null;
            permanentAddressInput.Text = null;
            jobTitlePicker.SelectedIndex = -1;

            userCreatePanel.Visible = false;
        }
    }
}
