using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartB
{
    class Everyday:Accounts
    {
        public Everyday() : base()
        {
            base.AccountType = "Everyday";
            base.Interest = 0;
            base.Overdraft = 0;
            base.Fee = 0;
        }
    }
}
