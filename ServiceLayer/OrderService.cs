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
        OrderDAO orderDAO;
        public OrderService()
        {
           orderDAO = new OrderDAO();
        }
        public List<Order> GetAllOrder()
        {
            return orderDAO.GetAllOrder();
        }
        public Order SearchByID(int ID)
        {
            return orderDAO.SearchByID(ID);
        }
    }
}
