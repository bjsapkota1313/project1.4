﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int OrderID { get; set; }    
        public int OrderItemId { get; set; }    
        public  MenuItem MenuItem { get; set; }
        public string Feedback { get; set; }    
        public int Quantity { get; set; }   
        public DateTime DateTime { get; set; }
        public OrderItemState OrderState { get; set; }
        
        public OrderItem()
        {
            MenuItem = new MenuItem();  
        }
        public OrderItem(int Quantity, MenuItem MenuItem, string Feedback)
        {
            this.Quantity = Quantity;
            this.MenuItem = MenuItem;
            this.Feedback = Feedback;
        }

    }
}
