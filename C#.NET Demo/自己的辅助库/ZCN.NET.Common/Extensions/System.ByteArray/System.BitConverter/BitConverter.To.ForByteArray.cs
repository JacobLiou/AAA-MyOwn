using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的两个字节转换来的 Unicode 字符。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于 0，且小于数组减 2 的长度</param>
        /// <returns></returns>
        public static char ToChar(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(char);

            if ((uint)startIndex >= (uint)value.Length)
                return default(char);

            if (startIndex > value.Length - 2)
                return default(char);

            return BitConverter.ToChar(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的一个字节转换来的布尔值。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于 0，且小于数组减 1 的长度</param>
        /// <returns></returns>
        public static bool ToBoolean(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(bool);

            if (startIndex < 0)
                return default(bool);

            if (startIndex > value.Length - 1)
                return default(bool);

            return BitConverter.ToBoolean(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的四个字节转换来的单精度浮点数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于 0，且小于数组减 4 的长度</param>
        /// <returns></returns>
        public static float ToSingle(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(float);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(float);

            if (startIndex > value.Length - 4)
                return default(float);

            return BitConverter.ToSingle(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返返回由字节数组中指定位置的八个字节转换来的双精度浮点数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于 0，且小于数组减 8 的长度</param>
        /// <returns></returns>
        public static double ToDouble(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(double);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(double);

            if (startIndex > value.Length - 8)
                return default(double);

            return BitConverter.ToDouble(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的两个字节转换来的 16 位有符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减2的长度</param>
        /// <returns></returns>
        public static Int16 ToInt16(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(Int16);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(Int16);

            if (startIndex > value.Length - 2)
                return default(Int16);

            return BitConverter.ToInt16(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的两个字节转换来的 16 位无符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减2的长度</param>
        /// <returns></returns>
        public static UInt16 ToUInt16(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(UInt16);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(UInt16);

            if (startIndex > value.Length - 2)
                return default(UInt16);

            return BitConverter.ToUInt16(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的四个字节转换来的 32 位有符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减4的长度</param>
        /// <returns></returns>
        public static Int32 ToInt32(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(Int32);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(Int32);

            if (startIndex > value.Length - 4)
                return default(Int32);

            return BitConverter.ToInt32(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返回由字节数组中指定位置的四个字节转换来的 32 位无符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减4的长度</param>
        /// <returns></returns>
        public static UInt32 ToUInt32(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(UInt32);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(UInt32);

            if (startIndex > value.Length - 4)
                return default(UInt32);

            return BitConverter.ToUInt32(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返返回由字节数组中指定位置的八个字节转换来的 64 位有符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减8的长度</param>
        /// <returns></returns>
        public static Int64 ToInt64(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(Int64);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(Int64);

            if (startIndex > value.Length - 8)
                return default(Int64);

            return BitConverter.ToInt64(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：返返回由字节数组中指定位置的八个字节转换来的 64 位无符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减8的长度</param>
        /// <returns></returns>
        public static UInt64 ToUInt64(this byte[] value, int startIndex)
        {
            if (value == null)
                return default(UInt64);

            if ((long)(uint)startIndex >= (long)value.Length)
                return default(UInt64);

            if (startIndex > value.Length - 8)
                return default(UInt64);

            return BitConverter.ToUInt64(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：将指定的字节数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static string ToString2(this byte[] value)
        {
            if (value == null)
                return String.Empty;

            return BitConverter.ToString(value);
        }

        /// <summary>
        ///  自定义扩展方法：将指定的字节子数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减 1 的长度</param>
        /// <returns></returns>
        public static string ToString2(this byte[] value, int startIndex)
        {
            if (value == null)
                return String.Empty;

            return BitConverter.ToString(value, startIndex);
        }

        /// <summary>
        ///  自定义扩展方法：将指定的字节子数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="startIndex">起始位置。大于等于0，且小于数组减 1 的长度</param>
        /// <param name="length">要转换的数组中的数组元素数</param>
        /// <returns></returns>
        public static string ToString2(this byte[] value, int startIndex, int length)
        {
            if (value == null)
                return String.Empty;

            if (startIndex < 0 || startIndex >= value.Length && startIndex > 0)
                return String.Empty;

            if (length <= 0)
                return String.Empty;

            if (length > 715827882)
                return String.Empty;

            return BitConverter.ToString(value, startIndex, length);
        }
    }
}