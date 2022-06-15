
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
    public class BillDAO : BaseDAO
    {
        public Bill GetBill(int tableNr)
        {
            //Create query
            string query = $"SELECT BillId, TableNr, OrderID FROM TableBill WHERE TableNr ='{tableNr}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private Bill ReadTables(DataTable dataTable)
        {
            Bill bill = new Bill();

            try
            {
                // For each data row, set all data to new Bill object
                foreach (DataRow dr in dataTable.Rows)
                {
                  
                    {

                        bill.BillID = (int)dr["BillID"];
                        bill.TableNr = (int)dr["TableNr"];
                        bill.OrderID = (int)dr["OrderID"];
                    }        
                }
                return bill;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the bills data from the database.", e);
            }
        }

        public void EditBill(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
