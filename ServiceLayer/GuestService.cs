using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;


namespace ServiceLayer
{
    public  class GuestService
    {
        GuestDAO guestDAO;
        public GuestService()
        {
            guestDAO = new GuestDAO();
        }
        public List<Guest> GetAllGuest()
        {
            return guestDAO.GetAllGuest();
        }
        public Guest SearchByID(int ID)
        {
            return guestDAO.SearchByID(ID);
        }
    }
}
