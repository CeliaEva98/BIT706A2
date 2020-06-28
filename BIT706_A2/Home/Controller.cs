using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Home
{
    [Serializable]
    public class Controller
    {
        
        
        int nextCustomerID = 0;
        int customerID;

        int nextAccountID = 1;
        int accountID;

        
        public List<Customer> CustomersList = new List<Customer>();
        public List<Accounts> customerAccounts = new List<Accounts>();
        List<Accounts> CorrespondingAccounts = new List<Accounts>();

        
        /// <summary>
        /// Code required to write the data relating to customer accounts to file
        /// </summary>
        public void WriteAccountsBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SerializeAccounts.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, customerAccounts);
            stream.Close();
        }

        /// <summary>
        /// Code required to write the data relating to customer details to file
        /// </summary>
        public void WriteCustomersBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("SerializeCustomer.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, CustomersList);
            stream.Close();
        }

        /// <summary>
        /// Code required to read the data relating to customer accounts from the file to the Accounts list
        /// </summary>
        public void ReadAccountsData()
        {
            
            IFormatter formatter = new BinaryFormatter();
            
                Stream stream = new FileStream("SerializeAccounts.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                customerAccounts = (List<Accounts>)formatter.Deserialize(stream);
                stream.Close();
            
            

        }

        /// <summary>
        /// Code required to read the data relating to customer details from the file to the Customer list
        /// </summary>
        public void ReadCustomerData()
        {
            IFormatter formatter = new BinaryFormatter();
            
                Stream stream = new FileStream("SerializeCustomer.bin", FileMode.Open, FileAccess.Read, FileShare.Read);            
                CustomersList = (List<Customer>)formatter.Deserialize(stream);
                stream.Close();
            
            
        }

        /// <summary>
        /// Code to ensure that when a new account is created that the account IDs are not same
        /// </summary>
        /// <param name="customerNum">The unique number allocated to a customer</param>
        /// <returns>Returns the new account ID or an error based on where the code ends</returns>
        public int setAccountID(int customerNum, string accType)
        {
            
            foreach (Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNum && acc.AccountID == nextAccountID && acc.AccountType == accType)
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
            return nextAccountID;
        }

        /// <summary>
        /// Code to create a unique ID number for the new customers
        /// </summary>
        /// <returns>Returns the new customer ID for the new customer</returns>
        public int setCustomerID()
        {
            ReadCustomerData();
            
            foreach(Customer cust in CustomersList)
            {
                if (cust.ID == nextCustomerID)
                {
                    nextCustomerID++;
                }
                else
                {
                    customerID = nextCustomerID;
                }
            }
            
            return customerID;
        }
        /// <summary>
        /// Code to create a new customer, add them to the customer list and write their 
        /// details to the customer file 
        /// </summary>
        /// <param name="custType">The type of customer; either Bank staff or other</param>
        /// <param name="firstName">Customer first name</param>
        /// <param name="lastName">Customer last name</param>
        /// <param name="contactNumber">Customer contact number</param>
        /// <returns>Returns the unique Id related to the new customer</returns>
        public int CreateCustomer(String custType, String firstName, String lastName, long contactNumber)
        {
            
            Customer newCust = new Customer(setCustomerID(), custType, firstName, lastName, contactNumber);
            CustomersList.Add(newCust);
            WriteCustomersBinaryData();
            return customerID;
        }

        /// <summary>
        /// code to remove a customer that has already been added
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        public void DeleteCustomer(int customerNumber)
        {
            Customer retrievedCustomer = FindCustomer(customerNumber);
            CustomersList.Remove(retrievedCustomer);
            WriteCustomersBinaryData();
        }

        /// <summary>
        /// Code to get the type of customer that has been entered
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the customer type for the customer number; either bank staff or other</returns>
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

        /// <summary>
        /// Code to edit the details of a customer that has already been added
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        public void EditCustomer(int customerNumber)
        {
            EditCustomer newEdit = new EditCustomer();
            newEdit.Show();
            newEdit.setLabelText(customerNumber.ToString());
            newEdit.setFirstName(GetFirstName(customerNumber));
            newEdit.setLastName(GetLastName(customerNumber));
            newEdit.setContactNum(GetContactNumber(customerNumber));
            newEdit.setCustType(GetCustomerType(customerNumber));
           
        }

      

        /// <summary>
        /// Code to update the details of a customer that has already been added
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="custType">The type of customer; either bank staff or other</param>
        /// <param name="firstName">The first name of the customer</param>
        /// <param name="lastName">The last name of the customer</param>
        /// <param name="contactNumber">The contact number of the customer</param>
        public void UpdateCustomerDetails(int customerNumber, string custType, string firstName, string lastName,long contactNumber)
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

        /// <summary>
        /// Code to find if a customer exists based on their customer number, returning their
        /// customer object if they exist
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the customer object related to the customer number if customer exists,
        /// otherwise null returned</returns>
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

        /// <summary>
        /// Code to get the first name of a customer from their customer number
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the first name of a customer if their customer number is found</returns>
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

        /// <summary>
        /// Code to get the last name of a customer from their customer number
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the last name of a customer if their customer number is found</returns>
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

        /// <summary>
        /// Code to get the contact number of a customer from their customer number
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the customer number of a customer if their customer number is found</returns>
        public long GetContactNumber(long customerNumber)
        {
            long contactNumber = 0;
            foreach(Customer cust in CustomersList)
            {
                if(cust.ID == customerNumber)
                {
                    contactNumber = cust.contactNum;
                }
            }
            return contactNumber;
        }

        /// <summary>
        /// Code to get any accounts linked to a customers customer number
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the accounts related to the customer number of a customer</returns>
        public List<Accounts> GetCustomerAccounts(int customerNumber)
        {
            ReadAccountsData();
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

        /// <summary>
        /// Code to get the amount of interest to be added to a certain account
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountNumber">The unique number allocated to a customer's account</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        /// <returns>Returns the amount of interest required to be added to an account</returns>
        public double getInterest(int customerNumber, int accountNumber, string accountType)
        {
            double interestRate = 0;
            double accountBalance = GetAccountBalance(customerNumber, accountNumber, accountType);
            foreach (Accounts acc in customerAccounts)
            {
                if (acc.CustomerNumber == customerNumber && acc.AccountID == accountNumber && acc.AccountType == accountType)
                {
                    interestRate = acc.Interest;
                }
            }
            double interestAmount = accountBalance * interestRate;
            accountBalance += interestAmount;
            return accountBalance;
        }

        /// <summary>
        /// Code to update the balance of a given customer account
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountNumber">The unique number allocated to a customer's account</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        /// <param name="newBalance">The new balance of the account after a change to the balance</param>
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

        /// <summary>
        /// Code to add a new customer account to an existing customer
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        public void AddAccount(int customerNumber, string accountType)
        {
            
            if (accountType == "Omni")
            {
                Omni newOmni = new Omni(customerNumber, setAccountID(customerNumber, accountType));
                customerAccounts.Add(newOmni);
                WriteAccountsBinaryData();
            }
            else if (accountType == "Investment")
            {
                Investment newInvest = new Investment(customerNumber, setAccountID(customerNumber, accountType));
                customerAccounts.Add(newInvest);
                WriteAccountsBinaryData();
            }
            else if (accountType == "Everyday")
            {
                Everyday newEveryday = new Everyday(customerNumber, setAccountID(customerNumber, accountType));
                customerAccounts.Add(newEveryday);
                WriteAccountsBinaryData();
            }
            
            
        }

        
        /// <summary>
        /// Code to get the balance of an account related to a customer number, account number
        /// and account type
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountNumber">The unique number allocated to a customer's account</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        /// <returns>Returns the balance of an account associated with the given parameter details</returns>
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

        /// <summary>
        /// Code to calculate the new balance of an account for a deposit
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountNumber">The unique number allocated to a customer's account(s)</param>
        /// <param name="depositAmount">The amount required to be deposited into the specified account</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        /// <returns>Returns the new balance following the deposit</returns>
        public double CompleteDeposit(int customerNumber, int accountNumber, int depositAmount, string accountType)
        {
            double previousBalance = GetAccountBalance(customerNumber, accountNumber, accountType);
            double newBalance = previousBalance + Convert.ToDouble(depositAmount);
            return newBalance;
        }

        /// <summary>
        /// Code to calculate whether an account is able to have the amount successfully withdrawn
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <param name="accountNumber">The unique number allocated to a customer's account</param>
        /// <param name="withdrawalAmount">The amount required to be withdrawn from a given account</param>
        /// <param name="accountType">The type of account; either omni, investment or everyday</param>
        /// <returns>Returns true if the account can withdraw the requested amount without entering a 
        /// negative amount. Returns false if a negative amount will be returned</returns>
        public Boolean CompleteWithdrawal(int customerNumber, int accountNumber, int withdrawalAmount, string accountType)
        {
            double previousBalance = GetAccountBalance(customerNumber, accountNumber, accountType);
            if (previousBalance < withdrawalAmount)
            {
                return false;
            }
            else
            {
                return true;
            }
   
        }

        /// <summary>
        /// Code used to calculate the new balance after a withdrawal from an account
        /// </summary>
        /// <param name="previousBal">Previous balance of the account prior to withdrawal</param>
        /// <param name="withdrawalAmount">Amount required to be withdrawn from the account's balance</param>
        /// <returns>The new balance for the account after the withdrawal is returned</returns>
        public double WithdrawalSuccessBalance(double previousBal, int withdrawalAmount)
        {
            double doubleWithdrawal = Convert.ToDouble(withdrawalAmount);
            double newBal = previousBal - withdrawalAmount;
            return newBal;
        }
        


        /// <summary>
        /// Code to display the information of a customer from their customer number if the customer
        /// already exists
        /// </summary>
        /// <param name="customerNumber">The unique number allocated to a customer</param>
        /// <returns>Returns the ID number, first name, last name and contact number of a customer</returns>
        public string CustomerInfoDisplay(int customerNumber)
        {
            string displayString;

            int customerID;
            string customerFirstName = "";
            string customerLastName = "";
            long customerContact = 0;

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
