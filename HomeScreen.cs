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
    public partial class HomeScreen : Form
    {
        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        public HomeScreen()
        {
            InitializeComponent();
            SearchProTextb.Focus();
            UserNameLabel.Text = LoginForm._UserName;

            //get statistics info
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From StatisticsTbl", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TotalSelling.Text = reader["TotalSelling"].ToString();
                TotalProfit.Text = reader["TotalProfit"].ToString();
            }

            conn.Close();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
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

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductsForm _products = new ProductsForm();
            _products.Show();
            this.Hide();

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            CustomersForm _customers = new CustomersForm();
            _customers.Show();
            this.Hide();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            SellingForm _invoiceForm = new SellingForm();
            _invoiceForm.Show();
            this.Hide();
        }

        private void PetsButton_Click(object sender, EventArgs e)
        {
            PetsForm _pets = new PetsForm();
            _pets.Show();
            this.Hide();
        }

        private void SearchProButton_Click(object sender, EventArgs e)
        {
            if(!Int32.TryParse(SearchProTextb.text,out int sayi) )
            {
                MessageBox.Show("Lütfen geçerli bir giriş yapınız!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Id = Convert.ToInt32(SearchProTextb.text);
                ProductInfo _productinfo = new ProductInfo(Id);
                _productinfo.Show();
            }
        }
    }
}
