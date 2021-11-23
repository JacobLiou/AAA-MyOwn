using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：串联字符串数组的所有元素，其中在每个元素之间将指定分隔符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="separator">要用作分隔符的字符串</param>
        /// <param name="options">匹配选项</param>
        /// <returns></returns>
        public static string[] Split(this string str, string separator, RegexOptions options)
        {
            return Regex.Split(str, separator, options);
        }
    }
}
