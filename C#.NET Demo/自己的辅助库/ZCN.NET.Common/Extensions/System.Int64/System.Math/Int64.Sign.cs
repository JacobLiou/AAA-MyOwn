using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回一个值，该值表示 64 位有符号整数的符号
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>一个指示 value 的符号的数字，如下表所示。返回值含义-1value 小于零。0value 等于零。1value 大于零</returns>
        public static Int64 Sign(this Int64 value)
        {
            return Math.Sign(value);
        }
    }
}