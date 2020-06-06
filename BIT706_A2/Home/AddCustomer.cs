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
    public partial class AddCustomer : Form
    {
        Controller control = new Controller();

        public AddCustomer()
        {
            InitializeComponent();
            labelError.Text = "";
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";
            string contactNumberString = "";
            int contactNumber = 0;
            Boolean firstNameCorrect = false;
            Boolean lastNameCorrect = false;
            Boolean contactNumberCorrect = false;

            if (textBoxFirstName.Text != null)
            {
                firstName = textBoxFirstName.Text;
                firstNameCorrect = true;
            }
            else
            {
                labelError.Text = "Please enter a valid first name";
                textBoxFirstName.Text = "";
                firstNameCorrect = false;
            }
            if (textBoxLastName.Text != null)
            {
                lastName = textBoxLastName.Text;
                lastNameCorrect = true;
            }
            else
            {
                labelError.Text = "Please enter a valid last name";
                textBoxLastName.Text = "";
                lastNameCorrect = false;
            }
            if (textBoxContact.Text != null)
            {
                contactNumberString = textBoxContact.Text;
                if (contactNumberString.Any(Char.IsLetter))
                {
                    labelError.Text = "Please enter a valid contact number. Letters are not permitted!";
                }
                else
                {
                    contactNumber = Int32.Parse(contactNumberString);
                    contactNumberCorrect = true;
                }
            }
            else
            {
                labelError.Text = "Please enter a valid contact number.";
                textBoxContact.Text = "";
                contactNumberCorrect = false;
            }
            if (firstNameCorrect && lastNameCorrect && contactNumberCorrect)
            {
                int correspondingCustomerID = control.CreateCustomer(firstName, lastName, contactNumber);
                if (control.FindCustomer(correspondingCustomerID) != null)
                {
                    labelError.Text = "New customer added successfully! Customer ID is: " + correspondingCustomerID;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxContact.Text = "";
                }
                else
                {
                    labelError.Text = "Customer could not be added. Please try again!";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu newMenu = new Menu();
            newMenu.Show();
        }
    }
}
