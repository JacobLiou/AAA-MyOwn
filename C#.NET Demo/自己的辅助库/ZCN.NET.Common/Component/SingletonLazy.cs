#if NETFRAMEWORK //NET40 || NET45 ||NET461

using System.Runtime.Remoting.Messaging;

#endif

namespace ZCN.NET.Common.Component
{
    /// <summary>
    ///  多线程下的单例模式实现(即Lazy模式):保证在整个应用程序的生命周期中，在任何时刻，被指定的类只有一个实例，
    ///  并为客户程序提供一个获取该实例的全局访问点
    /// </summary>
    /// <typeparam name="T">泛型类型参数</typeparam>
    public class SingletonLazy<T> where T : class, new()
    {
        private static T _instance = CallContext.GetData(typeof(T).Name + "_ZFramework.NET") as T;
        private static object _lock = new object();

        /// <summary>
        ///  获取具体组件的实例
        /// </summary>
        public static T Instance
        {
            get
            {
                /* 外层的if语句块
                 * 每个线程欲获取实例时不必每次都得加锁，因为只有实例为空时（即需要创建一个实例），才需加锁创建;
                 * 若果已存在一个实例，就直接返回该实例，节省了性能开销
                 */
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        /* 内层的if语句块，
                         * 使用这个语句块时，先进行加锁操作，
                         * 保证只有一个线程可以访问该语句块，进而保证只创建了一个实例
                         */

                        if (_instance == null)
                        {
                            _instance = new T();
                            CallContext.SetData(typeof(T).Name + "_ZFramework.NET", _instance);
                        }
                    }
                }
                return _instance;
            }
        }
    }

    /// <summary>
    ///     饿汉模式的单例
    ///     这种模式的特点是自己主动实例化
    /// </summary>
    public sealed class SingletonHunger
    {
        /*上面使用的readonly关键可以跟static一起使用，
         * 用于指定该常量是类别级的，它的初始化交由静态构造函数实现，并可以在运行时编译。
         * 在这种模式下，无需自己解决线程安全性问题，CLR会给我们解决。
         * 由此可以看到这个类被加载时，会自动实例化这个类，而不用在第一次调用GetInstance()后才实例化出唯一的单例对象。
         */

        private static readonly SingletonHunger Instance = new SingletonHunger();

        private SingletonHunger()
        {
        }

        private static SingletonHunger GetInstance()
        {
            return Instance;
        }
    }
}