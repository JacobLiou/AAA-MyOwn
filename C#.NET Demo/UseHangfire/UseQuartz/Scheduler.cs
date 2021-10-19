using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;

namespace UseQuartz
{
    public class Scheduler
    {
        public void Start(DateTime date)
        {
            var scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
        }
    }
}
