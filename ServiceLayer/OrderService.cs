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
        public void GetIdFromUnpaied(List<OrderItem> list, Table TableNr)
        {
            orderdb.GetIdFromUnpaied(list, TableNr);
        }
        public List<MenuItem> GetAllStarters(MenuItemCategory category)
        {
            return orderdb.GetAllStarters(category);
        }
        public void RemoveFromOrder(OrderItem order)
        {
            orderdb.RemoveFromOrder(order);
        }
        public void AddToOrderItem(OrderItem item)
        {
             orderdb.AddToOrderItems(item);
        }

        public Order SearchByID(int ID)
        {
            return orderdb.SearchByID(ID);
        }
        public void UpdateStatusOfSpecficOrderItem(OrderItem orderItem)
        {
            orderdb.UpdateStatusOfSpecficOrderItem(orderItem);
        }

        public List<Order> ReadOrdersForKitchenBar(TypeMenuItem menuItem, OrderItemState orderItemState)
        {
            return orderdb.GetAllOrderForKitchenAndBar(menuItem, orderItemState);
        }

        public List<OrderItem> ListOfOrderItemsInSelectedTable(Table selectedTable, PayementStatus payementStatus)
        {
           return orderdb.ListOfOrderItemsInSelectedTable(selectedTable, payementStatus);
        }

    }
}
