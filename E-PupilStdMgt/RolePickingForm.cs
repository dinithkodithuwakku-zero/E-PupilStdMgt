using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_PupilStdMgt
{
    public partial class RolePickingForm : Form
    {
        public RolePickingForm()
        {
            InitializeComponent();
            this.FormClosing += RolePickingForm_FormClosing;

        }

        private void RolePickingForm_Load(object sender, EventArgs e)
        {
            AlignComponents();
            ButtonProperties();
        }

        private void AlignComponents()
        {
            welcomeLabel.Left = (this.ClientSize.Width - welcomeLabel.Width) / 2;
            subTitleLabel.Left = (this.ClientSize.Width - subTitleLabel.Width) / 2;
            continueAsAdminButton.Left = (this.ClientSize.Width - continueAsAdminButton.Width) / 2;
            continueAsStuffButton.Left = (this.ClientSize.Width - continueAsStuffButton.Width) / 2;
        }

        private void ButtonProperties()
        {
            continueAsAdminButton.TabStop = false;
            continueAsAdminButton.FlatStyle = FlatStyle.Flat;
            continueAsAdminButton.FlatAppearance.BorderSize = 0;

            continueAsStuffButton.TabStop = false;
            continueAsStuffButton.FlatStyle = FlatStyle.Flat;
            continueAsStuffButton.FlatAppearance.BorderSize = 0;
        }

        private void RolePickingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                switch (MessageBox.Show(this, "Exit?", "Do you want to exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Stay on this form
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void continueAsAdminButton_Click(object sender, EventArgs e)
        {
            // loginType 1 is for admin
            LoginForm LoginForm = new LoginForm(1);
            LoginForm.Show();
            Hide();
        }

        private void continueAsStuffButton_Click(object sender, EventArgs e)
        {
            // loginType 2 is for admin
            LoginForm LoginForm = new LoginForm(2);
            LoginForm.Show();
            Hide();
        }
    }
}
