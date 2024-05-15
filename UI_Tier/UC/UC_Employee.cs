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

namespace UI_Tier.UC
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
        }
        BSUser bu = new BSUser();
        BSEmployee be = new BSEmployee();
        public void clearAll()
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.role = 0;
            bu.AddUser(user);
            Employee employee = new Employee();
            employee.employeeName = txtName.Text;
            employee.email = txtEmail.Text;
            employee.phoneNumber = txtPhoneNumber.Text;
            employee.address = txtAddress.Text;
            employee.gender = txtGender.Text;
            employee.employeeId = bu.getID(user.email);
            be.AddEmployee(employee);
            UC_Employee_Load(this, null);
            clearAll();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            DataSet ds = be.GetData();
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView2.DataSource = ds.Tables[0];
            labelID.Text = (bu.getLastInsertId()+1).ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[1] != null)
            {
                txtID.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                User user = new User();
                user.userId = int.Parse(txtID.Text);
                bu.deleteData(user);
                Employee employee = new Employee();
                employee.employeeId = int.Parse(txtID.Text);
                be.deleteData(employee);
                UC_Employee_Load(this, null);
            }
        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
