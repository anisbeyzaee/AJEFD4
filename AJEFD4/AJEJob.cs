using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IPathLibrary;

namespace AJEFD4
{
    class AJEJob
    {
        IPath obj;
        String[] list;
        static FileStream fs;
        static string filePath3;
        public AJEJob()
        {
            Logger.log("AJEJOB Thread has started to begin");
            
            ReadConfig rc = new ReadConfig();
             list = rc.ReadObjType();


            // for saveThePath3()



            // this method is to move to Logger.cleanAllLogs()

            filePath3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"PathInfo3.txt");
            try
            {
                if (File.Exists(filePath3))
                {

                    File.Delete(filePath3);

                }

            }
            catch(Exception e)
            {
                Logger.log("AJEJOB Thread Constructor " + e);
            }

            

        }
        public  void AJEJobRun()
        {
            Logger.log("AJEJOB Thread has started to begin the AJEJobRun");
            // Create image file getter object
            obj = ObjectFactoryPath.Create(list);
            if (obj == null)
            {
                Logger.log("Obj is null");
                return;
            }
            Logger.log("Object is  "  + obj.getPath());
            try
            {
                string id = Guid.NewGuid().ToString();
                //saveThePath(id + "," + @"C:\Users\anisb\source\repos\AJEFDService3\LocalTestImages\this.JPG");
                //saveThePath(obj.getPath());
                // Save image path to temporary file
                //saveThePath(id + "," + obj.getPath());
                //saveThePAth2(id + "," + obj.getPath());
                saveThePath3(id + "," + obj.getPath());
            }
            catch (Exception ex)
            {
                Logger.log("AJEFD Run()  has error of  "+ex.ToString());
            }
        }
        public static void saveThePath3(string pathArgument)
        {


            //Create the file.
            try
            {
                using (FileStream fs = File.Create(filePath3))
                {

                    byte[] info = new UTF8Encoding(true).GetBytes(pathArgument);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch(Exception e)
            {
                Logger.log("  saveTHePath3  ErrorCode  "+e.ToString());
            }

        }
        public static void saveThePAth2(string pathArgument)
        {
            try
            {
                using (FileStream fileStream =
                File.Create(AppDomain.CurrentDomain.BaseDirectory + "Path2.txt"))
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(pathArgument);
                }
            }
            catch (Exception e)
            {
                Logger.log("Path is not saved method saveThePath2()" + e.ToString());
            }
        }

        public static void saveThePath(string pathArgument)
        {

            fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Path.txt" , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(path);

            // string tmpFolderPath = Path.GetTempPath();   //path to windows temp folder
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"PathInfo.txt");
            try
            {
                using (sw)
                {
                    if (fs.CanRead)
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(pathArgument);
                        fs.Write(buffer, 0, buffer.Length);
                    }
                    fs.Flush();
                    fs.Close();
                }
            }
            catch(Exception e)
            {
                Logger.log("Path is not saved" + e.ToString());
            }
        }


    }
}
