using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Accounts
    {
        protected int customerNumber;
        protected string accountType;
        static int nextAccountID = 1;
        private int accountID;
        protected double interestRate = 0.04;
        protected int overdraftLimit;
        protected int accountFee = 10;
        private double accountBalance = 0;
        private double previousBalance = 0;
        protected double interestTotal;
        

        public Accounts()
        {
            accountID = nextAccountID;
            nextAccountID++;
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

        public double deposit(double depositValue)
        {
            previousBalance = accountBalance;
            accountBalance += depositValue;
            return accountBalance;
        }

        public string depositMessage(double depositValue)
        {
            String depositMessage = accountType + accountID + "; Deposit: $" + depositValue + "; Previous Balance: $" +
                previousBalance + "; New Balance: $" + accountBalance + "; Successful Deposit!";
            return depositMessage;
        }

        public double withdraw(int withdrawValue)
        {
            Boolean withdrawalSuccess = withdrawSuccess(withdrawValue);
            if (withdrawalSuccess == false)
            {

                return accountBalance;
            }
            else
            {
                accountBalance -= withdrawValue;
                return accountBalance;
            }
        }

        public string withdrawStatement(Boolean success, int withdrawValue)
        {
            if (success)
            {
                String successString = accountType + accountID + "; Withdraw: $" + withdrawValue + "; Balance: $" + accountBalance;
                return successString;
            }
            String failString = accountType + accountID + "; Withdraw: $" + withdrawValue + "; Withdraw failed; Fee: $" + accountFee + "; Balance: $"
                + accountBalance;
            return failString;

        }

        public Boolean withdrawSuccess(int withdrawValue)
        {
            if (withdrawValue > Balance)
            {
                return false;
            }
            return true;
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
