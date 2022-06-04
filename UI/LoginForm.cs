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
        private Employee loggedEmployee;
        public LoginForm()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
        }

        private void Login()
        {
            try
            {
                loggedEmployee = employeeService.GetLoggedEmployee(int.Parse(txtBoxEmployeeId.Text), txtBoxPassword.Text.ToString());
                //whenever password is verified login form is hidden
                this.Hide();

                switch (loggedEmployee.EmployeeType)
                {
                    case EmployeeType.Waiter:
                        // When ever waitier is logged in 
                        TableView tableView = new TableView();
                        tableView.Show();
                        break;
                    case EmployeeType.Manager:
                        // For now there is no management part so leaving it out 
                        break;
                    case (EmployeeType.BarTender) | (EmployeeType.Chef):
                        //whenever chef or Bar man is logged in then kitchen display is shown 
                        KitchenAndBarView kitchenAndBarView= new KitchenAndBarView();
                        kitchenAndBarView.Show();
                        break;
                }
               
            }
            catch (Exception e)
            {
                // all error are catched here even they are thrown in DAL layer also 
                MessageBox.Show(e.Message);
                
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
