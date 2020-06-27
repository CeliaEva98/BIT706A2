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
    public partial class EditCustomer : Form
    {
        Controller control = new Controller();
        public EditCustomer()
        {
            
            InitializeComponent();
            labelUserMessage.Text = "";
            control.ReadAccountsBinaryData();
            control.ReadCustomerBinaryData();
            
        }



        public void setLabelText(string labelText)
        {
            labelIDNum.Text = labelText;
        }

        public void setFirstName(string custFirstName)
        {
            textBoxFirstName.Text = custFirstName;
        }

        public void setLastName(string custLastName)
        {
            textBoxLastName.Text = custLastName;
        }

        public void setContactNum(long custContactNum)
        {
            textBoxContact.Text = custContactNum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            int customerID = Int32.Parse(labelIDNum.Text);
            string customerFirstName = textBoxFirstName.Text;
            string customerLastName = textBoxLastName.Text;
            long customerContactNum = Convert.ToInt64(textBoxContact.Text);
            string customerType = "";

            if(checkBoxOther.Checked)
            {
                customerType = "Other";
            }
            else if (checkBoxStaff.Checked)
            {
                customerType = "Staff";
            }
            else
            {
                labelUserMessage.Text = "Please select a cusotomer type and try again.";
            }

            if (textBoxContact.Text.All(Char.IsNumber) != true)
            {
                labelUserMessage.Text = "Please enter a valid contact number. Letters are not permitted.";
            }
            else if (textBoxFirstName.Text.All(Char.IsLetter) != true)
            {
                labelUserMessage.Text = "Please enter a valid first name. Numbers are not permitted.";
            }
            else if (textBoxLastName.Text.All(Char.IsLetter) != true)
            {
                labelUserMessage.Text = "Please enter a valid last name. Numbers are not permitted.";
            }
            else
            {
                control.UpdateCustomerDetails(customerID, customerType, customerFirstName, customerLastName, customerContactNum);
                labelUserMessage.Text = "Customer details successfully updated!";
            }
            

            
        }
    }
}
