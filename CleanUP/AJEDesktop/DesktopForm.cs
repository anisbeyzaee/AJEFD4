using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJEDesktop
{
    public partial class DesktopForm : Form
    {
        public DesktopForm()
        {
            InitializeComponent();
        }


        FileBrowser myFileBrowser = new FileBrowser();
       // Image img;
        string fileName;

        OpenFileDialog ofd = new OpenFileDialog();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = null;

            }
            //Address.Text = ofd.FileName;

            fileName = ofd.FileName + "\"" + ofd.SafeFileName;
            PictureBox picBox = new PictureBox();
            pictureBox1.Image = Image.FromFile(fileName);



            picBox.BringToFront();

            picBox.Location = new System.Drawing.Point(10, 10);

            picBox.Size = new System.Drawing.Size(500, 500);

            picBox.Visible = true;


            //ImageView_fire.Source = (ofd.FileName);
        }
    }
}
