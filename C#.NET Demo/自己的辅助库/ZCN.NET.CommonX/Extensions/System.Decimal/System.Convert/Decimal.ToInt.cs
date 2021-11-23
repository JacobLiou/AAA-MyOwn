using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 16 位有符号整数。
        ///  如果参数 小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" />则返回 default(Int16)。
        /// </summary>
        /// <param name="value">扩展对象。 小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /></param>
        /// <returns> 等效于decimal值的 16 位有符号整数</returns>
        public static short ToShort(this decimal value)
        {
            if (value < Int16.MinValue || value > Int16.MaxValue)
                return default(Int16);

            return Decimal.ToInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 16 位无符号整数
        ///  如果参数 小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" />，则返回 default(UInt16)。
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /></param>
        /// <returns> 等效于decimal值的 16 位无符号整数</returns>
        public static ushort ToUShort(this decimal value)
        {
            if (value < UInt16.MinValue || value > UInt16.MaxValue)
                return default(UInt16);

            return Decimal.ToUInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 16 位有符号整数。
        ///  如果参数 小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" />则返回 default(Int16)。
        /// </summary>
        /// <param name="value">扩展对象。 小于 <see cref="F:System.Int16.MinValue" /> 或大于 <see cref="F:System.Int16.MaxValue" /></param>
        /// <returns> 等效于decimal值的 16 位有符号整数</returns>
        public static int ToInt16(this decimal value)
        {
            if (value < Int16.MinValue || value > Int16.MaxValue)
                return default(Int16);

            return Decimal.ToInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 16 位无符号整数
        ///  如果参数 小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" />，则返回 default(UInt16)。
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.UInt16.MinValue" /> 或大于 <see cref="F:System.UInt16.MaxValue" /></param>
        /// <returns> 等效于decimal值的 16 位无符号整数</returns>
        public static uint ToUInt16(this decimal value)
        {
            if (value < UInt16.MinValue || value > UInt16.MaxValue)
                return default(UInt16);

            return Decimal.ToUInt16(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 32 位有符号整数。
        ///  如果参数小于 Int32.MinValue 或大于 Int32.MaxValue，则返回 default(Int32)
        /// </summary>
        /// <returns> 等效于decimal值的 32 位有符号整数</returns>
        public static int ToInt32(this decimal value)
        {
            if (value < Int32.MinValue || value > Int32.MaxValue)
                return default(Int32); //0

            return Decimal.ToInt32(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 32 位无符号整数
        ///  如果参数小于 UInt32.MinValue 或大于 UInt32.MaxValue，则返回 default(UInt32)值
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.UInt32.MinValue" /> 或大于 <see cref="F:System.UInt32.MaxValue" /></param>
        /// <returns> 等效于decimal值的 32 位无符号整数</returns>
        public static uint ToUInt32(this decimal value)
        {
            if (value < UInt32.MinValue || value > UInt32.MaxValue)
                return default(UInt32); //0

            return Decimal.ToUInt32(value);
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 64 位有符号整数。
        ///  如果参数小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" />，则返回 default(Int64)
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /></param>
        /// <returns> 等效于decimal值的 64 位有符号整数</returns>
        public static long ToInt64(this decimal value)
        {
            if (value < Int64.MinValue || value > Int64.MaxValue)
                return default(Int64); //0

           return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 64 位无符号整数
        ///  如果参数小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" />，则返回 default(UInt64)
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /></param>
        /// <returns> 等效于decimal值的 64 位无符号整数</returns>
        public static long ToUInt64(this decimal value)
        {
            if (value < UInt64.MinValue || value > UInt64.MaxValue)
                return default(Int64); //0

            return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 64 位有符号整数
        ///  如果参数小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" />，则返回 default(Int64)
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.Int64.MinValue" /> 或大于 <see cref="F:System.Int64.MaxValue" /></param>
        /// <returns> 等效于decimal值的 64 位有符号整数</returns>
        public static long ToLong2(this decimal value)
        {
            if (value < Int64.MinValue || value > Int64.MaxValue)
                return default(Int64); //0

           return Decimal.ToInt64(Decimal.Round(value, 0));
        }

        /// <summary>
        ///  自定义扩展方法：将指定 System.decimal 值转换为等效的 64 位无符号整数
        ///  如果参数小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" />，则返回 default(UInt64)
        /// </summary>
        /// <param name="value">扩展对象。小于 <see cref="F:System.UInt64.MinValue" /> 或大于 <see cref="F:System.UInt64.MaxValue" /></param>
        /// <returns> 等效于decimal值的 64 位无符号整数</returns>
        public static ulong ToULong(this decimal value)
        {
            if (value < UInt64.MinValue || value > UInt64.MaxValue)
                return default(UInt64); //0

            return Decimal.ToUInt64(Decimal.Round(value, 0));
        }
    }
}