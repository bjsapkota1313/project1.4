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
        public Employee SearchById(int id)
        {
            string query = "SELECT EmployeeID, FirstName, LastName, [Password],Salt FROM Employee WHERE EmployeeID=@ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", id);
            return ReadTableRows(ExecuteSelectQuery(query, sqlParameters));
        }
        private Employee ReadTableRows(DataTable dataTable)
        {
            // first making the employee null later on it will be set
            Employee employee=null;
            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["EmployeeID"];
                string firstName = (string)(dr["FirstName"].ToString());
                string lastName = (string)(dr["LastName"].ToString());
                string password = (string)(dr["Password"]).ToString();
                string salt= (string)(dr["Salt"].ToString());

                //creating hash password 
                HashedPasswordWithSalt hashedPasswordWithSalt = new HashedPasswordWithSalt();
                hashedPasswordWithSalt.Salt = salt; 
                hashedPasswordWithSalt.HashPassword = password;

                //creating a employee with alll read values from table 
                employee = new Employee(id, firstName, lastName,  hashedPasswordWithSalt);
            }
            return employee;
        }
    }
}
