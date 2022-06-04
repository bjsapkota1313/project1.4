using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Payment
    {
        public int Type { get; set; } 
        public Bill Bill { get; set; }
    }
}
