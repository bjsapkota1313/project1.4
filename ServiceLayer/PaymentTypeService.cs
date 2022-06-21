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
        //public PaymentType GetType(int id)
        //{
        //    return paymentTypedb.GetType(id);
        //}

    }
}

