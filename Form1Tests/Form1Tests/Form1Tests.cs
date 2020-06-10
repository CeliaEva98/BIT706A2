using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BIT706_A2_PartB;

namespace Form1Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Check_Text_Alphabet_Invalid()
        {
            Form1 testForm = new Form1();
            testForm.textBoxAmount.Text = "324756776a";
            Boolean textCheck = testForm.checkText();

            Assert.IsTrue(textCheck);
        }

        [TestMethod]
        public void Check_Text_Numbers_Only()
        {
            Form1 testForm = new Form1();
            testForm.textBoxAmount.Text = "324756776";
            Boolean textCheck = testForm.checkText();

            Assert.IsFalse(textCheck);
        }

        [TestMethod]
        public void Omni_Deposit()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 800;
            testOmni.deposit(900);

            double omniNewBalance = testOmni.Balance;

            Assert.AreEqual(1700, omniNewBalance);
        }

        [TestMethod]
        public void Everyday_Deposit()
        {
            Everyday testEveryday = new Everyday();
            testEveryday.Balance = 350;
            testEveryday.deposit(350);

            double everydayNewBalance = testEveryday.Balance;

            Assert.AreEqual(700, everydayNewBalance);
        }

        [TestMethod]
        public void Investment_Deposit()
        {
            double depositAmount = 500;
            Investment testInvestment = new Investment();
            testInvestment.Balance = 0;
            testInvestment.deposit(depositAmount);

            double investmentNewBalance = testInvestment.Balance;

            Assert.AreEqual(depositAmount, investmentNewBalance);

        }

        [TestMethod]
        public void Omni_Interest_Over1000()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 1001;
            testOmni.interestAmt();
            double interestRate = testOmni.Interest;

            Assert.AreEqual(0.04, interestRate);
        }

        [TestMethod]
        public void Omni_Interest_Under1000()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 999;
            testOmni.interestAmt();
            double interestRate = testOmni.Interest;

            Assert.AreEqual(0.00, interestRate);
        }

        [TestMethod]
        public void Omni_Interest_1000()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 1000;
            testOmni.interestAmt();
            double interestRate = testOmni.Interest;

            Assert.AreEqual(0.04, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_First_Rate()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 500;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.01, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_First_Rate_0Bal()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 0;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.01, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_First_Rate_Under500()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 499;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.01, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_Second_Rate_Above500()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 501;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.02, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_Second_Rate_Under1000()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 999;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.02, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_Second_Rate_1000()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 1000;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.02, interestRate);
        }

        [TestMethod]
        public void Investment_Interest_Over1000()
        {
            Investment testInvestment = new Investment();
            testInvestment.Balance = 1001;
            testInvestment.investInterestRates();
            double interestRate = testInvestment.Interest;

            Assert.AreEqual(0.04, interestRate);
        }

        [TestMethod]
        public void Withdraw_Success_PositiveBal()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 600;
            int withdrawValue = 500;

            Assert.IsTrue(testOmni.withdrawSuccess(withdrawValue));
        }

        [TestMethod]
        public void Withdraw_Success_ZeroBal()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 600;
            int withdrawValue = 600;

            Assert.IsTrue(testOmni.withdrawSuccess(withdrawValue));
        }

        [TestMethod]
        public void Withdraw_Failure()
        {
            Omni testOmni = new Omni();
            testOmni.Balance = 600;
            int withdrawValue = 700;

            Assert.IsFalse(testOmni.withdrawSuccess(withdrawValue));
        }



    }
}
