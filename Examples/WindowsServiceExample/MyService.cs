using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceExample
{
    public partial class MyService : ServiceBase
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        public MyService()
        {
            InitializeComponent();
            
        }

        protected override void OnStart(string[] args)
        {
            //XmlConfigurator.Configure(new System.IO.FileInfo("LogConfig/log4net.config"));
            logger.Info("Windows服務啟動了");
        }

        protected override void OnStop()
        {
            logger.Info("Windows服務停止了");
        }

    }
}
