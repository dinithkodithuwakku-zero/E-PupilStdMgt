﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using E_PupilStdMgt.src.controller.forms.screens;

namespace E_PupilStdMgt.src.controller.forms
{
    public partial class StuffDashboardForm : Form
    {

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
            InitializeComponent();

            AddSubjectsToPanel();
            AddClassesToPanel();
            AddStudentsToPanel();
        }


        private void AddClassesToPanel()
        {

            for (int i = 0; i < 5; i++)
            {
                Label label = new Label();

                label.Name = "ccode " + i;
                label.Text = "Class " + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Top = i * 60;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(this.ClassLabelClicked);

                label.Left = this.parentPanel.Width / 3;

                lClassDict[label.Name] = label;

                parentPanel.Controls.Add(label);
            }
        }

        private void AddSubjectsToPanel()
        {

            for (int i = 0; i < 10; i++)
            {
                Label label = new Label();

                label.Name = "scode " + i;
                label.Text = "Subject " + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Top = i * 60;
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

            for (int i = 0; i < 20; i++)
            {
                Label label = new Label();

                label.Name = "regno " + i;
                label.Text = "Student " + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = i * 60;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                // label.Click += new EventHandler(this.StudentLabelClicked);
                lStudentDict[label.Name] = label;
                label.Left = (int)(this.parentPanel.Width / 1.5);
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

            if (!string.IsNullOrEmpty(this.subjectCodePoint) && !string.IsNullOrEmpty(this.classCodePoint))
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

            if (!string.IsNullOrEmpty(this.studentRegNoPoint) && !string.IsNullOrEmpty(this.classCodePoint))
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

                if (!string.IsNullOrEmpty(this.subjectCodePoint) && !string.IsNullOrEmpty(this.classCodePoint))
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

                if (!string.IsNullOrEmpty(this.studentRegNoPoint) && !string.IsNullOrEmpty(this.classCodePoint))
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
            }
            else
            {
                MessageBox.Show("You should select a Class to map Subject");
            }
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
            StudentMarkMgtScreenForm studentMarkMgtScreenForm = new StudentMarkMgtScreenForm();

            studentMarkMgtScreenForm.Show();
        }
    }
}