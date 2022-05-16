using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Employee
    {
        public int Id { get; private set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HashedPasswordWithSalt PassWord { get; set; }
        public Employee(int id,string firstName,string lastName, HashedPasswordWithSalt passWord)
        {
            Id = id;
            FirstName = firstName;
            LastName=lastName;
            PassWord = passWord;
        }
    }
}
