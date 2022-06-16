using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int ItemId
        {
            get; set;
        }
        public decimal Price { get; set; } 
        public string Name { get; set; }
        public TypeMenuItem TypeMenuItem { get; set; }
        public MenuItemCategory Category { get; set; }  
        public decimal VAT { get; set; }
        public List<OrderItem> orderItems;

        public decimal OrderPrice
        {
            get
            {
                orderItems = new List<OrderItem>();
                decimal orderPrice = 0;
                foreach (OrderItem item in orderItems)
                {
                    orderPrice += Price * item.Quantity;
                }
                return orderPrice;
            }

        }
        public decimal HighVAT
        {
            
            get
            {
                orderItems = new List<OrderItem>();
                decimal highlVat = 0;
                foreach (OrderItem item in orderItems)
                {
                    if(item.MenuItem.VAT == (decimal)0.21)
                    {
                        highlVat += (Price * (decimal)0.21) * item.Quantity;
                    }
                }
                return highlVat;
            }
        }
        public decimal LowVAT
        {

            get
            {
                orderItems = new List<OrderItem>();
                decimal lowVat = 0;
                foreach (OrderItem item in orderItems)
                {
                    if (item.MenuItem.VAT == (decimal)0.06)
                    {
                        lowVat += (Price * (decimal)0.06) * item.Quantity;
                    }
                }
                return lowVat;
            }
        }
        public decimal TotalVAT
        {
            get
            {
                orderItems = new List<OrderItem>();
                decimal totalVat = 0;
                foreach (OrderItem item in orderItems)
                {
                    totalVat += Price * VAT * item.Quantity;
                }
                return totalVat;
            }
        }

    }
    public enum TypeMenuItem
    {
        Food=1,Drink
    }
    public enum MenuItemCategory
    {
       Drink, LuchStarter,LuchMainCourse, LuchDessert , DinnerStarter, DinnerEntrements,DinnerMainCourse, DinnerDessert
    }
   
}
