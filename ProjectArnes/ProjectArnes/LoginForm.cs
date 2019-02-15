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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configs.UsersData= System.IO.File.ReadAllLines("TableOne.csv").ToList();
            foreach (string Line in Configs.UsersData)
            {
                //if (Line.StartsWith(textBoxLoginInput.Text+';'+textBoxPasswordInput+';'))
                if(Line == textBoxLoginInput.Text + ';' + textBoxPasswordInput + ';')
                {
                    Configs.ThisUser = textBoxLoginInput.Text;

                    this.Close();
                }
                else { MessageBox.Show("Введён бред, протри глаза");}
            }
            
           
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }
    }
}
