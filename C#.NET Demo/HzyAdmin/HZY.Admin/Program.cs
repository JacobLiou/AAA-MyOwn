using System;
using HZY.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using HZY.Framework.ApiResultManage;

namespace HZY.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                var host = CreateHostBuilder(args).Build();

                //设置NLog
                LogUtil.Init(logger);
                logger.Debug("初始化 Main !");
                host.Run();
            }
            catch (Exception exception)
            {
                if (!(exception is MessageBox))
                {
                    //NLog: catch setup errors
                    logger.Error(exception, "由于异常而停止程序!");
                }
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}