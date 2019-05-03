
using System;
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
        }
        
        Image img;
        string fileName;
        OpenFileDialog ofd = new OpenFileDialog();
        ExternalComcs ec = new ExternalComcs();



        private void button1_Click(object sender, EventArgs e)
        {
            
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            pictureBox1.Image = null;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = null;

            }
            fileName = ofd.FileName.ToString() ;
            PictureBox picBox = new PictureBox();
            pictureBox1.ImageLocation = fileName;
            picBox.BringToFront();
            picBox.Location = new System.Drawing.Point(10, 10);
            picBox.Size = new System.Drawing.Size(500, 500);
            picBox.Visible = true;

            textBox_fileName.Text = "File Name: " + fileName;
           Classification_Lable.Text ="Classified As: " + ec.startProcess(fileName);
           //Classification_Lable.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "folderName");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
