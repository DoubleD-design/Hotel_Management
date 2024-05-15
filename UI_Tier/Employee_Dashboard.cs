using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Tier
{
    public partial class Employee_Dashboard : Form
    {
        public Employee_Dashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Employee_Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            uC_AddRoom1 = new UC_AddRoom();
            btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            uC_CustomerRegistration1 = new UC_CustomerRegistration();
            panelMoving = new Panel();
            btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            uC_Checkout1 = new UC.UC_Checkout();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uC_AddRoom1
            // 
            uC_AddRoom1.BackColor = Color.White;
            uC_AddRoom1.BorderStyle = BorderStyle.Fixed3D;
            uC_AddRoom1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_AddRoom1.Location = new Point(19, 138);
            uC_AddRoom1.Margin = new Padding(3, 4, 3, 4);
            uC_AddRoom1.Name = "uC_AddRoom1";
            uC_AddRoom1.Size = new Size(0, 0);
            uC_AddRoom1.TabIndex = 5;
            // 
            // btnMinisize
            // 
            btnMinisize.CustomizableEdges = customizableEdges1;
            btnMinisize.DisabledState.BorderColor = Color.DarkGray;
            btnMinisize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinisize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinisize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinisize.FillColor = Color.Transparent;
            btnMinisize.Font = new Font("Segoe UI", 9F);
            btnMinisize.ForeColor = Color.White;
            btnMinisize.Image = (Image)resources.GetObject("btnMinisize.Image");
            btnMinisize.ImageSize = new Size(30, 30);
            btnMinisize.Location = new Point(9, 42);
            btnMinisize.Name = "btnMinisize";
            btnMinisize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMinisize.Size = new Size(30, 30);
            btnMinisize.TabIndex = 7;
            btnMinisize.Click += btnMinisize_Click;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(30, 30);
            btnExit.Location = new Point(9, 4);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 6;
            btnExit.Click += btnExit_Click;
            // 
            // uC_CustomerRegistration1
            // 
            uC_CustomerRegistration1.BackColor = Color.White;
            uC_CustomerRegistration1.Location = new Point(15, 137);
            uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            uC_CustomerRegistration1.Size = new Size(1480, 774);
            uC_CustomerRegistration1.TabIndex = 11;
            uC_CustomerRegistration1.Load += uC_CustomerRegistration1_Load;
            // 
            // panelMoving
            // 
            panelMoving.BackColor = Color.Aquamarine;
            panelMoving.Location = new Point(325, 107);
            panelMoving.Name = "panelMoving";
            panelMoving.Size = new Size(298, 6);
            panelMoving.TabIndex = 10;
            // 
            // btnCustomerRegistration
            // 
            btnCustomerRegistration.BackColor = Color.Transparent;
            btnCustomerRegistration.BorderRadius = 18;
            btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerRegistration.Checked = true;
            btnCustomerRegistration.CheckedState.FillColor = Color.White;
            btnCustomerRegistration.CheckedState.ForeColor = Color.Black;
            btnCustomerRegistration.CustomizableEdges = customizableEdges4;
            btnCustomerRegistration.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerRegistration.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerRegistration.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerRegistration.FillColor = Color.Indigo;
            btnCustomerRegistration.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerRegistration.ForeColor = Color.White;
            btnCustomerRegistration.Image = (Image)resources.GetObject("btnCustomerRegistration.Image");
            btnCustomerRegistration.ImageSize = new Size(45, 45);
            btnCustomerRegistration.Location = new Point(325, 3);
            btnCustomerRegistration.Name = "btnCustomerRegistration";
            btnCustomerRegistration.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnCustomerRegistration.Size = new Size(298, 103);
            btnCustomerRegistration.TabIndex = 0;
            btnCustomerRegistration.Text = "Customer Registration";
            btnCustomerRegistration.Click += btnCustomerRegistration_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Transparent;
            btnCheckout.BorderRadius = 18;
            btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCheckout.CheckedState.FillColor = Color.White;
            btnCheckout.CheckedState.ForeColor = Color.Black;
            btnCheckout.CustomizableEdges = customizableEdges6;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.FillColor = Color.Indigo;
            btnCheckout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageSize = new Size(60, 50);
            btnCheckout.Location = new Point(791, 3);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnCheckout.Size = new Size(257, 103);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Check out";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(btnCustomerRegistration);
            panel1.Controls.Add(panelMoving);
            panel1.Location = new Point(64, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 116);
            panel1.TabIndex = 8;
            // 
            // uC_Checkout1
            // 
            uC_Checkout1.BackColor = Color.White;
            uC_Checkout1.Location = new Point(9, 137);
            uC_Checkout1.Name = "uC_Checkout1";
            uC_Checkout1.Size = new Size(1491, 787);
            uC_Checkout1.TabIndex = 12;
            uC_Checkout1.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges8;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Transparent;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageSize = new Size(30, 30);
            btnLogout.Location = new Point(5, 74);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnLogout.Size = new Size(39, 38);
            btnLogout.TabIndex = 13;
            btnLogout.Click += btnLogout_Click;
            // 
            // Employee_Dashboard
            // 
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1512, 945);
            Controls.Add(btnLogout);
            Controls.Add(uC_Checkout1);
            Controls.Add(uC_CustomerRegistration1);
            Controls.Add(uC_AddRoom1);
            Controls.Add(panel1);
            Controls.Add(btnMinisize);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRegistration1_Load(object sender, EventArgs e)
        {

        }

        private UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private UC_CustomerRegistration uC_CustomerRegistration1;
        private Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Panel panel1;
        private UC.UC_Checkout uC_Checkout1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnCheckout.Left;
            panelMoving.Size = new System.Drawing.Size(btnCheckout.Width, panelMoving.Height);
            uC_Checkout1.Visible = true;
            uC_CustomerRegistration1.Visible = false;
            uC_Checkout1.BringToFront();


        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnCustomerRegistration.Left;
            panelMoving.Size = new Size(btnCustomerRegistration.Width, panelMoving.Height);
            uC_CustomerRegistration1.Visible = true;
            uC_Checkout1.Visible = false;
            uC_CustomerRegistration1.BringToFront();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
