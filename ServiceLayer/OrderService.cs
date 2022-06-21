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

        public List<OrderItem> GetOrderTableNotPayed(Table table)
        {
            return orderdb.GetOrderTableNotPayed(table);
        }

        /* public Order GetOrderForSpecificTableWhichisNotPaidYet(Order order)

         {

             return orderdb.GetOrderForSpecificTableWhichisNotPaidYet(order);

         }*/
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
            return orderdb.GetAllOrdersByTableNumber(menuItem, orderState);
        }
        public List<OrderItem> ListOfOrderItemsInSelectedTable(Table selectedTable, PayementStatus payementStatus)
        {
            return orderdb.ListOfOrderItemsInSelectedTable(selectedTable, payementStatus);
        }
        //public Order GetOrderID(int tableNr)
        //{
        //    return orderdb.GetOrderID(tableNr);
        //}
        public void AddFeedback(int id, string feedback)
        {
             orderdb.AddFeedback(id, feedback);
        }
        public List<OrderItem> GetBill(int OrderId)
        {
            return orderdb.GetBill(OrderId);
        }
        public List<Order> GetOrderByTableNumber(int tableNr)
        {
            return orderdb.GetOrderByTableNumber(tableNr);
        }
        public void ChangeOrderPaymentStatus(int id)
        {
            orderdb.ChangeOrderPaymentStatus(id);
        }

    }
}

