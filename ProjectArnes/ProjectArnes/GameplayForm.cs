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
    public partial class GameplayForm : Form
    {
        public GameplayForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanelSkills.Controls.Clear();
            //tableLayoutPanelSkills.Controls.Add(button8, 0, 0);
            //Растянуть
            /*if (button2.Size.Width < 100)
            {
                button2.Size = new Size(300, 300);
                button2.Location = new Point(this.Width / 2, this.Height / 2);
            }
            //Ужать
            else
            {
                button2.Size = new Size(50, 50);
                button2.Location = new Point(40, 258);
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanelSkills.Controls.Clear();
            //tableLayoutPanelSkills.Controls.Add(button4, 0, 0);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
