using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AJEDesktop
{
    public partial class FileBrowser : Form
    {
        List<string> listFiles = new List<string>();
        string folderPath;
        ExternalComcs eComcs = new ExternalComcs();
        ExternalCom eCom = new ExternalCom();
        public FileBrowser()
        {
            InitializeComponent();
            
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your file." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    textPath.Text = fbd.SelectedPath;
                    folderPath = fbd.SelectedPath;
                    foreach(string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);

                    }
                    
                }

            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView.FocusedItem != null)
                Process.Start(listFiles[listView.FocusedItem.Index]);
            
            string fileName = listView.FocusedItem.Name;
            string folder = folderPath + fileName;
            Form form = new Form();
            form.Text = folder +"\n" + "file name is =" + fileName;
            form.ShowDialog();
            eCom.connect(folder);
            eComcs.startProcess(folder);
        }
    }
}
