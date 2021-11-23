using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {

        /// <summary>
        ///  自定义扩展方法：返回一个单精度浮点数的绝对值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Single Abs(this Single value)
        {
            return Math.Abs(value);
        }
    }
}