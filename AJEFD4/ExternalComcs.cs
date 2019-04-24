using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD4
{
    class ExternalComcs
    {
        string message;

        public ExternalComcs() { }
        
        public void startProcess(String path)
        {
            bridge(path, @"Classifier", @"ReadImage ");
            //bridge(message, @"NotificationBox", @"PDisplay");
        }

        private void bridge(String path, string folderName, string javaFile)
        {
            ProcessStartInfo s = new ProcessStartInfo();
                       
            //var fileName = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"Classifier");

            s.FileName = @"C:\Program Files\Java\jdk-11.0.2\bin\java.exe";

           // s.WorkingDirectory = @"C:\Temp\JClassifier";
            string fn = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,folderName );
            s.WorkingDirectory = fn;
            s.Arguments = javaFile + path;
            s.UseShellExecute = false;
            s.RedirectStandardOutput = true;
            s.RedirectStandardError = true;
            s.CreateNoWindow = true;
            Process process = new Process();

            process.StartInfo = s;
            process.Start();
          
            while (!process.StandardOutput.EndOfStream)

            {

                this.message = process.StandardOutput.ReadLine();

                break;

            }
            System.Windows.MessageBox.Show("Joe says :  " + this.message);
        }
    }
}
