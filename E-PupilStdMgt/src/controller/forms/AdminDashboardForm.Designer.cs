
namespace E_PupilStdMgt.forms
{
    partial class AdminDashboardForm
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subjectMgtPanelButton = new System.Windows.Forms.Panel();
            this.subjectMgtButtonLabel = new System.Windows.Forms.Label();
            this.subjectMgtButtonImage = new System.Windows.Forms.PictureBox();
            this.classMgtPanelButton = new System.Windows.Forms.Panel();
            this.classMgtButtonLabel = new System.Windows.Forms.Label();
            this.classMgtButtonImage = new System.Windows.Forms.PictureBox();
            this.stuffMgtPanelButton = new System.Windows.Forms.Panel();
            this.stuffMgtButtonLabel = new System.Windows.Forms.Label();
            this.stuffMgtButtonImage = new System.Windows.Forms.PictureBox();
            this.studentMgtPanelButton = new System.Windows.Forms.Panel();
            this.studentMgtButtonLabel = new System.Windows.Forms.Label();
            this.studentMgtButtonImage = new System.Windows.Forms.PictureBox();
            this.schoolMgtPanelButton = new System.Windows.Forms.Panel();
            this.schoolMgtButtonLabel = new System.Windows.Forms.Label();
            this.schoolMgtButtonImage = new System.Windows.Forms.PictureBox();
            this.dashboardPanelButton = new System.Windows.Forms.Panel();
            this.dashboardButtonLabel = new System.Windows.Forms.Label();
            this.dashboardButtonImage = new System.Windows.Forms.PictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameImage = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.currentPanelTitleLabel = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formLoaderPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subjectMgtPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMgtButtonImage)).BeginInit();
            this.classMgtPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMgtButtonImage)).BeginInit();
            this.stuffMgtPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffMgtButtonImage)).BeginInit();
            this.studentMgtPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtButtonImage)).BeginInit();
            this.schoolMgtPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolMgtButtonImage)).BeginInit();
            this.dashboardPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonImage)).BeginInit();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameImage)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.subjectMgtPanelButton);
            this.sidePanel.Controls.Add(this.classMgtPanelButton);
            this.sidePanel.Controls.Add(this.stuffMgtPanelButton);
            this.sidePanel.Controls.Add(this.studentMgtPanelButton);
            this.sidePanel.Controls.Add(this.schoolMgtPanelButton);
            this.sidePanel.Controls.Add(this.dashboardPanelButton);
            this.sidePanel.Controls.Add(this.userPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(273, 726);
            this.sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 664);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 50);
            this.panel1.TabIndex = 7;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(96, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exit Application";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_PupilStdMgt.Properties.Resources.outline_cancel_white_36dp;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // subjectMgtPanelButton
            // 
            this.subjectMgtPanelButton.Controls.Add(this.subjectMgtButtonLabel);
            this.subjectMgtPanelButton.Controls.Add(this.subjectMgtButtonImage);
            this.subjectMgtPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectMgtPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectMgtPanelButton.Location = new System.Drawing.Point(0, 349);
            this.subjectMgtPanelButton.Name = "subjectMgtPanelButton";
            this.subjectMgtPanelButton.Size = new System.Drawing.Size(273, 50);
            this.subjectMgtPanelButton.TabIndex = 6;
            this.subjectMgtPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectMgtPanelButton_MouseClick);
            // 
            // subjectMgtButtonLabel
            // 
            this.subjectMgtButtonLabel.AutoSize = true;
            this.subjectMgtButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectMgtButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.subjectMgtButtonLabel.Location = new System.Drawing.Point(96, 15);
            this.subjectMgtButtonLabel.Name = "subjectMgtButtonLabel";
            this.subjectMgtButtonLabel.Size = new System.Drawing.Size(109, 23);
            this.subjectMgtButtonLabel.TabIndex = 1;
            this.subjectMgtButtonLabel.Text = "Subject Mgt";
            this.subjectMgtButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectMgtPanelButton_MouseClick);
            // 
            // subjectMgtButtonImage
            // 
            this.subjectMgtButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_title_white_36dp;
            this.subjectMgtButtonImage.Location = new System.Drawing.Point(1, 2);
            this.subjectMgtButtonImage.Name = "subjectMgtButtonImage";
            this.subjectMgtButtonImage.Size = new System.Drawing.Size(63, 47);
            this.subjectMgtButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subjectMgtButtonImage.TabIndex = 0;
            this.subjectMgtButtonImage.TabStop = false;
            this.subjectMgtButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subjectMgtPanelButton_MouseClick);
            // 
            // classMgtPanelButton
            // 
            this.classMgtPanelButton.Controls.Add(this.classMgtButtonLabel);
            this.classMgtPanelButton.Controls.Add(this.classMgtButtonImage);
            this.classMgtPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classMgtPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.classMgtPanelButton.Location = new System.Drawing.Point(0, 299);
            this.classMgtPanelButton.Name = "classMgtPanelButton";
            this.classMgtPanelButton.Size = new System.Drawing.Size(273, 50);
            this.classMgtPanelButton.TabIndex = 5;
            this.classMgtPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.classMgtPanelButton_MouseClick);
            // 
            // classMgtButtonLabel
            // 
            this.classMgtButtonLabel.AutoSize = true;
            this.classMgtButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classMgtButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.classMgtButtonLabel.Location = new System.Drawing.Point(96, 15);
            this.classMgtButtonLabel.Name = "classMgtButtonLabel";
            this.classMgtButtonLabel.Size = new System.Drawing.Size(88, 23);
            this.classMgtButtonLabel.TabIndex = 1;
            this.classMgtButtonLabel.Text = "Class Mgt";
            this.classMgtButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.classMgtPanelButton_MouseClick);
            // 
            // classMgtButtonImage
            // 
            this.classMgtButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_room_preferences_white_36dp;
            this.classMgtButtonImage.Location = new System.Drawing.Point(1, 2);
            this.classMgtButtonImage.Name = "classMgtButtonImage";
            this.classMgtButtonImage.Size = new System.Drawing.Size(63, 47);
            this.classMgtButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.classMgtButtonImage.TabIndex = 0;
            this.classMgtButtonImage.TabStop = false;
            this.classMgtButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.classMgtPanelButton_MouseClick);
            // 
            // stuffMgtPanelButton
            // 
            this.stuffMgtPanelButton.Controls.Add(this.stuffMgtButtonLabel);
            this.stuffMgtPanelButton.Controls.Add(this.stuffMgtButtonImage);
            this.stuffMgtPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stuffMgtPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stuffMgtPanelButton.Location = new System.Drawing.Point(0, 249);
            this.stuffMgtPanelButton.Name = "stuffMgtPanelButton";
            this.stuffMgtPanelButton.Size = new System.Drawing.Size(273, 50);
            this.stuffMgtPanelButton.TabIndex = 4;
            this.stuffMgtPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stuffMgtPanelButton_MouseClick);
            // 
            // stuffMgtButtonLabel
            // 
            this.stuffMgtButtonLabel.AutoSize = true;
            this.stuffMgtButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stuffMgtButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.stuffMgtButtonLabel.Location = new System.Drawing.Point(96, 15);
            this.stuffMgtButtonLabel.Name = "stuffMgtButtonLabel";
            this.stuffMgtButtonLabel.Size = new System.Drawing.Size(90, 23);
            this.stuffMgtButtonLabel.TabIndex = 1;
            this.stuffMgtButtonLabel.Text = "Stuff Mgt";
            this.stuffMgtButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stuffMgtPanelButton_MouseClick);
            // 
            // stuffMgtButtonImage
            // 
            this.stuffMgtButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_manage_accounts_white_36dp;
            this.stuffMgtButtonImage.Location = new System.Drawing.Point(1, 2);
            this.stuffMgtButtonImage.Name = "stuffMgtButtonImage";
            this.stuffMgtButtonImage.Size = new System.Drawing.Size(63, 47);
            this.stuffMgtButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stuffMgtButtonImage.TabIndex = 0;
            this.stuffMgtButtonImage.TabStop = false;
            this.stuffMgtButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stuffMgtPanelButton_MouseClick);
            // 
            // studentMgtPanelButton
            // 
            this.studentMgtPanelButton.Controls.Add(this.studentMgtButtonLabel);
            this.studentMgtPanelButton.Controls.Add(this.studentMgtButtonImage);
            this.studentMgtPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentMgtPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentMgtPanelButton.Location = new System.Drawing.Point(0, 199);
            this.studentMgtPanelButton.Name = "studentMgtPanelButton";
            this.studentMgtPanelButton.Size = new System.Drawing.Size(273, 50);
            this.studentMgtPanelButton.TabIndex = 3;
            this.studentMgtPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentMgtPanelButton_MouseClick);
            // 
            // studentMgtButtonLabel
            // 
            this.studentMgtButtonLabel.AutoSize = true;
            this.studentMgtButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentMgtButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.studentMgtButtonLabel.Location = new System.Drawing.Point(96, 15);
            this.studentMgtButtonLabel.Name = "studentMgtButtonLabel";
            this.studentMgtButtonLabel.Size = new System.Drawing.Size(113, 23);
            this.studentMgtButtonLabel.TabIndex = 1;
            this.studentMgtButtonLabel.Text = "Student Mgt";
            this.studentMgtButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentMgtPanelButton_MouseClick);
            // 
            // studentMgtButtonImage
            // 
            this.studentMgtButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_badge_white_36dp;
            this.studentMgtButtonImage.Location = new System.Drawing.Point(1, 2);
            this.studentMgtButtonImage.Name = "studentMgtButtonImage";
            this.studentMgtButtonImage.Size = new System.Drawing.Size(63, 47);
            this.studentMgtButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentMgtButtonImage.TabIndex = 0;
            this.studentMgtButtonImage.TabStop = false;
            this.studentMgtButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.studentMgtPanelButton_MouseClick);
            // 
            // schoolMgtPanelButton
            // 
            this.schoolMgtPanelButton.Controls.Add(this.schoolMgtButtonLabel);
            this.schoolMgtPanelButton.Controls.Add(this.schoolMgtButtonImage);
            this.schoolMgtPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schoolMgtPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.schoolMgtPanelButton.Location = new System.Drawing.Point(0, 149);
            this.schoolMgtPanelButton.Name = "schoolMgtPanelButton";
            this.schoolMgtPanelButton.Size = new System.Drawing.Size(273, 50);
            this.schoolMgtPanelButton.TabIndex = 2;
            this.schoolMgtPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.schoolMgtPanelButton_MouseClick);
            // 
            // schoolMgtButtonLabel
            // 
            this.schoolMgtButtonLabel.AutoSize = true;
            this.schoolMgtButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.schoolMgtButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.schoolMgtButtonLabel.Location = new System.Drawing.Point(96, 15);
            this.schoolMgtButtonLabel.Name = "schoolMgtButtonLabel";
            this.schoolMgtButtonLabel.Size = new System.Drawing.Size(102, 23);
            this.schoolMgtButtonLabel.TabIndex = 1;
            this.schoolMgtButtonLabel.Text = "School Mgt";
            this.schoolMgtButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.schoolMgtPanelButton_MouseClick);
            // 
            // schoolMgtButtonImage
            // 
            this.schoolMgtButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_school_white_36dp1;
            this.schoolMgtButtonImage.Location = new System.Drawing.Point(1, 2);
            this.schoolMgtButtonImage.Name = "schoolMgtButtonImage";
            this.schoolMgtButtonImage.Size = new System.Drawing.Size(63, 47);
            this.schoolMgtButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.schoolMgtButtonImage.TabIndex = 0;
            this.schoolMgtButtonImage.TabStop = false;
            this.schoolMgtButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.schoolMgtPanelButton_MouseClick);
            // 
            // dashboardPanelButton
            // 
            this.dashboardPanelButton.Controls.Add(this.dashboardButtonLabel);
            this.dashboardPanelButton.Controls.Add(this.dashboardButtonImage);
            this.dashboardPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardPanelButton.Location = new System.Drawing.Point(0, 99);
            this.dashboardPanelButton.Name = "dashboardPanelButton";
            this.dashboardPanelButton.Size = new System.Drawing.Size(273, 50);
            this.dashboardPanelButton.TabIndex = 1;
            this.dashboardPanelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashboardPanelButton_MouseClick);
            // 
            // dashboardButtonLabel
            // 
            this.dashboardButtonLabel.AutoSize = true;
            this.dashboardButtonLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardButtonLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.dashboardButtonLabel.Location = new System.Drawing.Point(96, 14);
            this.dashboardButtonLabel.Name = "dashboardButtonLabel";
            this.dashboardButtonLabel.Size = new System.Drawing.Size(97, 23);
            this.dashboardButtonLabel.TabIndex = 1;
            this.dashboardButtonLabel.Text = "Dashboard";
            this.dashboardButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashboardPanelButton_MouseClick);
            // 
            // dashboardButtonImage
            // 
            this.dashboardButtonImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_dashboard_white_36dp;
            this.dashboardButtonImage.Location = new System.Drawing.Point(1, 2);
            this.dashboardButtonImage.Name = "dashboardButtonImage";
            this.dashboardButtonImage.Size = new System.Drawing.Size(63, 47);
            this.dashboardButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardButtonImage.TabIndex = 0;
            this.dashboardButtonImage.TabStop = false;
            this.dashboardButtonImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dashboardPanelButton_MouseClick);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Controls.Add(this.userNameImage);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(273, 99);
            this.userPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.userNameLabel.Location = new System.Drawing.Point(73, 65);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 20);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "UserName";
            // 
            // userNameImage
            // 
            this.userNameImage.Image = global::E_PupilStdMgt.Properties.Resources.outline_account_circle_white_36dp;
            this.userNameImage.Location = new System.Drawing.Point(88, 9);
            this.userNameImage.Name = "userNameImage";
            this.userNameImage.Size = new System.Drawing.Size(53, 53);
            this.userNameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userNameImage.TabIndex = 2;
            this.userNameImage.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.topPanel.Controls.Add(this.currentPanelTitleLabel);
            this.topPanel.Controls.Add(this.userTypeLabel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(273, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1021, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dashboardForm_MouseDown);
            // 
            // currentPanelTitleLabel
            // 
            this.currentPanelTitleLabel.AutoSize = true;
            this.currentPanelTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPanelTitleLabel.ForeColor = System.Drawing.Color.White;
            this.currentPanelTitleLabel.Location = new System.Drawing.Point(16, 9);
            this.currentPanelTitleLabel.Name = "currentPanelTitleLabel";
            this.currentPanelTitleLabel.Size = new System.Drawing.Size(121, 20);
            this.currentPanelTitleLabel.TabIndex = 2;
            this.currentPanelTitleLabel.Text = "Click menu item";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userTypeLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.userTypeLabel.Location = new System.Drawing.Point(896, 9);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(113, 20);
            this.userTypeLabel.TabIndex = 1;
            this.userTypeLabel.Text = "an Admin user";
            this.userTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You are currently logged in as";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLoaderPanel
            // 
            this.formLoaderPanel.Location = new System.Drawing.Point(273, 40);
            this.formLoaderPanel.Name = "formLoaderPanel";
            this.formLoaderPanel.Size = new System.Drawing.Size(1021, 686);
            this.formLoaderPanel.TabIndex = 1;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1294, 726);
            this.Controls.Add(this.formLoaderPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DashboardForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dashboardForm_MouseDown);
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subjectMgtPanelButton.ResumeLayout(false);
            this.subjectMgtPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMgtButtonImage)).EndInit();
            this.classMgtPanelButton.ResumeLayout(false);
            this.classMgtPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMgtButtonImage)).EndInit();
            this.stuffMgtPanelButton.ResumeLayout(false);
            this.stuffMgtPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffMgtButtonImage)).EndInit();
            this.studentMgtPanelButton.ResumeLayout(false);
            this.studentMgtPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMgtButtonImage)).EndInit();
            this.schoolMgtPanelButton.ResumeLayout(false);
            this.schoolMgtPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolMgtButtonImage)).EndInit();
            this.dashboardPanelButton.ResumeLayout(false);
            this.dashboardPanelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardButtonImage)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameImage)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox userNameImage;
        private System.Windows.Forms.Panel dashboardPanelButton;
        private System.Windows.Forms.Label dashboardButtonLabel;
        private System.Windows.Forms.PictureBox dashboardButtonImage;
        private System.Windows.Forms.Panel schoolMgtPanelButton;
        private System.Windows.Forms.Label schoolMgtButtonLabel;
        private System.Windows.Forms.PictureBox schoolMgtButtonImage;
        private System.Windows.Forms.Panel studentMgtPanelButton;
        private System.Windows.Forms.Label studentMgtButtonLabel;
        private System.Windows.Forms.PictureBox studentMgtButtonImage;
        private System.Windows.Forms.Panel classMgtPanelButton;
        private System.Windows.Forms.Label classMgtButtonLabel;
        private System.Windows.Forms.PictureBox classMgtButtonImage;
        private System.Windows.Forms.Panel stuffMgtPanelButton;
        private System.Windows.Forms.Label stuffMgtButtonLabel;
        private System.Windows.Forms.PictureBox stuffMgtButtonImage;
        private System.Windows.Forms.Panel subjectMgtPanelButton;
        private System.Windows.Forms.Label subjectMgtButtonLabel;
        private System.Windows.Forms.PictureBox subjectMgtButtonImage;
        private System.Windows.Forms.Panel formLoaderPanel;
        private System.Windows.Forms.Label currentPanelTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}