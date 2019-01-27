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
    public partial class MainForm : Form
    {
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
    }
}
