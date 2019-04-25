using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace AJEFD4
{
    public partial class MyNewService : ServiceBase
    {
        
        private int eventId = 1;
       
        public MyNewService()
        {
            InitializeComponent();
            // to change the working directory to baseDirectory
            //System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
           

        }

        public void onDebug()
        {
            OnStart(null);
        }



        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");
            Logger.log("On Start");
            try
            {
                
                // Set up a timer that triggers every minute.
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 30000; // 30 seconds
                timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
                timer.Start();

                //ReadConfig rc = new ReadConfig();
                //list = rc.ReadObjType();

                // Create image file getter object
                //obj = ObjectFactoryPath.Create(list);
                //if (obj == null)
                //{
                //    Logger.log(" Path returned as an Empty String");
                //    return;
                //}
                //AJEJob.saveThePath(obj.getPath());

            }
            catch (Exception e)
            {
               Logger.log("OnStart Exception on OnStart() "+ e);
            }

        }


        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
            Logger.log("In OnContinue() ");
        }


        protected override void OnStop()
        {
            Logger.log("In OnStop() ");
            eventLog1.WriteEntry("In OnStop.");
        }



        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            Logger.log("OnTimer here");
            // TODO: Insert monitoring activities here.
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);

            
            
            Logger.log(" Thread has started");
            try
            {
                // As creating a child process might be a time consuming operation,
                // its better to do that in a separate thread than blocking the main thread.
                System.Threading.Thread ProcessCreationThread = new System.Threading.Thread(MyThreadFunc);
                ProcessCreationThread.Start();
                
                //ajj.AJEJobRun();
                //string id = Guid.NewGuid().ToString();
                // Save image path to temporary file
                //AJEJob.saveThePath(id + "," + obj.getPath());
            }
            catch (Exception e)
            {
                Logger.log("Thread one to create path "+e);
            }
            try
            {
                System.Threading.Thread ProcessCreationThread2 = new System.Threading.Thread(MyThreadFunc2);
                ProcessCreationThread2.Start();
            }
            catch (Exception e)
            {
                Logger.log("Thread two to run classifier with Error Code ' " + e);
            }

        }


        
        public static void MyThreadFunc()
        {
            AJEJob myAjEJob = new AJEJob();
            myAjEJob.AJEJobRun();
        }

        // This thread function would launch a child process 
        // in the interactive session of the logged-on user.
        public static void MyThreadFunc2()
        {
            //CreateProcessAsUserWrapper.LaunchChildProcess(@"C:\Users\anisb\source\repos\ReadImageBridge\RIBridge\bin\Debug\RIBridge.exe");
            CreateProcessAsUserWrapper.LaunchChildProcess(AppDomain.CurrentDomain.BaseDirectory + @"RIBridge.exe");
        }
    }
}
