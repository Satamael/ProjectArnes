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

        private void Form1_Load(object sender, EventArgs e)
        {

            LabelThisLogined.Text = "Добро пожаловать " + Configs.ThisUser;
           /* File.WriteAllText("1.csv", "Логин;Пароль" + Environment.NewLine);
            File.AppendAllText("1.csv", "2q342134;235243534" + Environment.NewLine);
            File.AppendAllText("1.csv", "2q342134;235243534" + Environment.NewLine);
            File.AppendAllText("1.csv", "2q342134;235243534" + Environment.NewLine);
            File.AppendAllText("1.csv", "2q342134;235243534" + Environment.NewLine);
        */}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.ShowDialog();
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
        }

        private void saddaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChars fc = new FormChars();
            fc.ShowDialog();
        }

        private void LabelThisLogined_Click(object sender, EventArgs e)
        {

        }
    }
}
