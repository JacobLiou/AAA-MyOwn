using System.Linq;
using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字符串是否是回文字符串(顺读和倒读都一样)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>如果是回文则返回true，否则返回false</returns>
        public static bool IsPalindrome(this string @this)
        {
            var rgx = new Regex("[^a-zA-Z0-9]");
            @this = rgx.Replace(@this, "");
            return @this.SequenceEqual(@this.Reverse());
        }
    }
}