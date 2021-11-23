using System;
using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {

        /// <summary>
        ///  自定义扩展方法：循环将泛型数组中的元素作为参数传入泛型委托中并执行，如果执行结果为 true 则将该元素加入集合中
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="predicate">泛型委托</param>
        /// <param name="values">泛型数组</param>
        /// <returns></returns>
        public static void AddRangeIf<T>(this ICollection<T> @this,Func<T,bool> predicate,params T[] values)
        {
            foreach(T value in values)
            {
                if(predicate(value))
                {
                    @this.Add(value);
                }
            }
        }
    }
}