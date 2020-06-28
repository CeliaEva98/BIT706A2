using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    [Serializable]
    class Omni : Accounts
    {
        public Omni(): base()
        {
            base.AccountType = "Omni";
            base.Overdraft = 1000;
        }

        public Omni(int customerNumber, int accountID)
        {
            base.customerNumber = customerNumber;
            base.accountID = accountID;
            base.accountType = "Omni";
        }
    }
}
