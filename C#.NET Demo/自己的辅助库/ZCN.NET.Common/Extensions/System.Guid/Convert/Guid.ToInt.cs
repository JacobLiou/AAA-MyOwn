using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// summary>
        ///  自定义扩展方法：将 Guid 的值转换为字节数组,然后返回由字节数组中指定位置的四个字节转换来的 16 位有符号整数
        /// </summary>
        /// <param name="value">Guid value</param>
        /// <returns>Int32 value</returns>
        public static int ToInt16(this Guid value)
        {
            byte[] bytes = value.ToByteArray();
            return BitConverter.ToInt16(bytes, 0);
        }

        /// <summary>
        /// summary>
        ///  自定义扩展方法：将 Guid 的值转换为字节数组,然后返回由字节数组中指定位置的四个字节转换来的 32 位有符号整数
        /// </summary>
        /// <param name="value">Guid value</param>
        /// <returns>Int32 value</returns>
        public static int ToInt32(this Guid value)
        {
            byte[] bytes = value.ToByteArray();
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        ///  自定义扩展方法：将 Guid 的值转换为字节数组,然后返回由字节数组中指定位置的四个字节转换来的 64 位有符号整数
        /// </summary>
        /// <param name="value">Guid value</param>
        /// <returns>Int64 value</returns>
        public static long ToInt64(this Guid value)
        {
            byte[] bytes = value.ToByteArray();
            return BitConverter.ToInt64(bytes, 0);
        }
    }
}