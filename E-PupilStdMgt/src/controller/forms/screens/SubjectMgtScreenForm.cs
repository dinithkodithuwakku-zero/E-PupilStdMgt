﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;


namespace E_PupilStdMgt.forms.screens
{
    public partial class SubjectMgtScreenForm : Form
    {
        private ISubjectServiceCustom iSubjectServiceCustom;
        private int _subjectId;

        DBConnection con = new DBConnection();
        public SubjectMgtScreenForm()
        {
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);

            InitializeComponent();
            LoadSubjectDetails();
            ButtonProperties();
        }

        public void LoadSubjectDetails()
        {
            try
            {
                subjectDataGrid.Rows.Clear();

                List<SubjectDTO> list = iSubjectServiceCustom.FindAllSubjects();

                foreach (SubjectDTO dto in list)
                {
                    this.subjectDataGrid.Rows.Add(dto.SubjectId, dto.SubjectName, dto.SubjectCode, dto.SubjectDuration, dto.SubjectTotalPoints);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load subject details!", "Error!");
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
                bool isCreated = iSubjectServiceCustom.CreateNewSubject(new SubjectDTO(subjectNameInput.Text, subjectCodeInput.Text, Int16.Parse(subjectDurationInput.Text), Double.Parse(subjectTotalPointsInput.Text)));

                if (isCreated)
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
        }

        private void ClearCreateFormData()
        {
            subjectNameInput.Text = null;
            subjectCodeInput.Text = null;
            subjectDurationInput.Text = null;
            subjectTotalPointsInput.Text = null;
            subjectCreatePanel.Visible = false;

            _subjectId = 0;
            updateSubjectNameInput.Text = null;
            updateSubjectCodeInput.Text = null;
            updateSubjectDurationInput.Text = null;
            updateSubjectTotalPointsInput.Text = null;
            subjectUpdatePanel.Visible = false;
        }

        private void subjectDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.subjectDataGrid.Rows[e.RowIndex];

                _subjectId = Int16.Parse(row.Cells[0].Value.ToString());
                updateSubjectNameInput.Text = row.Cells[1].Value.ToString();
                updateSubjectCodeInput.Text = row.Cells[2].Value.ToString();
                updateSubjectDurationInput.Text = row.Cells[3].Value.ToString();
                updateSubjectTotalPointsInput.Text = row.Cells[4].Value.ToString();

                subjectUpdatePanel.Visible = true;
            }
        }

        private void cancelUpdatePanelButton_Click(object sender, EventArgs e)
        {
            ClearCreateFormData();
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUpdated = iSubjectServiceCustom.UpdateSubject(new SubjectDTO(_subjectId, updateSubjectNameInput.Text, updateSubjectCodeInput.Text, Int16.Parse(updateSubjectDurationInput.Text), Double.Parse(updateSubjectTotalPointsInput.Text)));

                if (isUpdated)
                {
                    MessageBox.Show("Subject Updated!");
                    LoadSubjectDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Update Subject!", "Error!");
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
                bool isDeleted = iSubjectServiceCustom.DeleteSubject(_subjectId);

                if (isDeleted)
                {
                    MessageBox.Show("Subject Deleted!");
                    LoadSubjectDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Delete Subject!", "Error!");
                }

            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }
    }
}
