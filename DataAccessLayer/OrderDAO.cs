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

        // Getting all the orders for kitchenAndBar
        public List<OrderItem> GetAllRunningOrder(TypeMenuItem menuItem, OrderState orderState, int orderId)
        {
            string query = "SELECT o.OrderItemId, o.OrderId, o.OrderStatus, o.Feedback, o.Quantity, o.OrderItemDateTime, m.Name From OrderItem As O join Menu_Item As[M] on O.MenuItemId = M.ItemID"
            + "Where M.ItemType = @itemType AND o.OrderStatus = @orderState AND OrderId = @orderId";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@itemType", (int)menuItem);
            sqlParameters[1] = new SqlParameter("@orderState", (int)orderState);
            sqlParameters[2] = new SqlParameter("@orderId", orderId);
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetAllOrderForKitchenAndBar(TypeMenuItem menuItem, OrderState orderState)
        {
            string query = "SELECT o.OrderID, o.TableNr, o.Time, o.Date From [Order] As o Join [Table] As T On o.tableNr = T.TableNr where o.PayementStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            return ReadOrdersForKitchenBar(ExecuteSelectQuery(query, sqlParameters),menuItem,orderState);
        }
        private List<Order> ReadOrdersForKitchenBar (DataTable dataTable, TypeMenuItem menuItem, OrderState orderState)
        {
          List<Order> orders = new List<Order>();   
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)dr["OrderID"];
                order.Time = Convert.ToDateTime(dr["Time"].ToString());
                order.Table.Number = (int)dr["TableNr"];
                order.Table.Status = (TableStatus)dr["Status"];
                order.PayementStatus = (PayementStatus)dr["PayementStatus"];
                order.TotalPrice = (decimal)dr["TotalPrice"];
                order.OrderItems = GetAllRunningOrder( menuItem,  orderState, order.OrderId);
                orders.Add(order);
            }
            return orders;
        }


    }
}
