using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

            
        //static void Main()
        //{
        //    ServiceBase[] ServicesToRun;
        //    ServicesToRun = new ServiceBase[]
        //    {
        //        new MyNewService()
        //    };
        //    ServiceBase.Run(ServicesToRun);
        //}


        static void Main()
        {

#if DEBUG
                    MyNewService myService = new MyNewService();
                    myService.onDebug();
                    System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                        new MyNewService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
