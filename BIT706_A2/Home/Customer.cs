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
        
        public Customer()
        {

        }

        public Customer(int customerIDNum, string firstName, string lastName, int contactNum)
        {
            customerID = customerIDNum;
            customerFirstName = firstName;
            customerLastName = lastName;
            customerContactNum = contactNum;
        }  

        public int ID { get => customerID; set => customerID = value; }
        public string firstName { get => customerFirstName; set => customerFirstName = value; }
        public string lastName { get => customerLastName; set => customerLastName = value; }
        public int contactNum { get => customerContactNum; set => customerContactNum = value; }
    }
    
}
