using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Omni : Accounts
    {
        public Omni(): base()
        {
            base.AccountType = "Omni";
            base.Overdraft = 1000;
        }
    }
}
