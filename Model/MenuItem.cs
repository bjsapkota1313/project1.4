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
