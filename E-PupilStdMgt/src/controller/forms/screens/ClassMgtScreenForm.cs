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
using System.ComponentModel.DataAnnotations;
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.forms.screens
{
    public partial class ClassMgtScreenForm : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        private int _selectedClassId;

        public ClassMgtScreenForm()
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);

            InitializeComponent();

            LoadClassDetails();

            ButtonProperties();
        }

        private void LoadClassDetails()
        {
            try
            {
                classDataGrid.Rows.Clear();

                List<ClassDTO> list = iClassServiceCustom.FindAllClasses();

                foreach (ClassDTO dto in list)
                {
                    this.classDataGrid.Rows.Add(dto.ClassId, dto.ClassName, dto.ClassCode, dto.IsActive);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load class details!", "Error!");
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

                ClassDTO classDTO = new ClassDTO();
                classDTO.ClassName = classNameInput.Text;
                classDTO.ClassCode = classCodeInput.Text;
                classDTO.IsActive = isActiveCheckBox.Checked ? 1 : 0;

                classDTO.Validate();

                bool isCreated = iClassServiceCustom.CreateClass(classDTO);

                if (isCreated)
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
            catch (ValidationException Exp)
            {
                MessageBox.Show(this, Exp.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void ClearCreateFormData()
        {

            classNameInput.Text = null;
            classCodeInput.Text = null;
            isActiveCheckBox.Checked = false;
            classCreatePanel.Visible = false;

            _selectedClassId = 0;
            updateClassNameInput.Text = null;
            updateClassCodeInput.Text = null;
            updateClassIsActiveCheckbox.Checked = false;
            classUpdatePanel.Visible = false;
        }

        private void classDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.classDataGrid.Rows[e.RowIndex];

                _selectedClassId = Int16.Parse(row.Cells[0].Value.ToString());
                updateClassNameInput.Text = row.Cells[1].Value.ToString();
                updateClassCodeInput.Text = row.Cells[2].Value.ToString();

                updateClassIsActiveCheckbox.Checked = Int16.Parse(row.Cells[3].Value.ToString()) == 1 ? true : false;

                classUpdatePanel.Visible = true;
            }
        }

        private void cancelPanelButton_Click(object sender, EventArgs e)
        {
            ClearCreateFormData();
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {

                ClassDTO classDTO = new ClassDTO();
                classDTO.ClassId = _selectedClassId;
                classDTO.ClassName = updateClassNameInput.Text;
                classDTO.ClassCode = updateClassCodeInput.Text;
                classDTO.IsActive = updateClassIsActiveCheckbox.Checked ? 1 : 0;

                classDTO.Validate();

                bool isUpdated = iClassServiceCustom.UpdateClass(classDTO);

                if (isUpdated)
                {
                    MessageBox.Show("Class Updated!");
                    LoadClassDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Update Class!", "Error!");
                }

            }
            catch (ValidationException Exp)
            {
                MessageBox.Show(this, Exp.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void deletePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete Class?",
                                   "Confirm Delete!!",
                                   MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = iClassServiceCustom.DeleteClass(_selectedClassId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Class Deleted!");
                        LoadClassDetails();
                        ClearCreateFormData();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Class!", "Error!");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Connection Error", "Error!");
            }
        }

        private void printCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.csv)|*.csv";
            sfd.FileName = $"Class-CSV.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                new GenerateCSV().ToCsV(classDataGrid, sfd.FileName);
            }
        }
    }
}
