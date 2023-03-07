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
    public partial class PetsForm : Form
    {
        public PetsForm()
        {
            InitializeComponent();
            displayPets();
        }

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        int Key = 0;
        private void ClearTb()
        {
            NameTextb.Text = "";
            OwnerTextb.Text = "";
            OtherTextb.Text = "";
            TypeDrop.selectedIndex = 0;
            BirtdayPicker.Value = DateTime.Now;
        }
        private void displayPets()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PetsTbl", conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PetsDataGrid.DataSource = ds.Tables[0];
            conn.Close();
        }

        DataTable dt = new DataTable();

        DataView filter(string href, string value)
        {
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = href + " like '" + value + "%'";
            PetsDataGrid.DataSource = dv;
            return dv;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextb.Text == "" || TypeDrop.selectedValue == "" || OwnerTextb.Text == "" )
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into PetsTbl (PetName, PetType, OwnerName, BirtDay, OtherInfo) values(@PetName, @PetType, @OwnerName, @BirtDay, @OtherInfo)", conn);

                    cmd.Parameters.AddWithValue("@PetName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PetType", TypeDrop.selectedValue);
                    cmd.Parameters.AddWithValue("@OwnerName", OwnerTextb.Text);
                    cmd.Parameters.AddWithValue("@BirtDay", BirtdayPicker.Value);
                    cmd.Parameters.AddWithValue("@OtherInfo", OtherTextb.Text);



                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayPets();
                    ClearTb();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTextb.Text == "" || TypeDrop.selectedValue == "" || OwnerTextb.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update PetsTbl set PetName = @PetName, PetType = @PetType, OwnerName = @OwnerName, BirtDay = @BirtDay, OtherInfo = @OtherInfo where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@PetName", NameTextb.Text);
                    cmd.Parameters.AddWithValue("@PetType", TypeDrop.selectedValue);
                    cmd.Parameters.AddWithValue("@OwnerName", OwnerTextb.Text);
                    cmd.Parameters.AddWithValue("@BirtDay", BirtdayPicker.Value);
                    cmd.Parameters.AddWithValue("@OtherInfo", OtherTextb.Text);
                    cmd.Parameters.AddWithValue("@Id", Key);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayPets();
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

        private void PetsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTextb.Text = PetsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            TypeDrop.Text = PetsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            OwnerTextb.Text = PetsDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            BirtdayPicker.Text = PetsDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            OtherTextb.Text = PetsDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            if (NameTextb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PetsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
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
                    SqlCommand cmd = new SqlCommand("delete from PetsTbl where Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id", Key);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayPets();
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from PetsTbl", conn);
            sda.Fill(dt);
            PetsDataGrid.DataSource = dt;
            if(TypeDrop.selectedIndex == -1 && OwnerTextb.Text == "")
            {
                filter("PetName", NameTextb.Text);
            }
            if (TypeDrop.selectedIndex == -1 && NameTextb.Text == "")
            {
                filter("OwnerName", OwnerTextb.Text);
            }
            if (TypeDrop.selectedIndex != -1 && NameTextb.Text == "" && OwnerTextb.Text == "")
            {
                filter("PetType", TypeDrop.selectedValue);
            }
        }
    }
}
