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
        public double Price { get; set; } 
        public string Name { get; set; }
        public TypeMenuItem TypeMenuItem { get; set; }
    }
    public enum TypeMenuItem
    {
        Food,Drink
    }
}
