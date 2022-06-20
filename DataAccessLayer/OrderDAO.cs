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
        public void GetIdFromUnpaied(List<OrderItem> list, Table TableNr)
        {
            string query = "Select OrderID From [Order] WHERE TableNr = @TableNr AND PaymentStatus = 0;";


            SqlParameter[] sqlParameters = new SqlParameter[0];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@TableNr", TableNr);

            int orderId = RunningOrder(ExecuteSelectQuery(query, sqlParameters));
            // if order id is not 0 add to orderid else create a new order
            if (orderId != 0)
            {
                AddToExisting(list, orderId);
            }
            else
            {
                AddNew(list, orderId);
            }


        }
        private int RunningOrder(DataTable dataTable)
        {
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    return int.Parse(dataTable.Rows[0]["OrderID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Error");
            }
        }
        private void AddToExisting(List<OrderItem> orderItems, int orderID)
        {
            foreach (OrderItem item in orderItems)
            {
                string query = "If EXISTS (SELECT * FROM OrderItem WHERE OrderId = @OrderId AND MenuItemId = @MenuItemId) UPDATE OrderItem SET Quantity = Quantity + @Quantity WHERE OrderId = @OrderId AND MenuItemId = @MenuItemId ELSE INSERT INTO OrderItem(OrderId, MenuItemId, OrderItemDateTime, Feedback) VALUES(@OrderId, @MenuItemId, @datetime, @feedback); ";

                SqlParameter[] sqlParameters = {new SqlParameter("@OrderID", orderID),
                    new SqlParameter("MenuItemId", item.OrderItemId),
                    new SqlParameter("@Quantity", item.Quantity),
                    new SqlParameter("@datetime", DateTime.Now),
                    new SqlParameter("@feedback", item.Feedback)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        private void AddNew(List<OrderItem> orderItem, int TableNr)
        {
            string query = "INSERT INTO [Order] (TableNr) VALUES (@TableNr)";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@TableNr", TableNr)
            };
            ExecuteEditQuery(query, sqlParameters);

            int highestID = GetHighId();

            foreach (OrderItem item in orderItem)
            {
                string query2 = "INSERT INTO OrderItem (OrderId, MenuItemId, OrderItemDateTime,Feedback) VALUES (@HighOrderId, @MenuItemId, @datetime,@feedback)";

                SqlParameter[] sqlParameters1 =
                {
                    new SqlParameter("@HighOrderId",highestID ),
                    new SqlParameter(" @MenuItemId", item.OrderItemId),
                    new SqlParameter("@datetime",DateTime.Now),
                    new SqlParameter("@feedback",item.Feedback)
                };
                ExecuteEditQuery(query2, sqlParameters1);
            }

        }
        private int GetHighId()
        {
            string query = "SELECT MAX(OrderId) AS 'MAXID' from [Order]";
            return ReadHighestID(ExecuteSelectQuery(query, new SqlParameter[0]));
        }
        private int ReadHighestID(DataTable dataTable)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return int.Parse(dataTable.Rows[0]["MAXID"].ToString());
            }
            else
            {
                return 0;
            }
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
        public Order GetOrderForSpecificTableWhichisNotPaidYet(int tableNr, PayementStatus payementStatus)
        {
            string query = "Select O.OrderID,T.TableNr,T.[Status],O.[Date],o.[Time],o.PayementStatus  From [Order] AS O "
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

                order.OrderItems = ListOfOrderItemsInOneOrder(order.OrderId);
            }
            return order;
        }

        private List<OrderItem> ReadingTableForOrderItemsList(DataTable dataTable)
        {
            List<OrderItem> list = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem();
                item.OrderItemId = (int)dr["OrderItemId"];
                item.OrderState = (OrderState)dr["OrderStatus"];
                item.Feedback = (string)dr["Feedback"];
                item.Quantity = (int)dr["Quantity"];
                item.DateTime = (DateTime)dr["OrderItemDateTime"];
                item.MenuItem.ItemId = (int)dr["ItemId"];
                item.MenuItem.Name = (string)dr["Name"];
                item.MenuItem.Price = (decimal)dr["Price"];
                item.MenuItem.Category = (MenuItemCategory)dr["ItemCategory"];
                item.MenuItem.TypeMenuItem = (TypeMenuItem)dr["ItemType"];
                list.Add(item);
            }
            return list;
        }
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
            OrderItem item = new OrderItem();
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
            string query = "Select Name,ItemId,Price from [Menu_Item] WHERE ItemCategory = @itemCategory;";
            SqlParameter[] sqlParamenters = new SqlParameter[1];
            sqlParamenters[0] = new SqlParameter("@itemCategory", (int)category);
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }
        public void AddToOrderItems(OrderItem item)
        {
            string query = " INSERT into [OrderItem] (OrderStatus,Feedback,Quantity,OrderItemDateTime) values (@OrderStatus,'@Feedback','@Quantity','@Time');";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderStatus",item.OrderState),
                new SqlParameter("@Feedback",item.Feedback),
                 new SqlParameter("@Quantity",item.Quantity),
                new SqlParameter("@Time", item.DateTime)
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
            parameters[1] = new SqlParameter("OrderStatus", (int)orderItem.OrderState);
            ExecuteEditQuery(query, parameters);
        }


        // Getting all the orders for kitchenAndBar
        public List<OrderItem> GetAllRunningOrder(TypeMenuItem menuItem, OrderState orderState, int orderId)
        {
            string query = "SELECT o.OrderItemId, o.OrderId, o.OrderStatus, o.Feedback, o.Quantity, o.OrderItemDateTime, m.Name, m.Price, m.ItemCategory, m.ItemId,m.ItemType From OrderItem As O join Menu_Item As[M] on O.MenuItemId = M.ItemID"
            + " Where M.ItemType = @itemType AND o.OrderStatus = @orderState AND OrderId = @orderId";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@itemType", (int)menuItem);
            sqlParameters[1] = new SqlParameter("@orderState", (int)orderState);
            sqlParameters[2] = new SqlParameter("@orderId", orderId);
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetAllOrdersByTableNumber(TypeMenuItem menuItem, OrderState orderState)
        {
            string query = "SELECT o.OrderID, o.TableNr, o.Time, o.PayementStatus,t.Status, o.Date From [Order] As o Join [Table] As T On o.tableNr = T.TableNr where o.PayementStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrdersForKitchenBar(ExecuteSelectQuery(query, sqlParameters), menuItem, orderState);
        }
        private List<Order> ReadOrdersForKitchenBar(DataTable dataTable, TypeMenuItem menuItem, OrderState orderState)
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
                order.OrderItems = GetAllRunningOrder(menuItem, orderState, order.OrderId);
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
        public List<OrderItem> ListOfOrderItemsInSelectedTable(Table selectedTable, PayementStatus payementStatus)
        {
            // arranding it so that ready to deliver order doesnot get missed 
            string query = "Select O.OrderItemId,O.OrderStatus,o.Feedback,o.Quantity,o.OrderItemDateTime,M.ItemId,M.[Name],M.Price, M.ItemType,M.ItemCategory "
                + " From [OrderItem] AS o" + " join [Order] AS Ord on o.OrderId=ord.OrderID"
                + "  join [Table] As Tab on Ord.TableNr=Tab.TableNr" + " join [Menu_Item] As M on o.MenuItemId= M.ItemID"
                + " WHERE Tab.TableNr = @Table AND ord.PayementStatus = @PayementStatus"
                + " ORDER BY o.OrderStatus DESC";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Table", selectedTable.Number);
            sqlParameters[1] = new SqlParameter("@PayementStatus", payementStatus);

            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }
        //public Order GetOrderID(int tableNr)
        //{
        //    string query = $"SELECT OrderID, TableNr WHERE TableNr = '{tableNr}'";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];

        //    // Preventing SQL from injections
        //    return ReadingOrderofSpecificTable(ExecuteSelectQuery(query, sqlParameters));
        //}
        public Order GetOrderByTableNumber(int tableNr)
        {
            string query = $"SELECT O.OrderID FROM [Order] AS O INNER JOIN [Table] AS T ON T.TableNr = O.TableNr WHERE PayementStatus = '0' AND O.TableNr = '{tableNr}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadOrdersForUnpaidOrder(ExecuteSelectQuery(query, sqlParameters));
        }
        //Updating the feedback of an order
        public void AddFeedback(int id, string feedback)
        {
            string query = $"UPDATE [Order] SET Feedback = '{feedback}' WHERE OrderID = '{id}'";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Execute query
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ChangeOrderPaymentStatus(int id)
        {
            string query = $"UPDATE [Order] SET PayementStatus = '1' WHERE OrderID = '{id}'; ";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Execute query
            ExecuteEditQuery(query, sqlParameters);
        }



        //Getting the bill of an order
        public List<OrderItem> GetBill(int OrderId)
        {
            string query = $"SELECT O.OrderId, O.Quantity,M.[Name],M.Price, M.VAT FROM OrderItem AS O INNER JOIN Menu_Item AS M ON M.ItemID = O.MenuItemId WHERE O.OrderId = '{OrderId}'";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Preventing SQL from injections
            return ReadingTableForBill(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadingTableForBill(DataTable dataTable)
        {
            List<OrderItem> list = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem();
                item.OrderID = (int)dr["OrderId"];
                item.Quantity = (int)dr["Quantity"];
                item.MenuItem.Name = (string)dr["Name"];
                item.MenuItem.Price = (decimal)dr["Price"];
                item.MenuItem.VAT = (decimal)dr["VAT"];
                list.Add(item);
            }
            return list;
        }
        private Order ReadOrdersForUnpaidOrder(DataTable dataTable)
        {
            Order orders = new Order();
            
            if(dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Order order = new Order();

                    order.OrderId = (int)dr["OrderID"];
                    //order.Table.Number = (int)dr["TableNr"];
                    //order.PayementStatus = (PayementStatus)dr["PayementStatus"];
                }               
            }
            return orders;
        }
           

    }
}
