﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.forms.screens;

namespace E_PupilStdMgt.forms
{
    public partial class dashboardForm : Form
    {
        private Int16 _loginType; // 1 is admin, 2 is stuff 
        public dashboardForm(Int16 loginType)
        {
            _loginType = loginType;

            // this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            if (_loginType == 1)
            {
                userTypeLabel.Text = "an Admin user";
            }
            else if (_loginType == 2)
            {
                userTypeLabel.Text = "a Stuff user";
            }

           LoadDashboardScreen();
        }

        private void DashboardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to Exit?",
                                      "Confirm Exit!!",
                                      MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void LoadDashboardScreen()
        {
            dashboardPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Dashboard";

            DashboardScreenForm dashboardScreenForm = new DashboardScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(dashboardScreenForm);
            dashboardScreenForm.Show();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dashboardForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ResetNavigationButtonColors()
        {
            dashboardPanelButton.BackColor = Color.FromArgb(24, 30, 54);
            schoolMgtPanelButton.BackColor = Color.FromArgb(24, 30, 54);
            studentMgtPanelButton.BackColor = Color.FromArgb(24, 30, 54);
            stuffMgtPanelButton.BackColor = Color.FromArgb(24, 30, 54);
            classMgtPanelButton.BackColor = Color.FromArgb(24, 30, 54);
            subjectMgtPanelButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void dashboardPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            dashboardPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Dashboard";

            DashboardScreenForm dashboardScreenForm = new DashboardScreenForm() { Dock=DockStyle.Fill,TopLevel=false,TopMost=true };
            dashboardScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(dashboardScreenForm);
            dashboardScreenForm.Show();
        }

        private void schoolMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            schoolMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "School Management";

            SchoolMgtScreenForm schoolMgtScreenForm = new SchoolMgtScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            schoolMgtScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(schoolMgtScreenForm);
            schoolMgtScreenForm.Show();
        }

        private void studentMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            studentMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void stuffMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            stuffMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void classMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            classMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void subjectMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            subjectMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);
        }

    }
}
