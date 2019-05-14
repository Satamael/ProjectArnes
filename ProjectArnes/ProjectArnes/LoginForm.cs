using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectArnes
{
    public partial class LoginForm : Form
    {
        List<user> usery = new List<user>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     Configs.UsersData = SQLClass.Select("SELECT Email,Promo,EXP,Coins,DonatCoins,Character1,Character2,Character3 FROM Users WHERE Name = '" +
                textBoxLoginInput.Text + "' AND Password = '" + textBoxPasswordInput.Text + "'");
            //MessageBox.Show(System.IO.Path.GetTempPath());

            /*Configs.UsersData= System.IO.File.ReadAllLines("TableOne.csv").ToList();
            foreach (string Line in Configs.UsersData)
            {
                if (Line == Configs.UsersData[0])
                {
                    continue;
                }

                string[] words = Line.Split(new char[] { ';' });

                user u1 = new user();
                u1.name = words[0];

                usery.Add(u1);*/

     if (Configs.UsersData.Count >= 2)
                {
                    Configs.ThisUser.name = textBoxLoginInput.Text;
                    Configs.ThisUser.password = textBoxPasswordInput.Text;
                    Configs.ThisUser.email = Configs.UsersData[0];
                    Configs.ThisUser.promo = Configs.UsersData[1];
                    Configs.ThisUser.EXP = Convert.ToInt32(Configs.UsersData[2]);
                    Configs.ThisUser.Coins = Convert.ToInt32(Configs.UsersData[3]);
                    Configs.ThisUser.donatCoins = Convert.ToInt32(Configs.UsersData[4]);
                    Configs.ThisUser.NChars = 0;
                    if (Configs.UsersData[5] != "")
                    {
                        Configs.ThisUser.NChars++;
                    }
                    if (Configs.UsersData[6] != "")
                    {
                       Configs.ThisUser.NChars++;
                    }
                    if (Configs.UsersData[7] != "")
                    {
                        Configs.ThisUser.NChars++;
                    }
                    //Configs.ThisUser.Chars[1] = Configs.UsersData[5];

                    Configs.logged = true;

                    
                    this.Close();
                    return;
                }
            //}

            MessageBox.Show("Введён бред, протри глаза");
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
