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


        public Payment GetPaymentMethod(int id)
        {
            return paymentdb.GetPaymentMethod(id);
        }
        public void AddPayment(int id, decimal total, decimal tip, int paymentType)
        {
            paymentdb.AddPayment(id, total, tip, paymentType);

        }
   



    }
}

