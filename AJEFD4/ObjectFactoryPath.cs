using System;
using System.IO;
using System.Reflection;
using System.Linq;
using IPathLibrary;


namespace AJEFD4
{
    class ObjectFactoryPath
    {

        
        public static IPath Create(String[] fileInfo)
        {
           // Boolean fExist = true;
            
            //String[] info;
            String[] myList;
            myList = fileInfo;
            //IPath IObj;
            String dllFileName = myList[1];
            String nameSpace = myList[2];
            String className = myList[3];

            string thisClientDirectory =  GetThisAssemblyDirectory();
            string dllPath = Path.Combine(thisClientDirectory, dllFileName);
            if (!File.Exists(dllPath))
            {
               Logger.log("ERROR: File " + dllPath + " does not exist");
                return null;
            }

            // Load the DLL
            Assembly customDLL = Assembly.LoadFrom(dllPath);

            Type t = customDLL.GetType(className);
            if (t == null)
            {
                
                Logger.log("ERROR: Can't find class named " + dllFileName +  dllPath);
                return null;
            }


            // Create an instance of the class.
            object o = Activator.CreateInstance(t);

            // Check if o is of type IPath.
            if (!(o is IPath))
            {
                Logger.log("ERROR: Class :: " + className + "   does not implement interface IPath");
            }
            Logger.log("O is Created");
            // IPath customerObj = (IPath)o;
            //getPath = customerObj.getPath();
            //ExternalComcs ec = new ExternalComcs(getPath);
            //IObj = (IPath)o; 
            //return IObj;

            return o as IPath;

        }
        private static string GetThisAssemblyDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            Logger.log("OBJECTFACTORY LOG :: Assembly directory : " + path + "  " + Path.GetDirectoryName(path));
            return Path.GetDirectoryName(path);

        }
    }
}
