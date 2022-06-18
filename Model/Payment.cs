using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Payment
    {
        public int Id { get; set; } 
        public PaymentType Type { get; set; } 
        public Bill Bill { get; set; }
        public string Feedback { get; set; }    
        public bool PaymentStatus { get; set; }
        public decimal Tip { get; set; }    
        public decimal Total { get; set; }   
    }
}
