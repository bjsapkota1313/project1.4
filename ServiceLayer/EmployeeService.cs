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
        public Employee SearchByUserName(string username)
        {
            return employeeDAO.SearchByUserName(username);
        }
    }
}
