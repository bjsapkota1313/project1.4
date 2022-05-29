using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DataAccessLayer
{
     public class FeedbackDAO : BaseDAO
    {
        public List<Feedback> GetAllFeedback()
        {
            string query = "SELECT OrderID, Description FROM Feedback";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Feedback> ReadTables(DataTable dataTable)
        {

            List<Feedback> feedbacks = new List<Feedback>();
            try
            {

                // For each data row, set all data to new Drink object
                foreach (DataRow dr in dataTable.Rows)
                {
                    Feedback feedback = new Feedback()
                    {

                        OrderID = (int)dr["OrderID"],
                        Description = (string)dr["Description"],
                    };
                    // Add new Drink object to list of Drinks
                    feedbacks.Add(feedback);
                }
                return feedbacks;
            }
            catch (Exception e)
            {
                throw new Exception("There is an issue reading the bills data from the database.", e);
            }
        }
        public void EditFeedback(string query)
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];

            // Return result of query
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
