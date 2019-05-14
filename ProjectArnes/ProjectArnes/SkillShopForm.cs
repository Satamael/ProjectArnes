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
    public partial class SkillShopForm : Form
    {
        string name = "";
        public SkillShopForm()
        {
            InitializeComponent();
        }

        private void SkillShopForm_Load(object sender, EventArgs e)
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
            for (int i = 0; i < dannye.Count; i+=2)
            {
                Panel p1 = new Panel();
                p1.Tag = dannye[i];
                p1.Dock = DockStyle.Fill;

                PictureBox pn1 = new PictureBox();
                pn1.Load(dannye[i+ 1]);
                p1.BackgroundImage = pn1.Image;
                p1.BackgroundImageLayout = ImageLayout.Stretch;
                p1.Click += new EventHandler(tableElement_Click);
                pn1.Click += new EventHandler(tableElement_Click);

                Label l1 = new Label();
                l1.Text = dannye[i];
                l1.Dock = DockStyle.Top;
                l1.BackColor = Color.Transparent;
                l1.Click += new EventHandler(tableElement_Click);

                p1.Controls.Add(l1);
                tableLayoutPanelSkills.Controls.Add(p1, i/2, 0);
            }
        }

        private void buttoRefresh_Click(object sender, EventArgs e)
        {
            SkillShopForm_Load(sender, e);
        }

        

        private void tableLayoutPanelSkills_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDMG_Click(object sender, EventArgs e)
        {

        }

        private void tableElement_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tableLayoutPanelSkills.Controls)
            {
                if (ctrl.GetType().Name.Contains("Panel"))
                {
                    ((Panel)ctrl).BorderStyle = BorderStyle.None;
                    foreach (Control ctr in ctrl.Controls)
                    {

                        if (ctr.GetType().Name.Contains("Label"))
                        {
                            ((Label)ctr).BorderStyle = BorderStyle.None;
                        }
                    }
                }
            }

            String txt = "";
            try
            {
                Label l1 = (Label)sender;
                txt = l1.Text;
                name = txt;
                l1.BorderStyle = BorderStyle.Fixed3D;
            }
            catch
            {
                Panel p1 = (Panel)sender;
                txt = p1.Tag.ToString();
                name = txt;
                p1.BorderStyle = BorderStyle.Fixed3D;
            }
            List<string> click = new List<string>(SQLClass.Select("SELECT Tip,Talant,Damage,CDtime,Cost,EXP FROM Skills WHERE Name = '" + txt + "'"));
            for (int i = 0; i < click.Count; i += 6)
            {
                textBox1.Text = click[i];
                labelSchool.Text = "Требуется талант "+ click[i + 1];
                labelDMG.Text ="Урон "+ click[i + 2];
                labelCD.Text = "Восстановление " +click[i + 3];
                labelCost.Text = "Мана "+click[i + 4];
                labelEXP.Text = "Цена " + click[i + 5];
                
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int nom = Configs.ThisUserControlChar.nomer;
            List<string> ch = new List<string>(SQLClass.Select("SELECT Character" + nom.ToString() + " FROM Users WHERE Name='" + Configs.ThisUser.name + "'"));
            string[] chS = ch[0].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string[] chSS = chS[1].Split(new char[] { ',', '=' }, StringSplitOptions.RemoveEmptyEntries);
            int i=0;

            foreach(string line in chSS)
            {
                List<string> need = new List<string>(SQLClass.Select("SELECT Cost FROM Skills WHERE Name = '" + name + "'"));
                if (line.Trim() == name)
                {
                    string res = (Convert.ToInt32(chSS[i + 1]) + 1).ToString();
                    ch[0] = ch[0].Replace(name + "=" + chSS[i + 1], name + "=" + res);
                    SQLClass.Update("UPDATE Users SET Character" + nom.ToString() + " = '" + ch[0] + "' WHERE Name='" + Configs.ThisUser.name + "'");
                    List<string> str = new List<string>(SQLClass.Select("SELECT EXP FROM Users WHERE Name='" + Configs.ThisUser.name + "'"));
                    int minus = Convert.ToInt32(str[0]) - Convert.ToInt32(labelEXP.Text.Replace("Цена", ""));
                    List<string> Check =new List<string>(SQLClass.Select("SELECT EXP FROM Users WHERE Name= '" + Configs.ThisUser.name + "'"));

                    if (Convert.ToInt32(Check[0])>= Convert.ToInt32(need[0]))
                    {
                        SQLClass.Update("UPDATE Users SET EXP= " + minus.ToString() + " WHERE Name ='" + Configs.ThisUser.name + "'");
                    }
                    
                }
                i++;
            }


            




        }
    }
}
