
namespace E_PupilStdMgt.src.controller.forms.reports
{
    partial class ClassMappingReport
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
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printReportButton = new System.Windows.Forms.Button();
            this.subjectDataGrid = new System.Windows.Forms.DataGridView();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.studentRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // classPicker
            // 
            this.classPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classPicker.FormattingEnabled = true;
            this.classPicker.Location = new System.Drawing.Point(184, 52);
            this.classPicker.Name = "classPicker";
            this.classPicker.Size = new System.Drawing.Size(196, 28);
            this.classPicker.TabIndex = 46;
            this.classPicker.SelectedValueChanged += new System.EventHandler(this.classPicker_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Select Class";
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
            this.printReportButton.Location = new System.Drawing.Point(342, 112);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(238, 43);
            this.printReportButton.TabIndex = 49;
            this.printReportButton.Text = "Generate PDF Report";
            this.printReportButton.UseVisualStyleBackColor = false;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // subjectDataGrid
            // 
            this.subjectDataGrid.AllowUserToAddRows = false;
            this.subjectDataGrid.AllowUserToDeleteRows = false;
            this.subjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectCode,
            this.subjectName});
            this.subjectDataGrid.Location = new System.Drawing.Point(26, 218);
            this.subjectDataGrid.Name = "subjectDataGrid";
            this.subjectDataGrid.ReadOnly = true;
            this.subjectDataGrid.RowHeadersWidth = 51;
            this.subjectDataGrid.RowTemplate.Height = 29;
            this.subjectDataGrid.Size = new System.Drawing.Size(554, 188);
            this.subjectDataGrid.TabIndex = 50;
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
            this.subjectName.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Students";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentRegNo,
            this.studentName});
            this.studentDataGrid.Location = new System.Drawing.Point(26, 475);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersWidth = 51;
            this.studentDataGrid.RowTemplate.Height = 29;
            this.studentDataGrid.Size = new System.Drawing.Size(554, 188);
            this.studentDataGrid.TabIndex = 52;
            // 
            // studentRegNo
            // 
            this.studentRegNo.HeaderText = "Student Reg No";
            this.studentRegNo.MinimumWidth = 6;
            this.studentRegNo.Name = "studentRegNo";
            this.studentRegNo.ReadOnly = true;
            this.studentRegNo.Width = 200;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 300;
            // 
            // ClassMappingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(615, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectDataGrid);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.classPicker);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClassMappingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Mapping Report";
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.DataGridView subjectDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
    }
}