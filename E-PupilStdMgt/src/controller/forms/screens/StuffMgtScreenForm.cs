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
using E_PupilStdMgt.src.utill;

namespace E_PupilStdMgt.forms.screens
{
    public partial class StuffMgtScreenForm : Form
    {
        private IStuffServiceCustom iStuffServiceCustom;
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();
        private int _stuffId;
        public StuffMgtScreenForm()
        {
            iStuffServiceCustom = ServiceFactory.GetInstance().GetService<StuffServiceImpl>(ServiceFactory.ServiceTypes.STUFF);
            InitializeComponent();
            LoadStuffDetails();
            ButtonProperties();

            passwordInput.PasswordChar = '*';
        }

        public void LoadStuffDetails()
        {
            try
            {
                userDataGrid.Rows.Clear();

                List<StuffDTO> list = iStuffServiceCustom.FindAllStuff();

                foreach (StuffDTO dto in list)
                {
                    this.userDataGrid.Rows.Add(dto.StuffId, dto.UserName, dto.FullName, dto.Nic, dto.JobTitle, dto.MobileNo, dto.Email, dto.PermanentAddress);
                }
            }
            catch
            {
                MessageBox.Show("Unable to load stuff details!", "Error!");
            }
        }

        public void ButtonProperties()
        {
            createNewUserButton.TabStop = false;
            createNewUserButton.FlatStyle = FlatStyle.Flat;
            createNewUserButton.FlatAppearance.BorderSize = 0;

            createPanelButton.TabStop = false;
            createPanelButton.FlatStyle = FlatStyle.Flat;
            createPanelButton.FlatAppearance.BorderSize = 0;

            closePanelButton.TabStop = false;
            closePanelButton.FlatStyle = FlatStyle.Flat;
            closePanelButton.FlatAppearance.BorderSize = 0;
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            userCreatePanel.Visible = true;
        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCreated = iStuffServiceCustom.CreateNewStuff(new StuffDTO(userNameInput.Text, encryptDecrypt.Encrypt(passwordInput.Text), fullNameInput.Text, nicInput.Text, jobTitlePicker.SelectedItem.ToString(), mobileNoInput.Text, emailInput.Text, permanentAddressInput.Text));

                if (isCreated)
                {
                    MessageBox.Show("New User Created!");
                    LoadStuffDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Create new User!", "Error!");
                }

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

        private void ClearCreateFormData()
        {
            userNameInput.Text = null;
            passwordInput.Text = null;
            fullNameInput.Text = null;
            nicInput.Text = null;
            mobileNoInput.Text = null;
            emailInput.Text = null;
            permanentAddressInput.Text = null;
            jobTitlePicker.SelectedIndex = -1;
            userCreatePanel.Visible = false;

            _stuffId = 0;
            updateUserFullNameInput.Text = null;
            updateUserNICInput.Text = null;
            updateUserJobTitlePicker.SelectedIndex = -1;
            updateUserMobileNoInput.Text = null;
            updateUserEmailInput.Text = null;
            updateUserAddressInput.Text = null;
            updateUserPanel.Visible = false;
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isUpdated = iStuffServiceCustom.UpdateStuff(new StuffDTO(_stuffId, updateUserFullNameInput.Text, updateUserNICInput.Text, updateUserJobTitlePicker.SelectedItem.ToString(), updateUserMobileNoInput.Text, updateUserEmailInput.Text, updateUserAddressInput.Text));

                if (isUpdated)
                {
                    MessageBox.Show("User Updated!");
                    LoadStuffDetails();
                    ClearCreateFormData();
                }
                else
                {
                    MessageBox.Show("Unable to Update User!", "Error!");
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
                var confirmResult = MessageBox.Show("Are you sure to delete User?",
                                  "Confirm Delete!!",
                                  MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = iStuffServiceCustom.DeleteStuff(_stuffId);

                    if (isDeleted)
                    {
                        MessageBox.Show("User Deleted!");
                        LoadStuffDetails();
                        ClearCreateFormData();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete User!", "Error!");
                    }
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

        private void userDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.userDataGrid.Rows[e.RowIndex];

                _stuffId = Int16.Parse(row.Cells[0].Value.ToString());
                updateUserFullNameInput.Text = row.Cells[2].Value.ToString();
                updateUserNICInput.Text = row.Cells[3].Value.ToString();
                updateUserJobTitlePicker.SelectedItem = row.Cells[4].Value.ToString();
                updateUserMobileNoInput.Text = row.Cells[5].Value.ToString();
                updateUserEmailInput.Text = row.Cells[6].Value.ToString();
                updateUserAddressInput.Text = row.Cells[7].Value.ToString();

                updateUserPanel.Visible = true;
            }
        }
    }
}
