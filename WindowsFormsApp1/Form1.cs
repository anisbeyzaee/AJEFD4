
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Classify.Enabled = false;
            
        }
        string result;
        Image img;
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog();
        ExternalComcs ec = new ExternalComcs();
        


        private void btnLocal_Click(object sender, EventArgs e)
        {
            
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ImageDisplay_PictureBox.Image = null;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageDisplay_PictureBox.Image = null;

            }
            fileName = ofd.FileName.ToString() ;
            PictureBox picBox = new PictureBox();
            ImageDisplay_PictureBox.ImageLocation = fileName;
            picBox.BringToFront();
            picBox.Location = new System.Drawing.Point(10, 10);
            picBox.Size = new System.Drawing.Size(500, 500);
            picBox.Visible = true;


            textBox_fileName.Text = "File Name: " + fileName;
            textBox_fileName.BringToFront();
            Classification_Lable.Text = null;
            btn_Classify.Enabled = true;
            BackGround_pictureBox.BackColor = this.BackColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            result = "Classified As: " + ec.startProcess(fileName);
            Classification_Lable.Text = result;
            Classification_Lable.BringToFront();
            textBox_log.Text += String.Format(fileName + "Classified as: " + result + "{0}" , Environment.NewLine) ;

            BackGround_pictureBox.BackColor = System.Drawing.Color.Red;

        }
    }
}
