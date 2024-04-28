namespace JewelryStoreManagmentSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTbl.Text == "useradmin")
                {
                    Billing billing = new Billing();
                    billing.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Password not Correct");
            }
        }

        private void CancelLbl_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
