using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartB
{
    public abstract class Customers
    {
        private int customerNumber;
        private string customerName;
        private string customerContact;

        public String Info()
        {
            String outputString = "Customer Number: " + customerNumber + "; Customer Name: " + customerName + "; Customer Contact: " +
                customerContact;
            return outputString;
        }
    }
}
