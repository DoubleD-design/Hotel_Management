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
    public partial class UC_Checkout : UserControl
    {
        BSCustomer bc = new BSCustomer();
        public UC_Checkout()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txtSearch.Clear();
            txtName.Clear();
            txtRoomNumber.Clear();
            txtCheckout.ResetText();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = bc.getDataByName(txtSearch.Text);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            DataSet ds = bc.getDataAndRoom();
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_Checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        int cid;
        int rNo;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex] != null)
            {
                cid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNumber.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String cdate = txtCheckout.Text;
                rNo = int.Parse(txtRoomNumber.Text);
                bc.setData(cdate, cid, rNo);
                UC_Checkout_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No selected customer", "Information", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }
    }
}
