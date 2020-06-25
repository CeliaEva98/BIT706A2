using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Investment : Accounts
    {
        public Investment():base()
        {
            base.AccountType = "Investment";
            base.Overdraft = 0;
        }

        public Investment(int customerNumber, int accountNumber)
        {
            base.customerNumber = customerNumber;
            base.accountID = accountNumber;
            base.accountType = "Investment";
        }
    }
}
