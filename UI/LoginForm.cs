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
            // whenever employee is logged out it and login form is closed logged employee is made null and search again by database
            loggedEmployee = null;
            // default setting 
            DefaultSettingForShowHideFunction();

        }

        private void DefaultSettingForShowHideFunction()
        {
            picBoxHidePass.Hide();
            picBoxShowPass.Show();
            picBoxShowPass.BackColor = txtBoxPassword.BackColor;
            picBoxHidePass.BackColor = txtBoxPassword.BackColor;
        }
        private void Login()
        {
            try
            {
                loggedEmployee = employeeService.LogEmployee(int.Parse(txtBoxEmployeeId.Text), txtBoxPassword.Text);
                //whenever password is verified login form is hidden


                switch (loggedEmployee.EmployeeType)
                {
                    case EmployeeType.Waiter:
                        // When ever waitier is logged in 
                        TableView tableView = new TableView(loggedEmployee);
                        tableView.Show();
                        break;
                    case EmployeeType.BarTender | EmployeeType.Chef:
                        //whenever chef or Barman is logged in then kitchen display is shown 
                        KitchenAndBarView kitchenAndBarView = new KitchenAndBarView(loggedEmployee);
                        kitchenAndBarView.Show();
                        break;
                }
                this.Hide();

            }
            catch (Exception e)
            {
                // all error are catched here even they are thrown in DAL layer also 
                MessageBox.Show(e.Message, "Try again!", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);


            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void picBoxShowPass_Click(object sender, EventArgs e)
        {
            // first hidding  clicked picture box and showing otherone
            picBoxShowPass.Hide();
            // converting to normal pass
            txtBoxPassword.PasswordChar = '\0';
            // showing other picBox
            picBoxHidePass.Show();

        }

        private void picBoxHidePass_Click(object sender, EventArgs e)
        {
            picBoxHidePass.Hide();
            txtBoxPassword.PasswordChar = '*';
            picBoxShowPass.Show();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // whenever form exit button is pressed it closes the application
            Application.Exit();
        }
    }
}
