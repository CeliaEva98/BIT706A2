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
        string transactionType = "";
        

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
    }
}
