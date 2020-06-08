using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A2_PartB
{
    public partial class Form1 : Form
    {
        Omni a = new Omni();
        Investment b = new Investment();
        Everyday c = new Everyday();


        public Form1()
        {
            InitializeComponent();
            infoLabel.Text = "";
            labelError.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void errorMessage()
        {
            labelError.Text = "Error: Please enter a valid number or input";
            labelError.Refresh();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            checkText();
            if (!checkText())
            {
                string depositString = "";
                double depositValue = Convert.ToDouble(textBoxAmount.Text);
                if (checkBoxOmni.Checked)
                {
                    a.deposit(depositValue);
                    depositString = a.depositMessage(depositValue);
                    infoLabel.Text = depositString;
                }
                else if (checkBoxInvest.Checked)
                {
                    b.deposit(depositValue);
                    depositString = b.depositMessage(depositValue);
                    infoLabel.Text = depositString;
                }
                else if (checkBoxEveryday.Checked)
                {
                    c.deposit(depositValue);
                    depositString = c.depositMessage(depositValue);
                    infoLabel.Text = depositString;
                }
                else
                {
                    labelError.Text = "Error: Please select a checkbox";
                    labelError.Refresh();
                }
            }
            else
            {
                errorMessage();
            }
        }

        private void groupBoxAccounts_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxOmni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOmni.Checked)
            {
                checkBoxEveryday.Checked = false;
                checkBoxInvest.Checked = false;
            }

        }

        private void checkBoxEveryday_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEveryday.Checked)
            {
                checkBoxInvest.Checked = false;
                checkBoxOmni.Checked = false;
            }

        }

        private void checkBoxInvest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInvest.Checked)
            {
                checkBoxOmni.Checked = false;
                checkBoxEveryday.Checked = false;
            }

        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {
            String accountInfo = "";
            if (checkBoxEveryday.Checked)
            {

                accountInfo = c.Info();
            }
            else if (checkBoxOmni.Checked)
            {
                accountInfo = a.Info();
            }
            else if (checkBoxInvest.Checked)
            {
                accountInfo = b.Info();
            }
            infoLabel.Text = accountInfo;
            infoLabel.Refresh();

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private Boolean checkText()
        {
            if (textBoxAmount.Text != null)
            {
                String alphabet = "abcdefghijklmnopqrstuvwxyz";
                int i = 0;
                while (i < alphabet.Length)
                {
                    if (textBoxAmount.Text.Contains(alphabet[i]))
                    {
                        return true;
                    }
                    i++;
                }
            }
            return false;
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            String withdrawOutput;
            int textboxText;
            if (!checkText())
            {
                textboxText = Int32.Parse(textBoxAmount.Text);
                if (checkBoxOmni.Checked)
                {
                    a.withdraw(Int32.Parse(textBoxAmount.Text));
                    withdrawOutput = a.withdrawStatement(a.withdrawSuccess(textboxText), textboxText);
                    infoLabel.Text = withdrawOutput;
                }
                else if (checkBoxInvest.Checked)
                {
                    b.withdraw(Int32.Parse(textBoxAmount.Text));
                    withdrawOutput = b.withdrawStatement(b.withdrawSuccess(textboxText), textboxText);
                    infoLabel.Text = withdrawOutput;
                }
                else if (checkBoxInvest.Checked)
                {
                    c.withdraw(Int32.Parse(textBoxAmount.Text));
                    withdrawOutput = c.withdrawStatement(c.withdrawSuccess(textboxText), textboxText);
                    infoLabel.Text = withdrawOutput;
                }
                else
                {
                    labelError.Text = "Error: Please select a checkbox";
                    labelError.Refresh();
                }
            }
            else
            {
                errorMessage();
            }
        }

        private void buttonInterest_Click(object sender, EventArgs e)
        {
            String interestOutput = "";
            if (checkBoxOmni.Checked)
            {
                a.interestAmt();
                interestOutput = a.interestString();
                infoLabel.Text = interestOutput;
            }
            else if (checkBoxInvest.Checked)
            {
                b.investInterestRates();
                b.interestAmt();
                interestOutput = b.interestString();
                infoLabel.Text = interestOutput;
            }
            else if (checkBoxEveryday.Checked)
            {
                c.interestAmt();
                interestOutput = c.interestString();
                infoLabel.Text = interestOutput;
            }
            else
            {
                labelError.Text = "Error: Please select a checkbox";
                labelError.Refresh();
            }
        }
    }
}
