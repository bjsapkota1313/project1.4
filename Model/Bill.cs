using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bill
    {
   
        public int BillID { get; set; }
        public int OrderID { get; set; }
        public double Amount { get; set; }
        public double Tip { get; set; }
    }
}
