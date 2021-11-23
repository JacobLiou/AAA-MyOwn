using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：检索程序集的第一个自定义特性。如果没有则返回 null
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T GetAttribute<T>(this Assembly @this) where T : Attribute
        {
            object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof(T), false);
            if (configAttributes != null && configAttributes.Length > 0)
                return (T)configAttributes[0];

            return null;
        }
    }
}