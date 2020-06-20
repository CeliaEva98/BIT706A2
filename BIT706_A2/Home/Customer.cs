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
        String custType;
        public IFeesStrategy myFeesStrategy;
        
        public Customer()
        {

        }

        public void SetFeesStrategy(IFeesStrategy newStrategy)
        {
            myFeesStrategy = newStrategy;
        }

        public Customer(int customerIDNum, string customerType, string firstName, string lastName, int contactNum)
        {
            customerID = customerIDNum;
            custType = customerType;
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
