namespace JewelryStoreManagmentSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar.Value = startpoint;
            PercentageLbl.Text = startpoint + "%";
            if (ProgressBar.Value == 100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
