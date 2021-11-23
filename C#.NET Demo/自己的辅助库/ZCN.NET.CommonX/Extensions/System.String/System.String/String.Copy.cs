using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 创建一个与指定的 System.String 具有相同值的 System.String 的新实例
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns> 值与 str 相同的新字符串</returns>
        public static string Copy(this string str)
        {
            /* 从 .NET Core 3.0 开始，此方法已过时。 但是，我们不建议在任何.NET 实现中使用。
             * 特别是，由于 .NET Core 3.0 中的字符串暂存发生了更改，因此，在某些情况下，该 Copy 方法将不会创建新的字符串，而只会返回对现有暂存字符串的引用。
             * 请参考 https://docs.microsoft.com/zh-cn/dotnet/api/system.string.copy?view=net-5.0
             */
            return String.Copy(str);
        }
    }
}