using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using E_PupilStdMgt.src.db;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;

namespace E_PupilStdMgt.forms.screens
{
    public partial class SchoolMgtScreenForm : Form
    {
        DBConnection con = new DBConnection();
        String schoolId, schoolName, schoolDescription, schoolBadgeFilePath, schoolAddress, schoolContactNo;

        private ISchoolServiceCustom iSchoolServiceCustom;

        public SchoolMgtScreenForm()
        {
            iSchoolServiceCustom = ServiceFactory.GetInstance().GetService<SchoolServiceImpl>(ServiceFactory.ServiceTypes.SCHOOL);

            InitializeComponent();

            LoadSchoolDetails();

            ButtonProperties();
        }

        private void LoadSchoolDetails()
        {
            try
            {
                SchoolDTO schoolDTO = iSchoolServiceCustom.GetSchoolDetails();

                schoolNameInput.Text = schoolDTO.SchoolName;
                schoolDescriptionInput.Text = schoolDTO.SchoolDescription;
                schoolContactNoInput.Text = schoolDTO.SchoolContactNo;
                schoolAddressInput.Text = schoolDTO.SchoolAddress;
                schoolBadgeImageUploader.Image = Image.FromFile(@schoolDTO.SchoolBadgeImagePath);

                schoolId = schoolDTO.SchoolId.ToString();
                schoolBadgeFilePath = schoolDTO.SchoolBadgeImagePath;
            }
            catch
            {
                MessageBox.Show("Unable to load school details!", "Error!");
            }
            
        }

        public void ButtonProperties()
        {
            updateSchoolDetailsButton.TabStop = false;
            updateSchoolDetailsButton.FlatStyle = FlatStyle.Flat;
            updateSchoolDetailsButton.FlatAppearance.BorderSize = 0;
        }

        private void updateSchoolDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SchoolDTO schoolDTO = new SchoolDTO(Int16.Parse(schoolId), schoolNameInput.Text, schoolDescriptionInput.Text, schoolContactNoInput.Text, schoolAddressInput.Text, schoolBadgeFilePath);
                Boolean isUpdated = iSchoolServiceCustom.UpdateSchool(schoolDTO);

                if (isUpdated)
                {
                    MessageBox.Show("School Details Updated!");
                }
                else
                {
                    MessageBox.Show("Unable to Update School Details!", "Error!");
                }

                LoadSchoolDetails();
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error!");
            }
        }

        private void schoolBadgeImageUploader_Click(object sender, EventArgs e)
        {
            if (schoolBadgeFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                schoolBadgeFilePath = schoolBadgeFileDialog.FileName;
                schoolBadgeImageUploader.Image = Image.FromFile(@schoolBadgeFilePath);
            }
        }
    }
}
