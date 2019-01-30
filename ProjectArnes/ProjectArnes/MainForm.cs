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
    
    public struct skill
    {
        string name;
        string tips;
        string school;
        string anim;
        string picChar;
        string picTarget;
        PictureBox pic;
        int MPcost;
        int SPcost;
        int cooldown;
        int DMG;
    };

    public struct character
    {
        string name;
        int XP;
        List<Image> picPortret;
        int HP;
        int MP;
        int SP;
        string classPers;
        int DMG;

        public character(string str)
        {
            name = "";
            XP = 0;
            picPortret = new List<Image>();
            HP = 50;
            MP = 50;
            SP = 3;
            classPers="";
            DMG = 0;
        }
    };
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
           
        }

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
    }
}
