using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 字符分类到由某个 System.Globalization.UnicodeCategory 值标识的组中
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }
    }
}