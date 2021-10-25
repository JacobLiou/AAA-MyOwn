using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // for (int counter = 1; counter < 5; counter++)
            // {
            //     if (counter % 3 == 0)
            //     {
            //         WriteFactorialAsyncUsingTask(counter);
            //     }
            //     else
            //     {
            //         Console.WriteLine(counter);
            //     }
            // }

            await DoSomething(1);
            DoOtherSomething(2).Wait();
            
            // Console.ReadLine();
            SpinLockDemo.SpinLockSample1();
        }

        private static async Task DoSomething(int i)
        {
            Console.WriteLine("先运行");
            await Task.Delay(2000);
            Console.WriteLine(DateTime.Now.ToString() + "----" + i.ToString());
        }

        private static async Task DoOtherSomething(int i)
        {
            await Task.Delay(100);
            Console.WriteLine("先运行");
            Task.Delay(3000);
            Console.WriteLine(DateTime.Now.ToString() + "----" + i.ToString());
        }

        private static void WriteFactorialAsyncUsingTask(int no)
        {
            Task<int> task=Task.Run<int>(() =>
            {
                int result = FindFactorialWithSimulatedDelay(no);
                return result;
            });
            task.ContinueWith(new Action<Task<int>>((input) =>
            {
                Console.WriteLine("Factorial of {0} is {1}", no, input.Result);
            }));
        }

        private static int FindFactorialWithSimulatedDelay(int no)
        {
            int result = 1;
            for (int i = 1; i <= no; i++)
            {
                Thread.Sleep(500);
                result = result * i;
            }
            return result;
        }
    }
}
