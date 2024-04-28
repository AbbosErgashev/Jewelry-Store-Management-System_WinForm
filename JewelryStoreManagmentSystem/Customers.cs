using System.Data;
using System.Data.SqlClient;

namespace JewelryStoreManagmentSystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=jewelry_store_db;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Save()
        {
            if (CNameTbl.Text == "" || CPhoneTbl.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values('" + CNameTbl.Text + "', '" + CPhoneTbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Saved Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCustomer()
        {
            if (CNameTbl.Text == "" || CPhoneTbl.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CustomerTbl set CustomerName='" + CNameTbl.Text + "', CustomerPhone='" + CPhoneTbl.Text + "' where CustomerId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer  Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Delete()
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CustomerTbl where CustomerId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            {
                CNameTbl.Text = "";
                CPhoneTbl.Text = "";
                key = 0;
            }
        }

        private void ProductsLbl_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CustomersListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTbl.Text = CustomersListDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            CPhoneTbl.Text = CustomersListDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (CNameTbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustomersListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
