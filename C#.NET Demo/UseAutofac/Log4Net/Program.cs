using System;
using log4net;
using log4net.Config;

//直接程序集加入配置
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace UseLog4Net
{
    class Program
    {
        static ILog log = LogManager.GetLogger(nameof(Program));

        static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console.
            //BasicConfigurator.Configure();

            //使用配置文件进行日志输出配置
            //log4net.Config.XmlConfigurator.Configure();

            log.Error("Error");

            log.Info("Entering application.");
            Bar bar = new Bar();
            bar.DoIt();
            log.Info("Exiting application.");

            Console.WriteLine("Hello World!");
        }
    }

    internal class Bar
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Bar));

        public void DoIt()
        {
            log.Debug("Did it again!");
        }

    }
}
