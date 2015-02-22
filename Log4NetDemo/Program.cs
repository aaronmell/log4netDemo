using System;
using System.IO;
using System.Reflection;
using Common.Logging;
using log4net.Config;

namespace Log4NetDemo
{
    class Program
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            //This configures the logger to use the Log4Net.config file. This must be done as early as possible in the lifetime of your application!
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log4Net.config")));

            //Just a Simple Logging Statement
            _logger.Info("Hello World");
        }
    }
}
