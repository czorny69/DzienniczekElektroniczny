using System;
using System.Text;
using System.Windows.Forms;

namespace ProjektDziennik
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void passChangeBT_Click(object sender, EventArgs e)
        {
            if(pass1.Text != null && pass2.Text != null && pass1.Text == pass2.Text)
            {
                try
                {
                    Form1.client.Set(@"users/" + Form1.fireBaseUser + "/password", Convert.ToBase64String(Encoding.ASCII.GetBytes(pass2.Text)));
                    MessageBox.Show("Hasło zmienione!", "Powodzenie");
                    Application.Restart();
                    Environment.Exit(0);
                }
                catch
                {
                    MessageBox.Show("Wystąpił problem!", "Błąd");
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane!", "Błąd");
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
