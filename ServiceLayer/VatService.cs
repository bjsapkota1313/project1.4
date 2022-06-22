using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public class VatService
    {
        VatDAO vatdb;
        public VatService()
        {
            vatdb = new VatDAO();
        }

        public VAT GetVAT(int vatID)
        {
            return vatdb.GetVAT(vatID);
        }

    }
}
