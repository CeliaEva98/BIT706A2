using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartB
{
    public class Investment:Accounts
    {
        public Investment() : base()
        {
            base.AccountType = "Investment";
            base.Overdraft = 0;
            base.Fee = 10;
            investInterestRates();
        }

        public virtual void investInterestRates()
        {
            if (base.Balance >= 0 && base.Balance <= 500)
            {
                base.interestRate = 0.01;
            }
            else if (base.Balance > 500 && base.Balance <= 1000)
            {
                base.interestRate = 0.02;
            }
            else
            {
                base.interestRate = 0.04;
            }
        }
    }
}
