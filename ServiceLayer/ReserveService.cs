using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public  class ReserveService
    {
        ReserveDAO reserveDAO;
        public ReserveService()
        {
            reserveDAO = new ReserveDAO();  
        }
        public List<Reserve> GetAllReserve()
        {
            return reserveDAO.GetAllReserve();
        }
        public Reserve SearchByID(int ID)
        {
            return reserveDAO.SearchByID(ID);
        }
    }
}
