using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region AppendJoin

        /// <summary>
        /// 自定义扩展方法：使用分隔符将泛型类型集合中的元素串联起来，然后追加到扩展对象结尾
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">分隔符</param>
        /// <param name="values">泛型类型集合</param>
        /// <returns></returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            return @this.Append(string.Join(separator, values));
        }

        /// <summary>
        /// 自定义扩展方法：使用分隔符将泛型类型数组中的元素串联起来，然后追加到扩展对象结尾
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">分隔符</param>
        /// <param name="values">泛型类型数组</param>
        /// <returns></returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
        {
            return @this.Append(string.Join(separator, values));
        }

        #endregion

        #region AppendLineJoin

        /// <summary>
        /// 自定义扩展方法：使用分隔符将泛型类型集合中的元素串联起来，然后追加到扩展对象结尾(带有换行符号)
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">分隔符</param>
        /// <param name="values">泛型类型集合</param>
        /// <returns></returns>
        public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            return @this.AppendLine(string.Join(separator, values));

        }

        /// <summary>
        /// 自定义扩展方法：使用分隔符将泛型类型数组中的元素串联起来，然后追加到扩展对象结尾(带有换行符号)
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="separator">分隔符</param>
        /// <param name="values">泛型类型数组</param>
        /// <returns></returns>
        public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
        {
            return @this.AppendLine(string.Join(separator, values));
        }

        #endregion
    }
}