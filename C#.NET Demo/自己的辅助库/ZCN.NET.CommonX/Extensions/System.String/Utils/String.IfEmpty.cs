namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：如果扩展对象为空字符串，返回默认值；否则返回本身
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>如果扩展对象不为空字符串，则返回本身；否则返回默认值</returns>
        public static string IfEmpty(this string @this,string defaultValue)
        {
            return @this.IsEmpty() ? defaultValue : @this;
        }
    }
}