using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 检索系统对指定 System.String 的引用
        /// </summary>
        /// <param name="str">要在暂存池中搜索的字符串</param>
        /// <returns>如果暂存了 str，则返回系统对其的引用；否则返回对值为 str 的字符串的新引用</returns>
        public static string Intern(this String str)
        {
            return String.Intern(str);
        }
    }
}