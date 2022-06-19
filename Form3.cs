using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using FireSharp.Response;

namespace ProjektDziennik
{
    public partial class Form3 : Form
    {
        public string selectedGrade;
        public string userData;
        private string userCheck;
        private int gradesCount = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try {
                FirebaseResponse resultUser = Form1.client.Get(@"users/" + Form1.fireBaseUser);
                if (resultUser != null)
                {
                    dynamic dataUser = JsonConvert.DeserializeObject<dynamic>(resultUser.Body);
                    typeInfo.Text = "Typ konta: " + dataUser.type.ToString();
                    userInfo.Text = "Użytkownik: " + dataUser.name.ToString() + " " + dataUser.surname.ToString();
                    passInfo.Text = "W celu resetu hasła należy \n skontaktować się z administratorem.";

                    valueTXT.Maximum = 6;

                    userCheck = Form2.selectedUser;

                    if (dataUser.type == "student")
                    {
                        saveBT.Visible = false;
                        delBT.Visible = false;
                        changeBT.Visible = false;

                        nameTxt.ReadOnly = true;
                        surnameTxt.ReadOnly = true;
                        phoneTxt.ReadOnly = true;
                        peselTxt.ReadOnly = true;
                        valueTXT.ReadOnly = true;
                        valueTXT.Increment = 0;
                        subjectTXT.ReadOnly = true;
                        authorTXT.ReadOnly = true;
                        richTextBox1.ReadOnly = true;

                        nameTxt.BackColor = System.Drawing.SystemColors.Window;
                        surnameTxt.BackColor = System.Drawing.SystemColors.Window;
                        phoneTxt.BackColor = System.Drawing.SystemColors.Window;
                        peselTxt.BackColor = System.Drawing.SystemColors.Window;
                        valueTXT.BackColor = System.Drawing.SystemColors.Window;
                        subjectTXT.BackColor = System.Drawing.SystemColors.Window;
                        authorTXT.BackColor = System.Drawing.SystemColors.Window;
                        richTextBox1.BackColor = System.Drawing.SystemColors.Window;

                        userCheck = Form1.fireBaseUser;
                    }
                    if (dataUser.type == "teacher")
                    {
                        saveBT.Visible = false;
                        delBT.Visible = false;
                        changeBT.Text = "Dodaj";

                        nameTxt.ReadOnly = true;
                        surnameTxt.ReadOnly = true;
                        phoneTxt.ReadOnly = true;
                        peselTxt.ReadOnly = true;

                        nameTxt.BackColor = System.Drawing.SystemColors.Window;
                        surnameTxt.BackColor = System.Drawing.SystemColors.Window;
                        phoneTxt.BackColor = System.Drawing.SystemColors.Window;
                        peselTxt.BackColor = System.Drawing.SystemColors.Window;
                    }

                    FirebaseResponse result = Form1.client.Get(@"users/" + userCheck);
                    if (result != null)
                    {
                        dynamic data = JsonConvert.DeserializeObject<dynamic>(result.Body);
                        userData = data.name + "|" + data.surname + "|" + data.phone + "|" + data.pesel;
                        this.Size = new Size(439, 378);
                        tabControl1.Size = new Size(399, 218);
                        nameTxt.Text = data.name;
                        surnameTxt.Text = data.surname;
                        phoneTxt.Text = data.phone;
                        peselTxt.Text = data.pesel;
                    }
                }
            }
            catch { 
                MessageBox.Show("Wystąpił problem!", "Błąd");
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            var name = nameTxt.Text;
            var surname = surnameTxt.Text;
            var phone = phoneTxt.Text;
            var pesel = peselTxt.Text;
            var temp = userData.Split("|");
            if (name != temp[0] || surname != temp[1] || phone != temp[2] || pesel != temp[3])
            {
                if(name != null && surname != null && phone != null && pesel != null )
                {
                    try {
                        var entryNumber = Int32.Parse(userCheck);
                        Form1.client.Set(@"users/" + entryNumber + "/name", name);
                        Form1.client.Set(@"users/" + entryNumber + "/surname", surname);
                        Form1.client.Set(@"users/" + entryNumber + "/phone", phone);
                        Form1.client.Set(@"users/" + entryNumber + "/pesel", pesel);
                        MessageBox.Show("Zaktualizowano!");
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
                    MessageBox.Show("Niepoprawne dane!");
                }

            }
            else
            {
                MessageBox.Show("Nie wprowadzono żadnych zmian.");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                FirebaseResponse result = Form1.client.Get(@"users/" + userCheck);
                if (result != null)
                {
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(result.Body);
                    userData = data.name + "|" + data.surname + "|" + data.phone + "|" + data.pesel;
                    nameTxt.Text = data.name;
                    surnameTxt.Text = data.surname;
                    phoneTxt.Text = data.phone;
                    peselTxt.Text = data.pesel;

                    var tab = tabControl1.SelectedIndex;

                    if (tab == 0)
                    {
                        this.Size = new Size(439, 378);
                        tabControl1.Size = new Size(399, 218);
                    }

                    if (tab == 1)
                    {

                        valueTXT.Text = "";
                        subjectTXT.Text = "";
                        authorTXT.Text = "";
                        richTextBox1.Text = "";

                        this.Size = new Size(439, 600);
                        tabControl1.Size = new Size(399, 440);
                        listView1.Items.Clear();
                        gradesCount = 0;
                        if (data.grades != null)
                        {
                            dynamic grades = JsonConvert.DeserializeObject<dynamic>(data.grades.ToString());
                            foreach (var grade in grades)
                            {
                                if (grade != null && grade.deleted == false)
                                {
                                    ListViewItem item = new ListViewItem(gradesCount.ToString());
                                    item.SubItems.Add(grade.subject.ToString());
                                    item.SubItems.Add(grade.value.ToString());
                                    item.SubItems.Add(grade.author.ToString());
                                    item.SubItems.Add(grade.desc.ToString());

                                    listView1.Items.Add(item);
                                }
                                gradesCount++;
                            }
                        }
                        else
                        {
                            valueLB.Text = "Ocena: ";
                            subjectLB.Text = "Przedmiot: ";
                            authorLB.Text = "Nauczyciel: ";
                            richTextBox1.Text = "";
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił problem!", "Błąd");
                Application.Restart();
                Environment.Exit(0);
            }
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = this.listView1.SelectedItems;
            
            foreach (ListViewItem item in selected)
            {
                selectedGrade = item.SubItems[0].Text + "|" + listView1.Items.IndexOf(item).ToString();
                subjectTXT.Text = item.SubItems[1].Text;
                valueTXT.Text = item.SubItems[2].Text;
                authorTXT.Text = item.SubItems[3].Text;
                richTextBox1.Text = item.SubItems[4].Text;
            }
        }

        private void delBT_Click(object sender, EventArgs e)
        {
            if (selectedGrade != null)
            {
                try {
                    var temp = selectedGrade.Split("|");
                    var entryNumber = Int32.Parse(userCheck);
                    var gradeNumber = Int32.Parse(temp[0]);
                    Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/deleted", true);
                    listView1.Items.RemoveAt(Int32.Parse(temp[1]));
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
        
        private void backBT_Click(object sender, EventArgs e)
        {
            var tab = new Form2();
            this.Hide();
            tab.ShowDialog();
            this.Close();

        }

        private void logoutBT_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void changeBT_Click(object sender, EventArgs e)
        {
            var checkBT = changeBT.Text == "Dodaj";

            if (selectedGrade != null || checkBT)
            {
                int gradeNumber = 9999;
                int index = 9999;

                if (!checkBT) { 
                    var temp = selectedGrade.Split("|");
                    gradeNumber = Int32.Parse(temp[0]);
                    index = Int32.Parse(temp[1]);
                }

                if (checkBT)
                {
                    index = gradesCount;
                    gradeNumber = gradesCount;
                    gradesCount++;
                }

                
                var entryNumber = Int32.Parse(userCheck);
                

                if (valueTXT.Text != null && subjectTXT.Text != null && authorTXT.Text != null && richTextBox1.Text != null)
                {
                    try
                    {
                        Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/author", authorTXT.Text);
                        Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/subject", subjectTXT.Text);
                        Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/value", valueTXT.Text);
                        Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/desc", richTextBox1.Text);
                        if (checkBT)
                        {
                            Form1.client.Set(@"users/" + entryNumber + "/grades/" + gradeNumber + "/deleted", false);

                            ListViewItem item = new ListViewItem(gradeNumber.ToString());
                            item.SubItems.Add(subjectTXT.Text);
                            item.SubItems.Add(valueTXT.Text);
                            item.SubItems.Add(authorTXT.Text);
                            item.SubItems.Add(richTextBox1.Text);

                            listView1.Items.Add(item);

                            MessageBox.Show("Ocena dodana!");
                        }
                        else
                        {
                            listView1.Items[index].SubItems[1].Text = subjectTXT.Text;
                            listView1.Items[index].SubItems[2].Text = valueTXT.Text;
                            listView1.Items[index].SubItems[3].Text = authorTXT.Text;
                            listView1.Items[index].SubItems[4].Text = richTextBox1.Text;
                            MessageBox.Show("Ocena zaktualizowana!");
                        }
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
                    MessageBox.Show("Nieprawidłowe dane!");
                }
            }

        }

    }
}
