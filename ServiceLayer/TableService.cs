﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public  class TableService
    {
       private  TableDAO tableDAO;
        public int counter;
        public TableService()
        {
            tableDAO = new TableDAO();
        }
        public Table SearchTable(int tableNumber)
        {
            return tableDAO.SearchTable(tableNumber);
        }
        public List<Table> GetAllTables()
        {
            return tableDAO.GetAllTable();
        }
         public void UpdateTheStatusOfTable(Table UpdatingTable)
        {
            tableDAO.UpdateTheStatusOfTable(UpdatingTable); 
        }
        public void ChangeTableToFree(int tableNr)
        {
            tableDAO.ChangeTableToFree(tableNr);
        }
    }
}
