using System;
using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：遍历集合的同时并执行指定的方法
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="action">要执行的方法</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            T[] array = @this.ToArray();
            foreach(T t in array)
            {
                action(t);
            }

            return array;
        }

        /// <summary>
        ///  自定义扩展方法：遍历集合的同时并执行指定的方法
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="action">要执行的方法</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            T[] array = @this.ToArray();

            for(int i = 0; i < array.Length; i++)
            {
                action(array[i], i);
            }

            return array;
        }
    }
}