using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Customer
    {
        int customerID;
        String customerFirstName;
        String customerLastName;
        int customerContactNum;

        public Customer(int customerIDNum, string firstName, string lastName, int contactNum)
        {
            customerID = customerIDNum;
            customerFirstName = firstName;
            customerLastName = lastName;
            customerContactNum = contactNum;
        }  
    }
    
}
