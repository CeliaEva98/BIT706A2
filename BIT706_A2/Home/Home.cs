using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Home
{
    public partial class Home : Form
    {
        Controller control = new Controller();
        

        public Home()
        {
            control.ReadAccountsBinaryData();
            control.ReadCustomerBinaryData();
            InitializeComponent();
            
            
            
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
