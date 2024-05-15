using Connector_Tier;
using Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
namespace Bus_Tier
{
    public class BSRoom
    {
        ConnectorFactory conn = new ConnectorFactory();
        public DataSet getAllData()
        {
            String sql = "SELECT * FROM rooms";
            return conn.getData(sql);
        }

        public void setData(Room room)
        {
            String roomNo = room.roomNo+"";
            String roomType = room.roomType;
            String bedType = room.bedType;
            Int64 price = room.price;
            String sql = "INSERT INTO rooms (roomNo, roomType, bedType, price, bookStatus) VALUES ('" + roomNo + "', '" + roomType + "', '" + bedType + "', " + price + ", 'NO');";
            conn.setData(sql);
        }

        public MySqlDataReader getRoomNo(Room room)
        {
            String roomType = room.roomType;
            String bedType = room.bedType;
            String sql = "SELECT roomNo FROM rooms WHERE roomType = '" + roomType + "' AND bedType = '" + bedType + "' AND bookStatus = 'NO' AND isAvailable = 'YES'";
            return conn.GetForCombo(sql);
        }

        public DataSet getPriceAndID(Room room)
        {
            String roomNo = room.roomNo.ToString();
            String sql = "SELECT price, roomId FROM rooms WHERE roomNo = '" + roomNo + "'";
            return conn.getData(sql);
        }

        public void DeleteData(Room room)
        {
            string sql = "DELETE FROM rooms WHERE roomNo = '" + room.roomNo + "'";
            conn.setData(sql);
        }
        public void DisableRoom(Room room)
        {
            String sql = "UPDATE rooms SET isAvailable = 'NO' WHERE roomNo = '" + room.roomNo + "'";
            conn.setData(sql);
        }

        public void EnableRoom(Room room)
        {
            String sql = "UPDATE rooms SET isAvailable = 'YES' WHERE roomNo = '" + room.roomNo + "'";
            conn.setData(sql);
        }

        public bool isRoomNoExists(Room room)
        {
            String sql = "SELECT COUNT(*) FROM Rooms WHERE RoomNo = '" + room.roomNo + "'";
            int count = Convert.ToInt32(conn.getData(sql).Tables[0].Rows[0][0]);
            return count > 0;
        }
    }
}
