using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopOtomation
{
    public partial class ProductInfo : Form
    {
        private int Id = 0;
        bool isExist = true;

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));

        public ProductInfo(int Id)
        {
            InitializeComponent();
            this.Id = Id;
            IdLabel.Text = Id.ToString();

            bool isExist = false;

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From ProductTbl", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(reader["Id"].ToString() == Id.ToString())
                {
                    NameLabel.Text = reader["PrName"].ToString();
                    CategoryLabel.Text = reader["PrCategory"].ToString();
                    BuyPriceLabel.Text = reader["PrBuyPrice"].ToString();
                    SellPriceLabel.Text = reader["PrSellPrice"].ToString();
                    StockLabel.Text = reader["PrStock"].ToString();

                    isExist = true;
                }
            }

            if (!isExist)
            {
                MessageBox.Show("Bu ID'ye sahip bir ürün bulunamadı!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.isExist = false;
            }
            conn.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            if (!isExist)
            {
                this.Close();
            }
        }
    }
}
