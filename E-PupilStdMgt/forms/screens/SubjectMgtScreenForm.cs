using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_PupilStdMgt.forms.screens
{
    public partial class SubjectMgtScreenForm : Form
    {
        public SubjectMgtScreenForm()
        {
            InitializeComponent();
            ButtonProperties();
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
            subjectCreatePanel.Visible = false;
        }

        private void createPanelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
