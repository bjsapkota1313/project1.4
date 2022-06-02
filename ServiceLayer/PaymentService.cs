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
        PaymentDAO paymentDAO;
        public PaymentService()
        {
            paymentDAO = new PaymentDAO();
        }
        public List<Payment> GetAllPayments()
        {
            return paymentDAO.GetAllPayments();
        }
        public Payment SearchByID(int ID)
        {
            return paymentDAO.SearchByID(ID);
        }
    }
}
