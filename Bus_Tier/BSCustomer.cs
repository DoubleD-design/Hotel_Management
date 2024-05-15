using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connector_Tier;
using Model;
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Crud;

namespace Bus_Tier
{
    public class BSCustomer
    {
        ConnectorFactory conn = new ConnectorFactory();
        public void setData(Customer customer, String roomNo)
        {
            string sql = "INSERT INTO customer (customerName, phoneNumber, nationality, gender, dob, idProof, address, checkin, roomId) VALUES ('" + customer.customerName + "', '" + customer.phoneNumber + "', '" + customer.nationality + "', '" + customer.gender + "', '" + customer.dob + "', '" + customer.idProof + "', '" + customer.address + "', '" + customer.checkin + "', '" + customer.roomId + "'); UPDATE rooms SET bookStatus = 'YES' WHERE roomNo = '" + roomNo + "';";
            conn.setData(sql);
        }
        public DataSet getDataAndRoom()
        {
            String sql = "SELECT customer.customerId, customer.customerName, customer.phoneNumber, customer.nationality, customer.gender, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bedType, rooms.price FROM customer INNER JOIN rooms ON customer.roomId = rooms.roomId WHERE customer.checkout = 'NO'";
            DataSet ds = conn.getData(sql);
            return ds;
        }
        public DataSet getDataByName(String name)
        { 
            String sql = "SELECT customer.customerId, customer.customerName, customer.phoneNumber, customer.nationality, customer.gender, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bedType, rooms.price FROM customer INNER JOIN rooms ON customer.roomId = rooms.roomId WHERE customer.customerName like '" + name + "%' and checkout = 'NO'";
            return conn.getData(sql);
        }

        public void setData(String date, int cid,int rNo)
        {
            String sql = "UPDATE customer SET checkout = 'YES', checkoutDate = '" + date + "' WHERE customerId = '" + cid + "'";
            conn.setData(sql);
            String sql1 = "UPDATE rooms SET bookStatus = 'NO' WHERE roomNo = '" + rNo + "'";
            conn.setData(sql1);
        }
        public DataSet getAllCustomer()
        {
            String sql = "SELECT customer.customerId, customer.customerName, customer.phoneNumber, customer.nationality, customer.gender, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bedType, rooms.price, customer.checkout FROM customer INNER JOIN rooms ON customer.roomId = rooms.roomId";
            return conn.getData(sql);
        }
        public DataSet getInHotelCustomer()
        {
            String sql = "SELECT customer.customerId, customer.customerName, customer.phoneNumber, customer.nationality, customer.gender, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bedType, rooms.price, customer.checkout FROM customer INNER JOIN rooms ON customer.roomId = rooms.roomId WHERE customer.checkout = 'NO'";
            return conn.getData(sql);
        }
        public DataSet getCheckoutCustomer()
        {
            String sql = "SELECT customer.customerId, customer.customerName, customer.phoneNumber, customer.nationality, customer.gender, customer.dob, customer.idProof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bedType, rooms.price, customer.checkout FROM customer INNER JOIN rooms ON customer.roomId = rooms.roomId WHERE customer.checkout = 'YES'";
            return conn.getData(sql);
        }
    }
}
