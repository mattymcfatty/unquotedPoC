using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace SimpleWindowsService1
{
    public partial class SimpleService : ServiceBase
    {
        public SimpleService()
        {
            InitializeComponent();
            // Initialize eventLogSimple   
            if (!System.Diagnostics.EventLog.SourceExists("SimpleSource"))
                System.Diagnostics.EventLog.CreateEventSource("SimpleSource", "SimpleLog");
            eventLogSimple.Source = "SimpleSource";
            eventLogSimple.Log = "SimpleLog";
        }

        protected override void OnStart(string[] args)
        {
			//this is not executed for some reason
            eventLogSimple.WriteEntry("Uh oh. Program.exe was executed using unquoted path vulnerability. Service Started.");
        }

        protected override void OnStop()
        {
			//this is not executed for some reason
            eventLogSimple.WriteEntry("Uh oh. Program.exe was executed using unquoted path vulnerability. Service Stopped");
        }
    }
}
