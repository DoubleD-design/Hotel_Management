namespace UI_Tier
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            btnMinisize = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            panelMoving = new Panel();
            btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            uC_Employee1 = new UC.UC_Employee();
            uC_CustomerDetail1 = new UC.UC_CustomerDetail();
            uC_AddRoom1 = new UC_AddRoom();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnExit.Location = new Point(5, 6);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinisize
            // 
            btnMinisize.CustomizableEdges = customizableEdges2;
            btnMinisize.DisabledState.BorderColor = Color.DarkGray;
            btnMinisize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinisize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinisize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinisize.FillColor = Color.Transparent;
            btnMinisize.Font = new Font("Segoe UI", 9F);
            btnMinisize.ForeColor = Color.White;
            btnMinisize.Image = (Image)resources.GetObject("btnMinisize.Image");
            btnMinisize.ImageSize = new Size(30, 30);
            btnMinisize.Location = new Point(6, 44);
            btnMinisize.Name = "btnMinisize";
            btnMinisize.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnMinisize.Size = new Size(30, 30);
            btnMinisize.TabIndex = 1;
            btnMinisize.Click += btnMinisize_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(panelMoving);
            panel1.Controls.Add(btnCustomerDetail);
            panel1.Controls.Add(btnAddRoom);
            panel1.Location = new Point(60, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 116);
            panel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.BorderRadius = 18;
            btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnEmployee.CheckedState.FillColor = Color.White;
            btnEmployee.CheckedState.ForeColor = Color.Black;
            btnEmployee.CustomizableEdges = customizableEdges4;
            btnEmployee.DisabledState.BorderColor = Color.DarkGray;
            btnEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEmployee.FillColor = Color.Indigo;
            btnEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageSize = new Size(60, 50);
            btnEmployee.Location = new Point(1102, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnEmployee.Size = new Size(257, 103);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panelMoving
            // 
            panelMoving.BackColor = Color.Aquamarine;
            panelMoving.Location = new Point(14, 107);
            panelMoving.Name = "panelMoving";
            panelMoving.Size = new Size(257, 6);
            panelMoving.TabIndex = 4;
            // 
            // btnCustomerDetail
            // 
            btnCustomerDetail.BackColor = Color.Transparent;
            btnCustomerDetail.BorderRadius = 18;
            btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCustomerDetail.CheckedState.FillColor = Color.White;
            btnCustomerDetail.CheckedState.ForeColor = Color.Black;
            btnCustomerDetail.CustomizableEdges = customizableEdges6;
            btnCustomerDetail.DisabledState.BorderColor = Color.DarkGray;
            btnCustomerDetail.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCustomerDetail.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCustomerDetail.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCustomerDetail.FillColor = Color.Indigo;
            btnCustomerDetail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerDetail.ForeColor = Color.White;
            btnCustomerDetail.Image = (Image)resources.GetObject("btnCustomerDetail.Image");
            btnCustomerDetail.ImageSize = new Size(45, 45);
            btnCustomerDetail.Location = new Point(578, 3);
            btnCustomerDetail.Name = "btnCustomerDetail";
            btnCustomerDetail.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnCustomerDetail.Size = new Size(257, 103);
            btnCustomerDetail.TabIndex = 1;
            btnCustomerDetail.Text = "Customer Detail";
            btnCustomerDetail.Click += btnCustomerDetail_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.Transparent;
            btnAddRoom.BorderRadius = 18;
            btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddRoom.Checked = true;
            btnAddRoom.CheckedState.FillColor = Color.White;
            btnAddRoom.CheckedState.ForeColor = Color.Black;
            btnAddRoom.CustomizableEdges = customizableEdges8;
            btnAddRoom.DisabledState.BorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRoom.FillColor = Color.Indigo;
            btnAddRoom.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Image = (Image)resources.GetObject("btnAddRoom.Image");
            btnAddRoom.ImageSize = new Size(45, 45);
            btnAddRoom.Location = new Point(14, 3);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnAddRoom.Size = new Size(257, 103);
            btnAddRoom.TabIndex = 0;
            btnAddRoom.Text = "Room Details";
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_Employee1);
            panel2.Controls.Add(uC_CustomerDetail1);
            panel2.Controls.Add(uC_AddRoom1);
            panel2.Location = new Point(18, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(1482, 782);
            panel2.TabIndex = 3;
            // 
            // uC_Employee1
            // 
            uC_Employee1.BackColor = Color.White;
            uC_Employee1.Location = new Point(-1, 0);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(1479, 772);
            uC_Employee1.TabIndex = 1;
            uC_Employee1.Visible = false;
            uC_Employee1.Load += uC_Employee1_Load;
            // 
            // uC_CustomerDetail1
            // 
            uC_CustomerDetail1.BackColor = Color.White;
            uC_CustomerDetail1.Location = new Point(-1, 0);
            uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            uC_CustomerDetail1.Size = new Size(1479, 769);
            uC_CustomerDetail1.TabIndex = 0;
            uC_CustomerDetail1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            uC_AddRoom1.BackColor = Color.White;
            uC_AddRoom1.BorderStyle = BorderStyle.Fixed3D;
            uC_AddRoom1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uC_AddRoom1.Location = new Point(-1, -2);
            uC_AddRoom1.Margin = new Padding(3, 4, 3, 4);
            uC_AddRoom1.Name = "uC_AddRoom1";
            uC_AddRoom1.Size = new Size(1480, 774);
            uC_AddRoom1.TabIndex = 0;
            uC_AddRoom1.Load += uC_AddRoom1_Load;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges10;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Transparent;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageSize = new Size(30, 30);
            btnLogout.Location = new Point(3, 80);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnLogout.Size = new Size(39, 38);
            btnLogout.TabIndex = 4;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1512, 945);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnMinisize);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnMinisize;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private Panel panelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_AddRoom uC_AddRoom1;
        private UC.UC_CustomerDetail uC_CustomerDetail1;
        private UC.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}