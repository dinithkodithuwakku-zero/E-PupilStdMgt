using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.src.controller.forms.reports;

namespace E_PupilStdMgt.src.controller.forms.screens
{
    public partial class ReportScreenForm : Form
    {
        public ReportScreenForm()
        {
            InitializeComponent();
        }

        private void classStudentListReportButton_Click(object sender, EventArgs e)
        {
            ClassStudentListReportView classStudentListReportView = new ClassStudentListReportView();
            classStudentListReportView.Show();
        }

        private void studentMarkListReportButton_Click(object sender, EventArgs e)
        {
            StudentMarkListReport studentMarkListReport = new StudentMarkListReport();
            studentMarkListReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassMappingReport classMappingReport = new ClassMappingReport();
            classMappingReport.Show();
        }
    }
}
