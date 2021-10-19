using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace UseQuartz
{
    public class SendJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() => Console.WriteLine(DateTime.Now));
        }
    }
}
