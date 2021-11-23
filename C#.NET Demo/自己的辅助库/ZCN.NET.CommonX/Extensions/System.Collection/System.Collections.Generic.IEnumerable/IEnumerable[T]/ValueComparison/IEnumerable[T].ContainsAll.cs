using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断集合中是否包含数组中的所有元素。
        ///  全部包含时返回 true，否则返回false
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。泛型集合</param>
        /// <param name="values">泛型数组</param>
        /// <returns></returns>
        public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            T[] list = @this.ToArray();
            foreach(T value in values)
            {
                if(!list.Contains(value))
                {
                    return false;
                }
            }

            return true;
        }
    }
}