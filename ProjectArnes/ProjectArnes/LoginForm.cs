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
                string[] words = Line.Split(new char[] { ';' });

                user u1 = new user();
                u1.name = words[0];

                usery.Add(u1);

                String str = textBoxLoginInput.Text + ";" + textBoxPasswordInput.Text + ";";
                String str2 = textBoxLoginInput.Text + ';' + textBoxPasswordInput.Text + ';'; 
                if (Line.StartsWith(str))
                //if(Line == textBoxLoginInput.Text + ';' + textBoxPasswordInput + ';')
                {
                    Configs.ThisUser = textBoxLoginInput.Text;

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
    }
}
