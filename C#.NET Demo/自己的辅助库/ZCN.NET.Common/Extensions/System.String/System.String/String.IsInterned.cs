using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 检索对指定 System.String 的引用
        /// </summary>
        /// <param name="str">要在暂存池中搜索的字符串</param>
        /// <returns> 如果 str 在公共语言运行时的暂存池中，则返回对它的引用；否则返回 null</returns>
        public static string IsInterned(this string str)
        {
            return String.IsInterned(str);
        }
    }
}