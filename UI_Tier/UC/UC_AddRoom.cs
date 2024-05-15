using Connector_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Tier;
using Model;
using Guna.UI2.WinForms;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace UI_Tier
{
    public partial class UC_AddRoom : UserControl
    {
        BSRoom br = new BSRoom();
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            DataSet ds = br.getAllData();
            RoomGridView.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != null)
            {
                Room room = new Room();
                room.roomNo = int.Parse(txtRoomNo.Text);
                room.roomType = txtRoomType.Text;
                room.bedType = txtBed.Text;
                room.price = long.Parse(txtPrice.Text);
                if (br.isRoomNoExists(room) == false)
                {
                    br.setData(room);
                    UC_AddRoom_Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Room Number exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                Room room = new Room();
                room.roomNo = int.Parse(txtRoomNo.Text);
                br.DeleteData(room);
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No selected room", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RoomGridView.Rows[e.RowIndex].Cells[1] != null)
            {
                txtRoomNo.Text = RoomGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomType.Text = RoomGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBed.Text = RoomGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrice.Text = RoomGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Index out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                Room room = new Room();
                room.roomNo = int.Parse(txtRoomNo.Text);
                br.DisableRoom(room);
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No selected room", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                Room room = new Room();
                room.roomNo = int.Parse(txtRoomNo.Text);
                br.EnableRoom(room);
                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("No selected room", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
