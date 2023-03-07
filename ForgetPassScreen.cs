using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShopOtomation
{
    public partial class ForgetPassScreen : Form
    {
        public ForgetPassScreen()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(System.IO.File.ReadAllText(@"C:\Road.txt"));
        public bool sendMail(string subject, string body, string who)
        {

            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("mutkumese@gmail.com");

            ePosta.To.Add(who);

            ePosta.Subject = subject;

            ePosta.Body = body;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("mutkumese@gmail.com", "iamettlvllfrffnb");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            string UserName = UserNameTb.Text;
            string UserMail = "";
            string UserPassword = "";
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from UsersTbl", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (UserName == reader["UserName"].ToString())
                {
                    isExist = true;
                    UserMail = reader["Mail"].ToString();
                    UserPassword = reader["Password"].ToString();
                    break;
                }
                isExist = false;
            }
            

            if (isExist)
            {
                String mailBody = "MERHABA " + UserName + "\nLütfen hemen aramıza dön!\nŞifren: " + UserPassword;

                sendMail("ŞİFRENİ KURTARDIK!", mailBody, UserMail);
                MessageBox.Show("Mail adresini kontrol et!", "Gönderim başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
