using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.utill;


namespace E_PupilStdMgt.forms.screens
{
    public partial class SubjectMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        public SubjectMgtScreenForm()
        {
            InitializeComponent();
            LoadSubjectDetails();
            ButtonProperties();
        }

        public void LoadSubjectDetails()
        {
            try
            {
                subjectDataGrid.Rows.Clear();

                con.Open();
                string query = "select ID_SUBJECT, SUBJECT_NAME, SUBJECT_CODE, SUBJECT_DURATION, SUBJECT_TOTAL_POINTS from core_subject";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    this.subjectDataGrid.Rows.Add(reader["ID_SUBJECT"].ToString(), reader["SUBJECT_NAME"].ToString(), reader["SUBJECT_CODE"].ToString(), reader["SUBJECT_DURATION"].ToString(), reader["SUBJECT_TOTAL_POINTS"].ToString());
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
            createNewSubjectButton.TabStop = false;
            createNewSubjectButton.FlatStyle = FlatStyle.Flat;
            createNewSubjectButton.FlatAppearance.BorderSize = 0;

            createPanelButton.TabStop = false;
            createPanelButton.FlatStyle = FlatStyle.Flat;
            createPanelButton.FlatAppearance.BorderSize = 0;

            closePanelButton.TabStop = false;
            closePanelButton.FlatStyle = FlatStyle.Flat;
            closePanelButton.FlatAppearance.BorderSize = 0;
        }

        private void createNewSubjectButton_Click(object sender, EventArgs e)
        {
            subjectCreatePanel.Visible = true;
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
                string query = "INSERT INTO core_subject(SUBJECT_NAME, SUBJECT_CODE, SUBJECT_DURATION, SUBJECT_TOTAL_POINTS)" +
                    " VALUES(@subjectName, @subjectCode, @subjectDuration, @subjectTotalPoints)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@subjectName", subjectNameInput.Text),
                    new ParameterClass("@subjectCode", subjectCodeInput.Text),
                    new ParameterClass("@subjectDuration", Int16.Parse(subjectDurationInput.Text).ToString()),
                    new ParameterClass("@subjectTotalPoints", Double.Parse(subjectTotalPointsInput.Text).ToString("0.00")),
                };
                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    MessageBox.Show("New Subject Created!");
                    LoadSubjectDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Create new Subject!", "Error!");
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
            subjectNameInput.Text = null;
            subjectCodeInput.Text = null;
            subjectDurationInput.Text = null;
            subjectTotalPointsInput.Text = null;
            subjectCreatePanel.Visible = false;
        }
    }
}
