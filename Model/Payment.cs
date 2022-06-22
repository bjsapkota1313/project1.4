using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Payment
    {
        public int BillID { get; set; } 
        public PaymentType Type { get; set; } 
        public Order Order { get; set; }
        public string Feedback { get; set; }    
        public bool PaymentStatus { get; set; }
        public decimal Tip { get; set; }    
        public decimal Total { get; set; }   
    }
}
