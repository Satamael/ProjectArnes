using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectArnes
{
    
   
    public partial class MainForm : Form
    {
        public static List<skill> fire = new List<skill>();
        public static List<skill> wather = new List<skill>();
        public static List<skill> terra = new List<skill>();
        public static List<skill> air = new List<skill>();
        public static List<skill> bone = new List<skill>();
        public static List<skill> metal = new List<skill>();
        public static List<skill> blood = new List<skill>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Configs.logined == true)
            {
                LabelThisLogined.Text = "Добро пожаловать, " + Configs.ThisUser.name;
                menuStripVirtical.Visible = true;

            }
            else { 
                LabelThisLogined.Text = "Добро пожаловать, Гость";
                /*UnloginToolStripMenuItem.Visible = false;
                CharsToolStripMenuItem.Visible = false;
                AchivToolStripMenuItem.Visible = false;
                QestsToolStripMenuItem.Visible = false;
                EventsToolStripMenuItem.Visible = false;
                MultiplayerToolStripMenuItem.Visible = false;
                SingleToolStripMenuItem.Visible = false;
                */
                menuStripVirtical.Visible = false;


            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.ShowDialog();
            MainForm_Load(sender, e);
        }

        private void персонажToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelBacked_Paint(object sender, PaintEventArgs e)
        {

        }

        private void приключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameplayForm gf = new GameplayForm();
            gf.ShowDialog();

        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            MainForm_Load(sender, e);
        }

        private void saddaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChars fc = new FormChars();
            fc.ShowDialog();
            MainForm_Load(sender, e);
        }

        private void LabelThisLogined_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configs.ThisUser.name = "";
            Configs.ThisUser.password = "";
            Configs.ThisUser.email = "";
            Configs.ThisUser.promo = "";
            Configs.logined = false;
            MainForm_Load(sender,e);
        }
    }
}
