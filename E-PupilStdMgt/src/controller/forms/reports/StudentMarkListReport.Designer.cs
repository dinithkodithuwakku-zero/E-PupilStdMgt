
namespace E_PupilStdMgt.src.controller.forms.reports
{
    partial class StudentMarkListReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subjectPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classSubjectStudentMarkDataGrid = new System.Windows.Forms.DataGridView();
            this.classCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectStudentMarkDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectPicker
            // 
            this.subjectPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectPicker.FormattingEnabled = true;
            this.subjectPicker.Location = new System.Drawing.Point(616, 56);
            this.subjectPicker.Name = "subjectPicker";
            this.subjectPicker.Size = new System.Drawing.Size(161, 28);
            this.subjectPicker.TabIndex = 46;
            this.subjectPicker.SelectedValueChanged += new System.EventHandler(this.subjectPicker_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(473, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Select Subject";
            // 
            // classPicker
            // 
            this.classPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classPicker.FormattingEnabled = true;
            this.classPicker.Location = new System.Drawing.Point(181, 59);
            this.classPicker.Name = "classPicker";
            this.classPicker.Size = new System.Drawing.Size(196, 28);
            this.classPicker.TabIndex = 44;
            this.classPicker.SelectedValueChanged += new System.EventHandler(this.classPicker_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Select Class";
            // 
            // classSubjectStudentMarkDataGrid
            // 
            this.classSubjectStudentMarkDataGrid.AllowUserToAddRows = false;
            this.classSubjectStudentMarkDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classSubjectStudentMarkDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classSubjectStudentMarkDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classSubjectStudentMarkDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classCode,
            this.className,
            this.subjectCode,
            this.subjectName,
            this.studentName,
            this.examDate,
            this.studentPoint});
            this.classSubjectStudentMarkDataGrid.Location = new System.Drawing.Point(23, 224);
            this.classSubjectStudentMarkDataGrid.Name = "classSubjectStudentMarkDataGrid";
            this.classSubjectStudentMarkDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classSubjectStudentMarkDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classSubjectStudentMarkDataGrid.RowHeadersWidth = 51;
            this.classSubjectStudentMarkDataGrid.RowTemplate.Height = 29;
            this.classSubjectStudentMarkDataGrid.Size = new System.Drawing.Size(754, 248);
            this.classSubjectStudentMarkDataGrid.TabIndex = 47;
            // 
            // classCode
            // 
            this.classCode.HeaderText = "Class Code";
            this.classCode.MinimumWidth = 6;
            this.classCode.Name = "classCode";
            this.classCode.ReadOnly = true;
            this.classCode.Width = 125;
            // 
            // className
            // 
            this.className.HeaderText = "Class Name";
            this.className.MinimumWidth = 6;
            this.className.Name = "className";
            this.className.ReadOnly = true;
            this.className.Width = 125;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.MinimumWidth = 6;
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.ReadOnly = true;
            this.subjectCode.Width = 200;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 250;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 125;
            // 
            // examDate
            // 
            this.examDate.HeaderText = "Exam Date";
            this.examDate.MinimumWidth = 6;
            this.examDate.Name = "examDate";
            this.examDate.ReadOnly = true;
            this.examDate.Width = 125;
            // 
            // studentPoint
            // 
            this.studentPoint.HeaderText = "Student Point";
            this.studentPoint.MinimumWidth = 6;
            this.studentPoint.Name = "studentPoint";
            this.studentPoint.ReadOnly = true;
            this.studentPoint.Width = 125;
            // 
            // printReportButton
            // 
            this.printReportButton.AutoSize = true;
            this.printReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.printReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printReportButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.printReportButton.FlatAppearance.BorderSize = 0;
            this.printReportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printReportButton.ForeColor = System.Drawing.SystemColors.Info;
            this.printReportButton.Location = new System.Drawing.Point(539, 122);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(238, 43);
            this.printReportButton.TabIndex = 48;
            this.printReportButton.Text = "Generate PDF Report";
            this.printReportButton.UseVisualStyleBackColor = false;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // StudentMarkListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(818, 524);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.classSubjectStudentMarkDataGrid);
            this.Controls.Add(this.subjectPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classPicker);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentMarkListReport";
            this.Text = "Student Marks List Report";
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectStudentMarkDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView classSubjectStudentMarkDataGrid;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPoint;
    }
}