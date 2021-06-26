using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace E_PupilStdMgt.src.controller.forms
{
    public partial class StuffDashboardForm : Form
    {
        private Point p1, p2;
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();

        Dictionary<string,Label> lClassDict = new Dictionary<string, Label>();
        Dictionary<string, Label> lSubjectDict = new Dictionary<string, Label>();

        private string subjectCodePoint, classCodePoint;
        List<string> subjectCodePointList = new List<string>();
        List<string> classCodePointList = new List<string>();

        public StuffDashboardForm()
        {
            InitializeComponent();

            AddSubjectsToPanel();
            AddClassesToPanel();
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
                // label.Anchor = AnchorStyles.Left;
                // label.Anchor = AnchorStyles.Right;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Top = i * 60;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(this.ClassLabelClicked);

                label.Left = this.parentPanel.Width / 2;

                lClassDict[label.Name] = label;

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
                this.subjectCodePoint = null;
                this.classCodePoint = null;
                parentPanel.Invalidate();
            }
        }


        private void AddSubjectsToPanel()
        {

            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();

                label.Name = "scode " + i;
                label.Text = "Subject " + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                // label.Anchor = AnchorStyles.Left;
                // label.Anchor = AnchorStyles.Right;
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

        void SubjectLabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;

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
                this.subjectCodePoint = null;
                this.classCodePoint = null;
                parentPanel.Invalidate();
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

            using (var p = new Pen(Color.Blue, 4))
            {
                for (int i = 0; i < classCodePointList.Count; i++)
                {
                    var classLabel = lClassDict[classCodePointList[i]];
                    var subjectLabel = lSubjectDict[subjectCodePointList[i]];

                    //subjectLabel.Location.X = subjectLabel.Location.X - subjectLabel.Size.Width;
                    Point sbPoint = subjectLabel.Location;
                    sbPoint.X = subjectLabel.Location.X + subjectLabel.Size.Width;
                    sbPoint.Y = subjectLabel.Location.Y + (subjectLabel.Size.Height/2);


                    e.Graphics.DrawLine(p, classLabel.Location, sbPoint);
                }
            }
        }
    }
}
