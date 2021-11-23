namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将字符串与字符数组的元素连接成一个字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="values">字符串实例的数组</param>
        /// <returns>A string.</returns>
        public static string ConcatWith(this string @this, params string[] values)
        {
            return string.Concat(@this, string.Concat(values));
        }
    }
}