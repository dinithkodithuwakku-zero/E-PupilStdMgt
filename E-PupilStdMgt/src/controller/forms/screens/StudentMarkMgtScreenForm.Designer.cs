
namespace E_PupilStdMgt.src.controller.forms.screens
{
    partial class StudentMarkMgtScreenForm
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
            this.classNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobTitlePicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // classNameInput
            // 
            this.classNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classNameInput.Location = new System.Drawing.Point(193, 181);
            this.classNameInput.Name = "classNameInput";
            this.classNameInput.Size = new System.Drawing.Size(206, 27);
            this.classNameInput.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Point";
            // 
            // jobTitlePicker
            // 
            this.jobTitlePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitlePicker.FormattingEnabled = true;
            this.jobTitlePicker.Items.AddRange(new object[] {
            "Reception",
            "Teacher"});
            this.jobTitlePicker.Location = new System.Drawing.Point(193, 109);
            this.jobTitlePicker.Name = "jobTitlePicker";
            this.jobTitlePicker.Size = new System.Drawing.Size(206, 28);
            this.jobTitlePicker.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(571, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Exam Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(693, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 27);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reception",
            "Teacher"});
            this.comboBox1.Location = new System.Drawing.Point(648, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 28);
            this.comboBox1.TabIndex = 35;
            // 
            // closePanelButton
            // 
            this.closePanelButton.AutoSize = true;
            this.closePanelButton.BackColor = System.Drawing.Color.IndianRed;
            this.closePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.closePanelButton.FlatAppearance.BorderSize = 0;
            this.closePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.closePanelButton.Location = new System.Drawing.Point(732, 229);
            this.closePanelButton.Name = "closePanelButton";
            this.closePanelButton.Size = new System.Drawing.Size(122, 43);
            this.closePanelButton.TabIndex = 38;
            this.closePanelButton.Text = "Cancel";
            this.closePanelButton.UseVisualStyleBackColor = false;
            // 
            // createPanelButton
            // 
            this.createPanelButton.AutoSize = true;
            this.createPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.createPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.createPanelButton.FlatAppearance.BorderSize = 0;
            this.createPanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.createPanelButton.Location = new System.Drawing.Point(571, 229);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(122, 43);
            this.createPanelButton.TabIndex = 37;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentRegNo,
            this.studentName,
            this.subjectCode,
            this.subjectName,
            this.examDate,
            this.studentPoint});
            this.dataGridView1.Location = new System.Drawing.Point(35, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(818, 189);
            this.dataGridView1.TabIndex = 39;
            // 
            // studentRegNo
            // 
            this.studentRegNo.HeaderText = "Student Reg No";
            this.studentRegNo.MinimumWidth = 6;
            this.studentRegNo.Name = "studentRegNo";
            this.studentRegNo.ReadOnly = true;
            this.studentRegNo.Width = 125;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 200;
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "Subject Code";
            this.subjectCode.MinimumWidth = 6;
            this.subjectCode.Name = "subjectCode";
            this.subjectCode.ReadOnly = true;
            this.subjectCode.Width = 125;
            // 
            // subjectName
            // 
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 200;
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
            // StudentMarkMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(883, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closePanelButton);
            this.Controls.Add(this.createPanelButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobTitlePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classNameInput);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StudentMarkMgtScreenForm";
            this.Text = "Student Marks Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobTitlePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPoint;
    }
}