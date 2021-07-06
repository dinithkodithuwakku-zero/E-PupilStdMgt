using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using E_PupilStdMgt.src.controller.forms.screens;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.service;
using E_PupilStdMgt.src.service.custom;
using E_PupilStdMgt.src.service.custom.impl;

namespace E_PupilStdMgt.src.controller.forms
{
    public partial class StuffDashboardForm : Form
    {

        private ISubjectServiceCustom iSubjectServiceCustom;
        private IStudentServiceCustom iStudentServiceCustom;
        private IClassServiceCustom iClassServiceCustom;

        private Dictionary<string, Label> lClassDict = new Dictionary<string, Label>();
        private Dictionary<string, Label> lSubjectDict = new Dictionary<string, Label>();
        private Dictionary<string, Label> lStudentDict = new Dictionary<string, Label>();

        private string subjectCodePoint, classCodePoint, studentRegNoPoint;
        private List<string> subjectCodePointList = new List<string>();
        private List<string> classCodePointList = new List<string>();
        private List<string> studentRegNoPointList = new List<string>();

        Dictionary<string, List<string>> classesToSubjectMapping = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> classesToStudentMapping = new Dictionary<string, List<string>>();

        public StuffDashboardForm()
        {
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);

            InitializeComponent();

            AddSubjectsToPanel();
            AddClassesToPanel();
            AddStudentsToPanel();

            GetClassesToSubjectMapping();
            GetClassesToStudentMapping();

            subjectLabel.Left = 0;
            classLabel.Left = this.parentPanel.Width / 2;
            studentLabel.Left = this.parentPanel.Width;
        }

        private void AddClassesToPanel()
        {

            // GET ALL CLASSES because IF CLASS CLOSED MEAN IT'S ON REPAIR OR SOMETHING
            List<ClassDTO> list = iClassServiceCustom.FindAllClasses();

            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label();

                label.Name = list[i].ClassCode;
                label.Text = list[i].ClassName;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Top = i * 60 + 50;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(this.ClassLabelClicked);

                label.Left = this.parentPanel.Width / 2;

                lClassDict[label.Name] = label;

                parentPanel.Controls.Add(label);
            }
        }

        private void AddSubjectsToPanel()
        {
            // GET ACTIVE SUBJECT
            List<SubjectDTO> list = iSubjectServiceCustom.FindAllSubjects();

            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label();

                label.Name = list[i].SubjectCode;
                label.Text = list[i].SubjectName;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Top = i * 60 + 50;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(this.SubjectLabelClicked);
                lSubjectDict[label.Name] = label;

                parentPanel.Controls.Add(label);
            }
        }

        private void AddStudentsToPanel()
        {

            StudentDTO studentDTO = new StudentDTO();
            studentDTO.Status = 1;

            List<StudentDTO> list = iStudentServiceCustom.FindStudents(studentDTO);

            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label();

                label.Name = list[i].StudentRegNo;
                label.Text = list[i].StudentName;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = i * 60 + 50;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                // label.Click += new EventHandler(this.StudentLabelClicked);
                lStudentDict[label.Name] = label;
                label.Left = (int)(this.parentPanel.Width);
                // label.DoubleClick += new EventHandler(this.StudentLabelDoubleClicked);
                label.MouseUp += (s, args) =>
                {
                    if (args.Button == MouseButtons.Right)
                    {
                        this.StudentLabelRightClicked(s, args);
                    }
                    else
                    {
                        this.StudentLabelLeftClicked(s, args);
                    }
                };

                parentPanel.Controls.Add(label);
            }
        }

        public void GetClassesToSubjectMapping()
        {
            List<ClassSubjectDTO> classSubjectList = iClassServiceCustom.FindSubjectMapping();

            foreach (ClassSubjectDTO classSubjectDTO in classSubjectList)
            {
                if (classesToSubjectMapping.ContainsKey(classSubjectDTO.ClassDTO.ClassCode))
                {
                    List<string> classSubjects = classesToSubjectMapping[classSubjectDTO.ClassDTO.ClassCode];
                    classSubjects.Add(classSubjectDTO.SubjectDTO.SubjectCode);

                    classesToSubjectMapping[classSubjectDTO.ClassDTO.ClassCode] = classSubjects;
                }
                else
                {
                    classesToSubjectMapping.Add(classSubjectDTO.ClassDTO.ClassCode, new List<string>() { classSubjectDTO.SubjectDTO.SubjectCode });
                }

                classCodePointList.Add(classSubjectDTO.ClassDTO.ClassCode);
                subjectCodePointList.Add(classSubjectDTO.SubjectDTO.SubjectCode);
            }

            Debug.WriteLine(classesToSubjectMapping.Count);

            parentPanel.Invalidate();
        }

        public void GetClassesToStudentMapping()
        {
            List<ClassStudentDTO> classStudentList = iClassServiceCustom.FindStudentMapping();

            foreach (ClassStudentDTO classStudentDTO in classStudentList)
            {
                if (classesToStudentMapping.ContainsKey(classStudentDTO.ClassDTO.ClassCode))
                {
                    List<string> classStudents = classesToStudentMapping[classStudentDTO.ClassDTO.ClassCode];
                    classStudents.Add(classStudentDTO.StudentDTO.StudentRegNo);

                    classesToStudentMapping[classStudentDTO.ClassDTO.ClassCode] = classStudents;
                }
                else
                {
                    classesToStudentMapping.Add(classStudentDTO.ClassDTO.ClassCode, new List<string>() { classStudentDTO.StudentDTO.StudentRegNo });
                }

                classCodePointList.Add(classStudentDTO.ClassDTO.ClassCode);
                studentRegNoPointList.Add(classStudentDTO.StudentDTO.StudentRegNo);
            }

            Debug.WriteLine(classesToSubjectMapping.Count);

            parentPanel.Invalidate();
        }

        void ClassLabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (string.IsNullOrEmpty(this.classCodePoint))
            {
                this.classCodePoint = label.Name;
                classCodePointList.Add(label.Name);
            }
            else
            {
                MessageBox.Show("Already selected a class, Please select a Subject!");
            }

            AddClassSubjectMapping();

            AddClassStudentMapping();
        }

        private void AddClassSubjectMapping()
        {
            if (!string.IsNullOrEmpty(this.subjectCodePoint) && !string.IsNullOrEmpty(this.classCodePoint))
            {

                ClassSubjectDTO classSubjectDTO = new ClassSubjectDTO();

                ClassDTO classDTO = new ClassDTO();
                classDTO.ClassCode = this.classCodePoint;
                classSubjectDTO.ClassDTO = classDTO;

                SubjectDTO subjectDTO = new SubjectDTO();
                subjectDTO.SubjectCode = this.subjectCodePoint;
                classSubjectDTO.SubjectDTO = subjectDTO;

                bool isMapCreated = iClassServiceCustom.AddSubjectMapping(classSubjectDTO);

                if (isMapCreated)
                {
                    if (classesToSubjectMapping.ContainsKey(this.classCodePoint))
                    {
                        List<string> classSubjects = classesToSubjectMapping[this.classCodePoint];
                        classSubjects.Add(this.subjectCodePoint);

                        classesToSubjectMapping[this.classCodePoint] = classSubjects;
                    }
                    else
                    {
                        classesToSubjectMapping.Add(this.classCodePoint, new List<string>() { this.subjectCodePoint });
                    }


                    this.subjectCodePoint = null;
                    this.classCodePoint = null;
                    parentPanel.Invalidate();
                }
                else
                {
                    MessageBox.Show("Unable to create class - subject mapping");
                }
            }

            /*if (!string.IsNullOrEmpty(this.subjectCodePoint) && !string.IsNullOrEmpty(this.classCodePoint))
            {
                if (classesToSubjectMapping.ContainsKey(this.classCodePoint))
                {
                    List<string> classSubjects = classesToSubjectMapping[this.classCodePoint];
                    classSubjects.Add(this.subjectCodePoint);

                    classesToSubjectMapping[this.classCodePoint] = classSubjects;
                }
                else
                {
                    classesToSubjectMapping.Add(this.classCodePoint, new List<string>() { this.subjectCodePoint });
                }

                this.subjectCodePoint = null;
                this.classCodePoint = null;
                parentPanel.Invalidate();
            }*/
        }

        void SubjectLabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (string.IsNullOrEmpty(this.studentRegNoPoint))
            {
                if (string.IsNullOrEmpty(this.subjectCodePoint))
                {
                    this.subjectCodePoint = label.Name;
                    subjectCodePointList.Add(label.Name);
                }
                else
                {
                    MessageBox.Show("Already selected a subject, Please select a Class!");
                }

                AddClassSubjectMapping();
            }
            else
            {
                MessageBox.Show("You should select a Class to map Student");
            }
        }


        void StudentLabelLeftClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            if (string.IsNullOrEmpty(this.subjectCodePoint))
            {
                if (string.IsNullOrEmpty(this.studentRegNoPoint))
                {
                    this.studentRegNoPoint = label.Name;
                    studentRegNoPointList.Add(label.Name);
                }
                else
                {
                    MessageBox.Show("Already selected a Student, Please select a Class!");
                }

                AddClassStudentMapping();
            }
            else
            {
                MessageBox.Show("You should select a Class to map Subject");
            }
        }

        private void AddClassStudentMapping()
        {
            if (!string.IsNullOrEmpty(this.studentRegNoPoint) && !string.IsNullOrEmpty(this.classCodePoint))
            {

                ClassStudentDTO classStudentDTO = new ClassStudentDTO();

                ClassDTO classDTO = new ClassDTO();
                classDTO.ClassCode = this.classCodePoint;
                classStudentDTO.ClassDTO = classDTO;

                StudentDTO studentDTO = new StudentDTO();
                studentDTO.StudentRegNo = this.studentRegNoPoint;
                classStudentDTO.StudentDTO = studentDTO;

                bool isMapCreated = iClassServiceCustom.AddStudentMapping(classStudentDTO);

                if (isMapCreated)
                {
                    if (classesToStudentMapping.ContainsKey(this.classCodePoint))
                    {
                        List<string> classSubjects = classesToStudentMapping[this.classCodePoint];
                        classSubjects.Add(this.studentRegNoPoint);

                        classesToStudentMapping[this.classCodePoint] = classSubjects;
                    }
                    else
                    {
                        classesToStudentMapping.Add(this.classCodePoint, new List<string>() { this.studentRegNoPoint });
                    }

                    this.studentRegNoPoint = null;
                    this.classCodePoint = null;
                    parentPanel.Invalidate();
                }
                else
                {
                    MessageBox.Show("Unable to create class - student mapping");
                }
            }


            /*if (!string.IsNullOrEmpty(this.studentRegNoPoint) && !string.IsNullOrEmpty(this.classCodePoint))
            {
                if (classesToStudentMapping.ContainsKey(this.classCodePoint))
                {
                    List<string> classSubjects = classesToStudentMapping[this.classCodePoint];
                    classSubjects.Add(this.studentRegNoPoint);

                    classesToStudentMapping[this.classCodePoint] = classSubjects;
                }
                else
                {
                    classesToStudentMapping.Add(this.classCodePoint, new List<string>() { this.studentRegNoPoint });
                }

                this.studentRegNoPoint = null;
                this.classCodePoint = null;
                parentPanel.Invalidate();
            }*/
        }

        private void parentPanel_Paint(object sender, PaintEventArgs e)
        {
            /* using (var p = new Pen(Color.Blue, 4))
             {
                 for (int x = 0; x < p1List.Count; x++)
                 {
                     e.Graphics.DrawLine(p, p1List[x], p2List[x]);
                 }
             }*/

            using (var p = new Pen(Color.White, 4))
            {
                for (int i = 0; i < classCodePointList.Count; i++)
                {
                    if (classesToSubjectMapping.ContainsKey(classCodePointList[i]))
                    {
                        List<string> classSubjects = classesToSubjectMapping[classCodePointList[i]];

                        foreach (string subjectCode in classSubjects)
                        {
                            var classLabel = lClassDict[classCodePointList[i]];
                            var subjectLabel = lSubjectDict[subjectCode];

                            //subjectLabel.Location.X = subjectLabel.Location.X - subjectLabel.Size.Width;
                            Point sbPoint = subjectLabel.Location;
                            sbPoint.X = subjectLabel.Location.X + subjectLabel.Size.Width;
                            sbPoint.Y = subjectLabel.Location.Y + (subjectLabel.Size.Height / 2);

                            Point clPoint = classLabel.Location;
                            clPoint.X = classLabel.Location.X;
                            clPoint.Y = classLabel.Location.Y + (classLabel.Size.Height / 2);

                            e.Graphics.DrawLine(p, clPoint, sbPoint);
                        }
                    }
                }
            }

            using (var p = new Pen(Color.Red, 4))
            {
                for (int i = 0; i < classCodePointList.Count; i++)
                {
                    if (classesToStudentMapping.ContainsKey(classCodePointList[i]))
                    {

                        List<string> classStudents = classesToStudentMapping[classCodePointList[i]];

                        foreach (string studentRegNo in classStudents)
                        {
                            var classLabel = lClassDict[classCodePointList[i]];
                            var studentLabel = lStudentDict[studentRegNo];

                            //subjectLabel.Location.X = subjectLabel.Location.X - subjectLabel.Size.Width;
                            Point stPoint = studentLabel.Location;
                            stPoint.X = studentLabel.Location.X;
                            stPoint.Y = studentLabel.Location.Y + (studentLabel.Size.Height / 2);

                            Point clPoint = classLabel.Location;
                            clPoint.X = classLabel.Location.X + classLabel.Size.Width;
                            clPoint.Y = classLabel.Location.Y + (classLabel.Size.Height / 2);

                            e.Graphics.DrawLine(p, clPoint, stPoint);
                        }
                    }
                }
            }
        }


        void StudentLabelRightClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            StudentDTO studentDTO = new StudentDTO();
            studentDTO.StudentRegNo = label.Name;
            studentDTO.Status = 1;

            List<StudentDTO> studentDTOList = iStudentServiceCustom.FindStudents(studentDTO);
            Debug.WriteLine(studentDTOList.Count);
            if (studentDTOList.Count > 0)
            {
                StudentMarkMgtScreenForm studentMarkMgtScreenForm = new StudentMarkMgtScreenForm(studentDTOList[0]);

                studentMarkMgtScreenForm.Show();
            }
            else
            {
                MessageBox.Show("Student not found!", "Error!");
            }
        }
    }
}
