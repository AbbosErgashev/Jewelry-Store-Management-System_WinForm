using System.Data;
using System.Data.SqlClient;

namespace JewelryStoreManagmentSystem
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            Populate();
            DisplayCustomer();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=jewelry_store_db;Integrated Security=True;Encrypt=False");
        int key = 0;
        int stock = 0;
        int n = 0;
        int GrdTotal = 0;
        int CustomerKey = 0;

        private void Populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void DisplayCustomer()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTbl.Text = ProductsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            PriceTbl.Text = ProductsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (ProductsDGV.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                stock = Convert.ToInt32(ProductsDGV.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }

        private void AddBill()
        {
            if (QtyTbl.Text == "" /*Convert.ToInt32(QtyTbl.Text) > stock*/)
            {
                MessageBox.Show("No Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTbl.Text) * Convert.ToInt32(PriceTbl.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = PNameTbl.Text;
                newRow.Cells[2].Value = PriceTbl.Text;
                newRow.Cells[3].Value = QtyTbl.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "$  " + GrdTotal;
                n++;
                UpdateStock();
            }
        }

        private void UpdateStock()
        {
            try
            {
                int newStock = stock - Convert.ToInt32(QtyTbl.Text);
                Con.Open();
                string query = "update ItemTbl set ItemQuantity=" + newStock + " where ItemId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Item Updated Successfully");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            AddBill();
        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTbl.Text = CustomersDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (CNameTbl.Text == "")
            {
                CustomerKey = 0;
            }
            else
            {
                CustomerKey = Convert.ToInt32(CustomersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewBills viewBills = new ViewBills();
            viewBills.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
