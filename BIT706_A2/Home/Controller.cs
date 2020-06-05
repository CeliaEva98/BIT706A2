using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Controller
    {
        int nextCustomerID = 1;
        int customerID;

        public List<Customer> CustomersList = new List<Customer>();

        public void setCustomerID()
        {
            customerID = nextCustomerID;
            nextCustomerID++; 
        }

        public void CreateCustomer(String firstName, String lastName, int contactNumber)
        {

        }

        public void DeleteCustomer(int customerNumber)
        {

        }

        public void EditCustomer(int customerNumber)
        {

        }

        public void FindCustomer(int customerNumber)
        {

        }
    }
}
