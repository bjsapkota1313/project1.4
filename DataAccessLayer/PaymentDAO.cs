using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAccessLayer
{
    public  class PaymentDAO : BaseDAO
    {
        public List<Payment> GetAllPayments()
        {
            //Create query
            string query = "SELECT BillID, Type FROM Payment";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            try
            {
                // For each data row, set all data to new Drink object
                foreach (DataRow dr in dataTable.Rows)
                {
                    Payment payment = new Payment()
                    {
                  
                        Bill = (Bill)dr["BillID"],
                        Type = (int)dr["Type"]
                    };
                    // Add new Drink object to list of Drinks
                    payments.Add(payment);
                }
                return payments;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the payments data from the database.", e);
            }
        }
        public Payment SearchByID(int ID)
        {
            string query = $"SELECT BillID, Type FROM PAYMENT WHERE BillID='{ID}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
    }
}
