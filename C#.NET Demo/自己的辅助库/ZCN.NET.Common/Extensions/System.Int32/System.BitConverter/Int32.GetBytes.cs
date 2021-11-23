using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 以字节数组的形式返回指定的 32 位有符号整数值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static byte[] GetBytes(this Int32 value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}