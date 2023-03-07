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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));

        bool MailAtChecker = false;
        bool MailDotChecker = false;

        bool UserNameChecker = true;
        bool PasswordChecker = true;

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm _login = new LoginForm();
            _login.ShowDialog();
            this.Close();
        }

        private void VisiblePic1_Click(object sender, EventArgs e)
        {
            PasswordTextb.UseSystemPasswordChar = false;
            VisiblePic1.Visible = false;
            NonVisiblePic1.Visible = true;
        }

        private void NonVisiblePic1_Click(object sender, EventArgs e)
        {
            PasswordTextb.UseSystemPasswordChar = true;
            NonVisiblePic1.Visible = false;
            VisiblePic1.Visible = true;
        }

        private void VisiblePic2_Click(object sender, EventArgs e)
        {
            RePasswordTextb.UseSystemPasswordChar = false;
            VisiblePic2.Visible = false;
            NonVisiblePic2.Visible = true;
        }

        private void NonVisiblePic2_Click(object sender, EventArgs e)
        {
            RePasswordTextb.UseSystemPasswordChar = true;
            NonVisiblePic2.Visible = false;
            VisiblePic2.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResisterButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextb.Text == "" || PasswordTextb.Text == "" || RePasswordTextb.Text == "" || MailTextb.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (PasswordTextb.Text == RePasswordTextb.Text)
                    {
                        if (AllowCheck.Checked)
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("insert into UsersTbl (UserName, Password, Mail) values(@UserName, @Password, @Mail)", conn);

                            foreach (char i in UserNameTextb.Text)
                            {
                                if (i == ' ')
                                    UserNameChecker = false;
                            }

                            if (UserNameTextb.Text.Length >= 4 && UserNameChecker)
                            {
                                cmd.Parameters.AddWithValue("@UserName", UserNameTextb.Text);
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı en az 4 karakterden oluşmalıdır ve boşluk içermemelidir!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                            }

                            foreach (char i in PasswordTextb.Text)
                            {
                                if (i == ' ')
                                    PasswordChecker = false;
                            }

                            if (PasswordTextb.Text.Length >= 5 && PasswordChecker)
                            {
                                cmd.Parameters.AddWithValue("@Password", PasswordTextb.Text);
                            }
                            else
                            {
                                MessageBox.Show("Şifre en az 5 karakterden oluşmalıdır ve boşluk içermemelidir!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                            }

                            foreach (char i in MailTextb.Text)
                            {
                                if(i == '@')
                                    MailAtChecker = true;
                                if (i == '.')
                                    MailDotChecker = true;
                            }

                            if(MailDotChecker && MailAtChecker)
                            {
                                cmd.Parameters.AddWithValue("@Mail", MailTextb.Text);
                            }
                            else
                            {
                                MessageBox.Show("Geçerli bir mail adresi giriniz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                            }

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            MessageBox.Show("Artık giriş yapabilirsin!", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            LoginForm _login = new LoginForm();
                            _login.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanım koşullarını kabul etmelisiniz!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girilen şifreler uyuşmuyor!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}