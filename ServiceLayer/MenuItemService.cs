using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDAO;

        public MenuItemService()
        {
                menuItemDAO= new MenuItemDAO(); 
        }
        public List<MenuItemDAO> GetAllMenuItem()
        {
            return menuItemDAO.GetAllMenuItem();
        }
        public MenuItemDAO SearchByID(int ID)
        {
            return menuItemDAO.SearchByID(ID);
        }
    }
}
