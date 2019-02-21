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
    }
}
