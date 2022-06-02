using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Order
    {
        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Table Table { get; set; }
        public PayementStatus PayementStatus { get; set; }  
        public Order()
        {
           // when ever order is not paid , new table and orderitem is restted
            Table = new Table();
            OrderItems = new List<OrderItem>();
        }
    }
    public enum PayementStatus
    {
        UnPaid=0,Paid
    }
}
