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
        public EditCustomer()
        {
            Controller control = new Controller();
            InitializeComponent();
            
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

        public void setContactNum(int custContactNum)
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
    }
}
