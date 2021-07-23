using System;
using System.Drawing;
using System.Windows.Forms;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace E_PupilStdMgt.forms.screens
{
    public partial class SchoolMgtScreenForm : Form
    {
        String schoolId, schoolBadgeFilePath;

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
            catch (FileNotFoundException ffe)
            {
                MessageBox.Show("School badge not found! loading static image", "Error!");
                schoolBadgeImageUploader.Image = Image.FromFile(string.Format("{0}Resources\\esoft_badge.jpg", Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory)));
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

                schoolDTO.Validate();

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
            catch (ValidationException Exp)
            {
                MessageBox.Show(this, Exp.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
