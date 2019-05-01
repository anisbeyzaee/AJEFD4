using System;
using System.IO;


namespace AJEFD4
{
    static class Logger
    {
        
        public  static void log(string logMessage)
        {   
            //string tmpFolderPath = Path.GetTempPath();
            //string path = @"C:\Users\anisb\AppData\Local\Temp\\"; 
            try
            {
                using (StreamWriter w = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "\\AJElog.txt"))
                {
                    writeLog(logMessage, w);
                    w.Close();
                }
            }

            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error Occured opening the LOGFile" + e);
            }

        }

        private static void cleanAllLogs()
        {

        }

        private static void writeLog(string logMessage, StreamWriter w)
        {
            
            try
            {

                w.Write("\r\nLog Entry : ");
                w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.WriteLine("  :");
                w.WriteLine($"  :{logMessage}");
                w.WriteLine("-------------------------------");
            } catch (Exception e)
            {
                System.Windows.MessageBox.Show("Error Occured on Adding the LOG to file" + e);
            }
            

        }

       
    }
}

