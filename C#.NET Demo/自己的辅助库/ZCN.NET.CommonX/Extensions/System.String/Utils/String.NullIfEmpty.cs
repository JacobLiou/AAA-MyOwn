namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：如果扩展对象等于空字符串则返回null，否则返回本身
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string NullIfEmpty(this string @this)
        {
            return @this == "" ? null : @this;
        }

        /// <summary>
        ///  自定义扩展方法：如果扩展对象等于空白字符串则返回null，否则返回本身
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string NullIfWhiteSpace(this string @this)
        {
            return @this.TrimAll() == "" ? null : @this;
        }
    }
}