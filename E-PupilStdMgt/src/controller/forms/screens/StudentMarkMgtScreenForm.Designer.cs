
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentPointInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.examDatePicker = new System.Windows.Forms.DateTimePicker();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.classSubjectStudentMarkDataGrid = new System.Windows.Forms.DataGridView();
            this.ID_CLASS_SUBJECT_STUDENT_MARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailLable = new System.Windows.Forms.Label();
            this.subjectPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.subjectUpdateInput = new System.Windows.Forms.TextBox();
            this.classUpdateInput = new System.Windows.Forms.TextBox();
            this.studentDetailUpdatePanelLable = new System.Windows.Forms.Label();
            this.deleteUpdatePanelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelUpdateButton = new System.Windows.Forms.Button();
            this.updatePanelButton = new System.Windows.Forms.Button();
            this.updateExamDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateStudentPointInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectStudentMarkDataGrid)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentPointInput
            // 
            this.studentPointInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentPointInput.Location = new System.Drawing.Point(193, 181);
            this.studentPointInput.Name = "studentPointInput";
            this.studentPointInput.Size = new System.Drawing.Size(196, 27);
            this.studentPointInput.TabIndex = 17;
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
            // classPicker
            // 
            this.classPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classPicker.FormattingEnabled = true;
            this.classPicker.Location = new System.Drawing.Point(193, 109);
            this.classPicker.Name = "classPicker";
            this.classPicker.Size = new System.Drawing.Size(196, 28);
            this.classPicker.TabIndex = 30;
            this.classPicker.SelectedValueChanged += new System.EventHandler(this.classPicker_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Exam Date";
            // 
            // examDatePicker
            // 
            this.examDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.examDatePicker.Location = new System.Drawing.Point(628, 38);
            this.examDatePicker.Name = "examDatePicker";
            this.examDatePicker.Size = new System.Drawing.Size(161, 27);
            this.examDatePicker.TabIndex = 34;
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
            this.closePanelButton.Location = new System.Drawing.Point(667, 260);
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
            this.createPanelButton.Location = new System.Drawing.Point(506, 260);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(122, 43);
            this.createPanelButton.TabIndex = 37;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            this.createPanelButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // classSubjectStudentMarkDataGrid
            // 
            this.classSubjectStudentMarkDataGrid.AllowUserToAddRows = false;
            this.classSubjectStudentMarkDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classSubjectStudentMarkDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.classSubjectStudentMarkDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classSubjectStudentMarkDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLASS_SUBJECT_STUDENT_MARK,
            this.classCode,
            this.className,
            this.subjectCode,
            this.subjectName,
            this.studentName,
            this.examDate,
            this.studentPoint});
            this.classSubjectStudentMarkDataGrid.Location = new System.Drawing.Point(35, 333);
            this.classSubjectStudentMarkDataGrid.Name = "classSubjectStudentMarkDataGrid";
            this.classSubjectStudentMarkDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classSubjectStudentMarkDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classSubjectStudentMarkDataGrid.RowHeadersWidth = 51;
            this.classSubjectStudentMarkDataGrid.RowTemplate.Height = 29;
            this.classSubjectStudentMarkDataGrid.Size = new System.Drawing.Size(754, 248);
            this.classSubjectStudentMarkDataGrid.TabIndex = 39;
            this.classSubjectStudentMarkDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classSubjectStudentMarkDataGrid_CellClick);
            // 
            // ID_CLASS_SUBJECT_STUDENT_MARK
            // 
            this.ID_CLASS_SUBJECT_STUDENT_MARK.HeaderText = "Student Mark Id";
            this.ID_CLASS_SUBJECT_STUDENT_MARK.MinimumWidth = 6;
            this.ID_CLASS_SUBJECT_STUDENT_MARK.Name = "ID_CLASS_SUBJECT_STUDENT_MARK";
            this.ID_CLASS_SUBJECT_STUDENT_MARK.ReadOnly = true;
            this.ID_CLASS_SUBJECT_STUDENT_MARK.Width = 125;
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
            // studentDetailLable
            // 
            this.studentDetailLable.AutoSize = true;
            this.studentDetailLable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentDetailLable.ForeColor = System.Drawing.Color.White;
            this.studentDetailLable.Location = new System.Drawing.Point(35, 38);
            this.studentDetailLable.Name = "studentDetailLable";
            this.studentDetailLable.Size = new System.Drawing.Size(256, 25);
            this.studentDetailLable.TabIndex = 40;
            this.studentDetailLable.Text = "Student Name - Reg no 0002";
            // 
            // subjectPicker
            // 
            this.subjectPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectPicker.FormattingEnabled = true;
            this.subjectPicker.Location = new System.Drawing.Point(628, 106);
            this.subjectPicker.Name = "subjectPicker";
            this.subjectPicker.Size = new System.Drawing.Size(161, 28);
            this.subjectPicker.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Select Subject";
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePanel.Controls.Add(this.subjectUpdateInput);
            this.updatePanel.Controls.Add(this.classUpdateInput);
            this.updatePanel.Controls.Add(this.studentDetailUpdatePanelLable);
            this.updatePanel.Controls.Add(this.deleteUpdatePanelButton);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.cancelUpdateButton);
            this.updatePanel.Controls.Add(this.updatePanelButton);
            this.updatePanel.Controls.Add(this.updateExamDatePicker);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.label8);
            this.updatePanel.Controls.Add(this.updateStudentPointInput);
            this.updatePanel.Controls.Add(this.label9);
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Location = new System.Drawing.Point(12, 84);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(791, 385);
            this.updatePanel.TabIndex = 43;
            this.updatePanel.Visible = false;
            // 
            // subjectUpdateInput
            // 
            this.subjectUpdateInput.Enabled = false;
            this.subjectUpdateInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectUpdateInput.Location = new System.Drawing.Point(567, 154);
            this.subjectUpdateInput.Name = "subjectUpdateInput";
            this.subjectUpdateInput.Size = new System.Drawing.Size(196, 27);
            this.subjectUpdateInput.TabIndex = 56;
            // 
            // classUpdateInput
            // 
            this.classUpdateInput.Enabled = false;
            this.classUpdateInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classUpdateInput.Location = new System.Drawing.Point(195, 154);
            this.classUpdateInput.Name = "classUpdateInput";
            this.classUpdateInput.Size = new System.Drawing.Size(196, 27);
            this.classUpdateInput.TabIndex = 55;
            // 
            // studentDetailUpdatePanelLable
            // 
            this.studentDetailUpdatePanelLable.AutoSize = true;
            this.studentDetailUpdatePanelLable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentDetailUpdatePanelLable.ForeColor = System.Drawing.Color.White;
            this.studentDetailUpdatePanelLable.Location = new System.Drawing.Point(273, 22);
            this.studentDetailUpdatePanelLable.Name = "studentDetailUpdatePanelLable";
            this.studentDetailUpdatePanelLable.Size = new System.Drawing.Size(256, 25);
            this.studentDetailUpdatePanelLable.TabIndex = 54;
            this.studentDetailUpdatePanelLable.Text = "Student Name - Reg no 0002";
            // 
            // deleteUpdatePanelButton
            // 
            this.deleteUpdatePanelButton.AutoSize = true;
            this.deleteUpdatePanelButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteUpdatePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUpdatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.deleteUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.deleteUpdatePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUpdatePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteUpdatePanelButton.Location = new System.Drawing.Point(503, 317);
            this.deleteUpdatePanelButton.Name = "deleteUpdatePanelButton";
            this.deleteUpdatePanelButton.Size = new System.Drawing.Size(122, 43);
            this.deleteUpdatePanelButton.TabIndex = 53;
            this.deleteUpdatePanelButton.Text = "Delete";
            this.deleteUpdatePanelButton.UseVisualStyleBackColor = false;
            this.deleteUpdatePanelButton.Click += new System.EventHandler(this.deleteUpdatePanelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(459, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Subject";
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.AutoSize = true;
            this.cancelUpdateButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cancelUpdateButton.FlatAppearance.BorderSize = 0;
            this.cancelUpdateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelUpdateButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelUpdateButton.Location = new System.Drawing.Point(641, 317);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(122, 43);
            this.cancelUpdateButton.TabIndex = 50;
            this.cancelUpdateButton.Text = "Cancel";
            this.cancelUpdateButton.UseVisualStyleBackColor = false;
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // updatePanelButton
            // 
            this.updatePanelButton.AutoSize = true;
            this.updatePanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.updatePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.updatePanelButton.FlatAppearance.BorderSize = 0;
            this.updatePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.updatePanelButton.Location = new System.Drawing.Point(363, 317);
            this.updatePanelButton.Name = "updatePanelButton";
            this.updatePanelButton.Size = new System.Drawing.Size(122, 43);
            this.updatePanelButton.TabIndex = 49;
            this.updatePanelButton.Text = "Update";
            this.updatePanelButton.UseVisualStyleBackColor = false;
            this.updatePanelButton.Click += new System.EventHandler(this.updatePanelButton_Click);
            // 
            // updateExamDatePicker
            // 
            this.updateExamDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateExamDatePicker.Location = new System.Drawing.Point(602, 86);
            this.updateExamDatePicker.Name = "updateExamDatePicker";
            this.updateExamDatePicker.Size = new System.Drawing.Size(161, 27);
            this.updateExamDatePicker.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(480, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Exam Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Class";
            // 
            // updateStudentPointInput
            // 
            this.updateStudentPointInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateStudentPointInput.Location = new System.Drawing.Point(195, 226);
            this.updateStudentPointInput.Name = "updateStudentPointInput";
            this.updateStudentPointInput.Size = new System.Drawing.Size(196, 27);
            this.updateStudentPointInput.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Student Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update Student Mark";
            // 
            // StudentMarkMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(840, 611);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.subjectPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDetailLable);
            this.Controls.Add(this.classSubjectStudentMarkDataGrid);
            this.Controls.Add(this.closePanelButton);
            this.Controls.Add(this.createPanelButton);
            this.Controls.Add(this.examDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentPointInput);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StudentMarkMgtScreenForm";
            this.Text = "Student Marks Management";
            ((System.ComponentModel.ISupportInitialize)(this.classSubjectStudentMarkDataGrid)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentPointInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox classPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker examDatePicker;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.DataGridView classSubjectStudentMarkDataGrid;
        private System.Windows.Forms.Label studentDetailLable;
        private System.Windows.Forms.ComboBox subjectPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLASS_SUBJECT_STUDENT_MARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPoint;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label studentDetailUpdatePanelLable;
        private System.Windows.Forms.Button deleteUpdatePanelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelUpdateButton;
        private System.Windows.Forms.Button updatePanelButton;
        private System.Windows.Forms.DateTimePicker updateExamDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateStudentPointInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectUpdateInput;
        private System.Windows.Forms.TextBox classUpdateInput;
    }
}