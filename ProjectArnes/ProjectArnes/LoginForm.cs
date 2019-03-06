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
            //MessageBox.Show(System.IO.Path.GetTempPath());

            Configs.UsersData= System.IO.File.ReadAllLines("TableOne.csv").ToList();
            foreach (string Line in Configs.UsersData)
            {
                if (Line == Configs.UsersData[0])
                {
                    continue;
                }

                string[] words = Line.Split(new char[] { ';' });

                user u1 = new user();
                u1.name = words[0];

                usery.Add(u1);

                if (words[0] == textBoxLoginInput.Text &&
                    words[1] == textBoxPasswordInput.Text)
                {
                    Configs.ThisUser.name = words[0];
                    Configs.ThisUser.password = words[1]; //ДОПИЛИ СУКА
                    Configs.ThisUser.email = words[2];
                    Configs.ThisUser.promo = words[3];
                    Configs.logined = true;
                    
                    this.Close();
                    return;
                }
            }

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
