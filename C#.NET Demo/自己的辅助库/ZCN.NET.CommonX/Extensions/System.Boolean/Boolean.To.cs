using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：如果扩展对象的值为 true 则返回 trueValue；
        /// 如果扩展对象的值为 false 则返回 falseValue
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="trueValue">如果这个值为 true，则返回的真正值</param>
        /// <param name="falseValue">如果这个值是 false，则返回的false值</param>
        /// <returns></returns>
        public static string ToString2(this bool value, string trueValue = "true", string falseValue = "false")
        {
            return value ? trueValue : falseValue;
        }

        /// <summary>
        /// 自定义扩展方法：如果扩展对象的值为 true 则返回 trueValue；
        /// 如果扩展对象的值为 false 则返回 falseValue
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="trueValue">如果这个值为 true，则返回的真正值</param>
        /// <param name="falseValue">如果这个值是 false，则返回的false值</param>
        /// <returns></returns>
        public static string ToString2(this bool? value, string trueValue = "true", string falseValue = "false")
        {
            return value.ToBoolean() ? trueValue : falseValue;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 8 位无符号整数。
        /// 如果无法转换则返回 default(byte) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static byte ToByte(this bool value)
        {
            return !value ? (byte)0 : (byte)1; // Convert.ToByte(value); //内部实现
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 8 位带符号整数。
        /// 如果无法转换则返回 default(byte) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static sbyte ToSByte(this bool value)
        {
            return !value ? (sbyte)0 : (sbyte)1; // Convert.ToByte(value); //内部实现
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的十进制数。
        /// 如果无法转换则返回 default(decimal) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static decimal ToDecimal(this bool value)
        {
            return (Decimal)(value ? 1 : 0);
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的单精度浮点数。
        /// 如果无法转换则返回 default(float) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static float ToSingle(this bool value)
        {
            return value ? 1f : 0.0f;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的双精度浮点数。
        /// 如果无法转换则返回 default(double) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static double ToDouble(this bool value)
        {
            return value ? 1.0 : 0.0;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 16 位带符号整数。
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int16 ToInt16(this bool value)
        {
            return !value ? (short)0 : (short)1;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 16 位无符号整数。
        /// 如果无法转换则返回 default(ushort) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt16 ToUInt16(this bool value)
        {
            return !value ? (ushort)0 : (ushort)1;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 32 位带符号整数。
        /// 如果无法转换则返回 default(int) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int32 ToInt32(this bool value)
        {
            return !value ? 0 : 1;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 32 位无符号整数。
        /// 如果无法转换则返回 default(uint) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt32 ToUInt32(this bool value)
        {
            return !value ? 0U : 1U;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 64 位带符号整数。
        /// 如果无法转换则返回 default(long) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static Int64 ToInt64(this bool value)
        {
            return value ? 1L : 0L;
        }

        /// <summary>
        /// 自定义扩展方法：将指定布尔值转换为等效的 64 位无符号整数。
        /// 如果无法转换则返回 default(ulong) 值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns></returns>
        public static UInt64 ToUInt64(this bool value)
        {
            return !value ? 0UL : 1UL;
        }
    }
}