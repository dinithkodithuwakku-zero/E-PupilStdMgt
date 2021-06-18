
namespace E_PupilStdMgt.forms.screens
{
    partial class ClassMgtScreenForm
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
            this.classDataGrid = new System.Windows.Forms.DataGridView();
            this.ID_CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_ACTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createNewClassButton = new System.Windows.Forms.Button();
            this.classCreatePanel = new System.Windows.Forms.Panel();
            this.classCodeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closePanelButton = new System.Windows.Forms.Button();
            this.createPanelButton = new System.Windows.Forms.Button();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGrid)).BeginInit();
            this.classCreatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // classDataGrid
            // 
            this.classDataGrid.AllowUserToAddRows = false;
            this.classDataGrid.AllowUserToDeleteRows = false;
            this.classDataGrid.AllowUserToOrderColumns = true;
            this.classDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.classDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLASS,
            this.CLASS_NAME,
            this.CLASS_CODE,
            this.IS_ACTIVE});
            this.classDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.classDataGrid.Location = new System.Drawing.Point(47, 183);
            this.classDataGrid.Name = "classDataGrid";
            this.classDataGrid.ReadOnly = true;
            this.classDataGrid.RowHeadersWidth = 51;
            this.classDataGrid.RowTemplate.Height = 29;
            this.classDataGrid.Size = new System.Drawing.Size(802, 248);
            this.classDataGrid.TabIndex = 0;
            // 
            // ID_CLASS
            // 
            this.ID_CLASS.HeaderText = "Class Id";
            this.ID_CLASS.MinimumWidth = 6;
            this.ID_CLASS.Name = "ID_CLASS";
            this.ID_CLASS.ReadOnly = true;
            this.ID_CLASS.Width = 125;
            // 
            // CLASS_NAME
            // 
            this.CLASS_NAME.HeaderText = "Class Name";
            this.CLASS_NAME.MinimumWidth = 6;
            this.CLASS_NAME.Name = "CLASS_NAME";
            this.CLASS_NAME.ReadOnly = true;
            this.CLASS_NAME.Width = 250;
            // 
            // CLASS_CODE
            // 
            this.CLASS_CODE.HeaderText = "Class Code";
            this.CLASS_CODE.MinimumWidth = 6;
            this.CLASS_CODE.Name = "CLASS_CODE";
            this.CLASS_CODE.ReadOnly = true;
            this.CLASS_CODE.Width = 250;
            // 
            // IS_ACTIVE
            // 
            this.IS_ACTIVE.HeaderText = "Is Active";
            this.IS_ACTIVE.MinimumWidth = 6;
            this.IS_ACTIVE.Name = "IS_ACTIVE";
            this.IS_ACTIVE.ReadOnly = true;
            this.IS_ACTIVE.Width = 125;
            // 
            // createNewClassButton
            // 
            this.createNewClassButton.AutoSize = true;
            this.createNewClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(136)))), ((int)(((byte)(88)))));
            this.createNewClassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewClassButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.createNewClassButton.FlatAppearance.BorderSize = 0;
            this.createNewClassButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewClassButton.ForeColor = System.Drawing.SystemColors.Info;
            this.createNewClassButton.Location = new System.Drawing.Point(658, 56);
            this.createNewClassButton.Name = "createNewClassButton";
            this.createNewClassButton.Size = new System.Drawing.Size(192, 53);
            this.createNewClassButton.TabIndex = 9;
            this.createNewClassButton.Text = "Create New Class";
            this.createNewClassButton.UseVisualStyleBackColor = false;
            this.createNewClassButton.Click += new System.EventHandler(this.createNewClassButton_Click);
            // 
            // classCreatePanel
            // 
            this.classCreatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCreatePanel.Controls.Add(this.isActiveCheckBox);
            this.classCreatePanel.Controls.Add(this.classCodeInput);
            this.classCreatePanel.Controls.Add(this.label3);
            this.classCreatePanel.Controls.Add(this.classNameInput);
            this.classCreatePanel.Controls.Add(this.label2);
            this.classCreatePanel.Controls.Add(this.label1);
            this.classCreatePanel.Controls.Add(this.closePanelButton);
            this.classCreatePanel.Controls.Add(this.createPanelButton);
            this.classCreatePanel.Location = new System.Drawing.Point(128, 86);
            this.classCreatePanel.Name = "classCreatePanel";
            this.classCreatePanel.Size = new System.Drawing.Size(651, 332);
            this.classCreatePanel.TabIndex = 10;
            this.classCreatePanel.Visible = false;
            // 
            // classCodeInput
            // 
            this.classCodeInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classCodeInput.Location = new System.Drawing.Point(209, 126);
            this.classCodeInput.Name = "classCodeInput";
            this.classCodeInput.Size = new System.Drawing.Size(405, 27);
            this.classCodeInput.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Class Code";
            // 
            // classNameInput
            // 
            this.classNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classNameInput.Location = new System.Drawing.Point(209, 75);
            this.classNameInput.Name = "classNameInput";
            this.classNameInput.Size = new System.Drawing.Size(405, 27);
            this.classNameInput.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Class Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create New Class";
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
            this.closePanelButton.Location = new System.Drawing.Point(465, 242);
            this.closePanelButton.Name = "closePanelButton";
            this.closePanelButton.Size = new System.Drawing.Size(149, 53);
            this.closePanelButton.TabIndex = 12;
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
            this.createPanelButton.Location = new System.Drawing.Point(299, 242);
            this.createPanelButton.Name = "createPanelButton";
            this.createPanelButton.Size = new System.Drawing.Size(149, 53);
            this.createPanelButton.TabIndex = 11;
            this.createPanelButton.Text = "Create";
            this.createPanelButton.UseVisualStyleBackColor = false;
            this.createPanelButton.Click += new System.EventHandler(this.createPanelButton_Click);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isActiveCheckBox.ForeColor = System.Drawing.SystemColors.Info;
            this.isActiveCheckBox.Location = new System.Drawing.Point(209, 185);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(75, 24);
            this.isActiveCheckBox.TabIndex = 20;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClassMgtScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(898, 564);
            this.Controls.Add(this.classCreatePanel);
            this.Controls.Add(this.createNewClassButton);
            this.Controls.Add(this.classDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassMgtScreenForm";
            this.Text = "ClassMgtScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.classDataGrid)).EndInit();
            this.classCreatePanel.ResumeLayout(false);
            this.classCreatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView classDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_ACTIVE;
        private System.Windows.Forms.Button createNewClassButton;
        private System.Windows.Forms.Panel classCreatePanel;
        private System.Windows.Forms.Button closePanelButton;
        private System.Windows.Forms.Button createPanelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classCodeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox classNameInput;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
    }
}