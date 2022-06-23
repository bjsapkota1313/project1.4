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

            ExecuteEditQuery(query, sqlParameters);

        }
    }
}
