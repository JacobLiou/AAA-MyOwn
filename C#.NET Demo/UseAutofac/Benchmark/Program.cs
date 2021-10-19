using BenchmarkDotNet.Running;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Benchmark
{

    //Activator.CreateInstance Performance Alternative

    //constructorinfo invoke vs Activator.CreateInstance
    /// <summary>
    /// 不同对象创建的Benchmark
    /// 时间
    /// 还有空间怎么计算？  有的可能是空间换取时间了呢？
    ///
    ///
    /// https://andrewlock.net/benchmarking-4-reflection-methods-for-calling-a-constructor-in-dotnet/
    /// https://www.cnblogs.com/myshowtime/p/15043961.html
    ///
    ///// 直接调用 ConstructorInfo 对象的Invoke()方法
    //使用 Activator.CreateInstance()
    //使用 Microsoft.Extensions.DependencyInjection
    //黑科技 Natasha
    //使用表达式 Expression
    //使用 Reflection.Emit 创建动态方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Best way for performance to repeatedly create instance in runtime is compiled expression:

            //static readonly Func<X> YCreator = Expression.Lambda<Func<X>>(
            //    Expression<>.New(typeof(Y).GetConstructor(Type.EmptyTypes))
            //).Compile();

            //X x = YCreator();
            var sumary = BenchmarkRunner.Run<ReflectionBenchmarks>();
        }
    }

    public class Employee { }

    public class ReflectionBenchmarks
    {
        private readonly ConstructorInfo _ctor;
        private readonly IServiceProvider _provider;
        private readonly Func<Employee> _expressionActivator;
        private readonly Func<Employee> _emitActivator;
        //private readonly Func<Employee> _natashaActivator;


        public ReflectionBenchmarks()
        {
            _ctor = typeof(Employee).GetConstructor(Type.EmptyTypes);

            _provider = new ServiceCollection().AddTransient<Employee>().BuildServiceProvider();

            //NatashaInitializer.Initialize();
            //_natashaActivator = Natasha.CSharp.NInstance.Creator<Employee>();


            _expressionActivator = Expression.Lambda<Func<Employee>>(Expression.New(typeof(Employee))).Compile();

            DynamicMethod dynamic = new("DynamicMethod", typeof(Employee), null, typeof(ReflectionBenchmarks).Module, false);
            ILGenerator il = dynamic.GetILGenerator();
            il.Emit(OpCodes.Newobj, typeof(Employee).GetConstructor(System.Type.EmptyTypes));
            il.Emit(OpCodes.Ret);
            _emitActivator = dynamic.CreateDelegate(typeof(Func<Employee>)) as Func<Employee>;

        }

        [Benchmark(Baseline = true)]
        public Employee UseNew() => new Employee();

        [Benchmark]
        public Employee UseReflection() => _ctor.Invoke(null) as Employee;

        [Benchmark]
        public Employee UseActivator() => Activator.CreateInstance<Employee>();

        [Benchmark]
        public Employee UseDependencyInjection() => _provider.GetRequiredService<Employee>();

        //[Benchmark]
        //public Employee UseNatasha() => _natashaActivator();


        [Benchmark]
        public Employee UseExpression() => _expressionActivator();


        [Benchmark]
        public Employee UseEmit() => _emitActivator();


    }
}
