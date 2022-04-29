using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ServiceLayer
{
    public class StockService
    {
        StockDAO stockDAO;
        public StockService()
        {
            stockDAO = new StockDAO();
        }
        public List<Stock> GetAllStock()
        {
            return stockDAO.GetAllStock();
        }
    
        public Stock SearchByID(int ID)
        {
            return stockDAO.SearchByID(ID);
        }
    }
}
