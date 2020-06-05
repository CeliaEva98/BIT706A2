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

        public Customer FindCustomer(int customerNumber)
        {
            foreach(Customer cust in CustomersList)
            {
                if (cust.ID == customerID)
                {
                    return cust;
                }
                
            }
            return null;
        }

        public string CustomerInfoDisplay(int customerNumber)
        {
            string displayString;

            int customerID;
            string customerFirstName = "";
            string customerLastName = "";
            int customerContact = 0;

            Customer result = FindCustomer(customerNumber);
            if (result == null)
            {
                displayString = "No customer found with the entered ID. Please try again.";
            }
            else
            {
                customerID = customerNumber;

                foreach(Customer cust in CustomersList) {
                    if (cust.ID == customerID)
                    {
                        customerFirstName = cust.firstName;
                        customerLastName = cust.lastName;
                        customerContact = cust.contactNum;
                    }
                }
                displayString = "ID Number: " + customerID.ToString() + "\n First Name: " + customerFirstName
                    + "\n Last Name: " + customerLastName + "\n Contact Number: " + customerContact.ToString();
            }
            return displayString;
        }
    }
}
