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
        String selectedItem;
        Boolean IDentered = false;


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

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            transactionType = "deposit";

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
                buttonContinue.Text = "Deposit";
                
                
            }
            else if (transactionType == "withdraw" && textBoxAmount.Text != null && itemSelected == true)
            {
                buttonContinue.Text = "Withdraw";
            }
            
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSelected = false;
            if (listBoxAccounts.SelectedIndex >= 0)
            {
                selectedItem = listBoxAccounts.SelectedItem.ToString();
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
                    if (control.GetCustomerAccounts(enteredID) != null)
                    {
                        listBoxAccounts.DataSource = control.GetCustomerAccounts(enteredID);
                        IDentered = true;
                    }
                    else
                    {
                        labelError.Text = "No accounts to display.";
                        
                    }
                }
                if (IDentered == true)
                {
                    buttonDeposit.Show();
                    buttonWithdraw.Show();
                    buttonTransfer.Show();
                    buttonAddInterest.Show();
                }
            }
        }
    }
}
