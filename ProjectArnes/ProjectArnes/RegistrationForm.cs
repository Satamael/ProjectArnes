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

        }

        private void buttonRegistrationEnd_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxRePassword.Text &&
                textBoxLogin.Text != "" &&
                textBoxPassword.Text != "")
            {
                Configs.ThisUser.name = textBoxLogin.Text;
                Configs.ThisUser.password = textBoxPassword.Text;
                Configs.ThisUser.email = textBoxEmail.Text;
                Configs.ThisUser.promo = textBoxPromo.Text;
                Configs.ThisUser.donatCoins = 10;
                
                System.IO.File.AppendAllText("TableOne.csv", Environment.NewLine + Configs.ThisUser.name +
                    ';' + Configs.ThisUser.password +
                     ';' + Configs.ThisUser.email + 
                     ';' + Configs.ThisUser.promo +
                     ';' + Configs.ThisUser.donatCoins + ';');
               
                CreateCharacterForm ccf = new CreateCharacterForm();
                this.Close();
                ccf.ShowDialog();
                

            }
        }
    }
}
