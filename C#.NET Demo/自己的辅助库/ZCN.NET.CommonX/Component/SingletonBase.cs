using System;
using System.Diagnostics;

namespace ZCN.NET.Common.Component
{
    /// <summary>
    /// �������͵ĵ���ģʽ�������
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
