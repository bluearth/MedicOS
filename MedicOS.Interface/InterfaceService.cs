﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Configuration;

namespace MedicOS.Interface
{
    public partial class InterfaceService : ServiceBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MedicOS.Interface.InterfaceService));
        

        public InterfaceService()
        {
            InitializeComponent();
            
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Starting service...");
            try
            {
                log.Info("Loading configuration...");
                //InterfaceConfiguration config = (InterfaceConfiguration) ConfigurationManager.GetSection("interface");
                log.Info("Configuration loaded.");
                log.Info("Service started.");
            }
            catch (Exception e)
            {
                log.Error("Exception occured during service startup. ("+e.Message+")");
                log.Error(e.StackTrace);
                log.Error("Service failed to start.");
                throw e;
            }
        }

        protected override void OnStop()
        {
            log.Info("Stopping service...");
            try
            {
                log.Info("Service stopped.");
            }
            catch (Exception e)
            {
                log.Error("Exception occured during service stop. (" + e.Message + ")");
                log.Error(e.StackTrace);
                throw e;
            }
        }
    }

    
}
