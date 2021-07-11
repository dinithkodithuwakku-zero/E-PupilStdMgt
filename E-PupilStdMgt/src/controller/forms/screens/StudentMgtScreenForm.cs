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
        private int _studentId;
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
                    this.studentDataGrid.Rows.Add(dto.StudentId, dto.StudentRegNo, dto.StudentName, dto.Email, dto.MobileNo, dto.PermanentAddress, dto.Gender);
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

            _studentId = 0;
            updateStudentRegNoInput.Text = null;
            updateStudentNameInput.Text = null;
            updateStudentMobileNoInput.Text = null;
            updateStudentGenderPicker.SelectedIndex = -1;
            updateStudentEmailInput.Text = null;
            updateStudentAddressInput.Text = null;
            studentUpdatePanel.Visible = false;
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUpdated = iStudentServiceCustom.UpdateStudent(new StudentDTO(_studentId, updateStudentRegNoInput.Text, updateStudentNameInput.Text, updateStudentMobileNoInput.Text, updateStudentGenderPicker.SelectedItem.ToString(), updateStudentEmailInput.Text, updateStudentAddressInput.Text));

                if (isUpdated)
                {
                    MessageBox.Show("Student Updated!");
                    LoadStudentDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Update Student!", "Error!");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void deleteUpdatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isDeleted = iStudentServiceCustom.DeleteStudent(_studentId);

                if (isDeleted)
                {
                    MessageBox.Show("Student Deleted!");
                    LoadStudentDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Delete Student!", "Error!");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void cancelUpdatePanelButton_Click(object sender, EventArgs e)
        {
            ClearCreateFormData();
        }

        private void studentDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.studentDataGrid.Rows[e.RowIndex];

                _studentId = Int16.Parse(row.Cells[0].Value.ToString());
                updateStudentRegNoInput.Text = row.Cells[1].Value.ToString();
                updateStudentNameInput.Text = row.Cells[2].Value.ToString();
                updateStudentEmailInput.Text = row.Cells[3].Value.ToString();
                updateStudentMobileNoInput.Text = row.Cells[4].Value.ToString();
                updateStudentAddressInput.Text = row.Cells[5].Value.ToString();
                updateStudentGenderPicker.SelectedItem = row.Cells[6].Value.ToString();

                studentUpdatePanel.Visible = true;
            }
        }
    }
}
