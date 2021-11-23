using System;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：从字符串中移除指定条件的字符
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="predicate">过滤条件</param>
        /// <returns></returns>
        public static string RemoveWhere(this string @this, Func<char, bool> predicate)
        {
            return new string(@this.ToCharArray().Where(x => !predicate(x)).ToArray());
        }
    }
}