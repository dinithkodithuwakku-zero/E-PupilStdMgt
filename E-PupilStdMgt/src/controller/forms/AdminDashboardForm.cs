using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.forms.screens;

namespace E_PupilStdMgt.forms
{
    public partial class AdminDashboardForm : Form
    {
        private Int16 _loginType; // 1 is admin, 2 is stuff 
        public AdminDashboardForm()
        {

            // this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            LoadDashboardScreen();
        }


        // when ESC button pressed
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

        // when comonent loaded, make changes to the form controls in the panel
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

            DashboardScreenForm dashboardScreenForm = new DashboardScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Student Management";

            StudentMgtScreenForm studentMgtScreenForm = new StudentMgtScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            studentMgtScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(studentMgtScreenForm);
            studentMgtScreenForm.Show();
        }

        private void stuffMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            stuffMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Stuff Management";

            StuffMgtScreenForm stuffMgtScreenForm = new StuffMgtScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            stuffMgtScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(stuffMgtScreenForm);
            stuffMgtScreenForm.Show();
        }

        private void classMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            classMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Class Management";

            ClassMgtScreenForm classMgtScreenForm = new ClassMgtScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            classMgtScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(classMgtScreenForm);
            classMgtScreenForm.Show();
        }

        private void subjectMgtPanelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetNavigationButtonColors();
            subjectMgtPanelButton.BackColor = Color.FromArgb(46, 51, 73);

            this.formLoaderPanel.Controls.Clear();
            currentPanelTitleLabel.Text = "Subject Management";

            SubjectMgtScreenForm subjectMgtScreenForm = new SubjectMgtScreenForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            subjectMgtScreenForm.FormBorderStyle = FormBorderStyle.None;

            this.formLoaderPanel.Controls.Add(subjectMgtScreenForm);
            subjectMgtScreenForm.Show();
        }

        // exit button
        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                  "Confirm Exit!!",
                                  MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // logout button
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to logout?",
                                  "Confirm logout!!",
                                  MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                RolePickingForm rolePickingForm = new RolePickingForm();
                rolePickingForm.Show();
                this.Hide();
            }
        }
    }
}
