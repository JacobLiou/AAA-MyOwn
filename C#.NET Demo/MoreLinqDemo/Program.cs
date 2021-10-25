using System;
using System.Linq;
using System.Linq.Expressions;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using MoreLinq;

namespace MoreLinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Normal();
            Normal1();
        }

        static void Normal()
        {
            var re = Enumerable.Range(0 ,10).AsQueryable().Where(x => x > 5 && x < 8).ToList();
            var res = Enumerable.Range(0 ,10).Where(x => x > 5 && x < 8);
            foreach(var item in re)
            {
                Console.WriteLine(item);
            } 

            foreach(var item in res)
            {
                Console.WriteLine(item);
            }         
        }

        static void Normal1()
        {
            //Linq对比Numpy LInq要达到Numpy目的 数据操作无敌  
// LINQ to Objects 
// LINQ to XML 
// LINQ to SQL 
            Expression<Func<int, bool>> exp = x => x > 1;
            Func<int, bool> filter = x => x > 1;
            var res = Enumerable.Range(0 ,10).Where(filter);
            res = Enumerable.Range(0 ,10).Where(exp.Compile());
            //IQuerable可以接收Expression参数
            res = Enumerable.Range(0 ,10).AsQueryable().Where(exp);
            foreach(var item in res)
            {
                Console.WriteLine(item);
            } 
        }

        static void MoreLinq1()
        {
            //来自于MoreLinq的扩展方法
            // GetFiles().Acquire();
            try
            {
                // var res = GetResources().Acquire();
            }
            catch
            {

            }

            var res = Enumerable.Range(0, 10).Shuffle().Select(n => new {Num=n, Stream=n.ToString()});
        //     res.Aggregate(
        //         0, (s, e)=> s+e.Num,
        //           0, (s, e) => e.Num % 2 == 0 ? s + e.Num : s,
        // 0, (s, _) => s + 1,
        // (int?)null, (s, e) => s is int n ? Math.Min(n, e.Num) : e.Num,
        // (int?)null, (s, e) => s is int n ? Math.Max(n, e.Num) : e.Num,
        // new HashSet<int>(), (s, e) => { s.Add(e.Str.Length); return s; },
        // new List<(int, string)>(), (s, e) => { s.Add((e.Num, e.Str)); return s; },
        // (sum, esum, count, min, max, lengths, items) => new
        // {
        //     Sum           = sum,
        //     EvenSum       = esum,
        //     Count         = count,
        //     Average       = (double)sum / count,
        //     Min           = min is int mn ? mn : throw new InvalidOperationException(),
        //     Max           = max is int mx ? mx : throw new InvalidOperationException(),
        //     UniqueLengths = "[" + string.Join(", ", lengths) + "]",
        //     Items         = "[" + string.Join(", ", items)   + "]",
        // })
        //     Writing each aggregator this way can be tedious, repetitive and error-prone because you cannot, for example, reuse Enumerable.Sum but there is a set of experimental overloads (that live in the MoreLinq.Experimental namespace) tha
        //     )
        }

        static IEnumerable<FileStream> GetFiles()
        {
            yield return File.OpenRead("File1");
            yield return File.OpenRead("File2");
            yield return File.OpenRead("File3");
        }

        // static IEnumerable<IDisposable> GetResources()
        // {
        //     Console.WriteLine("Yielding resource #1");
        //     yield return Disposable(() => WriteLine("Resource #1 disposed"));
        //     Console. WriteLine("Yielding resource #2");
        //     yield return Disposable(() => WriteLine("Resource #2 disposed"));
        //     Console.WriteLine("Yielding resource #3");
        //     throw new ApplicationException(); // Oops!
        //     // CS0162: Unreachable code detected
        //     yield return Disposable(() => WriteLine("Resource #3 disposed"));
        // }
    }
}
