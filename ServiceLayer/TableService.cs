using System;
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
        TableDAO tableDAO;
        public TableService()
        {
            tableDAO = new TableDAO();
        }
        public List<Table> GetAllTable()
        {
            return tableDAO.GetAllTable();
        }
        public Table SearchByID(int ID)
        {
            return tableDAO.SearchByID(ID);
        }
    }
}
