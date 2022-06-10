using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public class PaymentService
    {
        PaymentDAO paymentdb;
        public PaymentService()
        {
            paymentdb = new PaymentDAO();
        }
        //public Payment GetPayment(int billID)
        //{
        //   // return paymentdb.GetPayment(billID);
        //}
        //public Payment SearchByID(int ID)
        //{
        //    return paymentdb.SearchByID(ID);
        //}

        public List<Payment> GetAllOrderedItems(int orderID)
        {
            return paymentdb.GetAllOrderedItems(orderID);
        }

        public void AddFeedback(int id, string feedback)
        {
            //Create query
            string query = $"UPDATE OrderPayment SET Feedback = '{feedback}' WHERE BillID = '{id}'";

            // Add Feedback to the database
            paymentdb.EditPayment(query);

        }      
        public void AddTip(int id, decimal tip)
        {
            //Create query
            string query = $"UPDATE OrderPayment SET Tip = '{tip}' WHERE BillID='{id}'";

            // Add Tip to the database
            paymentdb.EditPayment(query);

        }
        public void AddTotal(int id, decimal total)
        {
            //Create query
            string query = $"UPDATE OrderPayment SET Total = '{total}' WHERE BillID='{id}'";

            // Add Tip to the database
            paymentdb.EditPayment(query);

        }
        public void AddPayment(int id, decimal total, decimal tip, int paymentType)
        {
            //Create query
            string query = $"UPDATE OrderPayment SET Total = '{total}', Tip = '{tip}', [Type] = '{paymentType}' WHERE BillID='{id}'";

            // Add Payment to the database
            paymentdb.EditPayment(query);

        }
        public void ChangePaymentStatus(int id, bool status)
        {
            //Create query
            string query = $"UPDATE OrderPayment SET PaymentStatus = '{status}' WHERE BillID='{id}'";

            // Add Payment to the database
            paymentdb.EditPayment(query);

        }

    }
}
