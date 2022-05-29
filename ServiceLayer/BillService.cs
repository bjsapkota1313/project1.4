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
        public List<Bill> GetAlllBills()
        {
            return billDAO.GetAlllBills();
        }
        public Bill SearchByID(int ID)
        {
            return billDAO.SearchByID(ID);
        }

        public void AddTip(int ID, double value)
        {
            string query = $"UPDATE BILL SET Tip = '{value}' WHERE BillID='{ID}'";
            billDAO.EditBill(query);

        }
    }
}
