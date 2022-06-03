using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class OrderDAO : BaseDAO
    {          //Getting the list of orderItem having the same order
        public List<OrderItem> ListOfOrderItemsInOneOrder(int OrderId)
        {
            string query = "Select O.OrderItemId,O.OrderStatus,o.Feedback,o.Quantity,o.OrderItemDateTime,M.ItemId,M.[Name],M.Price,M.ItemType,M.ItemCategory From [OrderItem] As [O] "
                + " JOIN [Menu_Item] As [M] on M.ItemID= O.MenuItemId "
                + " Where O.OrderId= @Id ";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", OrderId);
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        } 

        private List<OrderItem> ReadingTableForOrderItemsList(DataTable dataTable)
        {
            List<OrderItem> list = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item= new OrderItem();
                item.OrderItemId = (int)dr["OrderItemId"];
                item.OrderState = (OrderState)dr["OrderStatus"];
                item.Feedback = (string)dr["Feedback"];
                item.Quantity = (int)dr["Quantity"];
                item.DateTime = (DateTime)dr["OrderItemDateTime"];
                item.MenuItem.ItemId = (int)dr["ItemId"];
                item.MenuItem.Name = (string)dr["Name"];
                item.MenuItem.Price = (decimal)dr["Price"];
                item.MenuItem.Category = (MenuItemCategory)dr["ItemCategory"];
                list.Add(item); 
            }
            return list;    
        }

        // 
        public Order GetOrderForSpecificTableWhichisNotPaidYet(Order order)
        {
            string query = "Select O.OrderID,T.TableNr,T.[Status],O.[Date],o.[Time],o.PayementStatus,o.TotalPrice  From [Order] AS O "
                + " join [Table] as T On O.TableNr=T.TableNr " + " where O.TableNr=@TableNr AND o.PayementStatus=@PayementStatus ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@TableNr", order.Table.Number);
            sqlParameters[1]=new SqlParameter("@PayementStatus", (int)order.PayementStatus);
            return ReadingOrderofSpecificTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private Order ReadingOrderofSpecificTable(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                order.OrderId = (int)dr["OrderID"];
                order.Time = Convert.ToDateTime(dr["Time"].ToString());
                order.Table.Number = (int)dr["TableNr"];
                order.Table.Status = (TableStatus)dr["Status"];
                order.PayementStatus = (PayementStatus)dr["PayementStatus"];
                order.TotalPrice = (decimal)dr["TotalPrice"];
                order.OrderItems = ListOfOrderItemsInOneOrder(order.OrderId);
            }
            return order;
        }


        public Order GetOrder(int tableNr, int orderNumber)
        {
            string query = "Select  [Order].OrderID, [Order].[Date], [Order].[Time], [Table].TableNr, [Table].[Status], [Order].Feedback from [Order] Join [Table] on [Order].TableNr=[Table].TableNr WHERE [Order].OrderID=@OrderId ANd [Table].TableNr=@TableNR";
            SqlParameter[] sqlParamenters = new SqlParameter[2];
            sqlParamenters[0] = new SqlParameter("@OrderId", orderNumber);
            sqlParamenters[1] = new SqlParameter("@TableNR", tableNr);
            return ReadTable(ExecuteSelectQuery(query, sqlParamenters));
        }
        private Order ReadTable(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                order.OrderId = (int)dr["OrderID"];
                order.Time = (DateTime)dr["Time"];
                order.Table.Number = (int)dr["TableNr"];
                order.Table.Status = (TableStatus)dr["Status"];
                order.Feedback = (string)dr["Feedback"];
            }
            return order;
        }
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
                //new SqlParameter("@StudentNumber", order.Name),
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
                //    Name = (string)dr["name"],
                //    Price = (double)dr["price"],
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
        public void EditOrder(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Execute query
            ExecuteEditQuery(query, sqlParameters);
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

        // Getting all the orders for kitchenAndBar
        public List<OrderItem> GetAllRunningOrder(TypeMenuItem menuItem, OrderState orderState, int orderId)
        {
            string query = "SELECT o.OrderItemId, o.OrderId, o.OrderStatus, o.Feedback, o.Quantity, o.OrderItemDateTime, m.Name, m.Price, m.ItemCategory, m.ItemId From OrderItem As O join Menu_Item As[M] on O.MenuItemId = M.ItemID"
            + " Where M.ItemType = @itemType AND o.OrderStatus = @orderState AND OrderId = @orderId";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@itemType", (int)menuItem);
            sqlParameters[1] = new SqlParameter("@orderState", (int)orderState);
            sqlParameters[2] = new SqlParameter("@orderId", orderId);
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetAllOrderForKitchenAndBar(TypeMenuItem menuItem, OrderState orderState)
        {
            string query = "SELECT o.OrderID, o.TableNr, o.Time, o.PayementStatus,t.Status, o.Date From [Order] As o Join [Table] As T On o.tableNr = T.TableNr where o.PayementStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
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
                order.OrderItems = GetAllRunningOrder( menuItem, orderState, order.OrderId);
                orders.Add(order);
            }
            return orders;
        }

        //update the order status from Preparing to ReadyToDeliver
        public void UpdateOrderStatusReadyToDeliver(int orderItemId)
        {
            string query = $@"update OrderItem SET OrderStatus = {(int)OrderState.ReadyToDeliver}
                WHERE OrderItemId = @orderItemId";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderItemId", orderItemId);

            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
