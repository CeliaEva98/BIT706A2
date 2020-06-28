using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Home;
using System.Collections.Generic;

namespace GherkinRequirementsTests
{
    [TestClass]
    public class GherkinTests
    {

        Controller control = new Controller();


        [TestMethod]
        public void Withdraw_Omni_Failure_Test()
        {
            string exceptedResult = "Failure";
            string result;
            int customerIDNum = control.setCustomerID();
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNum = control.setAccountID(customerIDNum, "Omni");
            int withdrawAmt = 200;


            Accounts acc = new Accounts(customerIDNum, accountIDNum, "Omni");
            double previousBal = control.GetAccountBalance(customerIDNum, accountIDNum, "Omni");
            if (control.CompleteWithdrawal(customerIDNum, accountIDNum, withdrawAmt, "Omni"))
            {
                control.WithdrawalSuccessBalance(previousBal, withdrawAmt);
                result = "Success";
            }
            else
            {
                result = "Failure";
            }
            Assert.AreEqual(exceptedResult, result);
        }

        [TestMethod]
        public void Withdraw_Everyday_Failure_Test()
        {
            string exceptedResult = "Failure";
            string result;
            int customerIDNum = control.setCustomerID();
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNum = control.setAccountID(customerIDNum, "Everyday");
            int withdrawAmt = 200;


            Accounts acc = new Accounts(customerIDNum, accountIDNum, "Everyday");
            double previousBal = control.GetAccountBalance(customerIDNum, accountIDNum, "Everyday");
            if (control.CompleteWithdrawal(customerIDNum, accountIDNum, withdrawAmt, "Everyday"))
            {
                control.WithdrawalSuccessBalance(previousBal, withdrawAmt);
                result = "Success";
            }
            else
            {
                result = "Failure";
            }
            Assert.AreEqual(exceptedResult, result);
        }

        [TestMethod]
        public void Withdraw_Investment_Failure_Test()
        {
            string exceptedResult = "Failure";
            string result;
            int customerIDNum = control.setCustomerID();
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNum = control.setAccountID(customerIDNum, "Investment");
            int withdrawAmt = 200;


            Accounts acc = new Accounts(customerIDNum, accountIDNum, "Investment");
            double previousBal = control.GetAccountBalance(customerIDNum, accountIDNum, "Investment");
            if (control.CompleteWithdrawal(customerIDNum, accountIDNum, withdrawAmt, "Investment"))
            {
                control.WithdrawalSuccessBalance(previousBal, withdrawAmt);
                result = "Success";
            }
            else
            {
                result = "Failure";
            }
            Assert.AreEqual(exceptedResult, result);
        }

        [TestMethod]
        public void Transfer_Between_Accounts_Failure_Test()
        {
            string expectedResult = "Failure";
            string result;
            int customerIDNum = control.setCustomerID();
            int transferAmount = 500;
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNumFirstAcc = control.setAccountID(customerIDNum, "Everyday");
            int accountIDNumSecondAcc = control.setAccountID(customerIDNum, "Everyday");

            Accounts firstAcc = new Accounts(customerIDNum, accountIDNumFirstAcc, "Everyday");
            Accounts secondAcc = new Accounts(customerIDNum, accountIDNumSecondAcc, "Everyday", 5000);

            double firstAccBal = control.GetAccountBalance(customerIDNum, accountIDNumFirstAcc, "Everyday");
            double secondAccBal = control.GetAccountBalance(customerIDNum, accountIDNumSecondAcc, "Everyday");

            if (firstAccBal < transferAmount)
            {
                result = "Failure";
            }
            else {
                double newFirstAccBal = firstAccBal - transferAmount;
                double newSecondAccBal = secondAccBal + transferAmount;
                control.UpdateAccountBalance(customerIDNum, accountIDNumFirstAcc, "Everyday", newFirstAccBal);
                control.UpdateAccountBalance(customerIDNum, accountIDNumSecondAcc, "Everyday", newSecondAccBal);
                result = "Success";
            }
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Transfer_Between_Accounts_Success_Test()
        {
            string expectedResult = "Success";
            string result;
            int customerIDNum = control.setCustomerID();
            int transferAmount = 500;

            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNumFirstAcc = control.setAccountID(customerIDNum, "Everyday");
            Accounts firstAcc = new Accounts(customerIDNum, accountIDNumFirstAcc, "Everyday", 500);
            control.customerAccounts.Add(firstAcc);

            int accountIDNumSecondAcc = control.setAccountID(customerIDNum, "Everyday");
            Accounts secondAcc = new Accounts(customerIDNum, accountIDNumSecondAcc, "Everyday");
            control.customerAccounts.Add(secondAcc);

            double firstAccBal = control.GetAccountBalance(customerIDNum, accountIDNumFirstAcc, "Everyday");
            double secondAccBal = control.GetAccountBalance(customerIDNum, accountIDNumSecondAcc, "Everyday");

            if (firstAccBal < transferAmount)
            {
                result = "Failure";
            }
            else
            {
                double newFirstAccBal = firstAccBal - transferAmount;
                double newSecondAccBal = secondAccBal + transferAmount;
                control.UpdateAccountBalance(customerIDNum, accountIDNumFirstAcc, "Everyday", newFirstAccBal);
                control.UpdateAccountBalance(customerIDNum, accountIDNumSecondAcc, "Everyday", newSecondAccBal);
                if (control.GetAccountBalance(customerIDNum, accountIDNumFirstAcc, "Everyday") == newFirstAccBal)
                {
                    if (control.GetAccountBalance(customerIDNum, accountIDNumSecondAcc, "Everyday") == newSecondAccBal) {
                        result = "Success";
                    }
                    else
                    {
                        result = "Failure";
                    }
                }
                else
                {
                    result = "Failure";
                }
            }
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_Account_Interest_Test()
        {
            double accountBal = 5000;
            double expectedInterestBal = 200;

            int customerIDNum = control.setCustomerID();
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNum = control.setAccountID(customerIDNum, "Everyday");
            Accounts acc = new Accounts(customerIDNum, accountIDNum, "Everyday", accountBal);
            control.customerAccounts.Add(acc);

            double resultAccountBal = control.getInterest(customerIDNum, accountIDNum, "Everyday");
            double expectedAccountBal = accountBal + expectedInterestBal;

            Assert.AreEqual(expectedAccountBal, resultAccountBal);


        }

        [TestMethod] 
        public void Deposit_Funds_Account_Test()
        {
            double accountBal = 5000;
            int depositAmt = 500;

            int customerIDNum = control.setCustomerID();
            Customer newCust = new Customer(customerIDNum, "Other", "Bob", "Jones", 2312313123);
            int accountIDNum = control.setAccountID(customerIDNum, "Everyday");
            Accounts acc = new Accounts(customerIDNum, accountIDNum, "Everyday", accountBal);
            control.customerAccounts.Add(acc);

            double resultAccountBal = control.CompleteDeposit(customerIDNum, accountIDNum, depositAmt, "Everyday");
            double expectedAccountBal = accountBal + depositAmt;
            Assert.AreEqual(expectedAccountBal, resultAccountBal);
        }

        [TestMethod]
        public void Add_New_Customer_Test()
        {
            string expectedResult = "Added";
            string actualResult;
            int newCustomerID = control.CreateCustomer("Other", "Bob", "Jones", 23233123123);
            if (control.FindCustomer(newCustomerID) == null)
            {
                actualResult = "Not Added";
            }
            else
            {
                actualResult = "Added";
            }
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Add_New_Customer_Account_Test()
        {
            string expectedResult = "Added";
            string actualResult;

            int newCustomerID = control.CreateCustomer("Other", "Bob", "Jones", 23233123123);
            control.AddAccount(newCustomerID, "Omni");
            List<Accounts> newList = new List<Accounts>();
            newList = control.GetCustomerAccounts(newCustomerID);
            if (newList.Count != 0)
            {
                actualResult = "Added";
            }
            else
            {
                actualResult = "Failed";
            }
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Edit_Entered_Customer_Details_Test()
        {
            string expectedResult = "Correct";
            string actualResult;
            int newCustomerID = control.CreateCustomer("Other", "Bob", "Jones", 23233123123);
            control.UpdateCustomerDetails(newCustomerID, "Other", "Billy", "Joel", 23233123123);
            if (control.GetFirstName(newCustomerID) != "Billy")
            {
                actualResult = "Incorrect";
            }
            else
            {
                actualResult = "Correct";
            }
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
