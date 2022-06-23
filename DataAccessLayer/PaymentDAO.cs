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
        public Payment GetPayment(int orderId)
        {
            //Create query
            string query = $"SELECT OrderID, Type, Tip, Total, BillID  FROM OrderPayment WHERE OrderID = '{orderId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private Payment ReadTables(DataTable dataTable)
        {
            Payment payment = new Payment();

            try
            {
                // For each data row, set all data to new Payment object
                foreach (DataRow dr in dataTable.Rows)
                {
                    
                    {
                        //payment.BillID = (int)dr["BillID"];
                        //payment.Order = (Order)dr["OrderID"];
                        payment.Type = (PaymentType)dr["ID"];
                        //payment.Tip = (decimal)dr["Tip"];
                        //payment.Total = (decimal)dr["Total"];

                    }

                }
                return payment;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the payments data from the database.", e);
            }
        }
        public void AddPayment(int id, decimal total, decimal tip, int paymentType)
        {
            string query = "INSERT INTO OrderPayment (OrderID, Total, Tip, [Type]) VALUES (@id, @total, @tip,@payementType)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id",id),
                new SqlParameter("@total",total),
                new SqlParameter("@tip",tip),
                new SqlParameter("@payementType",paymentType)
            };

            // Execute query
            ExecuteEditQuery(query, sqlParameters);
        }
        public Payment GetPaymentMethod(int id)
        {
            string query = $"SELECT P.Type FROM OrderPayment AS P INNER JOIN PaymentType AS T ON P.Type = T.ID WHERE P.Type = '{id}'";

            SqlParameter[] sqlParameters = new SqlParameter[0];


            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void EditPayment(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Execute query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
