
namespace E_PupilStdMgt.forms.screens
{
    partial class StuffMgtScreenForm
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
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.ID_STUFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOB_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBILE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERMANENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCreatePanel = new System.Windows.Forms.Panel();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.permanentAddressInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mobileNoInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jobTitlePicker = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nicInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewUserLabel = new System.Windows.Forms.Label();
            this.updateUserPanel = new System.Windows.Forms.Panel();
            this.deleteUpdatePanelButton = new System.Windows.Forms.Button();
            this.cancelUpdatePanelButton = new System.Windows.Forms.Button();
            this.updatePanelButton = new System.Windows.Forms.Button();
            this.updateUserAddressInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateUserEmailInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateUserMobileNoInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.updateUserJobTitlePicker = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.updateUserNICInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.updateUserFullNameInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.userCreatePanel.SuspendLayout();
            this.updateUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.AutoSize = true;
            this.createNewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.createNewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.createNewUserButton.FlatAppearance.BorderSize = 0;
            this.createNewUserButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewUserButton.ForeColor = System.Drawing.SystemColors.Info;
            this.createNewUserButton.Location = new System.Drawing.Point(689, 31);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(192, 53);
            this.createNewUserButton.TabIndex = 11;
            this.createNewUserButton.Text = "Create New User";
            this.createNewUserButton.UseVisualStyleBackColor = false;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButton_Click);
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToAddRows = false;
            this.userDataGrid.AllowUserToDeleteRows = false;
            this.userDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.userDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_STUFF,
            this.USER_NAME,
            this.FULL_NAME,
            this.NIC,
            this.JOB_TITLE,
            this.MOBILE_NO,
            this.EMAIL,
            this.PERMANENT_ADDRESS});
            this.userDataGrid.Location = new System.Drawing.Point(39, 143);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.RowHeadersWidth = 51;
            this.userDataGrid.RowTemplate.Height = 29;
            this.userDataGrid.Size = new System.Drawing.Size(842, 417);
            this.userDataGrid.TabIndex = 12;
            this.userDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGrid_CellClick);
            // 
            // ID_STUFF
            // 
            this.ID_STUFF.HeaderText = "User Id";
            this.ID_STUFF.MinimumWidth = 6;
            this.ID_STUFF.Name = "ID_STUFF";
            this.ID_STUFF.ReadOnly = true;
            this.ID_STUFF.Width = 125;
            // 
            // USER_NAME
            // 
            this.USER_NAME.HeaderText = "Login User Name";
            this.USER_NAME.MinimumWidth = 6;
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            this.USER_NAME.Width = 125;
            // 
            // FULL_NAME
            // 
            this.FULL_NAME.HeaderText = "Full Name";
            this.FULL_NAME.MinimumWidth = 6;
            this.FULL_NAME.Name = "FULL_NAME";
            this.FULL_NAME.ReadOnly = true;
            this.FULL_NAME.Width = 250;
            // 
            // NIC
            // 
            this.NIC.HeaderText = "NIC";
            this.NIC.MinimumWidth = 6;
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            this.NIC.Width = 125;
            // 
            // JOB_TITLE
            // 
            this.JOB_TITLE.HeaderText = "Job Title";
            this.JOB_TITLE.MinimumWidth = 6;
            this.JOB_TITLE.Name = "JOB_TITLE";
            this.JOB_TITLE.ReadOnly = true;
            this.JOB_TITLE.Width = 125;
            // 
            // MOBILE_NO
            // 
            this.MOBILE_NO.HeaderText = "Mobile No";
            this.MOBILE_NO.MinimumWidth = 6;
            this.MOBILE_NO.Name = "MOBILE_NO";
            this.MOBILE_NO.ReadOnly = true;
            this.MOBILE_NO.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 125;
            // 
            // PERMANENT_ADDRESS
            // 
            this.PERMANENT_ADDRESS.HeaderText = "Permanent Address";
            this.PERMANENT_ADDRESS.MinimumWidth = 6;
            this.PERMANENT_ADDRESS.Name = "PERMANENT_ADDRESS";
            this.PERMANENT_ADDRESS.ReadOnly = true;
            this.PERMANENT_ADDRESS.Width = 250;
            // 
            // userCreatePanel
            // 
            this.userCreatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCreatePanel.Controls.Add(this.closePanelButton);
            this.userCreatePanel.Controls.Add(this.createPanelButton);
            this.userCreatePanel.Controls.Add(this.permanentAddressInput);
            this.userCreatePanel.Controls.Add(this.label9);
            this.userCreatePanel.Controls.Add(this.emailInput);
            this.userCreatePanel.Controls.Add(this.label8);
            this.userCreatePanel.Controls.Add(this.mobileNoInput);
            this.userCreatePanel.Controls.Add(this.label7);
            this.userCreatePanel.Controls.Add(this.jobTitlePicker);
            this.userCreatePanel.Controls.Add(this.label6);
            this.userCreatePanel.Controls.Add(this.label5);
            this.userCreatePanel.Controls.Add(this.nicInput);
            this.userCreatePanel.Controls.Add(this.label4);
            this.userCreatePanel.Controls.Add(this.fullNameInput);
            this.userCreatePanel.Controls.Add(this.label3);
            this.userCreatePanel.Controls.Add(this.passwordInput);
            this.userCreatePanel.Controls.Add(this.label1);
            this.userCreatePanel.Controls.Add(this.userNameInput);
            this.userCreatePanel.Controls.Add(this.label2);
            this.userCreatePanel.Controls.Add(this.createNewUserLabel);
            this.userCreatePanel.Location = new System.Drawing.Point(39, 42);
            this.userCreatePanel.Name = "userCreatePanel";
            this.userCreatePanel.Size = new System.Drawing.Size(828, 505);
            this.userCreatePanel.TabIndex = 13;
            this.userCreatePanel.Visible = false;
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
            this.closePanelButton.Location = new System.Drawing.Point(636, 414);
            this.closePanelButton.Name = "closePanelButton";
            this.closePanelButton.Size = new System.Drawing.Size(149, 53);
            this.closePanelButton.TabIndex = 36;
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
            this.createPanelButton.Location = new System.Drawing.Point(470, 414);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(149, 53);
            this.createPanelButton.TabIndex = 35;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            this.createPanelButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // permanentAddressInput
            // 
            this.permanentAddressInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.permanentAddressInput.Location = new System.Drawing.Point(192, 315);
            this.permanentAddressInput.Multiline = true;
            this.permanentAddressInput.Name = "permanentAddressInput";
            this.permanentAddressInput.Size = new System.Drawing.Size(593, 59);
            this.permanentAddressInput.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Permanent Address";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(538, 263);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(247, 27);
            this.emailInput.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(412, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Email";
            // 
            // mobileNoInput
            // 
            this.mobileNoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobileNoInput.Location = new System.Drawing.Point(192, 266);
            this.mobileNoInput.Name = "mobileNoInput";
            this.mobileNoInput.Size = new System.Drawing.Size(180, 27);
            this.mobileNoInput.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mobile No";
            // 
            // jobTitlePicker
            // 
            this.jobTitlePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitlePicker.FormattingEnabled = true;
            this.jobTitlePicker.Items.AddRange(new object[] {
            "Reception",
            "Teacher"});
            this.jobTitlePicker.Location = new System.Drawing.Point(538, 218);
            this.jobTitlePicker.Name = "jobTitlePicker";
            this.jobTitlePicker.Size = new System.Drawing.Size(247, 28);
            this.jobTitlePicker.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(412, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Job Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(353, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "V";
            // 
            // nicInput
            // 
            this.nicInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nicInput.Location = new System.Drawing.Point(192, 218);
            this.nicInput.Name = "nicInput";
            this.nicInput.Size = new System.Drawing.Size(155, 27);
            this.nicInput.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "NIC";
            // 
            // fullNameInput
            // 
            this.fullNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullNameInput.Location = new System.Drawing.Point(192, 165);
            this.fullNameInput.Name = "fullNameInput";
            this.fullNameInput.Size = new System.Drawing.Size(593, 27);
            this.fullNameInput.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Full Name";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(538, 101);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(247, 27);
            this.passwordInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password";
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameInput.Location = new System.Drawing.Point(192, 101);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(143, 27);
            this.userNameInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Login User Name";
            // 
            // createNewUserLabel
            // 
            this.createNewUserLabel.AutoSize = true;
            this.createNewUserLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewUserLabel.ForeColor = System.Drawing.Color.White;
            this.createNewUserLabel.Location = new System.Drawing.Point(21, 28);
            this.createNewUserLabel.Name = "createNewUserLabel";
            this.createNewUserLabel.Size = new System.Drawing.Size(126, 20);
            this.createNewUserLabel.TabIndex = 15;
            this.createNewUserLabel.Text = "Create New User";
            // 
            // updateUserPanel
            // 
            this.updateUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateUserPanel.Controls.Add(this.deleteUpdatePanelButton);
            this.updateUserPanel.Controls.Add(this.cancelUpdatePanelButton);
            this.updateUserPanel.Controls.Add(this.updatePanelButton);
            this.updateUserPanel.Controls.Add(this.updateUserAddressInput);
            this.updateUserPanel.Controls.Add(this.label10);
            this.updateUserPanel.Controls.Add(this.updateUserEmailInput);
            this.updateUserPanel.Controls.Add(this.label11);
            this.updateUserPanel.Controls.Add(this.updateUserMobileNoInput);
            this.updateUserPanel.Controls.Add(this.label12);
            this.updateUserPanel.Controls.Add(this.updateUserJobTitlePicker);
            this.updateUserPanel.Controls.Add(this.label13);
            this.updateUserPanel.Controls.Add(this.label14);
            this.updateUserPanel.Controls.Add(this.updateUserNICInput);
            this.updateUserPanel.Controls.Add(this.label15);
            this.updateUserPanel.Controls.Add(this.updateUserFullNameInput);
            this.updateUserPanel.Controls.Add(this.label16);
            this.updateUserPanel.Controls.Add(this.label19);
            this.updateUserPanel.Location = new System.Drawing.Point(39, 42);
            this.updateUserPanel.Name = "updateUserPanel";
            this.updateUserPanel.Size = new System.Drawing.Size(828, 422);
            this.updateUserPanel.TabIndex = 37;
            this.updateUserPanel.Visible = false;
            // 
            // deleteUpdatePanelButton
            // 
            this.deleteUpdatePanelButton.AutoSize = true;
            this.deleteUpdatePanelButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteUpdatePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUpdatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.deleteUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.deleteUpdatePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUpdatePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteUpdatePanelButton.Location = new System.Drawing.Point(470, 332);
            this.deleteUpdatePanelButton.Name = "deleteUpdatePanelButton";
            this.deleteUpdatePanelButton.Size = new System.Drawing.Size(149, 53);
            this.deleteUpdatePanelButton.TabIndex = 37;
            this.deleteUpdatePanelButton.Text = "Delete";
            this.deleteUpdatePanelButton.UseVisualStyleBackColor = false;
            this.deleteUpdatePanelButton.Click += new System.EventHandler(this.deleteUpdatePanelButton_Click);
            // 
            // cancelUpdatePanelButton
            // 
            this.cancelUpdatePanelButton.AutoSize = true;
            this.cancelUpdatePanelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelUpdatePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelUpdatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cancelUpdatePanelButton.FlatAppearance.BorderSize = 0;
            this.cancelUpdatePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelUpdatePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.cancelUpdatePanelButton.Location = new System.Drawing.Point(634, 332);
            this.cancelUpdatePanelButton.Name = "cancelUpdatePanelButton";
            this.cancelUpdatePanelButton.Size = new System.Drawing.Size(149, 53);
            this.cancelUpdatePanelButton.TabIndex = 36;
            this.cancelUpdatePanelButton.Text = "Cancel";
            this.cancelUpdatePanelButton.UseVisualStyleBackColor = false;
            this.cancelUpdatePanelButton.Click += new System.EventHandler(this.cancelUpdatePanelButton_Click);
            // 
            // updatePanelButton
            // 
            this.updatePanelButton.AutoSize = true;
            this.updatePanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.updatePanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePanelButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.updatePanelButton.FlatAppearance.BorderSize = 0;
            this.updatePanelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatePanelButton.ForeColor = System.Drawing.SystemColors.Info;
            this.updatePanelButton.Location = new System.Drawing.Point(308, 332);
            this.updatePanelButton.Name = "updatePanelButton";
            this.updatePanelButton.Size = new System.Drawing.Size(149, 53);
            this.updatePanelButton.TabIndex = 35;
            this.updatePanelButton.Text = "Update";
            this.updatePanelButton.UseVisualStyleBackColor = false;
            this.updatePanelButton.Click += new System.EventHandler(this.updatePanelButton_Click);
            // 
            // updateUserAddressInput
            // 
            this.updateUserAddressInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserAddressInput.Location = new System.Drawing.Point(190, 233);
            this.updateUserAddressInput.Multiline = true;
            this.updateUserAddressInput.Name = "updateUserAddressInput";
            this.updateUserAddressInput.Size = new System.Drawing.Size(593, 59);
            this.updateUserAddressInput.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Permanent Address";
            // 
            // updateUserEmailInput
            // 
            this.updateUserEmailInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserEmailInput.Location = new System.Drawing.Point(536, 181);
            this.updateUserEmailInput.Name = "updateUserEmailInput";
            this.updateUserEmailInput.Size = new System.Drawing.Size(247, 27);
            this.updateUserEmailInput.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(410, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Email";
            // 
            // updateUserMobileNoInput
            // 
            this.updateUserMobileNoInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserMobileNoInput.Location = new System.Drawing.Point(190, 184);
            this.updateUserMobileNoInput.Name = "updateUserMobileNoInput";
            this.updateUserMobileNoInput.Size = new System.Drawing.Size(180, 27);
            this.updateUserMobileNoInput.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mobile No";
            // 
            // updateUserJobTitlePicker
            // 
            this.updateUserJobTitlePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserJobTitlePicker.FormattingEnabled = true;
            this.updateUserJobTitlePicker.Items.AddRange(new object[] {
            "Reception",
            "Teacher"});
            this.updateUserJobTitlePicker.Location = new System.Drawing.Point(536, 136);
            this.updateUserJobTitlePicker.Name = "updateUserJobTitlePicker";
            this.updateUserJobTitlePicker.Size = new System.Drawing.Size(247, 28);
            this.updateUserJobTitlePicker.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(410, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Job Title";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(351, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "V";
            // 
            // updateUserNICInput
            // 
            this.updateUserNICInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserNICInput.Location = new System.Drawing.Point(190, 136);
            this.updateUserNICInput.Name = "updateUserNICInput";
            this.updateUserNICInput.Size = new System.Drawing.Size(155, 27);
            this.updateUserNICInput.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "NIC";
            // 
            // updateUserFullNameInput
            // 
            this.updateUserFullNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserFullNameInput.Location = new System.Drawing.Point(190, 83);
            this.updateUserFullNameInput.Name = "updateUserFullNameInput";
            this.updateUserFullNameInput.Size = new System.Drawing.Size(593, 27);
            this.updateUserFullNameInput.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(21, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Full Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(21, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "Update User";
            // 
            // StuffMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(916, 611);
            this.Controls.Add(this.updateUserPanel);
            this.Controls.Add(this.userCreatePanel);
            this.Controls.Add(this.userDataGrid);
            this.Controls.Add(this.createNewUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StuffMgtScreenForm";
            this.Text = "StuffMgtScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.userCreatePanel.ResumeLayout(false);
            this.userCreatePanel.PerformLayout();
            this.updateUserPanel.ResumeLayout(false);
            this.updateUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_STUFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOB_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBILE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERMANENT_ADDRESS;
        private System.Windows.Forms.Panel userCreatePanel;
        private System.Windows.Forms.Label createNewUserLabel;
        private System.Windows.Forms.TextBox fullNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mobileNoInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox jobTitlePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nicInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox permanentAddressInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.Panel updateUserPanel;
        private System.Windows.Forms.Button deleteUpdatePanelButton;
        private System.Windows.Forms.Button cancelUpdatePanelButton;
        private System.Windows.Forms.Button updatePanelButton;
        private System.Windows.Forms.TextBox updateUserAddressInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox updateUserEmailInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox updateUserMobileNoInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox updateUserJobTitlePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox updateUserNICInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox updateUserFullNameInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
    }
}