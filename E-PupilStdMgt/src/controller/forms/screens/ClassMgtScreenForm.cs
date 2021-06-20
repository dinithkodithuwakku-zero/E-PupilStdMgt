using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.forms.screens
{
    public partial class ClassMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();

        public ClassMgtScreenForm()
        {
            InitializeComponent();

            LoadClassDetails();

            ButtonProperties();
        }

        private void LoadClassDetails()
        {
            try
            {
                classDataGrid.Rows.Clear();

                con.Open();
                string query = "select ID_CLASS, CLASS_NAME, CLASS_CODE, IS_ACTIVE from core_class";

                MySqlDataReader reader = con.ExecuteReader(query);
                while (reader.Read())
                {
                    this.classDataGrid.Rows.Add(reader["ID_CLASS"].ToString(), reader["CLASS_NAME"].ToString(), reader["CLASS_CODE"].ToString(), reader["IS_ACTIVE"].ToString());
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
            createNewClassButton.TabStop = false;
            createNewClassButton.FlatStyle = FlatStyle.Flat;
            createNewClassButton.FlatAppearance.BorderSize = 0;

            createPanelButton.TabStop = false;
            createPanelButton.FlatStyle = FlatStyle.Flat;
            createPanelButton.FlatAppearance.BorderSize = 0;

            closePanelButton.TabStop = false;
            closePanelButton.FlatStyle = FlatStyle.Flat;
            closePanelButton.FlatAppearance.BorderSize = 0;
        }


        private void createNewClassButton_Click(object sender, EventArgs e)
        {
            classCreatePanel.Visible = true;
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
                string query = "INSERT INTO core_class(CLASS_NAME, CLASS_CODE, IS_ACTIVE) VALUES(@className, @classCode, @isActive)";

                ParameterClass[] parameterClasses = {
                    new ParameterClass("@className", classNameInput.Text),
                    new ParameterClass("@classCode", classCodeInput.Text),
                    new ParameterClass("@isActive", isActiveCheckBox.Checked ? 1.ToString(): 0.ToString())
                };
                int affected = con.ExecuteQueryWithParameters(query, parameterClasses);

                if (affected != -1)
                {
                    MessageBox.Show("New Class Created!");
                    LoadClassDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Create new Class!", "Error!");
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

            classNameInput.Text = null;
            classCodeInput.Text = null;
            isActiveCheckBox.Checked = false;
            classCreatePanel.Visible = false;
        }
    }
}
