using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BIT706_A2_PartB
{
    public class Omni:Accounts
    {
        public Omni() : base()
        {
            base.AccountType = "Omni";
            base.Overdraft = 1000;
            base.Fee = 10;
            interestAmt();
        }

        public virtual void interestAmt()
        {
            double interestBalance;
            double interestRate;
            if (base.Balance >= 1000)
            {
                interestBalance = base.Balance - 1000;
                interestRate = 0.04;
                base.interestRate = interestRate;
                base.interestTotal = interestBalance * interestRate;
            }
            else
            {
                base.interestRate = 0.00;
            }
        }

        public void info()
        {
            base.Info();
        }
    }
}
