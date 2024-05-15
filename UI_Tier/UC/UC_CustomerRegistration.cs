using Bus_Tier;
using Model;
using MySql.Data.MySqlClient;
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
    public partial class UC_CustomerRegistration : UserControl
    {
        BSRoom br = new BSRoom();
        BSCustomer bc = new BSCustomer();
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(ComboBox combo)
        {
            Room room = new Room();
            room.roomType = txtRoomType.Text;
            room.bedType = txtBed.Text;
            MySqlDataReader dr = br.getRoomNo(room);
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    combo.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDateofBirth.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckin.ResetText();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtRoomNumber.SelectedIndex = -1;
            txtPrice.Clear();
        }
        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNumber.Items.Clear();
            setComboBox(txtRoomNumber);
        }

        int rId;
        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room room = new Room();
            room.roomNo = int.Parse(txtRoomNumber.Text);
            DataSet ds = br.getPriceAndID(room);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rId = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAllotRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhoneNumber.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDateofBirth.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
                Customer customer = new Customer();
                customer.customerName = txtName.Text;
                customer.phoneNumber = txtPhoneNumber.Text;
                customer.nationality = txtNationality.Text;
                customer.gender = txtGender.Text;
                customer.dob = txtDateofBirth.Text;
                customer.address = txtAddress.Text;
                customer.checkin = txtCheckin.Text;
                customer.roomId = rId;
                bc.setData(customer, txtRoomNumber.Text);
                clearAll();
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
