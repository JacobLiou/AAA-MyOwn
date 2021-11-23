using System;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：从字符串中提取满足条件的字符
        /// </summary>
        /// <param name="this"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static string Extract(this string @this,Func<char,bool> predicate)
        {
            return new string(@this.ToCharArray().Where(predicate).ToArray());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取字母
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ExtractLetter(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => Char.IsLetter(x)).ToArray());
        }

        /// <summary>
        /// 自定义扩展方法：从字符串中提取数字
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ExtractNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => Char.IsNumber(x)).ToArray());
        }
    }
}