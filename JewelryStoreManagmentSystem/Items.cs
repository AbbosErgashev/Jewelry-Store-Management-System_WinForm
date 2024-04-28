using System.Data;
using System.Data.SqlClient;

namespace JewelryStoreManagmentSystem
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=jewelry_store_db;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Save()
        {
            if (ItemNameTbl.Text == "" || PriceTbl.Text == "" || QuantityTbl.Text == "" || CategoriesCb.SelectedIndex == -1 || TypesCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ItemTbl values('" + ItemNameTbl.Text + "', '" + CategoriesCb.SelectedItem.ToString() + "','" + TypesCb.SelectedItem.ToString() + "'," + PriceTbl.Text + "," + QuantityTbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Saved Successfully");
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

        private void ProductListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNameTbl.Text = ProductListDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            CategoriesCb.SelectedItem = ProductListDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            TypesCb.SelectedItem = ProductListDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            PriceTbl.Text = ProductListDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            QuantityTbl.Text = ProductListDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (ItemNameTbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            {
                ItemNameTbl.Text = "";
                CategoriesCb.SelectedIndex = -1;
                TypesCb.SelectedIndex = -1;
                PriceTbl.Text = "";
                QuantityTbl.Text = "";
                key = 0;
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
                    string query = "delete from ItemTbl where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully");
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

        private void UpdateItem()
        {
            if (ItemNameTbl.Text == "" || PriceTbl.Text == "" || QuantityTbl.Text == "" || CategoriesCb.SelectedIndex == -1 || TypesCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ItemTbl set ItemName='" + ItemNameTbl.Text + "', ItemCategory='" + CategoriesCb.SelectedItem.ToString() + "', ItemType='" + TypesCb.SelectedItem.ToString() + "', ItemPrice='" + PriceTbl.Text + "', ItemQuantity='" + QuantityTbl.Text + "' where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item  Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void FilterByCategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemCategory='" + FilterCat.SelectedItem.ToString() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterByType()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemType='" + FilterTy.SelectedItem.ToString() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductListDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CustomerLbl()
        {
            Customers customers = new Customers();
            customers.Show();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void CustomersLbl_Click(object sender, EventArgs e)
        {
            CustomerLbl();
        }

        private void FilterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void FilterTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByType();
        }

        private void ResetFilter_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
