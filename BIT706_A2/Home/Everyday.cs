using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Everyday : Accounts
    {
        public Everyday():base()
        {
            base.AccountType = "Everyday";
            base.Overdraft = 0;
        }
        
        public Everyday(int customerNumber, int accountNumber)
        {
            base.customerNumber = customerNumber;
            base.accountID = accountNumber;
            base.accountType = "Everyday";
        }
    }
}
