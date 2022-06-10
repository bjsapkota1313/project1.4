using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Order
    {
        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; set; }
         public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Table Table { get; set; }
        public PayementStatus PayementStatus { get; set; }
        public string Feedback { get; set; }
        public Order()
        {
           // when ever order is not paid , new table and orderitem is restted
            Table = new Table();
            OrderItems = new List<OrderItem>();
        }
        public Order( List<OrderItem> OrderItems, int OrderId, DateTime Time, Table Table, PayementStatus PayementStatus, string Feedback)
        {
            this.OrderItems = OrderItems;
            this.OrderId = OrderId;
            this.Time = Time;
            this.Table = Table;
            this.PayementStatus = PayementStatus;
            this.Feedback = Feedback;    
        }
    }

    public enum PayementStatus
    {
        UnPaid=0,Paid
    }
}
