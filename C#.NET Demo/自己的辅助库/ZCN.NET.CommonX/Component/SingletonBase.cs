using System;
using System.Diagnostics;

namespace ZCN.NET.Common.Component
{
    /// <summary>
    /// 泛型类型的单例模式抽象基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SingletonBase<T> where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => (T)((object)Activator.CreateInstance(typeof(T), true)));

        [DebuggerBrowsable(DebuggerBrowsableState.Never), DebuggerNonUserCode]
        public static T Current
        {
            get
            {

                return SingletonBase<T>._instance.Value;
            }
        }
    }
}
