using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStoreManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTbl.Text == "" || UsernameTbl.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (UsernameTbl.Text == "Admin" && PasswordTbl.Text == "Password")
            {
                Items obj = new Items();
                obj.Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin billing = new Admin();
            billing.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
