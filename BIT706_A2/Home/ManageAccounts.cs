using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class ManageAccounts : Form
    {
        Controller control = new Controller();
        string transactionType = null;
        int enteredAmount = 0;
        Boolean itemSelected;
        int selectedAccountIndex = 0;
        Boolean IDentered = false;
        int selectedAccountID = 0;
        string selectedAccountType = "";
        List<Accounts> listBoxDisplay = new List<Accounts>();
        Boolean transferItemSelected = false;
        int selectedTransferID = 0;
        string selectedTransferAccountType = "";
        int selectedTransferIndex = 0;
        Boolean accountsNoMatch;

        public ManageAccounts()
        {
            InitializeComponent();
            labelError.Text = "";
            labelCustDetails.Text = "";
            
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            listBoxAccountsTransfer.Show();
            hideAmountsGroupBoxItems();
            populateTransferListBox(Int32.Parse(labelCustDetails.Text));
        }

        private void showAmountsGroupBoxItems()
        {
            groupBoxAmounts.Show();
            textBoxAmount.Show();
            buttonCancel.Show();
            buttonContinue.Show();
        }

        private void hideAmountsGroupBoxItems()
        {
            groupBoxAmounts.Hide();
            textBoxAmount.Hide();
            buttonCancel.Hide();
            buttonContinue.Hide();
        }

        private void showTransferGroupBoxItems()
        {
            groupBoxTransfer.Show();
            textBoxTransfer.Show();
            buttonTransf.Show();
            buttonCancelTransfer.Show();
        }

        private void hideTransferGroupBoxItems()
        {
            groupBoxTransfer.Hide();
            textBoxTransfer.Hide();
            buttonTransf.Hide();
            buttonCancelTransfer.Hide();
        }

        private void showTransactionButtons()
        {
            buttonDeposit.Show();
            buttonWithdraw.Show();
            buttonTransfer.Show();
            buttonAddInterest.Show();
        }

        private void hideTransationButtons()
        {
            buttonDeposit.Hide();
            buttonWithdraw.Hide();
            buttonTransfer.Hide();
            buttonAddInterest.Hide();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            transactionType = "deposit";
            buttonContinue.Text = "Deposit";
            showAmountsGroupBoxItems();
            listBoxAccountsTransfer.Hide();
            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            hideAmountsGroupBoxItems();
            transactionType = null;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            int customerID = Int32.Parse(labelCustDetails.Text);
            int enteredAmount = Int32.Parse(textBoxAmount.Text);
            if (textBoxAmount.Text == null)
            {
                labelError.Text = "Please enter a valid amount to " + transactionType + ".";
            }
            else
            {
                enteredAmount = Int32.Parse(textBoxAmount.Text);
            }

            if (transactionType == "deposit" && textBoxAmount.Text != null && itemSelected == true)
            {
                double newBalance = control.CompleteDeposit(customerID, selectedAccountID, enteredAmount, selectedAccountType);
                control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType, newBalance);
                populateListBox(Int32.Parse(labelCustDetails.Text));
                hideAmountsGroupBoxItems();
                hideTransationButtons();
            }
            else if (transactionType == "withdraw" && textBoxAmount.Text != null && itemSelected == true)
            {
                double previousBalance = control.GetAccountBalance(customerID, selectedAccountID, selectedAccountType);
                if (previousBalance >= enteredAmount)
                {
                    double newBalance = control.CompleteWithdrawal(customerID, selectedAccountID, enteredAmount, selectedAccountType);
                    control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType, newBalance);
                    populateListBox(Int32.Parse(labelCustDetails.Text));
                    hideAmountsGroupBoxItems();
                    hideTransationButtons();
                }
                else
                {
                    labelError.Text = "Withdrawal amount exceeds available balance. Please try again.";
                    textBoxAmount.Text = "";
                }
                
            }
            
        }

        private Boolean transferBetweenAccounts(double transferAmount)
        {
            double firstAccountBal = control.GetAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType);
            double secondAccountBal = control.GetAccountBalance(Int32.Parse(labelCustDetails.Text), selectedTransferID, selectedTransferAccountType);
            if (firstAccountBal < transferAmount)
            {
                labelError.Text = "Amount to transfer is more than first account balance. Please try again";
                return false;
            }
            else
            {
                double newFirstAccountBal = firstAccountBal - transferAmount;
                double newSecondAccountBal = secondAccountBal + transferAmount;
                control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType, newFirstAccountBal);
                control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedTransferID, selectedTransferAccountType, newSecondAccountBal);
                return true;
            }
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            itemSelected = false;
            
            if (listBoxAccounts.SelectedIndex >= 0)
            {
                selectedAccountIndex = listBoxAccounts.SelectedIndex;
                selectedAccountID = listBoxDisplay[selectedAccountIndex].AccountID;
                selectedAccountType = listBoxDisplay[selectedAccountIndex].AccountType;
                showTransactionButtons();                
                itemSelected = true;
                if (transferItemSelected)
                {
                    if (selectedAccountID == selectedTransferID && selectedTransferAccountType == selectedAccountType)
                    {
                        labelError.Text = "Please select different accounts to transfer.";
                        accountsNoMatch = false;
                        hideTransferGroupBoxItems(); 
                    }
                    else
                    {
                        labelError.Text = "";
                        accountsNoMatch = true;
                        showTransferGroupBoxItems();
                    }
                }
            }
            else
            {
                labelError.Text = "Please select an account.";
                hideTransationButtons();
                itemSelected = false;
            }
            
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount newAccount = new AddAccount();
            newAccount.Show();
        }

        private void populateListBox(int customerID)
        {
            listBoxAccounts.Items.Clear();
            if (control.GetCustomerAccounts(customerID) != null)
            {
                int i = 0;
                listBoxDisplay = control.GetCustomerAccounts(customerID);
                foreach (Accounts acc in listBoxDisplay)
                {
                    int listLength = listBoxDisplay.Count();

                    while (i < listLength)
                    {
                        string displayItem = "";
                        displayItem = listBoxDisplay[i].AccountType.ToString() + "\t" + listBoxDisplay[i].AccountID.ToString() + "\t $"
                            + listBoxDisplay[i].Balance.ToString();
                        listBoxAccounts.Items.Add(displayItem);
                        i++;
                    }
                }
            }
            else
            {
                labelError.Text = "No accounts to display.";

            }
        }

        private void populateTransferListBox(int customerID)
        {
            listBoxAccountsTransfer.Items.Clear();
            if (control.GetCustomerAccounts(customerID) != null)
            {
                int i = 0;
                listBoxDisplay = control.GetCustomerAccounts(customerID);
                foreach (Accounts acc in listBoxDisplay)
                {
                    int listLength = listBoxDisplay.Count();

                    while (i < listLength)
                    {
                        string displayItem = "";
                        displayItem = listBoxDisplay[i].AccountType.ToString() + "\t" + listBoxDisplay[i].AccountID.ToString() + "\t $"
                            + listBoxDisplay[i].Balance.ToString();
                        listBoxAccountsTransfer.Items.Add(displayItem);
                        i++;
                    }
                }
            }
            else
            {
                labelError.Text = "No accounts to display.";

            }
        }
    

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Customer customer = null;
            int enteredID = -1;
            if (textBoxEnteredID.Text != "")
            {
                labelError.Text = "";
                if (textBoxEnteredID.Text.All(Char.IsNumber))
                {
                    enteredID = Int32.Parse(textBoxEnteredID.Text);
                    customer = control.FindCustomer(enteredID);
                }
                else
                {
                    labelError.Text = "Please only entered numbers for the ID. Please try again.";
                    textBoxEnteredID.Text = "";
                }
                
                if (customer == null)
                {
                    labelError.Text = "No customer found with the ID. Please try again.";
                }
                else
                {
                    labelCustDetails.Text = enteredID.ToString();
                    populateListBox(enteredID);
                }
                if (IDentered == true)
                {
                    buttonDeposit.Show();
                    buttonWithdraw.Show();
                    buttonTransfer.Show();
                    buttonAddInterest.Show();
                }
                else
                {
                    buttonDeposit.Hide();
                    buttonWithdraw.Hide();
                    buttonTransfer.Hide();
                    buttonAddInterest.Hide();
                }
            }
            else
            {
                labelError.Text = "Please enter a valid ID number.";
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            buttonContinue.Text = "Withdraw";
            transactionType = "withdraw";
            showAmountsGroupBoxItems();
            listBoxAccountsTransfer.Hide();
        }

        private void listBoxAccountsTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAccountsTransfer.SelectedIndex >= 0)
            {
                selectedTransferIndex = listBoxAccountsTransfer.SelectedIndex;
                selectedTransferID = listBoxDisplay[selectedTransferIndex].AccountID;
                selectedTransferAccountType = listBoxDisplay[selectedTransferIndex].AccountType;
                transferItemSelected = true;
            }
            else
            {
                labelError.Text = "Please select an account.";
                transferItemSelected = false;
                return;
            }

            if (selectedAccountID == selectedTransferID && selectedTransferAccountType == selectedAccountType)
            {
                labelError.Text = "Please select different accounts to transfer.";
                hideTransferGroupBoxItems();
            }
            else
            {
                labelError.Text = "";
                showTransferGroupBoxItems();
            }
        }

        private void buttonTransf_Click(object sender, EventArgs e)
        {
            if (textBoxTransfer.Text.All(Char.IsNumber))
            {
                double transferAmount = Convert.ToDouble(textBoxTransfer.Text);
                Boolean transferSuccess = transferBetweenAccounts(transferAmount);
                populateListBox(Int32.Parse(labelCustDetails.Text));
                populateTransferListBox(Int32.Parse(labelCustDetails.Text));
            }
            else
            {
                labelError.Text = "Please enter valid transfer amount. Numbers only";
                textBoxTransfer.Text = "";
            }
        }

        private void buttonCancelTransfer_Click(object sender, EventArgs e)
        {
            hideTransferGroupBoxItems();
        }

        private void buttonAddInterest_Click(object sender, EventArgs e)
        {
            double newAccountBal = control.getInterest(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType);
            control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType, newAccountBal);
            populateListBox(Int32.Parse(labelCustDetails.Text));
        }
    }
}
