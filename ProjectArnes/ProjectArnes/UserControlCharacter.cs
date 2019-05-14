using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectArnes
{
    public partial class UserControlCharacter : UserControl
    {
        public String[] tal;
        /// <summary>
        /// Номер персонажа
        /// </summary>
        public int nomer;

        public UserControlCharacter(String userData, int nom)
        {
            nomer = nom;
            InitializeComponent();

            if (userData == "")
            {
                return;
            }
            String[] stroki = userData.Split(new char[] { ',', '=','[',']' }, StringSplitOptions.RemoveEmptyEntries);
            labelName.Text += ": " + stroki[1];
            int index = 0;

            foreach (Control ct in tableLayoutPanelTalants.Controls)
            {
                
                if (tableLayoutPanelTalants.GetControlFromPosition(0,0)==null)
                {
                    
                }
            }

            foreach (string line in stroki)
            {
                index++;
                if (line.Trim() == "Gender")
                {
                    if (stroki[index].Trim() == "0")
                    {
                        pictureBoxGender.BackgroundImage = Properties.Resources.GenderFM; //System.Drawing.Image.FromFile(Properties.Resources.GenderFM);
                    }
                    else { pictureBoxGender.BackgroundImage = Properties.Resources.GenderM; }
                }
                if (line.Trim() == "Homeland")
                {
                    if (stroki[index].Trim() == "Arnes")
                    {
                        pictureBoxHomeland.Image = Properties.Resources.Arnes;
                        labelHome.Text = "Арнес";
                    }
                    if (stroki[index].Trim() == "Faro")
                    {
                        pictureBoxHomeland.Image = Properties.Resources.Faro;
                        labelHome.Text = "Фаро";
                    }
                    if (stroki[index].Trim() == "Vesk")
                    {
                        pictureBoxHomeland.Image = Properties.Resources.Vesk;
                        labelHome.Text = "Веск";
                    }

                }
                if (line.Trim() == "Str")
                {
                    labelSTR.Text = "Сила " + stroki[index].Trim();
                }
                if (line.Trim() == "Magic")
                {
                    labelMG.Text = "Магия " + stroki[index].Trim();
                }
                if (line.Trim() == "Dex")
                {
                    labelDEX.Text = "Ловкость " + stroki[index].Trim();
                }
                if (line.Trim() == "Charakter")
                {
                    labelCR.Text = "Харизма " + stroki[index].Trim();
                }
                if (line.Trim() == "Pic")
                {
                    pictureBoxAvatar.ImageLocation = stroki[index].Trim();
                }
                if (line.Trim() == "Talants")
                {
                    List<PictureBox> pbtal = new List<PictureBox>();
                    String[] stroki2 = userData.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                    tal = stroki2[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string tline in tal)
                    {
                        if (tline.Trim() == "Огонь")
                        {
                            PictureBox pb1tal = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources.Огонь

                            };
                            pbtal.Add(pb1tal);
                        }
                        if (tline.Trim() == "Вода")
                        {
                            PictureBox pb2tal = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources.Вода
                            };
                            pbtal.Add(pb2tal);
                        }
                        if (tline.Trim() == "Земля")
                        {
                            PictureBox pb3tal = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources.Земля
                            };
                            pbtal.Add(pb3tal);
                        }

                        if (tline.Trim() == "Воздух")
                        {
                            PictureBox pb4tal = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources.Воздух
                            };

                            pbtal.Add(pb4tal);
                        }

                        if (tline.Trim() == "Антари")
                        {
                            PictureBox pb5tal = new PictureBox
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Image = Properties.Resources.Кровь
                            };

                            pbtal.Add(pb5tal);
                        }
                        tableLayoutPanelTalants.Controls.AddRange(pbtal.ToArray());
                    }


                    // ДОДЕЛАТЬ БЛЕАТЬ!


                    /*if (tableLayoutPanelTalants.GetControlFromPosition(0, 0) == null)
                    {
                        PictureBox pbt1 = new PictureBox
                        {
                            Image = Properties.Resources.Воздух,
                            Dock = DockStyle.Fill,
                            SizeMode = PictureBoxSizeMode.StretchImage
                        };
                        tableLayoutPanelTalants.Controls.Add(pbt1,1,1);
                    }*/
                }




            }


        }

        private void UserControlCharacter_Load(object sender, EventArgs e)
        {
 
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Configs.ThisUserControlChar = this;
        }
    }
}