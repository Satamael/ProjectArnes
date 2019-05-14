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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void textBoxRePassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
           ;

        }

        private void buttonRegistrationEnd_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxRePassword.Text &&
                textBoxLogin.Text != "" &&
                textBoxPassword.Text != "")
            {
               List<String> LoginData = SQLClass.Select
                ("SELECT COUNT(*) FROM Users WHERE Name ='" + textBoxLogin.Text + "'");
               if (LoginData[0] == "0")
               {
                   SQLClass.Insert("INSERT INTO Users (Name,Password,Email,Promo,EXP,Coins,DonatCoins) VALUES ('" + textBoxLogin.Text + "', '" + textBoxPassword.Text + "','" + textBoxEmail.Text + "','" + textBoxPromo.Text + "', 0, 100, 10)");
                   Configs.ThisUser.name = textBoxLogin.Text;
                   Configs.ThisUser.password = textBoxPassword.Text;
                   Configs.ThisUser.email = textBoxEmail.Text;
                   Configs.ThisUser.promo = textBoxPromo.Text;
                   Configs.ThisUser.EXP = 0;
                   Configs.ThisUser.Coins = 100;
                   Configs.ThisUser.donatCoins = 10;
                   Configs.ThisUser.NChars = 1;
               }
                /*System.IO.File.AppendAllText("TableOne.csv", Environment.NewLine + Configs.ThisUser.name +
                    ';' + Configs.ThisUser.password +
                     ';' + Configs.ThisUser.email + 
                     ';' + Configs.ThisUser.promo +
                     ';' + Configs.ThisUser.donatCoins + ';');*/
                
               
                CreateCharacterForm ccf = new CreateCharacterForm();
                this.Close();
                ccf.ShowDialog();

            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
