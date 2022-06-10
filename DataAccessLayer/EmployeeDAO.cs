using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
     public class EmployeeDAO:BaseDAO
       {
       
        public Employee SearchById(int id)
        {
            string query = "SELECT EmployeeID, FirstName, LastName,FROM Employee WHERE EmployeeID=@ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", id);
            return ReadTableRows(ExecuteSelectQuery(query, sqlParameters));
        }
        public Employee VerifyPassword(int employeeId,string enteredPassword)
        {
            // first getting the stored salt from the database to compare with it 
            String query = "SELECT Salt FROM Employee WHERE EmployeeID=@ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", employeeId);
            string storedSalt = ReadEmployeeSalt(ExecuteSelectQuery(query, sqlParameters));
            if (storedSalt == null)
            {
                throw new Exception("No employee found with this employee Id");
            }
            // converting entered password by adding a stored salt from database 
            string hashedPassword = HashingEnteredPassword(enteredPassword, storedSalt);

            //now verifying the hashedpassword with salt to the user database
            Employee loggedEmployee = ComparingPasswordWithEnteredPassword(employeeId, hashedPassword);
            if (loggedEmployee == null)
            {
                throw new Exception("Somethings wrong with your credentials");
            }
            return loggedEmployee;
        }

        private  string HashingEnteredPassword(string enteredPassword, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 10000);
           return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); // using 32 bits 
        }

        private Employee ComparingPasswordWithEnteredPassword(int employeeId,string converetedPassword)
        {
            string query = "SELECT EmployeeID, FirstName, LastName,EmployeeType, [Password] FROM Employee WHERE EmployeeID=@ID AND [Password]=@password";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            // preventing from sql injections
            sqlParameters[0] = new SqlParameter("@ID", employeeId);
            sqlParameters[1] = new SqlParameter("@password", converetedPassword);
            return ReadTableRows(ExecuteSelectQuery(query, sqlParameters));
        }

        private  string ReadEmployeeSalt(DataTable dataTable)
        {
            string salt=null;
            foreach (DataRow dr in dataTable.Rows)
            {
                 salt = (dr["Salt"].ToString());
            }
            return salt;
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
                EmployeeType employeeType = (EmployeeType)dr["EmployeeType"];

                //creating a employee with alll read values from table 
                employee = new Employee(id, firstName, lastName,employeeType);
            }
            return employee;
        }
    }
}
