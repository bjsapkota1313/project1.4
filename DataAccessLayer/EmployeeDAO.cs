using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
     public class EmployeeDAO:BaseDAO
    {
        private SqlConnection dbConnection;

        public EmployeeDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["Chapeau"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public Employee SearchByUserName(string username)
        {
            string query = "SELECT EmployeeID, FirstName, LastName, Username, [Password] FROM Employee WHERE Username=@Username";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Username", username);
            return ReadTableRows(ExecuteSelectQuery(query, sqlParameters));
        }
        private Employee ReadTableRows(DataTable dataTable)
        {
            Employee employee=null;
            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["EmployeeID"];
                string firstName = (string)(dr["FirstName"].ToString());
                string lastName = (string)(dr["LastName"].ToString());
                string userName = (string)(dr["Username"]).ToString();
                string Password = (string)(dr["Password"]).ToString();

                //creating hash passowrd 
                HashedPasswordWithSalt hashedPasswordWithSalt = new HashedPasswordWithSalt();
                //hashedPasswordWithSalt.Salt =   
                hashedPasswordWithSalt.HashPassword = Password;

                //creating a employeenwith alll read values from table 
                employee = new Employee(id, firstName, lastName, userName, hashedPasswordWithSalt);
               
            }
            return employee;
        }
    }
}
