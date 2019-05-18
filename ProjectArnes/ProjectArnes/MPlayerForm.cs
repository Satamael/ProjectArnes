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
    public partial class MPlayerForm : Form
    { int enHP=100;
        string txt;
        public MPlayerForm()
        {
            InitializeComponent();
        }

        private void MPlayerForm_Load(object sender, EventArgs e)
        {
            Configs.ThisCharacter.HP = 100;
            progressBarHP.Maximum = Configs.ThisCharacter.HP;
            progressBarHP.Value = Configs.ThisCharacter.HP;
            progressBar2.Maximum = enHP;
            progressBar2.Value = enHP;

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



            List<string> check = new List<string>(SQLClass.Select("SELECT * FROM MPlayer"));
            if (check.Count != 0)
            {
                SQLClass.Update("UPDATE MPlayer SET UserTarget = '" + Configs.ThisUser.name + "'");
            } else
            {
                SQLClass.Insert("INSERT INTO MPlayer(UserHodit) VALUES('" + Configs.ThisUser.name + "')");
            }



            

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
            enHP -= Convert.ToInt32(click[2]);
            progressBarMP.Value -= Convert.ToInt32(click[5]);
            progressBar2.Value = enHP;
           textBox4.Text = Configs.ThisCharacter.name + " нанёс противнику " + click[2] + " урона используя " + txt + Environment.NewLine;
            List<string> dmg= new List<string>(SQLClass.Select("SELECT Damage FROM MPlayer WHERE "));
            Configs.ThisCharacter.HP -=Convert.ToInt32(dmg[0]);
            SQLClass.Update("UPDATE MPlayer SET Damage = '" + Convert.ToInt32(click[2]) + "'");
            
        }
        
    }
}
