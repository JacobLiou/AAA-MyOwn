namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 System.decimal 的值转换为等效的 8 位无符号整数。
        /// 如果参数小于 <see cref="F:System.Byte.MinValue" /> 或大于 <see cref="F:System.Byte.MaxValue" /> 则返回0
        /// </summary>
        /// <param name="value">扩展对象。大于 <see cref="F:System.Byte.MinValue" /> 或小于 <see cref="F:System.Byte.MaxValue" /></param>
        /// <returns>等效于 value 的 8 位无符号整数</returns>
        public static byte ToByte(this decimal value)
        {
            try
            {
                return decimal.ToByte(value);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 自定义扩展方法：将指定 System.decimal 的值转换为等效的 8 位有符号整数
        /// 如果参数小于 <see cref="F:System.SByte.MinValue" /> 或大于 <see cref="F:System.SByte.MaxValue" /> 则返回0
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>等效于 value 的 8 位有符号整数。大于 <see cref="F:System.SByte.MinValue" /> 或小于 <see cref="F:System.SByte.MaxValue" /></returns>
        public static sbyte ToSByte(this decimal value)
        {
            try
            {
                return decimal.ToSByte(value);
            }
            catch
            {
                return 0;
            }
        }
    }
}