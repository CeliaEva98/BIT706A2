using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    
    class OtherCust : Customer, IFeesStrategy
    {
        public string CalcFine()
        {
            return "Other Customer Fine";  
        }
    }
}
