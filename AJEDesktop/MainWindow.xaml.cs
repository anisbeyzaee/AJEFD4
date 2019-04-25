using System.Windows;


namespace AJEDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileBrowser myFileBrowser = new FileBrowser();
        
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (___rbtn_localImage_.IsChecked == true)
            
                myFileBrowser.ShowDialog();


            if (___rbtn_onlineImages_.IsChecked == true)
                myFileBrowser.Hide();

        }
    }
}
