using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace MedicOS.Interface
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MedicOS.Interface.Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new InterfaceService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
