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
<<<<<<< Updated upstream
        public List<Order> GetStarters()
=======
        public Order GetOrderForSpecificTableWhichisNotPaidYet(Order order)
        {

            return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(order);

        }
        public List<MenuItem> GetAllStarters(MenuItemCategory category)
>>>>>>> Stashed changes
        {
            return orderdb.GetAllStarters(category);
        }
        public void AddToOrder(Order order)
        {
            orderdb.AddToOrder(order);
        }
        public void RemoveToOrder(Order order)  
        {
            orderdb.RemoveOrder(order);
        }
        
        public Order SearchByID(int ID)
        {
           return orderdb.SearchByID(ID);
        }
    }
}
