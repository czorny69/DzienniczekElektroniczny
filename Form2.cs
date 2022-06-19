using System;
using System.Text;
using System.Windows.Forms;
using FireSharp.Response;
using Newtonsoft.Json;

namespace ProjektDziennik
{
    public partial class Form2 : Form
    {
        public static string selectedUser;
        private static string selData;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try {
                FirebaseResponse result = Form1.client.Get(@"users/" + Form1.fireBaseUser);
                dynamic data = JsonConvert.DeserializeObject<dynamic>(result.Body);

                FirebaseResponse result2 = Form1.client.Get(@"users");
                dynamic data2 = JsonConvert.DeserializeObject<dynamic>(result2.Body);

                typeInfo.Text = "Typ konta: " + data.type.ToString();
                userInfo.Text = "Użytkownik: " + data.name.ToString() + " " + data.surname.ToString();
                passInfo.Text = "W celu resetu hasła należy \n skontaktować się z administratorem.";


                var count = 0;
                var teacherCheck = data.type == "teacher";

                if (teacherCheck)
                {
                    resetBT.Visible = false;
                    removeBT.Visible = false;
                    addBT.Visible = false;
                }

                foreach (var user in data2)
                {
                    if (user?.deleted == false && user?.type != "admin" && (teacherCheck ? user?.type == "student" : user?.type != "admin"))
                    {

                        ListViewItem item = new ListViewItem(count.ToString());
                        item.SubItems.Add(user.type.ToString());
                        item.SubItems.Add(user.name.ToString());
                        item.SubItems.Add(user.surname.ToString());
                        item.SubItems.Add(user.pesel.ToString());
                        listView1.Items.Add(item);
                    }
                    count++;

                }
            }
            catch { 
                MessageBox.Show("Wystąpił problem!", "Błąd");
                Application.Restart();
                Environment.Exit(0);
            }
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logoutBT_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.listView1.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                    selectedUser = item.SubItems[0].Text;
                    selData = item.SubItems[4].Text + "|" + listView1.Items.IndexOf(item).ToString();
            }
        }

        private void dataBT_Click(object sender, EventArgs e)
        {
            if (selData != null)
            {
                this.Hide();
                var tab = new Form3();
                tab.ShowDialog();
                this.Close();
            }
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            if(selData != null)
            {

                try
                {
                    var temp = selData.Split("|");
                    Form1.client.Set(@"users/" + selectedUser + "/password", Convert.ToBase64String(Encoding.ASCII.GetBytes(temp[0])));
                    MessageBox.Show("Hasło zresetowane!");
                }
                catch
                {
                    MessageBox.Show("Wystąpił problem!", "Błąd");
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
        }

        private void removeBT_Click(object sender, EventArgs e)
        {
            if (selData != null)
            {
                try
                {
                    var temp = selData.Split("|");
                    Form1.client.Set(@"users/" + selectedUser + "/deleted", true);
                    listView1.Items.RemoveAt(Int32.Parse(temp[1]));
                    selData = null;
                    MessageBox.Show("Powodzenie!");

                }
                catch
                {
                    MessageBox.Show("Wystąpił problem!", "Błąd");
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tab = new Form5();
            tab.ShowDialog();
            this.Close();
        }
    }
}
