using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public  class EmployeeService
    {
        EmployeeDAO employeeDAO;
        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();    
        }
        public List<Employee> GetEmployees()
        {
            return employeeDAO.GetEmployees();
        }
        public Employee SearchByID(int ID)
        {
            return employeeDAO.SearchByID(ID);
        }
    }
}
