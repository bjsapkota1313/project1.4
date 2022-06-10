using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public class OrderService
    {
        OrderDAO orderdb;
        public OrderService()
        {
            orderdb = new OrderDAO();
        }

        public Order GetOrderForSpecificTableWhichisNotPaidYet(int tablenr, PayementStatus payementStatus)
        {

            return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(tablenr, payementStatus);
        }
       public List<OrderItem> GetOrderTableNotPayed(Table table)
        {
           return orderdb.GetOrderTableNotPayed(table);
        }

       /* public Order GetOrderForSpecificTableWhichisNotPaidYet(Order order)

        {

            return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(order);

        }*/
        public List<MenuItem> GetAllStarters(MenuItemCategory category)
        {
            return orderdb.GetAllStarters(category);
        }
        public void AddToOrder(Order order, string comment)
        {
            orderdb.AddToOrder(order);
        }
        public void RemoveFromOrder(OrderItem order)
        {
            orderdb.RemoveFromOrder(order);
        }

        public Order SearchByID(int ID)
        {
            return orderdb.SearchByID(ID);
        }
        public void AddFeedback(Order order)
        {
            //Create query
            string query = $"INSERT INTO Order(Feedback) VALUES '{order.Feedback}'";

            // Add Feedback to the database
            orderdb.EditOrder(query);

        }

        public List<OrderItem> ListOfOrderItemsInOneOrder(int OrderId)
        {
            return orderdb.ListOfOrderItemsInOneOrder(OrderId);
        }

        public void UpdateStatusOfSpecficOrderItem(OrderItem orderItem)
        {
            orderdb.UpdateStatusOfSpecficOrderItem(orderItem);
        }

        public List<Order> ReadOrdersForKitchenBar(TypeMenuItem menuItem, OrderState orderState)
        {
            return orderdb.GetAllOrderForKitchenAndBar(menuItem, orderState);
        }
        public void UpdateOrderStatusReadyToDeliver(int orderItemId)
        {
            orderdb.UpdateOrderStatusReadyToDeliver(orderItemId);

        }
    }
}
