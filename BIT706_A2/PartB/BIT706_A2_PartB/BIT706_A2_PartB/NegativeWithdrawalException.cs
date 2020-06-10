using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartB
{
    public class NegativeWithdrawalException : Exception
    {
        public NegativeWithdrawalException()
        {

        }
        public NegativeWithdrawalException(string message) : base(message)
        {

        }
    }
}
