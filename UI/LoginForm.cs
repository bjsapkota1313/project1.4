using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using ServiceLayer;

namespace UI
{
    public partial class LoginForm : Form
    {
        // making global so that it can be used
        private EmployeeService employeeService;
        public LoginForm()
        {
            InitializeComponent();
             employeeService = new EmployeeService();
            Employee employee = employeeService.SearchByID(1234);
            Console.WriteLine(employee.FirstName); 
        }
        //this is used when we compare to user using stored salt 
        private bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)) == storedHash; // using 32 bits
        }

    }
}
