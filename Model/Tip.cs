using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Tip
    {
        public Guest Guest { get; set; }
        public double Amount { get; set; }  
        public DateTime DateTime { get; set; }
    }
}
