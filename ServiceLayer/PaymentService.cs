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
        PayementDAO payementDAO;
        public PaymentService()
        {
            payementDAO = new PayementDAO();
        }
        public List<Payement> GetAllPayements()
        {
            return payementDAO.GetAllPayements();
        }
        public Payement SearchByID(int ID)
        {
            return payementDAO.SearchByID(ID);
        }
    }
}
