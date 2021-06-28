
namespace E_PupilStdMgt.src.controller.forms
{
    partial class StuffDashboardForm
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
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.studentLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.parentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userTypeLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 41);
            this.panel1.TabIndex = 0;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userTypeLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.userTypeLabel.Location = new System.Drawing.Point(1132, 9);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(91, 20);
            this.userTypeLabel.TabIndex = 5;
            this.userTypeLabel.Text = "a Stuff user";
            this.userTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(917, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "You are currently logged in as";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parentPanel
            // 
            this.parentPanel.AutoScroll = true;
            this.parentPanel.Controls.Add(this.studentLabel);
            this.parentPanel.Controls.Add(this.classLabel);
            this.parentPanel.Controls.Add(this.subjectLabel);
            this.parentPanel.Location = new System.Drawing.Point(12, 15);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Padding = new System.Windows.Forms.Padding(10);
            this.parentPanel.Size = new System.Drawing.Size(1191, 575);
            this.parentPanel.TabIndex = 2;
            this.parentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.parentPanel_Paint);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentLabel.ForeColor = System.Drawing.Color.White;
            this.studentLabel.Location = new System.Drawing.Point(1034, 10);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(71, 20);
            this.studentLabel.TabIndex = 7;
            this.studentLabel.Text = "Students";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classLabel.ForeColor = System.Drawing.Color.White;
            this.classLabel.Location = new System.Drawing.Point(563, 10);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(59, 20);
            this.classLabel.TabIndex = 8;
            this.classLabel.Text = "Classes";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(62, 10);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(67, 20);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subjects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Mapping";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.parentPanel);
            this.panel2.Location = new System.Drawing.Point(1, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 599);
            this.panel2.TabIndex = 7;
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
            this.createPanelButton.Location = new System.Drawing.Point(999, 57);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(206, 53);
            this.createPanelButton.TabIndex = 12;
            this.createPanelButton.Text = "Report Window";
            this.createPanelButton.UseVisualStyleBackColor = false;
            // 
            // StuffDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1235, 740);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createPanelButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StuffDashboardForm";
            this.Text = "StuffDashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.parentPanel.ResumeLayout(false);
            this.parentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel parentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label subjectLabel;
    }
}