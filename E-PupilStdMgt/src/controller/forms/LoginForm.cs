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
using E_PupilStdMgt.forms;
using E_PupilStdMgt.src.controller.forms;

namespace E_PupilStdMgt.forms
{
    public partial class LoginForm : Form
    {
        private Int16 _loginType; // 1 is admin, 2 is stuff 
        private ILoginServiceCustom iLoginServiceCustom;

        public LoginForm(Int16 loginType)
        {

            iLoginServiceCustom = ServiceFactory.GetInstance().GetService<LoginServiceImpl>(ServiceFactory.ServiceTypes.LOGIN);
            _loginType = loginType;
            InitializeComponent();

            AlignComponent();
            InputStyles();
            LoginButtonStyles();

            userNameInput.Focus();
        }

        public void AlignComponent()
        {
            backgroundPanel.Left = (this.ClientSize.Width - backgroundPanel.Width) / 2;
            inputPanel.Left = (this.ClientSize.Width - inputPanel.Width) / 2;
            titleLabel.Left = (this.ClientSize.Width - titleLabel.Width) / 2;
            coverImage.Left = (this.ClientSize.Width - coverImage.Width) / 2;
            loginButton.Left = (this.ClientSize.Width - loginButton.Width) / 2;
        }

        public void LoginButtonStyles()
        {
            loginButton.TabStop = false;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;

            if (_loginType == 1)
            {
                loginButton.BackColor = Color.FromArgb(47, 136, 88);
            }
            else if (_loginType == 2)
            {
                loginButton.BackColor = Color.FromArgb(44, 82, 130);
            }
        }

        public void InputStyles()
        {
            userNameInput.ForeColor = Color.White;
            passwordInput.ForeColor = Color.White;
            passwordInput.PasswordChar = '*';
        }


        private void userNameImage_Click(object sender, EventArgs e)
        {
            userNameInput.Focus();
        }

        private void passwordImage_Click(object sender, EventArgs e)
        {
            passwordInput.Focus();
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            RolePickingForm RolePickingForm = new RolePickingForm();
            RolePickingForm.Show();
            Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO loginDTO = new LoginDTO();
                loginDTO.UserName = userNameInput.Text;
                loginDTO.Password = passwordInput.Text;
                loginDTO.UserType = _loginType;


                bool isChecked = iLoginServiceCustom.CheckLoginCredientials(loginDTO);
                if (isChecked)
                {
                    if (_loginType == 1)
                    {
                        AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                        adminDashboardForm.Show();
                        this.Hide();
                    }
                    else if (_loginType == 2)
                    {
                        StuffDashboardForm stuffDashboardForm = new StuffDashboardForm();
                        stuffDashboardForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User not found! Please check user name and password!!", "Error - 401");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! " + ex.Message, "Error");
            }
        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
