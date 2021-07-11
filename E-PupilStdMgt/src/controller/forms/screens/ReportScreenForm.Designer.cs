
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
            this.classPicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classPicker
            // 
            this.classPicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classPicker.FormattingEnabled = true;
            this.classPicker.Location = new System.Drawing.Point(182, 33);
            this.classPicker.Name = "classPicker";
            this.classPicker.Size = new System.Drawing.Size(196, 28);
            this.classPicker.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 31;
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
            this.printReportButton.Location = new System.Drawing.Point(569, 72);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(192, 43);
            this.printReportButton.TabIndex = 38;
            this.printReportButton.Text = "Print Report";
            this.printReportButton.UseVisualStyleBackColor = false;
            this.printReportButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // ReportScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(858, 468);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.classPicker);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportScreenForm";
            this.Text = "Class Student List Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}