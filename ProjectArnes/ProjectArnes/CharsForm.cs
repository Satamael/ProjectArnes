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
    public partial class FormChars : Form
    {
        public FormChars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateCharacterForm c = new CreateCharacterForm();
            c.ShowDialog();
            FormChars_Load(sender, e);
            this.Visible = true;

        }

        private void FormChars_Load(object sender, EventArgs e)
        {
            tableLayoutPanelBack.Controls.Clear();
            if (Configs.ThisUser.NChars > 2)
            {
                CreateNewCharacterButton.Visible = false;
            }

            List<string> Char1 = new List<string>(SQLClass.Select("SELECT Character1, Character2, Character3 FROM Users WHERE Name = '" + Configs.ThisUser.name + "'"));

            if (Configs.ThisUser.NChars>=1){                
                UserControlCharacter crct = new UserControlCharacter(Char1[0], 1);
                tableLayoutPanelBack.Controls.Add(crct,0,0);
                comboBoxChars.Items.Add("1");
            }
            if (Configs.ThisUser.NChars >= 2)
            {
                List<string> Char2 = new List<string>(SQLClass.Select("SELECT Character2 FROM Users WHERE Name = '" + Configs.ThisUser.name + "'"));

                UserControlCharacter crct = new UserControlCharacter(Char1[1], 2);
                tableLayoutPanelBack.Controls.Add(crct, 0, 1);
                comboBoxChars.Items.Add("2");
            }
            if (Configs.ThisUser.NChars >= 3)
            {
                List<string> Char3 = new List<string>(SQLClass.Select("SELECT Character3 FROM Users WHERE Name = '" + Configs.ThisUser.name + "'"));

                UserControlCharacter crct = new UserControlCharacter(Char1[2], 3);
                tableLayoutPanelBack.Controls.Add(crct, 0, 2);
                comboBoxChars.Items.Add("3");
            }
        }

        private void tableLayoutPanelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxChars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(comboBoxChars.SelectedItem);
            int n = 3;
            for(int index= k; index < n; index++){
            
            // SQLClass.Delete("UPDATE Users  SET Character" + comboBoxChars.SelectedItem+" =''  WHERE Name ='" + Configs.ThisUser.name + "'");
            SQLClass.Delete("UPDATE Users  SET Character" + index + " =Character" + (index+1).ToString() + "  WHERE Name ='" + Configs.ThisUser.name + "'");
            }
            SQLClass.Delete("UPDATE Users  SET Character" + n + " =''  WHERE Name ='" + Configs.ThisUser.name + "'");
            Configs.ThisUser.NChars--;
            FormChars_Load(sender, e);
            
        }
    }
}
