using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using System.Collections;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;
using Syncfusion.Windows.Forms.Chart;
using System.Diagnostics;

namespace E_PupilStdMgt.forms.screens
{
    public partial class DashboardScreenForm : Form
    {
        private IClassServiceCustom iClassServiceCustom;
        private IStuffServiceCustom iStuffServiceCustom;
        private ISubjectServiceCustom iSubjectServiceCustom;
        private IStudentServiceCustom iStudentServiceCustom;
        private IClassSubjectStudentMarkServiceCustom iClassSubjectStudentMarkServiceCustom;
        public DashboardScreenForm()
        {
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iStuffServiceCustom = ServiceFactory.GetInstance().GetService<StuffServiceImpl>(ServiceFactory.ServiceTypes.STUFF);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
            iClassSubjectStudentMarkServiceCustom = ServiceFactory.GetInstance().GetService<ClassSubjectStudentServiceImpl>(ServiceFactory.ServiceTypes.ClASS_SUBJECT_STUDENT_MARK);

            InitializeComponent();

            LoadNumberofClasses();
            LoadNumberofStuffUsers();
            LoadNumberofSubjects();
            LoadNumberofStudents();
            LoadStudentsGPA();
        }

        private void LoadNumberofClasses()
        {
            int count = iClassServiceCustom.CountNumberOfClasses();
            this.noOfClassesLabel.Text = count.ToString();
        }

        private void LoadNumberofStuffUsers()
        {
            int count = iStuffServiceCustom.CountNumberOfStuffUsers();
            this.noOfStuffUsersLabel.Text = count.ToString();
        }

        private void LoadNumberofSubjects()
        {
            int count = iSubjectServiceCustom.CountNumberOfSubjects();
            this.noOfSubjectsLabel.Text = count.ToString();
        }

        private void LoadNumberofStudents()
        {
            int count = iStudentServiceCustom.CountNumberOfStudents();
            this.noOfStudentsLabel.Text = count.ToString();
        }

        private void LoadStudentsGPA()
        {
            try
            {
                ArrayList studentGPAList = iClassSubjectStudentMarkServiceCustom.CalculateStudentsGPA();


                /*BindingList<StudentGPADTO> dataSource = new BindingList<StudentGPADTO>();

                foreach (StudentGPADTO studentGPADTO in studentGPAList)
                {
                    Debug.WriteLine(studentGPADTO.StudentRegNo);
                    Debug.WriteLine(studentGPADTO.Gpa);
                    dataSource.Add(studentGPADTO);
                }

                CategoryAxisDataBindModel dataSeriesModel = new CategoryAxisDataBindModel(dataSource);


                dataSeriesModel.CategoryName = "StudentRegNo";

                dataSeriesModel.YNames = new string[] { "Gpa" };

                ChartSeries chartSeries = new ChartSeries("Gpa");

                chartSeries.CategoryModel = dataSeriesModel;


                studentGPAChart.Title.Text = "Student Avg GPA";
                studentGPAChart.Series.Add(chartSeries);*/

                ChartSeries series = new ChartSeries("sadasdasd");

                ChartDataBindModel dataSeriesModel = new ChartDataBindModel(studentGPAList);


                dataSeriesModel.YNames = new string[] { "Population" };


                series.SeriesModel = dataSeriesModel;

                ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(studentGPAList);

                dataLabelsModel.LabelName = "City";

                studentGPAChart.Series.Add(series);

                studentGPAChart.PrimaryXAxis.LabelsImpl = dataLabelsModel;
            }
            catch (Exception ep)
            {
                MessageBox.Show("Something went wrong! " + ep.Message);
            }
        }
    }
}
