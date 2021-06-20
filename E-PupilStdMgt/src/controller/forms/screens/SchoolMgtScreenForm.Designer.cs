
namespace E_PupilStdMgt.forms.screens
{
    partial class SchoolMgtScreenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.schoolNameInput = new System.Windows.Forms.TextBox();
            this.schoolDescriptionInput = new System.Windows.Forms.TextBox();
            this.schoolContactNoInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.schoolAddressInput = new System.Windows.Forms.TextBox();
            this.updateSchoolDetailsButton = new System.Windows.Forms.Button();
            this.schoolBadgeImageUploader = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.schoolBadgeFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBadgeImageUploader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "School name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "School description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "School contact no";
            // 
            // schoolNameInput
            // 
            this.schoolNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolNameInput.Location = new System.Drawing.Point(322, 40);
            this.schoolNameInput.Name = "schoolNameInput";
            this.schoolNameInput.Size = new System.Drawing.Size(484, 27);
            this.schoolNameInput.TabIndex = 3;
            // 
            // schoolDescriptionInput
            // 
            this.schoolDescriptionInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolDescriptionInput.Location = new System.Drawing.Point(322, 102);
            this.schoolDescriptionInput.Multiline = true;
            this.schoolDescriptionInput.Name = "schoolDescriptionInput";
            this.schoolDescriptionInput.Size = new System.Drawing.Size(484, 73);
            this.schoolDescriptionInput.TabIndex = 4;
            // 
            // schoolContactNoInput
            // 
            this.schoolContactNoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolContactNoInput.Location = new System.Drawing.Point(322, 209);
            this.schoolContactNoInput.Name = "schoolContactNoInput";
            this.schoolContactNoInput.Size = new System.Drawing.Size(484, 27);
            this.schoolContactNoInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "School address";
            // 
            // schoolAddressInput
            // 
            this.schoolAddressInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolAddressInput.Location = new System.Drawing.Point(322, 272);
            this.schoolAddressInput.Multiline = true;
            this.schoolAddressInput.Name = "schoolAddressInput";
            this.schoolAddressInput.Size = new System.Drawing.Size(484, 73);
            this.schoolAddressInput.TabIndex = 7;
            // 
            // updateSchoolDetailsButton
            // 
            this.updateSchoolDetailsButton.AutoSize = true;
            this.updateSchoolDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.updateSchoolDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSchoolDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.updateSchoolDetailsButton.FlatAppearance.BorderSize = 0;
            this.updateSchoolDetailsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateSchoolDetailsButton.ForeColor = System.Drawing.SystemColors.Info;
            this.updateSchoolDetailsButton.Location = new System.Drawing.Point(650, 525);
            this.updateSchoolDetailsButton.Name = "updateSchoolDetailsButton";
            this.updateSchoolDetailsButton.Size = new System.Drawing.Size(156, 53);
            this.updateSchoolDetailsButton.TabIndex = 8;
            this.updateSchoolDetailsButton.Text = "Update";
            this.updateSchoolDetailsButton.UseVisualStyleBackColor = false;
            this.updateSchoolDetailsButton.Click += new System.EventHandler(this.updateSchoolDetailsButton_Click);
            // 
            // schoolBadgeImageUploader
            // 
            this.schoolBadgeImageUploader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schoolBadgeImageUploader.Location = new System.Drawing.Point(322, 377);
            this.schoolBadgeImageUploader.Name = "schoolBadgeImageUploader";
            this.schoolBadgeImageUploader.Size = new System.Drawing.Size(143, 114);
            this.schoolBadgeImageUploader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.schoolBadgeImageUploader.TabIndex = 9;
            this.schoolBadgeImageUploader.TabStop = false;
            this.schoolBadgeImageUploader.Click += new System.EventHandler(this.schoolBadgeImageUploader_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "School badge";
            // 
            // schoolBadgeFileDialog
            // 
            this.schoolBadgeFileDialog.FileName = "openFileDialog1";
            // 
            // SchoolMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.schoolBadgeImageUploader);
            this.Controls.Add(this.updateSchoolDetailsButton);
            this.Controls.Add(this.schoolAddressInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.schoolContactNoInput);
            this.Controls.Add(this.schoolDescriptionInput);
            this.Controls.Add(this.schoolNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchoolMgtScreenForm";
            this.Text = "SchoolMgtScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.schoolBadgeImageUploader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox schoolNameInput;
        private System.Windows.Forms.TextBox schoolDescriptionInput;
        private System.Windows.Forms.TextBox schoolContactNoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox schoolAddressInput;
        private System.Windows.Forms.Button updateSchoolDetailsButton;
        private System.Windows.Forms.PictureBox schoolBadgeImageUploader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog schoolBadgeFileDialog;
    }
}