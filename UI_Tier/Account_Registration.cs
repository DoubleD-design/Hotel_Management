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
    public partial class Account_Registration : Form
    {
        int current_role = 1;
        BSManager bm = new BSManager();
        BSUser bu = new BSUser();
        public Account_Registration()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.email = txtUsername.Text;
            user.password = txtPassword.Text;
            user.role = current_role;
            bu.AddUser(user);
            Manager manager = new Manager();
            manager.managerId = bu.getLastInsertId();
            manager.managerName = txtName.Text;
            bm.addManager(manager);
            MessageBox.Show("Registration success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
