using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将集合的集合合转换为一个集合
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            var list = new List<T>();
            List<IEnumerable<T>> listItem = @this.ToList();

            foreach(var item in listItem)
            {
                list.AddRange(item);
            }

            return list;
        }
    }
}