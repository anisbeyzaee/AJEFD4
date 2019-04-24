﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPathLibrary;
using System.Security.Permissions;
using System.Security;

namespace LocalResources
{
    public class LocalSource : IPath
    {
        readonly String SourcePath = @"C:\Users\anisb\source\repos\AJEFDService\LocalTestImages";

        public string getPath()
        {
            return getFileRandmly(SourcePath);
           
        }

        

        private void AddText(FileStream fs, string path)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(path);
            fs.Write(info, 0, info.Length);
        }

        private string getFileRandmly(string path)
        {
            var rand = new Random();
            var files = Directory.GetFiles(path, "*.*");
            if (files.Length == 0)
            {
                Console.WriteLine(" Source Folder empty. No file can be tested");

            }
            return files[rand.Next(files.Length)];

        }
        private string getrandomfile(string path)
        {
            string filePath = null;
            if (!string.IsNullOrEmpty(path))
            {
                var extensions = new string[] { ".png", ".jpg", ".gif" };
                try
                {
                    var di = new DirectoryInfo(path);
                    var rgFiles = di.GetFiles("*.*").Where(f => extensions.Contains(f.Extension.ToLower()));
                    Random R = new Random();
                    filePath = rgFiles.ElementAt(R.Next(0, rgFiles.Count())).FullName;


                }
                // probably should only catch specific exceptions
                // throwable by the above methods.
                catch { }
            }
            // Console.WriteLine("file full name is ..." + file);
            return filePath;
        }

    }
}
