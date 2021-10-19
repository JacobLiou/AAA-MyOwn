using System;
using Hangfire;
using Hangfire.MemoryStorage;

namespace UseHangfire
{
    class Program
    {
        static void Main(string[] args)
        {
            //GlobalHangfireConfiguration.Instance.DoJob();
            ////RecurringJob.AddOrUpdate(() => Console.WriteLine("Transparent!"), "*/5 * * * * *");
            //BackgroundJob.Schedule(() => Console.WriteLine("Transparent!"), TimeSpan.FromMilliseconds(2000));
            //using (var server = new BackgroundJobServer())
            //{
            //    Console.ReadLine();
            //}

            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseColouredConsoleLogProvider()
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseMemoryStorage();

            //BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Transparent!"), "*/1 * * * * *");
            using (var server = new BackgroundJobServer())
            {
                Console.ReadLine();
            }

            Console.ReadKey();
        }

        
    }
}
