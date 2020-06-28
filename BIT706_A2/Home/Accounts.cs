using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    [Serializable]
    public class Accounts
    {
        protected int customerNumber;
        protected string accountType;
        protected int accountID;
        protected double interestRate = 0.04;
        protected int overdraftLimit;
        protected int accountFee = 10;
        private double accountBalance = 0;
        private double previousBalance = 0;
        protected double interestTotal;
        


        public Accounts(int customerIDNumber, int newAccountID, string newAccountType)
        {
            customerNumber = customerIDNumber;
            accountID = newAccountID;
            accountType = newAccountType;
        }

        public Accounts(int customerIDNumber, int newAccountID, string newAccountType, double balance)
        {
            customerNumber = customerIDNumber;
            accountID = newAccountID;
            accountType = newAccountType;
            accountBalance = balance;
        }

        public Accounts()
        {
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public int AccountID
        {
            get { return accountID; }
        }

        public double Balance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public double Interest
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public int Overdraft
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public int Fee
        {
            get { return accountFee; }
            set { accountFee = value; }
        }

        public double interestAmt()
        {
            interestTotal = accountBalance * interestRate;
            accountBalance += interestTotal;
            return interestTotal;
        }

        public string interestString()
        {
            string interestString = accountType + accountID + "; Interest Amount Added: $" + interestTotal + "; New Balance: $" +
                accountBalance;
            return interestString;
        }

        public String Info()
        {
            string outputString = accountType + " " + accountID.ToString() + "; Interest Rate " + (interestRate * 100) + "; Overdraft Limit $" +
                overdraftLimit + "; Fee $" + accountFee + "; Balance $" + accountBalance;
            return outputString;
        }
    }
}
