﻿
namespace E_PupilStdMgt.forms.screens
{
    partial class StudentMgtScreenForm
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
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.ID_STUDENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_REG_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_MOBILE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERMANENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createNewStudentButton = new System.Windows.Forms.Button();
            this.studentCreatePanel = new System.Windows.Forms.Panel();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.permentAddressInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stdEmailInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genderPicker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stdRegNoInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stdMobileNoInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewStudentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.studentCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.studentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_STUDENT,
            this.STUDENT_REG_NO,
            this.STUDENT_NAME,
            this.STUDENT_EMAIL,
            this.STUDENT_MOBILE_NO,
            this.PERMANENT_ADDRESS,
            this.GENDER});
            this.studentDataGrid.Location = new System.Drawing.Point(29, 164);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersWidth = 51;
            this.studentDataGrid.RowTemplate.Height = 29;
            this.studentDataGrid.Size = new System.Drawing.Size(847, 262);
            this.studentDataGrid.TabIndex = 0;
            // 
            // ID_STUDENT
            // 
            this.ID_STUDENT.HeaderText = "Student Id";
            this.ID_STUDENT.MinimumWidth = 6;
            this.ID_STUDENT.Name = "ID_STUDENT";
            this.ID_STUDENT.ReadOnly = true;
            this.ID_STUDENT.Width = 125;
            // 
            // STUDENT_REG_NO
            // 
            this.STUDENT_REG_NO.HeaderText = "Student Reg No";
            this.STUDENT_REG_NO.MinimumWidth = 6;
            this.STUDENT_REG_NO.Name = "STUDENT_REG_NO";
            this.STUDENT_REG_NO.ReadOnly = true;
            this.STUDENT_REG_NO.Width = 250;
            // 
            // STUDENT_NAME
            // 
            this.STUDENT_NAME.HeaderText = "Student Name";
            this.STUDENT_NAME.MinimumWidth = 6;
            this.STUDENT_NAME.Name = "STUDENT_NAME";
            this.STUDENT_NAME.ReadOnly = true;
            this.STUDENT_NAME.Width = 250;
            // 
            // STUDENT_EMAIL
            // 
            this.STUDENT_EMAIL.HeaderText = "Student Email";
            this.STUDENT_EMAIL.MinimumWidth = 6;
            this.STUDENT_EMAIL.Name = "STUDENT_EMAIL";
            this.STUDENT_EMAIL.ReadOnly = true;
            this.STUDENT_EMAIL.Width = 250;
            // 
            // STUDENT_MOBILE_NO
            // 
            this.STUDENT_MOBILE_NO.HeaderText = "Student Mobile No";
            this.STUDENT_MOBILE_NO.MinimumWidth = 6;
            this.STUDENT_MOBILE_NO.Name = "STUDENT_MOBILE_NO";
            this.STUDENT_MOBILE_NO.ReadOnly = true;
            this.STUDENT_MOBILE_NO.Width = 200;
            // 
            // PERMANENT_ADDRESS
            // 
            this.PERMANENT_ADDRESS.HeaderText = "Premanent Address";
            this.PERMANENT_ADDRESS.MinimumWidth = 6;
            this.PERMANENT_ADDRESS.Name = "PERMANENT_ADDRESS";
            this.PERMANENT_ADDRESS.ReadOnly = true;
            this.PERMANENT_ADDRESS.Width = 250;
            // 
            // GENDER
            // 
            this.GENDER.HeaderText = "Gender";
            this.GENDER.MinimumWidth = 6;
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            this.GENDER.Width = 125;
            // 
            // createNewStudentButton
            // 
            this.createNewStudentButton.AutoSize = true;
            this.createNewStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.createNewStudentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.createNewStudentButton.FlatAppearance.BorderSize = 0;
            this.createNewStudentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewStudentButton.ForeColor = System.Drawing.SystemColors.Info;
            this.createNewStudentButton.Location = new System.Drawing.Point(684, 53);
            this.createNewStudentButton.Name = "createNewStudentButton";
            this.createNewStudentButton.Size = new System.Drawing.Size(192, 53);
            this.createNewStudentButton.TabIndex = 10;
            this.createNewStudentButton.Text = "Create New Student";
            this.createNewStudentButton.UseVisualStyleBackColor = false;
            this.createNewStudentButton.Click += new System.EventHandler(this.createNewStudentButton_Click);
            // 
            // studentCreatePanel
            // 
            this.studentCreatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentCreatePanel.Controls.Add(this.closePanelButton);
            this.studentCreatePanel.Controls.Add(this.createPanelButton);
            this.studentCreatePanel.Controls.Add(this.permentAddressInput);
            this.studentCreatePanel.Controls.Add(this.label6);
            this.studentCreatePanel.Controls.Add(this.stdEmailInput);
            this.studentCreatePanel.Controls.Add(this.label5);
            this.studentCreatePanel.Controls.Add(this.genderPicker);
            this.studentCreatePanel.Controls.Add(this.label4);
            this.studentCreatePanel.Controls.Add(this.stdRegNoInput);
            this.studentCreatePanel.Controls.Add(this.label3);
            this.studentCreatePanel.Controls.Add(this.stdMobileNoInput);
            this.studentCreatePanel.Controls.Add(this.label1);
            this.studentCreatePanel.Controls.Add(this.stdNameInput);
            this.studentCreatePanel.Controls.Add(this.label2);
            this.studentCreatePanel.Controls.Add(this.createNewStudentLabel);
            this.studentCreatePanel.Location = new System.Drawing.Point(40, 29);
            this.studentCreatePanel.Name = "studentCreatePanel";
            this.studentCreatePanel.Size = new System.Drawing.Size(819, 485);
            this.studentCreatePanel.TabIndex = 11;
            this.studentCreatePanel.Visible = false;
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
            this.closePanelButton.Location = new System.Drawing.Point(619, 391);
            this.closePanelButton.Name = "closePanelButton";
            this.closePanelButton.Size = new System.Drawing.Size(149, 53);
            this.closePanelButton.TabIndex = 29;
            this.closePanelButton.Text = "Cancel";
            this.closePanelButton.UseVisualStyleBackColor = false;
            this.closePanelButton.Click += new System.EventHandler(this.closePanelButton_Click);
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
            this.createPanelButton.Location = new System.Drawing.Point(453, 391);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(149, 53);
            this.createPanelButton.TabIndex = 28;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            this.createPanelButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // permentAddressInput
            // 
            this.permentAddressInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.permentAddressInput.Location = new System.Drawing.Point(207, 285);
            this.permentAddressInput.Multiline = true;
            this.permentAddressInput.Name = "permentAddressInput";
            this.permentAddressInput.Size = new System.Drawing.Size(561, 69);
            this.permentAddressInput.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Permanent Address";
            // 
            // stdEmailInput
            // 
            this.stdEmailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdEmailInput.Location = new System.Drawing.Point(207, 232);
            this.stdEmailInput.Name = "stdEmailInput";
            this.stdEmailInput.Size = new System.Drawing.Size(561, 27);
            this.stdEmailInput.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Student Email";
            // 
            // genderPicker
            // 
            this.genderPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderPicker.FormattingEnabled = true;
            this.genderPicker.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderPicker.Location = new System.Drawing.Point(550, 177);
            this.genderPicker.Name = "genderPicker";
            this.genderPicker.Size = new System.Drawing.Size(218, 28);
            this.genderPicker.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(408, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Student Gender";
            // 
            // stdRegNoInput
            // 
            this.stdRegNoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdRegNoInput.Location = new System.Drawing.Point(615, 57);
            this.stdRegNoInput.Name = "stdRegNoInput";
            this.stdRegNoInput.Size = new System.Drawing.Size(153, 27);
            this.stdRegNoInput.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Student Reg No";
            // 
            // stdMobileNoInput
            // 
            this.stdMobileNoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdMobileNoInput.Location = new System.Drawing.Point(207, 178);
            this.stdMobileNoInput.Name = "stdMobileNoInput";
            this.stdMobileNoInput.Size = new System.Drawing.Size(171, 27);
            this.stdMobileNoInput.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student Mobile No";
            // 
            // stdNameInput
            // 
            this.stdNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stdNameInput.Location = new System.Drawing.Point(207, 125);
            this.stdNameInput.Name = "stdNameInput";
            this.stdNameInput.Size = new System.Drawing.Size(561, 27);
            this.stdNameInput.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Name";
            // 
            // createNewStudentLabel
            // 
            this.createNewStudentLabel.AutoSize = true;
            this.createNewStudentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewStudentLabel.ForeColor = System.Drawing.Color.White;
            this.createNewStudentLabel.Location = new System.Drawing.Point(14, 15);
            this.createNewStudentLabel.Name = "createNewStudentLabel";
            this.createNewStudentLabel.Size = new System.Drawing.Size(149, 20);
            this.createNewStudentLabel.TabIndex = 14;
            this.createNewStudentLabel.Text = "Create New Student";
            // 
            // StudentMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(898, 564);
            this.Controls.Add(this.studentCreatePanel);
            this.Controls.Add(this.createNewStudentButton);
            this.Controls.Add(this.studentDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMgtScreenForm";
            this.Text = "StudentMgtScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.studentCreatePanel.ResumeLayout(false);
            this.studentCreatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button createNewStudentButton;
        private System.Windows.Forms.Panel studentCreatePanel;
        private System.Windows.Forms.Label createNewStudentLabel;
        private System.Windows.Forms.TextBox stdMobileNoInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stdRegNoInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox permentAddressInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stdEmailInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_STUDENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_REG_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_MOBILE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERMANENT_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
    }
}