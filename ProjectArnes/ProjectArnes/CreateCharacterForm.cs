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
        public CreateCharacterForm()
        {
            InitializeComponent();
        }

        private void buttonAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter= ".jpg";
            f.ShowDialog();
            
        }
    }
}
