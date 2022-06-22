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

        public void GetIdFromUnpaied(List<OrderItem> list, Table TableNr)
        {
            // get the Order Id from table where order(s) have not beeen payed yet
            string query = "Select OrderID From [Order] WHERE TableNr = @TableNr AND PayementStatus = 0;";


            SqlParameter[] sqlParameters = new SqlParameter[1];
            // security sql layer
            sqlParameters[0] = new SqlParameter("@TableNr", TableNr.Number);

            int orderId = RunningOrder(ExecuteSelectQuery(query, sqlParameters));
            // if order id is not 0 add to orderid else create a new order
            if (orderId != 0)
            {
                AddToExisting(list, orderId);
            }
            else
            {
                AddNew(list, TableNr);
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
                // if exists add 1 to the quantity else insert new OrderItem
                string query = "If EXISTS (SELECT * FROM OrderItem WHERE OrderId = @OrderId AND MenuItemId = @MenuItemId) UPDATE OrderItem SET Quantity = Quantity + @Quantity WHERE OrderId = @OrderId AND MenuItemId = @MenuItemId ELSE INSERT INTO OrderItem(OrderId, MenuItemId, OrderItemDateTime, Feedback) VALUES(@OrderId, @MenuItemId, @datetime, @feedback); ";

                SqlParameter[] sqlParameters = {new SqlParameter("@OrderID", orderID),
                    new SqlParameter("MenuItemId", item.MenuItem.ItemId),
                    new SqlParameter("@Quantity", item.Quantity),
                    new SqlParameter("@datetime", DateTime.Now),
                    new SqlParameter("@feedback", item.Feedback)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        private void AddNew(List<OrderItem> orderItem, Table TableNr)// no order existing create new one and add into it
        {
            string query = "INSERT INTO [Order] (TableNr,Date,Time) VALUES (@TableNr,GETDATE() AT TIME ZONE 'UTC' AT TIME ZONE 'Central European Standard Time' ,GETDATE() AT TIME ZONE 'UTC' AT TIME ZONE 'Central European Standard Time' );";// add new

            SqlParameter[] sqlParameters = 
            {
                new SqlParameter("@TableNr", TableNr.Number),

            };
            ExecuteEditQuery(query, sqlParameters);

            int highestID = GetHighId();

            foreach (OrderItem item in orderItem)
            {
                string query2 = "INSERT INTO OrderItem (OrderId, MenuItemId,Feedback) VALUES (@HighOrderId, @MenuItemId,@feedback)";
                // insert into newly created order highest Id is the lastest created order which means all these vallues will be inserted into the newst order.

                SqlParameter[] sqlParameters1 =
                {
                    new SqlParameter("@HighOrderId",highestID ),
                    new SqlParameter("@MenuItemId", item.MenuItem.ItemId),
                    new SqlParameter("@feedback",item.Feedback)
                };
                ExecuteEditQuery(query2, sqlParameters1);
            }
        }
        private int GetHighId()// get the latest orderer created
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
        public List<OrderItem> GetOrderTableNotPayed(Table table)// dispaly the order(s) of the table which have not been paed yet which means the customer is still in the resaturant.
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
                order.OrderState = (OrderItemState)dr["OrderStatus"];
                order.Feedback = (string)dr["Feedback"];
                orderlist.Add(order);
            }
            return orderlist;
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
            string query = "Select Name,ItemId,Price,InStock from [Menu_Item] WHERE ItemCategory = @itemCategory AND InStock>0;";
            SqlParameter[] sqlParamenters = new SqlParameter[1];
            sqlParamenters[0] = new SqlParameter("@itemCategory", (int)category);
            return ReadTables(ExecuteSelectQuery(query, sqlParamenters));
        }

        public void AddToOrderItems(OrderItem item)
        {
            string query = " INSERT into [OrderItem] (OrderStatus,Feedback,Quantity,MenuItemId) values (@OrderStatus,@Feedback,@Quantity,@MenuItemID);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderStatus",(int)OrderItemState.RunningOrder),
                new SqlParameter("@Feedback",item.Feedback),
                 new SqlParameter("@Quantity",item.Quantity),
                new SqlParameter("@MenuItemID",item.MenuItem.ItemId)
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
                item.ItemId = (int)dr["ItemId"];
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

        // Getting all the orders for kitchenAndBar
        public List<Order> GetAllOrderForKitchenAndBar(TypeMenuItem menuItem, OrderItemState orderState)
        {
            string query = "SELECT o.OrderID, o.TableNr, o.Time, t.Status, o.Date From [Order] As o Join [Table] As T On o.tableNr = T.TableNr where o.PayementStatus = 0";

            return ReadOrdersForKitchenBar(ExecuteSelectQuery(query), menuItem, orderState);
        }

        //Read data to make order objects
        private List<Order> ReadOrdersForKitchenBar(DataTable dataTable, TypeMenuItem menuItem, OrderItemState orderItemState)
        {
            List<Order> orders = new List<Order>();

            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Order order = new Order();
                    order.OrderId = (int)dr["OrderID"];
                    order.Time = Convert.ToDateTime(dr["Time"].ToString());
                    order.Table.Number = (int)dr["TableNr"];
                    order.Table.Status = (TableStatus)dr["Status"];
                    //Retrieve order items
                    order.OrderItems = GetOrderItems(menuItem, orderItemState, order.OrderId);
                    orders.Add(order);
                }
            }
            
            return orders;
        }

        //Retrieve all order items for an order in specified orderstate
        public List<OrderItem> GetOrderItems(TypeMenuItem menuItem, OrderItemState orderItemState, int orderId)
        {
            string query = "SELECT o.OrderItemId, o.OrderId, o.OrderStatus, o.Feedback, o.Quantity, o.OrderItemDateTime, m.Name, m.Price, m.ItemCategory, m.ItemId,m.ItemType From OrderItem As O join Menu_Item As[M] on O.MenuItemId = M.ItemID"
            + " Where M.ItemType = @itemType AND o.OrderStatus = @orderState AND OrderId = @orderId";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@itemType", (int)menuItem);
            sqlParameters[1] = new SqlParameter("@orderState", (int)orderItemState);
            sqlParameters[2] = new SqlParameter("@orderId", orderId);
            
            return ReadingTableForOrderItemsList(ExecuteSelectQuery(query, sqlParameters));
        }

        //Read data for order items
        private List<OrderItem> ReadingTableForOrderItemsList(DataTable dataTable)
        {
            List<OrderItem> list = new List<OrderItem>();

            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    OrderItem item = new OrderItem();

                    item.OrderItemId = (int)dr["OrderItemId"];
                    item.OrderState = (OrderItemState)dr["OrderStatus"];
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
            }
            
            return list;
        }

        //Update status of one specific orderitem
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
        public List<Order> GetOrderByTableNumber(int tableNr)
        {
            string query = $"SELECT O.OrderID, T.TableNr FROM [Order] AS O INNER JOIN [Table] AS T ON T.TableNr = O.TableNr WHERE PayementStatus = '0' AND O.TableNr = '{tableNr}'";
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
        private List<Order> ReadOrdersForUnpaidOrder(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            
            if(dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Order order = new Order();

                    order.OrderId = (int)dr["OrderID"];
                    order.Table.Number = (int)dr["TableNr"];
                    orders.Add(order);
                    
                    //order.PayementStatus = (PayementStatus)dr["PayementStatus"];
                }               
            }
            return orders;
        }
           

    }
}
