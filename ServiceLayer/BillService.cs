using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class BillService
    {
        BillDAO billDAO;
        public BillService()
        {
            billDAO = new BillDAO();    
        }
        public List<Bill> GetAlllBill()
        {
            return billDAO.GetAlllBill();
        }
        public Bill SearchByID(int ID)
        {
            return billDAO.SearchByID(ID);
        }
    }
}
