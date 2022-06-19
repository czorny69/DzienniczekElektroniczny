using System;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using FireSharp.Response;

namespace ProjektDziennik
{
    public partial class Form5 : Form
    {

        private string selectedType;
        private int count;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try {
                FirebaseResponse result = Form1.client.Get(@"users/" + Form1.fireBaseUser);
                dynamic data = JsonConvert.DeserializeObject<dynamic>(result.Body);

                FirebaseResponse result2 = Form1.client.Get(@"users");
                dynamic data2 = JsonConvert.DeserializeObject<dynamic>(result2.Body);

                typeInfo.Text = "Typ konta: " + data.type.ToString();
                userInfo.Text = "Użytkownik: " + data.name.ToString() + " " + data.surname.ToString();
                passInfo.Text = "W celu resetu hasła należy \n skontaktować się z administratorem.";
                count = 0;
                foreach (var user in data2)
                {
                    count++;
                }
            }
            catch { 
                MessageBox.Show("Wystąpił problem!", "Błąd");
                Application.Restart();
                Environment.Exit(0);
            }
            

        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.typeBox.CheckedItems.Count > 0)
            selectedType = this.typeBox.CheckedItems[0]?.ToString();
        }
        
        private void typeBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < typeBox.Items.Count; ++ix)
                if (ix != e.Index) typeBox.SetItemChecked(ix, false);
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            if(nameTxt != null && surnameTxt != null && peselTxt != null && phoneTxt != null && selectedType != null)
            {
                try
                {
                    Form1.client.Set(@"users/" + count + "/name", nameTxt.Text);
                    Form1.client.Set(@"users/" + count + "/surname", surnameTxt.Text);
                    Form1.client.Set(@"users/" + count + "/phone", phoneTxt.Text);
                    Form1.client.Set(@"users/" + count + "/pesel", peselTxt.Text);
                    Form1.client.Set(@"users/" + count + "/password", Convert.ToBase64String(Encoding.ASCII.GetBytes(peselTxt.Text)));
                    Form1.client.Set(@"users/" + count + "/type", selectedType);
                    Form1.client.Set(@"users/" + count + "/deleted", false);
                }
                catch
                {
                    MessageBox.Show("Wystąpił problem!", "Błąd");
                    Application.Restart();
                    Environment.Exit(0);
                }

                    count++;
                    MessageBox.Show("Dodano nowego użytkownika!", "Powodzenie");
                

                nameTxt.Text = "";
                surnameTxt.Text = "";
                phoneTxt.Text = "";
                peselTxt.Text = "";

                for (int ix = 0; ix < typeBox.Items.Count; ++ix)
                    typeBox.SetItemChecked(ix, false);
            }
            else
            {
                MessageBox.Show("Niepoprawne dane!", "Błąd");
            }
        }

        private void logoutBT_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tab = new Form2();
            tab.ShowDialog();
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
