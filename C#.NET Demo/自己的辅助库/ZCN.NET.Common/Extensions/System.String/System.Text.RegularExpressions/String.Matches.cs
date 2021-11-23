using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：在指定的输入字符串中搜索指定的正则表达式的所有匹配项
        /// </summary>
        /// <param name="input">要搜索匹配项的字符串</param>
        /// <param name="pattern">要匹配的正则表达式模式</param>
        /// <returns>搜索操作找到的 System.Text.RegularExpressions.Match 对象的集合</returns>
        public static MatchCollection Matches(this string input, string pattern)
        {
            return Regex.Matches(input, pattern);
        }

        /// <summary>
        ///  自定义扩展方法：在指定的输入字符串中搜索指定的正则表达式的所有匹配项
        /// </summary>
        /// <param name="input">要搜索匹配项的字符串</param>
        /// <param name="pattern">要匹配的正则表达式模式</param>
        /// <param name="options">枚举值的一个按位组合，这些枚举值提供匹配选项</param>
        /// <returns>搜索操作找到的 System.Text.RegularExpressions.Match 对象的集合</returns>
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
        {
            return Regex.Matches(input, pattern, options);
        }
    }
}