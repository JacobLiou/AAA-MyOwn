using System;
using System.Threading;
using Quartz;
using Quartz.Impl;
using Quartz.Job;

namespace UseQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scheduler = StdSchedulerFactory.GetDefaultScheduler();
            //scheduler.Start();
            //var job = JobBuilder.Create<SendJob>()
            //    .WithIdentity("myJob", "group1")
            //    .Build();
            //var trigger = TriggerBuilder.Create()
            //    .WithIdentity("myTrigger", "group1")
            //    .StartNow()
            //    .WithSimpleSchedule(x => x
            //        .WithIntervalInSeconds(5)
            //        .RepeatForever())
            //    .Build();

            //scheduler.ScheduleJob(job, trigger);
            //Console.WriteLine("Hello World!");

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

            // and start it off
            scheduler.Start();

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<SendJob>()
                .WithIdentity("job1", "group1")
                .Build();

            // Trigger the job to run now, and then repeat every 10 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(1)
                    .RepeatForever())
                .Build();

            // Tell quartz to schedule the job using our trigger
            scheduler.ScheduleJob(job, trigger);

            // some sleep to show what's happening
            Thread.Sleep(TimeSpan.FromSeconds(60));

            // and last shut down the scheduler when you are ready to close your program
            scheduler.Shutdown();
        }
    }
}
