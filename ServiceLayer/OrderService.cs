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
        public Order GetOrderForSpecificTableWhichisNotPaidYet(int tablenr,PayementStatus payementStatus)
        {
            return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(tablenr,payementStatus);
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
        public List<OrderItem> ListOfOrderItemsInOneOrder(int OrderId)
        {
            return orderdb.ListOfOrderItemsInOneOrder(OrderId);
        }
       public void UpdateStatusOfSpecficOrderItem(OrderItem orderItem)
        {
            orderdb.UpdateStatusOfSpecficOrderItem(orderItem);
        }
    }
}
