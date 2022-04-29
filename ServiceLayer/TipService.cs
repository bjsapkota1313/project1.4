using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccessLayer;

namespace ServiceLayer
{
    public  class TipService
    {
        TipDAO tipDAO;
        public TipService()
        {
            tipDAO = new TipDAO();  
        }
        public List<Tip> GetAllTip()
        {
            return tipDAO.GetAllTip();
        }
        public Tip SearchByID(int ID)
        {
            return tipDAO.SearchByID(ID);
        }
    }
}
