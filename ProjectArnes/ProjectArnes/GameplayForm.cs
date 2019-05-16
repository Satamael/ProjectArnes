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
        int raund = 0;
        int enemyHP;
        string txt;
        string target;
        int NomNod;
        public GameplayForm()
        {
            InitializeComponent();
            
            Configs.ThisCharacter.HP=100+ Convert.ToInt32(Configs.ThisUserControlChar.labelSTR.Text.Replace("Сила", ""));
            progressBarHP.Maximum = Configs.ThisCharacter.HP;
            progressBarHP.Value = Configs.ThisCharacter.HP;
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

        private void GameplayForm_Resize(object sender, EventArgs e)
        {
            //   progressBarEmemyHP.Location = new Point(this.Width * (2 / 3), progressBarEmemyHP.Location.Y);
            // progressBarEmemyHP.Size = new Size(this.Width / 3 - 20, 30);
        }

        private void GameplayForm_Load(object sender, EventArgs e)
        {
            if (Configs.ThisUserControlChar == null)
            {
                return;
            }

            string talants = String.Join(",", Configs.ThisUserControlChar.tal);

            string zapros = "Talant LIKE '@@@@@@@@'";
            string[] tall = talants.Split(new char[] { ',' });
            foreach (string line in tall)
            {
                zapros += " OR Talant LIKE " + "'%" + line + "%' ";
            }

            List<String> dannye = SQLClass.Select("SELECT Name, Pic FROM Skills WHERE " + zapros); //FOR!!!
            tableLayoutPanelSkills.Controls.Clear();
            for (int i = 0; i < dannye.Count; i += 2)
            {
                Panel p1 = new Panel();
                p1.Tag = dannye[i];
                p1.Dock = DockStyle.Fill;

                PictureBox pn1 = new PictureBox();
                pn1.Load(dannye[i + 1]);
                p1.BackgroundImage = pn1.Image;
                p1.BackgroundImageLayout = ImageLayout.Stretch;
                p1.Click += new EventHandler(Hit_Click);


                Label l1 = new Label();
                l1.Text = dannye[i];
                txt = l1.Text;
                l1.Dock = DockStyle.Top;
                l1.BackColor = Color.Transparent;
                l1.Click += new EventHandler(Hit_Click);
                pn1.Click += new EventHandler(Hit_Click);


                p1.Controls.Add(l1);
                tableLayoutPanelSkills.Controls.Add(p1, i / 2, 0);
            }
            List<string> EnemyList = new List<string>(SQLClass.Select("SELECT * FROM Enemy LIMIT " + raund.ToString() + "," + '1'));
            labelEnName.Text = EnemyList[0];

            pictureBoxEnPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnPic.ImageLocation = EnemyList[5];

            enemyHP = Convert.ToInt32(EnemyList[1]);

            progressBarEmemyHP.Maximum = enemyHP;
            progressBarEmemyHP.Value = enemyHP;




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarHP.Value = Configs.ThisCharacter.HP;
            if (NomNod % 2 == 0)
            {
                List<string> EnemyList = new List<string>(SQLClass.Select("SELECT * FROM Enemy LIMIT " + raund.ToString() + "," + '1'));
                string talants = String.Join(",", EnemyList[3]);

                string zapros = "Talant LIKE '@@@@@@@@'";
                string[] tall = talants.Split(new char[] { ',' });
                foreach (string line in tall)
                {
                    zapros += " OR Talant LIKE " + "'%" + line + "%' ";
                }

                List<String> enSkills = SQLClass.Select("SELECT * FROM Skills WHERE " + zapros);
                Random rand = new Random();
                int rnd = rand.Next(0, enSkills.Count / 8);
                int vp = rnd;
                int dmg = Convert.ToInt32(enSkills[(vp/8)+3]);
                Configs.ThisCharacter.HP -= dmg;
                progressBarHP.Value = Configs.ThisCharacter.HP;
                
                // List<string> click = new List<string>(SQLClass.Select("SELECT Tip,Name,Damage,CDtime,Cost,EXP FROM Skills WHERE Talant = '" + EnemyList[3] + "'"));
                NomNod++;
            }
        }

        private void tableLayoutPanelSkills_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBackgraund_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Hit_Click(object sender, EventArgs e)
        {
            try
            {
                Panel p1 = (Panel)sender;
            }
            catch
            {
                Label p1 = (Label)sender;
            }
                List<string> click = new List<string>(SQLClass.Select("SELECT Tip,Talant,Damage,CDtime,Cost,EXP FROM Skills WHERE Name = '" + txt + "'"));
            enemyHP -=Convert.ToInt32(click[2]);
            progressBarMP.Value -= Convert.ToInt32(click[5]);
            progressBarEmemyHP.Value = enemyHP;
            NomNod++;
            if (NomNod % 2 == 0)
            {textBox4.Text = Configs.ThisCharacter.name + " нанёс противнику " + click[2] + " урона используя " + txt + Environment.NewLine;}
         
            

        }
    }
}
/**/