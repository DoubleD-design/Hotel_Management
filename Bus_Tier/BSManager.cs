using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Connector_Tier;

namespace Bus_Tier
{
    public class BSManager
    {
        ConnectorFactory conn = new ConnectorFactory();
        public void addManager(Manager manager)
        {
            String managerId = manager.managerId + "";
            String managerName = manager.managerName;
            String sql = "INSERT INTO manager (managerId, managerName) VALUES (" + managerId + ", '" + managerName + "');";
            conn.setData(sql);
        }
    }
}
