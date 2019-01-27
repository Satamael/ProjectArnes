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

    /*public struct character
    {
        string name;
        int XP;
                PictureBox pic;
        int MPcost;
        int SPcost;
        int cooldown;
        int DMG;
    };*/
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
            GameplayForm gf = new GameplayForm();
            gf.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void персонажToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelBacked_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
