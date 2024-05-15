using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Connector_Tier;
using System.Data;

namespace Bus_Tier
{
    public class BSEmployee
    {
        ConnectorFactory conn = new ConnectorFactory();

        public void AddEmployee(Employee employee)
        {
            String employeeId = employee.employeeId + "";
            String employeeName = employee.employeeName;
            String phoneNumber = employee.phoneNumber;
            String email = employee.email;
            String gender = employee.gender;
            String address = employee.address;
            String sql = "INSERT INTO employee (employeeId, employeeName, phoneNumber, email, gender, address) VALUES ('" + employeeId + "', '" + employeeName + "', '" + phoneNumber + "', '" + email + "', '" + gender + "', '" + address + "');";
            conn.setData(sql);
        }

        public DataSet GetData()
        {
            String sql = "SELECT * FROM employee";
            return conn.getData(sql);
        }

        public void deleteData(Employee employee)
        {
            int eid = employee.employeeId;
            String sql = "DELETE FROM employee WHERE employeeId = '" + eid + "'";
            conn.setData(sql);
        }

    }
}
