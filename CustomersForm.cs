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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShopOtomation
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            displayCustomers();
        }

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        int Key = 0;

        private void ClearTb()
        {
            NameTextb.Text = "";
            PetsNameTextb.Text = "";
            NumberTextb.Text = "";
            AddressTextb.Text = "";
        }
        private void displayCustomers()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from CustomersTbl", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        DataTable dt = new DataTable();

        DataView filter(string href, string value)
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = href + " like '" + value + "%'";
            CustomerDataGrid.DataSource = dv;
            return dv;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (NameTextb.Text == "" || PetsNameTextb.Text == "" || NumberTextb.Text == "" || AddressTextb.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomersTbl (CustomerName, PhoneNumber, PetName, Address) values(@CustomerName, @PhoneNumber, @PetName, @Address)", conn);

                    cmd.Parameters.AddWithValue("@CustomerName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", NumberTextb.Text);
                    cmd.Parameters.AddWithValue("@PetName", PetsNameTextb.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTextb.Text);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayCustomers();
                    ClearTb();
                    //MessageBox.Show("Müşteri başarıyla kaydedildi!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Lütfen bir müşteri seçiniz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomersTbl where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id", Key);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayCustomers();
                    ClearTb();
                    MessageBox.Show("Müşteri başarıyla silindi!", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void CustomerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTextb.Text = CustomerDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            NumberTextb.Text = CustomerDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PetsNameTextb.Text = CustomerDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            AddressTextb.Text = CustomerDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (NameTextb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTextb.Text == "" || PetsNameTextb.Text == "" || NumberTextb.Text == "" || AddressTextb.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomersTbl set CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, PetName = @PetName, Address = @Address where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@CustomerName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", NumberTextb.Text);
                    cmd.Parameters.AddWithValue("@PetName", PetsNameTextb.Text);
                    cmd.Parameters.AddWithValue("@Address", AddressTextb.Text);
                    cmd.Parameters.AddWithValue("@Id", Key);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayCustomers();
                    ClearTb();
                    MessageBox.Show("Değişiklikler başarıyla kaydedildi!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomersTbl", conn);
            sda.Fill(dt);
            CustomerDataGrid.DataSource = dt;

            filter("CustomerName", NameTextb.Text);
        }
    }
}
