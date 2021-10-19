using System;
using Serilog;

namespace UseSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var log = new LoggerConfiguration().
                WriteTo.Console().
                WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .MinimumLevel.Debug()
                .CreateLogger();

            log.Information("Hello World!");

            int a = 10, b = 0;
            try
            {
                log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                log.Error(ex, "Something went wrong");
            }
            finally
            {
                Log.CloseAndFlush();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
