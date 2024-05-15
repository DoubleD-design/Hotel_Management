using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Connector_Tier
{
    public class ConnectorFactory
    {
        

        public ConnectorFactory(){}

        public MySqlConnection getConnection()
        {
            string strConn = @"SERVER=localhost; DATABASE=hotel_management; UID=root";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = strConn;
            return conn;
        }

        public DataSet getData(String query)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand sql = new MySqlCommand();
            sql.Connection = conn;
            sql.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query)
        {
            MySqlConnection connection = getConnection();
            MySqlCommand sql = new MySqlCommand();
            sql.Connection= connection;
            connection.Open();
            sql.CommandText = query;
            sql.ExecuteNonQuery();
            connection.Close();
        }

        public MySqlDataReader GetForCombo(String query) 
        {
            MySqlConnection conn = getConnection();
            MySqlCommand sql = new MySqlCommand();
            sql.Connection = conn;
            conn.Open();
            sql.CommandText = query;
            MySqlDataReader dr = sql.ExecuteReader();
            return dr;
        }
    }
}
