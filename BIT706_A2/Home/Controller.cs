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

        int nextAccountID = 1;
        int accountID;

        public static List<Customer> CustomersList = new List<Customer>();
        public static List<Accounts> customerAccounts = new List<Accounts>();
        List<Accounts> CorrespondingAccounts = new List<Accounts>();

        public int setAccountID(int customerNum)
        {
            foreach (Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNum && acc.AccountID == nextAccountID)
                {
                    nextAccountID++;
                }
                else
                {
                    accountID = nextAccountID;
                    nextAccountID = 1;
                    return accountID;
                }
            }
            int errorEnd = 0;
            return errorEnd;
        }

        public int setCustomerID()
        {
            customerID = nextCustomerID;
            nextCustomerID++;
            return customerID;
        }

        public int CreateCustomer(String custType, String firstName, String lastName, int contactNumber)
        {
            Customer newCust = new Customer(setCustomerID(), custType, firstName, lastName, contactNumber);
            CustomersList.Add(newCust);
            return customerID;
        }

        public void DeleteCustomer(int customerNumber)
        {
            Customer retrievedCustomer = FindCustomer(customerNumber);
            CustomersList.Remove(retrievedCustomer);
        }
        
        public string GetCustomerType(int customerNumber)
        {
            string customerType = "";
            foreach (Customer cust in CustomersList)
            {
                if (cust.ID == customerNumber)
                {
                    customerType = cust.customerType;
                }
            }
            return customerType;
        }

        public void EditCustomer(int customerNumber)
        {
            EditCustomer newEdit = new EditCustomer();
            newEdit.Show();
            newEdit.setLabelText(customerNumber.ToString());
            newEdit.setFirstName(GetFirstName(customerNumber));
            newEdit.setLastName(GetLastName(customerNumber));
            newEdit.setContactNum(GetContactNumber(customerNumber));

           
        }

        public void UpdateCustomerDetails(int customerNumber, string custType, string firstName, string lastName, int contactNumber)
        {
            foreach (Customer cust in CustomersList.ToList())
            {
                if (cust.ID == customerNumber)
                {
                    CustomersList.Remove(cust);
                }

            }
            Customer newCustomer = new Customer(customerNumber, custType, firstName, lastName, contactNumber);
            CustomersList.Add(newCustomer);
        }

        public Customer FindCustomer(int customerNumber)
        {
            foreach(Customer cust in CustomersList)
            {
                if (cust.ID == customerNumber)
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

        public List<Accounts> GetCustomerAccounts(int customerNumber)
        {
            CorrespondingAccounts.Clear();

            foreach (Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNumber)
                {
                    CorrespondingAccounts.Add(acc);
                }
                
            }
            return CorrespondingAccounts;
        }

        public void UpdateAccountBalance(int customerNumber, int accountNumber, string accountType, double newBalance)
        {
            foreach(Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNumber && acc.AccountID == accountNumber && acc.AccountType == accountType)
                {
                    acc.Balance = newBalance;
                }
            }

        }

        public void AddAccount(int customerNumber, string accountType)
        {
            if (accountType == "Omni")
            {
                Omni newOmni = new Omni(customerNumber, setAccountID(customerNumber));
                customerAccounts.Add(newOmni);
            }
            else if (accountType == "Investment")
            {
                Investment newInvest = new Investment(customerNumber, setAccountID(customerNumber));
                customerAccounts.Add(newInvest);
            }
            else if (accountType == "Everyday")
            {
                Everyday newEveryday = new Everyday(customerNumber, setAccountID(customerNumber));
                customerAccounts.Add(newEveryday);
            }

            
        }

        

        public double GetAccountBalance(int customerNumber, int accountNumber, string accountType)
        {
            double balance = 0;
            foreach (Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNumber && acc.AccountID == accountNumber && acc.AccountType == accountType)
                {
                    balance = acc.Balance;
                }
            }
            return balance;        
        }

        public double CompleteDeposit(int customerNumber, int accountNumber, int depositAmount, string accountType)
        {
            double previousBalance = GetAccountBalance(customerNumber, accountNumber, accountType);
            double newBalance = previousBalance + Convert.ToDouble(depositAmount);
            return newBalance;
        }

        public double CompleteWithdrawal(int customerNumber, int accountNumber, int withdrawalAmount, string accountType)
        {
            double previousBalance = GetAccountBalance(customerNumber, accountNumber, accountType);
            double newBalance = previousBalance - Convert.ToDouble(withdrawalAmount);
            return newBalance;
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
                foreach(Customer cust in CustomersList)
                {
                    Console.WriteLine(cust.ID);
                }
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
