﻿using System;
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
               
                System.IO.File.AppendAllText("TableOne.csv", Environment.NewLine + textBoxLogin.Text + ';' + textBoxPassword.Text + ';' + textBoxEmail.Text + ';' + textBoxPromo.Text + ';');
                CreateCharacterForm ccf = new CreateCharacterForm();
                this.Close();
                ccf.ShowDialog();
                

            }
        }
    }
}