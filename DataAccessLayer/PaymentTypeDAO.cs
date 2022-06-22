
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
        //public PaymentType GetType(int id)
        //{
        //    //Create query
        //    string query = $"SELECT ID, Type  WHERE ID ='{id}'";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];

        //    // Return result of query
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        //}
        //private PaymentType ReadTables(DataTable dataTable)
        //{
        //    PaymentType type = new PaymentType();

        //    try
        //    {
        //        // For each data row, set all data to new type object
        //        foreach (DataRow dr in dataTable.Rows)
        //        {

        //            {
        //                type.ID = (int)dr["ID"];
        //                type.Type = (string)dr["Type"];
        //            }
        //        }
        //        return type;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("There is an issue reading the Payment Method data from the database.", e);
        //    }
        //}
    }
}
