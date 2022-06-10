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
                + " Where O.OrderId= @Id " + " ORDER BY o.OrderStatus DESC";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", OrderId);
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetOrderTableNotPayed(Table table)
        {
            string query = "Select  [OrderItem].OrderID,[Menu_Item].[Name], [Order].[Time], [OrderItem].OrderStatus, [OrderItem].Feedback from [Order] Join [Table] on [Order].TableNr=[Table].TableNr Join [OrderItem] ON [Order].OrderId = [OrderItem].OrderId join Menu_Item ON [OrderItem]. MenuItemId = [Menu_Item].ItemID WHERE [Order].PayementStatus=0 ANd [Table].TableNr=2;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@TableNr", table);
            return ReadingOrderofSpecificTableOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadingOrderofSpecificTableOrder(DataTable dataTable)
        {
            List<OrderItem> orderlist = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem order = new OrderItem();
                order.OrderItemId = (int)dr["OrderItemID"];
                order.MenuItem = (MenuItem)dr["MenuItem"];
                order.DateTime = Convert.ToDateTime(dr["Time"].ToString());
                order.OrderState = (OrderState)dr["OrderStatus"];
                order.Feedback = (string)dr["Feedback"];
                orderlist.Add(order);
            }
            return orderlist;
        }


        // getting order which is running on the table and accordinh to payement status
 

        public Order GetOrderForSpecificTableWhichisNotPaidYet(int tableNr, PayementStatus payementStatus)

        {
            string query = "Select O.OrderID,T.TableNr,T.[Status],O.[Date],o.[Time],o.PayementStatus,o.TotalPrice  From [Order] AS O "
                + " join [Table] as T On O.TableNr=T.TableNr " + " where O.TableNr=@TableNr AND o.PayementStatus=@PayementStatus ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@TableNr", tableNr);
            sqlParameters[1] = new SqlParameter("@PayementStatus", (int)payementStatus);
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
                item.MenuItem.TypeMenuItem=(TypeMenuItem)dr["ItemType"];
                list.Add(item); 
            }
            return list;    
        }

        // 


        public Order GetOrder(int tableNr)
        {
            string query = "Select  [OrderItem].OrderID,[Menu_Item].[Name], [Order].[Time], [Table].[Status], [OrderItem].Feedback from [Order] Join [Table] on [Order].TableNr=[Table].TableNr Join [OrderItem] ON [Order].OrderId = [OrderItem].OrderId join Menu_Item ON [OrderItem]. MenuItemId = [Menu_Item].ItemID WHERE [Order].PayementStatus=0 ANd [Table].TableNr=@TableNr;";
            SqlParameter[] sqlParamenters = new SqlParameter[2];
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
        public List<MenuItem> GetAllStarters(MenuItemCategory category)

        {
            string query = "Select Name,Price from [Menu_Item] WHERE ItemCategory = @itemCategory;";
            SqlParameter[] sqlParamenters = new SqlParameter[1];
            sqlParamenters[0] = new SqlParameter("@itemCategory", (int)category);
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem();
                item.Name = (string)dr["name"];

                item.Price = (decimal)dr["Price"];

                items.Add(item);
            }
            return items;
        }

        /* public List<Order> GetOrder()
         {

             string query = "Select Name,Price from [Order]";
             SqlParameter[] sqlParamenters = new SqlParameter[0];
             return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
         }*/
        /* public Order GetById(int tablenr)
         {
             string query = "Select Name,Price from [Order] WHERE student_number = tableNr";
             SqlParameter[] parameters = new SqlParameter[]
             {
                 new SqlParameter("@tableNr", tablenr)
             };
             return ReadRow(ExecuteSelectQuery(query, parameters));
         }*/

        public void AddToOrder(Table selectedtable, TimeoutException time, DateTime date)
        {
            string query = "INSERT into [Order] (TableNr,Date,Time,TotalPrice,PayementStatus,BillID) values (@TableNr,'@Date','@Time',0.00,0,Null);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TableNr", selectedtable),
                new SqlParameter("@Time", time),
                new SqlParameter("@Date", date),
            };

            ExecuteEditQuery(query, parameters);
        }

        public void RemoveFromOrder(OrderItem order)
        {
            string query = "Delete OrderItem FROM OrderItem INNER JOIN[Order] ON OrderItem.OrderId = [Order].OrderID WHERE [Order].OrderID = @ItemId AND OrderItem.OrderId = @ItemId;";
            SqlParameter[] parameters = new SqlParameter[]
            {

                new SqlParameter("@ItemId", order),
            };
            ExecuteEditQuery(query, parameters);
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
            order.Table = (Table)row["Table"];

            return order;
        }

        public void UpdateStatusOfSpecficOrderItem(OrderItem orderItem)
        {
            // updating the time whenever order item is updated 
            string query = "UPDATE [OrderItem] set OrderItemDateTime= GETDATE() AT TIME ZONE 'UTC' AT TIME ZONE 'Central European Standard Time' , OrderStatus=@OrderStatus " 
                + " WHERE orderItemId =@orderItemId";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@orderItemId", orderItem.OrderItemId);
            parameters[1] = new SqlParameter("OrderStatus",(int)orderItem.OrderState);
            ExecuteEditQuery(query, parameters);
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
