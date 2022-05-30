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
        public List<Order> GetAllStarters()
        {
            string query = "Select Name,Price from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public List<Order> GetAllMainCourse()
        {
            string query = "Select Name,Price from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public List<Order> GetAllDessert()
        {
            string query = "Select Name,Price from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public void AddToOrder(Order order)
        {
            string query = "INSERT INTO Order VALUES (@StudentNumber);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StudentNumber", order.Name),
            };

            ExecuteEditQuery(query, parameters);
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Name = (string)dr["name"],
                    Price = (double)dr["price"],
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
            //order.OrderId = (int)row["OrderID"];
           // order.Time = (DateTime)row["Time"];
           // order.Table = (Table)row["Table"];
           // order.MenuItem = (MenuItem)row["MenuItem"];

            return order;
        }
    }
}
