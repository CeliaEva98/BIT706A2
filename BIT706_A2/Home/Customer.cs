using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    [Serializable]
    class Customer
    {
        int customerID;
        String customerFirstName;
        String customerLastName;
        long customerContactNum;
        String custType;
        public IFeesStrategy myFeesStrategy;
        
        
        public Customer()
        {

        }

        public void SetFeesStrategy(IFeesStrategy newStrategy)
        {
            myFeesStrategy = newStrategy;
        }

        public Customer(int customerIDNum, string customerType, string firstName, string lastName, long contactNum)
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
        public long contactNum { get => customerContactNum; set => customerContactNum = value; }
        public string customerType { get => custType; set => custType = value; }
    }
    
}
