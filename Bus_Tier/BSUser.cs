using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Connector_Tier;
using System.Data;
using Org.BouncyCastle.Crypto.Generators;

namespace Bus_Tier
{
    public class BSUser
    {
        ConnectorFactory conn = new ConnectorFactory();

        // Mã hóa mật khẩu khi đăng ký
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Kiểm tra mật khẩu khi đăng nhập
        public bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
        }

        public void AddUser(User user)
        {
            String email = user.email;
            String password = HashPassword(user.password);
            String role = user.role + "";
            String sql = "INSERT INTO user (email, password, isManager) VALUES ('" + email + "', '" + password + "', '" + role + "');";
            conn.setData(sql);
        }
        public int getID(String email)
        {
            String sql = "SELECT userId FROM user WHERE email = '" + email + "'";
            return Convert.ToInt32(conn.getData(sql).Tables[0].Rows[0][0]);
        }
        public void deleteData(User user)
        {
            int uid = user.userId;
            String sql = "DELETE FROM user WHERE userId = '" + uid + "'";
            conn.setData(sql);
        }
        public int getLastInsertId()
        {
            String sql = "SELECT LAST_INSERT_ID()";
            return Convert.ToInt32(conn.getData(sql).Tables[0].Rows[0][0]);
        }

        public User GetUserByEmail(string email)
        {
            String sql = "SELECT * FROM user WHERE email = '" + email + "'";
            DataSet ds = conn.getData(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                User user = new User();
                user.email = ds.Tables[0].Rows[0]["email"].ToString();
                user.password = ds.Tables[0].Rows[0]["password"].ToString(); // Đây là mật khẩu đã băm
                user.role = Convert.ToInt32(ds.Tables[0].Rows[0]["isManager"]);
                return user;
            }
        }

    }
}
