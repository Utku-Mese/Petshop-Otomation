using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopOtomation
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        int startPosition = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (startPosition < 25)
                {
                    startPosition += 2;
                }
                else if (startPosition < 90)
                {
                    startPosition += 5;
                }
                else
                {
                    startPosition += 1;
                }
                MyProgressBar.Value = startPosition;
                LoadingLabel.Text = "% " + startPosition;
                if (MyProgressBar.Value == 99)
                {
                    MyProgressBar.Value = 0;
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                    timer1.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}
