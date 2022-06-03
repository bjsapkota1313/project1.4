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
        public List<MenuItem> GetAllStarters()
        {
            string query = "Select Name,Price from [Menu_Item] WHERE ItemCatagory = 0;";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public List<MenuItem> GetAllMainCourse()
        {
            string query = "Select Name,Price from [Order] WHERE";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public List<MenuItem> GetAllDessert()
        {
            string query = "Select Name,Price from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public List<Order> GetOrder()
        {
            string query = "Select Name,Price from [Order]";
            SqlParameter[] sqlParamenters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public Order GetById(int tablenr)
        {
            string query = "Select Name,Price from [Order] WHERE student_number = tableNr";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tableNr", tablenr)
            };
            return ReadRow(ExecuteSelectQuery(query, parameters));
        }

        public void AddToOrder(Order order)
        {
            string query = "INSERT INTO Order VALUES @ItemId;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ItemId", order.MenuItem),
            };

            ExecuteEditQuery(query, parameters);
        }

        public void RemoveOrder(Order order)
        {
            string query = "Delete FROM  Order WHERE OrderID = @ItemId;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ItemId", order.Name),
            };

            ExecuteEditQuery(query, parameters);
        }


        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem();
                item.Name = (string)dr["name"];
                item.Price = (double)dr["price"];
               
            orders.Add(items);
            }
            return orders;
        }
        private Order ReadRow(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Order order = new Order();
            order.Name= (string)row["Name"];
            order.Table = (Table)row["Table"];
            order.MenuItem = (MenuItem)row["MenuItem"];

            return order;
        }

    }
}
