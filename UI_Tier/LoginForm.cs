using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bus_Tier;

namespace UI_Tier
{
    public partial class LoginForm : Form
    {
        public int current_role = 1;
        BSUser bu = new BSUser();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Kiểm tra mật khẩu khi đăng nhập
        public bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            User user = bu.GetUserByEmail(enteredEmail);
            if (user == null || !bu.VerifyPassword(enteredPassword, user.password))
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
            else if(current_role == 1)
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }else if(current_role == 0)
            {
                Employee_Dashboard employee_Dashboard = new Employee_Dashboard();
                this.Hide();
                employee_Dashboard.Show();
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            current_role = 1;
            panelMoving.Left = btnManager.Left;
            linkAccountRegistration.Enabled = true;
            linkAccountRegistration.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            current_role = 0;
            panelMoving.Left = btnEmployee.Left;
            linkAccountRegistration.Enabled = false;
            linkAccountRegistration.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (current_role == 1)
            {
                linkAccountRegistration.Enabled = true;
            }
            else
            {
                linkAccountRegistration.Enabled = false;
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkAccountRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Account_Registration account_Registration = new Account_Registration();
            this.Hide();
            account_Registration.Show();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
