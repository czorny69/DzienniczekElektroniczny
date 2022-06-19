using System;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace ProjektDziennik
{
    public partial class Form1 : Form
    {
        public static string fireBaseUser;

        public Form1()
        {
            InitializeComponent();
        }

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4lui04jHawfv10irvi1lrn09c81rq9dNQ8eKKx5Q",
            BasePath = "https://dzienniczek-92d18-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public static IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                connectionLB.Text = "Brak połączenia z FireBase";
            }

            if(client != null)
            {
                connectionLB.Text = "Połączono z FireBase";
            }
            else { connectionLB.Text = "Brak połączenia z FireBase"; }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTxtBox.Text;
            var password = passTxtBox.Text;
            var error = true;
            if (login == "" || password == "" && connectionLB.Text == "Brak połączenia z FireBase")
            {
                if(connectionLB.Text == "Brak połączenia z FireBase")
                {
                    MessageBox.Show("Brak połączenia z FireBase!");
                } else
                {
                    MessageBox.Show("Niepoprawne dane logowania.");
                }
                
            }
            else
            {

                try
                {
                    FirebaseResponse result = client.Get(@"users");
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(result.Body);

                    var count = 0;
                    foreach (var user in data)
                    {
                        var tempPass = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(user.password.ToString()));
                        if (password == tempPass && login == user.pesel.ToString() && user.deleted == false)
                        {

                            fireBaseUser = count.ToString();
                            if (tempPass == user.pesel.ToString() && user.type.ToString() != "admin")
                            {
                                error = false;
                                MessageBox.Show("Wykryto domyślne hasło! \nPrzekierowanie do zmiany hasła.", "Uwaga");
                                var tab = new Form4();
                                tab.Show();
                                this.Hide();
                                break;
                            }
                            if (user.type.ToString() == "student")
                            {
                                error = false;
                                var tab = new Form3();
                                tab.Show();
                                this.Hide();
                                break;
                            }
                            if (user.type.ToString() == "teacher")
                            {
                                error = false;
                                var tab = new Form2();
                                tab.Show();
                                this.Hide();
                                break;
                            }
                            if (user.type.ToString() == "admin")
                            {
                                error = false;
                                var tab = new Form2();
                                tab.Show();
                                this.Hide();
                                break;
                            }
                        }
                        count++;
                    }
                }
                catch { 
                    MessageBox.Show("Wystąpił problem!", "Błąd");
                    Application.Restart();
                    Environment.Exit(0);
                }

                if(error) { MessageBox.Show("Niepoprawne dane logowania."); }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            loginTxtBox.Text = "";
            passTxtBox.Text = "";
        }

    }
}
