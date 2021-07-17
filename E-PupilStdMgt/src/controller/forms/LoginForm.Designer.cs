
namespace E_PupilStdMgt.forms
{
    partial class LoginForm
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.MaskedTextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.userNameImage = new System.Windows.Forms.PictureBox();
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.loginButton);
            this.backgroundPanel.Controls.Add(this.closeIcon);
            this.backgroundPanel.Controls.Add(this.inputPanel);
            this.backgroundPanel.Controls.Add(this.coverImage);
            this.backgroundPanel.Controls.Add(this.titleLabel);
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(502, 596);
            this.backgroundPanel.TabIndex = 0;
            this.backgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backgroundPanel_Paint);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.SystemColors.Info;
            this.loginButton.Location = new System.Drawing.Point(82, 419);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(331, 53);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = global::E_PupilStdMgt.Properties.Resources.outline_cancel_white_36dp;
            this.closeIcon.Location = new System.Drawing.Point(454, 12);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(33, 35);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeIcon.TabIndex = 3;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.passwordInput);
            this.inputPanel.Controls.Add(this.userNameInput);
            this.inputPanel.Controls.Add(this.panel3);
            this.inputPanel.Controls.Add(this.panel1);
            this.inputPanel.Controls.Add(this.passwordImage);
            this.inputPanel.Controls.Add(this.userNameImage);
            this.inputPanel.Location = new System.Drawing.Point(48, 257);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(390, 115);
            this.inputPanel.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(72, 62);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(315, 23);
            this.passwordInput.TabIndex = 7;
            // 
            // userNameInput
            // 
            this.userNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameInput.Location = new System.Drawing.Point(72, 10);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(315, 23);
            this.userNameInput.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(66, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(66, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 1);
            this.panel2.TabIndex = 4;
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_vpn_key_white_36dp;
            this.passwordImage.Location = new System.Drawing.Point(3, 53);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(63, 39);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 2;
            this.passwordImage.TabStop = false;
            this.passwordImage.Click += new System.EventHandler(this.passwordImage_Click);
            // 
            // userNameImage
            // 
            this.userNameImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_account_circle_white_36dp;
            this.userNameImage.Location = new System.Drawing.Point(3, 3);
            this.userNameImage.Name = "userNameImage";
            this.userNameImage.Size = new System.Drawing.Size(63, 36);
            this.userNameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userNameImage.TabIndex = 0;
            this.userNameImage.TabStop = false;
            this.userNameImage.Click += new System.EventHandler(this.userNameImage_Click);
            // 
            // coverImage
            // 
            this.coverImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_login_white_24dp;
            this.coverImage.Location = new System.Drawing.Point(191, 51);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(59, 57);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 1;
            this.coverImage.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.titleLabel.Location = new System.Drawing.Point(82, 148);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(499, 595);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.PictureBox userNameImage;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox passwordInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Button loginButton;
    }
}