using DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class BillService
    {
        BillDAO billdb;
        public BillService()
        {
            billdb = new BillDAO();    
        }

        public Bill GetBill(int tableNr)
        {
            return billdb.GetBill(tableNr);
        }

    }
}
