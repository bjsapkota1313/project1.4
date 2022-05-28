using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class OrderDAO : BaseDAO
    {
        public List<Order> GetAllOrders()
        {
            string query = "Select OrderID, Time, TableNr, ItemID from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderID"],
                    Time = (DateTime)dr["Time"],
                    Table = (Table)dr["Table"],
                    MenuItem = (MenuItem)dr["MenuItem"]
                };
            orders.Add(order);
            }
            return orders;
        }
        public Order SearchByID(int ID)
        {
            string query = "Select OrderID, Time, TableNr, ItemID from [Order] WHERE OrderID = @OrderID";
            SqlParameter[] sqlParamenters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", ID)
            };
            return ReadID(ExecuteSelectQuery(query, sqlParamenters));
        }

        private Order ReadID(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Order order = new Order();
            order.OrderId = (int)row["OrderID"];
            order.Time = (DateTime)row["Time"];
            order.Table = (Table)row["Table"];
            order.MenuItem = (MenuItem)row["MenuItem"];

            return order;
        }
    }
}
