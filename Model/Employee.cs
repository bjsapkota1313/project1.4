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
        public EmployeeType EmployeeType { get; set; }
        public Employee(int id,string firstName,string lastName, EmployeeType employeeType)
        {
            Id = id;
            FirstName = firstName;
            LastName=lastName;
            EmployeeType = employeeType;
        }
    }
}
