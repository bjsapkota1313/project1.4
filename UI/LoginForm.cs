using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Employee employee = employeeService.SearchByUserName("Dummy");
        }

    }
}
