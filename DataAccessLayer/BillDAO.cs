
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
    public class BillDAO:BaseDAO
    {
        public List<Bill> GetAlllBills()
        {
            string query = "SELECT BillID, OrderID, Amount, Tip FROM BILL";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            try
            {
                // For each data row, set all data to new Bill object
                foreach (DataRow dr in dataTable.Rows)
                {
                    Bill bill = new Bill()
                    {

                        BillID = (int)dr["BillID"],
                        OrderID = (int)dr["OrderID"],
                        Amount = (int)dr["Amount"],
                        Tip = (int)dr["Tip"]
                    };
                    // Add new Drink object to list of Bills
                    bills.Add(bill);
                }
                return bills;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the bills data from the database.", e);
            }
        }
        public Bill SearchByID(int ID)
        {
            string query = $"SELECT BillID, OrderID, Amount, Tip  FROM BILL WHERE BillID='{ID}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void EditBill(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
