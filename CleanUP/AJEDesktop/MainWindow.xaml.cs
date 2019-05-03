using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace AJEDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileBrowser myFileBrowser = new FileBrowser();
        //Image img;
        string fileName;
        public MainWindow()
        {
            InitializeComponent();
          
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageView_fire.Source = null;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                ImageView_fire.Source = null;

            }
            Address.Text = ofd.FileName;
            
            fileName = ofd.FileName + "\"" + ofd.SafeFileName;
            PictureBox picBox = new PictureBox();
            picBox.Image = Image.FromFile(fileName);
            

            
            picBox.BringToFront();
            
            picBox.Location = new System.Drawing.Point(10, 10);

            picBox.Size = new System.Drawing.Size(500, 500);
            
            picBox.Visible = true;
            

            //ImageView_fire.Source = (ofd.FileName);




            //if (___rbtn_localImage_.IsChecked == true)

            //    myFileBrowser.ShowDialog();


            //if (___rbtn_onlineImages_.IsChecked == true)
            //    myFileBrowser.Hide();


        }

       
    }
}
