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
    public partial class ClassMgtScreenForm : Form
    {
        private IClassServiceCustom iClassServiceCustom;

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
        }
    }
}
