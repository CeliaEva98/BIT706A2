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

        public ManageAccounts()
        {
            InitializeComponent();
            labelError.Text = "";
            
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            listBoxAccountsTransfer.Show();
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
                
                
                double newBalance = control.CompleteDeposit(Int32.Parse(labelCustDetails.Text), selectedAccountID, Int32.Parse(textBoxAmount.Text));
                control.UpdateAccountBalance(Int32.Parse(labelCustDetails.Text), selectedAccountID, selectedAccountType, newBalance);
                populateListBox(Int32.Parse(labelCustDetails.Text));
            }
            else if (transactionType == "withdraw" && textBoxAmount.Text != null && itemSelected == true)
            {
                
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
            }
            else
            {
                labelError.Text = "Please select an account.";
                itemSelected = false;
            }
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxEnteredID.Text != null)
            {
                int enteredID = Int32.Parse(textBoxEnteredID.Text);
                Customer customer = control.FindCustomer(enteredID);
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
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            buttonContinue.Text = "Withdraw";
        }
    }
}
