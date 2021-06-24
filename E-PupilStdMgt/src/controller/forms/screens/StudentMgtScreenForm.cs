using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;

namespace E_PupilStdMgt.forms.screens
{
    public partial class StudentMgtScreenForm : Form
    {
        private IStudentServiceCustom iStudentServiceCustom;
        public StudentMgtScreenForm()
        {
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
            InitializeComponent();
            LoadStudentDetails();
            ButtonProperties();
        }

        public void LoadStudentDetails()
        {
            try
            {
                studentDataGrid.Rows.Clear();

                List<StudentDTO> list = iStudentServiceCustom.FindAllStudents();

                foreach (StudentDTO dto in list)
                {
                    this.studentDataGrid.Rows.Add(dto.StudentId, dto.StudentRegNo, dto.StudentName, dto.MobileNo, dto.Email, dto.PermanentAddress, dto.Gender);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load student details!", "Error!");
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
                int nextRegNo = iStudentServiceCustom.GenerateNextRegNo();

                stdRegNoInput.Text = "REG" + nextRegNo;
                studentCreatePanel.Visible = true;

            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
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
                bool isCreated = iStudentServiceCustom.CreateNewStudent(new StudentDTO(stdRegNoInput.Text, stdNameInput.Text, stdMobileNoInput.Text, genderPicker.SelectedItem.ToString(), stdEmailInput.Text, permentAddressInput.Text));

                if (isCreated)
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
