using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopOtomation
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            displayProduct();
        }

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        int Key = 0;
        
        private void ClearTb()
        {
            NameTextb.Text = "";
            BuyPriceTextb.Text = "";
            SellPriceTextb.Text = "";
            QtityTextb.Text = "";
            CategoryDrop.selectedIndex = 0;
        }
        private void displayProduct()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ProductTbl", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        DataTable dt = new DataTable();

        DataView filter(string href, string value)
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = href + " like '" + value + "%'";
            ProductsDataGrid.DataSource= dv;
            return dv;
        }

        private void HomeSButton_Click(object sender, EventArgs e)
        {
            HomeScreen _homeScreen = new HomeScreen();
            _homeScreen.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm _customers = new CustomersForm();
            _customers.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm _login = new LoginForm();
            _login.Show();
            this.Hide();
        }

        private void PetsButton_Click(object sender, EventArgs e)
        {
            PetsForm _pets = new PetsForm();
            _pets.Show();
            this.Hide();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            SellingForm _invoiceForm = new SellingForm();
            _invoiceForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
                if (NameTextb.Text == "" || SellPriceTextb.Text == "" || BuyPriceTextb.Text == "" || QtityTextb.Text == ""|| CategoryDrop.selectedValue == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl (PrName, PrCategory, PrBuyPrice, PrSellPrice, PrStock) values(@PrName, @PrCategory, @PrBuyPrice, @PrSellPrice, @PrStock)", conn);

                    

                    cmd.Parameters.AddWithValue("@PrName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PrCategory", CategoryDrop.selectedValue);
                    cmd.Parameters.AddWithValue("@PrBuyPrice", BuyPriceTextb.Text);
                    cmd.Parameters.AddWithValue("@PrSellPrice", SellPriceTextb.Text);
                    cmd.Parameters.AddWithValue("@PrStock", QtityTextb.Text);



                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayProduct();
                    ClearTb();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void ProductsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDrop.Text = ProductsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SellPriceTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            BuyPriceTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            QtityTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            if (NameTextb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTextb.Text == "" || SellPriceTextb.Text == "" || BuyPriceTextb.Text == "" || QtityTextb.Text == "" || CategoryDrop.selectedValue == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update ProductTbl set PrName = @PrName, PrCategory = @PrCategory, PrBuyPrice = @PrBuyPrice, PrSellPrice = @PrSellPrice, PrStock = @PrStock where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@PrName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PrCategory", CategoryDrop.selectedValue);
                    cmd.Parameters.AddWithValue("@PrBuyPrice", BuyPriceTextb.Text);
                    cmd.Parameters.AddWithValue("@PrSellPrice", SellPriceTextb.Text);
                    cmd.Parameters.AddWithValue("@PrStock", QtityTextb.Text);
                    cmd.Parameters.AddWithValue("@Id", Key);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayProduct();
                    ClearTb();
                    MessageBox.Show("Değişiklikler başarıyla kaydedildi!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id", Key);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayProduct();
                    ClearTb();
                    MessageBox.Show("Kayıt başarıyla silindi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from ProductTbl", conn);
            sda.Fill(dt);
            ProductsDataGrid.DataSource = dt;
            if (CategoryDrop.selectedIndex == -1 )
            {
                filter("PrName", NameTextb.Text);
            }
            if (CategoryDrop.selectedIndex != -1 && NameTextb.Text == "" )
            {
                filter("PrCategory", CategoryDrop.selectedValue);
            }


            
            
        }
    }
}
