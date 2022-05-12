using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class HashedPasswordWithSalt
    {
        public string HashPassword { get; set; }
        public string Salt { get; set; }
    }
}
