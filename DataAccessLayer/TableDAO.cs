using System;
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
            string query = "SELECT TableNr,Status From [Table] WHERE TableNr=@TableNr"; 
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
                table.Status = (TableStatus)(dr["Status"]);
            }
            return table; 
        }
        public List<Table> GetAllTable()
        {
            string query = "SELECT TableNr,Status From [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];   
            return ReadTableForList(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Table>ReadTableForList(DataTable dataTable)
        {
            List<Table> tableList = new List<Table>();  
          
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                table.Number = (int)(dr["TableNr"]);
                table.Status = (TableStatus)(dr["Status"]);
                tableList.Add(table);
            }
            return tableList;
        }
        public void UpdateTheStatusOfTable(Table UpdatingTable)
        {
            string query = " UPDATE [Table] SET  [status]=@status WHERE TableNr= @tableNr";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tableNr", UpdatingTable.Number);
            sqlParameters[1] = new SqlParameter("@status", (int)UpdatingTable.Status);
            ExecuteEditQuery(query, sqlParameters);

        }
    }
}
