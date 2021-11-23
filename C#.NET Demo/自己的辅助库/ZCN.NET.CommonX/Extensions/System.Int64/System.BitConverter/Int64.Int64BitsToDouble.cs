using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将指定 64 位有符号整数转换成双精度浮点数
        /// </summary>
        /// <param name="value">扩展对象。要转换的数字</param>
        /// <returns></returns>
        public static double Int64BitsToDouble(this Int64 value)
        {
            return BitConverter.Int64BitsToDouble(value);
        }
    }
}