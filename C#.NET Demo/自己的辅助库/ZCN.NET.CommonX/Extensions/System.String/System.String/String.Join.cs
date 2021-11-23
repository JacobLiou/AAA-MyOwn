namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region IEnumerable<T>的扩展方法 JoinWith 已经实现以下功能

        ///// <summary>
        ///// 自定义扩展方法：串联字符串数组的所有元素，其中在每个元素之间将指定分隔符
        ///// </summary>
        ///// <param name="values">一个数组，其中包含要连接的元素</param>
        ///// <param name="separator">要用作分隔符的字符串</param>
        ///// <returns> 一个由 value 中的元素组成的字符串，这些元素以 separator 字符串分隔</returns>
        //public static string Join(this string[] values,string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// 自定义扩展方法： 串联对象数组的各个元素，其中在每个元素之间将指定分隔符
        ///// </summary>
        ///// <param name="values">一个数组，其中包含要连接的元素</param>
        ///// <param name="separator">要用作分隔符的字符串</param>
        ///// <returns> 一个由 value 中的元素组成的字符串，这些元素以 separator 字符串分隔</returns>
        //public static string Join(this object[] values, string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// 自定义扩展方法： 串联字符串集合的成员，其中在每个成员之间将指定分隔符
        ///// </summary>
        ///// <typeparam name="T">泛型类型参数</typeparam>
        ///// <param name="values">一个数组，其中包含要连接的元素</param>
        ///// <param name="separator">要用作分隔符的字符串</param>
        ///// <returns> 一个由 value 中的元素组成的字符串，这些元素以 separator 字符串分隔</returns>
        //public static string Join<T>(this IEnumerable<T> values, string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// 自定义扩展方法： 串联类型为 System.string 的 System.Collections.Generic.IEnumerable`1 构造集合的成员，其中在每个成员之间将指定分隔符
        ///// </summary>
        ///// <param name="values">一个包含要串联的字符串的集合</param>
        ///// <param name="separator">要用作分隔符的字符串</param>
        ///// <returns> 一个由 values 的成员组成的字符串，这些成员以 separator 字符串分隔</returns>
        //public static string Join(this IEnumerable<string> values,string separator)
        //{
        //    return string.Join(separator, values);
        //}

        /// <summary>
        ///  自定义扩展方法：串联字符串数组的指定元素，其中在每个元素之间将指定分隔符
        /// </summary>
        /// <param name="values">一个包含要串联的字符串的集合</param>
        /// <param name="separator">要用作分隔符的字符串</param>
        /// <param name="startIndex">value 中要使用的第一个元素</param>
        /// <param name="count"> 要使用的 value 的元素数</param>
        /// <returns>由 value 中的字符串组成的字符串，这些字符串以 separator 字符串分隔。
        ///          如果 count 为零，value 没有元素，或 separator以及 value 的全部元素均为 System.string.Empty，则为 System.string.Empty
        /// </returns>
        public static string JoinWith(this string[] values,string separator, int startIndex, int count)
        {
            return string.Join(separator, values, startIndex, count);
        }

        #endregion
    }
}