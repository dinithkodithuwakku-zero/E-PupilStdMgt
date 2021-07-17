
namespace E_PupilStdMgt.src.controller.forms.reports
{
    partial class ClassStudentListReportView
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
            this.printReportButton = new System.Windows.Forms.Button();
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.STUDENT_REG_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STUDENT_MOBILE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERMANENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.printReportButton.Location = new System.Drawing.Point(637, 94);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(238, 43);
            this.printReportButton.TabIndex = 41;
            this.printReportButton.Text = "Generate CSV Report";
            this.printReportButton.UseVisualStyleBackColor = false;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // classPicker
            // 
            this.classPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classPicker.FormattingEnabled = true;
            this.classPicker.Location = new System.Drawing.Point(186, 55);
            this.classPicker.Name = "classPicker";
            this.classPicker.Size = new System.Drawing.Size(196, 28);
            this.classPicker.TabIndex = 40;
            this.classPicker.SelectedValueChanged += new System.EventHandler(this.classPicker_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Select Class";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.studentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STUDENT_REG_NO,
            this.STUDENT_NAME,
            this.STUDENT_EMAIL,
            this.STUDENT_MOBILE_NO,
            this.PERMANENT_ADDRESS,
            this.GENDER});
            this.studentDataGrid.Location = new System.Drawing.Point(28, 178);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersWidth = 51;
            this.studentDataGrid.RowTemplate.Height = 29;
            this.studentDataGrid.Size = new System.Drawing.Size(847, 302);
            this.studentDataGrid.TabIndex = 42;
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
            // ClassStudentListReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(913, 541);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.classPicker);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClassStudentListReportView";
            this.Text = "Class Student List Report";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.ComboBox classPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_REG_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STUDENT_MOBILE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERMANENT_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
    }
}