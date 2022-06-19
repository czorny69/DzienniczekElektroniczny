
namespace ProjektDziennik
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBT = new System.Windows.Forms.Button();
            this.passInfo = new System.Windows.Forms.Label();
            this.logoutBT = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.typeInfo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.peselTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.valueTXT = new System.Windows.Forms.NumericUpDown();
            this.changeBT = new System.Windows.Forms.Button();
            this.subjectTXT = new System.Windows.Forms.TextBox();
            this.authorTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delBT = new System.Windows.Forms.Button();
            this.authorLB = new System.Windows.Forms.Label();
            this.subjectLB = new System.Windows.Forms.Label();
            this.valueLB = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.author = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTXT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.backBT);
            this.panel1.Controls.Add(this.passInfo);
            this.panel1.Controls.Add(this.logoutBT);
            this.panel1.Controls.Add(this.userInfo);
            this.panel1.Controls.Add(this.typeInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 91);
            this.panel1.TabIndex = 2;
            // 
            // backBT
            // 
            this.backBT.Location = new System.Drawing.Point(228, 50);
            this.backBT.Name = "backBT";
            this.backBT.Size = new System.Drawing.Size(75, 23);
            this.backBT.TabIndex = 4;
            this.backBT.Text = "Cofnij";
            this.backBT.UseVisualStyleBackColor = true;
            this.backBT.Click += new System.EventHandler(this.backBT_Click);
            // 
            // passInfo
            // 
            this.passInfo.AutoSize = true;
            this.passInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passInfo.Location = new System.Drawing.Point(190, 9);
            this.passInfo.Name = "passInfo";
            this.passInfo.Size = new System.Drawing.Size(38, 15);
            this.passInfo.TabIndex = 3;
            this.passInfo.Text = "label3";
            // 
            // logoutBT
            // 
            this.logoutBT.Location = new System.Drawing.Point(309, 51);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(75, 23);
            this.logoutBT.TabIndex = 2;
            this.logoutBT.Text = "Wyloguj";
            this.logoutBT.UseVisualStyleBackColor = true;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(13, 50);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(38, 15);
            this.userInfo.TabIndex = 1;
            this.userInfo.Text = "label2";
            // 
            // typeInfo
            // 
            this.typeInfo.AutoSize = true;
            this.typeInfo.Location = new System.Drawing.Point(13, 20);
            this.typeInfo.Name = "typeInfo";
            this.typeInfo.Size = new System.Drawing.Size(38, 15);
            this.typeInfo.TabIndex = 0;
            this.typeInfo.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 440);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveBT);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.phoneTxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.peselTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.surnameTxt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nameTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(159, 149);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(75, 23);
            this.saveBT.TabIndex = 8;
            this.saveBT.Text = "Zapisz";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(218, 98);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(167, 23);
            this.phoneTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pesel:";
            // 
            // peselTxt
            // 
            this.peselTxt.Location = new System.Drawing.Point(10, 98);
            this.peselTxt.Name = "peselTxt";
            this.peselTxt.Size = new System.Drawing.Size(167, 23);
            this.peselTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko:";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(218, 51);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(167, 23);
            this.surnameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(10, 51);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(167, 23);
            this.nameTxt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.valueTXT);
            this.tabPage2.Controls.Add(this.changeBT);
            this.tabPage2.Controls.Add(this.subjectTXT);
            this.tabPage2.Controls.Add(this.authorTXT);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.delBT);
            this.tabPage2.Controls.Add(this.authorLB);
            this.tabPage2.Controls.Add(this.subjectLB);
            this.tabPage2.Controls.Add(this.valueLB);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Oceny";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // valueTXT
            // 
            this.valueTXT.Location = new System.Drawing.Point(306, 58);
            this.valueTXT.Name = "valueTXT";
            this.valueTXT.Size = new System.Drawing.Size(67, 23);
            this.valueTXT.TabIndex = 11;
            // 
            // changeBT
            // 
            this.changeBT.Location = new System.Drawing.Point(265, 6);
            this.changeBT.Name = "changeBT";
            this.changeBT.Size = new System.Drawing.Size(55, 23);
            this.changeBT.TabIndex = 10;
            this.changeBT.Text = "Zapisz";
            this.changeBT.UseVisualStyleBackColor = true;
            this.changeBT.Click += new System.EventHandler(this.changeBT_Click);
            // 
            // subjectTXT
            // 
            this.subjectTXT.Location = new System.Drawing.Point(83, 32);
            this.subjectTXT.Name = "subjectTXT";
            this.subjectTXT.Size = new System.Drawing.Size(142, 23);
            this.subjectTXT.TabIndex = 8;
            // 
            // authorTXT
            // 
            this.authorTXT.Location = new System.Drawing.Point(83, 61);
            this.authorTXT.Name = "authorTXT";
            this.authorTXT.Size = new System.Drawing.Size(142, 23);
            this.authorTXT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wybrany wpis: ";
            // 
            // delBT
            // 
            this.delBT.Location = new System.Drawing.Point(326, 6);
            this.delBT.Name = "delBT";
            this.delBT.Size = new System.Drawing.Size(55, 23);
            this.delBT.TabIndex = 5;
            this.delBT.Text = "Usuń";
            this.delBT.UseVisualStyleBackColor = true;
            this.delBT.Click += new System.EventHandler(this.delBT_Click);
            // 
            // authorLB
            // 
            this.authorLB.AutoSize = true;
            this.authorLB.Location = new System.Drawing.Point(7, 64);
            this.authorLB.Name = "authorLB";
            this.authorLB.Size = new System.Drawing.Size(70, 15);
            this.authorLB.TabIndex = 4;
            this.authorLB.Text = "Nauczyciel: ";
            // 
            // subjectLB
            // 
            this.subjectLB.AutoSize = true;
            this.subjectLB.Location = new System.Drawing.Point(10, 36);
            this.subjectLB.Name = "subjectLB";
            this.subjectLB.Size = new System.Drawing.Size(67, 15);
            this.subjectLB.TabIndex = 3;
            this.subjectLB.Text = "Przedmiot: ";
            // 
            // valueLB
            // 
            this.valueLB.AutoSize = true;
            this.valueLB.Location = new System.Drawing.Point(253, 61);
            this.valueLB.Name = "valueLB";
            this.valueLB.Size = new System.Drawing.Size(47, 15);
            this.valueLB.TabIndex = 2;
            this.valueLB.Text = "Ocena: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 75);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Opis...";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.subject,
            this.value,
            this.author});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 168);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 238);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
            // 
            // subject
            // 
            this.subject.Text = "Przedmiot";
            this.subject.Width = 125;
            // 
            // value
            // 
            this.value.Text = "Ocena";
            // 
            // author
            // 
            this.author.Text = "Nauczyciel";
            this.author.Width = 140;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekt Dziennik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueTXT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passInfo;
        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Label typeInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peselTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button delBT;
        private System.Windows.Forms.Label authorLB;
        private System.Windows.Forms.Label subjectLB;
        private System.Windows.Forms.Label valueLB;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectTXT;
        private System.Windows.Forms.TextBox authorTXT;
        private System.Windows.Forms.Button changeBT;
        private System.Windows.Forms.NumericUpDown valueTXT;
    }
}