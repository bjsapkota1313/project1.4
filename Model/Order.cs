﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Table Table { get; set; }
    }
}
