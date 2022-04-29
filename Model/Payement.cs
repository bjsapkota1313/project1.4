using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Payement
    {
        public int PaymentID { get; set; } 
        public Bill Bill { get; set; }
    }
}
