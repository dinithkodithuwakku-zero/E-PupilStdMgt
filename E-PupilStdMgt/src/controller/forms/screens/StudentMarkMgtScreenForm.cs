﻿using System;
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
        public StudentMarkMgtScreenForm(StudentDTO studentDTO)
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iClassSubjectStudentMarkServiceCustom = ServiceFactory.GetInstance().GetService<ClassSubjectStudentServiceImpl>(ServiceFactory.ServiceTypes.ClASS_SUBJECT_STUDENT_MARK);

            InitializeComponent();

            studentDetailLable.Text = studentDTO.StudentName + " - Reg no : " + studentDTO.StudentRegNo;
            _studentId = studentDTO.StudentId;
            LoadClassesToPicker();
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

        void classPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(classPicker.SelectedItem.ToString());
            LoadSubjectsToPickerByClassCode(classPicker.SelectedItem.ToString());
        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            try
            {

                ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO= new ClassSubjectStudentMarkDTO();
                classSubjectStudentMarkDTO.ClassSubjectDTO = new ClassSubjectDTO(new ClassDTO(classPicker.SelectedItem.ToString()), new SubjectDTO(subjectPicker.SelectedItem.ToString()));
                classSubjectStudentMarkDTO.StudentDTO = new StudentDTO(_studentId);
                classSubjectStudentMarkDTO.ExamDate = examDatePicker.Value.Date;
                classSubjectStudentMarkDTO.StudentPoint = Double.Parse(studentPointInput.Text);

                bool isCreated = iClassSubjectStudentMarkServiceCustom.CreateStudentMark(classSubjectStudentMarkDTO);

                if (isCreated)
                {
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
    }
}
