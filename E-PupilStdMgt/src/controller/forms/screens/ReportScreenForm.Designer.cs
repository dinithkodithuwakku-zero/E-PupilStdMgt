
namespace E_PupilStdMgt.src.controller.forms.screens
{
    partial class ReportScreenForm
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
            this.classStudentListReportButton = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentMarkListReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classStudentListReportButton
            // 
            this.classStudentListReportButton.AutoSize = true;
            this.classStudentListReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.classStudentListReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classStudentListReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.classStudentListReportButton.FlatAppearance.BorderSize = 0;
            this.classStudentListReportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classStudentListReportButton.ForeColor = System.Drawing.SystemColors.Info;
            this.classStudentListReportButton.Location = new System.Drawing.Point(109, 60);
            this.classStudentListReportButton.Name = "classStudentListReportButton";
            this.classStudentListReportButton.Size = new System.Drawing.Size(246, 43);
            this.classStudentListReportButton.TabIndex = 38;
            this.classStudentListReportButton.Text = "Class Student List Report";
            this.classStudentListReportButton.UseVisualStyleBackColor = false;
            this.classStudentListReportButton.Click += new System.EventHandler(this.classStudentListReportButton_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "ReportViewer";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 0;
            // 
            // studentMarkListReportButton
            // 
            this.studentMarkListReportButton.AutoSize = true;
            this.studentMarkListReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.studentMarkListReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentMarkListReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.studentMarkListReportButton.FlatAppearance.BorderSize = 0;
            this.studentMarkListReportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentMarkListReportButton.ForeColor = System.Drawing.SystemColors.Info;
            this.studentMarkListReportButton.Location = new System.Drawing.Point(109, 161);
            this.studentMarkListReportButton.Name = "studentMarkListReportButton";
            this.studentMarkListReportButton.Size = new System.Drawing.Size(246, 43);
            this.studentMarkListReportButton.TabIndex = 39;
            this.studentMarkListReportButton.Text = "Student Marks List Report";
            this.studentMarkListReportButton.UseVisualStyleBackColor = false;
            this.studentMarkListReportButton.Click += new System.EventHandler(this.studentMarkListReportButton_Click);
            // 
            // ReportScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.studentMarkListReportButton);
            this.Controls.Add(this.classStudentListReportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportScreenForm";
            this.Text = "Report window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button classStudentListReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button studentMarkListReportButton;
    }
}