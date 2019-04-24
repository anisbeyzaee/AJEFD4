using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD4
{
    static class Logger
    {

        public Logger() { }

        public static void log(string logMessage)
        {
            string tmpFolderPath = Path.GetTempPath();
            //string path = @"C:\Users\anisb\AppData\Local\Temp\\"; 
            try
            {
                using (StreamWriter w = File.AppendText(tmpFolderPath + "AJElog.txt"))
                {
                    writeLog(logMessage, w);
                }
            }

            catch (Exception e)
            {
                
            }

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

            }
            

        }

       
    }
}

