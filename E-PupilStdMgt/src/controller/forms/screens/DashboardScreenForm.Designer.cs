
namespace E_PupilStdMgt.forms.screens
{
    partial class DashboardScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.noOfClassesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noOfSubjectsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentGPAChart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.noOfStudentsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.noOfStuffUsersLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.noOfClassesLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 164);
            this.panel1.TabIndex = 0;
            // 
            // noOfClassesLabel
            // 
            this.noOfClassesLabel.AutoSize = true;
            this.noOfClassesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfClassesLabel.Location = new System.Drawing.Point(83, 85);
            this.noOfClassesLabel.Name = "noOfClassesLabel";
            this.noOfClassesLabel.Size = new System.Drawing.Size(52, 41);
            this.noOfClassesLabel.TabIndex = 1;
            this.noOfClassesLabel.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Classes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.noOfSubjectsLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(320, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 164);
            this.panel2.TabIndex = 1;
            // 
            // noOfSubjectsLabel
            // 
            this.noOfSubjectsLabel.AutoSize = true;
            this.noOfSubjectsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfSubjectsLabel.Location = new System.Drawing.Point(88, 85);
            this.noOfSubjectsLabel.Name = "noOfSubjectsLabel";
            this.noOfSubjectsLabel.Size = new System.Drawing.Size(52, 41);
            this.noOfSubjectsLabel.TabIndex = 1;
            this.noOfSubjectsLabel.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Subjects";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.studentGPAChart);
            this.panel3.Controls.Add(this.noOfStudentsLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(16, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 344);
            this.panel3.TabIndex = 2;
            // 
            // studentGPAChart
            // 
            this.studentGPAChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.studentGPAChart.ChartArea.CursorReDraw = false;
            this.studentGPAChart.IsWindowLess = false;
            // 
            // 
            // 
            this.studentGPAChart.Legend.Location = new System.Drawing.Point(697, 81);
            this.studentGPAChart.Localize = null;
            this.studentGPAChart.Location = new System.Drawing.Point(29, 61);
            this.studentGPAChart.Name = "studentGPAChart";
            this.studentGPAChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.studentGPAChart.PrimaryXAxis.Margin = true;
            this.studentGPAChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.studentGPAChart.PrimaryYAxis.Margin = true;
            this.studentGPAChart.Size = new System.Drawing.Size(818, 264);
            this.studentGPAChart.TabIndex = 2;
            this.studentGPAChart.Text = "Student GPA";
            // 
            // 
            // 
            this.studentGPAChart.Title.Name = "Default";
            this.studentGPAChart.Titles.Add(this.studentGPAChart.Title);
            this.studentGPAChart.VisualTheme = "";
            // 
            // noOfStudentsLabel
            // 
            this.noOfStudentsLabel.AutoSize = true;
            this.noOfStudentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfStudentsLabel.Location = new System.Drawing.Point(230, 17);
            this.noOfStudentsLabel.Name = "noOfStudentsLabel";
            this.noOfStudentsLabel.Size = new System.Drawing.Size(52, 41);
            this.noOfStudentsLabel.TabIndex = 1;
            this.noOfStudentsLabel.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number of Students";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.noOfStuffUsersLabel);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(629, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 164);
            this.panel4.TabIndex = 3;
            // 
            // noOfStuffUsersLabel
            // 
            this.noOfStuffUsersLabel.AutoSize = true;
            this.noOfStuffUsersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfStuffUsersLabel.Location = new System.Drawing.Point(92, 85);
            this.noOfStuffUsersLabel.Name = "noOfStuffUsersLabel";
            this.noOfStuffUsersLabel.Size = new System.Drawing.Size(52, 41);
            this.noOfStuffUsersLabel.TabIndex = 1;
            this.noOfStuffUsersLabel.Text = "15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number of Stuff Users";
            // 
            // DashboardScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardScreenForm";
            this.Text = "DashboardScreenForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noOfClassesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label noOfSubjectsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label noOfStudentsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label noOfStuffUsersLabel;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Chart.ChartControl studentGPAChart;
    }
}