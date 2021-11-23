using System.Text.RegularExpressions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串是否匹配指定的模式
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="pattern">匹配默认</param>
        /// <returns></returns>
        public static bool IsLike(this string @this,string pattern)
        {
            string regexPattern = "^" + Regex.Escape(pattern) + "$";

            regexPattern = regexPattern.Replace(@"\[!","[^")
                                       .Replace(@"\[","[")
                                       .Replace(@"\]","]")
                                       .Replace(@"\?",".")
                                       .Replace(@"\*",".*")
                                       .Replace(@"\#",@"\d");

            return Regex.IsMatch(@this,regexPattern);
        }
    }
}