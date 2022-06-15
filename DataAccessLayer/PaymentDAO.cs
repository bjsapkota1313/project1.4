﻿using System;
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
        public Payment GetPayment(int billID)
        {
            //Create query
            string query = $"SELECT BillID, Type, Feedback, PaymentStatus, Tip, Total, ID FROM OrderPayment WHERE BillID = '{billID}'";
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

                        payment.Bill = (Bill)dr["BillID"];
                        payment.Type = (int)dr["Type"];
                        payment.Feedback = (string)dr["Feedback"];
                        payment.PaymentStatus = (bool)dr["PaymentStatus"];
                        payment.Tip = (decimal)dr["Tip"];
                        payment.Total = (decimal)dr["Total"];
                        payment.Id = (int)dr["ID"];

                    }

                }
                return payment;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the payments data from the database.", e);
            }
        }
        public Payment AddPaymentMethod(int id, int type)
        {
            //Create query
            string query = $"INSERT INTO OrderPayment(BillID, [Type]) VALUES ('{id}', '{type}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
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
