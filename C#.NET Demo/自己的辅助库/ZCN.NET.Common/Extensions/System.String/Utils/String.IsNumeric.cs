using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字符串是否仅包含0-9的数字
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNumeric(this string @this)
        {
            return !Regex.IsMatch(@this,"[^0-9]");
        }
    }
}