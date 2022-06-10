using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public class PaymentTypeService
    {
        PaymentTypeDAO paymentTypedb;
        public PaymentTypeService()
        {
            paymentTypedb = new PaymentTypeDAO();
        }
        public List<PaymentType> GetAllPaymentTypes()
        {
            return paymentTypedb.GetAllPaymentTypes();
        }
        //public PaymentType SearchByID(int ID)
        //{
        //    return paymentTypeDAO.SearchByID(ID);
        //}
        public PaymentType Type(int id)
        {
            return paymentTypedb.Type(id);
        }

    }
}

