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
using System.Xml;

namespace PetShopOtomation
{
    public partial class SellingForm : Form
    {
        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        public SellingForm()
        {
            InitializeComponent();
            displayProducts();
            displayBasket();
            TotalPriceLabel.Text = "0 ₺";

            //add Customers Ids
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From CustomersTbl", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomersDrop.AddItem(reader["Id"].ToString());
            }
            conn.Close();

            //get statistics info
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From StatisticsTbl", conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                TotalSelling = Convert.ToInt32(reader1["TotalSelling"].ToString());
                TotalProfit = Convert.ToInt32(reader1["TotalProfit"].ToString());
            }
                
            conn.Close();
        }

        int Key = 0;
        int stock = 10;

        int totalPrice = 0;
        int totalCost = 0;

        string tempPrName;
        string tempPrQtity;

        int TotalSelling = 0;
        int TotalProfit = 0;

        private void displayProducts()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ProductTbl", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void displayBasket()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from BasketTbl", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BasketDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void reset()
        {
            tempPrName = ProductNameTextb.Text;
            ProductNameTextb.Text = "";
            ProductPriceTextb.Text = "";
            tempPrQtity = ProductQtityTextb.Text;
            ProductQtityTextb.Text = "";
            stock = 0;
            Key = 0;
        }

        private void updateStock()
        {
            try
            {
                int newQtity = stock - Convert.ToInt32(ProductQtityTextb.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PrStock = @PrStock where Id = @Id",conn);
                cmd.Parameters.AddWithValue("@PrStock",newQtity);
                cmd.Parameters.AddWithValue("@Id", Key);
                cmd.ExecuteNonQuery();
                conn.Close();
                displayProducts();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetBasket()
        {
            totalPrice = 0;
            totalCost = 0;
            TotalPriceLabel.Text = totalPrice + " ₺";

            conn.Open();
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE BasketTbl", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
            displayBasket();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm _login = new LoginForm();
            _login.Show();
            this.Hide();
        }

        private void HomeSButton_Click(object sender, EventArgs e)
        {
            HomeScreen _homeScreen = new HomeScreen();
            _homeScreen.Show();
            this.Hide();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductsForm _products = new ProductsForm();
            _products.Show();
            this.Hide();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm _customersForm = new CustomersForm();
            _customersForm.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PetsForm _pets = new PetsForm();
            _pets.Show();
            this.Hide();
        }

        private void ProductsDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddBasketButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(ProductQtityTextb.Text) > stock)
            {
                MessageBox.Show("Yeterli stok yok!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(ProductQtityTextb.Text == "")
            {
                MessageBox.Show("Adet giriniz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into BasketTbl (Name, Price, Qtity) values(@Name, @Price, @Qtity)", conn);
                    cmd.Parameters.AddWithValue("@Name", ProductNameTextb.Text);
                    cmd.Parameters.AddWithValue("@Price", ProductPriceTextb.Text);
                    cmd.Parameters.AddWithValue("@Qtity", ProductQtityTextb.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayBasket();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
                



                int total = Convert.ToInt32(ProductQtityTextb.Text) * Convert.ToInt32(ProductPriceTextb.Text);
                //DataGridViewRow row = new DataGridViewRow();
                //row.CreateCells(BasketDataGrid);
                //row.Cells[0].Value = n + 1;
                //row.Cells[1].Value = ProductNameTextb.Text;
                //row.Cells[2].Value = ProductQtityTextb.Text;
                //row.Cells[3].Value = ProductPriceTextb.Text;
                //row.Cells[4].Value = total;
                totalPrice += total;
                totalCost += Convert.ToInt32(ProductQtityTextb.Text) * Convert.ToInt32(ProductsDataGrid.SelectedRows[0].Cells[3].Value.ToString());

                //BasketDataGrid.Rows.Add(row);
                //n++;
                TotalPriceLabel.Text = totalPrice + " ₺";
                updateStock();
                reset();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetBasket();
        }

        private void ProductsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductNameTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            ProductPriceTextb.Text = ProductsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            stock = Convert.ToInt32(ProductsDataGrid.SelectedRows[0].Cells[5].Value.ToString());

            if (ProductNameTextb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            //print Invoice
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            if (CustomerNameTextb.Text == "")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into InvoiceTbl (SellDate, Qtity, Price, Profit) values(@SellDate, @Qtity, @Price, @Profit)", conn);
                    cmd.Parameters.AddWithValue("@SellDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Qtity", Convert.ToInt32(tempPrQtity));
                    cmd.Parameters.AddWithValue("@Price", totalPrice);
                    cmd.Parameters.AddWithValue("@Profit", totalPrice - totalCost);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    // Record statistics
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Update StatisticsTbl set TotalSelling = @TotalSelling, TotalProfit = @TotalProfit where Id = @Id", conn);
                    cmd1.Parameters.AddWithValue("@TotalSelling", TotalSelling + totalPrice);
                    cmd1.Parameters.AddWithValue("@TotalProfit", TotalProfit + (totalPrice - totalCost));
                    cmd1.Parameters.AddWithValue("@Id", 1);
                    cmd1.ExecuteNonQuery();
                    conn.Close();

                    resetBasket();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into InvoiceTbl (SellDate, CustId, CustName, Qtity, Price, Profit) values(@SellDate, @CustId, @CustName, @Qtity, @Price, @Profit)", conn);
                    cmd.Parameters.AddWithValue("@SellDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@CustId", Convert.ToInt32(CustomersDrop.selectedValue));
                    cmd.Parameters.AddWithValue("@CustName", CustomerNameTextb.Text);
                    cmd.Parameters.AddWithValue("@Qtity", Convert.ToInt32(tempPrQtity));
                    cmd.Parameters.AddWithValue("@Price", totalPrice);
                    cmd.Parameters.AddWithValue("@Profit", totalPrice - totalCost);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    // Record statistics
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("Update StatisticsTbl set TotalSelling = @TotalSelling, TotalProfit = @TotalProfit where Id = @Id", conn);
                    cmd1.Parameters.AddWithValue("@TotalSelling", TotalSelling + totalPrice);
                    cmd1.Parameters.AddWithValue("@TotalProfit", TotalProfit + (totalPrice - totalCost));
                    cmd1.Parameters.AddWithValue("@Id", 1);
                    cmd1.ExecuteNonQuery();
                    conn.Close();

                    resetBasket();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            
        }

        private void CustomersDrop_onItemSelected(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From CustomersTbl", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(CustomersDrop.selectedValue == reader["Id"].ToString())
                {
                    CustomerNameTextb.Text = reader["CustomerName"].ToString();
                }
            }
            conn.Close();
        }
        int PrId, PrQty, PrPrice, Tottal, pos = 60;
        string PrName = "";
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EMPATİ PETSHOP", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Orange, new Point(80));
            e.Graphics.DrawString("Id     Ürün     Fiyat     Adet     Toplam", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Orange, new Point(26, 40));
            foreach(DataGridViewRow row in BasketDataGrid.Rows)
            {
                PrId++;
                PrName = "" + row.Cells[0].Value;
                PrPrice = Convert.ToInt32(row.Cells[2].Value);
                PrQty = Convert.ToInt32(row.Cells[1].Value);
                Tottal = Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);
                e.Graphics.DrawString("" + PrId, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, pos));
                e.Graphics.DrawString("" + PrName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(45, pos));
                e.Graphics.DrawString("" + PrPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(120, pos));
                e.Graphics.DrawString("" + PrQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(170, pos));
                e.Graphics.DrawString("" + Tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(235, pos));
                pos += 20;

            }
            e.Graphics.DrawString("        Toplam: " + totalPrice + "₺", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("*************** EMPATİ PETSHOP ***************", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            //BasketDataGrid.Rows.Clear();
            BasketDataGrid.Refresh();
            pos = 100;
            

        }
    }
}
