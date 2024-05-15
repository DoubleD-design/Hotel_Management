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
    public partial class UC_CustomerDetail : UserControl
    {
        BSCustomer bc = new BSCustomer();
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }
        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                DataSet ds = bc.getAllCustomer();
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearch.SelectedIndex == 1)
            {
                DataSet ds = bc.getInHotelCustomer();
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearch.SelectedIndex == 2)
            {
                DataSet ds = bc.getCheckoutCustomer();
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
