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
       private  EmployeeDAO employeeDAO;
        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();    
        }
        public Employee SearchByID(int id)
        {
            return employeeDAO.SearchById(id);
        }
    }
}
