
namespace E_PupilStdMgt.forms.screens
{
    partial class SubjectMgtScreenForm
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
            this.createNewSubjectButton = new System.Windows.Forms.Button();
            this.subjectDataGrid = new System.Windows.Forms.DataGridView();
            this.ID_SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_TOTAL_POINTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT_DURATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCreatePanel = new System.Windows.Forms.Panel();
            this.subjectCodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewSubjectLabel = new System.Windows.Forms.Label();
            this.subjectDurationInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectTotalPointsInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGrid)).BeginInit();
            this.subjectCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewSubjectButton
            // 
            this.createNewSubjectButton.AutoSize = true;
            this.createNewSubjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.createNewSubjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewSubjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.createNewSubjectButton.FlatAppearance.BorderSize = 0;
            this.createNewSubjectButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewSubjectButton.ForeColor = System.Drawing.SystemColors.Info;
            this.createNewSubjectButton.Location = new System.Drawing.Point(660, 47);
            this.createNewSubjectButton.Name = "createNewSubjectButton";
            this.createNewSubjectButton.Size = new System.Drawing.Size(192, 53);
            this.createNewSubjectButton.TabIndex = 11;
            this.createNewSubjectButton.Text = "Create New Subject";
            this.createNewSubjectButton.UseVisualStyleBackColor = false;
            this.createNewSubjectButton.Click += new System.EventHandler(this.createNewSubjectButton_Click);
            // 
            // subjectDataGrid
            // 
            this.subjectDataGrid.AllowUserToAddRows = false;
            this.subjectDataGrid.AllowUserToDeleteRows = false;
            this.subjectDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.subjectDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SUBJECT,
            this.SUBJECT_TOTAL_POINTS,
            this.SUBJECT_NAME,
            this.SUBJECT_CODE,
            this.SUBJECT_DURATION});
            this.subjectDataGrid.Location = new System.Drawing.Point(50, 154);
            this.subjectDataGrid.Name = "subjectDataGrid";
            this.subjectDataGrid.ReadOnly = true;
            this.subjectDataGrid.RowHeadersWidth = 51;
            this.subjectDataGrid.RowTemplate.Height = 29;
            this.subjectDataGrid.Size = new System.Drawing.Size(802, 256);
            this.subjectDataGrid.TabIndex = 12;
            // 
            // ID_SUBJECT
            // 
            this.ID_SUBJECT.HeaderText = "Subject Id";
            this.ID_SUBJECT.MinimumWidth = 6;
            this.ID_SUBJECT.Name = "ID_SUBJECT";
            this.ID_SUBJECT.ReadOnly = true;
            this.ID_SUBJECT.Width = 125;
            // 
            // SUBJECT_TOTAL_POINTS
            // 
            this.SUBJECT_TOTAL_POINTS.HeaderText = "Subject Total Points";
            this.SUBJECT_TOTAL_POINTS.MinimumWidth = 6;
            this.SUBJECT_TOTAL_POINTS.Name = "SUBJECT_TOTAL_POINTS";
            this.SUBJECT_TOTAL_POINTS.ReadOnly = true;
            this.SUBJECT_TOTAL_POINTS.Width = 125;
            // 
            // SUBJECT_NAME
            // 
            this.SUBJECT_NAME.HeaderText = "Subject Name";
            this.SUBJECT_NAME.MinimumWidth = 6;
            this.SUBJECT_NAME.Name = "SUBJECT_NAME";
            this.SUBJECT_NAME.ReadOnly = true;
            this.SUBJECT_NAME.Width = 250;
            // 
            // SUBJECT_CODE
            // 
            this.SUBJECT_CODE.HeaderText = "Subject Code";
            this.SUBJECT_CODE.MinimumWidth = 6;
            this.SUBJECT_CODE.Name = "SUBJECT_CODE";
            this.SUBJECT_CODE.ReadOnly = true;
            this.SUBJECT_CODE.Width = 175;
            // 
            // SUBJECT_DURATION
            // 
            this.SUBJECT_DURATION.HeaderText = "Subject Duration";
            this.SUBJECT_DURATION.MinimumWidth = 6;
            this.SUBJECT_DURATION.Name = "SUBJECT_DURATION";
            this.SUBJECT_DURATION.ReadOnly = true;
            this.SUBJECT_DURATION.Width = 125;
            // 
            // subjectCreatePanel
            // 
            this.subjectCreatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectCreatePanel.Controls.Add(this.closePanelButton);
            this.subjectCreatePanel.Controls.Add(this.createPanelButton);
            this.subjectCreatePanel.Controls.Add(this.subjectTotalPointsInput);
            this.subjectCreatePanel.Controls.Add(this.label4);
            this.subjectCreatePanel.Controls.Add(this.subjectDurationInput);
            this.subjectCreatePanel.Controls.Add(this.label3);
            this.subjectCreatePanel.Controls.Add(this.subjectCodeInput);
            this.subjectCreatePanel.Controls.Add(this.label1);
            this.subjectCreatePanel.Controls.Add(this.subjectNameInput);
            this.subjectCreatePanel.Controls.Add(this.label2);
            this.subjectCreatePanel.Controls.Add(this.createNewSubjectLabel);
            this.subjectCreatePanel.Location = new System.Drawing.Point(112, 64);
            this.subjectCreatePanel.Name = "subjectCreatePanel";
            this.subjectCreatePanel.Size = new System.Drawing.Size(688, 417);
            this.subjectCreatePanel.TabIndex = 13;
            this.subjectCreatePanel.Visible = false;
            // 
            // subjectCodeInput
            // 
            this.subjectCodeInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectCodeInput.Location = new System.Drawing.Point(249, 148);
            this.subjectCodeInput.Name = "subjectCodeInput";
            this.subjectCodeInput.Size = new System.Drawing.Size(382, 27);
            this.subjectCodeInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Subject Code";
            // 
            // subjectNameInput
            // 
            this.subjectNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectNameInput.Location = new System.Drawing.Point(249, 90);
            this.subjectNameInput.Name = "subjectNameInput";
            this.subjectNameInput.Size = new System.Drawing.Size(382, 27);
            this.subjectNameInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Subject Name";
            // 
            // createNewSubjectLabel
            // 
            this.createNewSubjectLabel.AutoSize = true;
            this.createNewSubjectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewSubjectLabel.ForeColor = System.Drawing.Color.White;
            this.createNewSubjectLabel.Location = new System.Drawing.Point(27, 28);
            this.createNewSubjectLabel.Name = "createNewSubjectLabel";
            this.createNewSubjectLabel.Size = new System.Drawing.Size(145, 20);
            this.createNewSubjectLabel.TabIndex = 15;
            this.createNewSubjectLabel.Text = "Create New Subject";
            // 
            // subjectDurationInput
            // 
            this.subjectDurationInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectDurationInput.Location = new System.Drawing.Point(249, 204);
            this.subjectDurationInput.Name = "subjectDurationInput";
            this.subjectDurationInput.Size = new System.Drawing.Size(76, 27);
            this.subjectDurationInput.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Subject Duration";
            // 
            // subjectTotalPointsInput
            // 
            this.subjectTotalPointsInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectTotalPointsInput.Location = new System.Drawing.Point(555, 204);
            this.subjectTotalPointsInput.Name = "subjectTotalPointsInput";
            this.subjectTotalPointsInput.Size = new System.Drawing.Size(76, 27);
            this.subjectTotalPointsInput.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(362, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Subject Total Points";
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
            this.closePanelButton.Location = new System.Drawing.Point(482, 318);
            this.closePanelButton.Name = "closePanelButton";
            this.closePanelButton.Size = new System.Drawing.Size(149, 53);
            this.closePanelButton.TabIndex = 31;
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
            this.createPanelButton.Location = new System.Drawing.Point(316, 318);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(149, 53);
            this.createPanelButton.TabIndex = 30;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            this.createPanelButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // SubjectMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.subjectCreatePanel);
            this.Controls.Add(this.subjectDataGrid);
            this.Controls.Add(this.createNewSubjectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectMgtScreenForm";
            this.Text = "SubjectMgtScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGrid)).EndInit();
            this.subjectCreatePanel.ResumeLayout(false);
            this.subjectCreatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewSubjectButton;
        private System.Windows.Forms.DataGridView subjectDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_TOTAL_POINTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_DURATION;
        private System.Windows.Forms.Panel subjectCreatePanel;
        private System.Windows.Forms.Label createNewSubjectLabel;
        private System.Windows.Forms.TextBox subjectCodeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectTotalPointsInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectDurationInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
    }
}