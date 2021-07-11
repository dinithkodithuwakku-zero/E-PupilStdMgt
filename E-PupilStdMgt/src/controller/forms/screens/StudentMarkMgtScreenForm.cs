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
using System.Diagnostics;

namespace E_PupilStdMgt.src.controller.forms.screens
{
    partial class StudentMarkMgtScreenForm : Form
    {
        private ISubjectServiceCustom iSubjectServiceCustom;
        private IClassServiceCustom iClassServiceCustom;
        private IClassSubjectStudentMarkServiceCustom iClassSubjectStudentMarkServiceCustom;

        private int _studentId;
        private int _classSubjectStudentMarkId;
        public StudentMarkMgtScreenForm(StudentDTO studentDTO)
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iClassSubjectStudentMarkServiceCustom = ServiceFactory.GetInstance().GetService<ClassSubjectStudentServiceImpl>(ServiceFactory.ServiceTypes.ClASS_SUBJECT_STUDENT_MARK);

            InitializeComponent();

            studentDetailLable.Text = studentDTO.StudentName + " - Reg no : " + studentDTO.StudentRegNo;
            _studentId = studentDTO.StudentId;
            LoadClassesToPicker();

            LoadClassSubjectStudentMarkDetails();
        }

        void LoadClassesToPicker()
        {
            try
            {
                List<ClassDTO> list = iClassServiceCustom.FindAllClasses();

                foreach (ClassDTO classDTO in list)
                {
                    classPicker.Items.Add(classDTO.ClassCode);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load classes!", "Error!");
            }
        }

        void LoadSubjectsToPickerByClassCode(string classCode)
        {
            try
            {
                subjectPicker.Items.Clear();

                List<SubjectDTO> list = iClassServiceCustom.FindAllSubjectsByClassCodeAndStudentId(classCode, _studentId);

                foreach (SubjectDTO subjectDTO in list)
                {
                    subjectPicker.Items.Add(subjectDTO.SubjectCode);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load subjects!", "Error!");
            }
        }

        void LoadClassSubjectStudentMarkDetails()
        {
            try
            {
                classSubjectStudentMarkDataGrid.Rows.Clear();

                List<ClassSubjectStudentMarkDTO> list = iClassSubjectStudentMarkServiceCustom.FindClassSubjectStudentMarks();

                foreach (ClassSubjectStudentMarkDTO dto in list)
                {
                    this.classSubjectStudentMarkDataGrid.Rows.Add(dto.ClassSubjectStudentMarkId, dto.ClassSubjectDTO.ClassDTO.ClassCode, dto.ClassSubjectDTO.ClassDTO.ClassName, dto.ClassSubjectDTO.SubjectDTO.SubjectCode, dto.ClassSubjectDTO.SubjectDTO.SubjectName, dto.StudentDTO.StudentName, dto.ExamDate.ToShortDateString(), dto.StudentPoint);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load class details!", "Error!");
            }
        }

        void classPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (classPicker.SelectedIndex != -1)
                LoadSubjectsToPickerByClassCode(classPicker.SelectedItem.ToString());
        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            try
            {

                ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO = new ClassSubjectStudentMarkDTO();
                classSubjectStudentMarkDTO.ClassSubjectDTO = new ClassSubjectDTO(new ClassDTO(classPicker.SelectedItem.ToString()), new SubjectDTO(subjectPicker.SelectedItem.ToString()));
                classSubjectStudentMarkDTO.StudentDTO = new StudentDTO(_studentId);
                classSubjectStudentMarkDTO.ExamDate = examDatePicker.Value.Date;
                classSubjectStudentMarkDTO.StudentPoint = Double.Parse(studentPointInput.Text);

                bool isCreated = iClassSubjectStudentMarkServiceCustom.CreateStudentMark(classSubjectStudentMarkDTO);

                if (isCreated)
                {
                    LoadClassSubjectStudentMarkDetails();
                    MessageBox.Show("Class Subject Student mark Submitted!");
                }
                else
                {
                    MessageBox.Show("Unable to Submit Class Subject Student mark!", "Error!");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void StudentMarkMgtScreenForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearInputForm()
        {
            classPicker.SelectedIndex = -1;
            subjectPicker.SelectedIndex = -1;
            examDatePicker.Value = DateTime.Now;
            studentPointInput.Text = null;

            studentDetailUpdatePanelLable.Text = "";

            _classSubjectStudentMarkId = 0;
            classUpdateInput.Text = null;
            subjectUpdateInput.Text = null;
            updateExamDatePicker.Value = DateTime.Now;
            updateStudentPointInput.Text = null;

            updatePanel.Visible = false;
        }

        private void classSubjectStudentMarkDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.classSubjectStudentMarkDataGrid.Rows[e.RowIndex];

                studentDetailUpdatePanelLable.Text = "Student : " + row.Cells[5].Value.ToString();

                _classSubjectStudentMarkId = Int16.Parse(row.Cells[0].Value.ToString());
                classUpdateInput.Text = row.Cells[2].Value.ToString();
                subjectUpdateInput.Text = row.Cells[4].Value.ToString();
                updateExamDatePicker.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                updateStudentPointInput.Text = row.Cells[7].Value.ToString();

                updatePanel.Visible = true;
            }
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {

                ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO = new ClassSubjectStudentMarkDTO();
                classSubjectStudentMarkDTO.ClassSubjectStudentMarkId = _classSubjectStudentMarkId;
                classSubjectStudentMarkDTO.ExamDate = updateExamDatePicker.Value.Date;
                classSubjectStudentMarkDTO.StudentPoint = Double.Parse(updateStudentPointInput.Text);

                bool isUpdated = iClassSubjectStudentMarkServiceCustom.UpdateStudentMark(classSubjectStudentMarkDTO);

                if (isUpdated)
                {
                    LoadClassSubjectStudentMarkDetails();
                    ClearInputForm();
                    MessageBox.Show("Class Subject Student mark Updated!");
                }
                else
                {
                    MessageBox.Show("Unable to Update Class Subject Student mark!", "Error!");
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

                bool isDeleted = iClassSubjectStudentMarkServiceCustom.DeleteStudentMark(_classSubjectStudentMarkId);

                if (isDeleted)
                {
                    LoadClassSubjectStudentMarkDetails();
                    ClearInputForm();
                    MessageBox.Show("Class Subject Student mark Deleted!");
                }
                else
                {
                    MessageBox.Show("Unable to Delete Class Subject Student mark!", "Error!");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            ClearInputForm();
        }

        private void closePanelButton_Click(object sender, EventArgs e)
        {
            ClearInputForm();
        }
    }
}
