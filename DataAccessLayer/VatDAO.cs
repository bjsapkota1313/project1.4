using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class VatDAO : BaseDAO
    {
        public VAT GetVAT(int vatId)
        {
            //Create query
            string query = $"SELECT VatID, VAT  WHERE VatID ='{vatId}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private VAT ReadTables(DataTable dataTable)
        {
            VAT vat = new VAT();

            try
            {
                // For each data row, set all data to new vat object
                foreach (DataRow dr in dataTable.Rows)
                {

                    {
                        vat.VatID = (int)dr["VatID"];
                        vat.ValueVAT = (decimal)dr["VAT"];
                    }
                }
                return vat;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the VAT data from the database.", e);
            }
        }
    }
}
