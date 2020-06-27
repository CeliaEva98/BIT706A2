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
    public partial class AddAccount : Form
    {
        Controller control = new Controller();
        Boolean boxSelected = false;
        ManageAccounts newManage = new ManageAccounts();
        

        public AddAccount()
        {
            InitializeComponent();
            labelError.Text = "";
            control.ReadCustomerBinaryData();
            control.ReadAccountsBinaryData();
        }

        private void checkBoxOmni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOmni.Checked)
            {
                checkBoxInvest.Checked = false;
                checkBoxEveryday.Checked = false;
                boxSelected = true;
                
            }
            else
            {
                boxSelected = false;
            }
            
        }

        private void checkBoxEveryday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEveryday.Checked)
            {
                checkBoxInvest.Checked = false;
                checkBoxOmni.Checked = false;
                boxSelected = true;
            }
            else
            {
                boxSelected = false;
            }
        }

        private void checkBoxInvest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInvest.Checked)
            {
                checkBoxOmni.Checked = false;
                checkBoxEveryday.Checked = false;
                boxSelected = true;
            }
            else
            {
                boxSelected = false;
            }
        }

        private Boolean checkEnteredID()
        {
            if (textBoxCustID != null) {
                if (!textBoxCustID.Text.All(Char.IsNumber))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }

        private string selectedBox()
        {
            if (checkBoxOmni.Checked)
            {
                return "Omni";
            }
            else if (checkBoxInvest.Checked)
            {
                return "Investment";
            }
            else if (checkBoxEveryday.Checked)
            {
                return "Everyday";
            }
            else
            {
                return "None";
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            Boolean enteredIDCorrect = checkEnteredID();
           
            if (enteredIDCorrect != true)
            {
                labelError.Text = "Incorrect ID entered. Please try again";
            }
            else
            {
                int custID = Int32.Parse(textBoxCustID.Text);
                if (control.FindCustomer(custID) != null && boxSelected == true)
                {
                    string boxSelectedName = selectedBox();
                    if (boxSelectedName != "None")
                    {
                        control.AddAccount(custID, boxSelectedName);
                        this.Hide();
                        newManage.Show();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            newManage.Show();
        }
    }
}
