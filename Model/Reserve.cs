using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Reserve
    {
        public Guest Guest { get; set; }
        public Table Table { get; set; }
        public DateTime DateTime { get; set; }

    }
}
