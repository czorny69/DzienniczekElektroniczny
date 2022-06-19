
namespace ProjektDziennik
{
    partial class Form2
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
            this.passInfo = new System.Windows.Forms.Label();
            this.logoutBT = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.typeInfo = new System.Windows.Forms.Label();
            this.removeBT = new System.Windows.Forms.Button();
            this.dataBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.type = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.surname = new System.Windows.Forms.ColumnHeader();
            this.addBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passInfo);
            this.panel1.Controls.Add(this.logoutBT);
            this.panel1.Controls.Add(this.userInfo);
            this.panel1.Controls.Add(this.typeInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 91);
            this.panel1.TabIndex = 1;
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
            // removeBT
            // 
            this.removeBT.Location = new System.Drawing.Point(125, 118);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(75, 23);
            this.removeBT.TabIndex = 4;
            this.removeBT.Text = "Usuń";
            this.removeBT.UseVisualStyleBackColor = true;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // dataBT
            // 
            this.dataBT.Location = new System.Drawing.Point(311, 118);
            this.dataBT.Name = "dataBT";
            this.dataBT.Size = new System.Drawing.Size(75, 23);
            this.dataBT.TabIndex = 5;
            this.dataBT.Text = "Dane";
            this.dataBT.UseVisualStyleBackColor = true;
            this.dataBT.Click += new System.EventHandler(this.dataBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Location = new System.Drawing.Point(206, 118);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(99, 23);
            this.resetBT.TabIndex = 6;
            this.resetBT.Text = "Resetuj hasło";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.type,
            this.name,
            this.surname});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 155);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 262);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
            // 
            // type
            // 
            this.type.Text = "Typ";
            this.type.Width = 70;
            // 
            // name
            // 
            this.name.Text = "Imie";
            this.name.Width = 140;
            // 
            // surname
            // 
            this.surname.Text = "Nazwisko";
            this.surname.Width = 140;
            // 
            // addBT
            // 
            this.addBT.Location = new System.Drawing.Point(44, 118);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(75, 23);
            this.addBT.TabIndex = 3;
            this.addBT.Text = "Dodaj";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 429);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.dataBT);
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projekt Dziennik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passInfo;
        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Label typeInfo;
        private System.Windows.Forms.Button removeBT;
        private System.Windows.Forms.Button resetBT;
        private System.Windows.Forms.Button dataBT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.Button addBT;
    }
}