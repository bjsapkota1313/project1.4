using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PaymentType
    {
        public int ID { get; set; }

        public PaymentTypes Type { get; set; }
    }
    public enum PaymentTypes
    {
        Cash = 0, CreditCard, PIN
    }

}
