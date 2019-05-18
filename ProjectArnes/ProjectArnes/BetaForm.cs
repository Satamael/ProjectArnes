using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ProjectArnes
{
    public partial class BetaForm : Form
    {
        public BetaForm()
        {
            InitializeComponent();
        }

        private void BetaForm_Load(object sender, EventArgs e)
        {
            string pass="3469366daz";
            MailAddress adress = new MailAddress("demidvip@gmail.com", "ProjectArnes");
            MailMessage Mes = new MailMessage();
            Mes.Body = textBox1.Text;
            Mes.Subject = "Заявка на BetaTest";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(adress.Address, pass)
            };

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
#region mail
            string pass = "3469366daz";
            MailAddress adress = new MailAddress("demidvip@gmail.com", "ProjectArnes");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(adress.Address, pass)
            };
            if (Configs.logged == false)
            {
                MailMessage Mes = new MailMessage(adress, adress);
                Mes.Body = textBox1.Text;
                Mes.Subject = "Заявка на BetaTest";
                smtp.Send(Mes);
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                MailMessage Mes = new MailMessage(adress, adress);
                Mes.Body =Configs.ThisUser.name+Environment.NewLine+ Configs.ThisUser.email + Environment.NewLine + Environment.NewLine + textBox1.Text;
                Mes.Subject = "Заявка на BetaTest";
                smtp.Send(Mes);
            }
          
            #endregion
            MessageBox.Show("Заявка отправлена");
            this.Close();
        }
    }
}
