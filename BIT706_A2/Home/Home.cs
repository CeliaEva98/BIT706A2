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
    public partial class Home : Form
    {
        public Home()
        {
            Controller control = new Controller();
            InitializeComponent();
            Accounts testAcc = new Accounts(1, 3, "fake");
            Controller.customerAccounts.Add(testAcc);
            Accounts testAcc2 = new Accounts(1, 45, "shit");
            Controller.customerAccounts.Add(testAcc2);
            int helpme = control.CreateCustomer("Shit", "poo", "bum", 021890212);
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void buttonManageAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAccounts newManage = new ManageAccounts();
            newManage.Show();
        }
    }
}
