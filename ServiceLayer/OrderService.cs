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
        public Order GetOrderForSpecificTableWhichisNotPaidYet(Order order)
        {

            return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(order);

        }
        public List<Order> GetAllStarters(Order order)
        {
          return  orderdb.GetAllStarters();
        }
        public List<Order> GetAllMainCourse(Order order)
        {
            return orderdb.GetAllStarters();
        }
        public List<Order> GetAllDessert(Order order)
        {
            return orderdb.GetAllStarters();
        }
        /*public void AddToOrder(Order order)
        {
            oderdb.AddToOrder(order);
        }
        public void RemoveToOrder(Order order)  
        {
            oderdb.AddToOrder(order);
        }
        */
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
        public List<Order> ReadOrdersForKitchenBar(TypeMenuItem menuItem, OrderState orderState)
        {
            return orderdb.GetAllOrderForKitchenAndBar(menuItem,orderState);
        }
        public void UpdateOrderStatusReadyToDeliver(int orderItemId, OrderState orderState)
        {
            orderdb.UpdateOrderStatusReadyToDeliver(orderItemId, orderState);
        }
    }
}
