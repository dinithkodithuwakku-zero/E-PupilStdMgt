
namespace E_PupilStdMgt.forms
{
    partial class RolePickingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.continueAsStuffButton = new System.Windows.Forms.Button();
            this.continueAsAdminButton = new System.Windows.Forms.Button();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.welcomeLabel.Location = new System.Drawing.Point(293, 73);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(186, 46);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "WELCOME";
            // 
            // formPanel
            // 
            this.formPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formPanel.AutoSize = true;
            this.formPanel.Controls.Add(this.continueAsStuffButton);
            this.formPanel.Controls.Add(this.continueAsAdminButton);
            this.formPanel.Controls.Add(this.closeIcon);
            this.formPanel.Controls.Add(this.subTitleLabel);
            this.formPanel.Controls.Add(this.welcomeLabel);
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(799, 448);
            this.formPanel.TabIndex = 1;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formPanel_MouseDown);
            // 
            // continueAsStuffButton
            // 
            this.continueAsStuffButton.AutoSize = true;
            this.continueAsStuffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(82)))), ((int)(((byte)(130)))));
            this.continueAsStuffButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.continueAsStuffButton.FlatAppearance.BorderSize = 0;
            this.continueAsStuffButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueAsStuffButton.ForeColor = System.Drawing.SystemColors.Info;
            this.continueAsStuffButton.Location = new System.Drawing.Point(218, 303);
            this.continueAsStuffButton.Name = "continueAsStuffButton";
            this.continueAsStuffButton.Size = new System.Drawing.Size(331, 53);
            this.continueAsStuffButton.TabIndex = 4;
            this.continueAsStuffButton.Text = "Continue as a Stuff";
            this.continueAsStuffButton.UseVisualStyleBackColor = false;
            this.continueAsStuffButton.Click += new System.EventHandler(this.continueAsStuffButton_Click);
            // 
            // continueAsAdminButton
            // 
            this.continueAsAdminButton.AutoSize = true;
            this.continueAsAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.continueAsAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.continueAsAdminButton.FlatAppearance.BorderSize = 0;
            this.continueAsAdminButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.continueAsAdminButton.ForeColor = System.Drawing.SystemColors.Info;
            this.continueAsAdminButton.Location = new System.Drawing.Point(218, 225);
            this.continueAsAdminButton.Name = "continueAsAdminButton";
            this.continueAsAdminButton.Size = new System.Drawing.Size(331, 53);
            this.continueAsAdminButton.TabIndex = 3;
            this.continueAsAdminButton.Text = "Continue as an Admin";
            this.continueAsAdminButton.UseVisualStyleBackColor = false;
            this.continueAsAdminButton.Click += new System.EventHandler(this.continueAsAdminButton_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = global::E_PupilStdMgt.Properties.Resources.outline_cancel_white_36dp;
            this.closeIcon.Location = new System.Drawing.Point(755, 12);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(33, 35);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeIcon.TabIndex = 2;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subTitleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.subTitleLabel.Location = new System.Drawing.Point(232, 120);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(299, 35);
            this.subTitleLabel.TabIndex = 1;
            this.subTitleLabel.Text = "OMP International School";
            // 
            // RolePickingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolePickingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RolePickingForm_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Button continueAsAdminButton;
        private System.Windows.Forms.Button continueAsStuffButton;
    }
}

