using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class BankStaff : Customer, IFeesStrategy
    {
        public string CalcFine()
        {
            return "Bank Staff Fine";
        }
    }
}
