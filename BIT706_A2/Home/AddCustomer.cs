﻿using System;
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

            if (textBoxFirstName.Text != null && textBoxLastName.Text != "")
            {
                if (textBoxFirstName.Text.Any(Char.IsNumber)) 
                {
                    labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
                    textBoxFirstName.Text = "";
                }
                else
                {
                    firstName = textBoxFirstName.Text;
                    firstNameCorrect = true;
                }
            }
            else
            {
                labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
                textBoxFirstName.Text = "";
                firstNameCorrect = false;
            }


            if (textBoxLastName.Text != null && textBoxLastName.Text != "")
            {
                if (textBoxLastName.Text.All(Char.IsLetter) != true)
                {
                    labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
                    textBoxLastName.Text = "";
                }
                else
                {
                    lastName = textBoxLastName.Text;
                    lastNameCorrect = true;
                } 
            }
            else
            {
                labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
                textBoxLastName.Text = "";
                lastNameCorrect = false;
            }


            if (textBoxContact.Text != null && textBoxContact.Text != "")
            {
                contactNumberString = textBoxContact.Text;
                if (contactNumberString.Any(Char.IsLetter))
                {
                    labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
                    textBoxContact.Text = "";
                }
                else
                {
                    contactNumber = Int32.Parse(contactNumberString);
                    contactNumberCorrect = true;
                }
            }
            else
            {
                labelError.Text = "INVALID ENTRIES. Invalid details cleared. Please try again!";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
