﻿using System;
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
   public   class TableDAO:BaseDAO
    {
        private SqlConnection dbConnection;
        public TableDAO()
        {
            // connecting to database
            string connString = ConfigurationManager.ConnectionStrings["Chapeau"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public Table SearchTable(int tableNumber)
        {
            string query = "SELECT TableNr,[Status] From [Table] WHERE TableNr=@TableNr"; 
            SqlParameter[] sqlParameters = new SqlParameter[1];
            // preventing from SQL injections
            sqlParameters[0] = new SqlParameter("@TableNr", tableNumber);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private Table ReadTables(DataTable dataTable)
        {
            Table table = new Table();  
            foreach (DataRow dr in dataTable.Rows)
            {
                table.Number = (int)(dr["TableNr"]);
                table.Status = (TableStatus)(dr["[Status"]);
            }
            return table; 
        }
    }
}
