using System;
using NLog;

namespace UseNLog
{
    class Program
    {
        //NLog makes it easy to write to several targets. (database, file, console)
        //    and change the logging configuration on-the-fly.

        //配置化  组件使用
        //众多组件都是如此
        //Log组件  任务调度组件 等等组件


        static ILogger logger = LogManager.GetLogger(nameof(Program));

        static void Main(string[] args)
        {
            logger.Debug("sdfasdfsdafsdhfsadkjf调试");


            logger.Error("Error");

            logger.Info("Entering application.");
            Bar bar = new Bar();
            bar.DoIt();
            logger.Info("Exiting application.");


            Console.WriteLine("Hello World!");
        }
    }

    internal class Bar
    {
        private static readonly ILogger log = LogManager.GetLogger(nameof(Bar));

        public void DoIt()
        {
            log.Debug("Did it again!");
        }

    }
}
