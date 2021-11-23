using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 Unicode 字符。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static char ToChar(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(char);

            return BitConverter.ToChar(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为布尔值。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static bool ToBoolean(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(bool);

            return BitConverter.ToBoolean(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为单精度浮点数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static float ToSingle(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(float);

            return BitConverter.ToSingle(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为双精度浮点数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static double ToDouble(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(double);

            return BitConverter.ToDouble(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 16 位带符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int16 ToInt16(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(Int16);

            return BitConverter.ToInt16(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 16 位无符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt16 ToUInt16(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(UInt16);

            return BitConverter.ToUInt16(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 32 位带符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int32 ToInt32(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(Int32);

            return BitConverter.ToInt32(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 32 位无符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt32 ToUInt32(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(UInt32);

            return BitConverter.ToUInt32(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 64 位带符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int64 ToInt64(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(Int64);

            return BitConverter.ToInt64(value);
        }

        /// <summary>
        ///  自定义扩展方法：将只读字节范围转换为 64 位无符号整数
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt64 ToUInt64(this ReadOnlySpan<byte> value)
        {
            if (value == null)
                return default(UInt64);

            return BitConverter.ToUInt64(value);
        }
    }
}