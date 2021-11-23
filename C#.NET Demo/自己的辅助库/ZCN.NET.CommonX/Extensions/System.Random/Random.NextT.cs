using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从指定的数组中随机返回一个元素
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="values">泛型类型数组</param>
        /// <returns></returns>
        public static T NextOne<T>(this Random @this, params T[] values)
        {
            return values[@this.Next(values.Length)];
        }
    }
}