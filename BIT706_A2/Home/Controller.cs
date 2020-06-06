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

        public static List<Customer> CustomersList = new List<Customer>();



        public int setCustomerID()
        {
            customerID = nextCustomerID;
            nextCustomerID++;
            return customerID;
        }

        public int CreateCustomer(String firstName, String lastName, int contactNumber)
        {
            Customer newCust = new Customer(setCustomerID(), firstName, lastName, contactNumber);
            CustomersList.Add(newCust);
            return customerID;
        }

        public void DeleteCustomer(int customerNumber)
        {
            Customer retrievedCustomer = FindCustomer(customerNumber);
            CustomersList.Remove(retrievedCustomer);
        }
        

        public void EditCustomer(int customerNumber)
        {
            EditCustomer newEdit = new EditCustomer();
            newEdit.Show();
            newEdit.setLabelText(customerNumber.ToString());
            newEdit.setFirstName(GetFirstName(customerNumber));
            newEdit.setLastName(GetLastName(customerNumber));
            newEdit.setContactNum(GetContactNumber(customerNumber));

            string firstName = GetFirstName(customerNumber);
            string lastName = GetLastName(customerNumber);
            int contactNumber = GetContactNumber(customerNumber);

            UpdateCustomerDetails(customerNumber, firstName, lastName, contactNumber);
        }

        public void UpdateCustomerDetails(int customerNumber, string firstName, string lastName, int contactNumber)
        {
            foreach (Customer cust in CustomersList)
            {
                if (cust.ID == customerNumber)
                {
                    CustomersList.Remove(cust);
                }

            }
            Customer newCustomer = new Customer(customerNumber, firstName, lastName, contactNumber);
            CustomersList.Add(newCustomer);
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

        public string GetFirstName(int customerNumber)
        {
            string firstName = "";
            foreach(Customer cust in CustomersList)
            {
                if(cust.ID == customerNumber)
                {
                    firstName = cust.firstName;
                }
            }
            return firstName;
        }

        public string GetLastName(int customerNumber)
        {
            string lastName = "";
            foreach(Customer cust in CustomersList)
            {
                if(cust.ID == customerNumber)
                {
                    lastName = cust.lastName;
                }
            }
            return lastName;
        }

        public int GetContactNumber(int customerNumber)
        {
            int contactNumber = 0;
            foreach(Customer cust in CustomersList)
            {
                if(cust.ID == customerNumber)
                {
                    contactNumber = cust.contactNum;
                }
            }
            return contactNumber;
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
