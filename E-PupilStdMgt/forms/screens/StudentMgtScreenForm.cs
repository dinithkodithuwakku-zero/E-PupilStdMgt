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
    public partial class StudentMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        public StudentMgtScreenForm()
        {
            InitializeComponent();
            LoadStudentDetails();
            ButtonProperties();
        }

        public void LoadStudentDetails()
        {
            try
            {
                studentDataGrid.Rows.Clear();

                con.Open();
                string query = "select ID_STUDENT, STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, STUDENT_EMAIL, PERMANENT_ADDRESS, GENDER from core_student";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    this.studentDataGrid.Rows.Add(reader["ID_STUDENT"].ToString(), reader["STUDENT_REG_NO"].ToString(), reader["STUDENT_NAME"].ToString(), reader["STUDENT_MOBILE_NO"].ToString(), reader["STUDENT_EMAIL"].ToString(), reader["PERMANENT_ADDRESS"].ToString(), reader["GENDER"].ToString());
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
            createNewStudentButton.TabStop = false;
            createNewStudentButton.FlatStyle = FlatStyle.Flat;
            createNewStudentButton.FlatAppearance.BorderSize = 0;

            createPanelButton.TabStop = false;
            createPanelButton.FlatStyle = FlatStyle.Flat;
            createPanelButton.FlatAppearance.BorderSize = 0;

            closePanelButton.TabStop = false;
            closePanelButton.FlatStyle = FlatStyle.Flat;
            closePanelButton.FlatAppearance.BorderSize = 0;
        }

        private void createNewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select ID_STUDENT from core_student ORDER BY ID_STUDENT DESC LIMIT 1";

                MySqlDataReader reader = con.ExecuteReader(query);
                if (reader.Read())
                {
                    stdRegNoInput.Text = "REG" + (Int16.Parse(reader["ID_STUDENT"].ToString()) + 1);
                    studentCreatePanel.Visible = true;
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

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO core_student(STUDENT_REG_NO, STUDENT_NAME, STUDENT_MOBILE_NO, GENDER, STUDENT_EMAIL, PERMANENT_ADDRESS)" +
                    " VALUES(@stdRegNo, @stdName, @stdMobileNo, @gender, @stdEmail, @stdPermanentAddress)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@stdRegNo", stdRegNoInput.Text),
                    new ParameterClass("@stdName", stdNameInput.Text),
                    new ParameterClass("@stdMobileNo", stdMobileNoInput.Text),
                    new ParameterClass("@gender", genderPicker.SelectedItem.ToString()),
                    new ParameterClass("@stdEmail", stdEmailInput.Text),
                    new ParameterClass("@stdPermanentAddress", permentAddressInput.Text),
                };
                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    MessageBox.Show("New Student Created!");
                    LoadStudentDetails();
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

        private void ClearCreateFormData()
        {
            stdRegNoInput.Text = null;
            stdNameInput.Text = null;
            stdMobileNoInput.Text = null;
            genderPicker.SelectedIndex = -1;
            stdEmailInput.Text = null;
            permentAddressInput.Text = null;

            studentCreatePanel.Visible = false;
        }
    }
}
