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

        public StuffDashboardForm()
        {
            InitializeComponent();

            AddSubjectsToPanel();
            AddClassesToPanel();
        }


        private void AddClassesToPanel()
        {
            this.classListPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            for (int i = 0; i < 5; i++)
            {
                Label label = new Label();

                label.Name = i.ToString();
                label.Text = "Class new " + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                // label.Anchor = AnchorStyles.Left;
                // label.Anchor = AnchorStyles.Right;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Width = this.classListPanel.Width;
                label.Top = i * 60;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;
                label.Click += new EventHandler(this.ClassLabelClicked);

                classListPanel.Controls.Add(label);
            }
        }

        void ClassLabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            MessageBox.Show(label.Name);
        }

        private void AddSubjectsToPanel()
        {
            this.subjectListPanel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);

            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();

                label.Text = "Subject" + i;
                label.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                label.ForeColor = Color.White;
                // label.Anchor = AnchorStyles.Left;
                // label.Anchor = AnchorStyles.Right;
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Width = this.subjectListPanel.Width;
                label.Top = i * 60;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
                label.Cursor = Cursors.Hand;

                subjectListPanel.Controls.Add(label);
            }
        }

        private void StuffDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private Point p1, p2;
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (p1.X == 0)
            {
                p1.X = e.X;
                p1.Y = e.Y;
            }
            else
            {
                p2.X = e.X;
                p2.Y = e.Y;

                p1List.Add(p1);
                p2List.Add(p2);

                parentPanel.Invalidate();
                p1.X = 0;
            }
        }

        private void parentPanel_Paint(object sender, PaintEventArgs e)
        {
            using (var p = new Pen(Color.Blue, 4))
            {
                for (int x = 0; x < p1List.Count; x++)
                {
                    e.Graphics.DrawLine(p, p1List[x], p2List[x]);
                }
            }
        }
    }
}
