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
    public partial class CreateCharacterForm : Form
    {
        int m = 25;
        int c = 25;
        int s = 25;
        int d = 25;

        
        public CreateCharacterForm()
        {
            InitializeComponent();
            pictureBoxPoint.AllowDrop = true;


            if (Configs.ThisUser.promo == "ant" || Configs.ThisUser.promo == "andminBeta")
            {
                checkedListBoxCharClass.SetItemChecked(5, true);
            }
        }

        private void buttonAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter= ".jpg";
            f.ShowDialog();
            
        }
        public static System.Drawing.Drawing2D.GraphicsPath BuildTransparencyPath(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Image im = pb.BackgroundImage;
            int x;
            int y;
            if (pb.BackgroundImage == null)
            {
                return gp;
            }
            Bitmap bmp = new Bitmap(im);
            Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= pb.Size.Width - 1; x++)
            {
                for (y = 0; y <= pb.Size.Height - 1; y++)
                {
                    int newX = x * im.Size.Width / pb.Size.Width;
                    int newY = y * im.Size.Height / pb.Size.Height;

                    if (!bmp.GetPixel(newX, newY).Equals(mask))
                    {
                        gp.AddRectangle(new Rectangle(
                            x,
                            y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;
        }  
        private void CreateCharacterForm_Load(object sender, EventArgs e)
        {
            pictureBoxPoint.AllowDrop = true;
            System.Drawing.Drawing2D.GraphicsPath gp3 = BuildTransparencyPath(pictureBoxPoint);
            pictureBoxPoint.Region = new Region(gp3);
        }

        private void pictureBoxPoint_Click(object sender, EventArgs e)
        {
            pictureBoxPoint.AllowDrop = true;

        }

        private void pictureBoxPoint_DragEnter(object sender, DragEventArgs e)
        {
            pictureBoxPoint.AllowDrop = true;
            int r = 25;
            pictureBoxPoint.Location = Cursor.Position;
            s = (pictureBoxPoint.Location.X+r)/4;
            c = 50 -((pictureBoxPoint.Location.X + r) / 4);
            d = (pictureBoxPoint.Location.Y + r) / 4;
            m = 50 - ((pictureBoxPoint.Location.Y + r) / 4);
            labelHP.Text = "Сила " + s.ToString();
            labelСharakter.Text = "Харизма " + c.ToString();
            labelDex.Text = "Ловкость " + d.ToString();
            labelMagic.Text = "Магия " + m.ToString();
        }

        private bool _moving;
        private Point _startLocation;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int r = 25;
            _moving = true;
            _startLocation = e.Location;
            s = (pictureBoxPoint.Location.X + r) / 4;
            c = 50 - ((pictureBoxPoint.Location.X + r) / 4);
            d = (pictureBoxPoint.Location.Y + r) / 4;
            m = 50 - ((pictureBoxPoint.Location.Y + r) / 4);
            labelHP.Text = "Сила " + s.ToString();
            labelСharakter.Text = "Харизма " + c.ToString();
            labelDex.Text = "Ловкость " + d.ToString();
            labelMagic.Text = "Магия " + m.ToString();
        }

        private void pictureBoxPoint_MouseUp(object sender, MouseEventArgs e)
        {
            _moving = false;
        }

        private void pictureBoxPoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                int r = 25;
                pictureBoxPoint.Left += e.Location.X - _startLocation.X;
                pictureBoxPoint.Top += e.Location.Y - _startLocation.Y;
                if (pictureBoxPoint.Location.X < 0)
                {
                    pictureBoxPoint.Location = new Point(0, pictureBoxPoint.Location.Y);
                }
                else if (pictureBoxPoint.Location.X > panelChoose.Size.Width - 10)
                {
                    pictureBoxPoint.Location = new Point(panelChoose.Size.Width - 10, pictureBoxPoint.Location.Y);
                }
                if (pictureBoxPoint.Location.Y < 0)
                {
                    pictureBoxPoint.Location = new Point(pictureBoxPoint.Location.X, 0);
                }
                else if (pictureBoxPoint.Location.Y > panelChoose.Size.Height - 10)
                {
                    pictureBoxPoint.Location = new Point(pictureBoxPoint.Location.X, panelChoose.Size.Height - 10);
                }
                s = (pictureBoxPoint.Location.X + r) / 4;
                c = 50 - ((pictureBoxPoint.Location.X + r) / 4);
                d = (pictureBoxPoint.Location.Y + r) / 4;
                m = 50 - ((pictureBoxPoint.Location.Y + r) / 4);
                labelHP.Text = "Сила " + s.ToString();
                labelСharakter.Text = "Харизма " + c.ToString();
                labelDex.Text = "Ловкость " + d.ToString();
                labelMagic.Text = "Магия " + m.ToString();
            }
        }

        private void pictureBoxPoint_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            String DannyeOPersonage = "";
            DannyeOPersonage += "Name = " + textBoxName.Text;
            if (radioButtonMale.Checked)
            {
                DannyeOPersonage += ", Gender = 1";
            }
            else
            {
                DannyeOPersonage += ", Gender = 0";
            }

            if (radioButtonArnes.Checked)
            {
                DannyeOPersonage += ", Homeland = Arnes";
            }
            else if (radioButtonFaro.Checked)
            {
                DannyeOPersonage += ", Homeland = Faro";
            }
            else if (radioButtonVesk.Checked)
            {
                DannyeOPersonage += ", Homeland = Vesk";
            }
            DannyeOPersonage += ", Talants[";
            foreach (String item in checkedListBoxCharClass.CheckedItems)
            {
                DannyeOPersonage += item+ ",";
            }
            DannyeOPersonage += "Тело,+]";
            DannyeOPersonage += ", Str=" + s.ToString() + ", Magic=" + m.ToString() + ", Dex=" + d.ToString() + ", Charakter=" + d.ToString();
            DannyeOPersonage += ", Pic=";
            if (textBoxAvatar.Text != "" && textBoxAvatar.Text != "Ссылка на аватар")
            {
                
                DannyeOPersonage += textBoxAvatar.Text;

            }
            else
            {
                DannyeOPersonage += "https://pbs.twimg.com/profile_images/1565063893/LogoSiluet_125x125_400x400.jpg";
            }

            MessageBox.Show(DannyeOPersonage);
            Configs.ThisUser.NChars++;
            SQLClass.Update("UPDATE Users SET Character" + Configs.ThisUser.NChars.ToString() + "='" + DannyeOPersonage + "' WHERE Name = '" + Configs.ThisUser.name + "'");
            this.Close();
            /*string vybrLinia = "";
            //Configs.UsersData= System.IO.File.ReadAllLines("TableOne.csv").ToList();
            //int NambStrb =0;
            //int NeededStrb = 0;
            foreach (string Line in Configs.UsersData)
            {
                
                if (Line.StartsWith(Configs.ThisUser.name + ';' + Configs.ThisUser.password))
                {
                    vybrLinia = Line;
                    NeededStrb = NambStrb;
                    //Line += DannyeOPersonage;
                }
              
                NambStrb++;
                
            }*/

         //   SQLClass.Insert("INSERT INTO Users () VALUES ("",,)");
            //Configs.UsersData[NeededStrb] +=','+ DannyeOPersonage;
           
           

            
  
        




        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void checkedListBoxCharClass_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public bool checked1 = false;

        private void checkedListBoxCharClass_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (Configs.ThisUser.promo == "ant" || Configs.ThisUser.promo == "andminBeta")
            {
                if (e.Index == 5)
                {
                    e.NewValue = CheckState.Checked;
                }
            }

            if (checkedListBoxCharClass.CheckedItems.Count >= 4 ||
                checkedListBoxCharClass.CheckedItems.Count >= 3 && 
                !(Configs.ThisUser.promo == "ant" || Configs.ThisUser.promo == "andminBeta")
                )
            {
                //checkedListBoxCharClass.SetItemChecked(e.Index, false);
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxAvatar_TextChanged(object sender, EventArgs e)
        {
            pictureBoxAvatar.ImageLocation = textBoxAvatar.Text;
            CreateCharacterForm_Load(sender, e);


        }

        private void buttonAva_Click_1(object sender, EventArgs e)
        {
            pictureBoxAvatar.ImageLocation = textBoxAvatar.Text;
            CreateCharacterForm_Load(sender, e);
        }
    }
}
