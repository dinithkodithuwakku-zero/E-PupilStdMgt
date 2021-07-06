
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
            this.studentPointInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.examDatePicker = new System.Windows.Forms.DateTimePicker();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailLable = new System.Windows.Forms.Label();
            this.subjectPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.subjectCode,
            this.subjectName,
            this.examDate,
            this.studentPoint});
            this.dataGridView1.Location = new System.Drawing.Point(35, 333);
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
            this.dataGridView1.Size = new System.Drawing.Size(754, 248);
            this.dataGridView1.TabIndex = 39;
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
            // StudentMarkMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(840, 611);
            this.Controls.Add(this.subjectPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDetailLable);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPoint;
        private System.Windows.Forms.Label studentDetailLable;
        private System.Windows.Forms.ComboBox subjectPicker;
        private System.Windows.Forms.Label label1;
    }
}