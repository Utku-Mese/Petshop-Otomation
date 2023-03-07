using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShopOtomation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserNameTextb.Text = Program.rememberUserName;
            PasswordTextb.Text = Program.rememberPassword;
        }

        public static string _UserName = "";

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextb.Text;
            string password = PasswordTextb.Text;
            bool isRegistered = false;

            if(userName == "" || password == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanı boş bırakılamaz", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UsersTbl",conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (userName == reader["UserName"].ToString() && password == reader["Password"].ToString())
                        {
                            isRegistered = true;
                            break;
                        }
                        else isRegistered = false;
                    }
                    conn.Close();

                    if (isRegistered == true)
                    {
                        if (RememberCheck.Checked)
                        {
                            //ToDo -> Complate Remember me
                            Program.rememberUserName = userName;
                            Program.rememberPassword = password;
                        }
                        _UserName = userName;
                        
                        MessageBox.Show("Hoşgeldin " + userName + "!", "Giriş Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        HomeScreen _homeScreen = new HomeScreen();
                        _homeScreen.Show();
                    }
                    else MessageBox.Show("Kullanıcı adı ve şifre kombinasyonu yanlış!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm _register = new RegisterForm();
            _register.ShowDialog();
        }

        private void VisiblePic_Click(object sender, EventArgs e)
        {
            PasswordTextb.UseSystemPasswordChar = false;
            VisiblePic.Visible = false;
            NonVisiblePic.Visible = true;
        }

        private void NonVisiblePic_Click(object sender, EventArgs e)
        {
            PasswordTextb.UseSystemPasswordChar = true;
            NonVisiblePic.Visible = false;
            VisiblePic.Visible = true;
        }

        private void ForgetPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassScreen forgetPassScreen = new ForgetPassScreen();
            forgetPassScreen.ShowDialog();
        }
    }
}
