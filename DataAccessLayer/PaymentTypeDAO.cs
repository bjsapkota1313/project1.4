
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
    public class PaymentTypeDAO : BaseDAO
    {
        public List<PaymentType> GetAllPaymentTypes()
        {
            string query = "SELECT ID, Type FROM PAYMENTTYPE";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<PaymentType> ReadTables(DataTable dataTable)
        {
            List<PaymentType> PaymentTypes = new List<PaymentType>();

            try
            {
                // For each data row, set all data to new Drink object
                foreach (DataRow dr in dataTable.Rows)
                {
                    PaymentType paymentType = new PaymentType()
                    {
                        ID = (int)dr["ID"],
                        Type = (string)dr["Tyoe"]

                    };
                    // Add new Drink object to list of Drinks
                    PaymentTypes.Add(paymentType);
                }
                return PaymentTypes;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the payments data from the database.", e);
            }
        }

        public PaymentType SearchByID(int ID)
        {
            string query = $"SELECT ID, Type FROM BILL WHERE ID='{ID}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

    }
}
