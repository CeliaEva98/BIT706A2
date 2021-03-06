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
    public partial class Menu : Form
    {
        Controller control = new Controller();
        string enteredIDString;
        int enteredID;
        Boolean customerFound = false;
        
        

        public Menu()
        {
            InitializeComponent();
            labelDisplay.Text = "";
            control.ReadCustomerData();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addNew = new AddCustomer();
            addNew.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            string customerDisplay = "";
            
            if (control.CustomersList.Count == 0)
            {
                labelDisplay.Text = "No customers in database. Please add customers first";
            }
            else if (control.CustomersList.Count != 0)
            {
                enteredIDString = textBoxID.Text;
                if (enteredIDString.All(Char.IsNumber) != true)
                {
                    textBoxID.Text = "";
                    labelDisplay.Text = "Please enter a valid ID. Letters are not permitted.";
                }
                else
                {                   
                    enteredID = Int32.Parse(enteredIDString);
                    customerDisplay = control.CustomerInfoDisplay(enteredID);
                    labelDisplay.Text = customerDisplay;
                    if (customerDisplay != "No customer found with the entered ID. Please try again.")
                    {
                        customerFound = true;
                    }
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (customerFound == true)
            {
                int customerID = Int32.Parse(textBoxID.Text);
                control.DeleteCustomer(customerID);
                if (control.FindCustomer(customerID) != null)
                {
                    labelDisplay.Text = "Deletion unsuccessful. Please try again";
                }
                else
                {
                    labelDisplay.Text = "Customer successfully deleted!";
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            if (customerFound == true)
            {
                int customerID = Int32.Parse(textBoxID.Text);
                this.Hide();
                control.EditCustomer(customerID);
                
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home newHome = new Home();
            newHome.Show();
        }
    }
}
