#if NETSTANDARD

using System.Collections.Concurrent;
using System.Threading;

namespace ZCN.NET.Common.Component
{
    /// <summary>
    ///  模拟实现 .NET Framework 中  System.Runtime.Remoting.Messaging.CallContext 类
    /// </summary>
    public class CallContext
    {
        static readonly ConcurrentDictionary<string, AsyncLocal<object>> Container = new ConcurrentDictionary<string, AsyncLocal<object>>();

        private CallContext()
        {

        }

        /// <summary>
        /// 存储给定对象并将其与指定名称关联
        /// </summary>
        /// <param name="name">要与新项关联的调用上下文中的名称。</param>
        /// <param name="data">要存储在调用上下文中的对象。</param>
        public static void SetData(string name, object data)
        {
            Container.GetOrAdd(name, _ => new AsyncLocal<object>()).Value = data;
        }

        /// <summary>
        /// 检索具有指定名称的对象
        /// </summary>
        /// <param name="name">调用上下文中的项的名称</param>
        /// <returns></returns>
        public static object GetData(string name)
        {
            return Container.TryGetValue(name, out AsyncLocal<object> data) ? data.Value : null;
        }

    }
}

#endif